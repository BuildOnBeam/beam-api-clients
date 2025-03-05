/*
 * Player API
 *
 * The Player API is a service to integrate your game with Beam
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using BeamPlayerClient.Model;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("BeamPlayerClient.Test")]

namespace BeamPlayerClient.Client
{
    /// <summary>
    /// Utility functions providing some benefit to API client consumers.
    /// </summary>
    public static partial class ClientUtils
    {

        /// <summary>
        /// A delegate for events.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public delegate void EventHandler<T>(object sender, T e) where T : EventArgs;

        /// <summary>
        /// An enum of headers
        /// </summary>
        public enum ApiKeyHeader
        {
            /// <summary>
            /// The x-api-key header
            /// </summary>
            X_api_key
        }

        /// <summary>
        /// Converte an ApiKeyHeader to a string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="System.ComponentModel.InvalidEnumArgumentException"></exception>
        public static string ApiKeyHeaderToString(ApiKeyHeader value)
        {
            return value switch
            {
                ApiKeyHeader.X_api_key => "x-api-key",
                _ => throw new System.ComponentModel.InvalidEnumArgumentException(nameof(value), (int)value, typeof(ApiKeyHeader)),
            };
        }

        /// <summary>
        /// Returns true when deserialization succeeds.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <param name="options"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool TryDeserialize<T>(string json, JsonSerializerOptions options, [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T result)
        {
            try
            {
                result = JsonSerializer.Deserialize<T>(json, options);
                return result != null;
            }
            catch (Exception)
            {
                result = default;
                return false;
            }
        }

        /// <summary>
        /// Returns true when deserialization succeeds.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <param name="options"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool TryDeserialize<T>(ref Utf8JsonReader reader, JsonSerializerOptions options, [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T result)
        {
            try
            {
                result = JsonSerializer.Deserialize<T>(ref reader, options);
                return result != null;
            }
            catch (Exception)
            {
                result = default;
                return false;
            }
        }

        /// <summary>
        /// If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
        /// If parameter is a list, join the list with ",".
        /// Otherwise just return the string.
        /// </summary>
        /// <param name="obj">The parameter (header, path, query, form).</param>
        /// <param name="format">The DateTime serialization format.</param>
        /// <returns>Formatted string.</returns>
        public static string ParameterToString(object obj, string format = ISO8601_DATETIME_FORMAT)
        {
            if (obj is DateTime dateTime)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return dateTime.ToString(format);
            if (obj is DateTimeOffset dateTimeOffset)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return dateTimeOffset.ToString(format);
            if (obj is DateOnly dateOnly)
                return dateOnly.ToString(format);
            if (obj is bool boolean)
                return boolean
                    ? "true"
                    : "false";
            if (obj is PlayerAcceptAssetOfferRequestInput.OperationProcessingEnum playerAcceptAssetOfferRequestInputOperationProcessingEnum)
                return PlayerAcceptAssetOfferRequestInput.OperationProcessingEnumToJsonValue(playerAcceptAssetOfferRequestInputOperationProcessingEnum);
            if (obj is PlayerAcceptAssetOfferRequestInput.AuthProviderEnum playerAcceptAssetOfferRequestInputAuthProviderEnum)
                return PlayerAcceptAssetOfferRequestInput.AuthProviderEnumToJsonValue(playerAcceptAssetOfferRequestInputAuthProviderEnum);
            if (obj is PlayerBuyAssetRequestInput.OperationProcessingEnum playerBuyAssetRequestInputOperationProcessingEnum)
                return PlayerBuyAssetRequestInput.OperationProcessingEnumToJsonValue(playerBuyAssetRequestInputOperationProcessingEnum);
            if (obj is PlayerBuyAssetRequestInput.AuthProviderEnum playerBuyAssetRequestInputAuthProviderEnum)
                return PlayerBuyAssetRequestInput.AuthProviderEnumToJsonValue(playerBuyAssetRequestInputAuthProviderEnum);
            if (obj is PlayerCancelAssetListingRequestInput.OperationProcessingEnum playerCancelAssetListingRequestInputOperationProcessingEnum)
                return PlayerCancelAssetListingRequestInput.OperationProcessingEnumToJsonValue(playerCancelAssetListingRequestInputOperationProcessingEnum);
            if (obj is PlayerCancelAssetListingRequestInput.AuthProviderEnum playerCancelAssetListingRequestInputAuthProviderEnum)
                return PlayerCancelAssetListingRequestInput.AuthProviderEnumToJsonValue(playerCancelAssetListingRequestInputAuthProviderEnum);
            if (obj is PlayerCancelAssetOfferRequestInput.OperationProcessingEnum playerCancelAssetOfferRequestInputOperationProcessingEnum)
                return PlayerCancelAssetOfferRequestInput.OperationProcessingEnumToJsonValue(playerCancelAssetOfferRequestInputOperationProcessingEnum);
            if (obj is PlayerCancelAssetOfferRequestInput.AuthProviderEnum playerCancelAssetOfferRequestInputAuthProviderEnum)
                return PlayerCancelAssetOfferRequestInput.AuthProviderEnumToJsonValue(playerCancelAssetOfferRequestInputAuthProviderEnum);
            if (obj is PlayerCommonActivityResponseDataInner.TypeEnum playerCommonActivityResponseDataInnerTypeEnum)
                return PlayerCommonActivityResponseDataInner.TypeEnumToJsonValue(playerCommonActivityResponseDataInnerTypeEnum);
            if (obj is PlayerCommonAssetActivityRequestInput.TypesEnum playerCommonAssetActivityRequestInputTypesEnum)
                return PlayerCommonAssetActivityRequestInput.TypesEnumToJsonValue(playerCommonAssetActivityRequestInputTypesEnum);
            if (obj is PlayerCommonContractActivityRequestInput.TypesEnum playerCommonContractActivityRequestInputTypesEnum)
                return PlayerCommonContractActivityRequestInput.TypesEnumToJsonValue(playerCommonContractActivityRequestInputTypesEnum);
            if (obj is PlayerCommonUserActivityRequestInput.TypesEnum playerCommonUserActivityRequestInputTypesEnum)
                return PlayerCommonUserActivityRequestInput.TypesEnumToJsonValue(playerCommonUserActivityRequestInputTypesEnum);
            if (obj is PlayerConfirmOperationRequest.StatusEnum playerConfirmOperationRequestStatusEnum)
                return PlayerConfirmOperationRequest.StatusEnumToJsonValue(playerConfirmOperationRequestStatusEnum);
            if (obj is PlayerConvertTokenRequestInput.OperationProcessingEnum playerConvertTokenRequestInputOperationProcessingEnum)
                return PlayerConvertTokenRequestInput.OperationProcessingEnumToJsonValue(playerConvertTokenRequestInputOperationProcessingEnum);
            if (obj is PlayerConvertTokenRequestInput.AuthProviderEnum playerConvertTokenRequestInputAuthProviderEnum)
                return PlayerConvertTokenRequestInput.AuthProviderEnumToJsonValue(playerConvertTokenRequestInputAuthProviderEnum);
            if (obj is PlayerCreateAssetOfferRequestInput.CurrencyEnum playerCreateAssetOfferRequestInputCurrencyEnum)
                return PlayerCreateAssetOfferRequestInput.CurrencyEnumToJsonValue(playerCreateAssetOfferRequestInputCurrencyEnum);
            if (obj is PlayerCreateAssetOfferRequestInput.OperationProcessingEnum playerCreateAssetOfferRequestInputOperationProcessingEnum)
                return PlayerCreateAssetOfferRequestInput.OperationProcessingEnumToJsonValue(playerCreateAssetOfferRequestInputOperationProcessingEnum);
            if (obj is PlayerCreateAssetOfferRequestInput.AuthProviderEnum playerCreateAssetOfferRequestInputAuthProviderEnum)
                return PlayerCreateAssetOfferRequestInput.AuthProviderEnumToJsonValue(playerCreateAssetOfferRequestInputAuthProviderEnum);
            if (obj is PlayerCreateConnectionRequestInput.AuthProviderEnum playerCreateConnectionRequestInputAuthProviderEnum)
                return PlayerCreateConnectionRequestInput.AuthProviderEnumToJsonValue(playerCreateConnectionRequestInputAuthProviderEnum);
            if (obj is PlayerCreateConnectionRequestResponse.StatusEnum playerCreateConnectionRequestResponseStatusEnum)
                return PlayerCreateConnectionRequestResponse.StatusEnumToJsonValue(playerCreateConnectionRequestResponseStatusEnum);
            if (obj is PlayerCreateOnrampRequestInput.TokenEnum playerCreateOnrampRequestInputTokenEnum)
                return PlayerCreateOnrampRequestInput.TokenEnumToJsonValue(playerCreateOnrampRequestInputTokenEnum);
            if (obj is PlayerCreateOnrampRequestInput.AuthProviderEnum playerCreateOnrampRequestInputAuthProviderEnum)
                return PlayerCreateOnrampRequestInput.AuthProviderEnumToJsonValue(playerCreateOnrampRequestInputAuthProviderEnum);
            if (obj is PlayerCreateTransactionRequestInput.OperationProcessingEnum playerCreateTransactionRequestInputOperationProcessingEnum)
                return PlayerCreateTransactionRequestInput.OperationProcessingEnumToJsonValue(playerCreateTransactionRequestInputOperationProcessingEnum);
            if (obj is PlayerCreateTransactionRequestInput.AuthProviderEnum playerCreateTransactionRequestInputAuthProviderEnum)
                return PlayerCreateTransactionRequestInput.AuthProviderEnumToJsonValue(playerCreateTransactionRequestInputAuthProviderEnum);
            if (obj is PlayerGenerateSessionRequestResponse.StatusEnum playerGenerateSessionRequestResponseStatusEnum)
                return PlayerGenerateSessionRequestResponse.StatusEnumToJsonValue(playerGenerateSessionRequestResponseStatusEnum);
            if (obj is PlayerGenerateSessionUrlRequestInput.AuthProviderEnum playerGenerateSessionUrlRequestInputAuthProviderEnum)
                return PlayerGenerateSessionUrlRequestInput.AuthProviderEnumToJsonValue(playerGenerateSessionUrlRequestInputAuthProviderEnum);
            if (obj is PlayerGetAssetListingsResponseDataInner.StatusEnum playerGetAssetListingsResponseDataInnerStatusEnum)
                return PlayerGetAssetListingsResponseDataInner.StatusEnumToJsonValue(playerGetAssetListingsResponseDataInnerStatusEnum);
            if (obj is PlayerGetAssetListingsResponseDataInnerPriceCurrency.SymbolEnum playerGetAssetListingsResponseDataInnerPriceCurrencySymbolEnum)
                return PlayerGetAssetListingsResponseDataInnerPriceCurrency.SymbolEnumToJsonValue(playerGetAssetListingsResponseDataInnerPriceCurrencySymbolEnum);
            if (obj is PlayerGetAssetResponse.RarityEnum playerGetAssetResponseRarityEnum)
                return PlayerGetAssetResponse.RarityEnumToJsonValue(playerGetAssetResponseRarityEnum);
            if (obj is PlayerGetAssetsForContractBodyInput.SortDirectionEnum playerGetAssetsForContractBodyInputSortDirectionEnum)
                return PlayerGetAssetsForContractBodyInput.SortDirectionEnumToJsonValue(playerGetAssetsForContractBodyInputSortDirectionEnum);
            if (obj is PlayerGetAssetsForContractBodyInput.SortByEnum playerGetAssetsForContractBodyInputSortByEnum)
                return PlayerGetAssetsForContractBodyInput.SortByEnumToJsonValue(playerGetAssetsForContractBodyInputSortByEnum);
            if (obj is PlayerGetAssetsForContractResponseDataInner.RarityEnum playerGetAssetsForContractResponseDataInnerRarityEnum)
                return PlayerGetAssetsForContractResponseDataInner.RarityEnumToJsonValue(playerGetAssetsForContractResponseDataInnerRarityEnum);
            if (obj is PlayerGetAssetsForUserBodyInput.SortDirectionEnum playerGetAssetsForUserBodyInputSortDirectionEnum)
                return PlayerGetAssetsForUserBodyInput.SortDirectionEnumToJsonValue(playerGetAssetsForUserBodyInputSortDirectionEnum);
            if (obj is PlayerGetAssetsForUserBodyInput.SortByEnum playerGetAssetsForUserBodyInputSortByEnum)
                return PlayerGetAssetsForUserBodyInput.SortByEnumToJsonValue(playerGetAssetsForUserBodyInputSortByEnum);
            if (obj is PlayerGetAssetsForUserResponseDataInner.RarityEnum playerGetAssetsForUserResponseDataInnerRarityEnum)
                return PlayerGetAssetsForUserResponseDataInner.RarityEnumToJsonValue(playerGetAssetsForUserResponseDataInnerRarityEnum);
            if (obj is PlayerGetAttributesResponseDataInner.KindEnum playerGetAttributesResponseDataInnerKindEnum)
                return PlayerGetAttributesResponseDataInner.KindEnumToJsonValue(playerGetAttributesResponseDataInnerKindEnum);
            if (obj is PlayerGetChainCurrenciesResponseDataInner.SymbolEnum playerGetChainCurrenciesResponseDataInnerSymbolEnum)
                return PlayerGetChainCurrenciesResponseDataInner.SymbolEnumToJsonValue(playerGetChainCurrenciesResponseDataInnerSymbolEnum);
            if (obj is PlayerGetConnectionRequestResponse.StatusEnum playerGetConnectionRequestResponseStatusEnum)
                return PlayerGetConnectionRequestResponse.StatusEnumToJsonValue(playerGetConnectionRequestResponseStatusEnum);
            if (obj is PlayerGetListedAssetsBodyInput.SortByEnum playerGetListedAssetsBodyInputSortByEnum)
                return PlayerGetListedAssetsBodyInput.SortByEnumToJsonValue(playerGetListedAssetsBodyInputSortByEnum);
            if (obj is PlayerGetListedAssetsBodyInput.SortDirectionEnum playerGetListedAssetsBodyInputSortDirectionEnum)
                return PlayerGetListedAssetsBodyInput.SortDirectionEnumToJsonValue(playerGetListedAssetsBodyInputSortDirectionEnum);
            if (obj is PlayerGetOwnerAssetsBodyInput.SortDirectionEnum playerGetOwnerAssetsBodyInputSortDirectionEnum)
                return PlayerGetOwnerAssetsBodyInput.SortDirectionEnumToJsonValue(playerGetOwnerAssetsBodyInputSortDirectionEnum);
            if (obj is PlayerGetOwnerAssetsBodyInput.SortByEnum playerGetOwnerAssetsBodyInputSortByEnum)
                return PlayerGetOwnerAssetsBodyInput.SortByEnumToJsonValue(playerGetOwnerAssetsBodyInputSortByEnum);
            if (obj is PlayerGetSessionRequestResponse.StatusEnum playerGetSessionRequestResponseStatusEnum)
                return PlayerGetSessionRequestResponse.StatusEnumToJsonValue(playerGetSessionRequestResponseStatusEnum);
            if (obj is PlayerOperationAction.TypeEnum playerOperationActionTypeEnum)
                return PlayerOperationAction.TypeEnumToJsonValue(playerOperationActionTypeEnum);
            if (obj is PlayerOperationActionSignature.TypeEnum playerOperationActionSignatureTypeEnum)
                return PlayerOperationActionSignature.TypeEnumToJsonValue(playerOperationActionSignatureTypeEnum);
            if (obj is PlayerOperationActionTransaction.StatusEnum playerOperationActionTransactionStatusEnum)
                return PlayerOperationActionTransaction.StatusEnumToJsonValue(playerOperationActionTransactionStatusEnum);
            if (obj is PlayerPlayerOperationResponse.StatusEnum playerPlayerOperationResponseStatusEnum)
                return PlayerPlayerOperationResponse.StatusEnumToJsonValue(playerPlayerOperationResponseStatusEnum);
            if (obj is PlayerPlayerOperationResponse.ProcessingEnum playerPlayerOperationResponseProcessingEnum)
                return PlayerPlayerOperationResponse.ProcessingEnumToJsonValue(playerPlayerOperationResponseProcessingEnum);
            if (obj is PlayerPlayerOperationResponse.AuthProviderEnum playerPlayerOperationResponseAuthProviderEnum)
                return PlayerPlayerOperationResponse.AuthProviderEnumToJsonValue(playerPlayerOperationResponseAuthProviderEnum);
            if (obj is PlayerPlayerOperationResponseTransactionsInner.StatusEnum playerPlayerOperationResponseTransactionsInnerStatusEnum)
                return PlayerPlayerOperationResponseTransactionsInner.StatusEnumToJsonValue(playerPlayerOperationResponseTransactionsInnerStatusEnum);
            if (obj is PlayerPlayerOperationResponseTransactionsInner.TypeEnum playerPlayerOperationResponseTransactionsInnerTypeEnum)
                return PlayerPlayerOperationResponseTransactionsInner.TypeEnumToJsonValue(playerPlayerOperationResponseTransactionsInnerTypeEnum);
            if (obj is PlayerRevokeSessionRequestInput.OperationProcessingEnum playerRevokeSessionRequestInputOperationProcessingEnum)
                return PlayerRevokeSessionRequestInput.OperationProcessingEnumToJsonValue(playerRevokeSessionRequestInputOperationProcessingEnum);
            if (obj is PlayerRevokeSessionRequestInput.AuthProviderEnum playerRevokeSessionRequestInputAuthProviderEnum)
                return PlayerRevokeSessionRequestInput.AuthProviderEnumToJsonValue(playerRevokeSessionRequestInputAuthProviderEnum);
            if (obj is PlayerSellAssetRequestInput.SellTypeEnum playerSellAssetRequestInputSellTypeEnum)
                return PlayerSellAssetRequestInput.SellTypeEnumToJsonValue(playerSellAssetRequestInputSellTypeEnum);
            if (obj is PlayerSellAssetRequestInput.CurrencyEnum playerSellAssetRequestInputCurrencyEnum)
                return PlayerSellAssetRequestInput.CurrencyEnumToJsonValue(playerSellAssetRequestInputCurrencyEnum);
            if (obj is PlayerSellAssetRequestInput.OperationProcessingEnum playerSellAssetRequestInputOperationProcessingEnum)
                return PlayerSellAssetRequestInput.OperationProcessingEnumToJsonValue(playerSellAssetRequestInputOperationProcessingEnum);
            if (obj is PlayerSellAssetRequestInput.AuthProviderEnum playerSellAssetRequestInputAuthProviderEnum)
                return PlayerSellAssetRequestInput.AuthProviderEnumToJsonValue(playerSellAssetRequestInputAuthProviderEnum);
            if (obj is PlayerTransferAssetRequestInput.OperationProcessingEnum playerTransferAssetRequestInputOperationProcessingEnum)
                return PlayerTransferAssetRequestInput.OperationProcessingEnumToJsonValue(playerTransferAssetRequestInputOperationProcessingEnum);
            if (obj is PlayerTransferAssetRequestInput.AuthProviderEnum playerTransferAssetRequestInputAuthProviderEnum)
                return PlayerTransferAssetRequestInput.AuthProviderEnumToJsonValue(playerTransferAssetRequestInputAuthProviderEnum);
            if (obj is PlayerTransferNativeTokenRequestInput.OperationProcessingEnum playerTransferNativeTokenRequestInputOperationProcessingEnum)
                return PlayerTransferNativeTokenRequestInput.OperationProcessingEnumToJsonValue(playerTransferNativeTokenRequestInputOperationProcessingEnum);
            if (obj is PlayerTransferNativeTokenRequestInput.AuthProviderEnum playerTransferNativeTokenRequestInputAuthProviderEnum)
                return PlayerTransferNativeTokenRequestInput.AuthProviderEnumToJsonValue(playerTransferNativeTokenRequestInputAuthProviderEnum);
            if (obj is PlayerTransferTokenRequestInput.OperationProcessingEnum playerTransferTokenRequestInputOperationProcessingEnum)
                return PlayerTransferTokenRequestInput.OperationProcessingEnumToJsonValue(playerTransferTokenRequestInputOperationProcessingEnum);
            if (obj is PlayerTransferTokenRequestInput.AuthProviderEnum playerTransferTokenRequestInputAuthProviderEnum)
                return PlayerTransferTokenRequestInput.AuthProviderEnumToJsonValue(playerTransferTokenRequestInputAuthProviderEnum);
            if (obj is PlayerUnwrappingTokenInput.OperationProcessingEnum playerUnwrappingTokenInputOperationProcessingEnum)
                return PlayerUnwrappingTokenInput.OperationProcessingEnumToJsonValue(playerUnwrappingTokenInputOperationProcessingEnum);
            if (obj is PlayerUnwrappingTokenInput.AuthProviderEnum playerUnwrappingTokenInputAuthProviderEnum)
                return PlayerUnwrappingTokenInput.AuthProviderEnumToJsonValue(playerUnwrappingTokenInputAuthProviderEnum);
            if (obj is PlayerWrappingTokenInput.OperationProcessingEnum playerWrappingTokenInputOperationProcessingEnum)
                return PlayerWrappingTokenInput.OperationProcessingEnumToJsonValue(playerWrappingTokenInputOperationProcessingEnum);
            if (obj is PlayerWrappingTokenInput.AuthProviderEnum playerWrappingTokenInputAuthProviderEnum)
                return PlayerWrappingTokenInput.AuthProviderEnumToJsonValue(playerWrappingTokenInputAuthProviderEnum);
            if (obj is ICollection collection)
            {
                List<string> entries = new();
                foreach (var entry in collection)
                    entries.Add(ParameterToString(entry));
                return string.Join(",", entries);
            }

            return Convert.ToString(obj, System.Globalization.CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// URL encode a string
        /// Credit/Ref: https://github.com/restsharp/RestSharp/blob/master/RestSharp/Extensions/StringExtensions.cs#L50
        /// </summary>
        /// <param name="input">string to be URL encoded</param>
        /// <returns>Byte array</returns>
        public static string UrlEncode(string input)
        {
            const int maxLength = 32766;

            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (input.Length <= maxLength)
            {
                return Uri.EscapeDataString(input);
            }

            StringBuilder sb = new StringBuilder(input.Length * 2);
            int index = 0;

            while (index < input.Length)
            {
                int length = Math.Min(input.Length - index, maxLength);
                string subString = input.Substring(index, length);

                sb.Append(Uri.EscapeDataString(subString));
                index += subString.Length;
            }

            return sb.ToString();
        }

        /// <summary>
        /// Encode string in base64 format.
        /// </summary>
        /// <param name="text">string to be encoded.</param>
        /// <returns>Encoded string.</returns>
        public static string Base64Encode(string text)
        {
            return Convert.ToBase64String(global::System.Text.Encoding.UTF8.GetBytes(text));
        }

        /// <summary>
        /// Convert stream to byte array
        /// </summary>
        /// <param name="inputStream">Input stream to be converted</param>
        /// <returns>Byte array</returns>
        public static byte[] ReadAsBytes(Stream inputStream)
        {
            using (var ms = new MemoryStream())
            {
                inputStream.CopyTo(ms);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Select the Content-Type header's value from the given content-type array:
        /// if JSON type exists in the given array, use it;
        /// otherwise use the first one defined in 'consumes'
        /// </summary>
        /// <param name="contentTypes">The Content-Type array to select from.</param>
        /// <returns>The Content-Type header to use.</returns>
        public static string SelectHeaderContentType(string[] contentTypes)
        {
            if (contentTypes.Length == 0)
                return null;

            foreach (var contentType in contentTypes)
            {
                if (IsJsonMime(contentType))
                    return contentType;
            }

            return contentTypes[0]; // use the first content type specified in 'consumes'
        }

        /// <summary>
        /// Select the Accept header's value from the given accepts array:
        /// if JSON exists in the given array, use it;
        /// otherwise use all of them (joining into a string)
        /// </summary>
        /// <param name="accepts">The accepts array to select from.</param>
        /// <returns>The Accept header to use.</returns>
        public static string SelectHeaderAccept(string[] accepts)
        {
            if (accepts.Length == 0)
                return null;

            if (accepts.Contains("application/json", StringComparer.OrdinalIgnoreCase))
                return "application/json";

            return string.Join(",", accepts);
        }

        /// <summary>
        /// Provides a case-insensitive check that a provided content type is a known JSON-like content type.
        /// </summary>
        private static readonly Regex JsonRegex = new Regex("(?i)^(application/json|[^;/ \t]+/[^;/ \t]+[+]json)[ \t]*(;.*)?$");

        /// <summary>
        /// Check if the given MIME is a JSON MIME.
        /// JSON MIME examples:
        ///    application/json
        ///    application/json; charset=UTF8
        ///    APPLICATION/JSON
        ///    application/vnd.company+json
        /// </summary>
        /// <param name="mime">MIME</param>
        /// <returns>Returns True if MIME type is json.</returns>
        public static bool IsJsonMime(string mime)
        {
            if (string.IsNullOrWhiteSpace(mime)) return false;

            return JsonRegex.IsMatch(mime) || mime.Equals("application/json-patch+json");
        }

        /// <summary>
        /// Get the discriminator
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="discriminator"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public static string GetDiscriminator(Utf8JsonReader utf8JsonReader, string discriminator)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

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

                    if (localVarJsonPropertyName != null && localVarJsonPropertyName.Equals(discriminator))
                        return utf8JsonReader.GetString();
                }
            }

            throw new JsonException("The specified discriminator was not found.");
        }

        /// <summary>
        /// The base path of the API
        /// </summary>
        public const string BASE_ADDRESS = "http://localhost";

        /// <summary>
        /// The scheme of the API
        /// </summary>
        public const string SCHEME = "http";

        /// <summary>
        /// The context path of the API
        /// </summary>
        public const string CONTEXT_PATH = "";

        /// <summary>
        /// The host of the API
        /// </summary>
        public const string HOST = "localhost";

        /// <summary>
        /// The format to use for DateTime serialization
        /// </summary>
        public const string ISO8601_DATETIME_FORMAT = "o";
    }
}