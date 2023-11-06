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
    /// GetAssetResponseContractAvatar
    /// </summary>
    [DataContract(Name = "GetAssetResponse_contract_avatar")]
    public partial class GetAssetResponseContractAvatar : IEquatable<GetAssetResponseContractAvatar>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetResponseContractAvatar" /> class.
        /// </summary>
        /// <param name="src">src.</param>
        /// <param name="caption">caption.</param>
        public GetAssetResponseContractAvatar(string src = default(string), string caption = default(string))
        {
            this.Src = src;
            this.Caption = caption;
        }

        /// <summary>
        /// Gets or Sets Src
        /// </summary>
        [DataMember(Name = "src", EmitDefaultValue = true)]
        public string Src { get; set; }

        /// <summary>
        /// Gets or Sets Caption
        /// </summary>
        [DataMember(Name = "caption", EmitDefaultValue = true)]
        public string Caption { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAssetResponseContractAvatar {\n");
            sb.Append("  Src: ").Append(Src).Append("\n");
            sb.Append("  Caption: ").Append(Caption).Append("\n");
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
            return this.Equals(input as GetAssetResponseContractAvatar);
        }

        /// <summary>
        /// Returns true if GetAssetResponseContractAvatar instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAssetResponseContractAvatar to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAssetResponseContractAvatar input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Src == input.Src ||
                    (this.Src != null &&
                    this.Src.Equals(input.Src))
                ) && 
                (
                    this.Caption == input.Caption ||
                    (this.Caption != null &&
                    this.Caption.Equals(input.Caption))
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
                if (this.Src != null)
                {
                    hashCode = (hashCode * 59) + this.Src.GetHashCode();
                }
                if (this.Caption != null)
                {
                    hashCode = (hashCode * 59) + this.Caption.GetHashCode();
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
