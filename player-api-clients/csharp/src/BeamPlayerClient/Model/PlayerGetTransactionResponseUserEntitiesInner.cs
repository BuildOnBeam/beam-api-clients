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
    /// PlayerGetTransactionResponseUserEntitiesInner
    /// </summary>
    public partial class PlayerGetTransactionResponseUserEntitiesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerGetTransactionResponseUserEntitiesInner" /> class.
        /// </summary>
        /// <param name="entityId">entityId</param>
        [JsonConstructor]
        public PlayerGetTransactionResponseUserEntitiesInner(string entityId)
        {
            EntityId = entityId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets EntityId
        /// </summary>
        [JsonPropertyName("entityId")]
        public string EntityId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerGetTransactionResponseUserEntitiesInner {\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
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
    /// A Json converter for type <see cref="PlayerGetTransactionResponseUserEntitiesInner" />
    /// </summary>
    public class PlayerGetTransactionResponseUserEntitiesInnerJsonConverter : JsonConverter<PlayerGetTransactionResponseUserEntitiesInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerGetTransactionResponseUserEntitiesInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerGetTransactionResponseUserEntitiesInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> entityId = default;

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
                        default:
                            break;
                    }
                }
            }

            if (!entityId.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetTransactionResponseUserEntitiesInner.", nameof(entityId));

            if (entityId.IsSet && entityId.Value == null)
                throw new ArgumentNullException(nameof(entityId), "Property is not nullable for class PlayerGetTransactionResponseUserEntitiesInner.");

            return new PlayerGetTransactionResponseUserEntitiesInner(entityId.Value);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerGetTransactionResponseUserEntitiesInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetTransactionResponseUserEntitiesInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerGetTransactionResponseUserEntitiesInner playerGetTransactionResponseUserEntitiesInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playerGetTransactionResponseUserEntitiesInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerGetTransactionResponseUserEntitiesInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetTransactionResponseUserEntitiesInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayerGetTransactionResponseUserEntitiesInner playerGetTransactionResponseUserEntitiesInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerGetTransactionResponseUserEntitiesInner.EntityId == null)
                throw new ArgumentNullException(nameof(playerGetTransactionResponseUserEntitiesInner.EntityId), "Property is required for class PlayerGetTransactionResponseUserEntitiesInner.");

            writer.WriteString("entityId", playerGetTransactionResponseUserEntitiesInner.EntityId);
        }
    }
}