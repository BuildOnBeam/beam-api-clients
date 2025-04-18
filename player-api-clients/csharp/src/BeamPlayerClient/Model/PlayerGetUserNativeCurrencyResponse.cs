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
    /// PlayerGetUserNativeCurrencyResponse
    /// </summary>
    public partial class PlayerGetUserNativeCurrencyResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerGetUserNativeCurrencyResponse" /> class.
        /// </summary>
        /// <param name="nativeTokenBalance">nativeTokenBalance</param>
        [JsonConstructor]
        public PlayerGetUserNativeCurrencyResponse(PlayerGetUserNativeCurrencyResponseNativeTokenBalance nativeTokenBalance)
        {
            NativeTokenBalance = nativeTokenBalance;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets NativeTokenBalance
        /// </summary>
        [JsonPropertyName("nativeTokenBalance")]
        public PlayerGetUserNativeCurrencyResponseNativeTokenBalance NativeTokenBalance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerGetUserNativeCurrencyResponse {\n");
            sb.Append("  NativeTokenBalance: ").Append(NativeTokenBalance).Append("\n");
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
    /// A Json converter for type <see cref="PlayerGetUserNativeCurrencyResponse" />
    /// </summary>
    public class PlayerGetUserNativeCurrencyResponseJsonConverter : JsonConverter<PlayerGetUserNativeCurrencyResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerGetUserNativeCurrencyResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerGetUserNativeCurrencyResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<PlayerGetUserNativeCurrencyResponseNativeTokenBalance> nativeTokenBalance = default;

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
                        case "nativeTokenBalance":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                nativeTokenBalance = new Option<PlayerGetUserNativeCurrencyResponseNativeTokenBalance>(JsonSerializer.Deserialize<PlayerGetUserNativeCurrencyResponseNativeTokenBalance>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!nativeTokenBalance.IsSet)
                throw new ArgumentException("Property is required for class PlayerGetUserNativeCurrencyResponse.", nameof(nativeTokenBalance));

            if (nativeTokenBalance.IsSet && nativeTokenBalance.Value == null)
                throw new ArgumentNullException(nameof(nativeTokenBalance), "Property is not nullable for class PlayerGetUserNativeCurrencyResponse.");

            return new PlayerGetUserNativeCurrencyResponse(nativeTokenBalance.Value);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerGetUserNativeCurrencyResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetUserNativeCurrencyResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerGetUserNativeCurrencyResponse playerGetUserNativeCurrencyResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playerGetUserNativeCurrencyResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerGetUserNativeCurrencyResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerGetUserNativeCurrencyResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayerGetUserNativeCurrencyResponse playerGetUserNativeCurrencyResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerGetUserNativeCurrencyResponse.NativeTokenBalance == null)
                throw new ArgumentNullException(nameof(playerGetUserNativeCurrencyResponse.NativeTokenBalance), "Property is required for class PlayerGetUserNativeCurrencyResponse.");

            writer.WritePropertyName("nativeTokenBalance");
            JsonSerializer.Serialize(writer, playerGetUserNativeCurrencyResponse.NativeTokenBalance, jsonSerializerOptions);
        }
    }
}