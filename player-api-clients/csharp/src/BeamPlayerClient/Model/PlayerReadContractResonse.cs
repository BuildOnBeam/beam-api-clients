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
    /// PlayerReadContractResonse
    /// </summary>
    public partial class PlayerReadContractResonse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerReadContractResonse" /> class.
        /// </summary>
        /// <param name="result">result</param>
        [JsonConstructor]
        public PlayerReadContractResonse(Option<Object> result = default)
        {
            ResultOption = result;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Result
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object> ResultOption { get; private set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [JsonPropertyName("result")]
        public Object Result { get { return this.ResultOption; } set { this.ResultOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerReadContractResonse {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
    /// A Json converter for type <see cref="PlayerReadContractResonse" />
    /// </summary>
    public class PlayerReadContractResonseJsonConverter : JsonConverter<PlayerReadContractResonse>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerReadContractResonse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerReadContractResonse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<Object> result = default;

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
                        case "result":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                result = new Option<Object>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            return new PlayerReadContractResonse(result);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerReadContractResonse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerReadContractResonse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerReadContractResonse playerReadContractResonse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playerReadContractResonse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerReadContractResonse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerReadContractResonse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayerReadContractResonse playerReadContractResonse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerReadContractResonse.ResultOption.IsSet)
                if (playerReadContractResonse.ResultOption.Value != null)
                {
                    writer.WritePropertyName("result");
                    JsonSerializer.Serialize(writer, playerReadContractResonse.Result, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("result");
        }
    }
}