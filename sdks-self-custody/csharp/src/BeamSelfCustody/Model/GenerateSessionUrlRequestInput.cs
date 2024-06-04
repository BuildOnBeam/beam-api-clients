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
using OpenAPIClientUtils = BeamSelfCustody.Client.ClientUtils;
using BeamSelfCustody.Client;

namespace BeamSelfCustody.Model
{
    /// <summary>
    /// GenerateSessionUrlRequestInput
    /// </summary>
    public partial class GenerateSessionUrlRequestInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSessionUrlRequestInput" /> class.
        /// </summary>
        /// <param name="address">address</param>
        /// <param name="chainId">chainId (default to 13337M)</param>
        [JsonConstructor]
        public GenerateSessionUrlRequestInput(string address, Option<decimal?> chainId = default)
        {
            Address = address;
            ChainIdOption = chainId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

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
            sb.Append("class GenerateSessionUrlRequestInput {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
    /// A Json converter for type <see cref="GenerateSessionUrlRequestInput" />
    /// </summary>
    public class GenerateSessionUrlRequestInputJsonConverter : JsonConverter<GenerateSessionUrlRequestInput>
    {
        /// <summary>
        /// Deserializes json to <see cref="GenerateSessionUrlRequestInput" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GenerateSessionUrlRequestInput Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> address = default;
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
                        case "address":
                            address = new Option<string?>(utf8JsonReader.GetString()!);
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

            if (!address.IsSet)
                throw new ArgumentException("Property is required for class GenerateSessionUrlRequestInput.", nameof(address));

            if (address.IsSet && address.Value == null)
                throw new ArgumentNullException(nameof(address), "Property is not nullable for class GenerateSessionUrlRequestInput.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class GenerateSessionUrlRequestInput.");

            return new GenerateSessionUrlRequestInput(address.Value!, chainId);
        }

        /// <summary>
        /// Serializes a <see cref="GenerateSessionUrlRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="generateSessionUrlRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GenerateSessionUrlRequestInput generateSessionUrlRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, generateSessionUrlRequestInput, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GenerateSessionUrlRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="generateSessionUrlRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GenerateSessionUrlRequestInput generateSessionUrlRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            if (generateSessionUrlRequestInput.Address == null)
                throw new ArgumentNullException(nameof(generateSessionUrlRequestInput.Address), "Property is required for class GenerateSessionUrlRequestInput.");

            writer.WriteString("address", generateSessionUrlRequestInput.Address);

            if (generateSessionUrlRequestInput.ChainIdOption.IsSet)
                writer.WriteNumber("chainId", generateSessionUrlRequestInput.ChainIdOption.Value!.Value);
        }
    }
}