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
    /// PlayerGetAssetsForUserResponseDataInnerAttributesInner
    /// </summary>
    public partial class PlayerGetAssetsForUserResponseDataInnerAttributesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerGetAssetsForUserResponseDataInnerAttributesInner" /> class.
        /// </summary>
        /// <param name="displayType">displayType</param>
        /// <param name="maxValue">maxValue</param>
        /// <param name="rarity">rarity</param>
        /// <param name="type">type</param>
        /// <param name="value">value</param>
        [JsonConstructor]
        public PlayerGetAssetsForUserResponseDataInnerAttributesInner(Option<string> displayType = default, Option<decimal?> maxValue = default, Option<decimal?> rarity = default, Option<string> type = default, Option<string> value = default)
        {
            DisplayTypeOption = displayType;
            MaxValueOption = maxValue;
            RarityOption = rarity;
            TypeOption = type;
            ValueOption = value;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of DisplayType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> DisplayTypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets DisplayType
        /// </summary>
        [JsonPropertyName("displayType")]
        public string DisplayType { get { return this.DisplayTypeOption; } set { this.DisplayTypeOption = new(value); } }

        /// <summary>
        /// Used to track the state of MaxValue
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> MaxValueOption { get; private set; }

        /// <summary>
        /// Gets or Sets MaxValue
        /// </summary>
        [JsonPropertyName("maxValue")]
        public decimal? MaxValue { get { return this.MaxValueOption; } set { this.MaxValueOption = new(value); } }

        /// <summary>
        /// Used to track the state of Rarity
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> RarityOption { get; private set; }

        /// <summary>
        /// Gets or Sets Rarity
        /// </summary>
        [JsonPropertyName("rarity")]
        public decimal? Rarity { get { return this.RarityOption; } set { this.RarityOption = new(value); } }

        /// <summary>
        /// Used to track the state of Type
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> TypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get { return this.TypeOption; } set { this.TypeOption = new(value); } }

        /// <summary>
        /// Used to track the state of Value
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ValueOption { get; private set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get { return this.ValueOption; } set { this.ValueOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerGetAssetsForUserResponseDataInnerAttributesInner {\n");
            sb.Append("  DisplayType: ").Append(DisplayType).Append("\n");
            sb.Append("  MaxValue: ").Append(MaxValue).Append("\n");
            sb.Append("  Rarity: ").Append(Rarity).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
    /// A Json converter for type <see cref="PlayerGetAssetsForUserResponseDataInnerAttributesInner" />
    /// </summary>
    public class PlayerGetAssetsForUserResponseDataInnerAttributesInnerJsonConverter : JsonConverter<PlayerGetAssetsForUserResponseDataInnerAttributesInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerGetAssetsForUserResponseDataInnerAttributesInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerGetAssetsForUserResponseDataInnerAttributesInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> displayType = default;
            Option<decimal?> maxValue = default;
            Option<decimal?> rarity = default;
            Option<string> type = default;
            Option<string> value = default;

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
                        case "displayType":
                            displayType = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "maxValue":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                maxValue = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "rarity":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                rarity = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "type":
                            type = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "value":
                            value = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            return new PlayerGetAssetsForUserResponseDataInnerAttributesInner(displayType, maxValue, rarity, type, value);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerGetAssetsForUserResponseDataInnerAttributesInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetAssetsForUserResponseDataInnerAttributesInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerGetAssetsForUserResponseDataInnerAttributesInner playerGetAssetsForUserResponseDataInnerAttributesInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playerGetAssetsForUserResponseDataInnerAttributesInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerGetAssetsForUserResponseDataInnerAttributesInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetAssetsForUserResponseDataInnerAttributesInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayerGetAssetsForUserResponseDataInnerAttributesInner playerGetAssetsForUserResponseDataInnerAttributesInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerGetAssetsForUserResponseDataInnerAttributesInner.DisplayTypeOption.IsSet)
            {
                if (playerGetAssetsForUserResponseDataInnerAttributesInner.DisplayTypeOption.Value != null)
                {
                    writer.WriteString("displayType", playerGetAssetsForUserResponseDataInnerAttributesInner.DisplayType);
                }
                else
                {
                    writer.WriteNull("displayType");
                }

            }

            if (playerGetAssetsForUserResponseDataInnerAttributesInner.MaxValueOption.IsSet)
            {
                if (playerGetAssetsForUserResponseDataInnerAttributesInner.MaxValueOption.Value != null)
                {
                    writer.WriteNumber("maxValue", playerGetAssetsForUserResponseDataInnerAttributesInner.MaxValueOption.Value.Value);
                }
                else
                {
                    writer.WriteNull("maxValue");
                }

            }

            if (playerGetAssetsForUserResponseDataInnerAttributesInner.RarityOption.IsSet)
            {
                if (playerGetAssetsForUserResponseDataInnerAttributesInner.RarityOption.Value != null)
                {
                    writer.WriteNumber("rarity", playerGetAssetsForUserResponseDataInnerAttributesInner.RarityOption.Value.Value);
                }
                else
                {
                    writer.WriteNull("rarity");
                }

            }

            if (playerGetAssetsForUserResponseDataInnerAttributesInner.TypeOption.IsSet)
            {
                if (playerGetAssetsForUserResponseDataInnerAttributesInner.TypeOption.Value != null)
                {
                    writer.WriteString("type", playerGetAssetsForUserResponseDataInnerAttributesInner.Type);
                }
                else
                {
                    writer.WriteNull("type");
                }

            }

            if (playerGetAssetsForUserResponseDataInnerAttributesInner.ValueOption.IsSet)
            {
                if (playerGetAssetsForUserResponseDataInnerAttributesInner.ValueOption.Value != null)
                {
                    writer.WriteString("value", playerGetAssetsForUserResponseDataInnerAttributesInner.Value);
                }
                else
                {
                    writer.WriteNull("value");
                }

            }
        }
    }
}