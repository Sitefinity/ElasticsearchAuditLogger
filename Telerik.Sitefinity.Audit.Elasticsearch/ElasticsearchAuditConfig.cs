using System;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using Telerik.Sitefinity.Configuration;
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

        /// <summary>
        /// Gets or sets a value indicating the name of the Elasticsearch index.
        /// </summary>        
        [ConfigurationProperty("IndexName", DefaultValue = "index")]
        [ObjectInfo(Title = "IndexName", Description = "The name of the Elasticsearch index")]
        public string IndexName
        {
            get
            {
                return (string)this["IndexName"];
            }

            set
            {
                this["IndexName"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the username
        /// </summary>        
        [ConfigurationProperty("Username")]
        [ObjectInfo(Title = "Username", Description = "The authentication username")]
        public string Username
        {
            get
            {
                return (string)this["Username"];
            }

            set
            {
                this["Username"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the password
        /// </summary>        
        [ConfigurationProperty("Password")]
        [ObjectInfo(Title = "Password", Description = "The authentication password")]
        [SecretData]
        public string Password
        {
            get
            {
                return (string)this["Password"];
            }

            set
            {
                this["Password"] = value;
            }
        }
    }
}
