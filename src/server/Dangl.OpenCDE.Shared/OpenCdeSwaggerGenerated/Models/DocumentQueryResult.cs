/*
 * OpenCDE Documents API
 *
 * OpenCDE Documents API Specification
 *
 * The version of the OpenAPI document: 1.0
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
using Dangl.OpenCDE.Shared.OpenCdeSwaggerGenerated.Converters;

namespace Dangl.OpenCDE.Shared.OpenCdeSwaggerGenerated.Models
{ 
    /// <summary>
    /// The versions array contains all the latest document version objects.
    /// </summary>
    [DataContract]
    public partial class DocumentQueryResult : IEquatable<DocumentQueryResult>
    {
        /// <summary>
        /// Gets or Sets Versions
        /// </summary>
        [Required]
        [DataMember(Name="versions", EmitDefaultValue=false)]
        public List<DocumentVersion> Versions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentQueryResult {\n");
            sb.Append("  Versions: ").Append(Versions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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
            return obj.GetType() == GetType() && Equals((DocumentQueryResult)obj);
        }

        /// <summary>
        /// Returns true if DocumentQueryResult instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentQueryResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentQueryResult other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Versions == other.Versions ||
                    Versions != null &&
                    other.Versions != null &&
                    Versions.SequenceEqual(other.Versions)
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
                    if (Versions != null)
                    hashCode = hashCode * 59 + Versions.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DocumentQueryResult left, DocumentQueryResult right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DocumentQueryResult left, DocumentQueryResult right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
