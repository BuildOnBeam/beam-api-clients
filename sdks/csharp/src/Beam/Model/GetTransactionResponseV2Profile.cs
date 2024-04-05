// <auto-generated>
/*
 * Beam game development API
 *
 * The Beam game development API is a service to integrate your game with Beam
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
using Beam.Client;

namespace Beam.Model
{
    /// <summary>
    /// Profile and wallet information related to the transaction
    /// </summary>
    public partial class GetTransactionResponseV2Profile : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionResponseV2Profile" /> class.
        /// </summary>
        /// <param name="wallet">wallet</param>
        /// <param name="id">id</param>
        [JsonConstructor]
        public GetTransactionResponseV2Profile(GetTransactionResponseV2ProfileWallet wallet, Option<string> id = default)
        {
            Wallet = wallet;
            IdOption = id;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Wallet
        /// </summary>
        [JsonPropertyName("wallet")]
        public GetTransactionResponseV2ProfileWallet Wallet { get; set; }

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> IdOption { get; private set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get { return this. IdOption; } set { this.IdOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTransactionResponseV2Profile {\n");
            sb.Append("  Wallet: ").Append(Wallet).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
    /// A Json converter for type <see cref="GetTransactionResponseV2Profile" />
    /// </summary>
    public class GetTransactionResponseV2ProfileJsonConverter : JsonConverter<GetTransactionResponseV2Profile>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetTransactionResponseV2Profile" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetTransactionResponseV2Profile Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<GetTransactionResponseV2ProfileWallet> wallet = default;
            Option<string> id = default;

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
                        case "wallet":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                wallet = new Option<GetTransactionResponseV2ProfileWallet>(JsonSerializer.Deserialize<GetTransactionResponseV2ProfileWallet>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "id":
                            id = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!wallet.IsSet)
                throw new ArgumentException("Property is required for class GetTransactionResponseV2Profile.", nameof(wallet));

            if (wallet.IsSet && wallet.Value == null)
                throw new ArgumentNullException(nameof(wallet), "Property is not nullable for class GetTransactionResponseV2Profile.");

            return new GetTransactionResponseV2Profile(wallet.Value, id);
        }

        /// <summary>
        /// Serializes a <see cref="GetTransactionResponseV2Profile" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getTransactionResponseV2Profile"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetTransactionResponseV2Profile getTransactionResponseV2Profile, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getTransactionResponseV2Profile, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetTransactionResponseV2Profile" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getTransactionResponseV2Profile"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetTransactionResponseV2Profile getTransactionResponseV2Profile, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getTransactionResponseV2Profile.Wallet == null)
                throw new ArgumentNullException(nameof(getTransactionResponseV2Profile.Wallet), "Property is required for class GetTransactionResponseV2Profile.");

            writer.WritePropertyName("wallet");
            JsonSerializer.Serialize(writer, getTransactionResponseV2Profile.Wallet, jsonSerializerOptions);
            if (getTransactionResponseV2Profile.IdOption.IsSet)
                if (getTransactionResponseV2Profile.IdOption.Value != null)
                    writer.WriteString("id", getTransactionResponseV2Profile.Id);
                else
                    writer.WriteNull("id");
        }
    }
}
