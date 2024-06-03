// <auto-generated>
/*
 * Beam self custody API
 *
 * The Beam self custody API is a service to integrate your game with Beam
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
using OpenAPIClientUtils = BeamSelfCustody.Client.ClientUtils;
using BeamSelfCustody.Client;

namespace BeamSelfCustody.Model
{
    /// <summary>
    /// CommonOperationResponse
    /// </summary>
    public partial class CommonOperationResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonOperationResponse" /> class.
        /// </summary>
        /// <param name="chainId">chainId</param>
        /// <param name="createdAt">createdAt</param>
        /// <param name="gameId">gameId</param>
        /// <param name="id">id</param>
        /// <param name="status">status</param>
        /// <param name="transactions">transactions</param>
        /// <param name="url">url</param>
        /// <param name="userId">userId</param>
        /// <param name="updatedAt">updatedAt</param>
        [JsonConstructor]
        public CommonOperationResponse(int chainId, DateTime createdAt, string gameId, string id, StatusEnum status, List<CommonOperationResponseTransactionsInner> transactions, string url, string userId, DateTime? updatedAt = default)
        {
            ChainId = chainId;
            CreatedAt = createdAt;
            GameId = gameId;
            Id = id;
            Status = status;
            Transactions = transactions;
            Url = url;
            UserId = userId;
            UpdatedAt = updatedAt;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines Status
        /// </summary>
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            Pending = 1,

            /// <summary>
            /// Enum Rejected for value: Rejected
            /// </summary>
            Rejected = 2,

            /// <summary>
            /// Enum Executed for value: Executed
            /// </summary>
            Executed = 3,

            /// <summary>
            /// Enum Error for value: Error
            /// </summary>
            Error = 4
        }

        /// <summary>
        /// Returns a <see cref="StatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static StatusEnum StatusEnumFromString(string value)
        {
            if (value.Equals("Pending"))
                return StatusEnum.Pending;

            if (value.Equals("Rejected"))
                return StatusEnum.Rejected;

            if (value.Equals("Executed"))
                return StatusEnum.Executed;

            if (value.Equals("Error"))
                return StatusEnum.Error;

            throw new NotImplementedException($"Could not convert value to type StatusEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="StatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static StatusEnum? StatusEnumFromStringOrDefault(string value)
        {
            if (value.Equals("Pending"))
                return StatusEnum.Pending;

            if (value.Equals("Rejected"))
                return StatusEnum.Rejected;

            if (value.Equals("Executed"))
                return StatusEnum.Executed;

            if (value.Equals("Error"))
                return StatusEnum.Error;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="StatusEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string StatusEnumToJsonValue(StatusEnum value)
        {
            if (value == StatusEnum.Pending)
                return "Pending";

            if (value == StatusEnum.Rejected)
                return "Rejected";

            if (value == StatusEnum.Executed)
                return "Executed";

            if (value == StatusEnum.Error)
                return "Error";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonPropertyName("status")]
        public StatusEnum Status { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [JsonPropertyName("chainId")]
        public int ChainId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [JsonPropertyName("gameId")]
        public string GameId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [JsonPropertyName("transactions")]
        public List<CommonOperationResponseTransactionsInner> Transactions { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CommonOperationResponse {\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
    /// A Json converter for type <see cref="CommonOperationResponse" />
    /// </summary>
    public class CommonOperationResponseJsonConverter : JsonConverter<CommonOperationResponse>
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
        /// Deserializes json to <see cref="CommonOperationResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CommonOperationResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> chainId = default;
            Option<DateTime?> createdAt = default;
            Option<string?> gameId = default;
            Option<string?> id = default;
            Option<CommonOperationResponse.StatusEnum?> status = default;
            Option<List<CommonOperationResponseTransactionsInner>?> transactions = default;
            Option<string?> url = default;
            Option<string?> userId = default;
            Option<DateTime?> updatedAt = default;

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
                                chainId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "createdAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "gameId":
                            gameId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "status":
                            string? statusRawValue = utf8JsonReader.GetString();
                            if (statusRawValue != null)
                                status = new Option<CommonOperationResponse.StatusEnum?>(CommonOperationResponse.StatusEnumFromStringOrDefault(statusRawValue));
                            break;
                        case "transactions":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                transactions = new Option<List<CommonOperationResponseTransactionsInner>?>(JsonSerializer.Deserialize<List<CommonOperationResponseTransactionsInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "url":
                            url = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "userId":
                            userId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "updatedAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                updatedAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!chainId.IsSet)
                throw new ArgumentException("Property is required for class CommonOperationResponse.", nameof(chainId));

            if (!createdAt.IsSet)
                throw new ArgumentException("Property is required for class CommonOperationResponse.", nameof(createdAt));

            if (!gameId.IsSet)
                throw new ArgumentException("Property is required for class CommonOperationResponse.", nameof(gameId));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class CommonOperationResponse.", nameof(id));

            if (!status.IsSet)
                throw new ArgumentException("Property is required for class CommonOperationResponse.", nameof(status));

            if (!transactions.IsSet)
                throw new ArgumentException("Property is required for class CommonOperationResponse.", nameof(transactions));

            if (!url.IsSet)
                throw new ArgumentException("Property is required for class CommonOperationResponse.", nameof(url));

            if (!userId.IsSet)
                throw new ArgumentException("Property is required for class CommonOperationResponse.", nameof(userId));

            if (!updatedAt.IsSet)
                throw new ArgumentException("Property is required for class CommonOperationResponse.", nameof(updatedAt));

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class CommonOperationResponse.");

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class CommonOperationResponse.");

            if (gameId.IsSet && gameId.Value == null)
                throw new ArgumentNullException(nameof(gameId), "Property is not nullable for class CommonOperationResponse.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class CommonOperationResponse.");

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class CommonOperationResponse.");

            if (transactions.IsSet && transactions.Value == null)
                throw new ArgumentNullException(nameof(transactions), "Property is not nullable for class CommonOperationResponse.");

            if (url.IsSet && url.Value == null)
                throw new ArgumentNullException(nameof(url), "Property is not nullable for class CommonOperationResponse.");

            if (userId.IsSet && userId.Value == null)
                throw new ArgumentNullException(nameof(userId), "Property is not nullable for class CommonOperationResponse.");

            return new CommonOperationResponse(chainId.Value!.Value!, createdAt.Value!.Value!, gameId.Value!, id.Value!, status.Value!.Value!, transactions.Value!, url.Value!, userId.Value!, updatedAt.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="CommonOperationResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="commonOperationResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CommonOperationResponse commonOperationResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, commonOperationResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CommonOperationResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="commonOperationResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, CommonOperationResponse commonOperationResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (commonOperationResponse.GameId == null)
                throw new ArgumentNullException(nameof(commonOperationResponse.GameId), "Property is required for class CommonOperationResponse.");

            if (commonOperationResponse.Id == null)
                throw new ArgumentNullException(nameof(commonOperationResponse.Id), "Property is required for class CommonOperationResponse.");

            if (commonOperationResponse.Transactions == null)
                throw new ArgumentNullException(nameof(commonOperationResponse.Transactions), "Property is required for class CommonOperationResponse.");

            if (commonOperationResponse.Url == null)
                throw new ArgumentNullException(nameof(commonOperationResponse.Url), "Property is required for class CommonOperationResponse.");

            if (commonOperationResponse.UserId == null)
                throw new ArgumentNullException(nameof(commonOperationResponse.UserId), "Property is required for class CommonOperationResponse.");

            writer.WriteNumber("chainId", commonOperationResponse.ChainId);

            writer.WriteString("createdAt", commonOperationResponse.CreatedAt.ToString(CreatedAtFormat));

            writer.WriteString("gameId", commonOperationResponse.GameId);

            writer.WriteString("id", commonOperationResponse.Id);

            var statusRawValue = CommonOperationResponse.StatusEnumToJsonValue(commonOperationResponse.Status);
            writer.WriteString("status", statusRawValue);
            writer.WritePropertyName("transactions");
            JsonSerializer.Serialize(writer, commonOperationResponse.Transactions, jsonSerializerOptions);
            writer.WriteString("url", commonOperationResponse.Url);

            writer.WriteString("userId", commonOperationResponse.UserId);

            if (commonOperationResponse.UpdatedAt != null)
                writer.WriteString("updatedAt", commonOperationResponse.UpdatedAt.Value.ToString(UpdatedAtFormat));
            else
                writer.WriteNull("updatedAt");
        }
    }
}