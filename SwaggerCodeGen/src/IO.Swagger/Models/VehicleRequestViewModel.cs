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
    public partial class VehicleRequestViewModel : IEquatable<VehicleRequestViewModel>
    { 
        /// <summary>
        /// Vehicle key in Titan system
        /// </summary>
        /// <value>Vehicle key in Titan system</value>

        [DataMember(Name="VehicleKey")]
        public int? VehicleKey { get; set; }

        /// <summary>
        /// Vehicle key in Third Party system
        /// </summary>
        /// <value>Vehicle key in Third Party system</value>

        [MaxLength(40)]
        [DataMember(Name="ExternalVehicleKey")]
        public string ExternalVehicleKey { get; set; }

        /// <summary>
        /// Code get from GET Makes API
        /// </summary>
        /// <value>Code get from GET Makes API</value>

        [DataMember(Name="MakeCode")]
        public int? MakeCode { get; set; }

        /// <summary>
        /// Gets or Sets Vin
        /// </summary>

        [MaxLength(17)]
        [DataMember(Name="Vin")]
        public string Vin { get; set; }

        /// <summary>
        /// Gets or Sets BootKey
        /// </summary>

        [MaxLength(10)]
        [DataMember(Name="BootKey")]
        public string BootKey { get; set; }

        /// <summary>
        /// Gets or Sets IgnitionKey
        /// </summary>

        [MaxLength(10)]
        [DataMember(Name="IgnitionKey")]
        public string IgnitionKey { get; set; }

        /// <summary>
        /// Code get from GET VehicleFuels API
        /// </summary>
        /// <value>Code get from GET VehicleFuels API</value>

        [DataMember(Name="FuelCode")]
        public int? FuelCode { get; set; }

        /// <summary>
        /// Gets or Sets RadioCode
        /// </summary>

        [MaxLength(40)]
        [DataMember(Name="RadioCode")]
        public string RadioCode { get; set; }

        /// <summary>
        /// Gets or Sets VehicleNote
        /// </summary>

        [MaxLength(600)]
        [DataMember(Name="VehicleNote")]
        public string VehicleNote { get; set; }

        /// <summary>
        /// Gets or Sets SellingDealerCode
        /// </summary>

        [MaxLength(40)]
        [DataMember(Name="SellingDealerCode")]
        public string SellingDealerCode { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationNo
        /// </summary>
        [Required]

        [StringLength(40, MinimumLength=1)]
        [DataMember(Name="RegistrationNo")]
        public string RegistrationNo { get; set; }

        /// <summary>
        /// Gets or Sets ComplianceNo
        /// </summary>

        [MaxLength(20)]
        [DataMember(Name="ComplianceNo")]
        public string ComplianceNo { get; set; }

        /// <summary>
        /// Gets or Sets VehicleEngine
        /// </summary>

        [MaxLength(128)]
        [DataMember(Name="VehicleEngine")]
        public string VehicleEngine { get; set; }

        /// <summary>
        /// Gets or Sets VehicleTransmission
        /// </summary>

        [MaxLength(128)]
        [DataMember(Name="VehicleTransmission")]
        public string VehicleTransmission { get; set; }

        /// <summary>
        /// Gets or Sets ComplianceDate
        /// </summary>

        [DataMember(Name="ComplianceDate")]
        public DateTime? ComplianceDate { get; set; }

        /// <summary>
        /// Code get from GET ModelPricingGuideCodes API
        /// </summary>
        /// <value>Code get from GET ModelPricingGuideCodes API</value>

        [DataMember(Name="ModelPricingGuideCode")]
        public string ModelPricingGuideCode { get; set; }

        /// <summary>
        /// Gets or Sets DriverKey
        /// </summary>

        [DataMember(Name="DriverKey")]
        public int? DriverKey { get; set; }

        /// <summary>
        /// Gets or Sets ExternalDriverKey
        /// </summary>

        [MaxLength(40)]
        [DataMember(Name="ExternalDriverKey")]
        public string ExternalDriverKey { get; set; }

        /// <summary>
        /// Gets or Sets FleetKey
        /// </summary>

        [DataMember(Name="FleetKey")]
        public int? FleetKey { get; set; }

        /// <summary>
        /// Gets or Sets ExternalFleetKey
        /// </summary>

        [MaxLength(40)]
        [DataMember(Name="ExternalFleetKey")]
        public string ExternalFleetKey { get; set; }

        /// <summary>
        /// Gets or Sets VehicleDescription
        /// </summary>

        [MaxLength(1000)]
        [DataMember(Name="VehicleDescription")]
        public string VehicleDescription { get; set; }

        /// <summary>
        /// Gets or Sets ModelDescription
        /// </summary>

        [MaxLength(1000)]
        [DataMember(Name="ModelDescription")]
        public string ModelDescription { get; set; }

        /// <summary>
        /// Gets or Sets VehicleColour
        /// </summary>

        [MaxLength(128)]
        [DataMember(Name="VehicleColour")]
        public string VehicleColour { get; set; }

        /// <summary>
        /// Gets or Sets InteriorColour
        /// </summary>

        [MaxLength(128)]
        [DataMember(Name="InteriorColour")]
        public string InteriorColour { get; set; }

        /// <summary>
        /// Gets or Sets EngineNumber
        /// </summary>

        [MaxLength(20)]
        [DataMember(Name="EngineNumber")]
        public string EngineNumber { get; set; }

        /// <summary>
        /// Gets or Sets BuildDate
        /// </summary>

        [DataMember(Name="BuildDate")]
        public DateTime? BuildDate { get; set; }

        /// <summary>
        /// Code get from GET BodyTypes API
        /// </summary>
        /// <value>Code get from GET BodyTypes API</value>

        [MaxLength(20)]
        [DataMember(Name="BodyType")]
        public string BodyType { get; set; }

        /// <summary>
        /// Code get from GET Models API
        /// </summary>
        /// <value>Code get from GET Models API</value>

        [DataMember(Name="ModelID")]
        public string ModelID { get; set; }

        /// <summary>
        /// Manufacturer reference for the vehicle
        /// </summary>
        /// <value>Manufacturer reference for the vehicle</value>

        [MaxLength(40)]
        [DataMember(Name="ManufacturerId")]
        public string ManufacturerId { get; set; }

        /// <summary>
        /// Gets or Sets ManufacturedDate
        /// </summary>

        [DataMember(Name="ManufacturedDate")]
        public DateTime? ManufacturedDate { get; set; }

        /// <summary>
        /// Name get from GET Bureaucracies API
        /// </summary>
        /// <value>Name get from GET Bureaucracies API</value>
        [Required]

        [StringLength(40, MinimumLength=1)]
        [DataMember(Name="RegistrationBureaucracy")]
        public string RegistrationBureaucracy { get; set; }

        /// <summary>
        /// Gets or Sets EngineCubicCapacity
        /// </summary>

        [DataMember(Name="EngineCubicCapacity")]
        public double? EngineCubicCapacity { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationExpiryDate
        /// </summary>

        [DataMember(Name="RegistrationExpiryDate")]
        public DateTime? RegistrationExpiryDate { get; set; }

        /// <summary>
        /// 1: Active, 2 Inactive  Default is 1
        /// </summary>
        /// <value>1: Active, 2 Inactive  Default is 1</value>

        [DataMember(Name="StatusCode")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Gets or Sets GlassNvic
        /// </summary>

        [DataMember(Name="GlassNvic")]
        public string GlassNvic { get; set; }

        /// <summary>
        /// Code get from GET Families API
        /// </summary>
        /// <value>Code get from GET Families API</value>

        [MaxLength(128)]
        [DataMember(Name="Family")]
        public string Family { get; set; }

        /// <summary>
        /// If VehiclePricingGuideConditionCodeSourceCode &#x3D; 1 (Redbook) &lt;br /&gt;  1: Poor, 2: Fair, 3: Average, 4: Good, 5: Very Good, 6: As New &lt;br /&gt;  If VehiclePricingGuideConditionCodeSourceCode &#x3D; 2 (Glassguide) &lt;br /&gt;  1: Below Average, 2: Average, 3: Above Average
        /// </summary>
        /// <value>If VehiclePricingGuideConditionCodeSourceCode &#x3D; 1 (Redbook) &lt;br /&gt;  1: Poor, 2: Fair, 3: Average, 4: Good, 5: Very Good, 6: As New &lt;br /&gt;  If VehiclePricingGuideConditionCodeSourceCode &#x3D; 2 (Glassguide) &lt;br /&gt;  1: Below Average, 2: Average, 3: Above Average</value>

        [Range(1, 6)]
        [DataMember(Name="VehiclePricingGuideConditionCode")]
        public int? VehiclePricingGuideConditionCode { get; set; }

        /// <summary>
        /// Code get from GET VehicleTypes API
        /// </summary>
        /// <value>Code get from GET VehicleTypes API</value>

        [DataMember(Name="VehicleType")]
        public int? VehicleType { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [Required]

        [DataMember(Name="Owner")]
        public ContactRequestViewModel Owner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VehicleRequestViewModel {\n");
            sb.Append("  VehicleKey: ").Append(VehicleKey).Append("\n");
            sb.Append("  ExternalVehicleKey: ").Append(ExternalVehicleKey).Append("\n");
            sb.Append("  MakeCode: ").Append(MakeCode).Append("\n");
            sb.Append("  Vin: ").Append(Vin).Append("\n");
            sb.Append("  BootKey: ").Append(BootKey).Append("\n");
            sb.Append("  IgnitionKey: ").Append(IgnitionKey).Append("\n");
            sb.Append("  FuelCode: ").Append(FuelCode).Append("\n");
            sb.Append("  RadioCode: ").Append(RadioCode).Append("\n");
            sb.Append("  VehicleNote: ").Append(VehicleNote).Append("\n");
            sb.Append("  SellingDealerCode: ").Append(SellingDealerCode).Append("\n");
            sb.Append("  RegistrationNo: ").Append(RegistrationNo).Append("\n");
            sb.Append("  ComplianceNo: ").Append(ComplianceNo).Append("\n");
            sb.Append("  VehicleEngine: ").Append(VehicleEngine).Append("\n");
            sb.Append("  VehicleTransmission: ").Append(VehicleTransmission).Append("\n");
            sb.Append("  ComplianceDate: ").Append(ComplianceDate).Append("\n");
            sb.Append("  ModelPricingGuideCode: ").Append(ModelPricingGuideCode).Append("\n");
            sb.Append("  DriverKey: ").Append(DriverKey).Append("\n");
            sb.Append("  ExternalDriverKey: ").Append(ExternalDriverKey).Append("\n");
            sb.Append("  FleetKey: ").Append(FleetKey).Append("\n");
            sb.Append("  ExternalFleetKey: ").Append(ExternalFleetKey).Append("\n");
            sb.Append("  VehicleDescription: ").Append(VehicleDescription).Append("\n");
            sb.Append("  ModelDescription: ").Append(ModelDescription).Append("\n");
            sb.Append("  VehicleColour: ").Append(VehicleColour).Append("\n");
            sb.Append("  InteriorColour: ").Append(InteriorColour).Append("\n");
            sb.Append("  EngineNumber: ").Append(EngineNumber).Append("\n");
            sb.Append("  BuildDate: ").Append(BuildDate).Append("\n");
            sb.Append("  BodyType: ").Append(BodyType).Append("\n");
            sb.Append("  ModelID: ").Append(ModelID).Append("\n");
            sb.Append("  ManufacturerId: ").Append(ManufacturerId).Append("\n");
            sb.Append("  ManufacturedDate: ").Append(ManufacturedDate).Append("\n");
            sb.Append("  RegistrationBureaucracy: ").Append(RegistrationBureaucracy).Append("\n");
            sb.Append("  EngineCubicCapacity: ").Append(EngineCubicCapacity).Append("\n");
            sb.Append("  RegistrationExpiryDate: ").Append(RegistrationExpiryDate).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  GlassNvic: ").Append(GlassNvic).Append("\n");
            sb.Append("  Family: ").Append(Family).Append("\n");
            sb.Append("  VehiclePricingGuideConditionCode: ").Append(VehiclePricingGuideConditionCode).Append("\n");
            sb.Append("  VehicleType: ").Append(VehicleType).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
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
            return obj.GetType() == GetType() && Equals((VehicleRequestViewModel)obj);
        }

        /// <summary>
        /// Returns true if VehicleRequestViewModel instances are equal
        /// </summary>
        /// <param name="other">Instance of VehicleRequestViewModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VehicleRequestViewModel other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    VehicleKey == other.VehicleKey ||
                    VehicleKey != null &&
                    VehicleKey.Equals(other.VehicleKey)
                ) && 
                (
                    ExternalVehicleKey == other.ExternalVehicleKey ||
                    ExternalVehicleKey != null &&
                    ExternalVehicleKey.Equals(other.ExternalVehicleKey)
                ) && 
                (
                    MakeCode == other.MakeCode ||
                    MakeCode != null &&
                    MakeCode.Equals(other.MakeCode)
                ) && 
                (
                    Vin == other.Vin ||
                    Vin != null &&
                    Vin.Equals(other.Vin)
                ) && 
                (
                    BootKey == other.BootKey ||
                    BootKey != null &&
                    BootKey.Equals(other.BootKey)
                ) && 
                (
                    IgnitionKey == other.IgnitionKey ||
                    IgnitionKey != null &&
                    IgnitionKey.Equals(other.IgnitionKey)
                ) && 
                (
                    FuelCode == other.FuelCode ||
                    FuelCode != null &&
                    FuelCode.Equals(other.FuelCode)
                ) && 
                (
                    RadioCode == other.RadioCode ||
                    RadioCode != null &&
                    RadioCode.Equals(other.RadioCode)
                ) && 
                (
                    VehicleNote == other.VehicleNote ||
                    VehicleNote != null &&
                    VehicleNote.Equals(other.VehicleNote)
                ) && 
                (
                    SellingDealerCode == other.SellingDealerCode ||
                    SellingDealerCode != null &&
                    SellingDealerCode.Equals(other.SellingDealerCode)
                ) && 
                (
                    RegistrationNo == other.RegistrationNo ||
                    RegistrationNo != null &&
                    RegistrationNo.Equals(other.RegistrationNo)
                ) && 
                (
                    ComplianceNo == other.ComplianceNo ||
                    ComplianceNo != null &&
                    ComplianceNo.Equals(other.ComplianceNo)
                ) && 
                (
                    VehicleEngine == other.VehicleEngine ||
                    VehicleEngine != null &&
                    VehicleEngine.Equals(other.VehicleEngine)
                ) && 
                (
                    VehicleTransmission == other.VehicleTransmission ||
                    VehicleTransmission != null &&
                    VehicleTransmission.Equals(other.VehicleTransmission)
                ) && 
                (
                    ComplianceDate == other.ComplianceDate ||
                    ComplianceDate != null &&
                    ComplianceDate.Equals(other.ComplianceDate)
                ) && 
                (
                    ModelPricingGuideCode == other.ModelPricingGuideCode ||
                    ModelPricingGuideCode != null &&
                    ModelPricingGuideCode.Equals(other.ModelPricingGuideCode)
                ) && 
                (
                    DriverKey == other.DriverKey ||
                    DriverKey != null &&
                    DriverKey.Equals(other.DriverKey)
                ) && 
                (
                    ExternalDriverKey == other.ExternalDriverKey ||
                    ExternalDriverKey != null &&
                    ExternalDriverKey.Equals(other.ExternalDriverKey)
                ) && 
                (
                    FleetKey == other.FleetKey ||
                    FleetKey != null &&
                    FleetKey.Equals(other.FleetKey)
                ) && 
                (
                    ExternalFleetKey == other.ExternalFleetKey ||
                    ExternalFleetKey != null &&
                    ExternalFleetKey.Equals(other.ExternalFleetKey)
                ) && 
                (
                    VehicleDescription == other.VehicleDescription ||
                    VehicleDescription != null &&
                    VehicleDescription.Equals(other.VehicleDescription)
                ) && 
                (
                    ModelDescription == other.ModelDescription ||
                    ModelDescription != null &&
                    ModelDescription.Equals(other.ModelDescription)
                ) && 
                (
                    VehicleColour == other.VehicleColour ||
                    VehicleColour != null &&
                    VehicleColour.Equals(other.VehicleColour)
                ) && 
                (
                    InteriorColour == other.InteriorColour ||
                    InteriorColour != null &&
                    InteriorColour.Equals(other.InteriorColour)
                ) && 
                (
                    EngineNumber == other.EngineNumber ||
                    EngineNumber != null &&
                    EngineNumber.Equals(other.EngineNumber)
                ) && 
                (
                    BuildDate == other.BuildDate ||
                    BuildDate != null &&
                    BuildDate.Equals(other.BuildDate)
                ) && 
                (
                    BodyType == other.BodyType ||
                    BodyType != null &&
                    BodyType.Equals(other.BodyType)
                ) && 
                (
                    ModelID == other.ModelID ||
                    ModelID != null &&
                    ModelID.Equals(other.ModelID)
                ) && 
                (
                    ManufacturerId == other.ManufacturerId ||
                    ManufacturerId != null &&
                    ManufacturerId.Equals(other.ManufacturerId)
                ) && 
                (
                    ManufacturedDate == other.ManufacturedDate ||
                    ManufacturedDate != null &&
                    ManufacturedDate.Equals(other.ManufacturedDate)
                ) && 
                (
                    RegistrationBureaucracy == other.RegistrationBureaucracy ||
                    RegistrationBureaucracy != null &&
                    RegistrationBureaucracy.Equals(other.RegistrationBureaucracy)
                ) && 
                (
                    EngineCubicCapacity == other.EngineCubicCapacity ||
                    EngineCubicCapacity != null &&
                    EngineCubicCapacity.Equals(other.EngineCubicCapacity)
                ) && 
                (
                    RegistrationExpiryDate == other.RegistrationExpiryDate ||
                    RegistrationExpiryDate != null &&
                    RegistrationExpiryDate.Equals(other.RegistrationExpiryDate)
                ) && 
                (
                    StatusCode == other.StatusCode ||
                    StatusCode != null &&
                    StatusCode.Equals(other.StatusCode)
                ) && 
                (
                    GlassNvic == other.GlassNvic ||
                    GlassNvic != null &&
                    GlassNvic.Equals(other.GlassNvic)
                ) && 
                (
                    Family == other.Family ||
                    Family != null &&
                    Family.Equals(other.Family)
                ) && 
                (
                    VehiclePricingGuideConditionCode == other.VehiclePricingGuideConditionCode ||
                    VehiclePricingGuideConditionCode != null &&
                    VehiclePricingGuideConditionCode.Equals(other.VehiclePricingGuideConditionCode)
                ) && 
                (
                    VehicleType == other.VehicleType ||
                    VehicleType != null &&
                    VehicleType.Equals(other.VehicleType)
                ) && 
                (
                    Owner == other.Owner ||
                    Owner != null &&
                    Owner.Equals(other.Owner)
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
                    if (VehicleKey != null)
                    hashCode = hashCode * 59 + VehicleKey.GetHashCode();
                    if (ExternalVehicleKey != null)
                    hashCode = hashCode * 59 + ExternalVehicleKey.GetHashCode();
                    if (MakeCode != null)
                    hashCode = hashCode * 59 + MakeCode.GetHashCode();
                    if (Vin != null)
                    hashCode = hashCode * 59 + Vin.GetHashCode();
                    if (BootKey != null)
                    hashCode = hashCode * 59 + BootKey.GetHashCode();
                    if (IgnitionKey != null)
                    hashCode = hashCode * 59 + IgnitionKey.GetHashCode();
                    if (FuelCode != null)
                    hashCode = hashCode * 59 + FuelCode.GetHashCode();
                    if (RadioCode != null)
                    hashCode = hashCode * 59 + RadioCode.GetHashCode();
                    if (VehicleNote != null)
                    hashCode = hashCode * 59 + VehicleNote.GetHashCode();
                    if (SellingDealerCode != null)
                    hashCode = hashCode * 59 + SellingDealerCode.GetHashCode();
                    if (RegistrationNo != null)
                    hashCode = hashCode * 59 + RegistrationNo.GetHashCode();
                    if (ComplianceNo != null)
                    hashCode = hashCode * 59 + ComplianceNo.GetHashCode();
                    if (VehicleEngine != null)
                    hashCode = hashCode * 59 + VehicleEngine.GetHashCode();
                    if (VehicleTransmission != null)
                    hashCode = hashCode * 59 + VehicleTransmission.GetHashCode();
                    if (ComplianceDate != null)
                    hashCode = hashCode * 59 + ComplianceDate.GetHashCode();
                    if (ModelPricingGuideCode != null)
                    hashCode = hashCode * 59 + ModelPricingGuideCode.GetHashCode();
                    if (DriverKey != null)
                    hashCode = hashCode * 59 + DriverKey.GetHashCode();
                    if (ExternalDriverKey != null)
                    hashCode = hashCode * 59 + ExternalDriverKey.GetHashCode();
                    if (FleetKey != null)
                    hashCode = hashCode * 59 + FleetKey.GetHashCode();
                    if (ExternalFleetKey != null)
                    hashCode = hashCode * 59 + ExternalFleetKey.GetHashCode();
                    if (VehicleDescription != null)
                    hashCode = hashCode * 59 + VehicleDescription.GetHashCode();
                    if (ModelDescription != null)
                    hashCode = hashCode * 59 + ModelDescription.GetHashCode();
                    if (VehicleColour != null)
                    hashCode = hashCode * 59 + VehicleColour.GetHashCode();
                    if (InteriorColour != null)
                    hashCode = hashCode * 59 + InteriorColour.GetHashCode();
                    if (EngineNumber != null)
                    hashCode = hashCode * 59 + EngineNumber.GetHashCode();
                    if (BuildDate != null)
                    hashCode = hashCode * 59 + BuildDate.GetHashCode();
                    if (BodyType != null)
                    hashCode = hashCode * 59 + BodyType.GetHashCode();
                    if (ModelID != null)
                    hashCode = hashCode * 59 + ModelID.GetHashCode();
                    if (ManufacturerId != null)
                    hashCode = hashCode * 59 + ManufacturerId.GetHashCode();
                    if (ManufacturedDate != null)
                    hashCode = hashCode * 59 + ManufacturedDate.GetHashCode();
                    if (RegistrationBureaucracy != null)
                    hashCode = hashCode * 59 + RegistrationBureaucracy.GetHashCode();
                    if (EngineCubicCapacity != null)
                    hashCode = hashCode * 59 + EngineCubicCapacity.GetHashCode();
                    if (RegistrationExpiryDate != null)
                    hashCode = hashCode * 59 + RegistrationExpiryDate.GetHashCode();
                    if (StatusCode != null)
                    hashCode = hashCode * 59 + StatusCode.GetHashCode();
                    if (GlassNvic != null)
                    hashCode = hashCode * 59 + GlassNvic.GetHashCode();
                    if (Family != null)
                    hashCode = hashCode * 59 + Family.GetHashCode();
                    if (VehiclePricingGuideConditionCode != null)
                    hashCode = hashCode * 59 + VehiclePricingGuideConditionCode.GetHashCode();
                    if (VehicleType != null)
                    hashCode = hashCode * 59 + VehicleType.GetHashCode();
                    if (Owner != null)
                    hashCode = hashCode * 59 + Owner.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(VehicleRequestViewModel left, VehicleRequestViewModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(VehicleRequestViewModel left, VehicleRequestViewModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
