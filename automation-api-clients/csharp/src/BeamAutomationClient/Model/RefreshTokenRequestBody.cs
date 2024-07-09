// <auto-generated>
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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = BeamAutomationClient.Client.ClientUtils;
using BeamAutomationClient.Client;

namespace BeamAutomationClient.Model
{
    /// <summary>
    /// RefreshTokenRequestBody
    /// </summary>
    public partial class RefreshTokenRequestBody : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshTokenRequestBody" /> class.
        /// </summary>
        /// <param name="assetAddress">assetAddress</param>
        /// <param name="tokenId">tokenId</param>
        /// <param name="chainId">chainId (default to 13337M)</param>
        [JsonConstructor]
        public RefreshTokenRequestBody(string assetAddress, string tokenId, Option<decimal?> chainId = default)
        {
            AssetAddress = assetAddress;
            TokenId = tokenId;
            ChainIdOption = chainId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets AssetAddress
        /// </summary>
        [JsonPropertyName("assetAddress")]
        public string AssetAddress { get; set; }

        /// <summary>
        /// Gets or Sets TokenId
        /// </summary>
        [JsonPropertyName("tokenId")]
        public string TokenId { get; set; }

        /// <summary>
        /// Used to track the state of ChainId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> ChainIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [JsonPropertyName("chainId")]
        public decimal? ChainId { get { return this. ChainIdOption; } set { this.ChainIdOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RefreshTokenRequestBody {\n");
            sb.Append("  AssetAddress: ").Append(AssetAddress).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="RefreshTokenRequestBody" />
    /// </summary>
    public class RefreshTokenRequestBodyJsonConverter : JsonConverter<RefreshTokenRequestBody>
    {
        /// <summary>
        /// Deserializes json to <see cref="RefreshTokenRequestBody" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override RefreshTokenRequestBody Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> assetAddress = default;
            Option<string?> tokenId = default;
            Option<decimal?> chainId = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "assetAddress":
                            assetAddress = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "tokenId":
                            tokenId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!assetAddress.IsSet)
                throw new ArgumentException("Property is required for class RefreshTokenRequestBody.", nameof(assetAddress));

            if (!tokenId.IsSet)
                throw new ArgumentException("Property is required for class RefreshTokenRequestBody.", nameof(tokenId));

            if (assetAddress.IsSet && assetAddress.Value == null)
                throw new ArgumentNullException(nameof(assetAddress), "Property is not nullable for class RefreshTokenRequestBody.");

            if (tokenId.IsSet && tokenId.Value == null)
                throw new ArgumentNullException(nameof(tokenId), "Property is not nullable for class RefreshTokenRequestBody.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class RefreshTokenRequestBody.");

            return new RefreshTokenRequestBody(assetAddress.Value!, tokenId.Value!, chainId);
        }

        /// <summary>
        /// Serializes a <see cref="RefreshTokenRequestBody" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="refreshTokenRequestBody"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, RefreshTokenRequestBody refreshTokenRequestBody, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, refreshTokenRequestBody, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="RefreshTokenRequestBody" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="refreshTokenRequestBody"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, RefreshTokenRequestBody refreshTokenRequestBody, JsonSerializerOptions jsonSerializerOptions)
        {
            if (refreshTokenRequestBody.AssetAddress == null)
                throw new ArgumentNullException(nameof(refreshTokenRequestBody.AssetAddress), "Property is required for class RefreshTokenRequestBody.");

            if (refreshTokenRequestBody.TokenId == null)
                throw new ArgumentNullException(nameof(refreshTokenRequestBody.TokenId), "Property is required for class RefreshTokenRequestBody.");

            writer.WriteString("assetAddress", refreshTokenRequestBody.AssetAddress);

            writer.WriteString("tokenId", refreshTokenRequestBody.TokenId);

            if (refreshTokenRequestBody.ChainIdOption.IsSet)
                writer.WriteNumber("chainId", refreshTokenRequestBody.ChainIdOption.Value!.Value);
        }
    }
}