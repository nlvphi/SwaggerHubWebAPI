/*
 * Appraisal Api
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ContactRequestViewModel : IEquatable<ContactRequestViewModel>
    { 
        /// <summary>
        /// Contact key in Titan system
        /// </summary>
        /// <value>Contact key in Titan system</value>

        [DataMember(Name="TradingEntityKey")]
        public int? TradingEntityKey { get; set; }

        /// <summary>
        /// Contact key in Third Party system
        /// </summary>
        /// <value>Contact key in Third Party system</value>

        [MaxLength(255)]
        [DataMember(Name="ExternalTradingEntityKey")]
        public string ExternalTradingEntityKey { get; set; }

        /// <summary>
        /// Gets or Sets WorkEmail
        /// </summary>

        [MaxLength(255)]
        [DataMember(Name="WorkEmail")]
        public string WorkEmail { get; set; }

        /// <summary>
        /// Gets or Sets Abn
        /// </summary>

        [MaxLength(40)]
        [DataMember(Name="Abn")]
        public string Abn { get; set; }

        /// <summary>
        /// Gets or Sets Acn
        /// </summary>

        [MaxLength(40)]
        [DataMember(Name="Acn")]
        public string Acn { get; set; }

        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>

        [MaxLength(128)]
        [DataMember(Name="CompanyName")]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>

        [MaxLength(80)]
        [DataMember(Name="FirstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets MiddleName
        /// </summary>

        [MaxLength(40)]
        [DataMember(Name="MiddleName")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>

        [MaxLength(40)]
        [DataMember(Name="LastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets HomePhone
        /// </summary>

        [MaxLength(30)]
        [DataMember(Name="HomePhone")]
        public string HomePhone { get; set; }

        /// <summary>
        /// Gets or Sets Mobile
        /// </summary>

        [MaxLength(30)]
        [DataMember(Name="Mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// Gets or Sets Fax
        /// </summary>

        [MaxLength(30)]
        [DataMember(Name="Fax")]
        public string Fax { get; set; }

        /// <summary>
        /// Gets or Sets WorkPhone
        /// </summary>

        [MaxLength(30)]
        [DataMember(Name="WorkPhone")]
        public string WorkPhone { get; set; }

        /// <summary>
        /// Gets or Sets PostalAddress
        /// </summary>

        [DataMember(Name="PostalAddress")]
        public AddressViewModel PostalAddress { get; set; }

        /// <summary>
        /// Gets or Sets StreetAddress
        /// </summary>

        [DataMember(Name="StreetAddress")]
        public AddressViewModel StreetAddress { get; set; }

        /// <summary>
        /// Gets or Sets PrivateEmail
        /// </summary>

        [MaxLength(255)]
        [DataMember(Name="PrivateEmail")]
        public string PrivateEmail { get; set; }

        /// <summary>
        /// 1: Male, 2: Female, 3: Other, 4: Unknown
        /// </summary>
        /// <value>1: Male, 2: Female, 3: Other, 4: Unknown</value>

        [Range(1, 4)]
        [DataMember(Name="Gender")]
        public int? Gender { get; set; }

        /// <summary>
        /// Code get from GET ContactTitles API
        /// </summary>
        /// <value>Code get from GET ContactTitles API</value>

        [DataMember(Name="Title")]
        public int? Title { get; set; }

        /// <summary>
        /// Gets or Sets BirthDate
        /// </summary>

        [DataMember(Name="BirthDate")]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Code get from GET TaxTypes API
        /// </summary>
        /// <value>Code get from GET TaxTypes API</value>

        [DataMember(Name="TaxType")]
        public int? TaxType { get; set; }

        /// <summary>
        /// Code get from GET OrganisationTypes API
        /// </summary>
        /// <value>Code get from GET OrganisationTypes API</value>

        [DataMember(Name="OrganisationType")]
        public int? OrganisationType { get; set; }

        /// <summary>
        /// Code get from GET Privacies API
        /// </summary>
        /// <value>Code get from GET Privacies API</value>

        [DataMember(Name="Privacy")]
        public int? Privacy { get; set; }

        /// <summary>
        /// Gets or Sets Occupation
        /// </summary>

        [MaxLength(128)]
        [DataMember(Name="Occupation")]
        public string Occupation { get; set; }

        /// <summary>
        /// Gets or Sets DriverLicence
        /// </summary>

        [MaxLength(18)]
        [DataMember(Name="DriverLicence")]
        public string DriverLicence { get; set; }

        /// <summary>
        /// Gets or Sets DriverLicenceExpiryDate
        /// </summary>

        [DataMember(Name="DriverLicenceExpiryDate")]
        public DateTime? DriverLicenceExpiryDate { get; set; }

        /// <summary>
        /// Gets or Sets PreferredContactMethod
        /// </summary>

        [DataMember(Name="PreferredContactMethod")]
        public int? PreferredContactMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactRequestViewModel {\n");
            sb.Append("  TradingEntityKey: ").Append(TradingEntityKey).Append("\n");
            sb.Append("  ExternalTradingEntityKey: ").Append(ExternalTradingEntityKey).Append("\n");
            sb.Append("  WorkEmail: ").Append(WorkEmail).Append("\n");
            sb.Append("  Abn: ").Append(Abn).Append("\n");
            sb.Append("  Acn: ").Append(Acn).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  HomePhone: ").Append(HomePhone).Append("\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  WorkPhone: ").Append(WorkPhone).Append("\n");
            sb.Append("  PostalAddress: ").Append(PostalAddress).Append("\n");
            sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
            sb.Append("  PrivateEmail: ").Append(PrivateEmail).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  TaxType: ").Append(TaxType).Append("\n");
            sb.Append("  OrganisationType: ").Append(OrganisationType).Append("\n");
            sb.Append("  Privacy: ").Append(Privacy).Append("\n");
            sb.Append("  Occupation: ").Append(Occupation).Append("\n");
            sb.Append("  DriverLicence: ").Append(DriverLicence).Append("\n");
            sb.Append("  DriverLicenceExpiryDate: ").Append(DriverLicenceExpiryDate).Append("\n");
            sb.Append("  PreferredContactMethod: ").Append(PreferredContactMethod).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ContactRequestViewModel)obj);
        }

        /// <summary>
        /// Returns true if ContactRequestViewModel instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactRequestViewModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactRequestViewModel other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TradingEntityKey == other.TradingEntityKey ||
                    TradingEntityKey != null &&
                    TradingEntityKey.Equals(other.TradingEntityKey)
                ) && 
                (
                    ExternalTradingEntityKey == other.ExternalTradingEntityKey ||
                    ExternalTradingEntityKey != null &&
                    ExternalTradingEntityKey.Equals(other.ExternalTradingEntityKey)
                ) && 
                (
                    WorkEmail == other.WorkEmail ||
                    WorkEmail != null &&
                    WorkEmail.Equals(other.WorkEmail)
                ) && 
                (
                    Abn == other.Abn ||
                    Abn != null &&
                    Abn.Equals(other.Abn)
                ) && 
                (
                    Acn == other.Acn ||
                    Acn != null &&
                    Acn.Equals(other.Acn)
                ) && 
                (
                    CompanyName == other.CompanyName ||
                    CompanyName != null &&
                    CompanyName.Equals(other.CompanyName)
                ) && 
                (
                    FirstName == other.FirstName ||
                    FirstName != null &&
                    FirstName.Equals(other.FirstName)
                ) && 
                (
                    MiddleName == other.MiddleName ||
                    MiddleName != null &&
                    MiddleName.Equals(other.MiddleName)
                ) && 
                (
                    LastName == other.LastName ||
                    LastName != null &&
                    LastName.Equals(other.LastName)
                ) && 
                (
                    HomePhone == other.HomePhone ||
                    HomePhone != null &&
                    HomePhone.Equals(other.HomePhone)
                ) && 
                (
                    Mobile == other.Mobile ||
                    Mobile != null &&
                    Mobile.Equals(other.Mobile)
                ) && 
                (
                    Fax == other.Fax ||
                    Fax != null &&
                    Fax.Equals(other.Fax)
                ) && 
                (
                    WorkPhone == other.WorkPhone ||
                    WorkPhone != null &&
                    WorkPhone.Equals(other.WorkPhone)
                ) && 
                (
                    PostalAddress == other.PostalAddress ||
                    PostalAddress != null &&
                    PostalAddress.Equals(other.PostalAddress)
                ) && 
                (
                    StreetAddress == other.StreetAddress ||
                    StreetAddress != null &&
                    StreetAddress.Equals(other.StreetAddress)
                ) && 
                (
                    PrivateEmail == other.PrivateEmail ||
                    PrivateEmail != null &&
                    PrivateEmail.Equals(other.PrivateEmail)
                ) && 
                (
                    Gender == other.Gender ||
                    Gender != null &&
                    Gender.Equals(other.Gender)
                ) && 
                (
                    Title == other.Title ||
                    Title != null &&
                    Title.Equals(other.Title)
                ) && 
                (
                    BirthDate == other.BirthDate ||
                    BirthDate != null &&
                    BirthDate.Equals(other.BirthDate)
                ) && 
                (
                    TaxType == other.TaxType ||
                    TaxType != null &&
                    TaxType.Equals(other.TaxType)
                ) && 
                (
                    OrganisationType == other.OrganisationType ||
                    OrganisationType != null &&
                    OrganisationType.Equals(other.OrganisationType)
                ) && 
                (
                    Privacy == other.Privacy ||
                    Privacy != null &&
                    Privacy.Equals(other.Privacy)
                ) && 
                (
                    Occupation == other.Occupation ||
                    Occupation != null &&
                    Occupation.Equals(other.Occupation)
                ) && 
                (
                    DriverLicence == other.DriverLicence ||
                    DriverLicence != null &&
                    DriverLicence.Equals(other.DriverLicence)
                ) && 
                (
                    DriverLicenceExpiryDate == other.DriverLicenceExpiryDate ||
                    DriverLicenceExpiryDate != null &&
                    DriverLicenceExpiryDate.Equals(other.DriverLicenceExpiryDate)
                ) && 
                (
                    PreferredContactMethod == other.PreferredContactMethod ||
                    PreferredContactMethod != null &&
                    PreferredContactMethod.Equals(other.PreferredContactMethod)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (TradingEntityKey != null)
                    hashCode = hashCode * 59 + TradingEntityKey.GetHashCode();
                    if (ExternalTradingEntityKey != null)
                    hashCode = hashCode * 59 + ExternalTradingEntityKey.GetHashCode();
                    if (WorkEmail != null)
                    hashCode = hashCode * 59 + WorkEmail.GetHashCode();
                    if (Abn != null)
                    hashCode = hashCode * 59 + Abn.GetHashCode();
                    if (Acn != null)
                    hashCode = hashCode * 59 + Acn.GetHashCode();
                    if (CompanyName != null)
                    hashCode = hashCode * 59 + CompanyName.GetHashCode();
                    if (FirstName != null)
                    hashCode = hashCode * 59 + FirstName.GetHashCode();
                    if (MiddleName != null)
                    hashCode = hashCode * 59 + MiddleName.GetHashCode();
                    if (LastName != null)
                    hashCode = hashCode * 59 + LastName.GetHashCode();
                    if (HomePhone != null)
                    hashCode = hashCode * 59 + HomePhone.GetHashCode();
                    if (Mobile != null)
                    hashCode = hashCode * 59 + Mobile.GetHashCode();
                    if (Fax != null)
                    hashCode = hashCode * 59 + Fax.GetHashCode();
                    if (WorkPhone != null)
                    hashCode = hashCode * 59 + WorkPhone.GetHashCode();
                    if (PostalAddress != null)
                    hashCode = hashCode * 59 + PostalAddress.GetHashCode();
                    if (StreetAddress != null)
                    hashCode = hashCode * 59 + StreetAddress.GetHashCode();
                    if (PrivateEmail != null)
                    hashCode = hashCode * 59 + PrivateEmail.GetHashCode();
                    if (Gender != null)
                    hashCode = hashCode * 59 + Gender.GetHashCode();
                    if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                    if (BirthDate != null)
                    hashCode = hashCode * 59 + BirthDate.GetHashCode();
                    if (TaxType != null)
                    hashCode = hashCode * 59 + TaxType.GetHashCode();
                    if (OrganisationType != null)
                    hashCode = hashCode * 59 + OrganisationType.GetHashCode();
                    if (Privacy != null)
                    hashCode = hashCode * 59 + Privacy.GetHashCode();
                    if (Occupation != null)
                    hashCode = hashCode * 59 + Occupation.GetHashCode();
                    if (DriverLicence != null)
                    hashCode = hashCode * 59 + DriverLicence.GetHashCode();
                    if (DriverLicenceExpiryDate != null)
                    hashCode = hashCode * 59 + DriverLicenceExpiryDate.GetHashCode();
                    if (PreferredContactMethod != null)
                    hashCode = hashCode * 59 + PreferredContactMethod.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ContactRequestViewModel left, ContactRequestViewModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ContactRequestViewModel left, ContactRequestViewModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
