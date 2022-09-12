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
    /// This model describes how a single part of a multipart file upload should be processed by the client. The upload links may only be valid for a specific time period, after which the links expire. Server vendors should make sure to have a reasonably long expiration date for clients to upload large files
    /// </summary>
    [DataContract]
    public partial class UploadFilePartInstruction : IEquatable<UploadFilePartInstruction>
    {
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [Required]
        [MinLength(1)]
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }


        /// <summary>
        /// Gets or Sets HttpMethod
        /// </summary>
        [TypeConverter(typeof(CustomEnumConverter<HttpMethodEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum HttpMethodEnum
        {
            
            /// <summary>
            /// Enum POSTEnum for POST
            /// </summary>
            [EnumMember(Value = "POST")]
            POSTEnum = 1,
            
            /// <summary>
            /// Enum PUTEnum for PUT
            /// </summary>
            [EnumMember(Value = "PUT")]
            PUTEnum = 2
        }

        /// <summary>
        /// Gets or Sets HttpMethod
        /// </summary>
        [Required]
        [DataMember(Name="http_method", EmitDefaultValue=true)]
        public HttpMethodEnum HttpMethod { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalHeaders
        /// </summary>
        [DataMember(Name="additional_headers", EmitDefaultValue=false)]
        public Headers AdditionalHeaders { get; set; }

        /// <summary>
        /// Whether or not to include the authorization request header in the file upload request. Including the authorization header with some cloud storage providers might fail the request
        /// </summary>
        /// <value>Whether or not to include the authorization request header in the file upload request. Including the authorization header with some cloud storage providers might fail the request</value>
        [DataMember(Name="include_authorization", EmitDefaultValue=true)]
        public bool IncludeAuthorization { get; set; } = false;

        /// <summary>
        /// Gets or Sets MultipartFormData
        /// </summary>
        [DataMember(Name="multipart_form_data", EmitDefaultValue=false)]
        public MultipartFormData MultipartFormData { get; set; }

        /// <summary>
        /// The inclusive, zero index based start for this part
        /// </summary>
        /// <value>The inclusive, zero index based start for this part</value>
        [Required]
        [DataMember(Name="content_range_start", EmitDefaultValue=true)]
        public long ContentRangeStart { get; set; }

        /// <summary>
        /// The inclusive, zero index based end for this part
        /// </summary>
        /// <value>The inclusive, zero index based end for this part</value>
        [Required]
        [DataMember(Name="content_range_end", EmitDefaultValue=true)]
        public long ContentRangeEnd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadFilePartInstruction {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  HttpMethod: ").Append(HttpMethod).Append("\n");
            sb.Append("  AdditionalHeaders: ").Append(AdditionalHeaders).Append("\n");
            sb.Append("  IncludeAuthorization: ").Append(IncludeAuthorization).Append("\n");
            sb.Append("  MultipartFormData: ").Append(MultipartFormData).Append("\n");
            sb.Append("  ContentRangeStart: ").Append(ContentRangeStart).Append("\n");
            sb.Append("  ContentRangeEnd: ").Append(ContentRangeEnd).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UploadFilePartInstruction)obj);
        }

        /// <summary>
        /// Returns true if UploadFilePartInstruction instances are equal
        /// </summary>
        /// <param name="other">Instance of UploadFilePartInstruction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadFilePartInstruction other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Url == other.Url ||
                    Url != null &&
                    Url.Equals(other.Url)
                ) && 
                (
                    HttpMethod == other.HttpMethod ||
                    
                    HttpMethod.Equals(other.HttpMethod)
                ) && 
                (
                    AdditionalHeaders == other.AdditionalHeaders ||
                    AdditionalHeaders != null &&
                    AdditionalHeaders.Equals(other.AdditionalHeaders)
                ) && 
                (
                    IncludeAuthorization == other.IncludeAuthorization ||
                    
                    IncludeAuthorization.Equals(other.IncludeAuthorization)
                ) && 
                (
                    MultipartFormData == other.MultipartFormData ||
                    MultipartFormData != null &&
                    MultipartFormData.Equals(other.MultipartFormData)
                ) && 
                (
                    ContentRangeStart == other.ContentRangeStart ||
                    
                    ContentRangeStart.Equals(other.ContentRangeStart)
                ) && 
                (
                    ContentRangeEnd == other.ContentRangeEnd ||
                    
                    ContentRangeEnd.Equals(other.ContentRangeEnd)
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
                    if (Url != null)
                    hashCode = hashCode * 59 + Url.GetHashCode();
                    
                    hashCode = hashCode * 59 + HttpMethod.GetHashCode();
                    if (AdditionalHeaders != null)
                    hashCode = hashCode * 59 + AdditionalHeaders.GetHashCode();
                    
                    hashCode = hashCode * 59 + IncludeAuthorization.GetHashCode();
                    if (MultipartFormData != null)
                    hashCode = hashCode * 59 + MultipartFormData.GetHashCode();
                    
                    hashCode = hashCode * 59 + ContentRangeStart.GetHashCode();
                    
                    hashCode = hashCode * 59 + ContentRangeEnd.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(UploadFilePartInstruction left, UploadFilePartInstruction right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UploadFilePartInstruction left, UploadFilePartInstruction right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
