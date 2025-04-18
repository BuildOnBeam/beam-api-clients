// <auto-generated>
/*
 * Automation API
 *
 * The Automation API is a service to integrate your game with Beam
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
using BeamAutomationClient.Client;

namespace BeamAutomationClient.Model
{
    /// <summary>
    /// AutomationCreateProfileResponseWalletsInner
    /// </summary>
    public partial class AutomationCreateProfileResponseWalletsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationCreateProfileResponseWalletsInner" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="createdAt">createdAt</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="externalId">externalId</param>
        /// <param name="address">address</param>
        /// <param name="chainId">chainId</param>
        /// <param name="profileId">profileId</param>
        /// <param name="userId">userId</param>
        [JsonConstructor]
        public AutomationCreateProfileResponseWalletsInner(string id, DateTime createdAt, DateTime updatedAt, string externalId, string address, int chainId, string profileId = default, string userId = default)
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            ExternalId = externalId;
            Address = address;
            ChainId = chainId;
            ProfileId = profileId;
            UserId = userId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [JsonPropertyName("externalId")]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [JsonPropertyName("chainId")]
        public int ChainId { get; set; }

        /// <summary>
        /// Gets or Sets ProfileId
        /// </summary>
        [JsonPropertyName("profileId")]
        public string ProfileId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutomationCreateProfileResponseWalletsInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
    /// A Json converter for type <see cref="AutomationCreateProfileResponseWalletsInner" />
    /// </summary>
    public class AutomationCreateProfileResponseWalletsInnerJsonConverter : JsonConverter<AutomationCreateProfileResponseWalletsInner>
    {
        /// <summary>
        /// The format to use to serialize CreatedAt
        /// </summary>
        public static string CreatedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize UpdatedAt
        /// </summary>
        public static string UpdatedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="AutomationCreateProfileResponseWalletsInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AutomationCreateProfileResponseWalletsInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> id = default;
            Option<DateTime?> createdAt = default;
            Option<DateTime?> updatedAt = default;
            Option<string> externalId = default;
            Option<string> address = default;
            Option<int?> chainId = default;
            Option<string> profileId = default;
            Option<string> userId = default;

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
                        case "id":
                            id = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "createdAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "updatedAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                updatedAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "externalId":
                            externalId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "address":
                            address = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "profileId":
                            profileId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "userId":
                            userId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class AutomationCreateProfileResponseWalletsInner.", nameof(id));

            if (!createdAt.IsSet)
                throw new ArgumentException("Property is required for class AutomationCreateProfileResponseWalletsInner.", nameof(createdAt));

            if (!updatedAt.IsSet)
                throw new ArgumentException("Property is required for class AutomationCreateProfileResponseWalletsInner.", nameof(updatedAt));

            if (!externalId.IsSet)
                throw new ArgumentException("Property is required for class AutomationCreateProfileResponseWalletsInner.", nameof(externalId));

            if (!address.IsSet)
                throw new ArgumentException("Property is required for class AutomationCreateProfileResponseWalletsInner.", nameof(address));

            if (!chainId.IsSet)
                throw new ArgumentException("Property is required for class AutomationCreateProfileResponseWalletsInner.", nameof(chainId));

            if (!profileId.IsSet)
                throw new ArgumentException("Property is required for class AutomationCreateProfileResponseWalletsInner.", nameof(profileId));

            if (!userId.IsSet)
                throw new ArgumentException("Property is required for class AutomationCreateProfileResponseWalletsInner.", nameof(userId));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class AutomationCreateProfileResponseWalletsInner.");

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class AutomationCreateProfileResponseWalletsInner.");

            if (updatedAt.IsSet && updatedAt.Value == null)
                throw new ArgumentNullException(nameof(updatedAt), "Property is not nullable for class AutomationCreateProfileResponseWalletsInner.");

            if (externalId.IsSet && externalId.Value == null)
                throw new ArgumentNullException(nameof(externalId), "Property is not nullable for class AutomationCreateProfileResponseWalletsInner.");

            if (address.IsSet && address.Value == null)
                throw new ArgumentNullException(nameof(address), "Property is not nullable for class AutomationCreateProfileResponseWalletsInner.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class AutomationCreateProfileResponseWalletsInner.");

            return new AutomationCreateProfileResponseWalletsInner(id.Value, createdAt.Value.Value, updatedAt.Value.Value, externalId.Value, address.Value, chainId.Value.Value, profileId.Value, userId.Value);
        }

        /// <summary>
        /// Serializes a <see cref="AutomationCreateProfileResponseWalletsInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationCreateProfileResponseWalletsInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AutomationCreateProfileResponseWalletsInner automationCreateProfileResponseWalletsInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, automationCreateProfileResponseWalletsInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AutomationCreateProfileResponseWalletsInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationCreateProfileResponseWalletsInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AutomationCreateProfileResponseWalletsInner automationCreateProfileResponseWalletsInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (automationCreateProfileResponseWalletsInner.Id == null)
                throw new ArgumentNullException(nameof(automationCreateProfileResponseWalletsInner.Id), "Property is required for class AutomationCreateProfileResponseWalletsInner.");

            if (automationCreateProfileResponseWalletsInner.ExternalId == null)
                throw new ArgumentNullException(nameof(automationCreateProfileResponseWalletsInner.ExternalId), "Property is required for class AutomationCreateProfileResponseWalletsInner.");

            if (automationCreateProfileResponseWalletsInner.Address == null)
                throw new ArgumentNullException(nameof(automationCreateProfileResponseWalletsInner.Address), "Property is required for class AutomationCreateProfileResponseWalletsInner.");

            writer.WriteString("id", automationCreateProfileResponseWalletsInner.Id);

            writer.WriteString("createdAt", automationCreateProfileResponseWalletsInner.CreatedAt.ToString(CreatedAtFormat));

            writer.WriteString("updatedAt", automationCreateProfileResponseWalletsInner.UpdatedAt.ToString(UpdatedAtFormat));

            writer.WriteString("externalId", automationCreateProfileResponseWalletsInner.ExternalId);

            writer.WriteString("address", automationCreateProfileResponseWalletsInner.Address);

            writer.WriteNumber("chainId", automationCreateProfileResponseWalletsInner.ChainId);

            if (automationCreateProfileResponseWalletsInner.ProfileId != null)
            {
                writer.WriteString("profileId", automationCreateProfileResponseWalletsInner.ProfileId);
            }
            else
            {
                writer.WriteNull("profileId");
            }

            if (automationCreateProfileResponseWalletsInner.UserId != null)
            {
                writer.WriteString("userId", automationCreateProfileResponseWalletsInner.UserId);
            }
            else
            {
                writer.WriteNull("userId");
            }
        }
    }
}