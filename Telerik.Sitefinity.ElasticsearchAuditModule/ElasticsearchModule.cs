using System;
using System.Linq;
using Telerik.Microsoft.Practices.Unity;
using Telerik.Sitefinity.Abstractions;
using Telerik.Sitefinity.AuditTrail;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Services;

namespace Telerik.Sitefinity.ElasticsearchAuditModule
{
    /// <summary>
    /// Custom Sitefinity content module 
    /// </summary>
    public class ElasticsearchModule : ModuleBase
    {
        #region Properties
        /// <summary>
        /// Gets the landing page id for the module.
        /// </summary>
        /// <value>The landing page id.</value>
        public override Guid LandingPageId
        {
            get
            {
                return Guid.Empty;
            }
        }

        /// <summary>
        /// Gets the CLR types of all data managers provided by this module.
        /// </summary>
        /// <value>An array of <see cref="T:System.Type" /> objects.</value>
        public override Type[] Managers
        {
            get
            {
                return null;
            }
        }
        #endregion

        #region Module Initialization
        /// <summary>
        /// Initializes the service with specified settings.
        /// This method is called every time the module is initializing (on application startup by default)
        /// </summary>
        /// <param name="settings">The settings.</param>
        public override void Initialize(ModuleSettings settings)
        {
            base.Initialize(settings);            

            var configManager = ConfigManager.GetManager();
            var modulesConfig = configManager.GetSection<SystemConfig>().ApplicationModules;
            var elasticSearchModule = modulesConfig.Elements.Where(el => el.GetKey().Equals(ModuleName)).FirstOrDefault();
            bool isAuditTrailModuleRegistered = modulesConfig.Elements.Any(el => el.GetKey().Equals(AuditModule.ModuleName));
            if (!isAuditTrailModuleRegistered && elasticSearchModule != null)
            {
                modulesConfig.Remove(elasticSearchModule);
                configManager.SaveChanges();
                return;
            }
            else if(!isAuditTrailModuleRegistered && elasticSearchModule == null)
            {
                return;
            }

            App.WorkWith()
                .Module(settings.Name)
                    .Initialize()
                    .Localization<ElasticsearchResources>()
                    .Configuration<ElasticsearchConfig>();

            var container = ObjectFactory.Container;
            container.RegisterType<IAuditLogger, ElasticsearchAuditLogger>("ElasticSearchAuditLogger");
            
        }
        #endregion

        #region Public and overriden methods
        /// <summary>
        /// Gets the module configuration.
        /// </summary>
        protected override ConfigSection GetModuleConfig()
        {
            return Config.Get<ElasticsearchConfig>();
        }


        public override void Install(SiteInitializer initializer)
        {
            
        }
        #endregion                   

        #region Private members & constants
        public const string ModuleName = "ElasticsearchAuditModule";
        internal const string ModuleTitle = "ElasticsearchAuditModule";
        internal const string ModuleDescription = "Elasticsearch audit module logs events from Audit trail to ElasticSearch index, which could be monitored through Kibana.";
        #endregion

    }
}
