// <auto-generated>
/*
 * Player API
 *
 * The Player API is a service to integrate your game with Beam
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
using OpenAPIClientUtils = BeamPlayerClient.Client.ClientUtils;
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
        /// <param name="chainId">chainId (default to 13337)</param>
        /// <param name="fiatAmount">fiatAmount</param>
        /// <param name="paymentCurrency">paymentCurrency (default to &quot;USD&quot;)</param>
        /// <param name="token">token (default to TokenEnum.BEAM)</param>
        /// <param name="tokenAmount">tokenAmount (default to &quot;100&quot;)</param>
        [JsonConstructor]
        public PlayerCreateOnrampRequestInput(Option<long?> chainId = default, Option<string?> fiatAmount = default, Option<string?> paymentCurrency = default, Option<TokenEnum?> token = default, Option<string?> tokenAmount = default)
        {
            ChainIdOption = chainId;
            FiatAmountOption = fiatAmount;
            PaymentCurrencyOption = paymentCurrency;
            TokenOption = token;
            TokenAmountOption = tokenAmount;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines Token
        /// </summary>
        [JsonConverter(typeof(TokenEnumJsonConverter))]
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
            if (value == TokenEnum.BEAM)
                return "BEAM";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Converts <see cref="TokenEnum"/> to and from the JSON value
        /// </summary>
        public static class TokenEnumValueConverter
        {
            /// <summary>
            /// Parses a given value to <see cref="TokenEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static TokenEnum FromString(string value)
            {
                    if (value.Equals("BEAM"))
                        return TokenEnum.BEAM;

                throw new NotImplementedException($"Could not convert value to type TokenEnum: '{value}'");
            }

            /// <summary>
            /// Parses a given value to <see cref="TokenEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static TokenEnum? FromStringOrDefault(string value)
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
            public static string ToJsonValue(TokenEnum value)
            {
                        if (value == TokenEnum.BEAM)
                            return "BEAM";

                throw new NotImplementedException($"Value could not be handled: '{value}'");
            }
        }

        /// <summary>
        /// A Json converter for type <see cref="TokenEnum"/>
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public class TokenEnumJsonConverter : JsonConverter<TokenEnum>
        {
            /// <summary>
            /// Returns a TokenEnum from the Json object
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="typeToConvert"></param>
            /// <param name="options"></param>
            /// <returns></returns>
            public override TokenEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                string? rawValue = reader.GetString();

                TokenEnum? result = rawValue == null
                    ? null
                    : TokenEnumValueConverter.FromStringOrDefault(rawValue);

                if (result != null)
                    return result.Value;

                throw new JsonException();
            }

            /// <summary>
            /// Writes the TokenEnum to the json writer
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="tokenEnum"></param>
            /// <param name="options"></param>
            public override void Write(Utf8JsonWriter writer, TokenEnum tokenEnum, JsonSerializerOptions options)
            {
                writer.WriteStringValue(TokenEnumValueConverter.ToJsonValue(tokenEnum));
            }
        }

        /// <summary>
        /// Used to track the state of Token
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<TokenEnum?> TokenOption { get; private set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [JsonPropertyName("token")]
        public TokenEnum? Token { get { return this.TokenOption; } set { this.TokenOption = new(value); } }

        /// <summary>
        /// Used to track the state of ChainId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> ChainIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [JsonPropertyName("chainId")]
        public long? ChainId { get { return this. ChainIdOption; } set { this.ChainIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of FiatAmount
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> FiatAmountOption { get; private set; }

        /// <summary>
        /// Gets or Sets FiatAmount
        /// </summary>
        [JsonPropertyName("fiatAmount")]
        public string? FiatAmount { get { return this. FiatAmountOption; } set { this.FiatAmountOption = new(value); } }

        /// <summary>
        /// Used to track the state of PaymentCurrency
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> PaymentCurrencyOption { get; private set; }

        /// <summary>
        /// Gets or Sets PaymentCurrency
        /// </summary>
        [JsonPropertyName("paymentCurrency")]
        public string? PaymentCurrency { get { return this. PaymentCurrencyOption; } set { this.PaymentCurrencyOption = new(value); } }

        /// <summary>
        /// Used to track the state of TokenAmount
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TokenAmountOption { get; private set; }

        /// <summary>
        /// Gets or Sets TokenAmount
        /// </summary>
        [JsonPropertyName("tokenAmount")]
        public string? TokenAmount { get { return this. TokenAmountOption; } set { this.TokenAmountOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerCreateOnrampRequestInput {\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  FiatAmount: ").Append(FiatAmount).Append("\n");
            sb.Append("  PaymentCurrency: ").Append(PaymentCurrency).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  TokenAmount: ").Append(TokenAmount).Append("\n");
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

            Option<long?> chainId = default;
            Option<string?> fiatAmount = default;
            Option<string?> paymentCurrency = default;
            Option<PlayerCreateOnrampRequestInput.TokenEnum?> token = default;
            Option<string?> tokenAmount = default;

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
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "fiatAmount":
                            fiatAmount = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "paymentCurrency":
                            paymentCurrency = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "token":
                            string? tokenRawValue = utf8JsonReader.GetString();
                            if (tokenRawValue != null)
                                token = new Option<PlayerCreateOnrampRequestInput.TokenEnum?>(PlayerCreateOnrampRequestInput.TokenEnumFromStringOrDefault(tokenRawValue));
                            break;
                        case "tokenAmount":
                            tokenAmount = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class PlayerCreateOnrampRequestInput.");

            if (fiatAmount.IsSet && fiatAmount.Value == null)
                throw new ArgumentNullException(nameof(fiatAmount), "Property is not nullable for class PlayerCreateOnrampRequestInput.");

            if (paymentCurrency.IsSet && paymentCurrency.Value == null)
                throw new ArgumentNullException(nameof(paymentCurrency), "Property is not nullable for class PlayerCreateOnrampRequestInput.");

            if (token.IsSet && token.Value == null)
                throw new ArgumentNullException(nameof(token), "Property is not nullable for class PlayerCreateOnrampRequestInput.");

            if (tokenAmount.IsSet && tokenAmount.Value == null)
                throw new ArgumentNullException(nameof(tokenAmount), "Property is not nullable for class PlayerCreateOnrampRequestInput.");

            return new PlayerCreateOnrampRequestInput(chainId, fiatAmount, paymentCurrency, token, tokenAmount);
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

            WriteProperties(ref writer, playerCreateOnrampRequestInput, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerCreateOnrampRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerCreateOnrampRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, PlayerCreateOnrampRequestInput playerCreateOnrampRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerCreateOnrampRequestInput.FiatAmountOption.IsSet && playerCreateOnrampRequestInput.FiatAmount == null)
                throw new ArgumentNullException(nameof(playerCreateOnrampRequestInput.FiatAmount), "Property is required for class PlayerCreateOnrampRequestInput.");

            if (playerCreateOnrampRequestInput.PaymentCurrencyOption.IsSet && playerCreateOnrampRequestInput.PaymentCurrency == null)
                throw new ArgumentNullException(nameof(playerCreateOnrampRequestInput.PaymentCurrency), "Property is required for class PlayerCreateOnrampRequestInput.");

            if (playerCreateOnrampRequestInput.TokenAmountOption.IsSet && playerCreateOnrampRequestInput.TokenAmount == null)
                throw new ArgumentNullException(nameof(playerCreateOnrampRequestInput.TokenAmount), "Property is required for class PlayerCreateOnrampRequestInput.");

            if (playerCreateOnrampRequestInput.ChainIdOption.IsSet)
                writer.WriteNumber("chainId", playerCreateOnrampRequestInput.ChainIdOption.Value!.Value);

            if (playerCreateOnrampRequestInput.FiatAmountOption.IsSet)
                writer.WriteString("fiatAmount", playerCreateOnrampRequestInput.FiatAmount);

            if (playerCreateOnrampRequestInput.PaymentCurrencyOption.IsSet)
                writer.WriteString("paymentCurrency", playerCreateOnrampRequestInput.PaymentCurrency);

            var tokenRawValue = PlayerCreateOnrampRequestInput.TokenEnumToJsonValue(playerCreateOnrampRequestInput.TokenOption.Value!.Value);
            writer.WriteString("token", tokenRawValue);
            if (playerCreateOnrampRequestInput.TokenAmountOption.IsSet)
                writer.WriteString("tokenAmount", playerCreateOnrampRequestInput.TokenAmount);
        }
    }
}