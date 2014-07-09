using System;
using System.Configuration;
using System.Linq;
using Telerik.Sitefinity.Localization;
using Telerik.Sitefinity.Modules.GenericContent.Configuration;



namespace Telerik.Sitefinity.ElasticsearchAuditModule
{
    /// <summary>
    /// Represents the configuration section for ElasticSearch module.
    /// </summary>
    [ObjectInfo(Title = "ElasticSearch Config Title", Description = "ElasticSearch Config Description")]
    public class ElasticsearchConfig : ModuleConfigBase
    {
        /// <inheritdoc />
        protected override void InitializeDefaultProviders(Sitefinity.Configuration.ConfigElementDictionary<string, Sitefinity.Configuration.DataProviderSettings> providers)
        {
            
        }

        /// <summary>
        /// Gets or sets a value indicating the address of the ElasticSearch server.
        /// </summary>        
        [ConfigurationProperty("ElasticsearchUri", DefaultValue = "http://[::1]:9200/")]
        [ObjectInfo(Title = "ElasticSearchUri", Description = "The address of the Elasticsearch server")]
        public string ElasticsearchUri
        {
            get
            {
                return (string)this["ElasticsearchUri"];
            }

            set
            {
                this["ElasticsearchUri"] = value;
            }
        }
    }
}
