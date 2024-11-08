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
    /// PlayerCreateOperationRequestInput
    /// </summary>
    public partial class PlayerCreateOperationRequestInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerCreateOperationRequestInput" /> class.
        /// </summary>
        /// <param name="entityId">entityId</param>
        /// <param name="actions">actions</param>
        /// <param name="chainId">chainId (default to 13337)</param>
        /// <param name="operationId">operationId</param>
        /// <param name="operationProcessing">operationProcessing (default to OperationProcessingEnum.Execute)</param>
        /// <param name="transactions">transactions</param>
        [JsonConstructor]
        public PlayerCreateOperationRequestInput(string entityId, Option<List<PlayerCreateOperationRequestInputActionsInner>?> actions = default, Option<long?> chainId = default, Option<string?> operationId = default, Option<OperationProcessingEnum?> operationProcessing = default, Option<List<PlayerCreateOperationRequestInputTransactionsInner>?> transactions = default)
        {
            EntityId = entityId;
            ActionsOption = actions;
            ChainIdOption = chainId;
            OperationIdOption = operationId;
            OperationProcessingOption = operationProcessing;
            TransactionsOption = transactions;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines OperationProcessing
        /// </summary>
        [JsonConverter(typeof(OperationProcessingEnumJsonConverter))]
        public enum OperationProcessingEnum
        {
            /// <summary>
            /// Enum SignOnly for value: SignOnly
            /// </summary>
            SignOnly = 1,

            /// <summary>
            /// Enum Execute for value: Execute
            /// </summary>
            Execute = 2
        }

        /// <summary>
        /// Returns a <see cref="OperationProcessingEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static OperationProcessingEnum OperationProcessingEnumFromString(string value)
        {
            if (value.Equals("SignOnly"))
                return OperationProcessingEnum.SignOnly;

            if (value.Equals("Execute"))
                return OperationProcessingEnum.Execute;

            throw new NotImplementedException($"Could not convert value to type OperationProcessingEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="OperationProcessingEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static OperationProcessingEnum? OperationProcessingEnumFromStringOrDefault(string value)
        {
            if (value.Equals("SignOnly"))
                return OperationProcessingEnum.SignOnly;

            if (value.Equals("Execute"))
                return OperationProcessingEnum.Execute;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="OperationProcessingEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string OperationProcessingEnumToJsonValue(OperationProcessingEnum? value)
        {
            if (value == OperationProcessingEnum.SignOnly)
                return "SignOnly";

            if (value == OperationProcessingEnum.Execute)
                return "Execute";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Converts <see cref="OperationProcessingEnum"/> to and from the JSON value
        /// </summary>
        public static class OperationProcessingEnumValueConverter
        {
            /// <summary>
            /// Parses a given value to <see cref="OperationProcessingEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static OperationProcessingEnum FromString(string value)
            {
                    if (value.Equals("SignOnly"))
                        return OperationProcessingEnum.SignOnly;

                    if (value.Equals("Execute"))
                        return OperationProcessingEnum.Execute;

                throw new NotImplementedException($"Could not convert value to type OperationProcessingEnum: '{value}'");
            }

            /// <summary>
            /// Parses a given value to <see cref="OperationProcessingEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static OperationProcessingEnum? FromStringOrDefault(string value)
            {
                    if (value.Equals("SignOnly"))
                        return OperationProcessingEnum.SignOnly;

                    if (value.Equals("Execute"))
                        return OperationProcessingEnum.Execute;

                return null;
            }

            /// <summary>
            /// Converts the <see cref="OperationProcessingEnum"/> to the json value
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            /// <exception cref="NotImplementedException"></exception>
            public static string ToJsonValue(OperationProcessingEnum value)
            {
                        if (value == OperationProcessingEnum.SignOnly)
                            return "SignOnly";

                        if (value == OperationProcessingEnum.Execute)
                            return "Execute";

                throw new NotImplementedException($"Value could not be handled: '{value}'");
            }
        }

        /// <summary>
        /// A Json converter for type <see cref="OperationProcessingEnum"/>
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public class OperationProcessingEnumJsonConverter : JsonConverter<OperationProcessingEnum>
        {
            /// <summary>
            /// Returns a OperationProcessingEnum from the Json object
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="typeToConvert"></param>
            /// <param name="options"></param>
            /// <returns></returns>
            public override OperationProcessingEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                string? rawValue = reader.GetString();

                OperationProcessingEnum? result = rawValue == null
                    ? null
                    : OperationProcessingEnumValueConverter.FromStringOrDefault(rawValue);

                if (result != null)
                    return result.Value;

                throw new JsonException();
            }

            /// <summary>
            /// Writes the OperationProcessingEnum to the json writer
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="operationProcessingEnum"></param>
            /// <param name="options"></param>
            public override void Write(Utf8JsonWriter writer, OperationProcessingEnum operationProcessingEnum, JsonSerializerOptions options)
            {
                writer.WriteStringValue(OperationProcessingEnumValueConverter.ToJsonValue(operationProcessingEnum));
            }
        }

        /// <summary>
        /// Used to track the state of OperationProcessing
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<OperationProcessingEnum?> OperationProcessingOption { get; private set; }

        /// <summary>
        /// Gets or Sets OperationProcessing
        /// </summary>
        [JsonPropertyName("operationProcessing")]
        public OperationProcessingEnum? OperationProcessing { get { return this.OperationProcessingOption; } set { this.OperationProcessingOption = new(value); } }

        /// <summary>
        /// Gets or Sets EntityId
        /// </summary>
        [JsonPropertyName("entityId")]
        public string EntityId { get; set; }

        /// <summary>
        /// Used to track the state of Actions
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<PlayerCreateOperationRequestInputActionsInner>?> ActionsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [JsonPropertyName("actions")]
        public List<PlayerCreateOperationRequestInputActionsInner>? Actions { get { return this. ActionsOption; } set { this.ActionsOption = new(value); } }

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
        /// Used to track the state of OperationId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> OperationIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets OperationId
        /// </summary>
        [JsonPropertyName("operationId")]
        public string? OperationId { get { return this. OperationIdOption; } set { this.OperationIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of Transactions
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<PlayerCreateOperationRequestInputTransactionsInner>?> TransactionsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [JsonPropertyName("transactions")]
        public List<PlayerCreateOperationRequestInputTransactionsInner>? Transactions { get { return this. TransactionsOption; } set { this.TransactionsOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerCreateOperationRequestInput {\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  OperationProcessing: ").Append(OperationProcessing).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
    /// A Json converter for type <see cref="PlayerCreateOperationRequestInput" />
    /// </summary>
    public class PlayerCreateOperationRequestInputJsonConverter : JsonConverter<PlayerCreateOperationRequestInput>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerCreateOperationRequestInput" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerCreateOperationRequestInput Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> entityId = default;
            Option<List<PlayerCreateOperationRequestInputActionsInner>?> actions = default;
            Option<long?> chainId = default;
            Option<string?> operationId = default;
            Option<PlayerCreateOperationRequestInput.OperationProcessingEnum?> operationProcessing = default;
            Option<List<PlayerCreateOperationRequestInputTransactionsInner>?> transactions = default;

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
                        case "entityId":
                            entityId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "actions":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                actions = new Option<List<PlayerCreateOperationRequestInputActionsInner>?>(JsonSerializer.Deserialize<List<PlayerCreateOperationRequestInputActionsInner>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "operationId":
                            operationId = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "operationProcessing":
                            string? operationProcessingRawValue = utf8JsonReader.GetString();
                            if (operationProcessingRawValue != null)
                                operationProcessing = new Option<PlayerCreateOperationRequestInput.OperationProcessingEnum?>(PlayerCreateOperationRequestInput.OperationProcessingEnumFromStringOrDefault(operationProcessingRawValue));
                            break;
                        case "transactions":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                transactions = new Option<List<PlayerCreateOperationRequestInputTransactionsInner>?>(JsonSerializer.Deserialize<List<PlayerCreateOperationRequestInputTransactionsInner>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!entityId.IsSet)
                throw new ArgumentException("Property is required for class PlayerCreateOperationRequestInput.", nameof(entityId));

            if (entityId.IsSet && entityId.Value == null)
                throw new ArgumentNullException(nameof(entityId), "Property is not nullable for class PlayerCreateOperationRequestInput.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class PlayerCreateOperationRequestInput.");

            if (operationProcessing.IsSet && operationProcessing.Value == null)
                throw new ArgumentNullException(nameof(operationProcessing), "Property is not nullable for class PlayerCreateOperationRequestInput.");

            return new PlayerCreateOperationRequestInput(entityId.Value!, actions, chainId, operationId, operationProcessing, transactions);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerCreateOperationRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerCreateOperationRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerCreateOperationRequestInput playerCreateOperationRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, playerCreateOperationRequestInput, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerCreateOperationRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerCreateOperationRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, PlayerCreateOperationRequestInput playerCreateOperationRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerCreateOperationRequestInput.EntityId == null)
                throw new ArgumentNullException(nameof(playerCreateOperationRequestInput.EntityId), "Property is required for class PlayerCreateOperationRequestInput.");

            writer.WriteString("entityId", playerCreateOperationRequestInput.EntityId);

            if (playerCreateOperationRequestInput.ActionsOption.IsSet)
                if (playerCreateOperationRequestInput.ActionsOption.Value != null)
                {
                    writer.WritePropertyName("actions");
                    JsonSerializer.Serialize(writer, playerCreateOperationRequestInput.Actions, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("actions");
            if (playerCreateOperationRequestInput.ChainIdOption.IsSet)
                writer.WriteNumber("chainId", playerCreateOperationRequestInput.ChainIdOption.Value!.Value);

            if (playerCreateOperationRequestInput.OperationIdOption.IsSet)
                if (playerCreateOperationRequestInput.OperationIdOption.Value != null)
                    writer.WriteString("operationId", playerCreateOperationRequestInput.OperationId);
                else
                    writer.WriteNull("operationId");

            var operationProcessingRawValue = PlayerCreateOperationRequestInput.OperationProcessingEnumToJsonValue(playerCreateOperationRequestInput.OperationProcessingOption.Value!.Value);
            writer.WriteString("operationProcessing", operationProcessingRawValue);
            if (playerCreateOperationRequestInput.TransactionsOption.IsSet)
                if (playerCreateOperationRequestInput.TransactionsOption.Value != null)
                {
                    writer.WritePropertyName("transactions");
                    JsonSerializer.Serialize(writer, playerCreateOperationRequestInput.Transactions, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("transactions");
        }
    }
}