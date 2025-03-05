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
    /// PlayerCreateConnectionRequestInput
    /// </summary>
    public partial class PlayerCreateConnectionRequestInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerCreateConnectionRequestInput" /> class.
        /// </summary>
        /// <param name="entityId">entityId</param>
        /// <param name="authProvider">Auth Provider for the user to use. If it&#39;s Any, user will be able to choose his preferred login method. Useful when you want to present social login choice in your UI. (default to AuthProviderEnum.Any)</param>
        /// <param name="chainId">chainId (default to 13337)</param>
        [JsonConstructor]
        public PlayerCreateConnectionRequestInput(string entityId, Option<AuthProviderEnum?> authProvider = default, Option<long?> chainId = default)
        {
            EntityId = entityId;
            AuthProviderOption = authProvider;
            ChainIdOption = chainId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Auth Provider for the user to use. If it&#39;s Any, user will be able to choose his preferred login method. Useful when you want to present social login choice in your UI.
        /// </summary>
        /// <value>Auth Provider for the user to use. If it&#39;s Any, user will be able to choose his preferred login method. Useful when you want to present social login choice in your UI.</value>
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
        public static string AuthProviderEnumToJsonValue(AuthProviderEnum? value)
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
        /// Used to track the state of AuthProvider
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<AuthProviderEnum?> AuthProviderOption { get; private set; }

        /// <summary>
        /// Auth Provider for the user to use. If it&#39;s Any, user will be able to choose his preferred login method. Useful when you want to present social login choice in your UI.
        /// </summary>
        /// <value>Auth Provider for the user to use. If it&#39;s Any, user will be able to choose his preferred login method. Useful when you want to present social login choice in your UI.</value>
        [JsonPropertyName("authProvider")]
        public AuthProviderEnum? AuthProvider { get { return this.AuthProviderOption; } set { this.AuthProviderOption = new(value); } }

        /// <summary>
        /// Gets or Sets EntityId
        /// </summary>
        [JsonPropertyName("entityId")]
        public string EntityId { get; set; }

        /// <summary>
        /// Used to track the state of ChainId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> ChainIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [JsonPropertyName("chainId")]
        public long? ChainId { get { return this.ChainIdOption; } set { this.ChainIdOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerCreateConnectionRequestInput {\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  AuthProvider: ").Append(AuthProvider).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
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
            // EntityId (string) maxLength
            if (this.EntityId != null && this.EntityId.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EntityId, length must be less than 250.", new [] { "EntityId" });
            }

            // EntityId (string) minLength
            if (this.EntityId != null && this.EntityId.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EntityId, length must be greater than 3.", new [] { "EntityId" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="PlayerCreateConnectionRequestInput" />
    /// </summary>
    public class PlayerCreateConnectionRequestInputJsonConverter : JsonConverter<PlayerCreateConnectionRequestInput>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerCreateConnectionRequestInput" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerCreateConnectionRequestInput Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> entityId = default;
            Option<PlayerCreateConnectionRequestInput.AuthProviderEnum?> authProvider = default;
            Option<long?> chainId = default;

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
                        case "entityId":
                            entityId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "authProvider":
                            string authProviderRawValue = utf8JsonReader.GetString();
                            if (authProviderRawValue != null)
                                authProvider = new Option<PlayerCreateConnectionRequestInput.AuthProviderEnum?>(PlayerCreateConnectionRequestInput.AuthProviderEnumFromStringOrDefault(authProviderRawValue));
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!entityId.IsSet)
                throw new ArgumentException("Property is required for class PlayerCreateConnectionRequestInput.", nameof(entityId));

            if (entityId.IsSet && entityId.Value == null)
                throw new ArgumentNullException(nameof(entityId), "Property is not nullable for class PlayerCreateConnectionRequestInput.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class PlayerCreateConnectionRequestInput.");

            return new PlayerCreateConnectionRequestInput(entityId.Value, authProvider, chainId);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerCreateConnectionRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerCreateConnectionRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerCreateConnectionRequestInput playerCreateConnectionRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playerCreateConnectionRequestInput, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerCreateConnectionRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerCreateConnectionRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayerCreateConnectionRequestInput playerCreateConnectionRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerCreateConnectionRequestInput.EntityId == null)
                throw new ArgumentNullException(nameof(playerCreateConnectionRequestInput.EntityId), "Property is required for class PlayerCreateConnectionRequestInput.");

            writer.WriteString("entityId", playerCreateConnectionRequestInput.EntityId);

            var authProviderRawValue = PlayerCreateConnectionRequestInput.AuthProviderEnumToJsonValue(playerCreateConnectionRequestInput.AuthProviderOption.Value.Value);
            if (authProviderRawValue != null)
                writer.WriteString("authProvider", authProviderRawValue);
            else
                writer.WriteNull("authProvider");

            if (playerCreateConnectionRequestInput.ChainIdOption.IsSet)
            {
                writer.WriteNumber("chainId", playerCreateConnectionRequestInput.ChainIdOption.Value.Value);
            }
        }
    }
}