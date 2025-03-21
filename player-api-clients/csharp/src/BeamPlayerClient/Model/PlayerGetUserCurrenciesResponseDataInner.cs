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
    /// PlayerGetUserCurrenciesResponseDataInner
    /// </summary>
    public partial class PlayerGetUserCurrenciesResponseDataInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerGetUserCurrenciesResponseDataInner" /> class.
        /// </summary>
        /// <param name="address">address</param>
        /// <param name="name">name</param>
        /// <param name="symbol">symbol</param>
        /// <param name="decimals">decimals</param>
        /// <param name="chainId">chainId</param>
        /// <param name="balance">balance</param>
        /// <param name="logoUri">logoUri</param>
        [JsonConstructor]
        public PlayerGetUserCurrenciesResponseDataInner(string address, string name, string symbol, decimal decimals, long chainId, string balance, Option<string> logoUri = default)
        {
            Address = address;
            Name = name;
            Symbol = symbol;
            Decimals = decimals;
            ChainId = chainId;
            Balance = balance;
            LogoUriOption = logoUri;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets Decimals
        /// </summary>
        [JsonPropertyName("decimals")]
        public decimal Decimals { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [JsonPropertyName("chainId")]
        public long ChainId { get; set; }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [JsonPropertyName("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// Used to track the state of LogoUri
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> LogoUriOption { get; private set; }

        /// <summary>
        /// Gets or Sets LogoUri
        /// </summary>
        [JsonPropertyName("logoUri")]
        public string LogoUri { get { return this.LogoUriOption; } set { this.LogoUriOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerGetUserCurrenciesResponseDataInner {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Decimals: ").Append(Decimals).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  LogoUri: ").Append(LogoUri).Append("\n");
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
    /// A Json converter for type <see cref="PlayerGetUserCurrenciesResponseDataInner" />
    /// </summary>
    public class PlayerGetUserCurrenciesResponseDataInnerJsonConverter : JsonConverter<PlayerGetUserCurrenciesResponseDataInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerGetUserCurrenciesResponseDataInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerGetUserCurrenciesResponseDataInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> address = default;
            Option<string> name = default;
            Option<string> symbol = default;
            Option<decimal?> decimals = default;
            Option<long?> chainId = default;
            Option<string> balance = default;
            Option<string> logoUri = default;

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
                        case "address":
                            address = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "name":
                            name = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "symbol":
                            symbol = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "decimals":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                decimals = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "balance":
                            balance = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "logoUri":
                            logoUri = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!address.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetUserCurrenciesResponseDataInner.", nameof(address));

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetUserCurrenciesResponseDataInner.", nameof(name));

            if (!symbol.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetUserCurrenciesResponseDataInner.", nameof(symbol));

            if (!decimals.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetUserCurrenciesResponseDataInner.", nameof(decimals));

            if (!chainId.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetUserCurrenciesResponseDataInner.", nameof(chainId));

            if (!balance.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetUserCurrenciesResponseDataInner.", nameof(balance));

            if (address.IsSet && address.Value == null)
                throw new ArgumentNullException(nameof(address), "Property is not nullable for class PlayerGetUserCurrenciesResponseDataInner.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class PlayerGetUserCurrenciesResponseDataInner.");

            if (symbol.IsSet && symbol.Value == null)
                throw new ArgumentNullException(nameof(symbol), "Property is not nullable for class PlayerGetUserCurrenciesResponseDataInner.");

            if (decimals.IsSet && decimals.Value == null)
                throw new ArgumentNullException(nameof(decimals), "Property is not nullable for class PlayerGetUserCurrenciesResponseDataInner.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class PlayerGetUserCurrenciesResponseDataInner.");

            if (balance.IsSet && balance.Value == null)
                throw new ArgumentNullException(nameof(balance), "Property is not nullable for class PlayerGetUserCurrenciesResponseDataInner.");

            if (logoUri.IsSet && logoUri.Value == null)
                throw new ArgumentNullException(nameof(logoUri), "Property is not nullable for class PlayerGetUserCurrenciesResponseDataInner.");

            return new PlayerGetUserCurrenciesResponseDataInner(address.Value, name.Value, symbol.Value, decimals.Value.Value, chainId.Value.Value, balance.Value, logoUri);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerGetUserCurrenciesResponseDataInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetUserCurrenciesResponseDataInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerGetUserCurrenciesResponseDataInner playerGetUserCurrenciesResponseDataInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playerGetUserCurrenciesResponseDataInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerGetUserCurrenciesResponseDataInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetUserCurrenciesResponseDataInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayerGetUserCurrenciesResponseDataInner playerGetUserCurrenciesResponseDataInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerGetUserCurrenciesResponseDataInner.Address == null)
                throw new ArgumentNullException(nameof(playerGetUserCurrenciesResponseDataInner.Address), "Property is required for class PlayerGetUserCurrenciesResponseDataInner.");

            if (playerGetUserCurrenciesResponseDataInner.Name == null)
                throw new ArgumentNullException(nameof(playerGetUserCurrenciesResponseDataInner.Name), "Property is required for class PlayerGetUserCurrenciesResponseDataInner.");

            if (playerGetUserCurrenciesResponseDataInner.Symbol == null)
                throw new ArgumentNullException(nameof(playerGetUserCurrenciesResponseDataInner.Symbol), "Property is required for class PlayerGetUserCurrenciesResponseDataInner.");

            if (playerGetUserCurrenciesResponseDataInner.Balance == null)
                throw new ArgumentNullException(nameof(playerGetUserCurrenciesResponseDataInner.Balance), "Property is required for class PlayerGetUserCurrenciesResponseDataInner.");

            if (playerGetUserCurrenciesResponseDataInner.LogoUriOption.IsSet && playerGetUserCurrenciesResponseDataInner.LogoUri == null)
                throw new ArgumentNullException(nameof(playerGetUserCurrenciesResponseDataInner.LogoUri), "Property is required for class PlayerGetUserCurrenciesResponseDataInner.");

            writer.WriteString("address", playerGetUserCurrenciesResponseDataInner.Address);

            writer.WriteString("name", playerGetUserCurrenciesResponseDataInner.Name);

            writer.WriteString("symbol", playerGetUserCurrenciesResponseDataInner.Symbol);

            writer.WriteNumber("decimals", playerGetUserCurrenciesResponseDataInner.Decimals);

            writer.WriteNumber("chainId", playerGetUserCurrenciesResponseDataInner.ChainId);

            writer.WriteString("balance", playerGetUserCurrenciesResponseDataInner.Balance);

            if (playerGetUserCurrenciesResponseDataInner.LogoUriOption.IsSet)
            {
                writer.WriteString("logoUri", playerGetUserCurrenciesResponseDataInner.LogoUri);
            }
        }
    }
}