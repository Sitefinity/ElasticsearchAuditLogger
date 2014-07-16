using System;
using System.Linq;
using Telerik.Microsoft.Practices.Unity;
using Telerik.Sitefinity.Abstractions;
using Telerik.Sitefinity.AuditTrail;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Services;

namespace Telerik.Sitefinity.Audit.Elasticsearch
{
    /// <summary>
    /// Custom Sitefinity content module 
    /// </summary>
    public class ElasticsearchAuditModule : ModuleBase
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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Justification = "The settings argument is checked in the base method.")]
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
            else if (!isAuditTrailModuleRegistered && elasticSearchModule == null)
            {
                return;
            }

            App.WorkWith()
               .Module(settings.Name)
               .Initialize()
               .Configuration<ElasticsearchAuditConfig>();

            var container = ObjectFactory.Container;
            container.RegisterType<IAuditLogger, ElasticsearchAuditLogger>("ElasticsearchAuditLogger");
        }

        #endregion

        #region Public and overriden methods

        /// <inheritdoc />
        protected override ConfigSection GetModuleConfig()
        {
            return Config.Get<ElasticsearchAuditConfig>();
        }

        public override void Install(SiteInitializer initializer)
        {
        }

        #endregion

        #region Private members & constants

        public const string ModuleName = "ElasticsearchAudit";
        internal const string ModuleTitle = "Audit Trail - Elasticsearch";
        internal const string ModuleDescription = "Logs audit events to an Elasticsearch instance.";

        #endregion
    }
}
