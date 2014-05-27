// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Kumiko HB">
//   Copyright © Kumiko HB 2014
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Kumiko.Tools.Web
{
    using System;
    using System.Configuration;
    using System.Linq;
    using System.Threading;

    using Nancy.Hosting.Self;

    /// <summary>
    /// Defines the Program type.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Start hosting the application.
        /// </summary>
        /// <param name="arguments">
        /// The arguments.
        /// </param>
        public static void Main(string[] arguments)
        {
            var url = new Uri(ConfigurationManager.AppSettings["HostUrl"]);

            var configuration = new HostConfiguration
            {
                UnhandledExceptionCallback = exception => Console.WriteLine(exception)
            };

            var host = new NancyHost(configuration, url);

            host.Start();

            if (arguments.Any(s => s.Equals("-d", StringComparison.CurrentCultureIgnoreCase)))
            {
                Thread.Sleep(Timeout.Infinite);
            }
            else
            {
                Console.WriteLine("Server running on {0}, press Enter to exit...", url);

                Console.ReadLine();
            }

            host.Stop();
        }
    }
}