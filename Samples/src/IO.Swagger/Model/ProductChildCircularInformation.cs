/* 
 * Madaster Private API
 *
 * The Madaster Private API endpoint.
 *
 * OpenAPI spec version: 1.1
 * Contact: service@madaster.com
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
    /// Circular information about a product child
    /// </summary>
    [DataContract]
    public partial class ProductChildCircularInformation :  IEquatable<ProductChildCircularInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductChildCircularInformation" /> class.
        /// </summary>
        /// <param name="inheritFeedstockPercentages">Whether the feedstock percentages should be inherited from the child.</param>
        /// <param name="recycledPercentageFeedstock">The percentage of the material&#39;s feedstock that comes from recycled sources.</param>
        /// <param name="rapidRenewablesPercentageFeedstock">The percentage of the material&#39;s feedstock that comes from rapidly renewable sources.</param>
        /// <param name="inheritEndOfLifePercentages">Whether the end of life percentages should be inherited from the child.</param>
        /// <param name="recycledPercentageEndOfLife">The percentage of the material that can be recycled at its end of life.</param>
        /// <param name="landfillPercentageEndOfLife">The percentage of the material that will go to the landfill at its end of life.</param>
        /// <param name="inheritEfficiencyPercentages">Whether the efficiency percentages should be inherited from the child.</param>
        /// <param name="efficiencyPercentageRecyclingFeedstock">The efficiency of the recycling process that led to the feedstock.</param>
        /// <param name="efficiencyPercentageRecyclingEndOfLife">The efficiency of the recycling process when the material reaches its end of life.</param>
        public ProductChildCircularInformation(bool? inheritFeedstockPercentages = default(bool?), double? recycledPercentageFeedstock = default(double?), double? rapidRenewablesPercentageFeedstock = default(double?), bool? inheritEndOfLifePercentages = default(bool?), double? recycledPercentageEndOfLife = default(double?), double? landfillPercentageEndOfLife = default(double?), bool? inheritEfficiencyPercentages = default(bool?), double? efficiencyPercentageRecyclingFeedstock = default(double?), double? efficiencyPercentageRecyclingEndOfLife = default(double?))
        {
            this.InheritFeedstockPercentages = inheritFeedstockPercentages;
            this.RecycledPercentageFeedstock = recycledPercentageFeedstock;
            this.RapidRenewablesPercentageFeedstock = rapidRenewablesPercentageFeedstock;
            this.InheritEndOfLifePercentages = inheritEndOfLifePercentages;
            this.RecycledPercentageEndOfLife = recycledPercentageEndOfLife;
            this.LandfillPercentageEndOfLife = landfillPercentageEndOfLife;
            this.InheritEfficiencyPercentages = inheritEfficiencyPercentages;
            this.EfficiencyPercentageRecyclingFeedstock = efficiencyPercentageRecyclingFeedstock;
            this.EfficiencyPercentageRecyclingEndOfLife = efficiencyPercentageRecyclingEndOfLife;
        }
        
        /// <summary>
        /// Whether the feedstock percentages should be inherited from the child
        /// </summary>
        /// <value>Whether the feedstock percentages should be inherited from the child</value>
        [DataMember(Name="inheritFeedstockPercentages", EmitDefaultValue=false)]
        public bool? InheritFeedstockPercentages { get; set; }

        /// <summary>
        /// The percentage of the material&#39;s feedstock that comes from recycled sources
        /// </summary>
        /// <value>The percentage of the material&#39;s feedstock that comes from recycled sources</value>
        [DataMember(Name="recycledPercentageFeedstock", EmitDefaultValue=false)]
        public double? RecycledPercentageFeedstock { get; set; }

        /// <summary>
        /// The percentage of the material&#39;s feedstock that comes from rapidly renewable sources
        /// </summary>
        /// <value>The percentage of the material&#39;s feedstock that comes from rapidly renewable sources</value>
        [DataMember(Name="rapidRenewablesPercentageFeedstock", EmitDefaultValue=false)]
        public double? RapidRenewablesPercentageFeedstock { get; set; }

        /// <summary>
        /// Whether the end of life percentages should be inherited from the child
        /// </summary>
        /// <value>Whether the end of life percentages should be inherited from the child</value>
        [DataMember(Name="inheritEndOfLifePercentages", EmitDefaultValue=false)]
        public bool? InheritEndOfLifePercentages { get; set; }

        /// <summary>
        /// The percentage of the material that can be recycled at its end of life
        /// </summary>
        /// <value>The percentage of the material that can be recycled at its end of life</value>
        [DataMember(Name="recycledPercentageEndOfLife", EmitDefaultValue=false)]
        public double? RecycledPercentageEndOfLife { get; set; }

        /// <summary>
        /// The percentage of the material that will go to the landfill at its end of life
        /// </summary>
        /// <value>The percentage of the material that will go to the landfill at its end of life</value>
        [DataMember(Name="landfillPercentageEndOfLife", EmitDefaultValue=false)]
        public double? LandfillPercentageEndOfLife { get; set; }

        /// <summary>
        /// Whether the efficiency percentages should be inherited from the child
        /// </summary>
        /// <value>Whether the efficiency percentages should be inherited from the child</value>
        [DataMember(Name="inheritEfficiencyPercentages", EmitDefaultValue=false)]
        public bool? InheritEfficiencyPercentages { get; set; }

        /// <summary>
        /// The efficiency of the recycling process that led to the feedstock
        /// </summary>
        /// <value>The efficiency of the recycling process that led to the feedstock</value>
        [DataMember(Name="efficiencyPercentageRecyclingFeedstock", EmitDefaultValue=false)]
        public double? EfficiencyPercentageRecyclingFeedstock { get; set; }

        /// <summary>
        /// The efficiency of the recycling process when the material reaches its end of life
        /// </summary>
        /// <value>The efficiency of the recycling process when the material reaches its end of life</value>
        [DataMember(Name="efficiencyPercentageRecyclingEndOfLife", EmitDefaultValue=false)]
        public double? EfficiencyPercentageRecyclingEndOfLife { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductChildCircularInformation {\n");
            sb.Append("  InheritFeedstockPercentages: ").Append(InheritFeedstockPercentages).Append("\n");
            sb.Append("  RecycledPercentageFeedstock: ").Append(RecycledPercentageFeedstock).Append("\n");
            sb.Append("  RapidRenewablesPercentageFeedstock: ").Append(RapidRenewablesPercentageFeedstock).Append("\n");
            sb.Append("  InheritEndOfLifePercentages: ").Append(InheritEndOfLifePercentages).Append("\n");
            sb.Append("  RecycledPercentageEndOfLife: ").Append(RecycledPercentageEndOfLife).Append("\n");
            sb.Append("  LandfillPercentageEndOfLife: ").Append(LandfillPercentageEndOfLife).Append("\n");
            sb.Append("  InheritEfficiencyPercentages: ").Append(InheritEfficiencyPercentages).Append("\n");
            sb.Append("  EfficiencyPercentageRecyclingFeedstock: ").Append(EfficiencyPercentageRecyclingFeedstock).Append("\n");
            sb.Append("  EfficiencyPercentageRecyclingEndOfLife: ").Append(EfficiencyPercentageRecyclingEndOfLife).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as ProductChildCircularInformation);
        }

        /// <summary>
        /// Returns true if ProductChildCircularInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductChildCircularInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductChildCircularInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InheritFeedstockPercentages == input.InheritFeedstockPercentages ||
                    (this.InheritFeedstockPercentages != null &&
                    this.InheritFeedstockPercentages.Equals(input.InheritFeedstockPercentages))
                ) && 
                (
                    this.RecycledPercentageFeedstock == input.RecycledPercentageFeedstock ||
                    (this.RecycledPercentageFeedstock != null &&
                    this.RecycledPercentageFeedstock.Equals(input.RecycledPercentageFeedstock))
                ) && 
                (
                    this.RapidRenewablesPercentageFeedstock == input.RapidRenewablesPercentageFeedstock ||
                    (this.RapidRenewablesPercentageFeedstock != null &&
                    this.RapidRenewablesPercentageFeedstock.Equals(input.RapidRenewablesPercentageFeedstock))
                ) && 
                (
                    this.InheritEndOfLifePercentages == input.InheritEndOfLifePercentages ||
                    (this.InheritEndOfLifePercentages != null &&
                    this.InheritEndOfLifePercentages.Equals(input.InheritEndOfLifePercentages))
                ) && 
                (
                    this.RecycledPercentageEndOfLife == input.RecycledPercentageEndOfLife ||
                    (this.RecycledPercentageEndOfLife != null &&
                    this.RecycledPercentageEndOfLife.Equals(input.RecycledPercentageEndOfLife))
                ) && 
                (
                    this.LandfillPercentageEndOfLife == input.LandfillPercentageEndOfLife ||
                    (this.LandfillPercentageEndOfLife != null &&
                    this.LandfillPercentageEndOfLife.Equals(input.LandfillPercentageEndOfLife))
                ) && 
                (
                    this.InheritEfficiencyPercentages == input.InheritEfficiencyPercentages ||
                    (this.InheritEfficiencyPercentages != null &&
                    this.InheritEfficiencyPercentages.Equals(input.InheritEfficiencyPercentages))
                ) && 
                (
                    this.EfficiencyPercentageRecyclingFeedstock == input.EfficiencyPercentageRecyclingFeedstock ||
                    (this.EfficiencyPercentageRecyclingFeedstock != null &&
                    this.EfficiencyPercentageRecyclingFeedstock.Equals(input.EfficiencyPercentageRecyclingFeedstock))
                ) && 
                (
                    this.EfficiencyPercentageRecyclingEndOfLife == input.EfficiencyPercentageRecyclingEndOfLife ||
                    (this.EfficiencyPercentageRecyclingEndOfLife != null &&
                    this.EfficiencyPercentageRecyclingEndOfLife.Equals(input.EfficiencyPercentageRecyclingEndOfLife))
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
                if (this.InheritFeedstockPercentages != null)
                    hashCode = hashCode * 59 + this.InheritFeedstockPercentages.GetHashCode();
                if (this.RecycledPercentageFeedstock != null)
                    hashCode = hashCode * 59 + this.RecycledPercentageFeedstock.GetHashCode();
                if (this.RapidRenewablesPercentageFeedstock != null)
                    hashCode = hashCode * 59 + this.RapidRenewablesPercentageFeedstock.GetHashCode();
                if (this.InheritEndOfLifePercentages != null)
                    hashCode = hashCode * 59 + this.InheritEndOfLifePercentages.GetHashCode();
                if (this.RecycledPercentageEndOfLife != null)
                    hashCode = hashCode * 59 + this.RecycledPercentageEndOfLife.GetHashCode();
                if (this.LandfillPercentageEndOfLife != null)
                    hashCode = hashCode * 59 + this.LandfillPercentageEndOfLife.GetHashCode();
                if (this.InheritEfficiencyPercentages != null)
                    hashCode = hashCode * 59 + this.InheritEfficiencyPercentages.GetHashCode();
                if (this.EfficiencyPercentageRecyclingFeedstock != null)
                    hashCode = hashCode * 59 + this.EfficiencyPercentageRecyclingFeedstock.GetHashCode();
                if (this.EfficiencyPercentageRecyclingEndOfLife != null)
                    hashCode = hashCode * 59 + this.EfficiencyPercentageRecyclingEndOfLife.GetHashCode();
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