/*
 * Player API
 *
 * The Player API is a service to integrate your game with Beam
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using BeamPlayerClient.Client;

namespace BeamPlayerClient.Extensions
{
    /// <summary>
    /// Extension methods for IServiceCollection
    /// </summary>
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Add the api to your host builder.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="options"></param>
        public static void AddBeamPlayerApi(this IServiceCollection services, Action<PlayerHostConfiguration> options)
        {
            PlayerHostConfiguration config = new(services);
            options(config);
            AddBeamPlayerApi(services, config);
        }

        /// <summary>
        /// Add the api to your host builder.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="options"></param>
        [Obsolete("Use AddBeamPlayerApi")]
        public static void AddApi(this IServiceCollection services, Action<PlayerHostConfiguration> options)
        {
            PlayerHostConfiguration config = new(services);
            options(config);
            AddBeamPlayerApi(services, config);
        }

        internal static void AddBeamPlayerApi(IServiceCollection services, PlayerHostConfiguration host)
        {
            if (!host.HttpClientsAdded)
                host.AddBeamPlayerApiHttpClients();

            services.AddSingleton<CookieContainer>();

            services.AddSingleton<SimpleApiKeyTokenProvider<PlayerApiKeyToken>>();
            services.AddTransient(typeof(TokenProvider<>).MakeGenericType(typeof(PlayerApiKeyToken)),
                        s => s.GetRequiredService(typeof(SimpleApiKeyTokenProvider<>).MakeGenericType(typeof(PlayerApiKeyToken))));
        }
    }
}