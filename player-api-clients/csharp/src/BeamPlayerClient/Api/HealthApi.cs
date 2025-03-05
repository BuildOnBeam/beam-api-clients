// <auto-generated>
/*
 * Player API
 *
 * The Player API is a service to integrate your game with Beam
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using BeamPlayerClient.Client;
using BeamPlayerClient.Model;
using System.Diagnostics.CodeAnalysis;

namespace BeamPlayerClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// This class is registered as transient.
    /// </summary>
    public interface IPlayerHealthApi : IPlayerApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        PlayerHealthApiEvents Events { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ICheckApiResponse"/>&gt;</returns>
        Task<ICheckApiResponse> CheckAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ICheckApiResponse"/>&gt;</returns>
        Task<ICheckApiResponse> CheckOrDefaultAsync(System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The <see cref="ICheckApiResponse"/>
    /// </summary>
    public interface ICheckApiResponse : BeamPlayerClient.Client.IApiResponse, IOk<BeamPlayerClient.Model.Check200Response>, IServiceUnavailable<BeamPlayerClient.Model.Check503Response>, IHttpStatusCode4XX<BeamPlayerClient.Model.PlayerBeamErrorResponse>, IHttpStatusCode5XX<BeamPlayerClient.Model.PlayerBeamErrorResponse>
    {
        /// <summary>
        /// Returns true if the response is 200 Ok
        /// </summary>
        /// <returns></returns>
        bool IsOk { get; }

        /// <summary>
        /// Returns true if the response is 503 ServiceUnavailable
        /// </summary>
        /// <returns></returns>
        bool IsServiceUnavailable { get; }

        /// <summary>
        /// Returns true if the response is 4XX HttpStatusCode4XX
        /// </summary>
        /// <returns></returns>
        bool IsHttpStatusCode4XX { get; }

        /// <summary>
        /// Returns true if the response is 5XX HttpStatusCode5XX
        /// </summary>
        /// <returns></returns>
        bool IsHttpStatusCode5XX { get; }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PlayerHealthApiEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs> OnCheck;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs> OnErrorCheck;

        internal void ExecuteOnCheck(PlayerHealthApi.CheckApiResponse apiResponse)
        {
            OnCheck?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorCheck(Exception exception)
        {
            OnErrorCheck?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class PlayerHealthApi : IPlayerHealthApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger factory
        /// </summary>
        public ILoggerFactory LoggerFactory { get; }

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<PlayerHealthApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public PlayerHealthApiEvents Events { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<PlayerApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerHealthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PlayerHealthApi(ILogger<PlayerHealthApi> logger, ILoggerFactory loggerFactory, HttpClient httpClient, PlayerJsonSerializerOptionsProvider jsonSerializerOptionsProvider, PlayerHealthApiEvents playerHealthApiEvents,
            TokenProvider<PlayerApiKeyToken> apiKeyProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            LoggerFactory = loggerFactory;
            Logger = LoggerFactory.CreateLogger<PlayerHealthApi>();
            HttpClient = httpClient;
            Events = playerHealthApiEvents;
            ApiKeyProvider = apiKeyProvider;
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        private void AfterCheckDefaultImplementation(ICheckApiResponse apiResponseLocalVar)
        {
            bool suppressDefaultLog = false;
            AfterCheck(ref suppressDefaultLog, apiResponseLocalVar);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        partial void AfterCheck(ref bool suppressDefaultLog, ICheckApiResponse apiResponseLocalVar);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        private void OnErrorCheckDefaultImplementation(Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar)
        {
            bool suppressDefaultLogLocalVar = false;
            OnErrorCheck(ref suppressDefaultLogLocalVar, exceptionLocalVar, pathFormatLocalVar, pathLocalVar);
            if (!suppressDefaultLogLocalVar)
                Logger.LogError(exceptionLocalVar, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// A partial method that gives developers a way to provide customized exception handling
        /// </summary>
        /// <param name="suppressDefaultLogLocalVar"></param>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        partial void OnErrorCheck(ref bool suppressDefaultLogLocalVar, Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar);

        /// <summary>
        ///  
        /// </summary>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ICheckApiResponse"/>&gt;</returns>
        public async Task<ICheckApiResponse> CheckOrDefaultAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await CheckAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ICheckApiResponse"/>&gt;</returns>
        public async Task<ICheckApiResponse> CheckAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/v1/health/services";

                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] acceptLocalVars = new string[] {
                        "application/json"
                    };

                    string acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));

                    httpRequestMessageLocalVar.Method = HttpMethod.Get;

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        ILogger<CheckApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<CheckApiResponse>();

                        CheckApiResponse apiResponseLocalVar = new(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/v1/health/services", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterCheckDefaultImplementation(apiResponseLocalVar);

                        Events.ExecuteOnCheck(apiResponseLocalVar);

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorCheckDefaultImplementation(e, "/v1/health/services", uriBuilderLocalVar.Path);
                Events.ExecuteOnErrorCheck(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="CheckApiResponse"/>
        /// </summary>
        public partial class CheckApiResponse : BeamPlayerClient.Client.ApiResponse, ICheckApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<CheckApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="CheckApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public CheckApiResponse(ILogger<CheckApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
            {
                Logger = logger;
                OnCreated(httpRequestMessage, httpResponseMessage);
            }

            partial void OnCreated(global::System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage);

            /// <summary>
            /// Returns true if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public bool IsOk => 200 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public BeamPlayerClient.Model.Check200Response Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<BeamPlayerClient.Model.Check200Response>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk([NotNullWhen(true)]out BeamPlayerClient.Model.Check200Response result)
            {
                result = null;

                try
                {
                    result = Ok();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)200);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 503 ServiceUnavailable
            /// </summary>
            /// <returns></returns>
            public bool IsServiceUnavailable => 503 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 503 ServiceUnavailable
            /// </summary>
            /// <returns></returns>
            public BeamPlayerClient.Model.Check503Response ServiceUnavailable()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsServiceUnavailable
                    ? System.Text.Json.JsonSerializer.Deserialize<BeamPlayerClient.Model.Check503Response>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 503 ServiceUnavailable and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryServiceUnavailable([NotNullWhen(true)]out BeamPlayerClient.Model.Check503Response result)
            {
                result = null;

                try
                {
                    result = ServiceUnavailable();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)503);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 4XX HttpStatusCode4XX
            /// </summary>
            /// <returns></returns>
            public bool IsHttpStatusCode4XX
            {
                get
                {
                    int statusCode = (int)StatusCode;
                    return 400 >= statusCode && 499 <= statusCode;
                }
            }

            /// <summary>
            /// Deserializes the response if the response is 4XX HttpStatusCode4XX
            /// </summary>
            /// <returns></returns>
            public BeamPlayerClient.Model.PlayerBeamErrorResponse HttpStatusCode4XX()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsHttpStatusCode4XX
                    ? System.Text.Json.JsonSerializer.Deserialize<BeamPlayerClient.Model.PlayerBeamErrorResponse>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 4XX HttpStatusCode4XX and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryHttpStatusCode4XX([NotNullWhen(true)]out BeamPlayerClient.Model.PlayerBeamErrorResponse result)
            {
                result = null;

                try
                {
                    result = HttpStatusCode4XX();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)4);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 5XX HttpStatusCode5XX
            /// </summary>
            /// <returns></returns>
            public bool IsHttpStatusCode5XX
            {
                get
                {
                    int statusCode = (int)StatusCode;
                    return 500 >= statusCode && 599 <= statusCode;
                }
            }

            /// <summary>
            /// Deserializes the response if the response is 5XX HttpStatusCode5XX
            /// </summary>
            /// <returns></returns>
            public BeamPlayerClient.Model.PlayerBeamErrorResponse HttpStatusCode5XX()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsHttpStatusCode5XX
                    ? System.Text.Json.JsonSerializer.Deserialize<BeamPlayerClient.Model.PlayerBeamErrorResponse>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 5XX HttpStatusCode5XX and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryHttpStatusCode5XX([NotNullWhen(true)]out BeamPlayerClient.Model.PlayerBeamErrorResponse result)
            {
                result = null;

                try
                {
                    result = HttpStatusCode5XX();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)5);
                }

                return result != null;
            }

            private void OnDeserializationErrorDefaultImplementation(Exception exception, HttpStatusCode httpStatusCode)
            {
                bool suppressDefaultLog = false;
                OnDeserializationError(ref suppressDefaultLog, exception, httpStatusCode);
                if (!suppressDefaultLog)
                    Logger.LogError(exception, "An error occurred while deserializing the {code} response.", httpStatusCode);
            }

            partial void OnDeserializationError(ref bool suppressDefaultLog, Exception exception, HttpStatusCode httpStatusCode);
        }
    }
}
