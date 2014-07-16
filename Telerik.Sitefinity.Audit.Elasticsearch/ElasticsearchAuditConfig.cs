using System;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using Telerik.Sitefinity.Localization;
using Telerik.Sitefinity.Modules.GenericContent.Configuration;

namespace Telerik.Sitefinity.Audit.Elasticsearch
{
    /// <summary>
    /// Represents the configuration section for Elasticsearch module.
    /// </summary>
    [ObjectInfo(Title = "Elasticsearch Config Title", Description = "Elasticsearch Config Description")]
    public class ElasticsearchAuditConfig : ModuleConfigBase
    {
        /// <inheritdoc />
        protected override void InitializeDefaultProviders(Sitefinity.Configuration.ConfigElementDictionary<string, Sitefinity.Configuration.DataProviderSettings> providers)
        {
        }

        /// <summary>
        /// Gets or sets a value indicating the address of the Elasticsearch server.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1056", Justification = "Sitefinity configuration does not support System.Uri in serialization.")]
        [ConfigurationProperty("ElasticsearchUri", DefaultValue = "http://localhost:9200/")]
        [ObjectInfo(Title = "ElasticsearchUri", Description = "The address of the Elasticsearch server")]
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
