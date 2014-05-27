// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Bootstrapper.cs" company="Kumiko HB">
//   Copyright © Kumiko HB 2014
// </copyright>
// <summary>
//   Defines the Bootstrapper type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Kumiko.Tools.Web
{
    using System;
    using System.Configuration;

    using Nancy;
    using Nancy.Conventions;

    /// <summary>
    /// Defines the Bootstrapper type.
    /// </summary>
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        /// <summary>
        /// The root path provider.
        /// </summary>
        private readonly Lazy<IRootPathProvider> _rootPathProvider = new Lazy<IRootPathProvider>(() => new AppConfigRootPathProvider());

        /// <summary>
        /// Gets the root path provider
        /// </summary>
        protected override IRootPathProvider RootPathProvider
        {
            get
            {
                return _rootPathProvider.Value;
            }
        }

        /// <summary>
        /// Overrides/configures Nancy's conventions
        /// </summary>
        /// <param name="nancyConventions">
        /// Convention object instance
        /// </param>
        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            base.ConfigureConventions(nancyConventions);

            nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("Content", "Content"));
            nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("Scripts", "Scripts"));
        }

        /// <summary>
        /// Defines the AppConfigRootPathProvider type.
        /// </summary>
        private class AppConfigRootPathProvider : IRootPathProvider
        {
            /// <summary>
            /// Returns the root folder path of the current Nancy application.
            /// </summary>
            /// <returns>
            /// A <see cref="T:System.String"/> containing the path of the root folder.
            /// </returns>
            public string GetRootPath()
            {
                return ConfigurationManager.AppSettings["RootPath"];
            }
        }
    }
}