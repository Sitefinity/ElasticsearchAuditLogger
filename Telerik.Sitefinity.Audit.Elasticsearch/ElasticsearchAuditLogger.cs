using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using Nest;
using Telerik.Sitefinity.AuditTrail;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Web.Events;

namespace Telerik.Sitefinity.Audit.Elasticsearch
{
    /// <summary>
    /// The Audit logger that logs data to Elasticsearch
    /// </summary>
    public class ElasticsearchAuditLogger : IAuditLogger
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElasticsearchAuditLogger"/> class.
        /// </summary>
        public ElasticsearchAuditLogger()
        {
            var uri = new Uri(Config.Get<ElasticsearchAuditConfig>().ElasticsearchUri);            
            var setting = new ConnectionSettings(uri, this.IndexName);

            this.client = new ElasticClient(setting);
        }

        /// <summary>
        /// Logs the specified info.
        /// </summary>
        /// <param name="info">The info.</param>
        [SuppressMessage("Microsoft.Design", "CA1031",
            Justification = "We want to catch any exception that occurs and log it for further investigation.")]
        public void Log(IAuditInfo info)
        {
            try
            {
                if (info is IPagePreRenderCompleteEvent) return;

                if (info == null) return;
                
                this.client.Raw.Index(this.IndexName, AuditTypeFriendlyName, info.Fields);
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

        public string IndexName
        {
            get
            {
                return Config.Get<ElasticsearchAuditConfig>().IndexName;
            }
            set
            {
                Config.Get<ElasticsearchAuditConfig>().IndexName=value;
            }
        }


        private readonly ElasticClient client;        
        private const string AuditTypeFriendlyName = "AUDIT";        
    }
}
