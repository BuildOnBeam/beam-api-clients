// <auto-generated>
/*
 * Player API
 *
 * The Player API is a service to integrate your game with Beam
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
using OpenAPIClientUtils = BeamPlayerClient.Client.ClientUtils;
using BeamPlayerClient.Client;

namespace BeamPlayerClient.Model
{
    /// <summary>
    /// GetQuoteResponse
    /// </summary>
    public partial class GetQuoteResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetQuoteResponse" /> class.
        /// </summary>
        /// <param name="amountIn">amountIn</param>
        /// <param name="amountOut">amountOut</param>
        /// <param name="tokenIn">tokenIn</param>
        /// <param name="tokenOut">tokenOut</param>
        [JsonConstructor]
        public GetQuoteResponse(string amountIn, string amountOut, string tokenIn, string tokenOut)
        {
            AmountIn = amountIn;
            AmountOut = amountOut;
            TokenIn = tokenIn;
            TokenOut = tokenOut;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets AmountIn
        /// </summary>
        [JsonPropertyName("amountIn")]
        public string AmountIn { get; set; }

        /// <summary>
        /// Gets or Sets AmountOut
        /// </summary>
        [JsonPropertyName("amountOut")]
        public string AmountOut { get; set; }

        /// <summary>
        /// Gets or Sets TokenIn
        /// </summary>
        [JsonPropertyName("tokenIn")]
        public string TokenIn { get; set; }

        /// <summary>
        /// Gets or Sets TokenOut
        /// </summary>
        [JsonPropertyName("tokenOut")]
        public string TokenOut { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetQuoteResponse {\n");
            sb.Append("  AmountIn: ").Append(AmountIn).Append("\n");
            sb.Append("  AmountOut: ").Append(AmountOut).Append("\n");
            sb.Append("  TokenIn: ").Append(TokenIn).Append("\n");
            sb.Append("  TokenOut: ").Append(TokenOut).Append("\n");
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
    /// A Json converter for type <see cref="GetQuoteResponse" />
    /// </summary>
    public class GetQuoteResponseJsonConverter : JsonConverter<GetQuoteResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetQuoteResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetQuoteResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> amountIn = default;
            Option<string?> amountOut = default;
            Option<string?> tokenIn = default;
            Option<string?> tokenOut = default;

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
                        case "amountIn":
                            amountIn = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "amountOut":
                            amountOut = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "tokenIn":
                            tokenIn = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "tokenOut":
                            tokenOut = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!amountIn.IsSet)
                throw new ArgumentException("Property is required for class GetQuoteResponse.", nameof(amountIn));

            if (!amountOut.IsSet)
                throw new ArgumentException("Property is required for class GetQuoteResponse.", nameof(amountOut));

            if (!tokenIn.IsSet)
                throw new ArgumentException("Property is required for class GetQuoteResponse.", nameof(tokenIn));

            if (!tokenOut.IsSet)
                throw new ArgumentException("Property is required for class GetQuoteResponse.", nameof(tokenOut));

            if (amountIn.IsSet && amountIn.Value == null)
                throw new ArgumentNullException(nameof(amountIn), "Property is not nullable for class GetQuoteResponse.");

            if (amountOut.IsSet && amountOut.Value == null)
                throw new ArgumentNullException(nameof(amountOut), "Property is not nullable for class GetQuoteResponse.");

            if (tokenIn.IsSet && tokenIn.Value == null)
                throw new ArgumentNullException(nameof(tokenIn), "Property is not nullable for class GetQuoteResponse.");

            if (tokenOut.IsSet && tokenOut.Value == null)
                throw new ArgumentNullException(nameof(tokenOut), "Property is not nullable for class GetQuoteResponse.");

            return new GetQuoteResponse(amountIn.Value!, amountOut.Value!, tokenIn.Value!, tokenOut.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="GetQuoteResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getQuoteResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetQuoteResponse getQuoteResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getQuoteResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetQuoteResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getQuoteResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetQuoteResponse getQuoteResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getQuoteResponse.AmountIn == null)
                throw new ArgumentNullException(nameof(getQuoteResponse.AmountIn), "Property is required for class GetQuoteResponse.");

            if (getQuoteResponse.AmountOut == null)
                throw new ArgumentNullException(nameof(getQuoteResponse.AmountOut), "Property is required for class GetQuoteResponse.");

            if (getQuoteResponse.TokenIn == null)
                throw new ArgumentNullException(nameof(getQuoteResponse.TokenIn), "Property is required for class GetQuoteResponse.");

            if (getQuoteResponse.TokenOut == null)
                throw new ArgumentNullException(nameof(getQuoteResponse.TokenOut), "Property is required for class GetQuoteResponse.");

            writer.WriteString("amountIn", getQuoteResponse.AmountIn);

            writer.WriteString("amountOut", getQuoteResponse.AmountOut);

            writer.WriteString("tokenIn", getQuoteResponse.TokenIn);

            writer.WriteString("tokenOut", getQuoteResponse.TokenOut);
        }
    }
}