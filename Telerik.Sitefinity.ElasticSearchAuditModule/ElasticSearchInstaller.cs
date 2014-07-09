using System;
using System.Linq;
using System.Reflection;
using Telerik.Sitefinity.Abstractions;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Data;
using Telerik.Sitefinity.Services;
using Telerik.Sitefinity.AuditTrail;

namespace Telerik.Sitefinity.ElasticsearchAuditModule
{
    /// <summary>
    /// Module installer class
    /// </summary>
    /// <remarks>
    /// This installer is registered in the /Properties/AssemblyInfo.cs file
    /// The purpose of it is to register the module in Sitefinity automatically.
    /// The User will have to enable the module from Administration -> Modules & Services
    /// </remarks>
    /// <see cref="http://www.sitefinity.com/blogs/peter-marinovs-blog/2013/03/20/creating-self-installing-widgets-and-modules-in-sitefinity"/>
    public static class ElasticsearchInstaller
    {
        #region Public methods
        /// <summary>
        /// Called before the application start.
        /// </summary>
        public static void PreApplicationStart()
        {
            Bootstrapper.Initialized += ElasticsearchInstaller.OnBootstrapperInitialized;
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Called when the Bootstrapper is initialized.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Telerik.Sitefinity.Data.ExecutedEventArgs" /> instance containing the event data.</param>
        private static void OnBootstrapperInitialized(object sender, ExecutedEventArgs e)
        {
            if (e.CommandName == "RegisterRoutes")
            {
                // We have to register the module at a very early stage when sitefinity is initializing
                ElasticsearchInstaller.RegisterModule();
            }
        }

        /// <summary>
        /// Registers the ElasticSearch module.
        /// </summary>
        private static void RegisterModule()
        {
            var configManager = ConfigManager.GetManager();
            var modulesConfig = configManager.GetSection<SystemConfig>().ApplicationModules;
            bool isElasticSearchModuleRegistered = modulesConfig.Elements.Any(el => el.GetKey().Equals(ElasticsearchModule.ModuleName));            
            if (!isElasticSearchModuleRegistered)
            {
                modulesConfig.Add(ElasticsearchModule.ModuleName, new AppModuleSettings(modulesConfig)
                {
                    Name = ElasticsearchModule.ModuleName,
                    Title = ElasticsearchModule.ModuleTitle,
                    Description = ElasticsearchModule.ModuleDescription,
                    Type = typeof(ElasticsearchModule).AssemblyQualifiedName,                    
                    StartupType = StartupType.Disabled
                });

                configManager.SaveSection(modulesConfig.Section);
            }
        }
        #endregion
    }
}
