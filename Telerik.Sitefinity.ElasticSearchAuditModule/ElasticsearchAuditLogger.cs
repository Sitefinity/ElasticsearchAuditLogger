using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using Nest;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Web.Events;
using Telerik.Sitefinity.AuditTrail;


namespace Telerik.Sitefinity.ElasticSearchAuditModule
{
    internal class ElasticsearchAuditLogger : IAuditLogger
    {
        public ElasticsearchAuditLogger()
        {
            var uri = new Uri(Config.Get<ElasticSearchConfig>().ElasticsearchUri);
            var setting = new ConnectionSettings(uri, IndexName);

            this.client = new ElasticClient(setting);
        }


        [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes",
            Justification = "We want to catch any exception that occurs and log it for further investigation.")]
        public void Log(IAuditInfo info)
        {
            try
            {
                if (info is IPagePreRenderCompleteEvent) return;

                if (info == null) return;
                
                this.client.Raw.Index(IndexName, AuditTypeFriendlyName, info.Fields);
            }
            catch (Exception e)
            {
                var exceptionMessage = new StringBuilder()
                .AppendLine("Error sending the audit information to Elasticsearch.")
                .AppendLine("Error details:")
                .Append(e.ToString())
                .ToString();
                Telerik.Sitefinity.Abstractions.Log.Write(exceptionMessage);
            }
        }

        private readonly ElasticClient client;
        private const string IndexName = "index";
        private const string AuditTypeFriendlyName = "AUDIT";        
    }
}
