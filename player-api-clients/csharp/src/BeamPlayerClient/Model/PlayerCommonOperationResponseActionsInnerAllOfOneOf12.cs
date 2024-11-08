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
    /// PlayerCommonOperationResponseActionsInnerAllOfOneOf12
    /// </summary>
    public partial class PlayerCommonOperationResponseActionsInnerAllOfOneOf12 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerCommonOperationResponseActionsInnerAllOfOneOf12" /> class.
        /// </summary>
        /// <param name="transaction">transaction</param>
        /// <param name="type">type</param>
        /// <param name="signature">signature</param>
        [JsonConstructor]
        public PlayerCommonOperationResponseActionsInnerAllOfOneOf12(PlayerCommonOperationResponseActionsInnerAllOfOneOfTransaction transaction, TypeEnum type, OneOf? signature = default)
        {
            Transaction = transaction;
            Type = type;
            Signature = signature;
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
            /// Enum CustomTransaction for value: CustomTransaction
            /// </summary>
            CustomTransaction = 1
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static TypeEnum TypeEnumFromString(string value)
        {
            if (value.Equals("CustomTransaction"))
                return TypeEnum.CustomTransaction;

            throw new NotImplementedException($"Could not convert value to type TypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeEnum? TypeEnumFromStringOrDefault(string value)
        {
            if (value.Equals("CustomTransaction"))
                return TypeEnum.CustomTransaction;

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
            if (value == TypeEnum.CustomTransaction)
                return "CustomTransaction";

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
                    if (value.Equals("CustomTransaction"))
                        return TypeEnum.CustomTransaction;

                throw new NotImplementedException($"Could not convert value to type TypeEnum: '{value}'");
            }

            /// <summary>
            /// Parses a given value to <see cref="TypeEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static TypeEnum? FromStringOrDefault(string value)
            {
                    if (value.Equals("CustomTransaction"))
                        return TypeEnum.CustomTransaction;

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
                        if (value == TypeEnum.CustomTransaction)
                            return "CustomTransaction";

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
        /// Gets or Sets Transaction
        /// </summary>
        [JsonPropertyName("transaction")]
        public PlayerCommonOperationResponseActionsInnerAllOfOneOfTransaction Transaction { get; set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [JsonPropertyName("signature")]
        public OneOf? Signature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerCommonOperationResponseActionsInnerAllOfOneOf12 {\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
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
    /// A Json converter for type <see cref="PlayerCommonOperationResponseActionsInnerAllOfOneOf12" />
    /// </summary>
    public class PlayerCommonOperationResponseActionsInnerAllOfOneOf12JsonConverter : JsonConverter<PlayerCommonOperationResponseActionsInnerAllOfOneOf12>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerCommonOperationResponseActionsInnerAllOfOneOf12" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerCommonOperationResponseActionsInnerAllOfOneOf12 Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<PlayerCommonOperationResponseActionsInnerAllOfOneOfTransaction?> transaction = default;
            Option<PlayerCommonOperationResponseActionsInnerAllOfOneOf12.TypeEnum?> type = default;
            Option<OneOf?> signature = default;

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
                        case "transaction":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                transaction = new Option<PlayerCommonOperationResponseActionsInnerAllOfOneOfTransaction?>(JsonSerializer.Deserialize<PlayerCommonOperationResponseActionsInnerAllOfOneOfTransaction>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "type":
                            string? typeRawValue = utf8JsonReader.GetString();
                            if (typeRawValue != null)
                                type = new Option<PlayerCommonOperationResponseActionsInnerAllOfOneOf12.TypeEnum?>(PlayerCommonOperationResponseActionsInnerAllOfOneOf12.TypeEnumFromStringOrDefault(typeRawValue));
                            break;
                        case "signature":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                signature = new Option<OneOf?>(JsonSerializer.Deserialize<OneOf>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!transaction.IsSet)
                throw new ArgumentException("Property is required for class PlayerCommonOperationResponseActionsInnerAllOfOneOf12.", nameof(transaction));

            if (!type.IsSet)
                throw new ArgumentException("Property is required for class PlayerCommonOperationResponseActionsInnerAllOfOneOf12.", nameof(type));

            if (!signature.IsSet)
                throw new ArgumentException("Property is required for class PlayerCommonOperationResponseActionsInnerAllOfOneOf12.", nameof(signature));

            if (transaction.IsSet && transaction.Value == null)
                throw new ArgumentNullException(nameof(transaction), "Property is not nullable for class PlayerCommonOperationResponseActionsInnerAllOfOneOf12.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class PlayerCommonOperationResponseActionsInnerAllOfOneOf12.");

            return new PlayerCommonOperationResponseActionsInnerAllOfOneOf12(transaction.Value!, type.Value!.Value!, signature.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerCommonOperationResponseActionsInnerAllOfOneOf12" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerCommonOperationResponseActionsInnerAllOfOneOf12"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerCommonOperationResponseActionsInnerAllOfOneOf12 playerCommonOperationResponseActionsInnerAllOfOneOf12, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, playerCommonOperationResponseActionsInnerAllOfOneOf12, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerCommonOperationResponseActionsInnerAllOfOneOf12" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerCommonOperationResponseActionsInnerAllOfOneOf12"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, PlayerCommonOperationResponseActionsInnerAllOfOneOf12 playerCommonOperationResponseActionsInnerAllOfOneOf12, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerCommonOperationResponseActionsInnerAllOfOneOf12.Transaction == null)
                throw new ArgumentNullException(nameof(playerCommonOperationResponseActionsInnerAllOfOneOf12.Transaction), "Property is required for class PlayerCommonOperationResponseActionsInnerAllOfOneOf12.");

            writer.WritePropertyName("transaction");
            JsonSerializer.Serialize(writer, playerCommonOperationResponseActionsInnerAllOfOneOf12.Transaction, jsonSerializerOptions);
            var typeRawValue = PlayerCommonOperationResponseActionsInnerAllOfOneOf12.TypeEnumToJsonValue(playerCommonOperationResponseActionsInnerAllOfOneOf12.Type);
            writer.WriteString("type", typeRawValue);
            if (playerCommonOperationResponseActionsInnerAllOfOneOf12.Signature != null)
            {
                writer.WritePropertyName("signature");
                JsonSerializer.Serialize(writer, playerCommonOperationResponseActionsInnerAllOfOneOf12.Signature, jsonSerializerOptions);
            }
            else
                writer.WriteNull("signature");
        }
    }
}