// <auto-generated>
/*
 * Automation API
 *
 * The Automation API is a service to integrate your game with Beam
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
using OpenAPIClientUtils = BeamAutomationClient.Client.ClientUtils;
using BeamAutomationClient.Client;

namespace BeamAutomationClient.Model
{
    /// <summary>
    /// AutomationGetAssetResponseV2
    /// </summary>
    public partial class AutomationGetAssetResponseV2 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationGetAssetResponseV2" /> class.
        /// </summary>
        /// <param name="assetAddress">assetAddress</param>
        /// <param name="assetId">assetId</param>
        /// <param name="assetType">assetType</param>
        /// <param name="chainId">chainId</param>
        /// <param name="imageUrl">imageUrl</param>
        /// <param name="name">name</param>
        /// <param name="supply">supply</param>
        /// <param name="attributes">attributes</param>
        /// <param name="owners">owners</param>
        /// <param name="rarity">rarity</param>
        /// <param name="rarityScore">rarityScore</param>
        [JsonConstructor]
        public AutomationGetAssetResponseV2(string assetAddress, string assetId, string assetType, long chainId, string imageUrl, string name, decimal supply, Option<List<AutomationGetAssetsForProfileResponseV2DataInnerAttributesInner>?> attributes = default, List<AutomationGetAssetResponseV2OwnersInner>? owners = default, Option<RarityEnum?> rarity = default, Option<decimal?> rarityScore = default)
        {
            AssetAddress = assetAddress;
            AssetId = assetId;
            AssetType = assetType;
            ChainId = chainId;
            ImageUrl = imageUrl;
            Name = name;
            Supply = supply;
            AttributesOption = attributes;
            Owners = owners;
            RarityOption = rarity;
            RarityScoreOption = rarityScore;
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
        /// Gets or Sets ChainId
        /// </summary>
        [JsonPropertyName("chainId")]
        public long ChainId { get; set; }

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
        public Option<List<AutomationGetAssetsForProfileResponseV2DataInnerAttributesInner>?> AttributesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [JsonPropertyName("attributes")]
        public List<AutomationGetAssetsForProfileResponseV2DataInnerAttributesInner>? Attributes { get { return this. AttributesOption; } set { this.AttributesOption = new(value); } }

        /// <summary>
        /// Gets or Sets Owners
        /// </summary>
        [JsonPropertyName("owners")]
        public List<AutomationGetAssetResponseV2OwnersInner>? Owners { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutomationGetAssetResponseV2 {\n");
            sb.Append("  AssetAddress: ").Append(AssetAddress).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  AssetType: ").Append(AssetType).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Supply: ").Append(Supply).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Owners: ").Append(Owners).Append("\n");
            sb.Append("  Rarity: ").Append(Rarity).Append("\n");
            sb.Append("  RarityScore: ").Append(RarityScore).Append("\n");
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
    /// A Json converter for type <see cref="AutomationGetAssetResponseV2" />
    /// </summary>
    public class AutomationGetAssetResponseV2JsonConverter : JsonConverter<AutomationGetAssetResponseV2>
    {
        /// <summary>
        /// Deserializes json to <see cref="AutomationGetAssetResponseV2" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AutomationGetAssetResponseV2 Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> assetAddress = default;
            Option<string?> assetId = default;
            Option<string?> assetType = default;
            Option<long?> chainId = default;
            Option<string?> imageUrl = default;
            Option<string?> name = default;
            Option<decimal?> supply = default;
            Option<List<AutomationGetAssetsForProfileResponseV2DataInnerAttributesInner>?> attributes = default;
            Option<List<AutomationGetAssetResponseV2OwnersInner>?> owners = default;
            Option<AutomationGetAssetResponseV2.RarityEnum?> rarity = default;
            Option<decimal?> rarityScore = default;

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
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<long?>(utf8JsonReader.GetInt64());
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
                                attributes = new Option<List<AutomationGetAssetsForProfileResponseV2DataInnerAttributesInner>?>(JsonSerializer.Deserialize<List<AutomationGetAssetsForProfileResponseV2DataInnerAttributesInner>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "owners":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                owners = new Option<List<AutomationGetAssetResponseV2OwnersInner>?>(JsonSerializer.Deserialize<List<AutomationGetAssetResponseV2OwnersInner>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "rarity":
                            string? rarityRawValue = utf8JsonReader.GetString();
                            if (rarityRawValue != null)
                                rarity = new Option<AutomationGetAssetResponseV2.RarityEnum?>(AutomationGetAssetResponseV2.RarityEnumFromStringOrDefault(rarityRawValue));
                            break;
                        case "rarityScore":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                rarityScore = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!assetAddress.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetAssetResponseV2.", nameof(assetAddress));

            if (!assetId.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetAssetResponseV2.", nameof(assetId));

            if (!assetType.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetAssetResponseV2.", nameof(assetType));

            if (!chainId.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetAssetResponseV2.", nameof(chainId));

            if (!imageUrl.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetAssetResponseV2.", nameof(imageUrl));

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetAssetResponseV2.", nameof(name));

            if (!supply.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetAssetResponseV2.", nameof(supply));

            if (!owners.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetAssetResponseV2.", nameof(owners));

            if (assetAddress.IsSet && assetAddress.Value == null)
                throw new ArgumentNullException(nameof(assetAddress), "Property is not nullable for class AutomationGetAssetResponseV2.");

            if (assetId.IsSet && assetId.Value == null)
                throw new ArgumentNullException(nameof(assetId), "Property is not nullable for class AutomationGetAssetResponseV2.");

            if (assetType.IsSet && assetType.Value == null)
                throw new ArgumentNullException(nameof(assetType), "Property is not nullable for class AutomationGetAssetResponseV2.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class AutomationGetAssetResponseV2.");

            if (imageUrl.IsSet && imageUrl.Value == null)
                throw new ArgumentNullException(nameof(imageUrl), "Property is not nullable for class AutomationGetAssetResponseV2.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class AutomationGetAssetResponseV2.");

            if (supply.IsSet && supply.Value == null)
                throw new ArgumentNullException(nameof(supply), "Property is not nullable for class AutomationGetAssetResponseV2.");

            return new AutomationGetAssetResponseV2(assetAddress.Value!, assetId.Value!, assetType.Value!, chainId.Value!.Value!, imageUrl.Value!, name.Value!, supply.Value!.Value!, attributes, owners.Value!, rarity, rarityScore);
        }

        /// <summary>
        /// Serializes a <see cref="AutomationGetAssetResponseV2" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationGetAssetResponseV2"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AutomationGetAssetResponseV2 automationGetAssetResponseV2, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, automationGetAssetResponseV2, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AutomationGetAssetResponseV2" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationGetAssetResponseV2"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, AutomationGetAssetResponseV2 automationGetAssetResponseV2, JsonSerializerOptions jsonSerializerOptions)
        {
            if (automationGetAssetResponseV2.AssetAddress == null)
                throw new ArgumentNullException(nameof(automationGetAssetResponseV2.AssetAddress), "Property is required for class AutomationGetAssetResponseV2.");

            if (automationGetAssetResponseV2.AssetId == null)
                throw new ArgumentNullException(nameof(automationGetAssetResponseV2.AssetId), "Property is required for class AutomationGetAssetResponseV2.");

            if (automationGetAssetResponseV2.AssetType == null)
                throw new ArgumentNullException(nameof(automationGetAssetResponseV2.AssetType), "Property is required for class AutomationGetAssetResponseV2.");

            if (automationGetAssetResponseV2.ImageUrl == null)
                throw new ArgumentNullException(nameof(automationGetAssetResponseV2.ImageUrl), "Property is required for class AutomationGetAssetResponseV2.");

            if (automationGetAssetResponseV2.Name == null)
                throw new ArgumentNullException(nameof(automationGetAssetResponseV2.Name), "Property is required for class AutomationGetAssetResponseV2.");

            writer.WriteString("assetAddress", automationGetAssetResponseV2.AssetAddress);

            writer.WriteString("assetId", automationGetAssetResponseV2.AssetId);

            writer.WriteString("assetType", automationGetAssetResponseV2.AssetType);

            writer.WriteNumber("chainId", automationGetAssetResponseV2.ChainId);

            writer.WriteString("imageUrl", automationGetAssetResponseV2.ImageUrl);

            writer.WriteString("name", automationGetAssetResponseV2.Name);

            writer.WriteNumber("supply", automationGetAssetResponseV2.Supply);

            if (automationGetAssetResponseV2.AttributesOption.IsSet)
                if (automationGetAssetResponseV2.AttributesOption.Value != null)
                {
                    writer.WritePropertyName("attributes");
                    JsonSerializer.Serialize(writer, automationGetAssetResponseV2.Attributes, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("attributes");
            if (automationGetAssetResponseV2.Owners != null)
            {
                writer.WritePropertyName("owners");
                JsonSerializer.Serialize(writer, automationGetAssetResponseV2.Owners, jsonSerializerOptions);
            }
            else
                writer.WriteNull("owners");
            var rarityRawValue = AutomationGetAssetResponseV2.RarityEnumToJsonValue(automationGetAssetResponseV2.RarityOption.Value!.Value);
            if (rarityRawValue != null)
                writer.WriteString("rarity", rarityRawValue);
            else
                writer.WriteNull("rarity");

            if (automationGetAssetResponseV2.RarityScoreOption.IsSet)
                if (automationGetAssetResponseV2.RarityScoreOption.Value != null)
                    writer.WriteNumber("rarityScore", automationGetAssetResponseV2.RarityScoreOption.Value!.Value);
                else
                    writer.WriteNull("rarityScore");
        }
    }
}