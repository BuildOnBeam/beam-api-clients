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
    /// AutomationConvertTokenRequestInput
    /// </summary>
    public partial class AutomationConvertTokenRequestInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationConvertTokenRequestInput" /> class.
        /// </summary>
        /// <param name="tokenIn">tokenIn</param>
        /// <param name="tokenOut">tokenOut</param>
        /// <param name="amountIn">amountIn</param>
        /// <param name="amountOut">amountOut</param>
        /// <param name="receiverEntityId">receiverEntityId</param>
        /// <param name="receiverWalletAddress">receiverWalletAddress</param>
        /// <param name="optimistic">optimistic (default to false)</param>
        /// <param name="sponsor">sponsor (default to true)</param>
        /// <param name="policyId">policyId</param>
        /// <param name="chainId">chainId (default to 13337)</param>
        [JsonConstructor]
        public AutomationConvertTokenRequestInput(string tokenIn, string tokenOut, string amountIn, string amountOut, Option<string> receiverEntityId = default, Option<string> receiverWalletAddress = default, Option<bool?> optimistic = default, Option<bool?> sponsor = default, Option<string> policyId = default, Option<long?> chainId = default)
        {
            TokenIn = tokenIn;
            TokenOut = tokenOut;
            AmountIn = amountIn;
            AmountOut = amountOut;
            ReceiverEntityIdOption = receiverEntityId;
            ReceiverWalletAddressOption = receiverWalletAddress;
            OptimisticOption = optimistic;
            SponsorOption = sponsor;
            PolicyIdOption = policyId;
            ChainIdOption = chainId;
            OnCreated();
        }

        partial void OnCreated();

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
        /// Used to track the state of ReceiverEntityId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ReceiverEntityIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets ReceiverEntityId
        /// </summary>
        [JsonPropertyName("receiverEntityId")]
        public string ReceiverEntityId { get { return this.ReceiverEntityIdOption; } set { this.ReceiverEntityIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of ReceiverWalletAddress
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ReceiverWalletAddressOption { get; private set; }

        /// <summary>
        /// Gets or Sets ReceiverWalletAddress
        /// </summary>
        [JsonPropertyName("receiverWalletAddress")]
        public string ReceiverWalletAddress { get { return this.ReceiverWalletAddressOption; } set { this.ReceiverWalletAddressOption = new(value); } }

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
        /// Used to track the state of ChainId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> ChainIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [JsonPropertyName("chainId")]
        public long? ChainId { get { return this.ChainIdOption; } set { this.ChainIdOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutomationConvertTokenRequestInput {\n");
            sb.Append("  TokenIn: ").Append(TokenIn).Append("\n");
            sb.Append("  TokenOut: ").Append(TokenOut).Append("\n");
            sb.Append("  AmountIn: ").Append(AmountIn).Append("\n");
            sb.Append("  AmountOut: ").Append(AmountOut).Append("\n");
            sb.Append("  ReceiverEntityId: ").Append(ReceiverEntityId).Append("\n");
            sb.Append("  ReceiverWalletAddress: ").Append(ReceiverWalletAddress).Append("\n");
            sb.Append("  Optimistic: ").Append(Optimistic).Append("\n");
            sb.Append("  Sponsor: ").Append(Sponsor).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
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
    /// A Json converter for type <see cref="AutomationConvertTokenRequestInput" />
    /// </summary>
    public class AutomationConvertTokenRequestInputJsonConverter : JsonConverter<AutomationConvertTokenRequestInput>
    {
        /// <summary>
        /// Deserializes json to <see cref="AutomationConvertTokenRequestInput" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AutomationConvertTokenRequestInput Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> tokenIn = default;
            Option<string> tokenOut = default;
            Option<string> amountIn = default;
            Option<string> amountOut = default;
            Option<string> receiverEntityId = default;
            Option<string> receiverWalletAddress = default;
            Option<bool?> optimistic = default;
            Option<bool?> sponsor = default;
            Option<string> policyId = default;
            Option<long?> chainId = default;

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
                        case "tokenIn":
                            tokenIn = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "tokenOut":
                            tokenOut = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "amountIn":
                            amountIn = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "amountOut":
                            amountOut = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "receiverEntityId":
                            receiverEntityId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "receiverWalletAddress":
                            receiverWalletAddress = new Option<string>(utf8JsonReader.GetString());
                            break;
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
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!tokenIn.IsSet)
                throw new ArgumentException("Property is required for class AutomationConvertTokenRequestInput.", nameof(tokenIn));

            if (!tokenOut.IsSet)
                throw new ArgumentException("Property is required for class AutomationConvertTokenRequestInput.", nameof(tokenOut));

            if (!amountIn.IsSet)
                throw new ArgumentException("Property is required for class AutomationConvertTokenRequestInput.", nameof(amountIn));

            if (!amountOut.IsSet)
                throw new ArgumentException("Property is required for class AutomationConvertTokenRequestInput.", nameof(amountOut));

            if (tokenIn.IsSet && tokenIn.Value == null)
                throw new ArgumentNullException(nameof(tokenIn), "Property is not nullable for class AutomationConvertTokenRequestInput.");

            if (tokenOut.IsSet && tokenOut.Value == null)
                throw new ArgumentNullException(nameof(tokenOut), "Property is not nullable for class AutomationConvertTokenRequestInput.");

            if (amountIn.IsSet && amountIn.Value == null)
                throw new ArgumentNullException(nameof(amountIn), "Property is not nullable for class AutomationConvertTokenRequestInput.");

            if (amountOut.IsSet && amountOut.Value == null)
                throw new ArgumentNullException(nameof(amountOut), "Property is not nullable for class AutomationConvertTokenRequestInput.");

            if (receiverEntityId.IsSet && receiverEntityId.Value == null)
                throw new ArgumentNullException(nameof(receiverEntityId), "Property is not nullable for class AutomationConvertTokenRequestInput.");

            if (receiverWalletAddress.IsSet && receiverWalletAddress.Value == null)
                throw new ArgumentNullException(nameof(receiverWalletAddress), "Property is not nullable for class AutomationConvertTokenRequestInput.");

            if (optimistic.IsSet && optimistic.Value == null)
                throw new ArgumentNullException(nameof(optimistic), "Property is not nullable for class AutomationConvertTokenRequestInput.");

            if (sponsor.IsSet && sponsor.Value == null)
                throw new ArgumentNullException(nameof(sponsor), "Property is not nullable for class AutomationConvertTokenRequestInput.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class AutomationConvertTokenRequestInput.");

            return new AutomationConvertTokenRequestInput(tokenIn.Value, tokenOut.Value, amountIn.Value, amountOut.Value, receiverEntityId, receiverWalletAddress, optimistic, sponsor, policyId, chainId);
        }

        /// <summary>
        /// Serializes a <see cref="AutomationConvertTokenRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationConvertTokenRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AutomationConvertTokenRequestInput automationConvertTokenRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, automationConvertTokenRequestInput, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AutomationConvertTokenRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationConvertTokenRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AutomationConvertTokenRequestInput automationConvertTokenRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            if (automationConvertTokenRequestInput.TokenIn == null)
                throw new ArgumentNullException(nameof(automationConvertTokenRequestInput.TokenIn), "Property is required for class AutomationConvertTokenRequestInput.");

            if (automationConvertTokenRequestInput.TokenOut == null)
                throw new ArgumentNullException(nameof(automationConvertTokenRequestInput.TokenOut), "Property is required for class AutomationConvertTokenRequestInput.");

            if (automationConvertTokenRequestInput.AmountIn == null)
                throw new ArgumentNullException(nameof(automationConvertTokenRequestInput.AmountIn), "Property is required for class AutomationConvertTokenRequestInput.");

            if (automationConvertTokenRequestInput.AmountOut == null)
                throw new ArgumentNullException(nameof(automationConvertTokenRequestInput.AmountOut), "Property is required for class AutomationConvertTokenRequestInput.");

            if (automationConvertTokenRequestInput.ReceiverEntityIdOption.IsSet && automationConvertTokenRequestInput.ReceiverEntityId == null)
                throw new ArgumentNullException(nameof(automationConvertTokenRequestInput.ReceiverEntityId), "Property is required for class AutomationConvertTokenRequestInput.");

            if (automationConvertTokenRequestInput.ReceiverWalletAddressOption.IsSet && automationConvertTokenRequestInput.ReceiverWalletAddress == null)
                throw new ArgumentNullException(nameof(automationConvertTokenRequestInput.ReceiverWalletAddress), "Property is required for class AutomationConvertTokenRequestInput.");

            writer.WriteString("tokenIn", automationConvertTokenRequestInput.TokenIn);

            writer.WriteString("tokenOut", automationConvertTokenRequestInput.TokenOut);

            writer.WriteString("amountIn", automationConvertTokenRequestInput.AmountIn);

            writer.WriteString("amountOut", automationConvertTokenRequestInput.AmountOut);

            if (automationConvertTokenRequestInput.ReceiverEntityIdOption.IsSet)
            {
                writer.WriteString("receiverEntityId", automationConvertTokenRequestInput.ReceiverEntityId);
            }

            if (automationConvertTokenRequestInput.ReceiverWalletAddressOption.IsSet)
            {
                writer.WriteString("receiverWalletAddress", automationConvertTokenRequestInput.ReceiverWalletAddress);
            }

            if (automationConvertTokenRequestInput.OptimisticOption.IsSet)
            {
                writer.WriteBoolean("optimistic", automationConvertTokenRequestInput.OptimisticOption.Value.Value);
            }

            if (automationConvertTokenRequestInput.SponsorOption.IsSet)
            {
                writer.WriteBoolean("sponsor", automationConvertTokenRequestInput.SponsorOption.Value.Value);
            }

            if (automationConvertTokenRequestInput.PolicyIdOption.IsSet)
            {
                if (automationConvertTokenRequestInput.PolicyIdOption.Value != null)
                {
                    writer.WriteString("policyId", automationConvertTokenRequestInput.PolicyId);
                }
                else
                {
                    writer.WriteNull("policyId");
                }

            }

            if (automationConvertTokenRequestInput.ChainIdOption.IsSet)
            {
                writer.WriteNumber("chainId", automationConvertTokenRequestInput.ChainIdOption.Value.Value);
            }
        }
    }
}