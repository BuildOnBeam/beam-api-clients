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
    /// PlayerGetAssetListingsResponseDataInnerPrice
    /// </summary>
    public partial class PlayerGetAssetListingsResponseDataInnerPrice : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerGetAssetListingsResponseDataInnerPrice" /> class.
        /// </summary>
        /// <param name="currency">currency</param>
        /// <param name="amount">amount</param>
        /// <param name="netAmount">netAmount</param>
        [JsonConstructor]
        public PlayerGetAssetListingsResponseDataInnerPrice(Option<PlayerGetAssetListingsResponseDataInnerPriceCurrency> currency = default, Option<PlayerGetAssetListingsResponseDataInnerPriceAmount> amount = default, Option<PlayerGetAssetListingsResponseDataInnerPriceAmount> netAmount = default)
        {
            CurrencyOption = currency;
            AmountOption = amount;
            NetAmountOption = netAmount;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Currency
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<PlayerGetAssetListingsResponseDataInnerPriceCurrency> CurrencyOption { get; private set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [JsonPropertyName("currency")]
        public PlayerGetAssetListingsResponseDataInnerPriceCurrency Currency { get { return this.CurrencyOption; } set { this.CurrencyOption = new(value); } }

        /// <summary>
        /// Used to track the state of Amount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<PlayerGetAssetListingsResponseDataInnerPriceAmount> AmountOption { get; private set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [JsonPropertyName("amount")]
        public PlayerGetAssetListingsResponseDataInnerPriceAmount Amount { get { return this.AmountOption; } set { this.AmountOption = new(value); } }

        /// <summary>
        /// Used to track the state of NetAmount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<PlayerGetAssetListingsResponseDataInnerPriceAmount> NetAmountOption { get; private set; }

        /// <summary>
        /// Gets or Sets NetAmount
        /// </summary>
        [JsonPropertyName("netAmount")]
        public PlayerGetAssetListingsResponseDataInnerPriceAmount NetAmount { get { return this.NetAmountOption; } set { this.NetAmountOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerGetAssetListingsResponseDataInnerPrice {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  NetAmount: ").Append(NetAmount).Append("\n");
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
    /// A Json converter for type <see cref="PlayerGetAssetListingsResponseDataInnerPrice" />
    /// </summary>
    public class PlayerGetAssetListingsResponseDataInnerPriceJsonConverter : JsonConverter<PlayerGetAssetListingsResponseDataInnerPrice>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerGetAssetListingsResponseDataInnerPrice" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerGetAssetListingsResponseDataInnerPrice Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<PlayerGetAssetListingsResponseDataInnerPriceCurrency> currency = default;
            Option<PlayerGetAssetListingsResponseDataInnerPriceAmount> amount = default;
            Option<PlayerGetAssetListingsResponseDataInnerPriceAmount> netAmount = default;

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
                        case "currency":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                currency = new Option<PlayerGetAssetListingsResponseDataInnerPriceCurrency>(JsonSerializer.Deserialize<PlayerGetAssetListingsResponseDataInnerPriceCurrency>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "amount":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                amount = new Option<PlayerGetAssetListingsResponseDataInnerPriceAmount>(JsonSerializer.Deserialize<PlayerGetAssetListingsResponseDataInnerPriceAmount>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "netAmount":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                netAmount = new Option<PlayerGetAssetListingsResponseDataInnerPriceAmount>(JsonSerializer.Deserialize<PlayerGetAssetListingsResponseDataInnerPriceAmount>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            return new PlayerGetAssetListingsResponseDataInnerPrice(currency, amount, netAmount);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerGetAssetListingsResponseDataInnerPrice" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetAssetListingsResponseDataInnerPrice"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerGetAssetListingsResponseDataInnerPrice playerGetAssetListingsResponseDataInnerPrice, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playerGetAssetListingsResponseDataInnerPrice, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerGetAssetListingsResponseDataInnerPrice" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetAssetListingsResponseDataInnerPrice"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayerGetAssetListingsResponseDataInnerPrice playerGetAssetListingsResponseDataInnerPrice, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerGetAssetListingsResponseDataInnerPrice.CurrencyOption.IsSet)
                if (playerGetAssetListingsResponseDataInnerPrice.CurrencyOption.Value != null)
                {
                    writer.WritePropertyName("currency");
                    JsonSerializer.Serialize(writer, playerGetAssetListingsResponseDataInnerPrice.Currency, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("currency");
            if (playerGetAssetListingsResponseDataInnerPrice.AmountOption.IsSet)
                if (playerGetAssetListingsResponseDataInnerPrice.AmountOption.Value != null)
                {
                    writer.WritePropertyName("amount");
                    JsonSerializer.Serialize(writer, playerGetAssetListingsResponseDataInnerPrice.Amount, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("amount");
            if (playerGetAssetListingsResponseDataInnerPrice.NetAmountOption.IsSet)
                if (playerGetAssetListingsResponseDataInnerPrice.NetAmountOption.Value != null)
                {
                    writer.WritePropertyName("netAmount");
                    JsonSerializer.Serialize(writer, playerGetAssetListingsResponseDataInnerPrice.NetAmount, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("netAmount");
        }
    }
}