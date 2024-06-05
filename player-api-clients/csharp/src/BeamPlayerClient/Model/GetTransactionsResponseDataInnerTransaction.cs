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
    /// The transaction object exists if you created the transaction deterministically and contains information about the on-chain transaction
    /// </summary>
    public partial class GetTransactionsResponseDataInnerTransaction : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionsResponseDataInnerTransaction" /> class.
        /// </summary>
        /// <param name="blockNumber">blockNumber</param>
        /// <param name="createdAt">createdAt</param>
        /// <param name="gasFee">gasFee</param>
        /// <param name="gasUsed">gasUsed</param>
        /// <param name="hash">hash</param>
        /// <param name="logs">logs</param>
        /// <param name="status">status</param>
        [JsonConstructor]
        public GetTransactionsResponseDataInnerTransaction(Option<decimal?> blockNumber = default, Object? createdAt = default, Option<string?> gasFee = default, Option<string?> gasUsed = default, Option<string?> hash = default, Option<List<GetTransactionsResponseDataInnerTransactionLogsInner>?> logs = default, Option<decimal?> status = default)
        {
            BlockNumberOption = blockNumber;
            CreatedAt = createdAt;
            GasFeeOption = gasFee;
            GasUsedOption = gasUsed;
            HashOption = hash;
            LogsOption = logs;
            StatusOption = status;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of BlockNumber
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> BlockNumberOption { get; private set; }

        /// <summary>
        /// Gets or Sets BlockNumber
        /// </summary>
        [JsonPropertyName("blockNumber")]
        public decimal? BlockNumber { get { return this. BlockNumberOption; } set { this.BlockNumberOption = new(value); } }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [JsonPropertyName("createdAt")]
        public Object? CreatedAt { get; set; }

        /// <summary>
        /// Used to track the state of GasFee
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> GasFeeOption { get; private set; }

        /// <summary>
        /// Gets or Sets GasFee
        /// </summary>
        [JsonPropertyName("gasFee")]
        public string? GasFee { get { return this. GasFeeOption; } set { this.GasFeeOption = new(value); } }

        /// <summary>
        /// Used to track the state of GasUsed
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> GasUsedOption { get; private set; }

        /// <summary>
        /// Gets or Sets GasUsed
        /// </summary>
        [JsonPropertyName("gasUsed")]
        public string? GasUsed { get { return this. GasUsedOption; } set { this.GasUsedOption = new(value); } }

        /// <summary>
        /// Used to track the state of Hash
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> HashOption { get; private set; }

        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        [JsonPropertyName("hash")]
        public string? Hash { get { return this. HashOption; } set { this.HashOption = new(value); } }

        /// <summary>
        /// Used to track the state of Logs
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<GetTransactionsResponseDataInnerTransactionLogsInner>?> LogsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Logs
        /// </summary>
        [JsonPropertyName("logs")]
        public List<GetTransactionsResponseDataInnerTransactionLogsInner>? Logs { get { return this. LogsOption; } set { this.LogsOption = new(value); } }

        /// <summary>
        /// Used to track the state of Status
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> StatusOption { get; private set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonPropertyName("status")]
        public decimal? Status { get { return this. StatusOption; } set { this.StatusOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTransactionsResponseDataInnerTransaction {\n");
            sb.Append("  BlockNumber: ").Append(BlockNumber).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  GasFee: ").Append(GasFee).Append("\n");
            sb.Append("  GasUsed: ").Append(GasUsed).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Logs: ").Append(Logs).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
    /// A Json converter for type <see cref="GetTransactionsResponseDataInnerTransaction" />
    /// </summary>
    public class GetTransactionsResponseDataInnerTransactionJsonConverter : JsonConverter<GetTransactionsResponseDataInnerTransaction>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetTransactionsResponseDataInnerTransaction" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetTransactionsResponseDataInnerTransaction Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<decimal?> blockNumber = default;
            Option<Object?> createdAt = default;
            Option<string?> gasFee = default;
            Option<string?> gasUsed = default;
            Option<string?> hash = default;
            Option<List<GetTransactionsResponseDataInnerTransactionLogsInner>?> logs = default;
            Option<decimal?> status = default;

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
                        case "blockNumber":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                blockNumber = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "createdAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdAt = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "gasFee":
                            gasFee = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "gasUsed":
                            gasUsed = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "hash":
                            hash = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "logs":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                logs = new Option<List<GetTransactionsResponseDataInnerTransactionLogsInner>?>(JsonSerializer.Deserialize<List<GetTransactionsResponseDataInnerTransactionLogsInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "status":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                status = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!createdAt.IsSet)
                throw new ArgumentException("Property is required for class GetTransactionsResponseDataInnerTransaction.", nameof(createdAt));

            if (blockNumber.IsSet && blockNumber.Value == null)
                throw new ArgumentNullException(nameof(blockNumber), "Property is not nullable for class GetTransactionsResponseDataInnerTransaction.");

            if (gasFee.IsSet && gasFee.Value == null)
                throw new ArgumentNullException(nameof(gasFee), "Property is not nullable for class GetTransactionsResponseDataInnerTransaction.");

            if (gasUsed.IsSet && gasUsed.Value == null)
                throw new ArgumentNullException(nameof(gasUsed), "Property is not nullable for class GetTransactionsResponseDataInnerTransaction.");

            if (hash.IsSet && hash.Value == null)
                throw new ArgumentNullException(nameof(hash), "Property is not nullable for class GetTransactionsResponseDataInnerTransaction.");

            if (logs.IsSet && logs.Value == null)
                throw new ArgumentNullException(nameof(logs), "Property is not nullable for class GetTransactionsResponseDataInnerTransaction.");

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class GetTransactionsResponseDataInnerTransaction.");

            return new GetTransactionsResponseDataInnerTransaction(blockNumber, createdAt.Value!, gasFee, gasUsed, hash, logs, status);
        }

        /// <summary>
        /// Serializes a <see cref="GetTransactionsResponseDataInnerTransaction" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getTransactionsResponseDataInnerTransaction"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetTransactionsResponseDataInnerTransaction getTransactionsResponseDataInnerTransaction, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getTransactionsResponseDataInnerTransaction, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetTransactionsResponseDataInnerTransaction" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getTransactionsResponseDataInnerTransaction"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetTransactionsResponseDataInnerTransaction getTransactionsResponseDataInnerTransaction, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getTransactionsResponseDataInnerTransaction.GasFeeOption.IsSet && getTransactionsResponseDataInnerTransaction.GasFee == null)
                throw new ArgumentNullException(nameof(getTransactionsResponseDataInnerTransaction.GasFee), "Property is required for class GetTransactionsResponseDataInnerTransaction.");

            if (getTransactionsResponseDataInnerTransaction.GasUsedOption.IsSet && getTransactionsResponseDataInnerTransaction.GasUsed == null)
                throw new ArgumentNullException(nameof(getTransactionsResponseDataInnerTransaction.GasUsed), "Property is required for class GetTransactionsResponseDataInnerTransaction.");

            if (getTransactionsResponseDataInnerTransaction.HashOption.IsSet && getTransactionsResponseDataInnerTransaction.Hash == null)
                throw new ArgumentNullException(nameof(getTransactionsResponseDataInnerTransaction.Hash), "Property is required for class GetTransactionsResponseDataInnerTransaction.");

            if (getTransactionsResponseDataInnerTransaction.LogsOption.IsSet && getTransactionsResponseDataInnerTransaction.Logs == null)
                throw new ArgumentNullException(nameof(getTransactionsResponseDataInnerTransaction.Logs), "Property is required for class GetTransactionsResponseDataInnerTransaction.");

            if (getTransactionsResponseDataInnerTransaction.BlockNumberOption.IsSet)
                writer.WriteNumber("blockNumber", getTransactionsResponseDataInnerTransaction.BlockNumberOption.Value!.Value);

            if (getTransactionsResponseDataInnerTransaction.CreatedAt != null)
            {
                writer.WritePropertyName("createdAt");
                JsonSerializer.Serialize(writer, getTransactionsResponseDataInnerTransaction.CreatedAt, jsonSerializerOptions);
            }
            else
                writer.WriteNull("createdAt");
            if (getTransactionsResponseDataInnerTransaction.GasFeeOption.IsSet)
                writer.WriteString("gasFee", getTransactionsResponseDataInnerTransaction.GasFee);

            if (getTransactionsResponseDataInnerTransaction.GasUsedOption.IsSet)
                writer.WriteString("gasUsed", getTransactionsResponseDataInnerTransaction.GasUsed);

            if (getTransactionsResponseDataInnerTransaction.HashOption.IsSet)
                writer.WriteString("hash", getTransactionsResponseDataInnerTransaction.Hash);

            if (getTransactionsResponseDataInnerTransaction.LogsOption.IsSet)
            {
                writer.WritePropertyName("logs");
                JsonSerializer.Serialize(writer, getTransactionsResponseDataInnerTransaction.Logs, jsonSerializerOptions);
            }
            if (getTransactionsResponseDataInnerTransaction.StatusOption.IsSet)
                writer.WriteNumber("status", getTransactionsResponseDataInnerTransaction.StatusOption.Value!.Value);
        }
    }
}