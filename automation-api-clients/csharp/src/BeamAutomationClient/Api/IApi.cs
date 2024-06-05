using System.Net.Http;
using BeamAutomationClient.Client;

namespace BeamAutomationClient.Api
{
    /// <summary>
    /// Any Api client
    /// </summary>
    public interface IApi
    {
        /// <summary>
        /// The HttpClient
        /// </summary>
        HttpClient HttpClient { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        TokenProvider<ApiKeyToken> ApiKeyProvider { get; }
    }
}