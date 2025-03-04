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
    /// PlayerGetAssetResponseOwnersInner
    /// </summary>
    public partial class PlayerGetAssetResponseOwnersInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerGetAssetResponseOwnersInner" /> class.
        /// </summary>
        /// <param name="address">address</param>
        /// <param name="quantity">quantity</param>
        /// <param name="entityId">entityId</param>
        [JsonConstructor]
        public PlayerGetAssetResponseOwnersInner(string address, decimal quantity, Option<string> entityId = default)
        {
            Address = address;
            Quantity = quantity;
            EntityIdOption = entityId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [JsonPropertyName("quantity")]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Used to track the state of EntityId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> EntityIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets EntityId
        /// </summary>
        [JsonPropertyName("entityId")]
        public string EntityId { get { return this.EntityIdOption; } set { this.EntityIdOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerGetAssetResponseOwnersInner {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
    /// A Json converter for type <see cref="PlayerGetAssetResponseOwnersInner" />
    /// </summary>
    public class PlayerGetAssetResponseOwnersInnerJsonConverter : JsonConverter<PlayerGetAssetResponseOwnersInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerGetAssetResponseOwnersInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerGetAssetResponseOwnersInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> address = default;
            Option<decimal?> quantity = default;
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
                        case "address":
                            address = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "quantity":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                quantity = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "entityId":
                            entityId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!address.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetAssetResponseOwnersInner.", nameof(address));

            if (!quantity.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetAssetResponseOwnersInner.", nameof(quantity));

            if (address.IsSet && address.Value == null)
                throw new ArgumentNullException(nameof(address), "Property is not nullable for class PlayerGetAssetResponseOwnersInner.");

            if (quantity.IsSet && quantity.Value == null)
                throw new ArgumentNullException(nameof(quantity), "Property is not nullable for class PlayerGetAssetResponseOwnersInner.");

            if (entityId.IsSet && entityId.Value == null)
                throw new ArgumentNullException(nameof(entityId), "Property is not nullable for class PlayerGetAssetResponseOwnersInner.");

            return new PlayerGetAssetResponseOwnersInner(address.Value, quantity.Value.Value, entityId);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerGetAssetResponseOwnersInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetAssetResponseOwnersInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerGetAssetResponseOwnersInner playerGetAssetResponseOwnersInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playerGetAssetResponseOwnersInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerGetAssetResponseOwnersInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetAssetResponseOwnersInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayerGetAssetResponseOwnersInner playerGetAssetResponseOwnersInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerGetAssetResponseOwnersInner.Address == null)
                throw new ArgumentNullException(nameof(playerGetAssetResponseOwnersInner.Address), "Property is required for class PlayerGetAssetResponseOwnersInner.");

            if (playerGetAssetResponseOwnersInner.EntityIdOption.IsSet && playerGetAssetResponseOwnersInner.EntityId == null)
                throw new ArgumentNullException(nameof(playerGetAssetResponseOwnersInner.EntityId), "Property is required for class PlayerGetAssetResponseOwnersInner.");

            writer.WriteString("address", playerGetAssetResponseOwnersInner.Address);

            writer.WriteNumber("quantity", playerGetAssetResponseOwnersInner.Quantity);

            if (playerGetAssetResponseOwnersInner.EntityIdOption.IsSet)
            {
                writer.WriteString("entityId", playerGetAssetResponseOwnersInner.EntityId);
            }
        }
    }
}