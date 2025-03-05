// <auto-generated>
/*
 * Player API
 *
 * The Player API is a service to integrate your game with Beam
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
using BeamPlayerClient.Client;

namespace BeamPlayerClient.Model
{
    /// <summary>
    /// PlayerUnwrappingTokenInput
    /// </summary>
    public partial class PlayerUnwrappingTokenInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerUnwrappingTokenInput" /> class.
        /// </summary>
        /// <param name="amount">amount</param>
        /// <param name="optimistic">optimistic (default to false)</param>
        /// <param name="sponsor">sponsor (default to true)</param>
        /// <param name="policyId">policyId</param>
        /// <param name="chainId">chainId (default to 13337)</param>
        /// <param name="operationProcessing">Operation processing type. If Execute is used, Operation will be executed automatically right after User signs it. If you prefer to have more control, use SignOnly then Process it using ProcessOperation. (default to OperationProcessingEnum.Execute)</param>
        /// <param name="authProvider">Auth Provider for the user to use. If it&#39;s Any, user will be able to choose his preferred login method. Useful when you want to present social login choice in your UI. (default to AuthProviderEnum.Any)</param>
        [JsonConstructor]
        public PlayerUnwrappingTokenInput(string amount, Option<bool?> optimistic = default, Option<bool?> sponsor = default, Option<string> policyId = default, Option<long?> chainId = default, Option<OperationProcessingEnum?> operationProcessing = default, Option<AuthProviderEnum?> authProvider = default)
        {
            Amount = amount;
            OptimisticOption = optimistic;
            SponsorOption = sponsor;
            PolicyIdOption = policyId;
            ChainIdOption = chainId;
            OperationProcessingOption = operationProcessing;
            AuthProviderOption = authProvider;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Operation processing type. If Execute is used, Operation will be executed automatically right after User signs it. If you prefer to have more control, use SignOnly then Process it using ProcessOperation.
        /// </summary>
        /// <value>Operation processing type. If Execute is used, Operation will be executed automatically right after User signs it. If you prefer to have more control, use SignOnly then Process it using ProcessOperation.</value>
        public enum OperationProcessingEnum
        {
            /// <summary>
            /// Enum SignOnly for value: SignOnly
            /// </summary>
            SignOnly = 1,

            /// <summary>
            /// Enum Execute for value: Execute
            /// </summary>
            Execute = 2
        }

        /// <summary>
        /// Returns a <see cref="OperationProcessingEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static OperationProcessingEnum OperationProcessingEnumFromString(string value)
        {
            if (value.Equals("SignOnly"))
                return OperationProcessingEnum.SignOnly;

            if (value.Equals("Execute"))
                return OperationProcessingEnum.Execute;

            throw new NotImplementedException($"Could not convert value to type OperationProcessingEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="OperationProcessingEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static OperationProcessingEnum? OperationProcessingEnumFromStringOrDefault(string value)
        {
            if (value.Equals("SignOnly"))
                return OperationProcessingEnum.SignOnly;

            if (value.Equals("Execute"))
                return OperationProcessingEnum.Execute;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="OperationProcessingEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string OperationProcessingEnumToJsonValue(OperationProcessingEnum? value)
        {
            if (value == null)
                return null;

            if (value == OperationProcessingEnum.SignOnly)
                return "SignOnly";

            if (value == OperationProcessingEnum.Execute)
                return "Execute";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Used to track the state of OperationProcessing
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<OperationProcessingEnum?> OperationProcessingOption { get; private set; }

        /// <summary>
        /// Operation processing type. If Execute is used, Operation will be executed automatically right after User signs it. If you prefer to have more control, use SignOnly then Process it using ProcessOperation.
        /// </summary>
        /// <value>Operation processing type. If Execute is used, Operation will be executed automatically right after User signs it. If you prefer to have more control, use SignOnly then Process it using ProcessOperation.</value>
        [JsonPropertyName("operationProcessing")]
        public OperationProcessingEnum? OperationProcessing { get { return this.OperationProcessingOption; } set { this.OperationProcessingOption = new(value); } }

        /// <summary>
        /// Auth Provider for the user to use. If it&#39;s Any, user will be able to choose his preferred login method. Useful when you want to present social login choice in your UI.
        /// </summary>
        /// <value>Auth Provider for the user to use. If it&#39;s Any, user will be able to choose his preferred login method. Useful when you want to present social login choice in your UI.</value>
        public enum AuthProviderEnum
        {
            /// <summary>
            /// Enum Any for value: Any
            /// </summary>
            Any = 1,

            /// <summary>
            /// Enum Google for value: Google
            /// </summary>
            Google = 2,

            /// <summary>
            /// Enum Discord for value: Discord
            /// </summary>
            Discord = 3,

            /// <summary>
            /// Enum Apple for value: Apple
            /// </summary>
            Apple = 4
        }

        /// <summary>
        /// Returns a <see cref="AuthProviderEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static AuthProviderEnum AuthProviderEnumFromString(string value)
        {
            if (value.Equals("Any"))
                return AuthProviderEnum.Any;

            if (value.Equals("Google"))
                return AuthProviderEnum.Google;

            if (value.Equals("Discord"))
                return AuthProviderEnum.Discord;

            if (value.Equals("Apple"))
                return AuthProviderEnum.Apple;

            throw new NotImplementedException($"Could not convert value to type AuthProviderEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="AuthProviderEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static AuthProviderEnum? AuthProviderEnumFromStringOrDefault(string value)
        {
            if (value.Equals("Any"))
                return AuthProviderEnum.Any;

            if (value.Equals("Google"))
                return AuthProviderEnum.Google;

            if (value.Equals("Discord"))
                return AuthProviderEnum.Discord;

            if (value.Equals("Apple"))
                return AuthProviderEnum.Apple;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="AuthProviderEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string AuthProviderEnumToJsonValue(AuthProviderEnum? value)
        {
            if (value == null)
                return null;

            if (value == AuthProviderEnum.Any)
                return "Any";

            if (value == AuthProviderEnum.Google)
                return "Google";

            if (value == AuthProviderEnum.Discord)
                return "Discord";

            if (value == AuthProviderEnum.Apple)
                return "Apple";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Used to track the state of AuthProvider
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<AuthProviderEnum?> AuthProviderOption { get; private set; }

        /// <summary>
        /// Auth Provider for the user to use. If it&#39;s Any, user will be able to choose his preferred login method. Useful when you want to present social login choice in your UI.
        /// </summary>
        /// <value>Auth Provider for the user to use. If it&#39;s Any, user will be able to choose his preferred login method. Useful when you want to present social login choice in your UI.</value>
        [JsonPropertyName("authProvider")]
        public AuthProviderEnum? AuthProvider { get { return this.AuthProviderOption; } set { this.AuthProviderOption = new(value); } }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

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
            sb.Append("class PlayerUnwrappingTokenInput {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Optimistic: ").Append(Optimistic).Append("\n");
            sb.Append("  Sponsor: ").Append(Sponsor).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  OperationProcessing: ").Append(OperationProcessing).Append("\n");
            sb.Append("  AuthProvider: ").Append(AuthProvider).Append("\n");
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
    /// A Json converter for type <see cref="PlayerUnwrappingTokenInput" />
    /// </summary>
    public class PlayerUnwrappingTokenInputJsonConverter : JsonConverter<PlayerUnwrappingTokenInput>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerUnwrappingTokenInput" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerUnwrappingTokenInput Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> amount = default;
            Option<bool?> optimistic = default;
            Option<bool?> sponsor = default;
            Option<string> policyId = default;
            Option<long?> chainId = default;
            Option<PlayerUnwrappingTokenInput.OperationProcessingEnum?> operationProcessing = default;
            Option<PlayerUnwrappingTokenInput.AuthProviderEnum?> authProvider = default;

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
                        case "amount":
                            amount = new Option<string>(utf8JsonReader.GetString());
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
                        case "operationProcessing":
                            string operationProcessingRawValue = utf8JsonReader.GetString();
                            if (operationProcessingRawValue != null)
                                operationProcessing = new Option<PlayerUnwrappingTokenInput.OperationProcessingEnum?>(PlayerUnwrappingTokenInput.OperationProcessingEnumFromStringOrDefault(operationProcessingRawValue));
                            break;
                        case "authProvider":
                            string authProviderRawValue = utf8JsonReader.GetString();
                            if (authProviderRawValue != null)
                                authProvider = new Option<PlayerUnwrappingTokenInput.AuthProviderEnum?>(PlayerUnwrappingTokenInput.AuthProviderEnumFromStringOrDefault(authProviderRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!amount.IsSet)
                throw new ArgumentException("Property is required for class PlayerUnwrappingTokenInput.", nameof(amount));

            if (amount.IsSet && amount.Value == null)
                throw new ArgumentNullException(nameof(amount), "Property is not nullable for class PlayerUnwrappingTokenInput.");

            if (optimistic.IsSet && optimistic.Value == null)
                throw new ArgumentNullException(nameof(optimistic), "Property is not nullable for class PlayerUnwrappingTokenInput.");

            if (sponsor.IsSet && sponsor.Value == null)
                throw new ArgumentNullException(nameof(sponsor), "Property is not nullable for class PlayerUnwrappingTokenInput.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class PlayerUnwrappingTokenInput.");

            if (operationProcessing.IsSet && operationProcessing.Value == null)
                throw new ArgumentNullException(nameof(operationProcessing), "Property is not nullable for class PlayerUnwrappingTokenInput.");

            return new PlayerUnwrappingTokenInput(amount.Value, optimistic, sponsor, policyId, chainId, operationProcessing, authProvider);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerUnwrappingTokenInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerUnwrappingTokenInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerUnwrappingTokenInput playerUnwrappingTokenInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playerUnwrappingTokenInput, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerUnwrappingTokenInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerUnwrappingTokenInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayerUnwrappingTokenInput playerUnwrappingTokenInput, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerUnwrappingTokenInput.Amount == null)
                throw new ArgumentNullException(nameof(playerUnwrappingTokenInput.Amount), "Property is required for class PlayerUnwrappingTokenInput.");

            writer.WriteString("amount", playerUnwrappingTokenInput.Amount);

            if (playerUnwrappingTokenInput.OptimisticOption.IsSet)
            {
                writer.WriteBoolean("optimistic", playerUnwrappingTokenInput.OptimisticOption.Value.Value);
            }

            if (playerUnwrappingTokenInput.SponsorOption.IsSet)
            {
                writer.WriteBoolean("sponsor", playerUnwrappingTokenInput.SponsorOption.Value.Value);
            }

            if (playerUnwrappingTokenInput.PolicyIdOption.IsSet)
            {
                if (playerUnwrappingTokenInput.PolicyIdOption.Value != null)
                {
                    writer.WriteString("policyId", playerUnwrappingTokenInput.PolicyId);
                }
                else
                {
                    writer.WriteNull("policyId");
                }

            }

            if (playerUnwrappingTokenInput.ChainIdOption.IsSet)
            {
                writer.WriteNumber("chainId", playerUnwrappingTokenInput.ChainIdOption.Value.Value);
            }

            var operationProcessingRawValue = PlayerUnwrappingTokenInput.OperationProcessingEnumToJsonValue(playerUnwrappingTokenInput.OperationProcessingOption.Value);
            if (operationProcessingRawValue != null)
                writer.WriteString("operationProcessing", operationProcessingRawValue);
            var authProviderRawValue = PlayerUnwrappingTokenInput.AuthProviderEnumToJsonValue(playerUnwrappingTokenInput.AuthProviderOption.Value.Value);
            if (authProviderRawValue != null)
                writer.WriteString("authProvider", authProviderRawValue);
            else
                writer.WriteNull("authProvider");
        }
    }
}