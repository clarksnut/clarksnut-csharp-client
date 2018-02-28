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
    /// MultipartFormDataInput
    /// </summary>
    [DataContract]
    public partial class MultipartFormDataInput :  IEquatable<MultipartFormDataInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartFormDataInput" /> class.
        /// </summary>
        /// <param name="FormDataMap">FormDataMap.</param>
        /// <param name="FormData">FormData.</param>
        /// <param name="Parts">Parts.</param>
        /// <param name="Preamble">Preamble.</param>
        public MultipartFormDataInput(Dictionary<string, List<InputPart>> FormDataMap = default(Dictionary<string, List<InputPart>>), Dictionary<string, InputPart> FormData = default(Dictionary<string, InputPart>), List<InputPart> Parts = default(List<InputPart>), string Preamble = default(string))
        {
            this.FormDataMap = FormDataMap;
            this.FormData = FormData;
            this.Parts = Parts;
            this.Preamble = Preamble;
        }
        
        /// <summary>
        /// Gets or Sets FormDataMap
        /// </summary>
        [DataMember(Name="formDataMap", EmitDefaultValue=false)]
        public Dictionary<string, List<InputPart>> FormDataMap { get; set; }

        /// <summary>
        /// Gets or Sets FormData
        /// </summary>
        [DataMember(Name="formData", EmitDefaultValue=false)]
        public Dictionary<string, InputPart> FormData { get; set; }

        /// <summary>
        /// Gets or Sets Parts
        /// </summary>
        [DataMember(Name="parts", EmitDefaultValue=false)]
        public List<InputPart> Parts { get; set; }

        /// <summary>
        /// Gets or Sets Preamble
        /// </summary>
        [DataMember(Name="preamble", EmitDefaultValue=false)]
        public string Preamble { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultipartFormDataInput {\n");
            sb.Append("  FormDataMap: ").Append(FormDataMap).Append("\n");
            sb.Append("  FormData: ").Append(FormData).Append("\n");
            sb.Append("  Parts: ").Append(Parts).Append("\n");
            sb.Append("  Preamble: ").Append(Preamble).Append("\n");
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
            return this.Equals(input as MultipartFormDataInput);
        }

        /// <summary>
        /// Returns true if MultipartFormDataInput instances are equal
        /// </summary>
        /// <param name="input">Instance of MultipartFormDataInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultipartFormDataInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FormDataMap == input.FormDataMap ||
                    this.FormDataMap != null &&
                    this.FormDataMap.SequenceEqual(input.FormDataMap)
                ) && 
                (
                    this.FormData == input.FormData ||
                    this.FormData != null &&
                    this.FormData.SequenceEqual(input.FormData)
                ) && 
                (
                    this.Parts == input.Parts ||
                    this.Parts != null &&
                    this.Parts.SequenceEqual(input.Parts)
                ) && 
                (
                    this.Preamble == input.Preamble ||
                    (this.Preamble != null &&
                    this.Preamble.Equals(input.Preamble))
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
                if (this.FormDataMap != null)
                    hashCode = hashCode * 59 + this.FormDataMap.GetHashCode();
                if (this.FormData != null)
                    hashCode = hashCode * 59 + this.FormData.GetHashCode();
                if (this.Parts != null)
                    hashCode = hashCode * 59 + this.Parts.GetHashCode();
                if (this.Preamble != null)
                    hashCode = hashCode * 59 + this.Preamble.GetHashCode();
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
