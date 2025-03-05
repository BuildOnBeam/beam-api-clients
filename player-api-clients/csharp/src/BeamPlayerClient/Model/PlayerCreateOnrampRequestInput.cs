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
    /// PlayerCreateOnrampRequestInput
    /// </summary>
    public partial class PlayerCreateOnrampRequestInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerCreateOnrampRequestInput" /> class.
        /// </summary>
        /// <param name="token">token (default to TokenEnum.BEAM)</param>
        /// <param name="tokenAmount">tokenAmount</param>
        /// <param name="fiatAmount">fiatAmount</param>
        /// <param name="paymentCurrency">paymentCurrency (default to &quot;USD&quot;)</param>
        /// <param name="canChangeAmount">canChangeAmount (default to false)</param>
        /// <param name="chainId">chainId (default to 13337)</param>
        /// <param name="authProvider">Auth Provider for the user to use. If it&#39;s Any, user will be able to choose his preferred login method. Useful when you want to present social login choice in your UI. (default to AuthProviderEnum.Any)</param>
        [JsonConstructor]
        public PlayerCreateOnrampRequestInput(Option<TokenEnum?> token = default, Option<string> tokenAmount = default, Option<string> fiatAmount = default, Option<string> paymentCurrency = default, Option<bool?> canChangeAmount = default, Option<long?> chainId = default, Option<AuthProviderEnum?> authProvider = default)
        {
            TokenOption = token;
            TokenAmountOption = tokenAmount;
            FiatAmountOption = fiatAmount;
            PaymentCurrencyOption = paymentCurrency;
            CanChangeAmountOption = canChangeAmount;
            ChainIdOption = chainId;
            AuthProviderOption = authProvider;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines Token
        /// </summary>
        public enum TokenEnum
        {
            /// <summary>
            /// Enum BEAM for value: BEAM
            /// </summary>
            BEAM = 1
        }

        /// <summary>
        /// Returns a <see cref="TokenEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static TokenEnum TokenEnumFromString(string value)
        {
            if (value.Equals("BEAM"))
                return TokenEnum.BEAM;

            throw new NotImplementedException($"Could not convert value to type TokenEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="TokenEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TokenEnum? TokenEnumFromStringOrDefault(string value)
        {
            if (value.Equals("BEAM"))
                return TokenEnum.BEAM;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="TokenEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string TokenEnumToJsonValue(TokenEnum? value)
        {
            if (value == null)
                return null;

            if (value == TokenEnum.BEAM)
                return "BEAM";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Used to track the state of Token
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<TokenEnum?> TokenOption { get; private set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [JsonPropertyName("token")]
        public TokenEnum? Token { get { return this.TokenOption; } set { this.TokenOption = new(value); } }

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
        /// Used to track the state of TokenAmount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> TokenAmountOption { get; private set; }

        /// <summary>
        /// Gets or Sets TokenAmount
        /// </summary>
        [JsonPropertyName("tokenAmount")]
        public string TokenAmount { get { return this.TokenAmountOption; } set { this.TokenAmountOption = new(value); } }

        /// <summary>
        /// Used to track the state of FiatAmount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> FiatAmountOption { get; private set; }

        /// <summary>
        /// Gets or Sets FiatAmount
        /// </summary>
        [JsonPropertyName("fiatAmount")]
        public string FiatAmount { get { return this.FiatAmountOption; } set { this.FiatAmountOption = new(value); } }

        /// <summary>
        /// Used to track the state of PaymentCurrency
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> PaymentCurrencyOption { get; private set; }

        /// <summary>
        /// Gets or Sets PaymentCurrency
        /// </summary>
        [JsonPropertyName("paymentCurrency")]
        public string PaymentCurrency { get { return this.PaymentCurrencyOption; } set { this.PaymentCurrencyOption = new(value); } }

        /// <summary>
        /// Used to track the state of CanChangeAmount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> CanChangeAmountOption { get; private set; }

        /// <summary>
        /// Gets or Sets CanChangeAmount
        /// </summary>
        [JsonPropertyName("canChangeAmount")]
        public bool? CanChangeAmount { get { return this.CanChangeAmountOption; } set { this.CanChangeAmountOption = new(value); } }

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
            sb.Append("class PlayerCreateOnrampRequestInput {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  TokenAmount: ").Append(TokenAmount).Append("\n");
            sb.Append("  FiatAmount: ").Append(FiatAmount).Append("\n");
            sb.Append("  PaymentCurrency: ").Append(PaymentCurrency).Append("\n");
            sb.Append("  CanChangeAmount: ").Append(CanChangeAmount).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
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
    /// A Json converter for type <see cref="PlayerCreateOnrampRequestInput" />
    /// </summary>
    public class PlayerCreateOnrampRequestInputJsonConverter : JsonConverter<PlayerCreateOnrampRequestInput>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerCreateOnrampRequestInput" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerCreateOnrampRequestInput Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<PlayerCreateOnrampRequestInput.TokenEnum?> token = default;
            Option<string> tokenAmount = default;
            Option<string> fiatAmount = default;
            Option<string> paymentCurrency = default;
            Option<bool?> canChangeAmount = default;
            Option<long?> chainId = default;
            Option<PlayerCreateOnrampRequestInput.AuthProviderEnum?> authProvider = default;

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
                        case "token":
                            string tokenRawValue = utf8JsonReader.GetString();
                            if (tokenRawValue != null)
                                token = new Option<PlayerCreateOnrampRequestInput.TokenEnum?>(PlayerCreateOnrampRequestInput.TokenEnumFromStringOrDefault(tokenRawValue));
                            break;
                        case "tokenAmount":
                            tokenAmount = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "fiatAmount":
                            fiatAmount = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "paymentCurrency":
                            paymentCurrency = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "canChangeAmount":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                canChangeAmount = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "authProvider":
                            string authProviderRawValue = utf8JsonReader.GetString();
                            if (authProviderRawValue != null)
                                authProvider = new Option<PlayerCreateOnrampRequestInput.AuthProviderEnum?>(PlayerCreateOnrampRequestInput.AuthProviderEnumFromStringOrDefault(authProviderRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (token.IsSet && token.Value == null)
                throw new ArgumentNullException(nameof(token), "Property is not nullable for class PlayerCreateOnrampRequestInput.");

            if (tokenAmount.IsSet && tokenAmount.Value == null)
                throw new ArgumentNullException(nameof(tokenAmount), "Property is not nullable for class PlayerCreateOnrampRequestInput.");

            if (fiatAmount.IsSet && fiatAmount.Value == null)
                throw new ArgumentNullException(nameof(fiatAmount), "Property is not nullable for class PlayerCreateOnrampRequestInput.");

            if (paymentCurrency.IsSet && paymentCurrency.Value == null)
                throw new ArgumentNullException(nameof(paymentCurrency), "Property is not nullable for class PlayerCreateOnrampRequestInput.");

            if (canChangeAmount.IsSet && canChangeAmount.Value == null)
                throw new ArgumentNullException(nameof(canChangeAmount), "Property is not nullable for class PlayerCreateOnrampRequestInput.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class PlayerCreateOnrampRequestInput.");

            return new PlayerCreateOnrampRequestInput(token, tokenAmount, fiatAmount, paymentCurrency, canChangeAmount, chainId, authProvider);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerCreateOnrampRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerCreateOnrampRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerCreateOnrampRequestInput playerCreateOnrampRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playerCreateOnrampRequestInput, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerCreateOnrampRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerCreateOnrampRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayerCreateOnrampRequestInput playerCreateOnrampRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerCreateOnrampRequestInput.TokenAmountOption.IsSet && playerCreateOnrampRequestInput.TokenAmount == null)
                throw new ArgumentNullException(nameof(playerCreateOnrampRequestInput.TokenAmount), "Property is required for class PlayerCreateOnrampRequestInput.");

            if (playerCreateOnrampRequestInput.FiatAmountOption.IsSet && playerCreateOnrampRequestInput.FiatAmount == null)
                throw new ArgumentNullException(nameof(playerCreateOnrampRequestInput.FiatAmount), "Property is required for class PlayerCreateOnrampRequestInput.");

            if (playerCreateOnrampRequestInput.PaymentCurrencyOption.IsSet && playerCreateOnrampRequestInput.PaymentCurrency == null)
                throw new ArgumentNullException(nameof(playerCreateOnrampRequestInput.PaymentCurrency), "Property is required for class PlayerCreateOnrampRequestInput.");

            var tokenRawValue = PlayerCreateOnrampRequestInput.TokenEnumToJsonValue(playerCreateOnrampRequestInput.TokenOption.Value);
            if (tokenRawValue != null)
                writer.WriteString("token", tokenRawValue);
            if (playerCreateOnrampRequestInput.TokenAmountOption.IsSet)
            {
                writer.WriteString("tokenAmount", playerCreateOnrampRequestInput.TokenAmount);
            }

            if (playerCreateOnrampRequestInput.FiatAmountOption.IsSet)
            {
                writer.WriteString("fiatAmount", playerCreateOnrampRequestInput.FiatAmount);
            }

            if (playerCreateOnrampRequestInput.PaymentCurrencyOption.IsSet)
            {
                writer.WriteString("paymentCurrency", playerCreateOnrampRequestInput.PaymentCurrency);
            }

            if (playerCreateOnrampRequestInput.CanChangeAmountOption.IsSet)
            {
                writer.WriteBoolean("canChangeAmount", playerCreateOnrampRequestInput.CanChangeAmountOption.Value.Value);
            }

            if (playerCreateOnrampRequestInput.ChainIdOption.IsSet)
            {
                writer.WriteNumber("chainId", playerCreateOnrampRequestInput.ChainIdOption.Value.Value);
            }

            var authProviderRawValue = PlayerCreateOnrampRequestInput.AuthProviderEnumToJsonValue(playerCreateOnrampRequestInput.AuthProviderOption.Value.Value);
            if (authProviderRawValue != null)
                writer.WriteString("authProvider", authProviderRawValue);
            else
                writer.WriteNull("authProvider");
        }
    }
}