/*
 * Automation API
 *
 * The Automation API is a service to integrate your game with Beam
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Polly.Timeout;
using Polly.Extensions.Http;
using Polly;

namespace BeamAutomationClient.Extensions
{
    /// <summary>
    /// Extension methods for IHttpClientBuilder
    /// </summary>
    public static class IHttpClientBuilderExtensions
    {
        /// <summary>
        /// Adds a Polly retry policy to your clients.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="retries"></param>
        /// <returns></returns>
        public static IHttpClientBuilder AddAutomationRetryPolicy(this IHttpClientBuilder client, int retries)
        {
            client.AddPolicyHandler(RetryPolicy(retries));

            return client;
        }

        /// <summary>
        /// Adds a Polly timeout policy to your clients.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public static IHttpClientBuilder AddAutomationTimeoutPolicy(this IHttpClientBuilder client, TimeSpan timeout)
        {
            client.AddPolicyHandler(TimeoutPolicy(timeout));

            return client;
        }

        /// <summary>
        /// Adds a Polly circuit breaker to your clients.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="handledEventsAllowedBeforeBreaking"></param>
        /// <param name="durationOfBreak"></param>
        /// <returns></returns>
        public static IHttpClientBuilder AddAutomationCircuitBreakerPolicy(this IHttpClientBuilder client, int handledEventsAllowedBeforeBreaking, TimeSpan durationOfBreak)
        {
            client.AddTransientHttpErrorPolicy(builder => CircuitBreakerPolicy(builder, handledEventsAllowedBeforeBreaking, durationOfBreak));

            return client;
        }

        private static Polly.Retry.AsyncRetryPolicy<HttpResponseMessage> RetryPolicy(int retries)
            => HttpPolicyExtensions
                .HandleTransientHttpError()
                .Or<TimeoutRejectedException>()
                .RetryAsync(retries);

        private static AsyncTimeoutPolicy<HttpResponseMessage> TimeoutPolicy(TimeSpan timeout)
            => Policy.TimeoutAsync<HttpResponseMessage>(timeout);

        private static Polly.CircuitBreaker.AsyncCircuitBreakerPolicy<HttpResponseMessage> CircuitBreakerPolicy(
            PolicyBuilder<HttpResponseMessage> builder, int handledEventsAllowedBeforeBreaking, TimeSpan durationOfBreak)
                => builder.CircuitBreakerAsync(handledEventsAllowedBeforeBreaking, durationOfBreak);
    }
}
