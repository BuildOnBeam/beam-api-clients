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
    /// PlayerBeamErrorResponse
    /// </summary>
    public partial class PlayerBeamErrorResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerBeamErrorResponse" /> class.
        /// </summary>
        /// <param name="path">path</param>
        /// <param name="timestamp">timestamp</param>
        /// <param name="status">status</param>
        /// <param name="error">error</param>
        /// <param name="validation">validation</param>
        /// <param name="type">type</param>
        /// <param name="message">message</param>
        /// <param name="traceId">traceId</param>
        [JsonConstructor]
        public PlayerBeamErrorResponse(string path, DateTime timestamp, int status, Option<string> error = default, Option<List<Object>> validation = default, Option<string> type = default, Option<string> message = default, Option<string> traceId = default)
        {
            Path = path;
            Timestamp = timestamp;
            Status = status;
            ErrorOption = error;
            ValidationOption = validation;
            TypeOption = type;
            MessageOption = message;
            TraceIdOption = traceId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [JsonPropertyName("path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// Used to track the state of Error
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ErrorOption { get; private set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [JsonPropertyName("error")]
        public string Error { get { return this.ErrorOption; } set { this.ErrorOption = new(value); } }

        /// <summary>
        /// Used to track the state of Validation
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<Object>> ValidationOption { get; private set; }

        /// <summary>
        /// Gets or Sets Validation
        /// </summary>
        [JsonPropertyName("validation")]
        public List<Object> Validation { get { return this.ValidationOption; } set { this.ValidationOption = new(value); } }

        /// <summary>
        /// Used to track the state of Type
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> TypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get { return this.TypeOption; } set { this.TypeOption = new(value); } }

        /// <summary>
        /// Used to track the state of Message
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> MessageOption { get; private set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get { return this.MessageOption; } set { this.MessageOption = new(value); } }

        /// <summary>
        /// Used to track the state of TraceId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> TraceIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets TraceId
        /// </summary>
        [JsonPropertyName("traceId")]
        public string TraceId { get { return this.TraceIdOption; } set { this.TraceIdOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerBeamErrorResponse {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Validation: ").Append(Validation).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  TraceId: ").Append(TraceId).Append("\n");
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
            // Status (int) maximum
            if (this.Status > (int)599)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Status, must be a value less than or equal to 599.", new [] { "Status" });
            }

            // Status (int) minimum
            if (this.Status < (int)400)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Status, must be a value greater than or equal to 400.", new [] { "Status" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="PlayerBeamErrorResponse" />
    /// </summary>
    public class PlayerBeamErrorResponseJsonConverter : JsonConverter<PlayerBeamErrorResponse>
    {
        /// <summary>
        /// The format to use to serialize Timestamp
        /// </summary>
        public static string TimestampFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="PlayerBeamErrorResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerBeamErrorResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> path = default;
            Option<DateTime?> timestamp = default;
            Option<int?> status = default;
            Option<string> error = default;
            Option<List<Object>> validation = default;
            Option<string> type = default;
            Option<string> message = default;
            Option<string> traceId = default;

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
                        case "path":
                            path = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "timestamp":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                timestamp = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "status":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                status = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "error":
                            error = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "validation":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                validation = new Option<List<Object>>(JsonSerializer.Deserialize<List<Object>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "type":
                            type = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "message":
                            message = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "traceId":
                            traceId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!path.IsSet)
                throw new ArgumentException("Property is required for class PlayerBeamErrorResponse.", nameof(path));

            if (!timestamp.IsSet)
                throw new ArgumentException("Property is required for class PlayerBeamErrorResponse.", nameof(timestamp));

            if (!status.IsSet)
                throw new ArgumentException("Property is required for class PlayerBeamErrorResponse.", nameof(status));

            if (path.IsSet && path.Value == null)
                throw new ArgumentNullException(nameof(path), "Property is not nullable for class PlayerBeamErrorResponse.");

            if (timestamp.IsSet && timestamp.Value == null)
                throw new ArgumentNullException(nameof(timestamp), "Property is not nullable for class PlayerBeamErrorResponse.");

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class PlayerBeamErrorResponse.");

            if (error.IsSet && error.Value == null)
                throw new ArgumentNullException(nameof(error), "Property is not nullable for class PlayerBeamErrorResponse.");

            if (validation.IsSet && validation.Value == null)
                throw new ArgumentNullException(nameof(validation), "Property is not nullable for class PlayerBeamErrorResponse.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class PlayerBeamErrorResponse.");

            if (message.IsSet && message.Value == null)
                throw new ArgumentNullException(nameof(message), "Property is not nullable for class PlayerBeamErrorResponse.");

            if (traceId.IsSet && traceId.Value == null)
                throw new ArgumentNullException(nameof(traceId), "Property is not nullable for class PlayerBeamErrorResponse.");

            return new PlayerBeamErrorResponse(path.Value, timestamp.Value.Value, status.Value.Value, error, validation, type, message, traceId);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerBeamErrorResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerBeamErrorResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerBeamErrorResponse playerBeamErrorResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playerBeamErrorResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerBeamErrorResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerBeamErrorResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayerBeamErrorResponse playerBeamErrorResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerBeamErrorResponse.Path == null)
                throw new ArgumentNullException(nameof(playerBeamErrorResponse.Path), "Property is required for class PlayerBeamErrorResponse.");

            if (playerBeamErrorResponse.ErrorOption.IsSet && playerBeamErrorResponse.Error == null)
                throw new ArgumentNullException(nameof(playerBeamErrorResponse.Error), "Property is required for class PlayerBeamErrorResponse.");

            if (playerBeamErrorResponse.ValidationOption.IsSet && playerBeamErrorResponse.Validation == null)
                throw new ArgumentNullException(nameof(playerBeamErrorResponse.Validation), "Property is required for class PlayerBeamErrorResponse.");

            if (playerBeamErrorResponse.TypeOption.IsSet && playerBeamErrorResponse.Type == null)
                throw new ArgumentNullException(nameof(playerBeamErrorResponse.Type), "Property is required for class PlayerBeamErrorResponse.");

            if (playerBeamErrorResponse.MessageOption.IsSet && playerBeamErrorResponse.Message == null)
                throw new ArgumentNullException(nameof(playerBeamErrorResponse.Message), "Property is required for class PlayerBeamErrorResponse.");

            if (playerBeamErrorResponse.TraceIdOption.IsSet && playerBeamErrorResponse.TraceId == null)
                throw new ArgumentNullException(nameof(playerBeamErrorResponse.TraceId), "Property is required for class PlayerBeamErrorResponse.");

            writer.WriteString("path", playerBeamErrorResponse.Path);

            writer.WriteString("timestamp", playerBeamErrorResponse.Timestamp.ToString(TimestampFormat));

            writer.WriteNumber("status", playerBeamErrorResponse.Status);

            if (playerBeamErrorResponse.ErrorOption.IsSet)
            {
                writer.WriteString("error", playerBeamErrorResponse.Error);
            }

            if (playerBeamErrorResponse.ValidationOption.IsSet)
            {
                writer.WritePropertyName("validation");
                JsonSerializer.Serialize(writer, playerBeamErrorResponse.Validation, jsonSerializerOptions);
            }
            if (playerBeamErrorResponse.TypeOption.IsSet)
            {
                writer.WriteString("type", playerBeamErrorResponse.Type);
            }

            if (playerBeamErrorResponse.MessageOption.IsSet)
            {
                writer.WriteString("message", playerBeamErrorResponse.Message);
            }

            if (playerBeamErrorResponse.TraceIdOption.IsSet)
            {
                writer.WriteString("traceId", playerBeamErrorResponse.TraceId);
            }
        }
    }
}