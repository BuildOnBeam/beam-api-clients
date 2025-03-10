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
    /// PlayerGetOwnersResponse
    /// </summary>
    public partial class PlayerGetOwnersResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerGetOwnersResponse" /> class.
        /// </summary>
        /// <param name="data">data</param>
        /// <param name="pagination">pagination</param>
        [JsonConstructor]
        public PlayerGetOwnersResponse(List<PlayerGetOwnersResponseDataInner> data, PlayerGetOwnersResponsePagination pagination)
        {
            Data = data;
            Pagination = pagination;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [JsonPropertyName("data")]
        public List<PlayerGetOwnersResponseDataInner> Data { get; set; }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [JsonPropertyName("pagination")]
        public PlayerGetOwnersResponsePagination Pagination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerGetOwnersResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
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
    /// A Json converter for type <see cref="PlayerGetOwnersResponse" />
    /// </summary>
    public class PlayerGetOwnersResponseJsonConverter : JsonConverter<PlayerGetOwnersResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerGetOwnersResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerGetOwnersResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<PlayerGetOwnersResponseDataInner>> data = default;
            Option<PlayerGetOwnersResponsePagination> pagination = default;

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
                                data = new Option<List<PlayerGetOwnersResponseDataInner>>(JsonSerializer.Deserialize<List<PlayerGetOwnersResponseDataInner>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "pagination":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                pagination = new Option<PlayerGetOwnersResponsePagination>(JsonSerializer.Deserialize<PlayerGetOwnersResponsePagination>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!data.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetOwnersResponse.", nameof(data));

            if (!pagination.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetOwnersResponse.", nameof(pagination));

            if (data.IsSet && data.Value == null)
                throw new ArgumentNullException(nameof(data), "Property is not nullable for class PlayerGetOwnersResponse.");

            if (pagination.IsSet && pagination.Value == null)
                throw new ArgumentNullException(nameof(pagination), "Property is not nullable for class PlayerGetOwnersResponse.");

            return new PlayerGetOwnersResponse(data.Value, pagination.Value);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerGetOwnersResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetOwnersResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerGetOwnersResponse playerGetOwnersResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playerGetOwnersResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerGetOwnersResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetOwnersResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayerGetOwnersResponse playerGetOwnersResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerGetOwnersResponse.Data == null)
                throw new ArgumentNullException(nameof(playerGetOwnersResponse.Data), "Property is required for class PlayerGetOwnersResponse.");

            if (playerGetOwnersResponse.Pagination == null)
                throw new ArgumentNullException(nameof(playerGetOwnersResponse.Pagination), "Property is required for class PlayerGetOwnersResponse.");

            writer.WritePropertyName("data");
            JsonSerializer.Serialize(writer, playerGetOwnersResponse.Data, jsonSerializerOptions);
            writer.WritePropertyName("pagination");
            JsonSerializer.Serialize(writer, playerGetOwnersResponse.Pagination, jsonSerializerOptions);
        }
    }
}