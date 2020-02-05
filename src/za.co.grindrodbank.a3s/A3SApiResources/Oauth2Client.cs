/**
 * *************************************************
 * Copyright (c) 2019, Grindrod Bank Limited
 * License MIT: https://opensource.org/licenses/MIT
 * **************************************************
 */
/*
 * A3S
 *
 * API Definition for A3S. This service allows authentication, authorisation and accounting.
 *
 * The version of the OpenAPI document: 1.1.0
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
    /// Models an Oauth2 or OpenID Connect client. 
    /// </summary>
    [DataContract]
    public partial class Oauth2Client : IEquatable<Oauth2Client>
    { 
        /// <summary>
        /// The unique ID of the client.
        /// </summary>
        /// <value>The unique ID of the client.</value>
        [Required]
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Client display name. Used for logging and the consent screen.
        /// </summary>
        /// <value>Client display name. Used for logging and the consent screen.</value>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The Oauth2 grant types that the client will be permitted to use.
        /// </summary>
        /// <value>The Oauth2 grant types that the client will be permitted to use.</value>
        [Required]
        [DataMember(Name="allowedGrantTypes", EmitDefaultValue=false)]
        public List<string> AllowedGrantTypes { get; set; }

        /// <summary>
        /// Specifies the allowed URIs to return tokens or authorisation codes to.
        /// </summary>
        /// <value>Specifies the allowed URIs to return tokens or authorisation codes to.</value>
        [DataMember(Name="redirectUris", EmitDefaultValue=false)]
        public List<string> RedirectUris { get; set; }

        /// <summary>
        /// Sets the allowed CORS origins for JavaScript clients.
        /// </summary>
        /// <value>Sets the allowed CORS origins for JavaScript clients.</value>
        [DataMember(Name="allowedCorsOrigins", EmitDefaultValue=false)]
        public List<string> AllowedCorsOrigins { get; set; }

        /// <summary>
        /// Specifies the allowed URIs to redirect to after logout.
        /// </summary>
        /// <value>Specifies the allowed URIs to redirect to after logout.</value>
        [DataMember(Name="postLogoutRedirectUris", EmitDefaultValue=false)]
        public List<string> PostLogoutRedirectUris { get; set; }

        /// <summary>
        /// Specifies the scopes that the client is allowed to access. If empty, the client cannot access any scopes.
        /// </summary>
        /// <value>Specifies the scopes that the client is allowed to access. If empty, the client cannot access any scopes.</value>
        [Required]
        [DataMember(Name="allowedScopes", EmitDefaultValue=false)]
        public List<string> AllowedScopes { get; set; }

        /// <summary>
        /// Defines whether offline access with refresh tokens is permitted for this client.
        /// </summary>
        /// <value>Defines whether offline access with refresh tokens is permitted for this client.</value>
        [Required]
        [DataMember(Name="allowedOfflineAccess", EmitDefaultValue=true)]
        public bool AllowedOfflineAccess { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Oauth2Client {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AllowedGrantTypes: ").Append(AllowedGrantTypes).Append("\n");
            sb.Append("  RedirectUris: ").Append(RedirectUris).Append("\n");
            sb.Append("  AllowedCorsOrigins: ").Append(AllowedCorsOrigins).Append("\n");
            sb.Append("  PostLogoutRedirectUris: ").Append(PostLogoutRedirectUris).Append("\n");
            sb.Append("  AllowedScopes: ").Append(AllowedScopes).Append("\n");
            sb.Append("  AllowedOfflineAccess: ").Append(AllowedOfflineAccess).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Oauth2Client)obj);
        }

        /// <summary>
        /// Returns true if Oauth2Client instances are equal
        /// </summary>
        /// <param name="other">Instance of Oauth2Client to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Oauth2Client other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ClientId == other.ClientId ||
                    ClientId != null &&
                    ClientId.Equals(other.ClientId)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    AllowedGrantTypes == other.AllowedGrantTypes ||
                    AllowedGrantTypes != null &&
                    other.AllowedGrantTypes != null &&
                    AllowedGrantTypes.SequenceEqual(other.AllowedGrantTypes)
                ) && 
                (
                    RedirectUris == other.RedirectUris ||
                    RedirectUris != null &&
                    other.RedirectUris != null &&
                    RedirectUris.SequenceEqual(other.RedirectUris)
                ) && 
                (
                    AllowedCorsOrigins == other.AllowedCorsOrigins ||
                    AllowedCorsOrigins != null &&
                    other.AllowedCorsOrigins != null &&
                    AllowedCorsOrigins.SequenceEqual(other.AllowedCorsOrigins)
                ) && 
                (
                    PostLogoutRedirectUris == other.PostLogoutRedirectUris ||
                    PostLogoutRedirectUris != null &&
                    other.PostLogoutRedirectUris != null &&
                    PostLogoutRedirectUris.SequenceEqual(other.PostLogoutRedirectUris)
                ) && 
                (
                    AllowedScopes == other.AllowedScopes ||
                    AllowedScopes != null &&
                    other.AllowedScopes != null &&
                    AllowedScopes.SequenceEqual(other.AllowedScopes)
                ) && 
                (
                    AllowedOfflineAccess == other.AllowedOfflineAccess ||
                    
                    AllowedOfflineAccess.Equals(other.AllowedOfflineAccess)
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
                    if (ClientId != null)
                    hashCode = hashCode * 59 + ClientId.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (AllowedGrantTypes != null)
                    hashCode = hashCode * 59 + AllowedGrantTypes.GetHashCode();
                    if (RedirectUris != null)
                    hashCode = hashCode * 59 + RedirectUris.GetHashCode();
                    if (AllowedCorsOrigins != null)
                    hashCode = hashCode * 59 + AllowedCorsOrigins.GetHashCode();
                    if (PostLogoutRedirectUris != null)
                    hashCode = hashCode * 59 + PostLogoutRedirectUris.GetHashCode();
                    if (AllowedScopes != null)
                    hashCode = hashCode * 59 + AllowedScopes.GetHashCode();
                    
                    hashCode = hashCode * 59 + AllowedOfflineAccess.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Oauth2Client left, Oauth2Client right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Oauth2Client left, Oauth2Client right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
