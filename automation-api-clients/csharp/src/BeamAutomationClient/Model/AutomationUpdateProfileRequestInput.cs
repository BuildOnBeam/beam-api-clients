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
    /// AutomationUpdateProfileRequestInput
    /// </summary>
    public partial class AutomationUpdateProfileRequestInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationUpdateProfileRequestInput" /> class.
        /// </summary>
        /// <param name="newEntityId">newEntityId</param>
        [JsonConstructor]
        public AutomationUpdateProfileRequestInput(string newEntityId)
        {
            NewEntityId = newEntityId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets NewEntityId
        /// </summary>
        [JsonPropertyName("newEntityId")]
        public string NewEntityId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutomationUpdateProfileRequestInput {\n");
            sb.Append("  NewEntityId: ").Append(NewEntityId).Append("\n");
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
            // NewEntityId (string) maxLength
            if (this.NewEntityId != null && this.NewEntityId.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NewEntityId, length must be less than 250.", new [] { "NewEntityId" });
            }

            // NewEntityId (string) minLength
            if (this.NewEntityId != null && this.NewEntityId.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NewEntityId, length must be greater than 3.", new [] { "NewEntityId" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="AutomationUpdateProfileRequestInput" />
    /// </summary>
    public class AutomationUpdateProfileRequestInputJsonConverter : JsonConverter<AutomationUpdateProfileRequestInput>
    {
        /// <summary>
        /// Deserializes json to <see cref="AutomationUpdateProfileRequestInput" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AutomationUpdateProfileRequestInput Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> newEntityId = default;

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
                        case "newEntityId":
                            newEntityId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!newEntityId.IsSet)
                throw new ArgumentException("Property is required for class AutomationUpdateProfileRequestInput.", nameof(newEntityId));

            if (newEntityId.IsSet && newEntityId.Value == null)
                throw new ArgumentNullException(nameof(newEntityId), "Property is not nullable for class AutomationUpdateProfileRequestInput.");

            return new AutomationUpdateProfileRequestInput(newEntityId.Value);
        }

        /// <summary>
        /// Serializes a <see cref="AutomationUpdateProfileRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationUpdateProfileRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AutomationUpdateProfileRequestInput automationUpdateProfileRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, automationUpdateProfileRequestInput, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AutomationUpdateProfileRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationUpdateProfileRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AutomationUpdateProfileRequestInput automationUpdateProfileRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            if (automationUpdateProfileRequestInput.NewEntityId == null)
                throw new ArgumentNullException(nameof(automationUpdateProfileRequestInput.NewEntityId), "Property is required for class AutomationUpdateProfileRequestInput.");

            writer.WriteString("newEntityId", automationUpdateProfileRequestInput.NewEntityId);
        }
    }
}