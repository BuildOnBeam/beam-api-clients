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
    /// AutomationGetAllGasUsageResponseChainsInner
    /// </summary>
    public partial class AutomationGetAllGasUsageResponseChainsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationGetAllGasUsageResponseChainsInner" /> class.
        /// </summary>
        /// <param name="policies">policies</param>
        /// <param name="summary">summary</param>
        [JsonConstructor]
        public AutomationGetAllGasUsageResponseChainsInner(List<AutomationGetAllGasUsageResponseChainsInnerPoliciesInner> policies, AutomationGetAllGasUsageResponseChainsInnerSummary summary)
        {
            Policies = policies;
            Summary = summary;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Policies
        /// </summary>
        [JsonPropertyName("policies")]
        public List<AutomationGetAllGasUsageResponseChainsInnerPoliciesInner> Policies { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [JsonPropertyName("summary")]
        public AutomationGetAllGasUsageResponseChainsInnerSummary Summary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutomationGetAllGasUsageResponseChainsInner {\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
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
    /// A Json converter for type <see cref="AutomationGetAllGasUsageResponseChainsInner" />
    /// </summary>
    public class AutomationGetAllGasUsageResponseChainsInnerJsonConverter : JsonConverter<AutomationGetAllGasUsageResponseChainsInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="AutomationGetAllGasUsageResponseChainsInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AutomationGetAllGasUsageResponseChainsInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<AutomationGetAllGasUsageResponseChainsInnerPoliciesInner>> policies = default;
            Option<AutomationGetAllGasUsageResponseChainsInnerSummary> summary = default;

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
                        case "policies":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                policies = new Option<List<AutomationGetAllGasUsageResponseChainsInnerPoliciesInner>>(JsonSerializer.Deserialize<List<AutomationGetAllGasUsageResponseChainsInnerPoliciesInner>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "summary":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                summary = new Option<AutomationGetAllGasUsageResponseChainsInnerSummary>(JsonSerializer.Deserialize<AutomationGetAllGasUsageResponseChainsInnerSummary>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!policies.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetAllGasUsageResponseChainsInner.", nameof(policies));

            if (!summary.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetAllGasUsageResponseChainsInner.", nameof(summary));

            if (policies.IsSet && policies.Value == null)
                throw new ArgumentNullException(nameof(policies), "Property is not nullable for class AutomationGetAllGasUsageResponseChainsInner.");

            if (summary.IsSet && summary.Value == null)
                throw new ArgumentNullException(nameof(summary), "Property is not nullable for class AutomationGetAllGasUsageResponseChainsInner.");

            return new AutomationGetAllGasUsageResponseChainsInner(policies.Value, summary.Value);
        }

        /// <summary>
        /// Serializes a <see cref="AutomationGetAllGasUsageResponseChainsInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationGetAllGasUsageResponseChainsInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AutomationGetAllGasUsageResponseChainsInner automationGetAllGasUsageResponseChainsInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, automationGetAllGasUsageResponseChainsInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AutomationGetAllGasUsageResponseChainsInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationGetAllGasUsageResponseChainsInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AutomationGetAllGasUsageResponseChainsInner automationGetAllGasUsageResponseChainsInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (automationGetAllGasUsageResponseChainsInner.Policies == null)
                throw new ArgumentNullException(nameof(automationGetAllGasUsageResponseChainsInner.Policies), "Property is required for class AutomationGetAllGasUsageResponseChainsInner.");

            if (automationGetAllGasUsageResponseChainsInner.Summary == null)
                throw new ArgumentNullException(nameof(automationGetAllGasUsageResponseChainsInner.Summary), "Property is required for class AutomationGetAllGasUsageResponseChainsInner.");

            writer.WritePropertyName("policies");
            JsonSerializer.Serialize(writer, automationGetAllGasUsageResponseChainsInner.Policies, jsonSerializerOptions);
            writer.WritePropertyName("summary");
            JsonSerializer.Serialize(writer, automationGetAllGasUsageResponseChainsInner.Summary, jsonSerializerOptions);
        }
    }
}