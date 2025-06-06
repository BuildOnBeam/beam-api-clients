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
    /// PlayerGetSessionRequestResponse
    /// </summary>
    public partial class PlayerGetSessionRequestResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerGetSessionRequestResponse" /> class.
        /// </summary>
        /// <param name="status">status</param>
        /// <param name="authProvider">authProvider</param>
        /// <param name="id">id</param>
        /// <param name="createdAt">createdAt</param>
        /// <param name="gameId">gameId</param>
        /// <param name="chainId">chainId</param>
        /// <param name="address">address</param>
        /// <param name="contracts">contracts</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="entityId">entityId</param>
        /// <param name="openfortId">openfortId</param>
        [JsonConstructor]
        public PlayerGetSessionRequestResponse(StatusEnum status, AuthProviderEnum authProvider, string id, DateTime createdAt, string gameId, long chainId, string address, List<string> contracts, DateTime? updatedAt = default, string entityId = default, string openfortId = default)
        {
            Status = status;
            AuthProvider = authProvider;
            Id = id;
            CreatedAt = createdAt;
            GameId = gameId;
            ChainId = chainId;
            Address = address;
            Contracts = contracts;
            UpdatedAt = updatedAt;
            EntityId = entityId;
            OpenfortId = openfortId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StatusEnumJsonConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            Pending = 1,

            /// <summary>
            /// Enum Accepted for value: Accepted
            /// </summary>
            Accepted = 2,

            /// <summary>
            /// Enum Error for value: Error
            /// </summary>
            Error = 3
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

            if (value.Equals("Accepted"))
                return StatusEnum.Accepted;

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

            if (value.Equals("Accepted"))
                return StatusEnum.Accepted;

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
            if (value == null)
                return null;

            if (value == StatusEnum.Pending)
                return "Pending";

            if (value == StatusEnum.Accepted)
                return "Accepted";

            if (value == StatusEnum.Error)
                return "Error";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Converts <see cref="StatusEnum"/> to and from the JSON value
        /// </summary>
        public static class StatusEnumValueConverter
        {
            /// <summary>
            /// Parses a given value to <see cref="StatusEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static StatusEnum FromString(string value)
            {
                    if (value.Equals("Pending"))
                    return StatusEnum.Pending;

                    if (value.Equals("Accepted"))
                    return StatusEnum.Accepted;

                    if (value.Equals("Error"))
                    return StatusEnum.Error;

            throw new NotImplementedException($"Could not convert value to type StatusEnum: '{value}'");
            }

            /// <summary>
            /// Parses a given value to <see cref="StatusEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static StatusEnum? FromStringOrDefault(string value)
            {
                    if (value.Equals("Pending"))
                    return StatusEnum.Pending;

                    if (value.Equals("Accepted"))
                    return StatusEnum.Accepted;

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
            public static string ToJsonValue(StatusEnum value)
            {
                        if (value == StatusEnum.Pending)
                        return "Pending";

                        if (value == StatusEnum.Accepted)
                        return "Accepted";

                        if (value == StatusEnum.Error)
                        return "Error";

                throw new NotImplementedException($"Value could not be handled: '{value}'");
            }
        }

        /// <summary>
        /// A Json converter for type <see cref="StatusEnum"/>
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public class StatusEnumJsonConverter : JsonConverter<StatusEnum>
        {
            /// <summary>
            /// Returns a StatusEnum from the Json object
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="typeToConvert"></param>
            /// <param name="options"></param>
            /// <returns></returns>
            public override StatusEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                string rawValue = reader.GetString();

                StatusEnum? result = rawValue == null
                ? null
                : StatusEnumValueConverter.FromStringOrDefault(rawValue);

                if (result != null)
                return result.Value;

                throw new JsonException();
            }

            /// <summary>
            /// Writes the StatusEnum to the json writer
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="statusEnum"></param>
            /// <param name="options"></param>
            public override void Write(Utf8JsonWriter writer, StatusEnum statusEnum, JsonSerializerOptions options)
            {
                writer.WriteStringValue(StatusEnumValueConverter.ToJsonValue(statusEnum));
            }
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonPropertyName("status")]
        public StatusEnum Status { get; set; }

        /// <summary>
        /// Defines AuthProvider
        /// </summary>
        [JsonConverter(typeof(AuthProviderEnumJsonConverter))]
        public enum AuthProviderEnum
        {
            /// <summary>
            /// Enum Any for value: Any
            /// </summary>
            Any = 1,

            /// <summary>
            /// Enum Google for value: Google
            /// </summary>
            Google = 2,

            /// <summary>
            /// Enum Discord for value: Discord
            /// </summary>
            Discord = 3,

            /// <summary>
            /// Enum Apple for value: Apple
            /// </summary>
            Apple = 4
        }

        /// <summary>
        /// Returns a <see cref="AuthProviderEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static AuthProviderEnum AuthProviderEnumFromString(string value)
        {
            if (value.Equals("Any"))
                return AuthProviderEnum.Any;

            if (value.Equals("Google"))
                return AuthProviderEnum.Google;

            if (value.Equals("Discord"))
                return AuthProviderEnum.Discord;

            if (value.Equals("Apple"))
                return AuthProviderEnum.Apple;

            throw new NotImplementedException($"Could not convert value to type AuthProviderEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="AuthProviderEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static AuthProviderEnum? AuthProviderEnumFromStringOrDefault(string value)
        {
            if (value.Equals("Any"))
                return AuthProviderEnum.Any;

            if (value.Equals("Google"))
                return AuthProviderEnum.Google;

            if (value.Equals("Discord"))
                return AuthProviderEnum.Discord;

            if (value.Equals("Apple"))
                return AuthProviderEnum.Apple;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="AuthProviderEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string AuthProviderEnumToJsonValue(AuthProviderEnum value)
        {
            if (value == null)
                return null;

            if (value == AuthProviderEnum.Any)
                return "Any";

            if (value == AuthProviderEnum.Google)
                return "Google";

            if (value == AuthProviderEnum.Discord)
                return "Discord";

            if (value == AuthProviderEnum.Apple)
                return "Apple";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Converts <see cref="AuthProviderEnum"/> to and from the JSON value
        /// </summary>
        public static class AuthProviderEnumValueConverter
        {
            /// <summary>
            /// Parses a given value to <see cref="AuthProviderEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static AuthProviderEnum FromString(string value)
            {
                    if (value.Equals("Any"))
                    return AuthProviderEnum.Any;

                    if (value.Equals("Google"))
                    return AuthProviderEnum.Google;

                    if (value.Equals("Discord"))
                    return AuthProviderEnum.Discord;

                    if (value.Equals("Apple"))
                    return AuthProviderEnum.Apple;

            throw new NotImplementedException($"Could not convert value to type AuthProviderEnum: '{value}'");
            }

            /// <summary>
            /// Parses a given value to <see cref="AuthProviderEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static AuthProviderEnum? FromStringOrDefault(string value)
            {
                    if (value.Equals("Any"))
                    return AuthProviderEnum.Any;

                    if (value.Equals("Google"))
                    return AuthProviderEnum.Google;

                    if (value.Equals("Discord"))
                    return AuthProviderEnum.Discord;

                    if (value.Equals("Apple"))
                    return AuthProviderEnum.Apple;

            return null;
            }

            /// <summary>
            /// Converts the <see cref="AuthProviderEnum"/> to the json value
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            /// <exception cref="NotImplementedException"></exception>
            public static string ToJsonValue(AuthProviderEnum value)
            {
                        if (value == AuthProviderEnum.Any)
                        return "Any";

                        if (value == AuthProviderEnum.Google)
                        return "Google";

                        if (value == AuthProviderEnum.Discord)
                        return "Discord";

                        if (value == AuthProviderEnum.Apple)
                        return "Apple";

                throw new NotImplementedException($"Value could not be handled: '{value}'");
            }
        }

        /// <summary>
        /// A Json converter for type <see cref="AuthProviderEnum"/>
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public class AuthProviderEnumJsonConverter : JsonConverter<AuthProviderEnum>
        {
            /// <summary>
            /// Returns a AuthProviderEnum from the Json object
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="typeToConvert"></param>
            /// <param name="options"></param>
            /// <returns></returns>
            public override AuthProviderEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                string rawValue = reader.GetString();

                AuthProviderEnum? result = rawValue == null
                ? null
                : AuthProviderEnumValueConverter.FromStringOrDefault(rawValue);

                if (result != null)
                return result.Value;

                throw new JsonException();
            }

            /// <summary>
            /// Writes the AuthProviderEnum to the json writer
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="authProviderEnum"></param>
            /// <param name="options"></param>
            public override void Write(Utf8JsonWriter writer, AuthProviderEnum authProviderEnum, JsonSerializerOptions options)
            {
                writer.WriteStringValue(AuthProviderEnumValueConverter.ToJsonValue(authProviderEnum));
            }
        }

        /// <summary>
        /// Gets or Sets AuthProvider
        /// </summary>
        [JsonPropertyName("authProvider")]
        public AuthProviderEnum AuthProvider { get; set; }

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
        /// Gets or Sets GameId
        /// </summary>
        [JsonPropertyName("gameId")]
        public string GameId { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [JsonPropertyName("chainId")]
        public long ChainId { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Contracts
        /// </summary>
        [JsonPropertyName("contracts")]
        public List<string> Contracts { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets EntityId
        /// </summary>
        [JsonPropertyName("entityId")]
        public string EntityId { get; set; }

        /// <summary>
        /// Gets or Sets OpenfortId
        /// </summary>
        [JsonPropertyName("openfortId")]
        public string OpenfortId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerGetSessionRequestResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  AuthProvider: ").Append(AuthProvider).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Contracts: ").Append(Contracts).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  OpenfortId: ").Append(OpenfortId).Append("\n");
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
    /// A Json converter for type <see cref="PlayerGetSessionRequestResponse" />
    /// </summary>
    public class PlayerGetSessionRequestResponseJsonConverter : JsonConverter<PlayerGetSessionRequestResponse>
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
        /// Deserializes json to <see cref="PlayerGetSessionRequestResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerGetSessionRequestResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<PlayerGetSessionRequestResponse.StatusEnum?> status = default;
            Option<PlayerGetSessionRequestResponse.AuthProviderEnum?> authProvider = default;
            Option<string> id = default;
            Option<DateTime?> createdAt = default;
            Option<string> gameId = default;
            Option<long?> chainId = default;
            Option<string> address = default;
            Option<List<string>> contracts = default;
            Option<DateTime?> updatedAt = default;
            Option<string> entityId = default;
            Option<string> openfortId = default;

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
                        case "status":
                            string statusRawValue = utf8JsonReader.GetString();
                            if (statusRawValue != null)
                                status = new Option<PlayerGetSessionRequestResponse.StatusEnum?>(PlayerGetSessionRequestResponse.StatusEnumFromStringOrDefault(statusRawValue));
                            break;
                        case "authProvider":
                            string authProviderRawValue = utf8JsonReader.GetString();
                            if (authProviderRawValue != null)
                                authProvider = new Option<PlayerGetSessionRequestResponse.AuthProviderEnum?>(PlayerGetSessionRequestResponse.AuthProviderEnumFromStringOrDefault(authProviderRawValue));
                            break;
                        case "id":
                            id = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "createdAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "gameId":
                            gameId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "address":
                            address = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "contracts":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                contracts = new Option<List<string>>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "updatedAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                updatedAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "entityId":
                            entityId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "openfortId":
                            openfortId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!status.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetSessionRequestResponse.", nameof(status));

            if (!authProvider.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetSessionRequestResponse.", nameof(authProvider));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetSessionRequestResponse.", nameof(id));

            if (!createdAt.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetSessionRequestResponse.", nameof(createdAt));

            if (!gameId.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetSessionRequestResponse.", nameof(gameId));

            if (!chainId.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetSessionRequestResponse.", nameof(chainId));

            if (!address.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetSessionRequestResponse.", nameof(address));

            if (!contracts.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetSessionRequestResponse.", nameof(contracts));

            if (!updatedAt.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetSessionRequestResponse.", nameof(updatedAt));

            if (!entityId.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetSessionRequestResponse.", nameof(entityId));

            if (!openfortId.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetSessionRequestResponse.", nameof(openfortId));

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class PlayerGetSessionRequestResponse.");

            if (authProvider.IsSet && authProvider.Value == null)
                throw new ArgumentNullException(nameof(authProvider), "Property is not nullable for class PlayerGetSessionRequestResponse.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class PlayerGetSessionRequestResponse.");

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class PlayerGetSessionRequestResponse.");

            if (gameId.IsSet && gameId.Value == null)
                throw new ArgumentNullException(nameof(gameId), "Property is not nullable for class PlayerGetSessionRequestResponse.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class PlayerGetSessionRequestResponse.");

            if (address.IsSet && address.Value == null)
                throw new ArgumentNullException(nameof(address), "Property is not nullable for class PlayerGetSessionRequestResponse.");

            if (contracts.IsSet && contracts.Value == null)
                throw new ArgumentNullException(nameof(contracts), "Property is not nullable for class PlayerGetSessionRequestResponse.");

            return new PlayerGetSessionRequestResponse(status.Value.Value, authProvider.Value.Value, id.Value, createdAt.Value.Value, gameId.Value, chainId.Value.Value, address.Value, contracts.Value, updatedAt.Value, entityId.Value, openfortId.Value);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerGetSessionRequestResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetSessionRequestResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerGetSessionRequestResponse playerGetSessionRequestResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playerGetSessionRequestResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerGetSessionRequestResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetSessionRequestResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayerGetSessionRequestResponse playerGetSessionRequestResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerGetSessionRequestResponse.Id == null)
                throw new ArgumentNullException(nameof(playerGetSessionRequestResponse.Id), "Property is required for class PlayerGetSessionRequestResponse.");

            if (playerGetSessionRequestResponse.GameId == null)
                throw new ArgumentNullException(nameof(playerGetSessionRequestResponse.GameId), "Property is required for class PlayerGetSessionRequestResponse.");

            if (playerGetSessionRequestResponse.Address == null)
                throw new ArgumentNullException(nameof(playerGetSessionRequestResponse.Address), "Property is required for class PlayerGetSessionRequestResponse.");

            if (playerGetSessionRequestResponse.Contracts == null)
                throw new ArgumentNullException(nameof(playerGetSessionRequestResponse.Contracts), "Property is required for class PlayerGetSessionRequestResponse.");

            var statusRawValue = PlayerGetSessionRequestResponse.StatusEnumToJsonValue(playerGetSessionRequestResponse.Status);
            if (statusRawValue != null)
                writer.WriteString("status", statusRawValue);
            var authProviderRawValue = PlayerGetSessionRequestResponse.AuthProviderEnumToJsonValue(playerGetSessionRequestResponse.AuthProvider);
            if (authProviderRawValue != null)
                writer.WriteString("authProvider", authProviderRawValue);
            writer.WriteString("id", playerGetSessionRequestResponse.Id);

            writer.WriteString("createdAt", playerGetSessionRequestResponse.CreatedAt.ToString(CreatedAtFormat));

            writer.WriteString("gameId", playerGetSessionRequestResponse.GameId);

            writer.WriteNumber("chainId", playerGetSessionRequestResponse.ChainId);

            writer.WriteString("address", playerGetSessionRequestResponse.Address);

            writer.WritePropertyName("contracts");
            JsonSerializer.Serialize(writer, playerGetSessionRequestResponse.Contracts, jsonSerializerOptions);
            if (playerGetSessionRequestResponse.UpdatedAt != null)
            {
                writer.WriteString("updatedAt", playerGetSessionRequestResponse.UpdatedAt.Value.ToString(UpdatedAtFormat));
            }
            else
            {
                writer.WriteNull("updatedAt");
            }

            if (playerGetSessionRequestResponse.EntityId != null)
            {
                writer.WriteString("entityId", playerGetSessionRequestResponse.EntityId);
            }
            else
            {
                writer.WriteNull("entityId");
            }

            if (playerGetSessionRequestResponse.OpenfortId != null)
            {
                writer.WriteString("openfortId", playerGetSessionRequestResponse.OpenfortId);
            }
            else
            {
                writer.WriteNull("openfortId");
            }
        }
    }
}