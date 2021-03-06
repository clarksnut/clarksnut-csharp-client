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
    /// DocumentQueryAttributes
    /// </summary>
    [DataContract]
    public partial class DocumentQueryAttributes :  IEquatable<DocumentQueryAttributes>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoleEnum
        {
            
            /// <summary>
            /// Enum SENDER for "SENDER"
            /// </summary>
            [EnumMember(Value = "SENDER")]
            SENDER = 1,
            
            /// <summary>
            /// Enum RECEIVER for "RECEIVER"
            /// </summary>
            [EnumMember(Value = "RECEIVER")]
            RECEIVER = 2
        }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public RoleEnum? Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentQueryAttributes" /> class.
        /// </summary>
        /// <param name="Role">Role.</param>
        /// <param name="FilterText">FilterText.</param>
        /// <param name="Types">Types.</param>
        /// <param name="Currencies">Currencies.</param>
        /// <param name="After">After.</param>
        /// <param name="Before">Before.</param>
        /// <param name="LessThan">LessThan.</param>
        /// <param name="GreaterThan">GreaterThan.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="Spaces">Spaces.</param>
        /// <param name="OrderBy">OrderBy.</param>
        /// <param name="Asc">Asc.</param>
        /// <param name="Offset">Offset.</param>
        /// <param name="Limit">Limit.</param>
        /// <param name="Starred">Starred.</param>
        /// <param name="Viewed">Viewed.</param>
        /// <param name="_Checked">_Checked.</param>
        public DocumentQueryAttributes(RoleEnum? Role = default(RoleEnum?), string FilterText = default(string), List<string> Types = default(List<string>), List<string> Currencies = default(List<string>), DateTime? After = default(DateTime?), DateTime? Before = default(DateTime?), float? LessThan = default(float?), float? GreaterThan = default(float?), List<string> Tags = default(List<string>), List<string> Spaces = default(List<string>), string OrderBy = default(string), bool? Asc = default(bool?), int? Offset = default(int?), int? Limit = default(int?), bool? Starred = default(bool?), bool? Viewed = default(bool?), bool? _Checked = default(bool?))
        {
            this.Role = Role;
            this.FilterText = FilterText;
            this.Types = Types;
            this.Currencies = Currencies;
            this.After = After;
            this.Before = Before;
            this.LessThan = LessThan;
            this.GreaterThan = GreaterThan;
            this.Tags = Tags;
            this.Spaces = Spaces;
            this.OrderBy = OrderBy;
            this.Asc = Asc;
            this.Offset = Offset;
            this.Limit = Limit;
            this.Starred = Starred;
            this.Viewed = Viewed;
            this._Checked = _Checked;
        }
        

        /// <summary>
        /// Gets or Sets FilterText
        /// </summary>
        [DataMember(Name="filterText", EmitDefaultValue=false)]
        public string FilterText { get; set; }

        /// <summary>
        /// Gets or Sets Types
        /// </summary>
        [DataMember(Name="types", EmitDefaultValue=false)]
        public List<string> Types { get; set; }

        /// <summary>
        /// Gets or Sets Currencies
        /// </summary>
        [DataMember(Name="currencies", EmitDefaultValue=false)]
        public List<string> Currencies { get; set; }

        /// <summary>
        /// Gets or Sets After
        /// </summary>
        [DataMember(Name="after", EmitDefaultValue=false)]
        public DateTime? After { get; set; }

        /// <summary>
        /// Gets or Sets Before
        /// </summary>
        [DataMember(Name="before", EmitDefaultValue=false)]
        public DateTime? Before { get; set; }

        /// <summary>
        /// Gets or Sets LessThan
        /// </summary>
        [DataMember(Name="lessThan", EmitDefaultValue=false)]
        public float? LessThan { get; set; }

        /// <summary>
        /// Gets or Sets GreaterThan
        /// </summary>
        [DataMember(Name="greaterThan", EmitDefaultValue=false)]
        public float? GreaterThan { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Spaces
        /// </summary>
        [DataMember(Name="spaces", EmitDefaultValue=false)]
        public List<string> Spaces { get; set; }

        /// <summary>
        /// Gets or Sets OrderBy
        /// </summary>
        [DataMember(Name="orderBy", EmitDefaultValue=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// Gets or Sets Asc
        /// </summary>
        [DataMember(Name="asc", EmitDefaultValue=false)]
        public bool? Asc { get; set; }

        /// <summary>
        /// Gets or Sets Offset
        /// </summary>
        [DataMember(Name="offset", EmitDefaultValue=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// Gets or Sets Starred
        /// </summary>
        [DataMember(Name="starred", EmitDefaultValue=false)]
        public bool? Starred { get; set; }

        /// <summary>
        /// Gets or Sets Viewed
        /// </summary>
        [DataMember(Name="viewed", EmitDefaultValue=false)]
        public bool? Viewed { get; set; }

        /// <summary>
        /// Gets or Sets _Checked
        /// </summary>
        [DataMember(Name="checked", EmitDefaultValue=false)]
        public bool? _Checked { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentQueryAttributes {\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  FilterText: ").Append(FilterText).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
            sb.Append("  Currencies: ").Append(Currencies).Append("\n");
            sb.Append("  After: ").Append(After).Append("\n");
            sb.Append("  Before: ").Append(Before).Append("\n");
            sb.Append("  LessThan: ").Append(LessThan).Append("\n");
            sb.Append("  GreaterThan: ").Append(GreaterThan).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Spaces: ").Append(Spaces).Append("\n");
            sb.Append("  OrderBy: ").Append(OrderBy).Append("\n");
            sb.Append("  Asc: ").Append(Asc).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Starred: ").Append(Starred).Append("\n");
            sb.Append("  Viewed: ").Append(Viewed).Append("\n");
            sb.Append("  _Checked: ").Append(_Checked).Append("\n");
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
            return this.Equals(input as DocumentQueryAttributes);
        }

        /// <summary>
        /// Returns true if DocumentQueryAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentQueryAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentQueryAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.FilterText == input.FilterText ||
                    (this.FilterText != null &&
                    this.FilterText.Equals(input.FilterText))
                ) && 
                (
                    this.Types == input.Types ||
                    this.Types != null &&
                    this.Types.SequenceEqual(input.Types)
                ) && 
                (
                    this.Currencies == input.Currencies ||
                    this.Currencies != null &&
                    this.Currencies.SequenceEqual(input.Currencies)
                ) && 
                (
                    this.After == input.After ||
                    (this.After != null &&
                    this.After.Equals(input.After))
                ) && 
                (
                    this.Before == input.Before ||
                    (this.Before != null &&
                    this.Before.Equals(input.Before))
                ) && 
                (
                    this.LessThan == input.LessThan ||
                    (this.LessThan != null &&
                    this.LessThan.Equals(input.LessThan))
                ) && 
                (
                    this.GreaterThan == input.GreaterThan ||
                    (this.GreaterThan != null &&
                    this.GreaterThan.Equals(input.GreaterThan))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Spaces == input.Spaces ||
                    this.Spaces != null &&
                    this.Spaces.SequenceEqual(input.Spaces)
                ) && 
                (
                    this.OrderBy == input.OrderBy ||
                    (this.OrderBy != null &&
                    this.OrderBy.Equals(input.OrderBy))
                ) && 
                (
                    this.Asc == input.Asc ||
                    (this.Asc != null &&
                    this.Asc.Equals(input.Asc))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Starred == input.Starred ||
                    (this.Starred != null &&
                    this.Starred.Equals(input.Starred))
                ) && 
                (
                    this.Viewed == input.Viewed ||
                    (this.Viewed != null &&
                    this.Viewed.Equals(input.Viewed))
                ) && 
                (
                    this._Checked == input._Checked ||
                    (this._Checked != null &&
                    this._Checked.Equals(input._Checked))
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
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.FilterText != null)
                    hashCode = hashCode * 59 + this.FilterText.GetHashCode();
                if (this.Types != null)
                    hashCode = hashCode * 59 + this.Types.GetHashCode();
                if (this.Currencies != null)
                    hashCode = hashCode * 59 + this.Currencies.GetHashCode();
                if (this.After != null)
                    hashCode = hashCode * 59 + this.After.GetHashCode();
                if (this.Before != null)
                    hashCode = hashCode * 59 + this.Before.GetHashCode();
                if (this.LessThan != null)
                    hashCode = hashCode * 59 + this.LessThan.GetHashCode();
                if (this.GreaterThan != null)
                    hashCode = hashCode * 59 + this.GreaterThan.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Spaces != null)
                    hashCode = hashCode * 59 + this.Spaces.GetHashCode();
                if (this.OrderBy != null)
                    hashCode = hashCode * 59 + this.OrderBy.GetHashCode();
                if (this.Asc != null)
                    hashCode = hashCode * 59 + this.Asc.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Starred != null)
                    hashCode = hashCode * 59 + this.Starred.GetHashCode();
                if (this.Viewed != null)
                    hashCode = hashCode * 59 + this.Viewed.GetHashCode();
                if (this._Checked != null)
                    hashCode = hashCode * 59 + this._Checked.GetHashCode();
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
