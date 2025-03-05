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
    /// AutomationCancelAssetListingRequestInputV2
    /// </summary>
    public partial class AutomationCancelAssetListingRequestInputV2 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationCancelAssetListingRequestInputV2" /> class.
        /// </summary>
        /// <param name="optimistic">optimistic (default to false)</param>
        /// <param name="sponsor">sponsor (default to true)</param>
        /// <param name="policyId">policyId</param>
        [JsonConstructor]
        public AutomationCancelAssetListingRequestInputV2(Option<bool?> optimistic = default, Option<bool?> sponsor = default, Option<string> policyId = default)
        {
            OptimisticOption = optimistic;
            SponsorOption = sponsor;
            PolicyIdOption = policyId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Optimistic
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> OptimisticOption { get; private set; }

        /// <summary>
        /// Gets or Sets Optimistic
        /// </summary>
        [JsonPropertyName("optimistic")]
        public bool? Optimistic { get { return this.OptimisticOption; } set { this.OptimisticOption = new(value); } }

        /// <summary>
        /// Used to track the state of Sponsor
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> SponsorOption { get; private set; }

        /// <summary>
        /// Gets or Sets Sponsor
        /// </summary>
        [JsonPropertyName("sponsor")]
        public bool? Sponsor { get { return this.SponsorOption; } set { this.SponsorOption = new(value); } }

        /// <summary>
        /// Used to track the state of PolicyId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> PolicyIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets PolicyId
        /// </summary>
        [JsonPropertyName("policyId")]
        public string PolicyId { get { return this.PolicyIdOption; } set { this.PolicyIdOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutomationCancelAssetListingRequestInputV2 {\n");
            sb.Append("  Optimistic: ").Append(Optimistic).Append("\n");
            sb.Append("  Sponsor: ").Append(Sponsor).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
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
    /// A Json converter for type <see cref="AutomationCancelAssetListingRequestInputV2" />
    /// </summary>
    public class AutomationCancelAssetListingRequestInputV2JsonConverter : JsonConverter<AutomationCancelAssetListingRequestInputV2>
    {
        /// <summary>
        /// Deserializes json to <see cref="AutomationCancelAssetListingRequestInputV2" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AutomationCancelAssetListingRequestInputV2 Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<bool?> optimistic = default;
            Option<bool?> sponsor = default;
            Option<string> policyId = default;

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
                        case "optimistic":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                optimistic = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "sponsor":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                sponsor = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "policyId":
                            policyId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (optimistic.IsSet && optimistic.Value == null)
                throw new ArgumentNullException(nameof(optimistic), "Property is not nullable for class AutomationCancelAssetListingRequestInputV2.");

            if (sponsor.IsSet && sponsor.Value == null)
                throw new ArgumentNullException(nameof(sponsor), "Property is not nullable for class AutomationCancelAssetListingRequestInputV2.");

            return new AutomationCancelAssetListingRequestInputV2(optimistic, sponsor, policyId);
        }

        /// <summary>
        /// Serializes a <see cref="AutomationCancelAssetListingRequestInputV2" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationCancelAssetListingRequestInputV2"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AutomationCancelAssetListingRequestInputV2 automationCancelAssetListingRequestInputV2, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, automationCancelAssetListingRequestInputV2, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AutomationCancelAssetListingRequestInputV2" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationCancelAssetListingRequestInputV2"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AutomationCancelAssetListingRequestInputV2 automationCancelAssetListingRequestInputV2, JsonSerializerOptions jsonSerializerOptions)
        {
            if (automationCancelAssetListingRequestInputV2.OptimisticOption.IsSet)
            {
                writer.WriteBoolean("optimistic", automationCancelAssetListingRequestInputV2.OptimisticOption.Value.Value);
            }

            if (automationCancelAssetListingRequestInputV2.SponsorOption.IsSet)
            {
                writer.WriteBoolean("sponsor", automationCancelAssetListingRequestInputV2.SponsorOption.Value.Value);
            }

            if (automationCancelAssetListingRequestInputV2.PolicyIdOption.IsSet)
            {
                if (automationCancelAssetListingRequestInputV2.PolicyIdOption.Value != null)
                {
                    writer.WriteString("policyId", automationCancelAssetListingRequestInputV2.PolicyId);
                }
                else
                {
                    writer.WriteNull("policyId");
                }

            }
        }
    }
}