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
    /// PlayerGetTransactionResponse
    /// </summary>
    public partial class PlayerGetTransactionResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerGetTransactionResponse" /> class.
        /// </summary>
        /// <param name="chainId">chainId</param>
        /// <param name="createdAt">createdAt</param>
        /// <param name="id">id</param>
        /// <param name="intent">intent</param>
        /// <param name="policy">policy</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="user">user</param>
        /// <param name="transaction">transaction</param>
        [JsonConstructor]
        public PlayerGetTransactionResponse(long chainId, DateTime createdAt, string id, PlayerGetTransactionsResponseDataInnerIntent intent, PlayerGetTransactionResponsePolicy policy, DateTime updatedAt, PlayerGetTransactionResponseUser user, Option<PlayerGetTransactionsResponseDataInnerTransaction?> transaction = default)
        {
            ChainId = chainId;
            CreatedAt = createdAt;
            Id = id;
            Intent = intent;
            Policy = policy;
            UpdatedAt = updatedAt;
            User = user;
            TransactionOption = transaction;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [JsonPropertyName("chainId")]
        public long ChainId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Intent
        /// </summary>
        [JsonPropertyName("intent")]
        public PlayerGetTransactionsResponseDataInnerIntent Intent { get; set; }

        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [JsonPropertyName("policy")]
        public PlayerGetTransactionResponsePolicy Policy { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [JsonPropertyName("user")]
        public PlayerGetTransactionResponseUser User { get; set; }

        /// <summary>
        /// Used to track the state of Transaction
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<PlayerGetTransactionsResponseDataInnerTransaction?> TransactionOption { get; private set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [JsonPropertyName("transaction")]
        public PlayerGetTransactionsResponseDataInnerTransaction? Transaction { get { return this. TransactionOption; } set { this.TransactionOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerGetTransactionResponse {\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Intent: ").Append(Intent).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
    /// A Json converter for type <see cref="PlayerGetTransactionResponse" />
    /// </summary>
    public class PlayerGetTransactionResponseJsonConverter : JsonConverter<PlayerGetTransactionResponse>
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
        /// Deserializes json to <see cref="PlayerGetTransactionResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerGetTransactionResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> chainId = default;
            Option<DateTime?> createdAt = default;
            Option<string?> id = default;
            Option<PlayerGetTransactionsResponseDataInnerIntent?> intent = default;
            Option<PlayerGetTransactionResponsePolicy?> policy = default;
            Option<DateTime?> updatedAt = default;
            Option<PlayerGetTransactionResponseUser?> user = default;
            Option<PlayerGetTransactionsResponseDataInnerTransaction?> transaction = default;

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
                        case "createdAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "intent":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                intent = new Option<PlayerGetTransactionsResponseDataInnerIntent?>(JsonSerializer.Deserialize<PlayerGetTransactionsResponseDataInnerIntent>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "policy":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                policy = new Option<PlayerGetTransactionResponsePolicy?>(JsonSerializer.Deserialize<PlayerGetTransactionResponsePolicy>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "updatedAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                updatedAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "user":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                user = new Option<PlayerGetTransactionResponseUser?>(JsonSerializer.Deserialize<PlayerGetTransactionResponseUser>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "transaction":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                transaction = new Option<PlayerGetTransactionsResponseDataInnerTransaction?>(JsonSerializer.Deserialize<PlayerGetTransactionsResponseDataInnerTransaction>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!chainId.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetTransactionResponse.", nameof(chainId));

            if (!createdAt.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetTransactionResponse.", nameof(createdAt));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetTransactionResponse.", nameof(id));

            if (!intent.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetTransactionResponse.", nameof(intent));

            if (!policy.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetTransactionResponse.", nameof(policy));

            if (!updatedAt.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetTransactionResponse.", nameof(updatedAt));

            if (!user.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetTransactionResponse.", nameof(user));

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class PlayerGetTransactionResponse.");

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class PlayerGetTransactionResponse.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class PlayerGetTransactionResponse.");

            if (intent.IsSet && intent.Value == null)
                throw new ArgumentNullException(nameof(intent), "Property is not nullable for class PlayerGetTransactionResponse.");

            if (policy.IsSet && policy.Value == null)
                throw new ArgumentNullException(nameof(policy), "Property is not nullable for class PlayerGetTransactionResponse.");

            if (updatedAt.IsSet && updatedAt.Value == null)
                throw new ArgumentNullException(nameof(updatedAt), "Property is not nullable for class PlayerGetTransactionResponse.");

            if (user.IsSet && user.Value == null)
                throw new ArgumentNullException(nameof(user), "Property is not nullable for class PlayerGetTransactionResponse.");

            return new PlayerGetTransactionResponse(chainId.Value!.Value!, createdAt.Value!.Value!, id.Value!, intent.Value!, policy.Value!, updatedAt.Value!.Value!, user.Value!, transaction);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerGetTransactionResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetTransactionResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerGetTransactionResponse playerGetTransactionResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, playerGetTransactionResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerGetTransactionResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetTransactionResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, PlayerGetTransactionResponse playerGetTransactionResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerGetTransactionResponse.Id == null)
                throw new ArgumentNullException(nameof(playerGetTransactionResponse.Id), "Property is required for class PlayerGetTransactionResponse.");

            if (playerGetTransactionResponse.Intent == null)
                throw new ArgumentNullException(nameof(playerGetTransactionResponse.Intent), "Property is required for class PlayerGetTransactionResponse.");

            if (playerGetTransactionResponse.Policy == null)
                throw new ArgumentNullException(nameof(playerGetTransactionResponse.Policy), "Property is required for class PlayerGetTransactionResponse.");

            if (playerGetTransactionResponse.User == null)
                throw new ArgumentNullException(nameof(playerGetTransactionResponse.User), "Property is required for class PlayerGetTransactionResponse.");

            writer.WriteNumber("chainId", playerGetTransactionResponse.ChainId);

            writer.WriteString("createdAt", playerGetTransactionResponse.CreatedAt.ToString(CreatedAtFormat));

            writer.WriteString("id", playerGetTransactionResponse.Id);

            writer.WritePropertyName("intent");
            JsonSerializer.Serialize(writer, playerGetTransactionResponse.Intent, jsonSerializerOptions);
            writer.WritePropertyName("policy");
            JsonSerializer.Serialize(writer, playerGetTransactionResponse.Policy, jsonSerializerOptions);
            writer.WriteString("updatedAt", playerGetTransactionResponse.UpdatedAt.ToString(UpdatedAtFormat));

            writer.WritePropertyName("user");
            JsonSerializer.Serialize(writer, playerGetTransactionResponse.User, jsonSerializerOptions);
            if (playerGetTransactionResponse.TransactionOption.IsSet)
                if (playerGetTransactionResponse.TransactionOption.Value != null)
                {
                    writer.WritePropertyName("transaction");
                    JsonSerializer.Serialize(writer, playerGetTransactionResponse.Transaction, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("transaction");
        }
    }
}