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
    /// AutomationTradeTokensRequestInputInitiatorTokensInner
    /// </summary>
    public partial class AutomationTradeTokensRequestInputInitiatorTokensInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationTradeTokensRequestInputInitiatorTokensInner" /> class.
        /// </summary>
        /// <param name="assetAddress">assetAddress</param>
        /// <param name="amount">amount</param>
        /// <param name="tokenId">tokenId</param>
        [JsonConstructor]
        public AutomationTradeTokensRequestInputInitiatorTokensInner(string assetAddress, string amount, Option<string> tokenId = default)
        {
            AssetAddress = assetAddress;
            Amount = amount;
            TokenIdOption = tokenId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets AssetAddress
        /// </summary>
        [JsonPropertyName("assetAddress")]
        public string AssetAddress { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// Used to track the state of TokenId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> TokenIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets TokenId
        /// </summary>
        [JsonPropertyName("tokenId")]
        public string TokenId { get { return this.TokenIdOption; } set { this.TokenIdOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutomationTradeTokensRequestInputInitiatorTokensInner {\n");
            sb.Append("  AssetAddress: ").Append(AssetAddress).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
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
    /// A Json converter for type <see cref="AutomationTradeTokensRequestInputInitiatorTokensInner" />
    /// </summary>
    public class AutomationTradeTokensRequestInputInitiatorTokensInnerJsonConverter : JsonConverter<AutomationTradeTokensRequestInputInitiatorTokensInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="AutomationTradeTokensRequestInputInitiatorTokensInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AutomationTradeTokensRequestInputInitiatorTokensInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> assetAddress = default;
            Option<string> amount = default;
            Option<string> tokenId = default;

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
                        case "assetAddress":
                            assetAddress = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "amount":
                            amount = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "tokenId":
                            tokenId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!assetAddress.IsSet)
                throw new ArgumentException("Property is required for class AutomationTradeTokensRequestInputInitiatorTokensInner.", nameof(assetAddress));

            if (!amount.IsSet)
                throw new ArgumentException("Property is required for class AutomationTradeTokensRequestInputInitiatorTokensInner.", nameof(amount));

            if (assetAddress.IsSet && assetAddress.Value == null)
                throw new ArgumentNullException(nameof(assetAddress), "Property is not nullable for class AutomationTradeTokensRequestInputInitiatorTokensInner.");

            if (amount.IsSet && amount.Value == null)
                throw new ArgumentNullException(nameof(amount), "Property is not nullable for class AutomationTradeTokensRequestInputInitiatorTokensInner.");

            if (tokenId.IsSet && tokenId.Value == null)
                throw new ArgumentNullException(nameof(tokenId), "Property is not nullable for class AutomationTradeTokensRequestInputInitiatorTokensInner.");

            return new AutomationTradeTokensRequestInputInitiatorTokensInner(assetAddress.Value, amount.Value, tokenId);
        }

        /// <summary>
        /// Serializes a <see cref="AutomationTradeTokensRequestInputInitiatorTokensInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationTradeTokensRequestInputInitiatorTokensInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AutomationTradeTokensRequestInputInitiatorTokensInner automationTradeTokensRequestInputInitiatorTokensInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, automationTradeTokensRequestInputInitiatorTokensInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AutomationTradeTokensRequestInputInitiatorTokensInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationTradeTokensRequestInputInitiatorTokensInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AutomationTradeTokensRequestInputInitiatorTokensInner automationTradeTokensRequestInputInitiatorTokensInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (automationTradeTokensRequestInputInitiatorTokensInner.AssetAddress == null)
                throw new ArgumentNullException(nameof(automationTradeTokensRequestInputInitiatorTokensInner.AssetAddress), "Property is required for class AutomationTradeTokensRequestInputInitiatorTokensInner.");

            if (automationTradeTokensRequestInputInitiatorTokensInner.Amount == null)
                throw new ArgumentNullException(nameof(automationTradeTokensRequestInputInitiatorTokensInner.Amount), "Property is required for class AutomationTradeTokensRequestInputInitiatorTokensInner.");

            if (automationTradeTokensRequestInputInitiatorTokensInner.TokenIdOption.IsSet && automationTradeTokensRequestInputInitiatorTokensInner.TokenId == null)
                throw new ArgumentNullException(nameof(automationTradeTokensRequestInputInitiatorTokensInner.TokenId), "Property is required for class AutomationTradeTokensRequestInputInitiatorTokensInner.");

            writer.WriteString("assetAddress", automationTradeTokensRequestInputInitiatorTokensInner.AssetAddress);

            writer.WriteString("amount", automationTradeTokensRequestInputInitiatorTokensInner.Amount);

            if (automationTradeTokensRequestInputInitiatorTokensInner.TokenIdOption.IsSet)
            {
                writer.WriteString("tokenId", automationTradeTokensRequestInputInitiatorTokensInner.TokenId);
            }
        }
    }
}