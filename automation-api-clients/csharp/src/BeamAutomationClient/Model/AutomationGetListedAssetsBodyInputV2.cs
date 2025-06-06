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
    /// AutomationGetListedAssetsBodyInputV2
    /// </summary>
    public partial class AutomationGetListedAssetsBodyInputV2 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationGetListedAssetsBodyInputV2" /> class.
        /// </summary>
        /// <param name="assetAddresses">assetAddresses</param>
        /// <param name="sortBy">sortBy (default to SortByEnum.CreatedAt)</param>
        /// <param name="sortDirection">If using &#x60;createdAt&#x60; for sorting, only &#x60;desc&#x60; is allowed. (default to SortDirectionEnum.Desc)</param>
        /// <param name="limit">limit (default to 50)</param>
        /// <param name="chainId">chainId (default to 13337)</param>
        /// <param name="continuation">continuation</param>
        [JsonConstructor]
        public AutomationGetListedAssetsBodyInputV2(Option<List<string>> assetAddresses = default, Option<SortByEnum?> sortBy = default, Option<SortDirectionEnum?> sortDirection = default, Option<int?> limit = default, Option<long?> chainId = default, Option<string> continuation = default)
        {
            AssetAddressesOption = assetAddresses;
            SortByOption = sortBy;
            SortDirectionOption = sortDirection;
            LimitOption = limit;
            ChainIdOption = chainId;
            ContinuationOption = continuation;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines SortBy
        /// </summary>
        [JsonConverter(typeof(SortByEnumJsonConverter))]
        public enum SortByEnum
        {
            /// <summary>
            /// Enum CreatedAt for value: createdAt
            /// </summary>
            CreatedAt = 1,

            /// <summary>
            /// Enum UpdatedAt for value: updatedAt
            /// </summary>
            UpdatedAt = 2,

            /// <summary>
            /// Enum Price for value: price
            /// </summary>
            Price = 3
        }

        /// <summary>
        /// Returns a <see cref="SortByEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static SortByEnum SortByEnumFromString(string value)
        {
            if (value.Equals("createdAt"))
                return SortByEnum.CreatedAt;

            if (value.Equals("updatedAt"))
                return SortByEnum.UpdatedAt;

            if (value.Equals("price"))
                return SortByEnum.Price;

            throw new NotImplementedException($"Could not convert value to type SortByEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="SortByEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static SortByEnum? SortByEnumFromStringOrDefault(string value)
        {
            if (value.Equals("createdAt"))
                return SortByEnum.CreatedAt;

            if (value.Equals("updatedAt"))
                return SortByEnum.UpdatedAt;

            if (value.Equals("price"))
                return SortByEnum.Price;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="SortByEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string SortByEnumToJsonValue(SortByEnum? value)
        {
            if (value == null)
                return null;

            if (value == SortByEnum.CreatedAt)
                return "createdAt";

            if (value == SortByEnum.UpdatedAt)
                return "updatedAt";

            if (value == SortByEnum.Price)
                return "price";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Converts <see cref="SortByEnum"/> to and from the JSON value
        /// </summary>
        public static class SortByEnumValueConverter
        {
            /// <summary>
            /// Parses a given value to <see cref="SortByEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static SortByEnum FromString(string value)
            {
                    if (value.Equals("createdAt"))
                    return SortByEnum.CreatedAt;

                    if (value.Equals("updatedAt"))
                    return SortByEnum.UpdatedAt;

                    if (value.Equals("price"))
                    return SortByEnum.Price;

            throw new NotImplementedException($"Could not convert value to type SortByEnum: '{value}'");
            }

            /// <summary>
            /// Parses a given value to <see cref="SortByEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static SortByEnum? FromStringOrDefault(string value)
            {
                    if (value.Equals("createdAt"))
                    return SortByEnum.CreatedAt;

                    if (value.Equals("updatedAt"))
                    return SortByEnum.UpdatedAt;

                    if (value.Equals("price"))
                    return SortByEnum.Price;

            return null;
            }

            /// <summary>
            /// Converts the <see cref="SortByEnum"/> to the json value
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            /// <exception cref="NotImplementedException"></exception>
            public static string ToJsonValue(SortByEnum value)
            {
                        if (value == SortByEnum.CreatedAt)
                        return "createdAt";

                        if (value == SortByEnum.UpdatedAt)
                        return "updatedAt";

                        if (value == SortByEnum.Price)
                        return "price";

                throw new NotImplementedException($"Value could not be handled: '{value}'");
            }
        }

        /// <summary>
        /// A Json converter for type <see cref="SortByEnum"/>
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public class SortByEnumJsonConverter : JsonConverter<SortByEnum>
        {
            /// <summary>
            /// Returns a SortByEnum from the Json object
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="typeToConvert"></param>
            /// <param name="options"></param>
            /// <returns></returns>
            public override SortByEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                string rawValue = reader.GetString();

                SortByEnum? result = rawValue == null
                ? null
                : SortByEnumValueConverter.FromStringOrDefault(rawValue);

                if (result != null)
                return result.Value;

                throw new JsonException();
            }

            /// <summary>
            /// Writes the SortByEnum to the json writer
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="sortByEnum"></param>
            /// <param name="options"></param>
            public override void Write(Utf8JsonWriter writer, SortByEnum sortByEnum, JsonSerializerOptions options)
            {
                writer.WriteStringValue(SortByEnumValueConverter.ToJsonValue(sortByEnum));
            }
        }

        /// <summary>
        /// Used to track the state of SortBy
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<SortByEnum?> SortByOption { get; private set; }

        /// <summary>
        /// Gets or Sets SortBy
        /// </summary>
        [JsonPropertyName("sortBy")]
        public SortByEnum? SortBy { get { return this.SortByOption; } set { this.SortByOption = new(value); } }

        /// <summary>
        /// If using &#x60;createdAt&#x60; for sorting, only &#x60;desc&#x60; is allowed.
        /// </summary>
        /// <value>If using &#x60;createdAt&#x60; for sorting, only &#x60;desc&#x60; is allowed.</value>
        [JsonConverter(typeof(SortDirectionEnumJsonConverter))]
        public enum SortDirectionEnum
        {
            /// <summary>
            /// Enum Asc for value: asc
            /// </summary>
            Asc = 1,

            /// <summary>
            /// Enum Desc for value: desc
            /// </summary>
            Desc = 2
        }

        /// <summary>
        /// Returns a <see cref="SortDirectionEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static SortDirectionEnum SortDirectionEnumFromString(string value)
        {
            if (value.Equals("asc"))
                return SortDirectionEnum.Asc;

            if (value.Equals("desc"))
                return SortDirectionEnum.Desc;

            throw new NotImplementedException($"Could not convert value to type SortDirectionEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="SortDirectionEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static SortDirectionEnum? SortDirectionEnumFromStringOrDefault(string value)
        {
            if (value.Equals("asc"))
                return SortDirectionEnum.Asc;

            if (value.Equals("desc"))
                return SortDirectionEnum.Desc;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="SortDirectionEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string SortDirectionEnumToJsonValue(SortDirectionEnum? value)
        {
            if (value == null)
                return null;

            if (value == SortDirectionEnum.Asc)
                return "asc";

            if (value == SortDirectionEnum.Desc)
                return "desc";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Converts <see cref="SortDirectionEnum"/> to and from the JSON value
        /// </summary>
        public static class SortDirectionEnumValueConverter
        {
            /// <summary>
            /// Parses a given value to <see cref="SortDirectionEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static SortDirectionEnum FromString(string value)
            {
                    if (value.Equals("asc"))
                    return SortDirectionEnum.Asc;

                    if (value.Equals("desc"))
                    return SortDirectionEnum.Desc;

            throw new NotImplementedException($"Could not convert value to type SortDirectionEnum: '{value}'");
            }

            /// <summary>
            /// Parses a given value to <see cref="SortDirectionEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static SortDirectionEnum? FromStringOrDefault(string value)
            {
                    if (value.Equals("asc"))
                    return SortDirectionEnum.Asc;

                    if (value.Equals("desc"))
                    return SortDirectionEnum.Desc;

            return null;
            }

            /// <summary>
            /// Converts the <see cref="SortDirectionEnum"/> to the json value
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            /// <exception cref="NotImplementedException"></exception>
            public static string ToJsonValue(SortDirectionEnum value)
            {
                        if (value == SortDirectionEnum.Asc)
                        return "asc";

                        if (value == SortDirectionEnum.Desc)
                        return "desc";

                throw new NotImplementedException($"Value could not be handled: '{value}'");
            }
        }

        /// <summary>
        /// A Json converter for type <see cref="SortDirectionEnum"/>
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public class SortDirectionEnumJsonConverter : JsonConverter<SortDirectionEnum>
        {
            /// <summary>
            /// Returns a SortDirectionEnum from the Json object
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="typeToConvert"></param>
            /// <param name="options"></param>
            /// <returns></returns>
            public override SortDirectionEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                string rawValue = reader.GetString();

                SortDirectionEnum? result = rawValue == null
                ? null
                : SortDirectionEnumValueConverter.FromStringOrDefault(rawValue);

                if (result != null)
                return result.Value;

                throw new JsonException();
            }

            /// <summary>
            /// Writes the SortDirectionEnum to the json writer
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="sortDirectionEnum"></param>
            /// <param name="options"></param>
            public override void Write(Utf8JsonWriter writer, SortDirectionEnum sortDirectionEnum, JsonSerializerOptions options)
            {
                writer.WriteStringValue(SortDirectionEnumValueConverter.ToJsonValue(sortDirectionEnum));
            }
        }

        /// <summary>
        /// Used to track the state of SortDirection
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<SortDirectionEnum?> SortDirectionOption { get; private set; }

        /// <summary>
        /// If using &#x60;createdAt&#x60; for sorting, only &#x60;desc&#x60; is allowed.
        /// </summary>
        /// <value>If using &#x60;createdAt&#x60; for sorting, only &#x60;desc&#x60; is allowed.</value>
        [JsonPropertyName("sortDirection")]
        public SortDirectionEnum? SortDirection { get { return this.SortDirectionOption; } set { this.SortDirectionOption = new(value); } }

        /// <summary>
        /// Used to track the state of AssetAddresses
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>> AssetAddressesOption { get; private set; }

        /// <summary>
        /// Gets or Sets AssetAddresses
        /// </summary>
        [JsonPropertyName("assetAddresses")]
        public List<string> AssetAddresses { get { return this.AssetAddressesOption; } set { this.AssetAddressesOption = new(value); } }

        /// <summary>
        /// Used to track the state of Limit
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> LimitOption { get; private set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [JsonPropertyName("limit")]
        public int? Limit { get { return this.LimitOption; } set { this.LimitOption = new(value); } }

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
        /// Used to track the state of Continuation
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ContinuationOption { get; private set; }

        /// <summary>
        /// Gets or Sets Continuation
        /// </summary>
        [JsonPropertyName("continuation")]
        public string Continuation { get { return this.ContinuationOption; } set { this.ContinuationOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutomationGetListedAssetsBodyInputV2 {\n");
            sb.Append("  AssetAddresses: ").Append(AssetAddresses).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
            sb.Append("  SortDirection: ").Append(SortDirection).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Continuation: ").Append(Continuation).Append("\n");
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
            // Limit (int) maximum
            if (this.LimitOption.IsSet && this.LimitOption.Value > (int)1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Limit, must be a value less than or equal to 1000.", new [] { "Limit" });
            }

            // Limit (int) minimum
            if (this.LimitOption.IsSet && this.LimitOption.Value < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Limit, must be a value greater than or equal to 1.", new [] { "Limit" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="AutomationGetListedAssetsBodyInputV2" />
    /// </summary>
    public class AutomationGetListedAssetsBodyInputV2JsonConverter : JsonConverter<AutomationGetListedAssetsBodyInputV2>
    {
        /// <summary>
        /// Deserializes json to <see cref="AutomationGetListedAssetsBodyInputV2" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AutomationGetListedAssetsBodyInputV2 Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<string>> assetAddresses = default;
            Option<AutomationGetListedAssetsBodyInputV2.SortByEnum?> sortBy = default;
            Option<AutomationGetListedAssetsBodyInputV2.SortDirectionEnum?> sortDirection = default;
            Option<int?> limit = default;
            Option<long?> chainId = default;
            Option<string> continuation = default;

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
                        case "assetAddresses":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                assetAddresses = new Option<List<string>>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "sortBy":
                            string sortByRawValue = utf8JsonReader.GetString();
                            if (sortByRawValue != null)
                                sortBy = new Option<AutomationGetListedAssetsBodyInputV2.SortByEnum?>(AutomationGetListedAssetsBodyInputV2.SortByEnumFromStringOrDefault(sortByRawValue));
                            break;
                        case "sortDirection":
                            string sortDirectionRawValue = utf8JsonReader.GetString();
                            if (sortDirectionRawValue != null)
                                sortDirection = new Option<AutomationGetListedAssetsBodyInputV2.SortDirectionEnum?>(AutomationGetListedAssetsBodyInputV2.SortDirectionEnumFromStringOrDefault(sortDirectionRawValue));
                            break;
                        case "limit":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                limit = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "continuation":
                            continuation = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (sortBy.IsSet && sortBy.Value == null)
                throw new ArgumentNullException(nameof(sortBy), "Property is not nullable for class AutomationGetListedAssetsBodyInputV2.");

            if (sortDirection.IsSet && sortDirection.Value == null)
                throw new ArgumentNullException(nameof(sortDirection), "Property is not nullable for class AutomationGetListedAssetsBodyInputV2.");

            if (limit.IsSet && limit.Value == null)
                throw new ArgumentNullException(nameof(limit), "Property is not nullable for class AutomationGetListedAssetsBodyInputV2.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class AutomationGetListedAssetsBodyInputV2.");

            return new AutomationGetListedAssetsBodyInputV2(assetAddresses, sortBy, sortDirection, limit, chainId, continuation);
        }

        /// <summary>
        /// Serializes a <see cref="AutomationGetListedAssetsBodyInputV2" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationGetListedAssetsBodyInputV2"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AutomationGetListedAssetsBodyInputV2 automationGetListedAssetsBodyInputV2, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, automationGetListedAssetsBodyInputV2, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AutomationGetListedAssetsBodyInputV2" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationGetListedAssetsBodyInputV2"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AutomationGetListedAssetsBodyInputV2 automationGetListedAssetsBodyInputV2, JsonSerializerOptions jsonSerializerOptions)
        {
            if (automationGetListedAssetsBodyInputV2.AssetAddressesOption.IsSet)
                if (automationGetListedAssetsBodyInputV2.AssetAddressesOption.Value != null)
                {
                    writer.WritePropertyName("assetAddresses");
                    JsonSerializer.Serialize(writer, automationGetListedAssetsBodyInputV2.AssetAddresses, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("assetAddresses");
            var sortByRawValue = AutomationGetListedAssetsBodyInputV2.SortByEnumToJsonValue(automationGetListedAssetsBodyInputV2.SortByOption.Value);
            if (sortByRawValue != null)
                writer.WriteString("sortBy", sortByRawValue);
            var sortDirectionRawValue = AutomationGetListedAssetsBodyInputV2.SortDirectionEnumToJsonValue(automationGetListedAssetsBodyInputV2.SortDirectionOption.Value);
            if (sortDirectionRawValue != null)
                writer.WriteString("sortDirection", sortDirectionRawValue);
            if (automationGetListedAssetsBodyInputV2.LimitOption.IsSet)
            {
                writer.WriteNumber("limit", automationGetListedAssetsBodyInputV2.LimitOption.Value.Value);
            }

            if (automationGetListedAssetsBodyInputV2.ChainIdOption.IsSet)
            {
                writer.WriteNumber("chainId", automationGetListedAssetsBodyInputV2.ChainIdOption.Value.Value);
            }

            if (automationGetListedAssetsBodyInputV2.ContinuationOption.IsSet)
            {
                if (automationGetListedAssetsBodyInputV2.ContinuationOption.Value != null)
                {
                    writer.WriteString("continuation", automationGetListedAssetsBodyInputV2.Continuation);
                }
                else
                {
                    writer.WriteNull("continuation");
                }

            }
        }
    }
}