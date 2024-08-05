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
    /// AutomationGetProfileNativeCurrencyResponseV2
    /// </summary>
    public partial class AutomationGetProfileNativeCurrencyResponseV2 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationGetProfileNativeCurrencyResponseV2" /> class.
        /// </summary>
        /// <param name="nativeTokenBalance">nativeTokenBalance</param>
        [JsonConstructor]
        public AutomationGetProfileNativeCurrencyResponseV2(AutomationGetProfileNativeCurrencyResponseV2NativeTokenBalance nativeTokenBalance)
        {
            NativeTokenBalance = nativeTokenBalance;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets NativeTokenBalance
        /// </summary>
        [JsonPropertyName("nativeTokenBalance")]
        public AutomationGetProfileNativeCurrencyResponseV2NativeTokenBalance NativeTokenBalance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutomationGetProfileNativeCurrencyResponseV2 {\n");
            sb.Append("  NativeTokenBalance: ").Append(NativeTokenBalance).Append("\n");
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
    /// A Json converter for type <see cref="AutomationGetProfileNativeCurrencyResponseV2" />
    /// </summary>
    public class AutomationGetProfileNativeCurrencyResponseV2JsonConverter : JsonConverter<AutomationGetProfileNativeCurrencyResponseV2>
    {
        /// <summary>
        /// Deserializes json to <see cref="AutomationGetProfileNativeCurrencyResponseV2" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AutomationGetProfileNativeCurrencyResponseV2 Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<AutomationGetProfileNativeCurrencyResponseV2NativeTokenBalance?> nativeTokenBalance = default;

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
                        case "nativeTokenBalance":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                nativeTokenBalance = new Option<AutomationGetProfileNativeCurrencyResponseV2NativeTokenBalance?>(JsonSerializer.Deserialize<AutomationGetProfileNativeCurrencyResponseV2NativeTokenBalance>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!nativeTokenBalance.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetProfileNativeCurrencyResponseV2.", nameof(nativeTokenBalance));

            if (nativeTokenBalance.IsSet && nativeTokenBalance.Value == null)
                throw new ArgumentNullException(nameof(nativeTokenBalance), "Property is not nullable for class AutomationGetProfileNativeCurrencyResponseV2.");

            return new AutomationGetProfileNativeCurrencyResponseV2(nativeTokenBalance.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="AutomationGetProfileNativeCurrencyResponseV2" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationGetProfileNativeCurrencyResponseV2"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AutomationGetProfileNativeCurrencyResponseV2 automationGetProfileNativeCurrencyResponseV2, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, automationGetProfileNativeCurrencyResponseV2, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AutomationGetProfileNativeCurrencyResponseV2" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationGetProfileNativeCurrencyResponseV2"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, AutomationGetProfileNativeCurrencyResponseV2 automationGetProfileNativeCurrencyResponseV2, JsonSerializerOptions jsonSerializerOptions)
        {
            if (automationGetProfileNativeCurrencyResponseV2.NativeTokenBalance == null)
                throw new ArgumentNullException(nameof(automationGetProfileNativeCurrencyResponseV2.NativeTokenBalance), "Property is required for class AutomationGetProfileNativeCurrencyResponseV2.");

            writer.WritePropertyName("nativeTokenBalance");
            JsonSerializer.Serialize(writer, automationGetProfileNativeCurrencyResponseV2.NativeTokenBalance, jsonSerializerOptions);
        }
    }
}