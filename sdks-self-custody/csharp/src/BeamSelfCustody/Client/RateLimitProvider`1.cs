// <auto-generated>
/*
 * Beam self custody API
 *
 * The Beam self custody API is a service to integrate your game with Beam
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Threading.Channels;

namespace BeamSelfCustody.Client 
{
    /// <summary>
    /// Provides a token to the api clients. Tokens will be rate limited based on the provided TimeSpan.
    /// </summary>
    /// <typeparam name="TTokenBase"></typeparam>
    [Obsolete("Please use SimpleApiKeyTokenProvider instead. This might result in CPU usage leaking in high throughput situations!")]
    public class RateLimitProvider<TTokenBase> : TokenProvider<TTokenBase> where TTokenBase : TokenBase
    {
        internal Channel<TTokenBase> AvailableTokens { get; set; }

        /// <summary>
        /// Instantiates a ThrottledTokenProvider. Your tokens will be rate limited based on the token's timeout.
        /// </summary>
        /// <param name="container"></param>
        public RateLimitProvider(TokenContainer<TTokenBase> container) : base(container.Tokens)
        {
            foreach(TTokenBase token in _tokens)
                token.StartTimer(token.Timeout ?? TimeSpan.FromMilliseconds(40));

            BoundedChannelOptions options = new BoundedChannelOptions(_tokens.Length)
            {
                FullMode = BoundedChannelFullMode.DropWrite
            };

            AvailableTokens = Channel.CreateBounded<TTokenBase>(options);

            for (int i = 0; i < _tokens.Length; i++)
                _tokens[i].TokenBecameAvailable += ((sender) => AvailableTokens.Writer.TryWrite((TTokenBase) sender));
        }

        public override async System.Threading.Tasks.ValueTask<TTokenBase> GetAsync(string header = "x-api-key", System.Threading.CancellationToken cancellation = default)
            => await AvailableTokens.Reader.ReadAsync(cancellation).ConfigureAwait(false);


        /// <summary>
        /// Sets the new token as a single token for the provider.
        /// </summary>
        public override void SetToken(TTokenBase newToken)
        {
            _tokens = new TTokenBase[1] { newToken };

            newToken.StartTimer(newToken.Timeout ?? TimeSpan.FromMilliseconds(40));

            BoundedChannelOptions options = new BoundedChannelOptions(_tokens.Length)
            {
                FullMode = BoundedChannelFullMode.DropWrite
            };

            AvailableTokens = Channel.CreateBounded<TTokenBase>(options);
            AvailableTokens.Writer.TryWrite(newToken);
        }
    }
} 
