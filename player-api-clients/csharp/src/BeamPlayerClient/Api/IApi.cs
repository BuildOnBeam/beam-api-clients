using System.Net.Http;
using BeamPlayerClient.Client;

namespace BeamPlayerClient.Api
{
    /// <summary>
    /// Any Api client
    /// </summary>
    public interface IPlayerApi
    {
        /// <summary>
        /// The HttpClient
        /// </summary>
        HttpClient HttpClient { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        TokenProvider<PlayerApiKeyToken> ApiKeyProvider { get; }
    }
}