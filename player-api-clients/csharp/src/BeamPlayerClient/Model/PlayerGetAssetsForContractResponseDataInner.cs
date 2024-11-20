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
    /// PlayerGetAssetsForContractResponseDataInner
    /// </summary>
    public partial class PlayerGetAssetsForContractResponseDataInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerGetAssetsForContractResponseDataInner" /> class.
        /// </summary>
        /// <param name="assetAddress">assetAddress</param>
        /// <param name="assetId">assetId</param>
        /// <param name="assetType">assetType</param>
        /// <param name="imageUrl">imageUrl</param>
        /// <param name="name">name</param>
        /// <param name="supply">supply</param>
        /// <param name="attributes">attributes</param>
        /// <param name="chainId">chainId (default to 13337)</param>
        /// <param name="mintedAt">mintedAt</param>
        /// <param name="rarity">rarity</param>
        /// <param name="rarityScore">rarityScore</param>
        /// <param name="updatedAt">updatedAt</param>
        [JsonConstructor]
        public PlayerGetAssetsForContractResponseDataInner(string assetAddress, string assetId, string assetType, string imageUrl, string name, decimal supply, Option<List<PlayerGetAssetsForUserResponseDataInnerAttributesInner>?> attributes = default, Option<long?> chainId = default, Option<DateTime?> mintedAt = default, Option<RarityEnum?> rarity = default, Option<decimal?> rarityScore = default, Option<DateTime?> updatedAt = default)
        {
            AssetAddress = assetAddress;
            AssetId = assetId;
            AssetType = assetType;
            ImageUrl = imageUrl;
            Name = name;
            Supply = supply;
            AttributesOption = attributes;
            ChainIdOption = chainId;
            MintedAtOption = mintedAt;
            RarityOption = rarity;
            RarityScoreOption = rarityScore;
            UpdatedAtOption = updatedAt;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines Rarity
        /// </summary>
        [JsonConverter(typeof(RarityEnumJsonConverter))]
        public enum RarityEnum
        {
            /// <summary>
            /// Enum Common for value: Common
            /// </summary>
            Common = 1,

            /// <summary>
            /// Enum Uncommon for value: Uncommon
            /// </summary>
            Uncommon = 2,

            /// <summary>
            /// Enum Rare for value: Rare
            /// </summary>
            Rare = 3,

            /// <summary>
            /// Enum VeryRare for value: VeryRare
            /// </summary>
            VeryRare = 4,

            /// <summary>
            /// Enum ExtremelyRare for value: ExtremelyRare
            /// </summary>
            ExtremelyRare = 5
        }

        /// <summary>
        /// Returns a <see cref="RarityEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static RarityEnum RarityEnumFromString(string value)
        {
            if (value.Equals("Common"))
                return RarityEnum.Common;

            if (value.Equals("Uncommon"))
                return RarityEnum.Uncommon;

            if (value.Equals("Rare"))
                return RarityEnum.Rare;

            if (value.Equals("VeryRare"))
                return RarityEnum.VeryRare;

            if (value.Equals("ExtremelyRare"))
                return RarityEnum.ExtremelyRare;

            throw new NotImplementedException($"Could not convert value to type RarityEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="RarityEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RarityEnum? RarityEnumFromStringOrDefault(string value)
        {
            if (value.Equals("Common"))
                return RarityEnum.Common;

            if (value.Equals("Uncommon"))
                return RarityEnum.Uncommon;

            if (value.Equals("Rare"))
                return RarityEnum.Rare;

            if (value.Equals("VeryRare"))
                return RarityEnum.VeryRare;

            if (value.Equals("ExtremelyRare"))
                return RarityEnum.ExtremelyRare;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="RarityEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string? RarityEnumToJsonValue(RarityEnum? value)
        {
            if (value == null)
                return null;

            if (value == RarityEnum.Common)
                return "Common";

            if (value == RarityEnum.Uncommon)
                return "Uncommon";

            if (value == RarityEnum.Rare)
                return "Rare";

            if (value == RarityEnum.VeryRare)
                return "VeryRare";

            if (value == RarityEnum.ExtremelyRare)
                return "ExtremelyRare";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Converts <see cref="RarityEnum"/> to and from the JSON value
        /// </summary>
        public static class RarityEnumValueConverter
        {
            /// <summary>
            /// Parses a given value to <see cref="RarityEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static RarityEnum FromString(string value)
            {
                    if (value.Equals("Common"))
                        return RarityEnum.Common;

                    if (value.Equals("Uncommon"))
                        return RarityEnum.Uncommon;

                    if (value.Equals("Rare"))
                        return RarityEnum.Rare;

                    if (value.Equals("VeryRare"))
                        return RarityEnum.VeryRare;

                    if (value.Equals("ExtremelyRare"))
                        return RarityEnum.ExtremelyRare;

                throw new NotImplementedException($"Could not convert value to type RarityEnum: '{value}'");
            }

            /// <summary>
            /// Parses a given value to <see cref="RarityEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static RarityEnum? FromStringOrDefault(string value)
            {
                    if (value.Equals("Common"))
                        return RarityEnum.Common;

                    if (value.Equals("Uncommon"))
                        return RarityEnum.Uncommon;

                    if (value.Equals("Rare"))
                        return RarityEnum.Rare;

                    if (value.Equals("VeryRare"))
                        return RarityEnum.VeryRare;

                    if (value.Equals("ExtremelyRare"))
                        return RarityEnum.ExtremelyRare;

                return null;
            }

            /// <summary>
            /// Converts the <see cref="RarityEnum"/> to the json value
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            /// <exception cref="NotImplementedException"></exception>
            public static string ToJsonValue(RarityEnum value)
            {
                        if (value == RarityEnum.Common)
                            return "Common";

                        if (value == RarityEnum.Uncommon)
                            return "Uncommon";

                        if (value == RarityEnum.Rare)
                            return "Rare";

                        if (value == RarityEnum.VeryRare)
                            return "VeryRare";

                        if (value == RarityEnum.ExtremelyRare)
                            return "ExtremelyRare";

                throw new NotImplementedException($"Value could not be handled: '{value}'");
            }
        }

        /// <summary>
        /// A Json converter for type <see cref="RarityEnum"/>
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public class RarityEnumJsonConverter : JsonConverter<RarityEnum>
        {
            /// <summary>
            /// Returns a RarityEnum from the Json object
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="typeToConvert"></param>
            /// <param name="options"></param>
            /// <returns></returns>
            public override RarityEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                string? rawValue = reader.GetString();

                RarityEnum? result = rawValue == null
                    ? null
                    : RarityEnumValueConverter.FromStringOrDefault(rawValue);

                if (result != null)
                    return result.Value;

                throw new JsonException();
            }

            /// <summary>
            /// Writes the RarityEnum to the json writer
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="rarityEnum"></param>
            /// <param name="options"></param>
            public override void Write(Utf8JsonWriter writer, RarityEnum rarityEnum, JsonSerializerOptions options)
            {
                writer.WriteStringValue(RarityEnumValueConverter.ToJsonValue(rarityEnum));
            }
        }

        /// <summary>
        /// Used to track the state of Rarity
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<RarityEnum?> RarityOption { get; private set; }

        /// <summary>
        /// Gets or Sets Rarity
        /// </summary>
        [JsonPropertyName("rarity")]
        public RarityEnum? Rarity { get { return this.RarityOption; } set { this.RarityOption = new(value); } }

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
        /// Gets or Sets AssetType
        /// </summary>
        [JsonPropertyName("assetType")]
        public string AssetType { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Supply
        /// </summary>
        [JsonPropertyName("supply")]
        public decimal Supply { get; set; }

        /// <summary>
        /// Used to track the state of Attributes
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<PlayerGetAssetsForUserResponseDataInnerAttributesInner>?> AttributesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [JsonPropertyName("attributes")]
        public List<PlayerGetAssetsForUserResponseDataInnerAttributesInner>? Attributes { get { return this. AttributesOption; } set { this.AttributesOption = new(value); } }

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
        /// Used to track the state of MintedAt
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> MintedAtOption { get; private set; }

        /// <summary>
        /// Gets or Sets MintedAt
        /// </summary>
        [JsonPropertyName("mintedAt")]
        public DateTime? MintedAt { get { return this. MintedAtOption; } set { this.MintedAtOption = new(value); } }

        /// <summary>
        /// Used to track the state of RarityScore
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> RarityScoreOption { get; private set; }

        /// <summary>
        /// Gets or Sets RarityScore
        /// </summary>
        [JsonPropertyName("rarityScore")]
        public decimal? RarityScore { get { return this. RarityScoreOption; } set { this.RarityScoreOption = new(value); } }

        /// <summary>
        /// Used to track the state of UpdatedAt
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> UpdatedAtOption { get; private set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get { return this. UpdatedAtOption; } set { this.UpdatedAtOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerGetAssetsForContractResponseDataInner {\n");
            sb.Append("  AssetAddress: ").Append(AssetAddress).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  AssetType: ").Append(AssetType).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Supply: ").Append(Supply).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  MintedAt: ").Append(MintedAt).Append("\n");
            sb.Append("  Rarity: ").Append(Rarity).Append("\n");
            sb.Append("  RarityScore: ").Append(RarityScore).Append("\n");
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
    /// A Json converter for type <see cref="PlayerGetAssetsForContractResponseDataInner" />
    /// </summary>
    public class PlayerGetAssetsForContractResponseDataInnerJsonConverter : JsonConverter<PlayerGetAssetsForContractResponseDataInner>
    {
        /// <summary>
        /// The format to use to serialize MintedAt
        /// </summary>
        public static string MintedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize UpdatedAt
        /// </summary>
        public static string UpdatedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="PlayerGetAssetsForContractResponseDataInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerGetAssetsForContractResponseDataInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> assetAddress = default;
            Option<string?> assetId = default;
            Option<string?> assetType = default;
            Option<string?> imageUrl = default;
            Option<string?> name = default;
            Option<decimal?> supply = default;
            Option<List<PlayerGetAssetsForUserResponseDataInnerAttributesInner>?> attributes = default;
            Option<long?> chainId = default;
            Option<DateTime?> mintedAt = default;
            Option<PlayerGetAssetsForContractResponseDataInner.RarityEnum?> rarity = default;
            Option<decimal?> rarityScore = default;
            Option<DateTime?> updatedAt = default;

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
                        case "assetAddress":
                            assetAddress = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "assetId":
                            assetId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "assetType":
                            assetType = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "imageUrl":
                            imageUrl = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "supply":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                supply = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "attributes":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                attributes = new Option<List<PlayerGetAssetsForUserResponseDataInnerAttributesInner>?>(JsonSerializer.Deserialize<List<PlayerGetAssetsForUserResponseDataInnerAttributesInner>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "mintedAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                mintedAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "rarity":
                            string? rarityRawValue = utf8JsonReader.GetString();
                            if (rarityRawValue != null)
                                rarity = new Option<PlayerGetAssetsForContractResponseDataInner.RarityEnum?>(PlayerGetAssetsForContractResponseDataInner.RarityEnumFromStringOrDefault(rarityRawValue));
                            break;
                        case "rarityScore":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                rarityScore = new Option<decimal?>(utf8JsonReader.GetDecimal());
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

            if (!assetAddress.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetAssetsForContractResponseDataInner.", nameof(assetAddress));

            if (!assetId.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetAssetsForContractResponseDataInner.", nameof(assetId));

            if (!assetType.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetAssetsForContractResponseDataInner.", nameof(assetType));

            if (!imageUrl.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetAssetsForContractResponseDataInner.", nameof(imageUrl));

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetAssetsForContractResponseDataInner.", nameof(name));

            if (!supply.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetAssetsForContractResponseDataInner.", nameof(supply));

            if (assetAddress.IsSet && assetAddress.Value == null)
                throw new ArgumentNullException(nameof(assetAddress), "Property is not nullable for class PlayerGetAssetsForContractResponseDataInner.");

            if (assetId.IsSet && assetId.Value == null)
                throw new ArgumentNullException(nameof(assetId), "Property is not nullable for class PlayerGetAssetsForContractResponseDataInner.");

            if (assetType.IsSet && assetType.Value == null)
                throw new ArgumentNullException(nameof(assetType), "Property is not nullable for class PlayerGetAssetsForContractResponseDataInner.");

            if (imageUrl.IsSet && imageUrl.Value == null)
                throw new ArgumentNullException(nameof(imageUrl), "Property is not nullable for class PlayerGetAssetsForContractResponseDataInner.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class PlayerGetAssetsForContractResponseDataInner.");

            if (supply.IsSet && supply.Value == null)
                throw new ArgumentNullException(nameof(supply), "Property is not nullable for class PlayerGetAssetsForContractResponseDataInner.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class PlayerGetAssetsForContractResponseDataInner.");

            return new PlayerGetAssetsForContractResponseDataInner(assetAddress.Value!, assetId.Value!, assetType.Value!, imageUrl.Value!, name.Value!, supply.Value!.Value!, attributes, chainId, mintedAt, rarity, rarityScore, updatedAt);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerGetAssetsForContractResponseDataInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetAssetsForContractResponseDataInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerGetAssetsForContractResponseDataInner playerGetAssetsForContractResponseDataInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, playerGetAssetsForContractResponseDataInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerGetAssetsForContractResponseDataInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetAssetsForContractResponseDataInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, PlayerGetAssetsForContractResponseDataInner playerGetAssetsForContractResponseDataInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerGetAssetsForContractResponseDataInner.AssetAddress == null)
                throw new ArgumentNullException(nameof(playerGetAssetsForContractResponseDataInner.AssetAddress), "Property is required for class PlayerGetAssetsForContractResponseDataInner.");

            if (playerGetAssetsForContractResponseDataInner.AssetId == null)
                throw new ArgumentNullException(nameof(playerGetAssetsForContractResponseDataInner.AssetId), "Property is required for class PlayerGetAssetsForContractResponseDataInner.");

            if (playerGetAssetsForContractResponseDataInner.AssetType == null)
                throw new ArgumentNullException(nameof(playerGetAssetsForContractResponseDataInner.AssetType), "Property is required for class PlayerGetAssetsForContractResponseDataInner.");

            if (playerGetAssetsForContractResponseDataInner.ImageUrl == null)
                throw new ArgumentNullException(nameof(playerGetAssetsForContractResponseDataInner.ImageUrl), "Property is required for class PlayerGetAssetsForContractResponseDataInner.");

            if (playerGetAssetsForContractResponseDataInner.Name == null)
                throw new ArgumentNullException(nameof(playerGetAssetsForContractResponseDataInner.Name), "Property is required for class PlayerGetAssetsForContractResponseDataInner.");

            writer.WriteString("assetAddress", playerGetAssetsForContractResponseDataInner.AssetAddress);

            writer.WriteString("assetId", playerGetAssetsForContractResponseDataInner.AssetId);

            writer.WriteString("assetType", playerGetAssetsForContractResponseDataInner.AssetType);

            writer.WriteString("imageUrl", playerGetAssetsForContractResponseDataInner.ImageUrl);

            writer.WriteString("name", playerGetAssetsForContractResponseDataInner.Name);

            writer.WriteNumber("supply", playerGetAssetsForContractResponseDataInner.Supply);

            if (playerGetAssetsForContractResponseDataInner.AttributesOption.IsSet)
                if (playerGetAssetsForContractResponseDataInner.AttributesOption.Value != null)
                {
                    writer.WritePropertyName("attributes");
                    JsonSerializer.Serialize(writer, playerGetAssetsForContractResponseDataInner.Attributes, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("attributes");
            if (playerGetAssetsForContractResponseDataInner.ChainIdOption.IsSet)
                writer.WriteNumber("chainId", playerGetAssetsForContractResponseDataInner.ChainIdOption.Value!.Value);

            if (playerGetAssetsForContractResponseDataInner.MintedAtOption.IsSet)
                if (playerGetAssetsForContractResponseDataInner.MintedAtOption.Value != null)
                    writer.WriteString("mintedAt", playerGetAssetsForContractResponseDataInner.MintedAtOption.Value!.Value.ToString(MintedAtFormat));
                else
                    writer.WriteNull("mintedAt");

            var rarityRawValue = PlayerGetAssetsForContractResponseDataInner.RarityEnumToJsonValue(playerGetAssetsForContractResponseDataInner.RarityOption.Value!.Value);
            if (rarityRawValue != null)
                writer.WriteString("rarity", rarityRawValue);
            else
                writer.WriteNull("rarity");

            if (playerGetAssetsForContractResponseDataInner.RarityScoreOption.IsSet)
                if (playerGetAssetsForContractResponseDataInner.RarityScoreOption.Value != null)
                    writer.WriteNumber("rarityScore", playerGetAssetsForContractResponseDataInner.RarityScoreOption.Value!.Value);
                else
                    writer.WriteNull("rarityScore");

            if (playerGetAssetsForContractResponseDataInner.UpdatedAtOption.IsSet)
                if (playerGetAssetsForContractResponseDataInner.UpdatedAtOption.Value != null)
                    writer.WriteString("updatedAt", playerGetAssetsForContractResponseDataInner.UpdatedAtOption.Value!.Value.ToString(UpdatedAtFormat));
                else
                    writer.WriteNull("updatedAt");
        }
    }
}