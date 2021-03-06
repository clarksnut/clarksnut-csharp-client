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
    /// DocumentAttributes
    /// </summary>
    [DataContract]
    public partial class DocumentAttributes :  IEquatable<DocumentAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentAttributes" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Type">Type.</param>
        /// <param name="AssignedId">AssignedId.</param>
        /// <param name="SupplierAssignedId">SupplierAssignedId.</param>
        /// <param name="CustomerAssignedId">CustomerAssignedId.</param>
        /// <param name="IssueDate">IssueDate.</param>
        /// <param name="Currency">Currency.</param>
        /// <param name="Amount">Amount.</param>
        /// <param name="Tax">Tax.</param>
        /// <param name="SupplierName">SupplierName.</param>
        /// <param name="SupplierStreetAddress">SupplierStreetAddress.</param>
        /// <param name="SupplierCity">SupplierCity.</param>
        /// <param name="SupplierCountry">SupplierCountry.</param>
        /// <param name="CustomerName">CustomerName.</param>
        /// <param name="CustomerStreetAddress">CustomerStreetAddress.</param>
        /// <param name="CustomerCity">CustomerCity.</param>
        /// <param name="CustomerCountry">CustomerCountry.</param>
        /// <param name="Viewed">Viewed.</param>
        /// <param name="Starred">Starred.</param>
        /// <param name="_Checked">_Checked.</param>
        /// <param name="Versions">Versions.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        public DocumentAttributes(string Id = default(string), string Type = default(string), string AssignedId = default(string), string SupplierAssignedId = default(string), string CustomerAssignedId = default(string), DateTime? IssueDate = default(DateTime?), string Currency = default(string), float? Amount = default(float?), float? Tax = default(float?), string SupplierName = default(string), string SupplierStreetAddress = default(string), string SupplierCity = default(string), string SupplierCountry = default(string), string CustomerName = default(string), string CustomerStreetAddress = default(string), string CustomerCity = default(string), string CustomerCountry = default(string), bool? Viewed = default(bool?), bool? Starred = default(bool?), bool? _Checked = default(bool?), List<string> Versions = default(List<string>), DateTime? CreatedAt = default(DateTime?), DateTime? UpdatedAt = default(DateTime?))
        {
            this.Id = Id;
            this.Type = Type;
            this.AssignedId = AssignedId;
            this.SupplierAssignedId = SupplierAssignedId;
            this.CustomerAssignedId = CustomerAssignedId;
            this.IssueDate = IssueDate;
            this.Currency = Currency;
            this.Amount = Amount;
            this.Tax = Tax;
            this.SupplierName = SupplierName;
            this.SupplierStreetAddress = SupplierStreetAddress;
            this.SupplierCity = SupplierCity;
            this.SupplierCountry = SupplierCountry;
            this.CustomerName = CustomerName;
            this.CustomerStreetAddress = CustomerStreetAddress;
            this.CustomerCity = CustomerCity;
            this.CustomerCountry = CustomerCountry;
            this.Viewed = Viewed;
            this.Starred = Starred;
            this._Checked = _Checked;
            this.Versions = Versions;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets AssignedId
        /// </summary>
        [DataMember(Name="assignedId", EmitDefaultValue=false)]
        public string AssignedId { get; set; }

        /// <summary>
        /// Gets or Sets SupplierAssignedId
        /// </summary>
        [DataMember(Name="supplierAssignedId", EmitDefaultValue=false)]
        public string SupplierAssignedId { get; set; }

        /// <summary>
        /// Gets or Sets CustomerAssignedId
        /// </summary>
        [DataMember(Name="customerAssignedId", EmitDefaultValue=false)]
        public string CustomerAssignedId { get; set; }

        /// <summary>
        /// Gets or Sets IssueDate
        /// </summary>
        [DataMember(Name="issueDate", EmitDefaultValue=false)]
        public DateTime? IssueDate { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public float? Amount { get; set; }

        /// <summary>
        /// Gets or Sets Tax
        /// </summary>
        [DataMember(Name="tax", EmitDefaultValue=false)]
        public float? Tax { get; set; }

        /// <summary>
        /// Gets or Sets SupplierName
        /// </summary>
        [DataMember(Name="supplierName", EmitDefaultValue=false)]
        public string SupplierName { get; set; }

        /// <summary>
        /// Gets or Sets SupplierStreetAddress
        /// </summary>
        [DataMember(Name="supplierStreetAddress", EmitDefaultValue=false)]
        public string SupplierStreetAddress { get; set; }

        /// <summary>
        /// Gets or Sets SupplierCity
        /// </summary>
        [DataMember(Name="supplierCity", EmitDefaultValue=false)]
        public string SupplierCity { get; set; }

        /// <summary>
        /// Gets or Sets SupplierCountry
        /// </summary>
        [DataMember(Name="supplierCountry", EmitDefaultValue=false)]
        public string SupplierCountry { get; set; }

        /// <summary>
        /// Gets or Sets CustomerName
        /// </summary>
        [DataMember(Name="customerName", EmitDefaultValue=false)]
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or Sets CustomerStreetAddress
        /// </summary>
        [DataMember(Name="customerStreetAddress", EmitDefaultValue=false)]
        public string CustomerStreetAddress { get; set; }

        /// <summary>
        /// Gets or Sets CustomerCity
        /// </summary>
        [DataMember(Name="customerCity", EmitDefaultValue=false)]
        public string CustomerCity { get; set; }

        /// <summary>
        /// Gets or Sets CustomerCountry
        /// </summary>
        [DataMember(Name="customerCountry", EmitDefaultValue=false)]
        public string CustomerCountry { get; set; }

        /// <summary>
        /// Gets or Sets Viewed
        /// </summary>
        [DataMember(Name="viewed", EmitDefaultValue=false)]
        public bool? Viewed { get; set; }

        /// <summary>
        /// Gets or Sets Starred
        /// </summary>
        [DataMember(Name="starred", EmitDefaultValue=false)]
        public bool? Starred { get; set; }

        /// <summary>
        /// Gets or Sets _Checked
        /// </summary>
        [DataMember(Name="checked", EmitDefaultValue=false)]
        public bool? _Checked { get; set; }

        /// <summary>
        /// Gets or Sets Versions
        /// </summary>
        [DataMember(Name="versions", EmitDefaultValue=false)]
        public List<string> Versions { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updatedAt", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentAttributes {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AssignedId: ").Append(AssignedId).Append("\n");
            sb.Append("  SupplierAssignedId: ").Append(SupplierAssignedId).Append("\n");
            sb.Append("  CustomerAssignedId: ").Append(CustomerAssignedId).Append("\n");
            sb.Append("  IssueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  SupplierName: ").Append(SupplierName).Append("\n");
            sb.Append("  SupplierStreetAddress: ").Append(SupplierStreetAddress).Append("\n");
            sb.Append("  SupplierCity: ").Append(SupplierCity).Append("\n");
            sb.Append("  SupplierCountry: ").Append(SupplierCountry).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  CustomerStreetAddress: ").Append(CustomerStreetAddress).Append("\n");
            sb.Append("  CustomerCity: ").Append(CustomerCity).Append("\n");
            sb.Append("  CustomerCountry: ").Append(CustomerCountry).Append("\n");
            sb.Append("  Viewed: ").Append(Viewed).Append("\n");
            sb.Append("  Starred: ").Append(Starred).Append("\n");
            sb.Append("  _Checked: ").Append(_Checked).Append("\n");
            sb.Append("  Versions: ").Append(Versions).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as DocumentAttributes);
        }

        /// <summary>
        /// Returns true if DocumentAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.AssignedId == input.AssignedId ||
                    (this.AssignedId != null &&
                    this.AssignedId.Equals(input.AssignedId))
                ) && 
                (
                    this.SupplierAssignedId == input.SupplierAssignedId ||
                    (this.SupplierAssignedId != null &&
                    this.SupplierAssignedId.Equals(input.SupplierAssignedId))
                ) && 
                (
                    this.CustomerAssignedId == input.CustomerAssignedId ||
                    (this.CustomerAssignedId != null &&
                    this.CustomerAssignedId.Equals(input.CustomerAssignedId))
                ) && 
                (
                    this.IssueDate == input.IssueDate ||
                    (this.IssueDate != null &&
                    this.IssueDate.Equals(input.IssueDate))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Tax == input.Tax ||
                    (this.Tax != null &&
                    this.Tax.Equals(input.Tax))
                ) && 
                (
                    this.SupplierName == input.SupplierName ||
                    (this.SupplierName != null &&
                    this.SupplierName.Equals(input.SupplierName))
                ) && 
                (
                    this.SupplierStreetAddress == input.SupplierStreetAddress ||
                    (this.SupplierStreetAddress != null &&
                    this.SupplierStreetAddress.Equals(input.SupplierStreetAddress))
                ) && 
                (
                    this.SupplierCity == input.SupplierCity ||
                    (this.SupplierCity != null &&
                    this.SupplierCity.Equals(input.SupplierCity))
                ) && 
                (
                    this.SupplierCountry == input.SupplierCountry ||
                    (this.SupplierCountry != null &&
                    this.SupplierCountry.Equals(input.SupplierCountry))
                ) && 
                (
                    this.CustomerName == input.CustomerName ||
                    (this.CustomerName != null &&
                    this.CustomerName.Equals(input.CustomerName))
                ) && 
                (
                    this.CustomerStreetAddress == input.CustomerStreetAddress ||
                    (this.CustomerStreetAddress != null &&
                    this.CustomerStreetAddress.Equals(input.CustomerStreetAddress))
                ) && 
                (
                    this.CustomerCity == input.CustomerCity ||
                    (this.CustomerCity != null &&
                    this.CustomerCity.Equals(input.CustomerCity))
                ) && 
                (
                    this.CustomerCountry == input.CustomerCountry ||
                    (this.CustomerCountry != null &&
                    this.CustomerCountry.Equals(input.CustomerCountry))
                ) && 
                (
                    this.Viewed == input.Viewed ||
                    (this.Viewed != null &&
                    this.Viewed.Equals(input.Viewed))
                ) && 
                (
                    this.Starred == input.Starred ||
                    (this.Starred != null &&
                    this.Starred.Equals(input.Starred))
                ) && 
                (
                    this._Checked == input._Checked ||
                    (this._Checked != null &&
                    this._Checked.Equals(input._Checked))
                ) && 
                (
                    this.Versions == input.Versions ||
                    this.Versions != null &&
                    this.Versions.SequenceEqual(input.Versions)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.AssignedId != null)
                    hashCode = hashCode * 59 + this.AssignedId.GetHashCode();
                if (this.SupplierAssignedId != null)
                    hashCode = hashCode * 59 + this.SupplierAssignedId.GetHashCode();
                if (this.CustomerAssignedId != null)
                    hashCode = hashCode * 59 + this.CustomerAssignedId.GetHashCode();
                if (this.IssueDate != null)
                    hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Tax != null)
                    hashCode = hashCode * 59 + this.Tax.GetHashCode();
                if (this.SupplierName != null)
                    hashCode = hashCode * 59 + this.SupplierName.GetHashCode();
                if (this.SupplierStreetAddress != null)
                    hashCode = hashCode * 59 + this.SupplierStreetAddress.GetHashCode();
                if (this.SupplierCity != null)
                    hashCode = hashCode * 59 + this.SupplierCity.GetHashCode();
                if (this.SupplierCountry != null)
                    hashCode = hashCode * 59 + this.SupplierCountry.GetHashCode();
                if (this.CustomerName != null)
                    hashCode = hashCode * 59 + this.CustomerName.GetHashCode();
                if (this.CustomerStreetAddress != null)
                    hashCode = hashCode * 59 + this.CustomerStreetAddress.GetHashCode();
                if (this.CustomerCity != null)
                    hashCode = hashCode * 59 + this.CustomerCity.GetHashCode();
                if (this.CustomerCountry != null)
                    hashCode = hashCode * 59 + this.CustomerCountry.GetHashCode();
                if (this.Viewed != null)
                    hashCode = hashCode * 59 + this.Viewed.GetHashCode();
                if (this.Starred != null)
                    hashCode = hashCode * 59 + this.Starred.GetHashCode();
                if (this._Checked != null)
                    hashCode = hashCode * 59 + this._Checked.GetHashCode();
                if (this.Versions != null)
                    hashCode = hashCode * 59 + this.Versions.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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
