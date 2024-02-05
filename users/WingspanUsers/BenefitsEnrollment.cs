
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace WingspanUsers
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;
    using WingspanUsers.Models.Operations;
    using WingspanUsers.Models.Shared;
    using WingspanUsers.Utils;

    /// <summary>
    /// Operations related to enrollments
    /// </summary>
    public interface IBenefitsEnrollment
    {

        /// <summary>
        /// Retrieve Enrollment Details for a Specific Member
        /// 
        /// <remarks>
        /// Fetches the enrollment status and details for a member identified by the provided unique identifier.
        /// </remarks>
        /// </summary>
        Task<GetBenefitsEnrollmentIdResponse> GetBenefitsEnrollmentIdAsync(string id);

        /// <summary>
        /// List all plan enrollments
        /// </summary>
        Task<GetBenefitsPlanEnrollmentResponse> GetBenefitsPlanEnrollmentAsync();

        /// <summary>
        /// Get a particular plan enrollment by ID
        /// </summary>
        Task<GetBenefitsPlanEnrollmentIdResponse> GetBenefitsPlanEnrollmentIdAsync(string id);
    }

    /// <summary>
    /// Operations related to enrollments
    /// </summary>
    public class BenefitsEnrollment: IBenefitsEnrollment
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "4.0.0";
        private const string _sdkGenVersion = "2.248.6";
        private const string _openapiDocVersion = "1.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 4.0.0 2.248.6 1.0.0 WingspanUsers";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public BenefitsEnrollment(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<GetBenefitsEnrollmentIdResponse> GetBenefitsEnrollmentIdAsync(string id)
        {
            var request = new GetBenefitsEnrollmentIdRequest()
            {
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/benefits/enrollment/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetBenefitsEnrollmentIdResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Enrollment = JsonConvert.DeserializeObject<Enrollment>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetBenefitsPlanEnrollmentResponse> GetBenefitsPlanEnrollmentAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = baseUrl + "/benefits/plan-enrollment";
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetBenefitsPlanEnrollmentResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Classes = JsonConvert.DeserializeObject<List<PlanEnrollment>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetBenefitsPlanEnrollmentIdResponse> GetBenefitsPlanEnrollmentIdAsync(string id)
        {
            var request = new GetBenefitsPlanEnrollmentIdRequest()
            {
                Id = id,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/benefits/plan-enrollment/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetBenefitsPlanEnrollmentIdResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.PlanEnrollment = JsonConvert.DeserializeObject<PlanEnrollment>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        
    }
}