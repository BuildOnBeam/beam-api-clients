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
    /// PlayerGetTransactionsResponseDataInnerTransactionLogsInner
    /// </summary>
    public partial class PlayerGetTransactionsResponseDataInnerTransactionLogsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerGetTransactionsResponseDataInnerTransactionLogsInner" /> class.
        /// </summary>
        /// <param name="blockNumber">blockNumber</param>
        /// <param name="blockHash">blockHash</param>
        /// <param name="transactionIndex">transactionIndex</param>
        /// <param name="removed">removed</param>
        /// <param name="address">address</param>
        /// <param name="data">data</param>
        /// <param name="topics">topics</param>
        /// <param name="transactionHash">transactionHash</param>
        /// <param name="logIndex">logIndex</param>
        /// <param name="orphaned">orphaned</param>
        [JsonConstructor]
        public PlayerGetTransactionsResponseDataInnerTransactionLogsInner(decimal blockNumber, string blockHash, decimal transactionIndex, bool removed, string address, string data, List<string> topics, string transactionHash, decimal logIndex, Option<bool?> orphaned = default)
        {
            BlockNumber = blockNumber;
            BlockHash = blockHash;
            TransactionIndex = transactionIndex;
            Removed = removed;
            Address = address;
            Data = data;
            Topics = topics;
            TransactionHash = transactionHash;
            LogIndex = logIndex;
            OrphanedOption = orphaned;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets BlockNumber
        /// </summary>
        [JsonPropertyName("blockNumber")]
        public decimal BlockNumber { get; set; }

        /// <summary>
        /// Gets or Sets BlockHash
        /// </summary>
        [JsonPropertyName("blockHash")]
        public string BlockHash { get; set; }

        /// <summary>
        /// Gets or Sets TransactionIndex
        /// </summary>
        [JsonPropertyName("transactionIndex")]
        public decimal TransactionIndex { get; set; }

        /// <summary>
        /// Gets or Sets Removed
        /// </summary>
        [JsonPropertyName("removed")]
        public bool Removed { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// Gets or Sets Topics
        /// </summary>
        [JsonPropertyName("topics")]
        public List<string> Topics { get; set; }

        /// <summary>
        /// Gets or Sets TransactionHash
        /// </summary>
        [JsonPropertyName("transactionHash")]
        public string TransactionHash { get; set; }

        /// <summary>
        /// Gets or Sets LogIndex
        /// </summary>
        [JsonPropertyName("logIndex")]
        public decimal LogIndex { get; set; }

        /// <summary>
        /// Used to track the state of Orphaned
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> OrphanedOption { get; private set; }

        /// <summary>
        /// Gets or Sets Orphaned
        /// </summary>
        [JsonPropertyName("orphaned")]
        public bool? Orphaned { get { return this.OrphanedOption; } set { this.OrphanedOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerGetTransactionsResponseDataInnerTransactionLogsInner {\n");
            sb.Append("  BlockNumber: ").Append(BlockNumber).Append("\n");
            sb.Append("  BlockHash: ").Append(BlockHash).Append("\n");
            sb.Append("  TransactionIndex: ").Append(TransactionIndex).Append("\n");
            sb.Append("  Removed: ").Append(Removed).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Topics: ").Append(Topics).Append("\n");
            sb.Append("  TransactionHash: ").Append(TransactionHash).Append("\n");
            sb.Append("  LogIndex: ").Append(LogIndex).Append("\n");
            sb.Append("  Orphaned: ").Append(Orphaned).Append("\n");
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
    /// A Json converter for type <see cref="PlayerGetTransactionsResponseDataInnerTransactionLogsInner" />
    /// </summary>
    public class PlayerGetTransactionsResponseDataInnerTransactionLogsInnerJsonConverter : JsonConverter<PlayerGetTransactionsResponseDataInnerTransactionLogsInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerGetTransactionsResponseDataInnerTransactionLogsInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerGetTransactionsResponseDataInnerTransactionLogsInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<decimal?> blockNumber = default;
            Option<string> blockHash = default;
            Option<decimal?> transactionIndex = default;
            Option<bool?> removed = default;
            Option<string> address = default;
            Option<string> data = default;
            Option<List<string>> topics = default;
            Option<string> transactionHash = default;
            Option<decimal?> logIndex = default;
            Option<bool?> orphaned = default;

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
                        case "blockNumber":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                blockNumber = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "blockHash":
                            blockHash = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "transactionIndex":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                transactionIndex = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "removed":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                removed = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "address":
                            address = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "data":
                            data = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "topics":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                topics = new Option<List<string>>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "transactionHash":
                            transactionHash = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "logIndex":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                logIndex = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "orphaned":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                orphaned = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!blockNumber.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetTransactionsResponseDataInnerTransactionLogsInner.", nameof(blockNumber));

            if (!blockHash.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetTransactionsResponseDataInnerTransactionLogsInner.", nameof(blockHash));

            if (!transactionIndex.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetTransactionsResponseDataInnerTransactionLogsInner.", nameof(transactionIndex));

            if (!removed.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetTransactionsResponseDataInnerTransactionLogsInner.", nameof(removed));

            if (!address.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetTransactionsResponseDataInnerTransactionLogsInner.", nameof(address));

            if (!data.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetTransactionsResponseDataInnerTransactionLogsInner.", nameof(data));

            if (!topics.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetTransactionsResponseDataInnerTransactionLogsInner.", nameof(topics));

            if (!transactionHash.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetTransactionsResponseDataInnerTransactionLogsInner.", nameof(transactionHash));

            if (!logIndex.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetTransactionsResponseDataInnerTransactionLogsInner.", nameof(logIndex));

            if (blockNumber.IsSet && blockNumber.Value == null)
                throw new ArgumentNullException(nameof(blockNumber), "Property is not nullable for class PlayerGetTransactionsResponseDataInnerTransactionLogsInner.");

            if (blockHash.IsSet && blockHash.Value == null)
                throw new ArgumentNullException(nameof(blockHash), "Property is not nullable for class PlayerGetTransactionsResponseDataInnerTransactionLogsInner.");

            if (transactionIndex.IsSet && transactionIndex.Value == null)
                throw new ArgumentNullException(nameof(transactionIndex), "Property is not nullable for class PlayerGetTransactionsResponseDataInnerTransactionLogsInner.");

            if (removed.IsSet && removed.Value == null)
                throw new ArgumentNullException(nameof(removed), "Property is not nullable for class PlayerGetTransactionsResponseDataInnerTransactionLogsInner.");

            if (address.IsSet && address.Value == null)
                throw new ArgumentNullException(nameof(address), "Property is not nullable for class PlayerGetTransactionsResponseDataInnerTransactionLogsInner.");

            if (data.IsSet && data.Value == null)
                throw new ArgumentNullException(nameof(data), "Property is not nullable for class PlayerGetTransactionsResponseDataInnerTransactionLogsInner.");

            if (topics.IsSet && topics.Value == null)
                throw new ArgumentNullException(nameof(topics), "Property is not nullable for class PlayerGetTransactionsResponseDataInnerTransactionLogsInner.");

            if (transactionHash.IsSet && transactionHash.Value == null)
                throw new ArgumentNullException(nameof(transactionHash), "Property is not nullable for class PlayerGetTransactionsResponseDataInnerTransactionLogsInner.");

            if (logIndex.IsSet && logIndex.Value == null)
                throw new ArgumentNullException(nameof(logIndex), "Property is not nullable for class PlayerGetTransactionsResponseDataInnerTransactionLogsInner.");

            return new PlayerGetTransactionsResponseDataInnerTransactionLogsInner(blockNumber.Value.Value, blockHash.Value, transactionIndex.Value.Value, removed.Value.Value, address.Value, data.Value, topics.Value, transactionHash.Value, logIndex.Value.Value, orphaned);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerGetTransactionsResponseDataInnerTransactionLogsInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetTransactionsResponseDataInnerTransactionLogsInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerGetTransactionsResponseDataInnerTransactionLogsInner playerGetTransactionsResponseDataInnerTransactionLogsInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playerGetTransactionsResponseDataInnerTransactionLogsInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerGetTransactionsResponseDataInnerTransactionLogsInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetTransactionsResponseDataInnerTransactionLogsInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayerGetTransactionsResponseDataInnerTransactionLogsInner playerGetTransactionsResponseDataInnerTransactionLogsInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerGetTransactionsResponseDataInnerTransactionLogsInner.BlockHash == null)
                throw new ArgumentNullException(nameof(playerGetTransactionsResponseDataInnerTransactionLogsInner.BlockHash), "Property is required for class PlayerGetTransactionsResponseDataInnerTransactionLogsInner.");

            if (playerGetTransactionsResponseDataInnerTransactionLogsInner.Address == null)
                throw new ArgumentNullException(nameof(playerGetTransactionsResponseDataInnerTransactionLogsInner.Address), "Property is required for class PlayerGetTransactionsResponseDataInnerTransactionLogsInner.");

            if (playerGetTransactionsResponseDataInnerTransactionLogsInner.Data == null)
                throw new ArgumentNullException(nameof(playerGetTransactionsResponseDataInnerTransactionLogsInner.Data), "Property is required for class PlayerGetTransactionsResponseDataInnerTransactionLogsInner.");

            if (playerGetTransactionsResponseDataInnerTransactionLogsInner.Topics == null)
                throw new ArgumentNullException(nameof(playerGetTransactionsResponseDataInnerTransactionLogsInner.Topics), "Property is required for class PlayerGetTransactionsResponseDataInnerTransactionLogsInner.");

            if (playerGetTransactionsResponseDataInnerTransactionLogsInner.TransactionHash == null)
                throw new ArgumentNullException(nameof(playerGetTransactionsResponseDataInnerTransactionLogsInner.TransactionHash), "Property is required for class PlayerGetTransactionsResponseDataInnerTransactionLogsInner.");

            writer.WriteNumber("blockNumber", playerGetTransactionsResponseDataInnerTransactionLogsInner.BlockNumber);

            writer.WriteString("blockHash", playerGetTransactionsResponseDataInnerTransactionLogsInner.BlockHash);

            writer.WriteNumber("transactionIndex", playerGetTransactionsResponseDataInnerTransactionLogsInner.TransactionIndex);

            writer.WriteBoolean("removed", playerGetTransactionsResponseDataInnerTransactionLogsInner.Removed);

            writer.WriteString("address", playerGetTransactionsResponseDataInnerTransactionLogsInner.Address);

            writer.WriteString("data", playerGetTransactionsResponseDataInnerTransactionLogsInner.Data);

            writer.WritePropertyName("topics");
            JsonSerializer.Serialize(writer, playerGetTransactionsResponseDataInnerTransactionLogsInner.Topics, jsonSerializerOptions);
            writer.WriteString("transactionHash", playerGetTransactionsResponseDataInnerTransactionLogsInner.TransactionHash);

            writer.WriteNumber("logIndex", playerGetTransactionsResponseDataInnerTransactionLogsInner.LogIndex);

            if (playerGetTransactionsResponseDataInnerTransactionLogsInner.OrphanedOption.IsSet)
            {
                if (playerGetTransactionsResponseDataInnerTransactionLogsInner.OrphanedOption.Value != null)
                {
                    writer.WriteBoolean("orphaned", playerGetTransactionsResponseDataInnerTransactionLogsInner.OrphanedOption.Value.Value);
                }
                else
                {
                    writer.WriteNull("orphaned");
                }

            }
        }
    }
}