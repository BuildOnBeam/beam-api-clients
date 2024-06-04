// <auto-generated>
/*
 * Beam game development API
 *
 * The Beam game development API is a service to integrate your game with Beam
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
using OpenAPIClientUtils = Beam.Client.ClientUtils;
using Beam.Client;

namespace Beam.Model
{
    /// <summary>
    /// TradeTokensRequestInputInitiator
    /// </summary>
    public partial class TradeTokensRequestInputInitiator : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeTokensRequestInputInitiator" /> class.
        /// </summary>
        /// <param name="entityId">entityId</param>
        /// <param name="tokens">tokens</param>
        [JsonConstructor]
        public TradeTokensRequestInputInitiator(string entityId, List<TradeTokensRequestInputInitiatorTokensInner> tokens)
        {
            EntityId = entityId;
            Tokens = tokens;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets EntityId
        /// </summary>
        [JsonPropertyName("entityId")]
        public string EntityId { get; set; }

        /// <summary>
        /// Gets or Sets Tokens
        /// </summary>
        [JsonPropertyName("tokens")]
        public List<TradeTokensRequestInputInitiatorTokensInner> Tokens { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TradeTokensRequestInputInitiator {\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  Tokens: ").Append(Tokens).Append("\n");
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
    /// A Json converter for type <see cref="TradeTokensRequestInputInitiator" />
    /// </summary>
    public class TradeTokensRequestInputInitiatorJsonConverter : JsonConverter<TradeTokensRequestInputInitiator>
    {
        /// <summary>
        /// Deserializes json to <see cref="TradeTokensRequestInputInitiator" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TradeTokensRequestInputInitiator Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> entityId = default;
            Option<List<TradeTokensRequestInputInitiatorTokensInner>?> tokens = default;

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
                        case "entityId":
                            entityId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "tokens":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                tokens = new Option<List<TradeTokensRequestInputInitiatorTokensInner>?>(JsonSerializer.Deserialize<List<TradeTokensRequestInputInitiatorTokensInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!entityId.IsSet)
                throw new ArgumentException("Property is required for class TradeTokensRequestInputInitiator.", nameof(entityId));

            if (!tokens.IsSet)
                throw new ArgumentException("Property is required for class TradeTokensRequestInputInitiator.", nameof(tokens));

            if (entityId.IsSet && entityId.Value == null)
                throw new ArgumentNullException(nameof(entityId), "Property is not nullable for class TradeTokensRequestInputInitiator.");

            if (tokens.IsSet && tokens.Value == null)
                throw new ArgumentNullException(nameof(tokens), "Property is not nullable for class TradeTokensRequestInputInitiator.");

            return new TradeTokensRequestInputInitiator(entityId.Value!, tokens.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="TradeTokensRequestInputInitiator" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="tradeTokensRequestInputInitiator"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TradeTokensRequestInputInitiator tradeTokensRequestInputInitiator, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, tradeTokensRequestInputInitiator, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TradeTokensRequestInputInitiator" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="tradeTokensRequestInputInitiator"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, TradeTokensRequestInputInitiator tradeTokensRequestInputInitiator, JsonSerializerOptions jsonSerializerOptions)
        {
            if (tradeTokensRequestInputInitiator.EntityId == null)
                throw new ArgumentNullException(nameof(tradeTokensRequestInputInitiator.EntityId), "Property is required for class TradeTokensRequestInputInitiator.");

            if (tradeTokensRequestInputInitiator.Tokens == null)
                throw new ArgumentNullException(nameof(tradeTokensRequestInputInitiator.Tokens), "Property is required for class TradeTokensRequestInputInitiator.");

            writer.WriteString("entityId", tradeTokensRequestInputInitiator.EntityId);

            writer.WritePropertyName("tokens");
            JsonSerializer.Serialize(writer, tradeTokensRequestInputInitiator.Tokens, jsonSerializerOptions);
        }
    }
}