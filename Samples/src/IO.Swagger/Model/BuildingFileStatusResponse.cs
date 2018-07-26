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
    /// BuildingFileStatusResponse
    /// </summary>
    [DataContract]
    public partial class BuildingFileStatusResponse :  IEquatable<BuildingFileStatusResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            
            NUMBER_0 = 0,
            
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            
            NUMBER_1 = 1,
            
            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            
            NUMBER_2 = 2,
            
            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            
            NUMBER_3 = 3,
            
            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            
            NUMBER_4 = 4,
            
            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            
            NUMBER_5 = 5,
            
            /// <summary>
            /// Enum NUMBER_6 for value: 6
            /// </summary>
            
            NUMBER_6 = 6,
            
            /// <summary>
            /// Enum NUMBER_7 for value: 7
            /// </summary>
            
            NUMBER_7 = 7,
            
            /// <summary>
            /// Enum NUMBER_8 for value: 8
            /// </summary>
            
            NUMBER_8 = 8,
            
            /// <summary>
            /// Enum NUMBER_99 for value: 99
            /// </summary>
            
            NUMBER_99 = 99
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingFileStatusResponse" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="elementProcessedCount">elementProcessedCount.</param>
        /// <param name="elementCount">elementCount.</param>
        /// <param name="statusMessage">statusMessage.</param>
        /// <param name="id">id.</param>
        public BuildingFileStatusResponse(StatusEnum? status = default(StatusEnum?), int? elementProcessedCount = default(int?), int? elementCount = default(int?), string statusMessage = default(string), Guid? id = default(Guid?))
        {
            this.Status = status;
            this.ElementProcessedCount = elementProcessedCount;
            this.ElementCount = elementCount;
            this.StatusMessage = statusMessage;
            this.Id = id;
        }
        

        /// <summary>
        /// Gets or Sets ElementProcessedCount
        /// </summary>
        [DataMember(Name="elementProcessedCount", EmitDefaultValue=false)]
        public int? ElementProcessedCount { get; set; }

        /// <summary>
        /// Gets or Sets ElementCount
        /// </summary>
        [DataMember(Name="elementCount", EmitDefaultValue=false)]
        public int? ElementCount { get; set; }

        /// <summary>
        /// Gets or Sets StatusMessage
        /// </summary>
        [DataMember(Name="statusMessage", EmitDefaultValue=false)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuildingFileStatusResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ElementProcessedCount: ").Append(ElementProcessedCount).Append("\n");
            sb.Append("  ElementCount: ").Append(ElementCount).Append("\n");
            sb.Append("  StatusMessage: ").Append(StatusMessage).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as BuildingFileStatusResponse);
        }

        /// <summary>
        /// Returns true if BuildingFileStatusResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BuildingFileStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildingFileStatusResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ElementProcessedCount == input.ElementProcessedCount ||
                    (this.ElementProcessedCount != null &&
                    this.ElementProcessedCount.Equals(input.ElementProcessedCount))
                ) && 
                (
                    this.ElementCount == input.ElementCount ||
                    (this.ElementCount != null &&
                    this.ElementCount.Equals(input.ElementCount))
                ) && 
                (
                    this.StatusMessage == input.StatusMessage ||
                    (this.StatusMessage != null &&
                    this.StatusMessage.Equals(input.StatusMessage))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ElementProcessedCount != null)
                    hashCode = hashCode * 59 + this.ElementProcessedCount.GetHashCode();
                if (this.ElementCount != null)
                    hashCode = hashCode * 59 + this.ElementCount.GetHashCode();
                if (this.StatusMessage != null)
                    hashCode = hashCode * 59 + this.StatusMessage.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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