/**
 * *************************************************
 * Copyright (c) 2019, Grindrod Bank Limited
 * License MIT: https://opensource.org/licenses/MIT
 * **************************************************
 */
/*
 * A3S
 *
 * API Definition for the A3S. This service allows authentication, authorisation and accounting.
 *
 * The version of the OpenAPI document: 1.0.2
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using za.co.grindrodbank.a3s.Converters;

namespace za.co.grindrodbank.a3s.A3SApiResources
{ 
    /// <summary>
    /// Model used to create or update a Role. 
    /// </summary>
    [DataContract]
    public partial class RoleSubmit : IEquatable<RoleSubmit>
    { 
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [Required]
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [Required]
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public Guid Uuid { get; set; }

        /// <summary>
        /// The UUIDs of the child roles attached to the role.
        /// </summary>
        /// <value>The UUIDs of the child roles attached to the role.</value>
        [DataMember(Name="roleIds", EmitDefaultValue=false)]
        public List<Guid> RoleIds { get; set; }

        /// <summary>
        /// Gets or Sets FunctionIds
        /// </summary>
        [DataMember(Name="functionIds", EmitDefaultValue=false)]
        public List<Guid> FunctionIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleSubmit {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  RoleIds: ").Append(RoleIds).Append("\n");
            sb.Append("  FunctionIds: ").Append(FunctionIds).Append("\n");
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((RoleSubmit)obj);
        }

        /// <summary>
        /// Returns true if RoleSubmit instances are equal
        /// </summary>
        /// <param name="other">Instance of RoleSubmit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoleSubmit other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Uuid == other.Uuid ||
                    Uuid != null &&
                    Uuid.Equals(other.Uuid)
                ) && 
                (
                    RoleIds == other.RoleIds ||
                    RoleIds != null &&
                    other.RoleIds != null &&
                    RoleIds.SequenceEqual(other.RoleIds)
                ) && 
                (
                    FunctionIds == other.FunctionIds ||
                    FunctionIds != null &&
                    other.FunctionIds != null &&
                    FunctionIds.SequenceEqual(other.FunctionIds)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Uuid != null)
                    hashCode = hashCode * 59 + Uuid.GetHashCode();
                    if (RoleIds != null)
                    hashCode = hashCode * 59 + RoleIds.GetHashCode();
                    if (FunctionIds != null)
                    hashCode = hashCode * 59 + FunctionIds.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RoleSubmit left, RoleSubmit right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RoleSubmit left, RoleSubmit right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
