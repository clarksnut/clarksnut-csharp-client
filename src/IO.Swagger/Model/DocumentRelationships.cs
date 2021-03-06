/* 
 * Clarksnut
 *
 * Clarksnut UBL collector
 *
 * OpenAPI spec version: 1.2.0-SNAPSHOT
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// DocumentRelationships
    /// </summary>
    [DataContract]
    public partial class DocumentRelationships :  IEquatable<DocumentRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentRelationships" /> class.
        /// </summary>
        /// <param name="OwnedBy">OwnedBy.</param>
        public DocumentRelationships(OwnedBy OwnedBy = default(OwnedBy))
        {
            this.OwnedBy = OwnedBy;
        }
        
        /// <summary>
        /// Gets or Sets OwnedBy
        /// </summary>
        [DataMember(Name="ownedBy", EmitDefaultValue=false)]
        public OwnedBy OwnedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentRelationships {\n");
            sb.Append("  OwnedBy: ").Append(OwnedBy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DocumentRelationships);
        }

        /// <summary>
        /// Returns true if DocumentRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentRelationships input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OwnedBy == input.OwnedBy ||
                    (this.OwnedBy != null &&
                    this.OwnedBy.Equals(input.OwnedBy))
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
                if (this.OwnedBy != null)
                    hashCode = hashCode * 59 + this.OwnedBy.GetHashCode();
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
