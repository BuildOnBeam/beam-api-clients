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
    /// AutomationUpdateProfileResponse
    /// </summary>
    public partial class AutomationUpdateProfileResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationUpdateProfileResponse" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="createdAt">createdAt</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="externalId">externalId</param>
        /// <param name="externalEntityId">externalEntityId</param>
        /// <param name="gameId">gameId</param>
        /// <param name="wallets">wallets</param>
        /// <param name="userId">userId</param>
        /// <param name="userConnectionCreatedAt">userConnectionCreatedAt</param>
        [JsonConstructor]
        public AutomationUpdateProfileResponse(string id, DateTime createdAt, DateTime updatedAt, string externalId, string externalEntityId, string gameId, List<AutomationCreateProfileResponseWalletsInner> wallets, string userId = default, Option<DateTime?> userConnectionCreatedAt = default)
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            ExternalId = externalId;
            ExternalEntityId = externalEntityId;
            GameId = gameId;
            Wallets = wallets;
            UserId = userId;
            UserConnectionCreatedAtOption = userConnectionCreatedAt;
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
        /// Gets or Sets ExternalId
        /// </summary>
        [JsonPropertyName("externalId")]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets ExternalEntityId
        /// </summary>
        [JsonPropertyName("externalEntityId")]
        public string ExternalEntityId { get; set; }

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [JsonPropertyName("gameId")]
        public string GameId { get; set; }

        /// <summary>
        /// Gets or Sets Wallets
        /// </summary>
        [JsonPropertyName("wallets")]
        public List<AutomationCreateProfileResponseWalletsInner> Wallets { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Used to track the state of UserConnectionCreatedAt
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> UserConnectionCreatedAtOption { get; private set; }

        /// <summary>
        /// Gets or Sets UserConnectionCreatedAt
        /// </summary>
        [JsonPropertyName("userConnectionCreatedAt")]
        public DateTime? UserConnectionCreatedAt { get { return this.UserConnectionCreatedAtOption; } set { this.UserConnectionCreatedAtOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutomationUpdateProfileResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  ExternalEntityId: ").Append(ExternalEntityId).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  Wallets: ").Append(Wallets).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserConnectionCreatedAt: ").Append(UserConnectionCreatedAt).Append("\n");
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
    /// A Json converter for type <see cref="AutomationUpdateProfileResponse" />
    /// </summary>
    public class AutomationUpdateProfileResponseJsonConverter : JsonConverter<AutomationUpdateProfileResponse>
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
        /// The format to use to serialize UserConnectionCreatedAt
        /// </summary>
        public static string UserConnectionCreatedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="AutomationUpdateProfileResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AutomationUpdateProfileResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> id = default;
            Option<DateTime?> createdAt = default;
            Option<DateTime?> updatedAt = default;
            Option<string> externalId = default;
            Option<string> externalEntityId = default;
            Option<string> gameId = default;
            Option<List<AutomationCreateProfileResponseWalletsInner>> wallets = default;
            Option<string> userId = default;
            Option<DateTime?> userConnectionCreatedAt = default;

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
                        case "externalId":
                            externalId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "externalEntityId":
                            externalEntityId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "gameId":
                            gameId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "wallets":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                wallets = new Option<List<AutomationCreateProfileResponseWalletsInner>>(JsonSerializer.Deserialize<List<AutomationCreateProfileResponseWalletsInner>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "userId":
                            userId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "userConnectionCreatedAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                userConnectionCreatedAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class AutomationUpdateProfileResponse.", nameof(id));

            if (!createdAt.IsSet)
                throw new ArgumentException("Property is required for class AutomationUpdateProfileResponse.", nameof(createdAt));

            if (!updatedAt.IsSet)
                throw new ArgumentException("Property is required for class AutomationUpdateProfileResponse.", nameof(updatedAt));

            if (!externalId.IsSet)
                throw new ArgumentException("Property is required for class AutomationUpdateProfileResponse.", nameof(externalId));

            if (!externalEntityId.IsSet)
                throw new ArgumentException("Property is required for class AutomationUpdateProfileResponse.", nameof(externalEntityId));

            if (!gameId.IsSet)
                throw new ArgumentException("Property is required for class AutomationUpdateProfileResponse.", nameof(gameId));

            if (!wallets.IsSet)
                throw new ArgumentException("Property is required for class AutomationUpdateProfileResponse.", nameof(wallets));

            if (!userId.IsSet)
                throw new ArgumentException("Property is required for class AutomationUpdateProfileResponse.", nameof(userId));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class AutomationUpdateProfileResponse.");

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class AutomationUpdateProfileResponse.");

            if (updatedAt.IsSet && updatedAt.Value == null)
                throw new ArgumentNullException(nameof(updatedAt), "Property is not nullable for class AutomationUpdateProfileResponse.");

            if (externalId.IsSet && externalId.Value == null)
                throw new ArgumentNullException(nameof(externalId), "Property is not nullable for class AutomationUpdateProfileResponse.");

            if (externalEntityId.IsSet && externalEntityId.Value == null)
                throw new ArgumentNullException(nameof(externalEntityId), "Property is not nullable for class AutomationUpdateProfileResponse.");

            if (gameId.IsSet && gameId.Value == null)
                throw new ArgumentNullException(nameof(gameId), "Property is not nullable for class AutomationUpdateProfileResponse.");

            if (wallets.IsSet && wallets.Value == null)
                throw new ArgumentNullException(nameof(wallets), "Property is not nullable for class AutomationUpdateProfileResponse.");

            return new AutomationUpdateProfileResponse(id.Value, createdAt.Value.Value, updatedAt.Value.Value, externalId.Value, externalEntityId.Value, gameId.Value, wallets.Value, userId.Value, userConnectionCreatedAt);
        }

        /// <summary>
        /// Serializes a <see cref="AutomationUpdateProfileResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationUpdateProfileResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AutomationUpdateProfileResponse automationUpdateProfileResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, automationUpdateProfileResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AutomationUpdateProfileResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationUpdateProfileResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AutomationUpdateProfileResponse automationUpdateProfileResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (automationUpdateProfileResponse.Id == null)
                throw new ArgumentNullException(nameof(automationUpdateProfileResponse.Id), "Property is required for class AutomationUpdateProfileResponse.");

            if (automationUpdateProfileResponse.ExternalId == null)
                throw new ArgumentNullException(nameof(automationUpdateProfileResponse.ExternalId), "Property is required for class AutomationUpdateProfileResponse.");

            if (automationUpdateProfileResponse.ExternalEntityId == null)
                throw new ArgumentNullException(nameof(automationUpdateProfileResponse.ExternalEntityId), "Property is required for class AutomationUpdateProfileResponse.");

            if (automationUpdateProfileResponse.GameId == null)
                throw new ArgumentNullException(nameof(automationUpdateProfileResponse.GameId), "Property is required for class AutomationUpdateProfileResponse.");

            if (automationUpdateProfileResponse.Wallets == null)
                throw new ArgumentNullException(nameof(automationUpdateProfileResponse.Wallets), "Property is required for class AutomationUpdateProfileResponse.");

            writer.WriteString("id", automationUpdateProfileResponse.Id);

            writer.WriteString("createdAt", automationUpdateProfileResponse.CreatedAt.ToString(CreatedAtFormat));

            writer.WriteString("updatedAt", automationUpdateProfileResponse.UpdatedAt.ToString(UpdatedAtFormat));

            writer.WriteString("externalId", automationUpdateProfileResponse.ExternalId);

            writer.WriteString("externalEntityId", automationUpdateProfileResponse.ExternalEntityId);

            writer.WriteString("gameId", automationUpdateProfileResponse.GameId);

            writer.WritePropertyName("wallets");
            JsonSerializer.Serialize(writer, automationUpdateProfileResponse.Wallets, jsonSerializerOptions);
            if (automationUpdateProfileResponse.UserId != null)
            {
                writer.WriteString("userId", automationUpdateProfileResponse.UserId);
            }
            else
            {
                writer.WriteNull("userId");
            }

            if (automationUpdateProfileResponse.UserConnectionCreatedAtOption.IsSet)
            {
                if (automationUpdateProfileResponse.UserConnectionCreatedAtOption.Value != null)
                {
                    writer.WriteString("userConnectionCreatedAt", automationUpdateProfileResponse.UserConnectionCreatedAtOption.Value.Value.ToString(UserConnectionCreatedAtFormat));
                }
                else
                {
                    writer.WriteNull("userConnectionCreatedAt");
                }

            }
        }
    }
}