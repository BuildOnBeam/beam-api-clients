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
    /// PlayerCommonContractActivityRequestInput
    /// </summary>
    public partial class PlayerCommonContractActivityRequestInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerCommonContractActivityRequestInput" /> class.
        /// </summary>
        /// <param name="chainId">chainId (default to 13337)</param>
        /// <param name="continuation">continuation</param>
        /// <param name="limit">limit (default to 20M)</param>
        /// <param name="types">types</param>
        [JsonConstructor]
        public PlayerCommonContractActivityRequestInput(Option<long?> chainId = default, Option<string?> continuation = default, Option<decimal?> limit = default, Option<List<PlayerCommonContractActivityRequestInput.TypesEnum>?> types = default)
        {
            ChainIdOption = chainId;
            ContinuationOption = continuation;
            LimitOption = limit;
            TypesOption = types;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines Types
        /// </summary>
        [JsonConverter(typeof(TypesEnumJsonConverter))]
        public enum TypesEnum
        {
            /// <summary>
            /// Enum Ask for value: ask
            /// </summary>
            Ask = 1,

            /// <summary>
            /// Enum AskCancel for value: ask_cancel
            /// </summary>
            AskCancel = 2,

            /// <summary>
            /// Enum Bid for value: bid
            /// </summary>
            Bid = 3,

            /// <summary>
            /// Enum BidCancel for value: bid_cancel
            /// </summary>
            BidCancel = 4,

            /// <summary>
            /// Enum Sale for value: sale
            /// </summary>
            Sale = 5,

            /// <summary>
            /// Enum Mint for value: mint
            /// </summary>
            Mint = 6,

            /// <summary>
            /// Enum Transfer for value: transfer
            /// </summary>
            Transfer = 7
        }

        /// <summary>
        /// Returns a <see cref="TypesEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static TypesEnum TypesEnumFromString(string value)
        {
            if (value.Equals("ask"))
                return TypesEnum.Ask;

            if (value.Equals("ask_cancel"))
                return TypesEnum.AskCancel;

            if (value.Equals("bid"))
                return TypesEnum.Bid;

            if (value.Equals("bid_cancel"))
                return TypesEnum.BidCancel;

            if (value.Equals("sale"))
                return TypesEnum.Sale;

            if (value.Equals("mint"))
                return TypesEnum.Mint;

            if (value.Equals("transfer"))
                return TypesEnum.Transfer;

            throw new NotImplementedException($"Could not convert value to type TypesEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="TypesEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypesEnum? TypesEnumFromStringOrDefault(string value)
        {
            if (value.Equals("ask"))
                return TypesEnum.Ask;

            if (value.Equals("ask_cancel"))
                return TypesEnum.AskCancel;

            if (value.Equals("bid"))
                return TypesEnum.Bid;

            if (value.Equals("bid_cancel"))
                return TypesEnum.BidCancel;

            if (value.Equals("sale"))
                return TypesEnum.Sale;

            if (value.Equals("mint"))
                return TypesEnum.Mint;

            if (value.Equals("transfer"))
                return TypesEnum.Transfer;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="TypesEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string TypesEnumToJsonValue(TypesEnum? value)
        {
            if (value == TypesEnum.Ask)
                return "ask";

            if (value == TypesEnum.AskCancel)
                return "ask_cancel";

            if (value == TypesEnum.Bid)
                return "bid";

            if (value == TypesEnum.BidCancel)
                return "bid_cancel";

            if (value == TypesEnum.Sale)
                return "sale";

            if (value == TypesEnum.Mint)
                return "mint";

            if (value == TypesEnum.Transfer)
                return "transfer";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Converts <see cref="TypesEnum"/> to and from the JSON value
        /// </summary>
        public static class TypesEnumValueConverter
        {
            /// <summary>
            /// Parses a given value to <see cref="TypesEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static TypesEnum FromString(string value)
            {
                    if (value.Equals("ask"))
                        return TypesEnum.Ask;

                    if (value.Equals("ask_cancel"))
                        return TypesEnum.AskCancel;

                    if (value.Equals("bid"))
                        return TypesEnum.Bid;

                    if (value.Equals("bid_cancel"))
                        return TypesEnum.BidCancel;

                    if (value.Equals("sale"))
                        return TypesEnum.Sale;

                    if (value.Equals("mint"))
                        return TypesEnum.Mint;

                    if (value.Equals("transfer"))
                        return TypesEnum.Transfer;

                throw new NotImplementedException($"Could not convert value to type TypesEnum: '{value}'");
            }

            /// <summary>
            /// Parses a given value to <see cref="TypesEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static TypesEnum? FromStringOrDefault(string value)
            {
                    if (value.Equals("ask"))
                        return TypesEnum.Ask;

                    if (value.Equals("ask_cancel"))
                        return TypesEnum.AskCancel;

                    if (value.Equals("bid"))
                        return TypesEnum.Bid;

                    if (value.Equals("bid_cancel"))
                        return TypesEnum.BidCancel;

                    if (value.Equals("sale"))
                        return TypesEnum.Sale;

                    if (value.Equals("mint"))
                        return TypesEnum.Mint;

                    if (value.Equals("transfer"))
                        return TypesEnum.Transfer;

                return null;
            }

            /// <summary>
            /// Converts the <see cref="TypesEnum"/> to the json value
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            /// <exception cref="NotImplementedException"></exception>
            public static string ToJsonValue(TypesEnum value)
            {
                        if (value == TypesEnum.Ask)
                            return "ask";

                        if (value == TypesEnum.AskCancel)
                            return "ask_cancel";

                        if (value == TypesEnum.Bid)
                            return "bid";

                        if (value == TypesEnum.BidCancel)
                            return "bid_cancel";

                        if (value == TypesEnum.Sale)
                            return "sale";

                        if (value == TypesEnum.Mint)
                            return "mint";

                        if (value == TypesEnum.Transfer)
                            return "transfer";

                throw new NotImplementedException($"Value could not be handled: '{value}'");
            }
        }

        /// <summary>
        /// A Json converter for type <see cref="TypesEnum"/>
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public class TypesEnumJsonConverter : JsonConverter<TypesEnum>
        {
            /// <summary>
            /// Returns a TypesEnum from the Json object
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="typeToConvert"></param>
            /// <param name="options"></param>
            /// <returns></returns>
            public override TypesEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                string? rawValue = reader.GetString();

                TypesEnum? result = rawValue == null
                    ? null
                    : TypesEnumValueConverter.FromStringOrDefault(rawValue);

                if (result != null)
                    return result.Value;

                throw new JsonException();
            }

            /// <summary>
            /// Writes the TypesEnum to the json writer
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="typesEnum"></param>
            /// <param name="options"></param>
            public override void Write(Utf8JsonWriter writer, TypesEnum typesEnum, JsonSerializerOptions options)
            {
                writer.WriteStringValue(TypesEnumValueConverter.ToJsonValue(typesEnum));
            }
        }

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
        /// Used to track the state of Continuation
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ContinuationOption { get; private set; }

        /// <summary>
        /// Gets or Sets Continuation
        /// </summary>
        [JsonPropertyName("continuation")]
        public string? Continuation { get { return this. ContinuationOption; } set { this.ContinuationOption = new(value); } }

        /// <summary>
        /// Used to track the state of Limit
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> LimitOption { get; private set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [JsonPropertyName("limit")]
        public decimal? Limit { get { return this. LimitOption; } set { this.LimitOption = new(value); } }

        /// <summary>
        /// Used to track the state of Types
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<PlayerCommonContractActivityRequestInput.TypesEnum>?> TypesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Types
        /// </summary>
        [JsonPropertyName("types")]
        public List<PlayerCommonContractActivityRequestInput.TypesEnum>? Types { get { return this. TypesOption; } set { this.TypesOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerCommonContractActivityRequestInput {\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Continuation: ").Append(Continuation).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
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
            // Limit (decimal) maximum
            if (this.LimitOption.IsSet && this.LimitOption.Value > (decimal)50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Limit, must be a value less than or equal to 50.", new [] { "Limit" });
            }

            // Limit (decimal) minimum
            if (this.LimitOption.IsSet && this.LimitOption.Value < (decimal)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Limit, must be a value greater than or equal to 1.", new [] { "Limit" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="PlayerCommonContractActivityRequestInput" />
    /// </summary>
    public class PlayerCommonContractActivityRequestInputJsonConverter : JsonConverter<PlayerCommonContractActivityRequestInput>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerCommonContractActivityRequestInput" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerCommonContractActivityRequestInput Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> chainId = default;
            Option<string?> continuation = default;
            Option<decimal?> limit = default;
            Option<List<PlayerCommonContractActivityRequestInput.TypesEnum>?> types = default;

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
                        case "continuation":
                            continuation = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "limit":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                limit = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "types":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                types = new Option<List<PlayerCommonContractActivityRequestInput.TypesEnum>?>(JsonSerializer.Deserialize<List<PlayerCommonContractActivityRequestInput.TypesEnum>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class PlayerCommonContractActivityRequestInput.");

            if (limit.IsSet && limit.Value == null)
                throw new ArgumentNullException(nameof(limit), "Property is not nullable for class PlayerCommonContractActivityRequestInput.");

            return new PlayerCommonContractActivityRequestInput(chainId, continuation, limit, types);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerCommonContractActivityRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerCommonContractActivityRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerCommonContractActivityRequestInput playerCommonContractActivityRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, playerCommonContractActivityRequestInput, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerCommonContractActivityRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerCommonContractActivityRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, PlayerCommonContractActivityRequestInput playerCommonContractActivityRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerCommonContractActivityRequestInput.ChainIdOption.IsSet)
                writer.WriteNumber("chainId", playerCommonContractActivityRequestInput.ChainIdOption.Value!.Value);

            if (playerCommonContractActivityRequestInput.ContinuationOption.IsSet)
                if (playerCommonContractActivityRequestInput.ContinuationOption.Value != null)
                    writer.WriteString("continuation", playerCommonContractActivityRequestInput.Continuation);
                else
                    writer.WriteNull("continuation");

            if (playerCommonContractActivityRequestInput.LimitOption.IsSet)
                writer.WriteNumber("limit", playerCommonContractActivityRequestInput.LimitOption.Value!.Value);

            if (playerCommonContractActivityRequestInput.TypesOption.IsSet)
                if (playerCommonContractActivityRequestInput.TypesOption.Value != null)
                {
                    writer.WritePropertyName("types");
                    JsonSerializer.Serialize(writer, playerCommonContractActivityRequestInput.Types, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("types");
        }
    }
}