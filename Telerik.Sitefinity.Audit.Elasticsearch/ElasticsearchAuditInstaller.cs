using System;
using System.Linq;
using Telerik.Sitefinity.Abstractions;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Data;
using Telerik.Sitefinity.Services;

namespace Telerik.Sitefinity.Audit.Elasticsearch
{
    /// <summary>
    /// Module installer class
    /// </summary>
    /// <remarks>
    /// This installer is registered in the /Properties/AssemblyInfo.cs file
    /// The purpose of it is to register the module in Sitefinity automatically.
    /// The User will have to enable the module from Administration -> Modules &amp; Services
    /// </remarks>
    /// <a href="http://www.sitefinity.com/blogs/peter-marinovs-blog/2013/03/20/creating-self-installing-widgets-and-modules-in-sitefinity">Creating Self installing Widgets And Modules In Sitefinity</a>
    public static class ElasticsearchAuditInstaller
    {
        #region Public methods
        /// <summary>
        /// Called before the application start.
        /// </summary>
        public static void PreApplicationStart()
        {
            Bootstrapper.Initialized += ElasticsearchAuditInstaller.OnBootstrapperInitialized;
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
                ElasticsearchAuditInstaller.RegisterModule();
            }
        }

        /// <summary>
        /// Registers the Elasticsearch module.
        /// </summary>
        private static void RegisterModule()
        {
            var configManager = ConfigManager.GetManager();
            var modulesConfig = configManager.GetSection<SystemConfig>().ApplicationModules;
            bool isElasticsearchModuleRegistered = modulesConfig.Elements.Any(el => el.GetKey().Equals(ElasticsearchAuditModule.ModuleName));
            if (!isElasticsearchModuleRegistered)
            {
                modulesConfig.Add(ElasticsearchAuditModule.ModuleName, new AppModuleSettings(modulesConfig)
                {
                    Name = ElasticsearchAuditModule.ModuleName,
                    Title = ElasticsearchAuditModule.ModuleTitle,
                    Description = ElasticsearchAuditModule.ModuleDescription,
                    Type = typeof(ElasticsearchAuditModule).AssemblyQualifiedName,
                    StartupType = StartupType.Disabled
                });

                configManager.SaveSection(modulesConfig.Section);
            }
        }
        #endregion
    }
}
