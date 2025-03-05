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
    /// AutomationGetChainResponseNativeCurrency
    /// </summary>
    public partial class AutomationGetChainResponseNativeCurrency : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationGetChainResponseNativeCurrency" /> class.
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="symbol">symbol</param>
        /// <param name="decimals">decimals</param>
        [JsonConstructor]
        public AutomationGetChainResponseNativeCurrency(string name, string symbol, decimal decimals)
        {
            Name = name;
            Symbol = symbol;
            Decimals = decimals;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets Decimals
        /// </summary>
        [JsonPropertyName("decimals")]
        public decimal Decimals { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutomationGetChainResponseNativeCurrency {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Decimals: ").Append(Decimals).Append("\n");
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
    /// A Json converter for type <see cref="AutomationGetChainResponseNativeCurrency" />
    /// </summary>
    public class AutomationGetChainResponseNativeCurrencyJsonConverter : JsonConverter<AutomationGetChainResponseNativeCurrency>
    {
        /// <summary>
        /// Deserializes json to <see cref="AutomationGetChainResponseNativeCurrency" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AutomationGetChainResponseNativeCurrency Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> name = default;
            Option<string> symbol = default;
            Option<decimal?> decimals = default;

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
                        case "name":
                            name = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "symbol":
                            symbol = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "decimals":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                decimals = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetChainResponseNativeCurrency.", nameof(name));

            if (!symbol.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetChainResponseNativeCurrency.", nameof(symbol));

            if (!decimals.IsSet)
                throw new ArgumentException("Property is required for class AutomationGetChainResponseNativeCurrency.", nameof(decimals));

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class AutomationGetChainResponseNativeCurrency.");

            if (symbol.IsSet && symbol.Value == null)
                throw new ArgumentNullException(nameof(symbol), "Property is not nullable for class AutomationGetChainResponseNativeCurrency.");

            if (decimals.IsSet && decimals.Value == null)
                throw new ArgumentNullException(nameof(decimals), "Property is not nullable for class AutomationGetChainResponseNativeCurrency.");

            return new AutomationGetChainResponseNativeCurrency(name.Value, symbol.Value, decimals.Value.Value);
        }

        /// <summary>
        /// Serializes a <see cref="AutomationGetChainResponseNativeCurrency" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationGetChainResponseNativeCurrency"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AutomationGetChainResponseNativeCurrency automationGetChainResponseNativeCurrency, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, automationGetChainResponseNativeCurrency, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AutomationGetChainResponseNativeCurrency" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="automationGetChainResponseNativeCurrency"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AutomationGetChainResponseNativeCurrency automationGetChainResponseNativeCurrency, JsonSerializerOptions jsonSerializerOptions)
        {
            if (automationGetChainResponseNativeCurrency.Name == null)
                throw new ArgumentNullException(nameof(automationGetChainResponseNativeCurrency.Name), "Property is required for class AutomationGetChainResponseNativeCurrency.");

            if (automationGetChainResponseNativeCurrency.Symbol == null)
                throw new ArgumentNullException(nameof(automationGetChainResponseNativeCurrency.Symbol), "Property is required for class AutomationGetChainResponseNativeCurrency.");

            writer.WriteString("name", automationGetChainResponseNativeCurrency.Name);

            writer.WriteString("symbol", automationGetChainResponseNativeCurrency.Symbol);

            writer.WriteNumber("decimals", automationGetChainResponseNativeCurrency.Decimals);
        }
    }
}