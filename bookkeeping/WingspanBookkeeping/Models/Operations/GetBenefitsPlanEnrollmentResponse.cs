
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace WingspanBookkeeping.Models.Operations
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System;
    using WingspanBookkeeping.Models.Shared;
    
    public class GetBenefitsPlanEnrollmentResponse
    {

        /// <summary>
        /// HTTP response content type for this operation
        /// </summary>
        public string? ContentType { get; set; } = default!;

        /// <summary>
        /// HTTP response status code for this operation
        /// </summary>
        public int StatusCode { get; set; } = default!;

        /// <summary>
        /// Raw HTTP response; suitable for custom response parsing
        /// </summary>
        public HttpResponseMessage RawResponse { get; set; } = default!;

        /// <summary>
        /// List of plan enrollments for a member
        /// </summary>
        public List<PlanEnrollment>? Classes { get; set; }
    }
}