/*
 * A3S
 *
 * API Definition for the A3S. This service allows authentication, authorisation and accounting.
 *
 * The version of the OpenAPI document: 1.0.5
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
    /// Models the default configuration section of a security contract.
    /// </summary>
    [DataContract]
    public partial class SecurityContractDefaultConfiguration : IEquatable<SecurityContractDefaultConfiguration>
    { 
        /// <summary>
        /// The name of the default configuration.
        /// </summary>
        /// <value>The name of the default configuration.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Applications
        /// </summary>
        [DataMember(Name="applications", EmitDefaultValue=false)]
        public List<SecurityContractDefaultConfigurationApplication> Applications { get; set; }

        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<SecurityContractDefaultConfigurationRole> Roles { get; set; }

        /// <summary>
        /// Gets or Sets LdapAuthenticationModes
        /// </summary>
        [DataMember(Name="ldapAuthenticationModes", EmitDefaultValue=false)]
        public List<SecurityContractDefaultConfigurationLdapAuthMode> LdapAuthenticationModes { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<SecurityContractDefaultConfigurationUser> Users { get; set; }

        /// <summary>
        /// Gets or Sets Teams
        /// </summary>
        [DataMember(Name="teams", EmitDefaultValue=false)]
        public List<SecurityContractDefaultConfigurationTeam> Teams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityContractDefaultConfiguration {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Applications: ").Append(Applications).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  LdapAuthenticationModes: ").Append(LdapAuthenticationModes).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SecurityContractDefaultConfiguration)obj);
        }

        /// <summary>
        /// Returns true if SecurityContractDefaultConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of SecurityContractDefaultConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityContractDefaultConfiguration other)
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
                    Applications == other.Applications ||
                    Applications != null &&
                    other.Applications != null &&
                    Applications.SequenceEqual(other.Applications)
                ) && 
                (
                    Roles == other.Roles ||
                    Roles != null &&
                    other.Roles != null &&
                    Roles.SequenceEqual(other.Roles)
                ) && 
                (
                    LdapAuthenticationModes == other.LdapAuthenticationModes ||
                    LdapAuthenticationModes != null &&
                    other.LdapAuthenticationModes != null &&
                    LdapAuthenticationModes.SequenceEqual(other.LdapAuthenticationModes)
                ) && 
                (
                    Users == other.Users ||
                    Users != null &&
                    other.Users != null &&
                    Users.SequenceEqual(other.Users)
                ) && 
                (
                    Teams == other.Teams ||
                    Teams != null &&
                    other.Teams != null &&
                    Teams.SequenceEqual(other.Teams)
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
                    if (Applications != null)
                    hashCode = hashCode * 59 + Applications.GetHashCode();
                    if (Roles != null)
                    hashCode = hashCode * 59 + Roles.GetHashCode();
                    if (LdapAuthenticationModes != null)
                    hashCode = hashCode * 59 + LdapAuthenticationModes.GetHashCode();
                    if (Users != null)
                    hashCode = hashCode * 59 + Users.GetHashCode();
                    if (Teams != null)
                    hashCode = hashCode * 59 + Teams.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SecurityContractDefaultConfiguration left, SecurityContractDefaultConfiguration right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SecurityContractDefaultConfiguration left, SecurityContractDefaultConfiguration right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
