// <auto-generated>
/*
 * Automation API
 *
 * The Automation API is a service to integrate your game with Beam
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

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
using BeamAutomationClient.Client;

namespace BeamAutomationClient.Model
{
    /// <summary>
    /// AutomationSellAssetResponseV2
    /// </summary>
    public partial class AutomationSellAssetResponseV2 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationSellAssetResponseV2" /> class.
        /// </summary>
        /// <param name="orderId">orderId</param>
        [JsonConstructor]
        public AutomationSellAssetResponseV2(string orderId)
        {
            OrderId = orderId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [JsonPropertyName("orderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutomationSellAssetResponseV2 {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
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
    /// A Json converter for type <see cref="AutomationSellAssetResponseV2" />
    /// </summary>
    public class AutomationSellAssetResponseV2JsonConverter : JsonConverter<AutomationSellAssetResponseV2>
    {
        /// <summary>
        /// Deserializes json to <see cref="AutomationSellAssetResponseV2" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AutomationSellAssetResponseV2 Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> orderId = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "orderId":
                            orderId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!orderId.IsSet)
                throw new ArgumentException("Property is required for class AutomationSellAssetResponseV2.", nameof(orderId));

            if (orderId.IsSet && orderId.Value == null)
                throw new ArgumentNullException(nameof(orderId), "Property is not nullable for class AutomationSellAssetResponseV2.");

            return new AutomationSellAssetResponseV2(orderId.Value);
        }

        /// <summary>
        /// Serializes a <see cref="AutomationSellAssetResponseV2" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationSellAssetResponseV2"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AutomationSellAssetResponseV2 automationSellAssetResponseV2, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, automationSellAssetResponseV2, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AutomationSellAssetResponseV2" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationSellAssetResponseV2"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AutomationSellAssetResponseV2 automationSellAssetResponseV2, JsonSerializerOptions jsonSerializerOptions)
        {
            if (automationSellAssetResponseV2.OrderId == null)
                throw new ArgumentNullException(nameof(automationSellAssetResponseV2.OrderId), "Property is required for class AutomationSellAssetResponseV2.");

            writer.WriteString("orderId", automationSellAssetResponseV2.OrderId);
        }
    }
}