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
    public interface IPlayerContractApi : IPlayerApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        PlayerContractApiEvents Events { get; }

        /// <summary>
        /// Calls a readable contract function
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="contractAddress"></param>
        /// <param name="playerReadContractRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IReadContractApiResponse"/>&gt;</returns>
        Task<IReadContractApiResponse> ReadContractAsync(string contractAddress, PlayerReadContractRequest playerReadContractRequest, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Calls a readable contract function
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contractAddress"></param>
        /// <param name="playerReadContractRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IReadContractApiResponse"/>&gt;</returns>
        Task<IReadContractApiResponse> ReadContractOrDefaultAsync(string contractAddress, PlayerReadContractRequest playerReadContractRequest, System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The <see cref="IReadContractApiResponse"/>
    /// </summary>
    public interface IReadContractApiResponse : BeamPlayerClient.Client.IApiResponse, IOk<BeamPlayerClient.Model.PlayerReadContractResonse>, IHttpStatusCode4XX<BeamPlayerClient.Model.PlayerBeamErrorResponse>, IHttpStatusCode5XX<BeamPlayerClient.Model.PlayerBeamErrorResponse>
    {
        /// <summary>
        /// Returns true if the response is 200 Ok
        /// </summary>
        /// <returns></returns>
        bool IsOk { get; }

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
    public class PlayerContractApiEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs> OnReadContract;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs> OnErrorReadContract;

        internal void ExecuteOnReadContract(PlayerContractApi.ReadContractApiResponse apiResponse)
        {
            OnReadContract?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorReadContract(Exception exception)
        {
            OnErrorReadContract?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class PlayerContractApi : IPlayerContractApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger factory
        /// </summary>
        public ILoggerFactory LoggerFactory { get; }

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<PlayerContractApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public PlayerContractApiEvents Events { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<PlayerApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerContractApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PlayerContractApi(ILogger<PlayerContractApi> logger, ILoggerFactory loggerFactory, HttpClient httpClient, PlayerJsonSerializerOptionsProvider jsonSerializerOptionsProvider, PlayerContractApiEvents playerContractApiEvents,
            TokenProvider<PlayerApiKeyToken> apiKeyProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            LoggerFactory = loggerFactory;
            Logger = LoggerFactory.CreateLogger<PlayerContractApi>();
            HttpClient = httpClient;
            Events = playerContractApiEvents;
            ApiKeyProvider = apiKeyProvider;
        }

        partial void FormatReadContract(ref string contractAddress, PlayerReadContractRequest playerReadContractRequest);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="contractAddress"></param>
        /// <param name="playerReadContractRequest"></param>
        /// <returns></returns>
        private void ValidateReadContract(string contractAddress, PlayerReadContractRequest playerReadContractRequest)
        {
            if (contractAddress == null)
                throw new ArgumentNullException(nameof(contractAddress));

            if (playerReadContractRequest == null)
                throw new ArgumentNullException(nameof(playerReadContractRequest));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="contractAddress"></param>
        /// <param name="playerReadContractRequest"></param>
        private void AfterReadContractDefaultImplementation(IReadContractApiResponse apiResponseLocalVar, string contractAddress, PlayerReadContractRequest playerReadContractRequest)
        {
            bool suppressDefaultLog = false;
            AfterReadContract(ref suppressDefaultLog, apiResponseLocalVar, contractAddress, playerReadContractRequest);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="contractAddress"></param>
        /// <param name="playerReadContractRequest"></param>
        partial void AfterReadContract(ref bool suppressDefaultLog, IReadContractApiResponse apiResponseLocalVar, string contractAddress, PlayerReadContractRequest playerReadContractRequest);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="contractAddress"></param>
        /// <param name="playerReadContractRequest"></param>
        private void OnErrorReadContractDefaultImplementation(Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, string contractAddress, PlayerReadContractRequest playerReadContractRequest)
        {
            bool suppressDefaultLogLocalVar = false;
            OnErrorReadContract(ref suppressDefaultLogLocalVar, exceptionLocalVar, pathFormatLocalVar, pathLocalVar, contractAddress, playerReadContractRequest);
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
        /// <param name="contractAddress"></param>
        /// <param name="playerReadContractRequest"></param>
        partial void OnErrorReadContract(ref bool suppressDefaultLogLocalVar, Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, string contractAddress, PlayerReadContractRequest playerReadContractRequest);

        /// <summary>
        /// Calls a readable contract function 
        /// </summary>
        /// <param name="contractAddress"></param>
        /// <param name="playerReadContractRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IReadContractApiResponse"/>&gt;</returns>
        public async Task<IReadContractApiResponse> ReadContractOrDefaultAsync(string contractAddress, PlayerReadContractRequest playerReadContractRequest, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await ReadContractAsync(contractAddress, playerReadContractRequest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Calls a readable contract function 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="contractAddress"></param>
        /// <param name="playerReadContractRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IReadContractApiResponse"/>&gt;</returns>
        public async Task<IReadContractApiResponse> ReadContractAsync(string contractAddress, PlayerReadContractRequest playerReadContractRequest, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateReadContract(contractAddress, playerReadContractRequest);

                FormatReadContract(ref contractAddress, playerReadContractRequest);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/v1/contract/{contractAddress}/read";
                    uriBuilderLocalVar.Path = uriBuilderLocalVar.Path.Replace("%7BcontractAddress%7D", Uri.EscapeDataString(contractAddress.ToString()));

                    httpRequestMessageLocalVar.Content = (playerReadContractRequest as object) is System.IO.Stream stream
                        ? httpRequestMessageLocalVar.Content = new StreamContent(stream)
                        : httpRequestMessageLocalVar.Content = new StringContent(JsonSerializer.Serialize(playerReadContractRequest, _jsonSerializerOptions));

                    List<TokenBase> tokenBaseLocalVars = new List<TokenBase>();
                    PlayerApiKeyToken apiKeyTokenLocalVar1 = (PlayerApiKeyToken) await ApiKeyProvider.GetAsync("x-api-key", cancellationToken).ConfigureAwait(false);
                    tokenBaseLocalVars.Add(apiKeyTokenLocalVar1);
                    apiKeyTokenLocalVar1.UseInHeader(httpRequestMessageLocalVar);

                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] contentTypes = new string[] {
                        "application/json"
                    };

                    string contentTypeLocalVar = ClientUtils.SelectHeaderContentType(contentTypes);

                    if (contentTypeLocalVar != null && httpRequestMessageLocalVar.Content != null)
                        httpRequestMessageLocalVar.Content.Headers.ContentType = new MediaTypeHeaderValue(contentTypeLocalVar);

                    string[] acceptLocalVars = new string[] {
                        "application/json"
                    };

                    string acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));

                    httpRequestMessageLocalVar.Method = HttpMethod.Post;

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        ILogger<ReadContractApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<ReadContractApiResponse>();

                        ReadContractApiResponse apiResponseLocalVar = new(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/v1/contract/{contractAddress}/read", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterReadContractDefaultImplementation(apiResponseLocalVar, contractAddress, playerReadContractRequest);

                        Events.ExecuteOnReadContract(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorReadContractDefaultImplementation(e, "/v1/contract/{contractAddress}/read", uriBuilderLocalVar.Path, contractAddress, playerReadContractRequest);
                Events.ExecuteOnErrorReadContract(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="ReadContractApiResponse"/>
        /// </summary>
        public partial class ReadContractApiResponse : BeamPlayerClient.Client.ApiResponse, IReadContractApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<ReadContractApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="ReadContractApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public ReadContractApiResponse(ILogger<ReadContractApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
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
            public BeamPlayerClient.Model.PlayerReadContractResonse Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<BeamPlayerClient.Model.PlayerReadContractResonse>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk([NotNullWhen(true)]out BeamPlayerClient.Model.PlayerReadContractResonse result)
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
