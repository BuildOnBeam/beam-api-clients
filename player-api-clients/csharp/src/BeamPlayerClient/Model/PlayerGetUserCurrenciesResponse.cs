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
    /// PlayerGetUserCurrenciesResponse
    /// </summary>
    public partial class PlayerGetUserCurrenciesResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerGetUserCurrenciesResponse" /> class.
        /// </summary>
        /// <param name="data">data</param>
        [JsonConstructor]
        public PlayerGetUserCurrenciesResponse(List<PlayerGetUserCurrenciesResponseDataInner> data)
        {
            Data = data;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [JsonPropertyName("data")]
        public List<PlayerGetUserCurrenciesResponseDataInner> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerGetUserCurrenciesResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
    /// A Json converter for type <see cref="PlayerGetUserCurrenciesResponse" />
    /// </summary>
    public class PlayerGetUserCurrenciesResponseJsonConverter : JsonConverter<PlayerGetUserCurrenciesResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerGetUserCurrenciesResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerGetUserCurrenciesResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<PlayerGetUserCurrenciesResponseDataInner>> data = default;

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
                        case "data":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                data = new Option<List<PlayerGetUserCurrenciesResponseDataInner>>(JsonSerializer.Deserialize<List<PlayerGetUserCurrenciesResponseDataInner>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!data.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetUserCurrenciesResponse.", nameof(data));

            if (data.IsSet && data.Value == null)
                throw new ArgumentNullException(nameof(data), "Property is not nullable for class PlayerGetUserCurrenciesResponse.");

            return new PlayerGetUserCurrenciesResponse(data.Value);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerGetUserCurrenciesResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetUserCurrenciesResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerGetUserCurrenciesResponse playerGetUserCurrenciesResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playerGetUserCurrenciesResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerGetUserCurrenciesResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetUserCurrenciesResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayerGetUserCurrenciesResponse playerGetUserCurrenciesResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerGetUserCurrenciesResponse.Data == null)
                throw new ArgumentNullException(nameof(playerGetUserCurrenciesResponse.Data), "Property is required for class PlayerGetUserCurrenciesResponse.");

            writer.WritePropertyName("data");
            JsonSerializer.Serialize(writer, playerGetUserCurrenciesResponse.Data, jsonSerializerOptions);
        }
    }
}