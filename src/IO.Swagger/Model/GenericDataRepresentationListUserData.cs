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
    /// GenericDataRepresentationListUserData
    /// </summary>
    [DataContract]
    public partial class GenericDataRepresentationListUserData :  IEquatable<GenericDataRepresentationListUserData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericDataRepresentationListUserData" /> class.
        /// </summary>
        /// <param name="Data">Data.</param>
        /// <param name="Links">Links.</param>
        /// <param name="Meta">Meta.</param>
        public GenericDataRepresentationListUserData(List<UserData> Data = default(List<UserData>), Dictionary<string, string> Links = default(Dictionary<string, string>), Dictionary<string, Object> Meta = default(Dictionary<string, Object>))
        {
            this.Data = Data;
            this.Links = Links;
            this.Meta = Meta;
        }
        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<UserData> Data { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public Dictionary<string, string> Links { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public Dictionary<string, Object> Meta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenericDataRepresentationListUserData {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return this.Equals(input as GenericDataRepresentationListUserData);
        }

        /// <summary>
        /// Returns true if GenericDataRepresentationListUserData instances are equal
        /// </summary>
        /// <param name="input">Instance of GenericDataRepresentationListUserData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenericDataRepresentationListUserData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.Meta == input.Meta ||
                    this.Meta != null &&
                    this.Meta.SequenceEqual(input.Meta)
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Meta != null)
                    hashCode = hashCode * 59 + this.Meta.GetHashCode();
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
