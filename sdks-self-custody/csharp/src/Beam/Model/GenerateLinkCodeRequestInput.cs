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
    /// GenerateLinkCodeRequestInput
    /// </summary>
    public partial class GenerateLinkCodeRequestInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateLinkCodeRequestInput" /> class.
        /// </summary>
        /// <param name="callbackUrl">callbackUrl</param>
        [JsonConstructor]
        public GenerateLinkCodeRequestInput(Option<string?> callbackUrl = default)
        {
            CallbackUrlOption = callbackUrl;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of CallbackUrl
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CallbackUrlOption { get; private set; }

        /// <summary>
        /// Gets or Sets CallbackUrl
        /// </summary>
        [JsonPropertyName("callbackUrl")]
        public string? CallbackUrl { get { return this. CallbackUrlOption; } set { this.CallbackUrlOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GenerateLinkCodeRequestInput {\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
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
    /// A Json converter for type <see cref="GenerateLinkCodeRequestInput" />
    /// </summary>
    public class GenerateLinkCodeRequestInputJsonConverter : JsonConverter<GenerateLinkCodeRequestInput>
    {
        /// <summary>
        /// Deserializes json to <see cref="GenerateLinkCodeRequestInput" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GenerateLinkCodeRequestInput Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> callbackUrl = default;

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
                        case "callbackUrl":
                            callbackUrl = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            return new GenerateLinkCodeRequestInput(callbackUrl);
        }

        /// <summary>
        /// Serializes a <see cref="GenerateLinkCodeRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="generateLinkCodeRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GenerateLinkCodeRequestInput generateLinkCodeRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, generateLinkCodeRequestInput, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GenerateLinkCodeRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="generateLinkCodeRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GenerateLinkCodeRequestInput generateLinkCodeRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            if (generateLinkCodeRequestInput.CallbackUrlOption.IsSet)
                if (generateLinkCodeRequestInput.CallbackUrlOption.Value != null)
                    writer.WriteString("callbackUrl", generateLinkCodeRequestInput.CallbackUrl);
                else
                    writer.WriteNull("callbackUrl");
        }
    }
}