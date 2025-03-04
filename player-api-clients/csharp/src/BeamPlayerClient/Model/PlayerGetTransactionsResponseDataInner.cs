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
    /// PlayerGetTransactionsResponseDataInner
    /// </summary>
    public partial class PlayerGetTransactionsResponseDataInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerGetTransactionsResponseDataInner" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="createdAt">createdAt</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="chainId">chainId</param>
        /// <param name="intent">intent</param>
        /// <param name="transaction">transaction</param>
        [JsonConstructor]
        public PlayerGetTransactionsResponseDataInner(string id, DateTime createdAt, DateTime updatedAt, long chainId, PlayerGetTransactionsResponseDataInnerIntent intent, Option<PlayerGetTransactionsResponseDataInnerTransaction> transaction = default)
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            ChainId = chainId;
            Intent = intent;
            TransactionOption = transaction;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [JsonPropertyName("chainId")]
        public long ChainId { get; set; }

        /// <summary>
        /// Gets or Sets Intent
        /// </summary>
        [JsonPropertyName("intent")]
        public PlayerGetTransactionsResponseDataInnerIntent Intent { get; set; }

        /// <summary>
        /// Used to track the state of Transaction
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<PlayerGetTransactionsResponseDataInnerTransaction> TransactionOption { get; private set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [JsonPropertyName("transaction")]
        public PlayerGetTransactionsResponseDataInnerTransaction Transaction { get { return this.TransactionOption; } set { this.TransactionOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerGetTransactionsResponseDataInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Intent: ").Append(Intent).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
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
    /// A Json converter for type <see cref="PlayerGetTransactionsResponseDataInner" />
    /// </summary>
    public class PlayerGetTransactionsResponseDataInnerJsonConverter : JsonConverter<PlayerGetTransactionsResponseDataInner>
    {
        /// <summary>
        /// The format to use to serialize CreatedAt
        /// </summary>
        public static string CreatedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize UpdatedAt
        /// </summary>
        public static string UpdatedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="PlayerGetTransactionsResponseDataInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerGetTransactionsResponseDataInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> id = default;
            Option<DateTime?> createdAt = default;
            Option<DateTime?> updatedAt = default;
            Option<long?> chainId = default;
            Option<PlayerGetTransactionsResponseDataInnerIntent> intent = default;
            Option<PlayerGetTransactionsResponseDataInnerTransaction> transaction = default;

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
                        case "createdAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "updatedAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                updatedAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "intent":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                intent = new Option<PlayerGetTransactionsResponseDataInnerIntent>(JsonSerializer.Deserialize<PlayerGetTransactionsResponseDataInnerIntent>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "transaction":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                transaction = new Option<PlayerGetTransactionsResponseDataInnerTransaction>(JsonSerializer.Deserialize<PlayerGetTransactionsResponseDataInnerTransaction>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetTransactionsResponseDataInner.", nameof(id));

            if (!createdAt.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetTransactionsResponseDataInner.", nameof(createdAt));

            if (!updatedAt.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetTransactionsResponseDataInner.", nameof(updatedAt));

            if (!chainId.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetTransactionsResponseDataInner.", nameof(chainId));

            if (!intent.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetTransactionsResponseDataInner.", nameof(intent));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class PlayerGetTransactionsResponseDataInner.");

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class PlayerGetTransactionsResponseDataInner.");

            if (updatedAt.IsSet && updatedAt.Value == null)
                throw new ArgumentNullException(nameof(updatedAt), "Property is not nullable for class PlayerGetTransactionsResponseDataInner.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class PlayerGetTransactionsResponseDataInner.");

            if (intent.IsSet && intent.Value == null)
                throw new ArgumentNullException(nameof(intent), "Property is not nullable for class PlayerGetTransactionsResponseDataInner.");

            return new PlayerGetTransactionsResponseDataInner(id.Value, createdAt.Value.Value, updatedAt.Value.Value, chainId.Value.Value, intent.Value, transaction);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerGetTransactionsResponseDataInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetTransactionsResponseDataInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerGetTransactionsResponseDataInner playerGetTransactionsResponseDataInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playerGetTransactionsResponseDataInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerGetTransactionsResponseDataInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetTransactionsResponseDataInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayerGetTransactionsResponseDataInner playerGetTransactionsResponseDataInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerGetTransactionsResponseDataInner.Id == null)
                throw new ArgumentNullException(nameof(playerGetTransactionsResponseDataInner.Id), "Property is required for class PlayerGetTransactionsResponseDataInner.");

            if (playerGetTransactionsResponseDataInner.Intent == null)
                throw new ArgumentNullException(nameof(playerGetTransactionsResponseDataInner.Intent), "Property is required for class PlayerGetTransactionsResponseDataInner.");

            writer.WriteString("id", playerGetTransactionsResponseDataInner.Id);

            writer.WriteString("createdAt", playerGetTransactionsResponseDataInner.CreatedAt.ToString(CreatedAtFormat));

            writer.WriteString("updatedAt", playerGetTransactionsResponseDataInner.UpdatedAt.ToString(UpdatedAtFormat));

            writer.WriteNumber("chainId", playerGetTransactionsResponseDataInner.ChainId);

            writer.WritePropertyName("intent");
            JsonSerializer.Serialize(writer, playerGetTransactionsResponseDataInner.Intent, jsonSerializerOptions);
            if (playerGetTransactionsResponseDataInner.TransactionOption.IsSet)
                if (playerGetTransactionsResponseDataInner.TransactionOption.Value != null)
                {
                    writer.WritePropertyName("transaction");
                    JsonSerializer.Serialize(writer, playerGetTransactionsResponseDataInner.Transaction, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("transaction");
        }
    }
}