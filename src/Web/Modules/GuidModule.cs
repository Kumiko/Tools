// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GuidModule.cs" company="Kumiko HB">
//   Copyright © Kumiko HB 2014
// </copyright>
// <summary>
//   Defines the GuidModule type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Kumiko.Tools.Web.Modules
{
    using System;

    using Nancy;

    /// <summary>
    /// Defines the GuidModule type.
    /// </summary>
    public class GuidModule : NancyModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GuidModule"/> class.
        /// </summary>
        public GuidModule()
        {
            Get["/api/guid/empty"] = parameters => new
            {
                N = Guid.Empty.ToString("N"),
                D = Guid.Empty.ToString("D"),
                B = Guid.Empty.ToString("B"),
                P = Guid.Empty.ToString("P"),
            };

            Get["/api/guid/new"] = parameters =>
            {
                var guid = Guid.NewGuid();

                return new
                {
                    N = guid.ToString("N"),
                    D = guid.ToString("D"),
                    B = guid.ToString("B"),
                    P = guid.ToString("P")
                };
            };

            Get["/api/guid/new-upper"] = parameters =>
            {
                var guid = Guid.NewGuid();

                return new
                {
                    N = guid.ToString("N").ToUpperInvariant(),
                    D = guid.ToString("D").ToUpperInvariant(),
                    B = guid.ToString("B").ToUpperInvariant(),
                    P = guid.ToString("P").ToUpperInvariant()
                };
            };
        }
    }
}