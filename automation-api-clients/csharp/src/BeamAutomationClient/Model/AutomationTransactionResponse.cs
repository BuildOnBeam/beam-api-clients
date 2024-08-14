// <auto-generated>
/*
 * Automation API
 *
 * The Automation API is a service to integrate your game with Beam
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
using OpenAPIClientUtils = BeamAutomationClient.Client.ClientUtils;
using BeamAutomationClient.Client;

namespace BeamAutomationClient.Model
{
    /// <summary>
    /// AutomationTransactionResponse
    /// </summary>
    public partial class AutomationTransactionResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationTransactionResponse" /> class.
        /// </summary>
        /// <param name="chainId">chainId</param>
        /// <param name="createdAt">createdAt</param>
        /// <param name="explorerUrl">explorerUrl</param>
        /// <param name="id">id</param>
        /// <param name="intent">intent</param>
        /// <param name="policy">policy</param>
        /// <param name="profile">profile</param>
        /// <param name="status">status</param>
        /// <param name="success">success</param>
        /// <param name="type">type</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="transaction">transaction</param>
        /// <param name="transactionHash">transactionHash</param>
        [JsonConstructor]
        public AutomationTransactionResponse(decimal chainId, DateTime createdAt, string explorerUrl, string id, AutomationTransactionResponseIntent intent, AutomationTransactionResponsePolicy policy, AutomationTransactionResponseProfile profile, StatusEnum status, bool success, TypeEnum type, DateTime updatedAt, Option<AutomationTransactionResponseTransaction?> transaction = default, Option<string?> transactionHash = default)
        {
            ChainId = chainId;
            CreatedAt = createdAt;
            ExplorerUrl = explorerUrl;
            Id = id;
            Intent = intent;
            Policy = policy;
            Profile = profile;
            Status = status;
            Success = success;
            Type = type;
            UpdatedAt = updatedAt;
            TransactionOption = transaction;
            TransactionHashOption = transactionHash;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StatusEnumJsonConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            Pending = 1,

            /// <summary>
            /// Enum Success for value: success
            /// </summary>
            Success = 2
        }

        /// <summary>
        /// Returns a <see cref="StatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static StatusEnum StatusEnumFromString(string value)
        {
            if (value.Equals("pending"))
                return StatusEnum.Pending;

            if (value.Equals("success"))
                return StatusEnum.Success;

            throw new NotImplementedException($"Could not convert value to type StatusEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="StatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static StatusEnum? StatusEnumFromStringOrDefault(string value)
        {
            if (value.Equals("pending"))
                return StatusEnum.Pending;

            if (value.Equals("success"))
                return StatusEnum.Success;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="StatusEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string StatusEnumToJsonValue(StatusEnum value)
        {
            if (value == StatusEnum.Pending)
                return "pending";

            if (value == StatusEnum.Success)
                return "success";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Converts <see cref="StatusEnum"/> to and from the JSON value
        /// </summary>
        public static class StatusEnumValueConverter
        {
            /// <summary>
            /// Parses a given value to <see cref="StatusEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static StatusEnum FromString(string value)
            {
                    if (value.Equals("pending"))
                        return StatusEnum.Pending;

                    if (value.Equals("success"))
                        return StatusEnum.Success;

                throw new NotImplementedException($"Could not convert value to type StatusEnum: '{value}'");
            }

            /// <summary>
            /// Parses a given value to <see cref="StatusEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static StatusEnum? FromStringOrDefault(string value)
            {
                    if (value.Equals("pending"))
                        return StatusEnum.Pending;

                    if (value.Equals("success"))
                        return StatusEnum.Success;

                return null;
            }

            /// <summary>
            /// Converts the <see cref="StatusEnum"/> to the json value
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            /// <exception cref="NotImplementedException"></exception>
            public static string ToJsonValue(StatusEnum value)
            {
                        if (value == StatusEnum.Pending)
                            return "pending";

                        if (value == StatusEnum.Success)
                            return "success";

                throw new NotImplementedException($"Value could not be handled: '{value}'");
            }
        }

        /// <summary>
        /// A Json converter for type <see cref="StatusEnum"/>
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public class StatusEnumJsonConverter : JsonConverter<StatusEnum>
        {
            /// <summary>
            /// Returns a StatusEnum from the Json object
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="typeToConvert"></param>
            /// <param name="options"></param>
            /// <returns></returns>
            public override StatusEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                string? rawValue = reader.GetString();

                StatusEnum? result = rawValue == null
                    ? null
                    : StatusEnumValueConverter.FromStringOrDefault(rawValue);

                if (result != null)
                    return result.Value;

                throw new JsonException();
            }

            /// <summary>
            /// Writes the StatusEnum to the json writer
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="statusEnum"></param>
            /// <param name="options"></param>
            public override void Write(Utf8JsonWriter writer, StatusEnum statusEnum, JsonSerializerOptions options)
            {
                writer.WriteStringValue(StatusEnumValueConverter.ToJsonValue(statusEnum));
            }
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonPropertyName("status")]
        public StatusEnum Status { get; set; }

        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(TypeEnumJsonConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Custodial for value: custodial
            /// </summary>
            Custodial = 1,

            /// <summary>
            /// Enum SelfCustodial for value: self-custodial
            /// </summary>
            SelfCustodial = 2
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static TypeEnum TypeEnumFromString(string value)
        {
            if (value.Equals("custodial"))
                return TypeEnum.Custodial;

            if (value.Equals("self-custodial"))
                return TypeEnum.SelfCustodial;

            throw new NotImplementedException($"Could not convert value to type TypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeEnum? TypeEnumFromStringOrDefault(string value)
        {
            if (value.Equals("custodial"))
                return TypeEnum.Custodial;

            if (value.Equals("self-custodial"))
                return TypeEnum.SelfCustodial;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="TypeEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string TypeEnumToJsonValue(TypeEnum value)
        {
            if (value == TypeEnum.Custodial)
                return "custodial";

            if (value == TypeEnum.SelfCustodial)
                return "self-custodial";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Converts <see cref="TypeEnum"/> to and from the JSON value
        /// </summary>
        public static class TypeEnumValueConverter
        {
            /// <summary>
            /// Parses a given value to <see cref="TypeEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static TypeEnum FromString(string value)
            {
                    if (value.Equals("custodial"))
                        return TypeEnum.Custodial;

                    if (value.Equals("self-custodial"))
                        return TypeEnum.SelfCustodial;

                throw new NotImplementedException($"Could not convert value to type TypeEnum: '{value}'");
            }

            /// <summary>
            /// Parses a given value to <see cref="TypeEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static TypeEnum? FromStringOrDefault(string value)
            {
                    if (value.Equals("custodial"))
                        return TypeEnum.Custodial;

                    if (value.Equals("self-custodial"))
                        return TypeEnum.SelfCustodial;

                return null;
            }

            /// <summary>
            /// Converts the <see cref="TypeEnum"/> to the json value
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            /// <exception cref="NotImplementedException"></exception>
            public static string ToJsonValue(TypeEnum value)
            {
                        if (value == TypeEnum.Custodial)
                            return "custodial";

                        if (value == TypeEnum.SelfCustodial)
                            return "self-custodial";

                throw new NotImplementedException($"Value could not be handled: '{value}'");
            }
        }

        /// <summary>
        /// A Json converter for type <see cref="TypeEnum"/>
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public class TypeEnumJsonConverter : JsonConverter<TypeEnum>
        {
            /// <summary>
            /// Returns a TypeEnum from the Json object
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="typeToConvert"></param>
            /// <param name="options"></param>
            /// <returns></returns>
            public override TypeEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                string? rawValue = reader.GetString();

                TypeEnum? result = rawValue == null
                    ? null
                    : TypeEnumValueConverter.FromStringOrDefault(rawValue);

                if (result != null)
                    return result.Value;

                throw new JsonException();
            }

            /// <summary>
            /// Writes the TypeEnum to the json writer
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="typeEnum"></param>
            /// <param name="options"></param>
            public override void Write(Utf8JsonWriter writer, TypeEnum typeEnum, JsonSerializerOptions options)
            {
                writer.WriteStringValue(TypeEnumValueConverter.ToJsonValue(typeEnum));
            }
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [JsonPropertyName("chainId")]
        public decimal ChainId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ExplorerUrl
        /// </summary>
        [JsonPropertyName("explorerUrl")]
        public string ExplorerUrl { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Intent
        /// </summary>
        [JsonPropertyName("intent")]
        public AutomationTransactionResponseIntent Intent { get; set; }

        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [JsonPropertyName("policy")]
        public AutomationTransactionResponsePolicy Policy { get; set; }

        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [JsonPropertyName("profile")]
        public AutomationTransactionResponseProfile Profile { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Used to track the state of Transaction
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<AutomationTransactionResponseTransaction?> TransactionOption { get; private set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [JsonPropertyName("transaction")]
        public AutomationTransactionResponseTransaction? Transaction { get { return this. TransactionOption; } set { this.TransactionOption = new(value); } }

        /// <summary>
        /// Used to track the state of TransactionHash
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TransactionHashOption { get; private set; }

        /// <summary>
        /// Gets or Sets TransactionHash
        /// </summary>
        [JsonPropertyName("transactionHash")]
        public string? TransactionHash { get { return this. TransactionHashOption; } set { this.TransactionHashOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutomationTransactionResponse {\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ExplorerUrl: ").Append(ExplorerUrl).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Intent: ").Append(Intent).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("  TransactionHash: ").Append(TransactionHash).Append("\n");
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
    /// A Json converter for type <see cref="AutomationTransactionResponse" />
    /// </summary>
    public class AutomationTransactionResponseJsonConverter : JsonConverter<AutomationTransactionResponse>
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
        /// Deserializes json to <see cref="AutomationTransactionResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AutomationTransactionResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<decimal?> chainId = default;
            Option<DateTime?> createdAt = default;
            Option<string?> explorerUrl = default;
            Option<string?> id = default;
            Option<AutomationTransactionResponseIntent?> intent = default;
            Option<AutomationTransactionResponsePolicy?> policy = default;
            Option<AutomationTransactionResponseProfile?> profile = default;
            Option<AutomationTransactionResponse.StatusEnum?> status = default;
            Option<bool?> success = default;
            Option<AutomationTransactionResponse.TypeEnum?> type = default;
            Option<DateTime?> updatedAt = default;
            Option<AutomationTransactionResponseTransaction?> transaction = default;
            Option<string?> transactionHash = default;

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
                                chainId = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "createdAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "explorerUrl":
                            explorerUrl = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "intent":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                intent = new Option<AutomationTransactionResponseIntent?>(JsonSerializer.Deserialize<AutomationTransactionResponseIntent>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "policy":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                policy = new Option<AutomationTransactionResponsePolicy?>(JsonSerializer.Deserialize<AutomationTransactionResponsePolicy>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "profile":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                profile = new Option<AutomationTransactionResponseProfile?>(JsonSerializer.Deserialize<AutomationTransactionResponseProfile>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "status":
                            string? statusRawValue = utf8JsonReader.GetString();
                            if (statusRawValue != null)
                                status = new Option<AutomationTransactionResponse.StatusEnum?>(AutomationTransactionResponse.StatusEnumFromStringOrDefault(statusRawValue));
                            break;
                        case "success":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                success = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "type":
                            string? typeRawValue = utf8JsonReader.GetString();
                            if (typeRawValue != null)
                                type = new Option<AutomationTransactionResponse.TypeEnum?>(AutomationTransactionResponse.TypeEnumFromStringOrDefault(typeRawValue));
                            break;
                        case "updatedAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                updatedAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "transaction":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                transaction = new Option<AutomationTransactionResponseTransaction?>(JsonSerializer.Deserialize<AutomationTransactionResponseTransaction>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "transactionHash":
                            transactionHash = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!chainId.IsSet)
                throw new ArgumentException("Property is required for class AutomationTransactionResponse.", nameof(chainId));

            if (!createdAt.IsSet)
                throw new ArgumentException("Property is required for class AutomationTransactionResponse.", nameof(createdAt));

            if (!explorerUrl.IsSet)
                throw new ArgumentException("Property is required for class AutomationTransactionResponse.", nameof(explorerUrl));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class AutomationTransactionResponse.", nameof(id));

            if (!intent.IsSet)
                throw new ArgumentException("Property is required for class AutomationTransactionResponse.", nameof(intent));

            if (!policy.IsSet)
                throw new ArgumentException("Property is required for class AutomationTransactionResponse.", nameof(policy));

            if (!profile.IsSet)
                throw new ArgumentException("Property is required for class AutomationTransactionResponse.", nameof(profile));

            if (!status.IsSet)
                throw new ArgumentException("Property is required for class AutomationTransactionResponse.", nameof(status));

            if (!success.IsSet)
                throw new ArgumentException("Property is required for class AutomationTransactionResponse.", nameof(success));

            if (!type.IsSet)
                throw new ArgumentException("Property is required for class AutomationTransactionResponse.", nameof(type));

            if (!updatedAt.IsSet)
                throw new ArgumentException("Property is required for class AutomationTransactionResponse.", nameof(updatedAt));

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class AutomationTransactionResponse.");

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class AutomationTransactionResponse.");

            if (explorerUrl.IsSet && explorerUrl.Value == null)
                throw new ArgumentNullException(nameof(explorerUrl), "Property is not nullable for class AutomationTransactionResponse.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class AutomationTransactionResponse.");

            if (intent.IsSet && intent.Value == null)
                throw new ArgumentNullException(nameof(intent), "Property is not nullable for class AutomationTransactionResponse.");

            if (policy.IsSet && policy.Value == null)
                throw new ArgumentNullException(nameof(policy), "Property is not nullable for class AutomationTransactionResponse.");

            if (profile.IsSet && profile.Value == null)
                throw new ArgumentNullException(nameof(profile), "Property is not nullable for class AutomationTransactionResponse.");

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class AutomationTransactionResponse.");

            if (success.IsSet && success.Value == null)
                throw new ArgumentNullException(nameof(success), "Property is not nullable for class AutomationTransactionResponse.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class AutomationTransactionResponse.");

            if (updatedAt.IsSet && updatedAt.Value == null)
                throw new ArgumentNullException(nameof(updatedAt), "Property is not nullable for class AutomationTransactionResponse.");

            if (transactionHash.IsSet && transactionHash.Value == null)
                throw new ArgumentNullException(nameof(transactionHash), "Property is not nullable for class AutomationTransactionResponse.");

            return new AutomationTransactionResponse(chainId.Value!.Value!, createdAt.Value!.Value!, explorerUrl.Value!, id.Value!, intent.Value!, policy.Value!, profile.Value!, status.Value!.Value!, success.Value!.Value!, type.Value!.Value!, updatedAt.Value!.Value!, transaction, transactionHash);
        }

        /// <summary>
        /// Serializes a <see cref="AutomationTransactionResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationTransactionResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AutomationTransactionResponse automationTransactionResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, automationTransactionResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AutomationTransactionResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationTransactionResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, AutomationTransactionResponse automationTransactionResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (automationTransactionResponse.ExplorerUrl == null)
                throw new ArgumentNullException(nameof(automationTransactionResponse.ExplorerUrl), "Property is required for class AutomationTransactionResponse.");

            if (automationTransactionResponse.Id == null)
                throw new ArgumentNullException(nameof(automationTransactionResponse.Id), "Property is required for class AutomationTransactionResponse.");

            if (automationTransactionResponse.Intent == null)
                throw new ArgumentNullException(nameof(automationTransactionResponse.Intent), "Property is required for class AutomationTransactionResponse.");

            if (automationTransactionResponse.Policy == null)
                throw new ArgumentNullException(nameof(automationTransactionResponse.Policy), "Property is required for class AutomationTransactionResponse.");

            if (automationTransactionResponse.Profile == null)
                throw new ArgumentNullException(nameof(automationTransactionResponse.Profile), "Property is required for class AutomationTransactionResponse.");

            if (automationTransactionResponse.TransactionHashOption.IsSet && automationTransactionResponse.TransactionHash == null)
                throw new ArgumentNullException(nameof(automationTransactionResponse.TransactionHash), "Property is required for class AutomationTransactionResponse.");

            writer.WriteNumber("chainId", automationTransactionResponse.ChainId);

            writer.WriteString("createdAt", automationTransactionResponse.CreatedAt.ToString(CreatedAtFormat));

            writer.WriteString("explorerUrl", automationTransactionResponse.ExplorerUrl);

            writer.WriteString("id", automationTransactionResponse.Id);

            writer.WritePropertyName("intent");
            JsonSerializer.Serialize(writer, automationTransactionResponse.Intent, jsonSerializerOptions);
            writer.WritePropertyName("policy");
            JsonSerializer.Serialize(writer, automationTransactionResponse.Policy, jsonSerializerOptions);
            writer.WritePropertyName("profile");
            JsonSerializer.Serialize(writer, automationTransactionResponse.Profile, jsonSerializerOptions);
            var statusRawValue = AutomationTransactionResponse.StatusEnumToJsonValue(automationTransactionResponse.Status);
            writer.WriteString("status", statusRawValue);
            writer.WriteBoolean("success", automationTransactionResponse.Success);

            var typeRawValue = AutomationTransactionResponse.TypeEnumToJsonValue(automationTransactionResponse.Type);
            writer.WriteString("type", typeRawValue);
            writer.WriteString("updatedAt", automationTransactionResponse.UpdatedAt.ToString(UpdatedAtFormat));

            if (automationTransactionResponse.TransactionOption.IsSet)
                if (automationTransactionResponse.TransactionOption.Value != null)
                {
                    writer.WritePropertyName("transaction");
                    JsonSerializer.Serialize(writer, automationTransactionResponse.Transaction, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("transaction");
            if (automationTransactionResponse.TransactionHashOption.IsSet)
                writer.WriteString("transactionHash", automationTransactionResponse.TransactionHash);
        }
    }
}