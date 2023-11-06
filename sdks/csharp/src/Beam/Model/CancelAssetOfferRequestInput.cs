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
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Beam.Client.FileParameter;
using OpenAPIDateConverter = Beam.Client.OpenAPIDateConverter;

namespace Beam.Model
{
    /// <summary>
    /// CancelAssetOfferRequestInput
    /// </summary>
    [DataContract(Name = "CancelAssetOfferRequestInput")]
    public partial class CancelAssetOfferRequestInput : IEquatable<CancelAssetOfferRequestInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelAssetOfferRequestInput" /> class.
        /// </summary>
        /// <param name="optimistic">optimistic (default to false).</param>
        /// <param name="sponsor">sponsor (default to true).</param>
        /// <param name="policyId">policyId.</param>
        public CancelAssetOfferRequestInput(bool optimistic = false, bool sponsor = true, string policyId = default(string))
        {
            this.Optimistic = optimistic;
            this.Sponsor = sponsor;
            this.PolicyId = policyId;
        }

        /// <summary>
        /// Gets or Sets Optimistic
        /// </summary>
        [DataMember(Name = "optimistic", EmitDefaultValue = true)]
        public bool Optimistic { get; set; }

        /// <summary>
        /// Gets or Sets Sponsor
        /// </summary>
        [DataMember(Name = "sponsor", EmitDefaultValue = true)]
        public bool Sponsor { get; set; }

        /// <summary>
        /// Gets or Sets PolicyId
        /// </summary>
        [DataMember(Name = "policyId", EmitDefaultValue = false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CancelAssetOfferRequestInput {\n");
            sb.Append("  Optimistic: ").Append(Optimistic).Append("\n");
            sb.Append("  Sponsor: ").Append(Sponsor).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CancelAssetOfferRequestInput);
        }

        /// <summary>
        /// Returns true if CancelAssetOfferRequestInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CancelAssetOfferRequestInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancelAssetOfferRequestInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Optimistic == input.Optimistic ||
                    this.Optimistic.Equals(input.Optimistic)
                ) && 
                (
                    this.Sponsor == input.Sponsor ||
                    this.Sponsor.Equals(input.Sponsor)
                ) && 
                (
                    this.PolicyId == input.PolicyId ||
                    (this.PolicyId != null &&
                    this.PolicyId.Equals(input.PolicyId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Optimistic.GetHashCode();
                hashCode = (hashCode * 59) + this.Sponsor.GetHashCode();
                if (this.PolicyId != null)
                {
                    hashCode = (hashCode * 59) + this.PolicyId.GetHashCode();
                }
                return hashCode;
            }
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

}
