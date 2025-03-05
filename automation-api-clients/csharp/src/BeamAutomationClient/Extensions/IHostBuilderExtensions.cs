/*
 * Automation API
 *
 * The Automation API is a service to integrate your game with Beam
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BeamAutomationClient.Client;

namespace BeamAutomationClient.Extensions
{
    /// <summary>
    /// Extension methods for IHostBuilder
    /// </summary>
    public static class IHostBuilderExtensions
    {
        /// <summary>
        /// Add the api to your host builder.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="options"></param>
        [Obsolete("Use ConfigureBeamAutomationApi")]
        public static IHostBuilder ConfigureApi(this IHostBuilder builder, Action<HostBuilderContext, IServiceCollection, AutomationHostConfiguration> options)
        {
            builder.ConfigureServices((context, services) =>
            {
                AutomationHostConfiguration config = new AutomationHostConfiguration(services);

                options(context, services, config);

                IServiceCollectionExtensions.AddBeamAutomationApi(services, config);
            });

            return builder;
        }

        /// <summary>
        /// Add the api to your host builder.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="options"></param>
        public static IHostBuilder ConfigureBeamAutomationApi(this IHostBuilder builder, Action<HostBuilderContext, IServiceCollection, AutomationHostConfiguration> options)
        {
            builder.ConfigureServices((context, services) =>
            {
                AutomationHostConfiguration config = new AutomationHostConfiguration(services);

                options(context, services, config);

                IServiceCollectionExtensions.AddBeamAutomationApi(services, config);
            });

            return builder;
        }
    }
}