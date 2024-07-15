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
    /// GetAttributesResponseDataInner
    /// </summary>
    public partial class GetAttributesResponseDataInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAttributesResponseDataInner" /> class.
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="kind">kind</param>
        /// <param name="values">values</param>
        [JsonConstructor]
        public GetAttributesResponseDataInner(string key, KindEnum kind, Option<List<GetAttributesResponseDataInnerValuesInner>?> values = default)
        {
            Key = key;
            Kind = kind;
            ValuesOption = values;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines Kind
        /// </summary>
        public enum KindEnum
        {
            /// <summary>
            /// Enum String for value: string
            /// </summary>
            String = 1,

            /// <summary>
            /// Enum Number for value: number
            /// </summary>
            Number = 2,

            /// <summary>
            /// Enum Date for value: date
            /// </summary>
            Date = 3,

            /// <summary>
            /// Enum Range for value: range
            /// </summary>
            Range = 4
        }

        /// <summary>
        /// Returns a <see cref="KindEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static KindEnum KindEnumFromString(string value)
        {
            if (value.Equals("string"))
                return KindEnum.String;

            if (value.Equals("number"))
                return KindEnum.Number;

            if (value.Equals("date"))
                return KindEnum.Date;

            if (value.Equals("range"))
                return KindEnum.Range;

            throw new NotImplementedException($"Could not convert value to type KindEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="KindEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static KindEnum? KindEnumFromStringOrDefault(string value)
        {
            if (value.Equals("string"))
                return KindEnum.String;

            if (value.Equals("number"))
                return KindEnum.Number;

            if (value.Equals("date"))
                return KindEnum.Date;

            if (value.Equals("range"))
                return KindEnum.Range;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="KindEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string KindEnumToJsonValue(KindEnum value)
        {
            if (value == KindEnum.String)
                return "string";

            if (value == KindEnum.Number)
                return "number";

            if (value == KindEnum.Date)
                return "date";

            if (value == KindEnum.Range)
                return "range";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        [JsonPropertyName("kind")]
        public KindEnum Kind { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// Used to track the state of Values
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<GetAttributesResponseDataInnerValuesInner>?> ValuesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [JsonPropertyName("values")]
        public List<GetAttributesResponseDataInnerValuesInner>? Values { get { return this. ValuesOption; } set { this.ValuesOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAttributesResponseDataInner {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
    /// A Json converter for type <see cref="GetAttributesResponseDataInner" />
    /// </summary>
    public class GetAttributesResponseDataInnerJsonConverter : JsonConverter<GetAttributesResponseDataInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetAttributesResponseDataInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetAttributesResponseDataInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> key = default;
            Option<GetAttributesResponseDataInner.KindEnum?> kind = default;
            Option<List<GetAttributesResponseDataInnerValuesInner>?> values = default;

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
                        case "key":
                            key = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "kind":
                            string? kindRawValue = utf8JsonReader.GetString();
                            if (kindRawValue != null)
                                kind = new Option<GetAttributesResponseDataInner.KindEnum?>(GetAttributesResponseDataInner.KindEnumFromStringOrDefault(kindRawValue));
                            break;
                        case "values":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                values = new Option<List<GetAttributesResponseDataInnerValuesInner>?>(JsonSerializer.Deserialize<List<GetAttributesResponseDataInnerValuesInner>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!key.IsSet)
                throw new ArgumentException("Property is required for class GetAttributesResponseDataInner.", nameof(key));

            if (!kind.IsSet)
                throw new ArgumentException("Property is required for class GetAttributesResponseDataInner.", nameof(kind));

            if (key.IsSet && key.Value == null)
                throw new ArgumentNullException(nameof(key), "Property is not nullable for class GetAttributesResponseDataInner.");

            if (kind.IsSet && kind.Value == null)
                throw new ArgumentNullException(nameof(kind), "Property is not nullable for class GetAttributesResponseDataInner.");

            return new GetAttributesResponseDataInner(key.Value!, kind.Value!.Value!, values);
        }

        /// <summary>
        /// Serializes a <see cref="GetAttributesResponseDataInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAttributesResponseDataInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetAttributesResponseDataInner getAttributesResponseDataInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getAttributesResponseDataInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetAttributesResponseDataInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAttributesResponseDataInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetAttributesResponseDataInner getAttributesResponseDataInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getAttributesResponseDataInner.Key == null)
                throw new ArgumentNullException(nameof(getAttributesResponseDataInner.Key), "Property is required for class GetAttributesResponseDataInner.");

            writer.WriteString("key", getAttributesResponseDataInner.Key);

            var kindRawValue = GetAttributesResponseDataInner.KindEnumToJsonValue(getAttributesResponseDataInner.Kind);
            writer.WriteString("kind", kindRawValue);
            if (getAttributesResponseDataInner.ValuesOption.IsSet)
                if (getAttributesResponseDataInner.ValuesOption.Value != null)
                {
                    writer.WritePropertyName("values");
                    JsonSerializer.Serialize(writer, getAttributesResponseDataInner.Values, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("values");
        }
    }
}