﻿using Elastic.Clients.Elasticsearch;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
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
            var config = Config.Get<ElasticsearchAuditConfig>();
            var settings = new ElasticsearchClientSettings(new Uri(config.ElasticsearchUri));

            if (!string.IsNullOrWhiteSpace(config.Username) && !string.IsNullOrWhiteSpace(config.Password))
            {
                settings.Authentication(new BasicAuthentication(config.Username, config.Password));
            }

            this.client = new ElasticsearchClient(settings);
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
                
                var request = new IndexRequest<IDictionary<string, object>>(this.IndexName, new Id(Guid.NewGuid().ToString()));
                request.Document = info.Fields;
                this.client.Index(request);
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
                Config.Get<ElasticsearchAuditConfig>().IndexName = value;
            }
        }

        private readonly ElasticsearchClient client;
    }
}
