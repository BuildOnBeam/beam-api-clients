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
    /// PlayerOperationAction
    /// </summary>
    public partial class PlayerOperationAction : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerOperationAction" /> class.
        /// </summary>
        /// <param name="type">type</param>
        /// <param name="id">id</param>
        /// <param name="index">index</param>
        /// <param name="operationId">operationId</param>
        /// <param name="context">context</param>
        /// <param name="signature">signature</param>
        /// <param name="transaction">transaction</param>
        [JsonConstructor]
        public PlayerOperationAction(TypeEnum type, string id, int index, string operationId = default, Option<Object> context = default, Option<PlayerOperationActionSignature> signature = default, Option<PlayerOperationActionTransaction> transaction = default)
        {
            Type = type;
            Id = id;
            Index = index;
            OperationId = operationId;
            ContextOption = context;
            SignatureOption = signature;
            TransactionOption = transaction;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(TypeEnumJsonConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum FiatOnRamp for value: FiatOnRamp
            /// </summary>
            FiatOnRamp = 1,

            /// <summary>
            /// Enum Sign for value: Sign
            /// </summary>
            Sign = 2,

            /// <summary>
            /// Enum SessionRevoke for value: SessionRevoke
            /// </summary>
            SessionRevoke = 3,

            /// <summary>
            /// Enum MarketplaceCreateOffer for value: MarketplaceCreateOffer
            /// </summary>
            MarketplaceCreateOffer = 4,

            /// <summary>
            /// Enum MarketplaceCancelOffer for value: MarketplaceCancelOffer
            /// </summary>
            MarketplaceCancelOffer = 5,

            /// <summary>
            /// Enum MarketplaceAcceptOffer for value: MarketplaceAcceptOffer
            /// </summary>
            MarketplaceAcceptOffer = 6,

            /// <summary>
            /// Enum MarketplaceBuyAsset for value: MarketplaceBuyAsset
            /// </summary>
            MarketplaceBuyAsset = 7,

            /// <summary>
            /// Enum MarketplaceListAsset for value: MarketplaceListAsset
            /// </summary>
            MarketplaceListAsset = 8,

            /// <summary>
            /// Enum MarketplaceCancelListing for value: MarketplaceCancelListing
            /// </summary>
            MarketplaceCancelListing = 9,

            /// <summary>
            /// Enum ExchangeConvert for value: ExchangeConvert
            /// </summary>
            ExchangeConvert = 10,

            /// <summary>
            /// Enum ExchangeWrap for value: ExchangeWrap
            /// </summary>
            ExchangeWrap = 11,

            /// <summary>
            /// Enum ExchangeUnwrap for value: ExchangeUnwrap
            /// </summary>
            ExchangeUnwrap = 12,

            /// <summary>
            /// Enum TransferNFTs for value: TransferNFTs
            /// </summary>
            TransferNFTs = 13,

            /// <summary>
            /// Enum TransferToken for value: TransferToken
            /// </summary>
            TransferToken = 14,

            /// <summary>
            /// Enum CustomTransaction for value: CustomTransaction
            /// </summary>
            CustomTransaction = 15
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static TypeEnum TypeEnumFromString(string value)
        {
            if (value.Equals("FiatOnRamp"))
                return TypeEnum.FiatOnRamp;

            if (value.Equals("Sign"))
                return TypeEnum.Sign;

            if (value.Equals("SessionRevoke"))
                return TypeEnum.SessionRevoke;

            if (value.Equals("MarketplaceCreateOffer"))
                return TypeEnum.MarketplaceCreateOffer;

            if (value.Equals("MarketplaceCancelOffer"))
                return TypeEnum.MarketplaceCancelOffer;

            if (value.Equals("MarketplaceAcceptOffer"))
                return TypeEnum.MarketplaceAcceptOffer;

            if (value.Equals("MarketplaceBuyAsset"))
                return TypeEnum.MarketplaceBuyAsset;

            if (value.Equals("MarketplaceListAsset"))
                return TypeEnum.MarketplaceListAsset;

            if (value.Equals("MarketplaceCancelListing"))
                return TypeEnum.MarketplaceCancelListing;

            if (value.Equals("ExchangeConvert"))
                return TypeEnum.ExchangeConvert;

            if (value.Equals("ExchangeWrap"))
                return TypeEnum.ExchangeWrap;

            if (value.Equals("ExchangeUnwrap"))
                return TypeEnum.ExchangeUnwrap;

            if (value.Equals("TransferNFTs"))
                return TypeEnum.TransferNFTs;

            if (value.Equals("TransferToken"))
                return TypeEnum.TransferToken;

            if (value.Equals("CustomTransaction"))
                return TypeEnum.CustomTransaction;

            throw new NotImplementedException($"Could not convert value to type TypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeEnum? TypeEnumFromStringOrDefault(string value)
        {
            if (value.Equals("FiatOnRamp"))
                return TypeEnum.FiatOnRamp;

            if (value.Equals("Sign"))
                return TypeEnum.Sign;

            if (value.Equals("SessionRevoke"))
                return TypeEnum.SessionRevoke;

            if (value.Equals("MarketplaceCreateOffer"))
                return TypeEnum.MarketplaceCreateOffer;

            if (value.Equals("MarketplaceCancelOffer"))
                return TypeEnum.MarketplaceCancelOffer;

            if (value.Equals("MarketplaceAcceptOffer"))
                return TypeEnum.MarketplaceAcceptOffer;

            if (value.Equals("MarketplaceBuyAsset"))
                return TypeEnum.MarketplaceBuyAsset;

            if (value.Equals("MarketplaceListAsset"))
                return TypeEnum.MarketplaceListAsset;

            if (value.Equals("MarketplaceCancelListing"))
                return TypeEnum.MarketplaceCancelListing;

            if (value.Equals("ExchangeConvert"))
                return TypeEnum.ExchangeConvert;

            if (value.Equals("ExchangeWrap"))
                return TypeEnum.ExchangeWrap;

            if (value.Equals("ExchangeUnwrap"))
                return TypeEnum.ExchangeUnwrap;

            if (value.Equals("TransferNFTs"))
                return TypeEnum.TransferNFTs;

            if (value.Equals("TransferToken"))
                return TypeEnum.TransferToken;

            if (value.Equals("CustomTransaction"))
                return TypeEnum.CustomTransaction;

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
            if (value == null)
                return null;

            if (value == TypeEnum.FiatOnRamp)
                return "FiatOnRamp";

            if (value == TypeEnum.Sign)
                return "Sign";

            if (value == TypeEnum.SessionRevoke)
                return "SessionRevoke";

            if (value == TypeEnum.MarketplaceCreateOffer)
                return "MarketplaceCreateOffer";

            if (value == TypeEnum.MarketplaceCancelOffer)
                return "MarketplaceCancelOffer";

            if (value == TypeEnum.MarketplaceAcceptOffer)
                return "MarketplaceAcceptOffer";

            if (value == TypeEnum.MarketplaceBuyAsset)
                return "MarketplaceBuyAsset";

            if (value == TypeEnum.MarketplaceListAsset)
                return "MarketplaceListAsset";

            if (value == TypeEnum.MarketplaceCancelListing)
                return "MarketplaceCancelListing";

            if (value == TypeEnum.ExchangeConvert)
                return "ExchangeConvert";

            if (value == TypeEnum.ExchangeWrap)
                return "ExchangeWrap";

            if (value == TypeEnum.ExchangeUnwrap)
                return "ExchangeUnwrap";

            if (value == TypeEnum.TransferNFTs)
                return "TransferNFTs";

            if (value == TypeEnum.TransferToken)
                return "TransferToken";

            if (value == TypeEnum.CustomTransaction)
                return "CustomTransaction";

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
                    if (value.Equals("FiatOnRamp"))
                    return TypeEnum.FiatOnRamp;

                    if (value.Equals("Sign"))
                    return TypeEnum.Sign;

                    if (value.Equals("SessionRevoke"))
                    return TypeEnum.SessionRevoke;

                    if (value.Equals("MarketplaceCreateOffer"))
                    return TypeEnum.MarketplaceCreateOffer;

                    if (value.Equals("MarketplaceCancelOffer"))
                    return TypeEnum.MarketplaceCancelOffer;

                    if (value.Equals("MarketplaceAcceptOffer"))
                    return TypeEnum.MarketplaceAcceptOffer;

                    if (value.Equals("MarketplaceBuyAsset"))
                    return TypeEnum.MarketplaceBuyAsset;

                    if (value.Equals("MarketplaceListAsset"))
                    return TypeEnum.MarketplaceListAsset;

                    if (value.Equals("MarketplaceCancelListing"))
                    return TypeEnum.MarketplaceCancelListing;

                    if (value.Equals("ExchangeConvert"))
                    return TypeEnum.ExchangeConvert;

                    if (value.Equals("ExchangeWrap"))
                    return TypeEnum.ExchangeWrap;

                    if (value.Equals("ExchangeUnwrap"))
                    return TypeEnum.ExchangeUnwrap;

                    if (value.Equals("TransferNFTs"))
                    return TypeEnum.TransferNFTs;

                    if (value.Equals("TransferToken"))
                    return TypeEnum.TransferToken;

                    if (value.Equals("CustomTransaction"))
                    return TypeEnum.CustomTransaction;

            throw new NotImplementedException($"Could not convert value to type TypeEnum: '{value}'");
            }

            /// <summary>
            /// Parses a given value to <see cref="TypeEnum"/>
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static TypeEnum? FromStringOrDefault(string value)
            {
                    if (value.Equals("FiatOnRamp"))
                    return TypeEnum.FiatOnRamp;

                    if (value.Equals("Sign"))
                    return TypeEnum.Sign;

                    if (value.Equals("SessionRevoke"))
                    return TypeEnum.SessionRevoke;

                    if (value.Equals("MarketplaceCreateOffer"))
                    return TypeEnum.MarketplaceCreateOffer;

                    if (value.Equals("MarketplaceCancelOffer"))
                    return TypeEnum.MarketplaceCancelOffer;

                    if (value.Equals("MarketplaceAcceptOffer"))
                    return TypeEnum.MarketplaceAcceptOffer;

                    if (value.Equals("MarketplaceBuyAsset"))
                    return TypeEnum.MarketplaceBuyAsset;

                    if (value.Equals("MarketplaceListAsset"))
                    return TypeEnum.MarketplaceListAsset;

                    if (value.Equals("MarketplaceCancelListing"))
                    return TypeEnum.MarketplaceCancelListing;

                    if (value.Equals("ExchangeConvert"))
                    return TypeEnum.ExchangeConvert;

                    if (value.Equals("ExchangeWrap"))
                    return TypeEnum.ExchangeWrap;

                    if (value.Equals("ExchangeUnwrap"))
                    return TypeEnum.ExchangeUnwrap;

                    if (value.Equals("TransferNFTs"))
                    return TypeEnum.TransferNFTs;

                    if (value.Equals("TransferToken"))
                    return TypeEnum.TransferToken;

                    if (value.Equals("CustomTransaction"))
                    return TypeEnum.CustomTransaction;

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
                        if (value == TypeEnum.FiatOnRamp)
                        return "FiatOnRamp";

                        if (value == TypeEnum.Sign)
                        return "Sign";

                        if (value == TypeEnum.SessionRevoke)
                        return "SessionRevoke";

                        if (value == TypeEnum.MarketplaceCreateOffer)
                        return "MarketplaceCreateOffer";

                        if (value == TypeEnum.MarketplaceCancelOffer)
                        return "MarketplaceCancelOffer";

                        if (value == TypeEnum.MarketplaceAcceptOffer)
                        return "MarketplaceAcceptOffer";

                        if (value == TypeEnum.MarketplaceBuyAsset)
                        return "MarketplaceBuyAsset";

                        if (value == TypeEnum.MarketplaceListAsset)
                        return "MarketplaceListAsset";

                        if (value == TypeEnum.MarketplaceCancelListing)
                        return "MarketplaceCancelListing";

                        if (value == TypeEnum.ExchangeConvert)
                        return "ExchangeConvert";

                        if (value == TypeEnum.ExchangeWrap)
                        return "ExchangeWrap";

                        if (value == TypeEnum.ExchangeUnwrap)
                        return "ExchangeUnwrap";

                        if (value == TypeEnum.TransferNFTs)
                        return "TransferNFTs";

                        if (value == TypeEnum.TransferToken)
                        return "TransferToken";

                        if (value == TypeEnum.CustomTransaction)
                        return "CustomTransaction";

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
                string rawValue = reader.GetString();

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
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [JsonPropertyName("index")]
        public int Index { get; set; }

        /// <summary>
        /// Gets or Sets OperationId
        /// </summary>
        [JsonPropertyName("operationId")]
        public string OperationId { get; set; }

        /// <summary>
        /// Used to track the state of Context
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object> ContextOption { get; private set; }

        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [JsonPropertyName("context")]
        public Object Context { get { return this.ContextOption; } set { this.ContextOption = new(value); } }

        /// <summary>
        /// Used to track the state of Signature
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<PlayerOperationActionSignature> SignatureOption { get; private set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [JsonPropertyName("signature")]
        public PlayerOperationActionSignature Signature { get { return this.SignatureOption; } set { this.SignatureOption = new(value); } }

        /// <summary>
        /// Used to track the state of Transaction
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<PlayerOperationActionTransaction> TransactionOption { get; private set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [JsonPropertyName("transaction")]
        public PlayerOperationActionTransaction Transaction { get { return this.TransactionOption; } set { this.TransactionOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerOperationAction {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
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
    /// A Json converter for type <see cref="PlayerOperationAction" />
    /// </summary>
    public class PlayerOperationActionJsonConverter : JsonConverter<PlayerOperationAction>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerOperationAction" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerOperationAction Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<PlayerOperationAction.TypeEnum?> type = default;
            Option<string> id = default;
            Option<int?> index = default;
            Option<string> operationId = default;
            Option<Object> context = default;
            Option<PlayerOperationActionSignature> signature = default;
            Option<PlayerOperationActionTransaction> transaction = default;

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
                        case "type":
                            string typeRawValue = utf8JsonReader.GetString();
                            if (typeRawValue != null)
                                type = new Option<PlayerOperationAction.TypeEnum?>(PlayerOperationAction.TypeEnumFromStringOrDefault(typeRawValue));
                            break;
                        case "id":
                            id = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "index":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                index = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "operationId":
                            operationId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "context":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                context = new Option<Object>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "signature":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                signature = new Option<PlayerOperationActionSignature>(JsonSerializer.Deserialize<PlayerOperationActionSignature>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "transaction":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                transaction = new Option<PlayerOperationActionTransaction>(JsonSerializer.Deserialize<PlayerOperationActionTransaction>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!type.IsSet)
                throw new ArgumentException("Property is required for class PlayerOperationAction.", nameof(type));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class PlayerOperationAction.", nameof(id));

            if (!index.IsSet)
                throw new ArgumentException("Property is required for class PlayerOperationAction.", nameof(index));

            if (!operationId.IsSet)
                throw new ArgumentException("Property is required for class PlayerOperationAction.", nameof(operationId));

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class PlayerOperationAction.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class PlayerOperationAction.");

            if (index.IsSet && index.Value == null)
                throw new ArgumentNullException(nameof(index), "Property is not nullable for class PlayerOperationAction.");

            return new PlayerOperationAction(type.Value.Value, id.Value, index.Value.Value, operationId.Value, context, signature, transaction);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerOperationAction" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerOperationAction"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerOperationAction playerOperationAction, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, playerOperationAction, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerOperationAction" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerOperationAction"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PlayerOperationAction playerOperationAction, JsonSerializerOptions jsonSerializerOptions)
        {
            if (playerOperationAction.Id == null)
                throw new ArgumentNullException(nameof(playerOperationAction.Id), "Property is required for class PlayerOperationAction.");

            var typeRawValue = PlayerOperationAction.TypeEnumToJsonValue(playerOperationAction.Type);
            if (typeRawValue != null)
                writer.WriteString("type", typeRawValue);
            writer.WriteString("id", playerOperationAction.Id);

            writer.WriteNumber("index", playerOperationAction.Index);

            if (playerOperationAction.OperationId != null)
            {
                writer.WriteString("operationId", playerOperationAction.OperationId);
            }
            else
            {
                writer.WriteNull("operationId");
            }

            if (playerOperationAction.ContextOption.IsSet)
                if (playerOperationAction.ContextOption.Value != null)
                {
                    writer.WritePropertyName("context");
                    JsonSerializer.Serialize(writer, playerOperationAction.Context, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("context");
            if (playerOperationAction.SignatureOption.IsSet)
                if (playerOperationAction.SignatureOption.Value != null)
                {
                    writer.WritePropertyName("signature");
                    JsonSerializer.Serialize(writer, playerOperationAction.Signature, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("signature");
            if (playerOperationAction.TransactionOption.IsSet)
                if (playerOperationAction.TransactionOption.Value != null)
                {
                    writer.WritePropertyName("transaction");
                    JsonSerializer.Serialize(writer, playerOperationAction.Transaction, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("transaction");
        }
    }
}