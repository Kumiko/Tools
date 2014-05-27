// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeModule.cs" company="Kumiko HB">
//   Copyright © Kumiko HB 2014
// </copyright>
// <summary>
//   Defines the HomeModule type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Kumiko.Tools.Web.Modules
{
    using Nancy;

    /// <summary>
    /// Defines the HomeModule type.
    /// </summary>
    public class HomeModule : NancyModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HomeModule"/> class.
        /// </summary>
        public HomeModule()
        {
            Get["/"] = parameters => View["Home"];
            Get["/guid"] = parameters => View["Guid"];
        }
    }
}