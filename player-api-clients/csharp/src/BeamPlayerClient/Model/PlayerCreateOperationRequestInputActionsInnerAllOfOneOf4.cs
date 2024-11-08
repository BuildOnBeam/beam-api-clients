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
    /// PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4
    /// </summary>
    public partial class PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4" /> class.
        /// </summary>
        /// <param name="signature">signature</param>
        /// <param name="transaction">transaction</param>
        /// <param name="type">type</param>
        [JsonConstructor]
        public PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4(PlayerCreateOperationRequestInputActionsInnerAllOfOneOfSignature signature, PlayerCreateOperationRequestInputActionsInnerAllOfOneOfTransaction transaction, TypeEnum type)
        {
            Signature = signature;
            Transaction = transaction;
            Type = type;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(TypeEnumJsonConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum MarketplaceAcceptOffer for value: MarketplaceAcceptOffer
            /// </summary>
            MarketplaceAcceptOffer = 1
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static TypeEnum TypeEnumFromString(string value)
        {
            if (value.Equals("MarketplaceAcceptOffer"))
                return TypeEnum.MarketplaceAcceptOffer;

            throw new NotImplementedException($"Could not convert value to type TypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeEnum? TypeEnumFromStringOrDefault(string value)
        {
            if (value.Equals("MarketplaceAcceptOffer"))
                return TypeEnum.MarketplaceAcceptOffer;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="TypeEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string TypeEnumToJsonValue(TypeEnum value)
        {
            if (value == TypeEnum.MarketplaceAcceptOffer)
                return "MarketplaceAcceptOffer";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Converts <see cref="TypeEnum"/> to and from the JSON value
        /// </summary>
        public static class TypeEnumValueConverter
        {
            /// <summary>
            /// Parses a given value to <see cref="TypeEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static TypeEnum FromString(string value)
            {
                    if (value.Equals("MarketplaceAcceptOffer"))
                        return TypeEnum.MarketplaceAcceptOffer;

                throw new NotImplementedException($"Could not convert value to type TypeEnum: '{value}'");
            }

            /// <summary>
            /// Parses a given value to <see cref="TypeEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static TypeEnum? FromStringOrDefault(string value)
            {
                    if (value.Equals("MarketplaceAcceptOffer"))
                        return TypeEnum.MarketplaceAcceptOffer;

                return null;
            }

            /// <summary>
            /// Converts the <see cref="TypeEnum"/> to the json value
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            /// <exception cref="NotImplementedException"></exception>
            public static string ToJsonValue(TypeEnum value)
            {
                        if (value == TypeEnum.MarketplaceAcceptOffer)
                            return "MarketplaceAcceptOffer";

                throw new NotImplementedException($"Value could not be handled: '{value}'");
            }
        }

        /// <summary>
        /// A Json converter for type <see cref="TypeEnum"/>
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public class TypeEnumJsonConverter : JsonConverter<TypeEnum>
        {
            /// <summary>
            /// Returns a TypeEnum from the Json object
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="typeToConvert"></param>
            /// <param name="options"></param>
            /// <returns></returns>
            public override TypeEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                string? rawValue = reader.GetString();

                TypeEnum? result = rawValue == null
                    ? null
                    : TypeEnumValueConverter.FromStringOrDefault(rawValue);

                if (result != null)
                    return result.Value;

                throw new JsonException();
            }

            /// <summary>
            /// Writes the TypeEnum to the json writer
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="typeEnum"></param>
            /// <param name="options"></param>
            public override void Write(Utf8JsonWriter writer, TypeEnum typeEnum, JsonSerializerOptions options)
            {
                writer.WriteStringValue(TypeEnumValueConverter.ToJsonValue(typeEnum));
            }
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [JsonPropertyName("signature")]
        public PlayerCreateOperationRequestInputActionsInnerAllOfOneOfSignature Signature { get; set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [JsonPropertyName("transaction")]
        public PlayerCreateOperationRequestInputActionsInnerAllOfOneOfTransaction Transaction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4 {\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
    /// A Json converter for type <see cref="PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4" />
    /// </summary>
    public class PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4JsonConverter : JsonConverter<PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4 Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<PlayerCreateOperationRequestInputActionsInnerAllOfOneOfSignature?> signature = default;
            Option<PlayerCreateOperationRequestInputActionsInnerAllOfOneOfTransaction?> transaction = default;
            Option<PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4.TypeEnum?> type = default;

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
                        case "signature":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                signature = new Option<PlayerCreateOperationRequestInputActionsInnerAllOfOneOfSignature?>(JsonSerializer.Deserialize<PlayerCreateOperationRequestInputActionsInnerAllOfOneOfSignature>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "transaction":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                transaction = new Option<PlayerCreateOperationRequestInputActionsInnerAllOfOneOfTransaction?>(JsonSerializer.Deserialize<PlayerCreateOperationRequestInputActionsInnerAllOfOneOfTransaction>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "type":
                            string? typeRawValue = utf8JsonReader.GetString();
                            if (typeRawValue != null)
                                type = new Option<PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4.TypeEnum?>(PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4.TypeEnumFromStringOrDefault(typeRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!signature.IsSet)
                throw new ArgumentException("Property is required for class PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4.", nameof(signature));

            if (!transaction.IsSet)
                throw new ArgumentException("Property is required for class PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4.", nameof(transaction));

            if (!type.IsSet)
                throw new ArgumentException("Property is required for class PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4.", nameof(type));

            if (signature.IsSet && signature.Value == null)
                throw new ArgumentNullException(nameof(signature), "Property is not nullable for class PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4.");

            if (transaction.IsSet && transaction.Value == null)
                throw new ArgumentNullException(nameof(transaction), "Property is not nullable for class PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4.");

            return new PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4(signature.Value!, transaction.Value!, type.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerCreateOperationRequestInputActionsInnerAllOfOneOf4"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4 playerCreateOperationRequestInputActionsInnerAllOfOneOf4, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, playerCreateOperationRequestInputActionsInnerAllOfOneOf4, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerCreateOperationRequestInputActionsInnerAllOfOneOf4"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4 playerCreateOperationRequestInputActionsInnerAllOfOneOf4, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerCreateOperationRequestInputActionsInnerAllOfOneOf4.Signature == null)
                throw new ArgumentNullException(nameof(playerCreateOperationRequestInputActionsInnerAllOfOneOf4.Signature), "Property is required for class PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4.");

            if (playerCreateOperationRequestInputActionsInnerAllOfOneOf4.Transaction == null)
                throw new ArgumentNullException(nameof(playerCreateOperationRequestInputActionsInnerAllOfOneOf4.Transaction), "Property is required for class PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4.");

            writer.WritePropertyName("signature");
            JsonSerializer.Serialize(writer, playerCreateOperationRequestInputActionsInnerAllOfOneOf4.Signature, jsonSerializerOptions);
            writer.WritePropertyName("transaction");
            JsonSerializer.Serialize(writer, playerCreateOperationRequestInputActionsInnerAllOfOneOf4.Transaction, jsonSerializerOptions);
            var typeRawValue = PlayerCreateOperationRequestInputActionsInnerAllOfOneOf4.TypeEnumToJsonValue(playerCreateOperationRequestInputActionsInnerAllOfOneOf4.Type);
            writer.WriteString("type", typeRawValue);
        }
    }
}