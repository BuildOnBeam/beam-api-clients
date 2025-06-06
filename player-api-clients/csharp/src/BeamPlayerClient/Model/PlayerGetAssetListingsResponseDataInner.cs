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
    /// PlayerGetAssetListingsResponseDataInner
    /// </summary>
    public partial class PlayerGetAssetListingsResponseDataInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerGetAssetListingsResponseDataInner" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="side">side</param>
        /// <param name="assetAddress">assetAddress</param>
        /// <param name="assetId">assetId</param>
        /// <param name="contractKind">contractKind</param>
        /// <param name="maker">maker</param>
        /// <param name="status">status</param>
        /// <param name="price">price</param>
        /// <param name="validFrom">validFrom</param>
        /// <param name="validUntil">validUntil</param>
        /// <param name="quantityFilled">quantityFilled</param>
        /// <param name="quantityRemaining">quantityRemaining</param>
        /// <param name="expiresAt">expiresAt</param>
        /// <param name="createdAt">createdAt</param>
        /// <param name="updatedAt">updatedAt</param>
        [JsonConstructor]
        public PlayerGetAssetListingsResponseDataInner(string id, string side, string assetAddress, string assetId, string contractKind, string maker, Option<StatusEnum?> status = default, Option<PlayerGetAssetListingsResponseDataInnerPrice> price = default, Option<DateTime?> validFrom = default, Option<DateTime?> validUntil = default, Option<decimal?> quantityFilled = default, Option<decimal?> quantityRemaining = default, Option<DateTime?> expiresAt = default, Option<DateTime?> createdAt = default, Option<DateTime?> updatedAt = default)
        {
            Id = id;
            Side = side;
            AssetAddress = assetAddress;
            AssetId = assetId;
            ContractKind = contractKind;
            Maker = maker;
            StatusOption = status;
            PriceOption = price;
            ValidFromOption = validFrom;
            ValidUntilOption = validUntil;
            QuantityFilledOption = quantityFilled;
            QuantityRemainingOption = quantityRemaining;
            ExpiresAtOption = expiresAt;
            CreatedAtOption = createdAt;
            UpdatedAtOption = updatedAt;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StatusEnumJsonConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            Active = 1,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            Inactive = 2,

            /// <summary>
            /// Enum Expired for value: expired
            /// </summary>
            Expired = 3,

            /// <summary>
            /// Enum Canceled for value: canceled
            /// </summary>
            Canceled = 4,

            /// <summary>
            /// Enum Filled for value: filled
            /// </summary>
            Filled = 5
        }

        /// <summary>
        /// Returns a <see cref="StatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static StatusEnum StatusEnumFromString(string value)
        {
            if (value.Equals("active"))
                return StatusEnum.Active;

            if (value.Equals("inactive"))
                return StatusEnum.Inactive;

            if (value.Equals("expired"))
                return StatusEnum.Expired;

            if (value.Equals("canceled"))
                return StatusEnum.Canceled;

            if (value.Equals("filled"))
                return StatusEnum.Filled;

            throw new NotImplementedException($"Could not convert value to type StatusEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="StatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static StatusEnum? StatusEnumFromStringOrDefault(string value)
        {
            if (value.Equals("active"))
                return StatusEnum.Active;

            if (value.Equals("inactive"))
                return StatusEnum.Inactive;

            if (value.Equals("expired"))
                return StatusEnum.Expired;

            if (value.Equals("canceled"))
                return StatusEnum.Canceled;

            if (value.Equals("filled"))
                return StatusEnum.Filled;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="StatusEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string StatusEnumToJsonValue(StatusEnum? value)
        {
            if (value == null)
                return null;

            if (value == StatusEnum.Active)
                return "active";

            if (value == StatusEnum.Inactive)
                return "inactive";

            if (value == StatusEnum.Expired)
                return "expired";

            if (value == StatusEnum.Canceled)
                return "canceled";

            if (value == StatusEnum.Filled)
                return "filled";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Converts <see cref="StatusEnum"/> to and from the JSON value
        /// </summary>
        public static class StatusEnumValueConverter
        {
            /// <summary>
            /// Parses a given value to <see cref="StatusEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static StatusEnum FromString(string value)
            {
                    if (value.Equals("active"))
                    return StatusEnum.Active;

                    if (value.Equals("inactive"))
                    return StatusEnum.Inactive;

                    if (value.Equals("expired"))
                    return StatusEnum.Expired;

                    if (value.Equals("canceled"))
                    return StatusEnum.Canceled;

                    if (value.Equals("filled"))
                    return StatusEnum.Filled;

            throw new NotImplementedException($"Could not convert value to type StatusEnum: '{value}'");
            }

            /// <summary>
            /// Parses a given value to <see cref="StatusEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static StatusEnum? FromStringOrDefault(string value)
            {
                    if (value.Equals("active"))
                    return StatusEnum.Active;

                    if (value.Equals("inactive"))
                    return StatusEnum.Inactive;

                    if (value.Equals("expired"))
                    return StatusEnum.Expired;

                    if (value.Equals("canceled"))
                    return StatusEnum.Canceled;

                    if (value.Equals("filled"))
                    return StatusEnum.Filled;

            return null;
            }

            /// <summary>
            /// Converts the <see cref="StatusEnum"/> to the json value
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            /// <exception cref="NotImplementedException"></exception>
            public static string ToJsonValue(StatusEnum value)
            {
                        if (value == StatusEnum.Active)
                        return "active";

                        if (value == StatusEnum.Inactive)
                        return "inactive";

                        if (value == StatusEnum.Expired)
                        return "expired";

                        if (value == StatusEnum.Canceled)
                        return "canceled";

                        if (value == StatusEnum.Filled)
                        return "filled";

                throw new NotImplementedException($"Value could not be handled: '{value}'");
            }
        }

        /// <summary>
        /// A Json converter for type <see cref="StatusEnum"/>
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public class StatusEnumJsonConverter : JsonConverter<StatusEnum>
        {
            /// <summary>
            /// Returns a StatusEnum from the Json object
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="typeToConvert"></param>
            /// <param name="options"></param>
            /// <returns></returns>
            public override StatusEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                string rawValue = reader.GetString();

                StatusEnum? result = rawValue == null
                ? null
                : StatusEnumValueConverter.FromStringOrDefault(rawValue);

                if (result != null)
                return result.Value;

                throw new JsonException();
            }

            /// <summary>
            /// Writes the StatusEnum to the json writer
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="statusEnum"></param>
            /// <param name="options"></param>
            public override void Write(Utf8JsonWriter writer, StatusEnum statusEnum, JsonSerializerOptions options)
            {
                writer.WriteStringValue(StatusEnumValueConverter.ToJsonValue(statusEnum));
            }
        }

        /// <summary>
        /// Used to track the state of Status
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<StatusEnum?> StatusOption { get; private set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonPropertyName("status")]
        public StatusEnum? Status { get { return this.StatusOption; } set { this.StatusOption = new(value); } }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Side
        /// </summary>
        [JsonPropertyName("side")]
        public string Side { get; set; }

        /// <summary>
        /// Gets or Sets AssetAddress
        /// </summary>
        [JsonPropertyName("assetAddress")]
        public string AssetAddress { get; set; }

        /// <summary>
        /// Gets or Sets AssetId
        /// </summary>
        [JsonPropertyName("assetId")]
        public string AssetId { get; set; }

        /// <summary>
        /// Gets or Sets ContractKind
        /// </summary>
        [JsonPropertyName("contractKind")]
        public string ContractKind { get; set; }

        /// <summary>
        /// Gets or Sets Maker
        /// </summary>
        [JsonPropertyName("maker")]
        public string Maker { get; set; }

        /// <summary>
        /// Used to track the state of Price
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<PlayerGetAssetListingsResponseDataInnerPrice> PriceOption { get; private set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [JsonPropertyName("price")]
        public PlayerGetAssetListingsResponseDataInnerPrice Price { get { return this.PriceOption; } set { this.PriceOption = new(value); } }

        /// <summary>
        /// Used to track the state of ValidFrom
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> ValidFromOption { get; private set; }

        /// <summary>
        /// Gets or Sets ValidFrom
        /// </summary>
        [JsonPropertyName("validFrom")]
        public DateTime? ValidFrom { get { return this.ValidFromOption; } set { this.ValidFromOption = new(value); } }

        /// <summary>
        /// Used to track the state of ValidUntil
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> ValidUntilOption { get; private set; }

        /// <summary>
        /// Gets or Sets ValidUntil
        /// </summary>
        [JsonPropertyName("validUntil")]
        public DateTime? ValidUntil { get { return this.ValidUntilOption; } set { this.ValidUntilOption = new(value); } }

        /// <summary>
        /// Used to track the state of QuantityFilled
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> QuantityFilledOption { get; private set; }

        /// <summary>
        /// Gets or Sets QuantityFilled
        /// </summary>
        [JsonPropertyName("quantityFilled")]
        public decimal? QuantityFilled { get { return this.QuantityFilledOption; } set { this.QuantityFilledOption = new(value); } }

        /// <summary>
        /// Used to track the state of QuantityRemaining
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> QuantityRemainingOption { get; private set; }

        /// <summary>
        /// Gets or Sets QuantityRemaining
        /// </summary>
        [JsonPropertyName("quantityRemaining")]
        public decimal? QuantityRemaining { get { return this.QuantityRemainingOption; } set { this.QuantityRemainingOption = new(value); } }

        /// <summary>
        /// Used to track the state of ExpiresAt
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> ExpiresAtOption { get; private set; }

        /// <summary>
        /// Gets or Sets ExpiresAt
        /// </summary>
        [JsonPropertyName("expiresAt")]
        public DateTime? ExpiresAt { get { return this.ExpiresAtOption; } set { this.ExpiresAtOption = new(value); } }

        /// <summary>
        /// Used to track the state of CreatedAt
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> CreatedAtOption { get; private set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get { return this.CreatedAtOption; } set { this.CreatedAtOption = new(value); } }

        /// <summary>
        /// Used to track the state of UpdatedAt
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> UpdatedAtOption { get; private set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get { return this.UpdatedAtOption; } set { this.UpdatedAtOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerGetAssetListingsResponseDataInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  AssetAddress: ").Append(AssetAddress).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  ContractKind: ").Append(ContractKind).Append("\n");
            sb.Append("  Maker: ").Append(Maker).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  ValidFrom: ").Append(ValidFrom).Append("\n");
            sb.Append("  ValidUntil: ").Append(ValidUntil).Append("\n");
            sb.Append("  QuantityFilled: ").Append(QuantityFilled).Append("\n");
            sb.Append("  QuantityRemaining: ").Append(QuantityRemaining).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
    /// A Json converter for type <see cref="PlayerGetAssetListingsResponseDataInner" />
    /// </summary>
    public class PlayerGetAssetListingsResponseDataInnerJsonConverter : JsonConverter<PlayerGetAssetListingsResponseDataInner>
    {
        /// <summary>
        /// The format to use to serialize ValidFrom
        /// </summary>
        public static string ValidFromFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize ValidUntil
        /// </summary>
        public static string ValidUntilFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize ExpiresAt
        /// </summary>
        public static string ExpiresAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize CreatedAt
        /// </summary>
        public static string CreatedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize UpdatedAt
        /// </summary>
        public static string UpdatedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="PlayerGetAssetListingsResponseDataInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerGetAssetListingsResponseDataInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> id = default;
            Option<string> side = default;
            Option<string> assetAddress = default;
            Option<string> assetId = default;
            Option<string> contractKind = default;
            Option<string> maker = default;
            Option<PlayerGetAssetListingsResponseDataInner.StatusEnum?> status = default;
            Option<PlayerGetAssetListingsResponseDataInnerPrice> price = default;
            Option<DateTime?> validFrom = default;
            Option<DateTime?> validUntil = default;
            Option<decimal?> quantityFilled = default;
            Option<decimal?> quantityRemaining = default;
            Option<DateTime?> expiresAt = default;
            Option<DateTime?> createdAt = default;
            Option<DateTime?> updatedAt = default;

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
                        case "id":
                            id = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "side":
                            side = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "assetAddress":
                            assetAddress = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "assetId":
                            assetId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "contractKind":
                            contractKind = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "maker":
                            maker = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "status":
                            string statusRawValue = utf8JsonReader.GetString();
                            if (statusRawValue != null)
                                status = new Option<PlayerGetAssetListingsResponseDataInner.StatusEnum?>(PlayerGetAssetListingsResponseDataInner.StatusEnumFromStringOrDefault(statusRawValue));
                            break;
                        case "price":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                price = new Option<PlayerGetAssetListingsResponseDataInnerPrice>(JsonSerializer.Deserialize<PlayerGetAssetListingsResponseDataInnerPrice>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "validFrom":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                validFrom = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "validUntil":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                validUntil = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "quantityFilled":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                quantityFilled = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "quantityRemaining":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                quantityRemaining = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "expiresAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                expiresAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "createdAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "updatedAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                updatedAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetAssetListingsResponseDataInner.", nameof(id));

            if (!side.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetAssetListingsResponseDataInner.", nameof(side));

            if (!assetAddress.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetAssetListingsResponseDataInner.", nameof(assetAddress));

            if (!assetId.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetAssetListingsResponseDataInner.", nameof(assetId));

            if (!contractKind.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetAssetListingsResponseDataInner.", nameof(contractKind));

            if (!maker.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetAssetListingsResponseDataInner.", nameof(maker));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class PlayerGetAssetListingsResponseDataInner.");

            if (side.IsSet && side.Value == null)
                throw new ArgumentNullException(nameof(side), "Property is not nullable for class PlayerGetAssetListingsResponseDataInner.");

            if (assetAddress.IsSet && assetAddress.Value == null)
                throw new ArgumentNullException(nameof(assetAddress), "Property is not nullable for class PlayerGetAssetListingsResponseDataInner.");

            if (assetId.IsSet && assetId.Value == null)
                throw new ArgumentNullException(nameof(assetId), "Property is not nullable for class PlayerGetAssetListingsResponseDataInner.");

            if (contractKind.IsSet && contractKind.Value == null)
                throw new ArgumentNullException(nameof(contractKind), "Property is not nullable for class PlayerGetAssetListingsResponseDataInner.");

            if (maker.IsSet && maker.Value == null)
                throw new ArgumentNullException(nameof(maker), "Property is not nullable for class PlayerGetAssetListingsResponseDataInner.");

            if (quantityFilled.IsSet && quantityFilled.Value == null)
                throw new ArgumentNullException(nameof(quantityFilled), "Property is not nullable for class PlayerGetAssetListingsResponseDataInner.");

            if (quantityRemaining.IsSet && quantityRemaining.Value == null)
                throw new ArgumentNullException(nameof(quantityRemaining), "Property is not nullable for class PlayerGetAssetListingsResponseDataInner.");

            return new PlayerGetAssetListingsResponseDataInner(id.Value, side.Value, assetAddress.Value, assetId.Value, contractKind.Value, maker.Value, status, price, validFrom, validUntil, quantityFilled, quantityRemaining, expiresAt, createdAt, updatedAt);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerGetAssetListingsResponseDataInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetAssetListingsResponseDataInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerGetAssetListingsResponseDataInner playerGetAssetListingsResponseDataInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playerGetAssetListingsResponseDataInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerGetAssetListingsResponseDataInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetAssetListingsResponseDataInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayerGetAssetListingsResponseDataInner playerGetAssetListingsResponseDataInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerGetAssetListingsResponseDataInner.Id == null)
                throw new ArgumentNullException(nameof(playerGetAssetListingsResponseDataInner.Id), "Property is required for class PlayerGetAssetListingsResponseDataInner.");

            if (playerGetAssetListingsResponseDataInner.Side == null)
                throw new ArgumentNullException(nameof(playerGetAssetListingsResponseDataInner.Side), "Property is required for class PlayerGetAssetListingsResponseDataInner.");

            if (playerGetAssetListingsResponseDataInner.AssetAddress == null)
                throw new ArgumentNullException(nameof(playerGetAssetListingsResponseDataInner.AssetAddress), "Property is required for class PlayerGetAssetListingsResponseDataInner.");

            if (playerGetAssetListingsResponseDataInner.AssetId == null)
                throw new ArgumentNullException(nameof(playerGetAssetListingsResponseDataInner.AssetId), "Property is required for class PlayerGetAssetListingsResponseDataInner.");

            if (playerGetAssetListingsResponseDataInner.ContractKind == null)
                throw new ArgumentNullException(nameof(playerGetAssetListingsResponseDataInner.ContractKind), "Property is required for class PlayerGetAssetListingsResponseDataInner.");

            if (playerGetAssetListingsResponseDataInner.Maker == null)
                throw new ArgumentNullException(nameof(playerGetAssetListingsResponseDataInner.Maker), "Property is required for class PlayerGetAssetListingsResponseDataInner.");

            writer.WriteString("id", playerGetAssetListingsResponseDataInner.Id);

            writer.WriteString("side", playerGetAssetListingsResponseDataInner.Side);

            writer.WriteString("assetAddress", playerGetAssetListingsResponseDataInner.AssetAddress);

            writer.WriteString("assetId", playerGetAssetListingsResponseDataInner.AssetId);

            writer.WriteString("contractKind", playerGetAssetListingsResponseDataInner.ContractKind);

            writer.WriteString("maker", playerGetAssetListingsResponseDataInner.Maker);

            var statusRawValue = PlayerGetAssetListingsResponseDataInner.StatusEnumToJsonValue(playerGetAssetListingsResponseDataInner.StatusOption.Value.Value);
            if (statusRawValue != null)
                writer.WriteString("status", statusRawValue);
            else
                writer.WriteNull("status");

            if (playerGetAssetListingsResponseDataInner.PriceOption.IsSet)
                if (playerGetAssetListingsResponseDataInner.PriceOption.Value != null)
                {
                    writer.WritePropertyName("price");
                    JsonSerializer.Serialize(writer, playerGetAssetListingsResponseDataInner.Price, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("price");
            if (playerGetAssetListingsResponseDataInner.ValidFromOption.IsSet)
            {
                if (playerGetAssetListingsResponseDataInner.ValidFromOption.Value != null)
                {
                    writer.WriteString("validFrom", playerGetAssetListingsResponseDataInner.ValidFromOption.Value.Value.ToString(ValidFromFormat));
                }
                else
                {
                    writer.WriteNull("validFrom");
                }

            }

            if (playerGetAssetListingsResponseDataInner.ValidUntilOption.IsSet)
            {
                if (playerGetAssetListingsResponseDataInner.ValidUntilOption.Value != null)
                {
                    writer.WriteString("validUntil", playerGetAssetListingsResponseDataInner.ValidUntilOption.Value.Value.ToString(ValidUntilFormat));
                }
                else
                {
                    writer.WriteNull("validUntil");
                }

            }

            if (playerGetAssetListingsResponseDataInner.QuantityFilledOption.IsSet)
            {
                writer.WriteNumber("quantityFilled", playerGetAssetListingsResponseDataInner.QuantityFilledOption.Value.Value);
            }

            if (playerGetAssetListingsResponseDataInner.QuantityRemainingOption.IsSet)
            {
                writer.WriteNumber("quantityRemaining", playerGetAssetListingsResponseDataInner.QuantityRemainingOption.Value.Value);
            }

            if (playerGetAssetListingsResponseDataInner.ExpiresAtOption.IsSet)
            {
                if (playerGetAssetListingsResponseDataInner.ExpiresAtOption.Value != null)
                {
                    writer.WriteString("expiresAt", playerGetAssetListingsResponseDataInner.ExpiresAtOption.Value.Value.ToString(ExpiresAtFormat));
                }
                else
                {
                    writer.WriteNull("expiresAt");
                }

            }

            if (playerGetAssetListingsResponseDataInner.CreatedAtOption.IsSet)
            {
                if (playerGetAssetListingsResponseDataInner.CreatedAtOption.Value != null)
                {
                    writer.WriteString("createdAt", playerGetAssetListingsResponseDataInner.CreatedAtOption.Value.Value.ToString(CreatedAtFormat));
                }
                else
                {
                    writer.WriteNull("createdAt");
                }

            }

            if (playerGetAssetListingsResponseDataInner.UpdatedAtOption.IsSet)
            {
                if (playerGetAssetListingsResponseDataInner.UpdatedAtOption.Value != null)
                {
                    writer.WriteString("updatedAt", playerGetAssetListingsResponseDataInner.UpdatedAtOption.Value.Value.ToString(UpdatedAtFormat));
                }
                else
                {
                    writer.WriteNull("updatedAt");
                }

            }
        }
    }
}