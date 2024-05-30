// <auto-generated>
/*
 * Beam game development API
 *
 * The Beam game development API is a service to integrate your game with Beam
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
using OpenAPIClientUtils = Beam.Client.ClientUtils;
using Beam.Client;

namespace Beam.Model
{
    /// <summary>
    /// AddPolicyResponse
    /// </summary>
    public partial class AddPolicyResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddPolicyResponse" /> class.
        /// </summary>
        /// <param name="chainId">chainId</param>
        /// <param name="id">id</param>
        /// <param name="amount">amount</param>
        /// <param name="depositorId">depositorId</param>
        /// <param name="rateType">rateType</param>
        /// <param name="token">token</param>
        [JsonConstructor]
        public AddPolicyResponse(int chainId, string id, string? amount = default, string? depositorId = default, RateTypeEnum? rateType = default, string? token = default)
        {
            ChainId = chainId;
            Id = id;
            Amount = amount;
            DepositorId = depositorId;
            RateType = rateType;
            Token = token;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines RateType
        /// </summary>
        public enum RateTypeEnum
        {
            /// <summary>
            /// Enum Fixed for value: Fixed
            /// </summary>
            Fixed = 1,

            /// <summary>
            /// Enum Dynamic for value: Dynamic
            /// </summary>
            Dynamic = 2
        }

        /// <summary>
        /// Returns a <see cref="RateTypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static RateTypeEnum RateTypeEnumFromString(string value)
        {
            if (value.Equals("Fixed"))
                return RateTypeEnum.Fixed;

            if (value.Equals("Dynamic"))
                return RateTypeEnum.Dynamic;

            throw new NotImplementedException($"Could not convert value to type RateTypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="RateTypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RateTypeEnum? RateTypeEnumFromStringOrDefault(string value)
        {
            if (value.Equals("Fixed"))
                return RateTypeEnum.Fixed;

            if (value.Equals("Dynamic"))
                return RateTypeEnum.Dynamic;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="RateTypeEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string? RateTypeEnumToJsonValue(RateTypeEnum? value)
        {
            if (value == null)
                return null;

            if (value == RateTypeEnum.Fixed)
                return "Fixed";

            if (value == RateTypeEnum.Dynamic)
                return "Dynamic";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets RateType
        /// </summary>
        [JsonPropertyName("rateType")]
        public RateTypeEnum? RateType { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [JsonPropertyName("chainId")]
        public int ChainId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [JsonPropertyName("amount")]
        public string? Amount { get; set; }

        /// <summary>
        /// Gets or Sets DepositorId
        /// </summary>
        [JsonPropertyName("depositorId")]
        public string? DepositorId { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddPolicyResponse {\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  DepositorId: ").Append(DepositorId).Append("\n");
            sb.Append("  RateType: ").Append(RateType).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
    /// A Json converter for type <see cref="AddPolicyResponse" />
    /// </summary>
    public class AddPolicyResponseJsonConverter : JsonConverter<AddPolicyResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="AddPolicyResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AddPolicyResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> chainId = default;
            Option<string?> id = default;
            Option<string?> amount = default;
            Option<string?> depositorId = default;
            Option<AddPolicyResponse.RateTypeEnum?> rateType = default;
            Option<string?> token = default;

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
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "amount":
                            amount = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "depositorId":
                            depositorId = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "rateType":
                            string? rateTypeRawValue = utf8JsonReader.GetString();
                            if (rateTypeRawValue != null)
                                rateType = new Option<AddPolicyResponse.RateTypeEnum?>(AddPolicyResponse.RateTypeEnumFromStringOrDefault(rateTypeRawValue));
                            break;
                        case "token":
                            token = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!chainId.IsSet)
                throw new ArgumentException("Property is required for class AddPolicyResponse.", nameof(chainId));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class AddPolicyResponse.", nameof(id));

            if (!amount.IsSet)
                throw new ArgumentException("Property is required for class AddPolicyResponse.", nameof(amount));

            if (!depositorId.IsSet)
                throw new ArgumentException("Property is required for class AddPolicyResponse.", nameof(depositorId));

            if (!rateType.IsSet)
                throw new ArgumentException("Property is required for class AddPolicyResponse.", nameof(rateType));

            if (!token.IsSet)
                throw new ArgumentException("Property is required for class AddPolicyResponse.", nameof(token));

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class AddPolicyResponse.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class AddPolicyResponse.");

            return new AddPolicyResponse(chainId.Value!.Value!, id.Value!, amount.Value!, depositorId.Value!, rateType.Value!, token.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="AddPolicyResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="addPolicyResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AddPolicyResponse addPolicyResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, addPolicyResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AddPolicyResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="addPolicyResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, AddPolicyResponse addPolicyResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (addPolicyResponse.Id == null)
                throw new ArgumentNullException(nameof(addPolicyResponse.Id), "Property is required for class AddPolicyResponse.");

            writer.WriteNumber("chainId", addPolicyResponse.ChainId);

            writer.WriteString("id", addPolicyResponse.Id);

            if (addPolicyResponse.Amount != null)
                writer.WriteString("amount", addPolicyResponse.Amount);
            else
                writer.WriteNull("amount");

            if (addPolicyResponse.DepositorId != null)
                writer.WriteString("depositorId", addPolicyResponse.DepositorId);
            else
                writer.WriteNull("depositorId");

            var rateTypeRawValue = AddPolicyResponse.RateTypeEnumToJsonValue(addPolicyResponse.RateType!.Value);
            if (rateTypeRawValue != null)
                writer.WriteString("rateType", rateTypeRawValue);
            else
                writer.WriteNull("rateType");

            if (addPolicyResponse.Token != null)
                writer.WriteString("token", addPolicyResponse.Token);
            else
                writer.WriteNull("token");
        }
    }
}