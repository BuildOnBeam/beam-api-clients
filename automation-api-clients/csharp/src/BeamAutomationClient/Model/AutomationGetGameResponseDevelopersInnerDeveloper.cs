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
    /// AutomationGetGameResponseDevelopersInnerDeveloper
    /// </summary>
    public partial class AutomationGetGameResponseDevelopersInnerDeveloper : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationGetGameResponseDevelopersInnerDeveloper" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="email">email</param>
        /// <param name="createdAt">createdAt</param>
        /// <param name="name">name</param>
        /// <param name="lastSeenAt">lastSeenAt</param>
        /// <param name="supabaseId">supabaseId</param>
        [JsonConstructor]
        public AutomationGetGameResponseDevelopersInnerDeveloper(string id, string email, DateTime createdAt, string name = default, DateTime? lastSeenAt = default, string supabaseId = default)
        {
            Id = id;
            Email = email;
            CreatedAt = createdAt;
            Name = name;
            LastSeenAt = lastSeenAt;
            SupabaseId = supabaseId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets LastSeenAt
        /// </summary>
        [JsonPropertyName("lastSeenAt")]
        public DateTime? LastSeenAt { get; set; }

        /// <summary>
        /// Gets or Sets SupabaseId
        /// </summary>
        [JsonPropertyName("supabaseId")]
        public string SupabaseId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutomationGetGameResponseDevelopersInnerDeveloper {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LastSeenAt: ").Append(LastSeenAt).Append("\n");
            sb.Append("  SupabaseId: ").Append(SupabaseId).Append("\n");
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
    /// A Json converter for type <see cref="AutomationGetGameResponseDevelopersInnerDeveloper" />
    /// </summary>
    public class AutomationGetGameResponseDevelopersInnerDeveloperJsonConverter : JsonConverter<AutomationGetGameResponseDevelopersInnerDeveloper>
    {
        /// <summary>
        /// The format to use to serialize CreatedAt
        /// </summary>
        public static string CreatedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize LastSeenAt
        /// </summary>
        public static string LastSeenAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="AutomationGetGameResponseDevelopersInnerDeveloper" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AutomationGetGameResponseDevelopersInnerDeveloper Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> id = default;
            Option<string> email = default;
            Option<DateTime?> createdAt = default;
            Option<string> name = default;
            Option<DateTime?> lastSeenAt = default;
            Option<string> supabaseId = default;

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
                        case "email":
                            email = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "createdAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "name":
                            name = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "lastSeenAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lastSeenAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "supabaseId":
                            supabaseId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetGameResponseDevelopersInnerDeveloper.", nameof(id));

            if (!email.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetGameResponseDevelopersInnerDeveloper.", nameof(email));

            if (!createdAt.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetGameResponseDevelopersInnerDeveloper.", nameof(createdAt));

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetGameResponseDevelopersInnerDeveloper.", nameof(name));

            if (!lastSeenAt.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetGameResponseDevelopersInnerDeveloper.", nameof(lastSeenAt));

            if (!supabaseId.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetGameResponseDevelopersInnerDeveloper.", nameof(supabaseId));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class AutomationGetGameResponseDevelopersInnerDeveloper.");

            if (email.IsSet && email.Value == null)
                throw new ArgumentNullException(nameof(email), "Property is not nullable for class AutomationGetGameResponseDevelopersInnerDeveloper.");

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class AutomationGetGameResponseDevelopersInnerDeveloper.");

            return new AutomationGetGameResponseDevelopersInnerDeveloper(id.Value, email.Value, createdAt.Value.Value, name.Value, lastSeenAt.Value, supabaseId.Value);
        }

        /// <summary>
        /// Serializes a <see cref="AutomationGetGameResponseDevelopersInnerDeveloper" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationGetGameResponseDevelopersInnerDeveloper"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AutomationGetGameResponseDevelopersInnerDeveloper automationGetGameResponseDevelopersInnerDeveloper, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, automationGetGameResponseDevelopersInnerDeveloper, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AutomationGetGameResponseDevelopersInnerDeveloper" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationGetGameResponseDevelopersInnerDeveloper"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AutomationGetGameResponseDevelopersInnerDeveloper automationGetGameResponseDevelopersInnerDeveloper, JsonSerializerOptions jsonSerializerOptions)
        {
            if (automationGetGameResponseDevelopersInnerDeveloper.Id == null)
                throw new ArgumentNullException(nameof(automationGetGameResponseDevelopersInnerDeveloper.Id), "Property is required for class AutomationGetGameResponseDevelopersInnerDeveloper.");

            if (automationGetGameResponseDevelopersInnerDeveloper.Email == null)
                throw new ArgumentNullException(nameof(automationGetGameResponseDevelopersInnerDeveloper.Email), "Property is required for class AutomationGetGameResponseDevelopersInnerDeveloper.");

            writer.WriteString("id", automationGetGameResponseDevelopersInnerDeveloper.Id);

            writer.WriteString("email", automationGetGameResponseDevelopersInnerDeveloper.Email);

            writer.WriteString("createdAt", automationGetGameResponseDevelopersInnerDeveloper.CreatedAt.ToString(CreatedAtFormat));

            if (automationGetGameResponseDevelopersInnerDeveloper.Name != null)
            {
                writer.WriteString("name", automationGetGameResponseDevelopersInnerDeveloper.Name);
            }
            else
            {
                writer.WriteNull("name");
            }

            if (automationGetGameResponseDevelopersInnerDeveloper.LastSeenAt != null)
            {
                writer.WriteString("lastSeenAt", automationGetGameResponseDevelopersInnerDeveloper.LastSeenAt.Value.ToString(LastSeenAtFormat));
            }
            else
            {
                writer.WriteNull("lastSeenAt");
            }

            if (automationGetGameResponseDevelopersInnerDeveloper.SupabaseId != null)
            {
                writer.WriteString("supabaseId", automationGetGameResponseDevelopersInnerDeveloper.SupabaseId);
            }
            else
            {
                writer.WriteNull("supabaseId");
            }
        }
    }
}