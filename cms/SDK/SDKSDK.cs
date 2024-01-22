
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SDK
{
    using Newtonsoft.Json;
    using SDK.Models.Operations;
    using SDK.Models.Shared;
    using SDK.Utils;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Wingspan Benefits API: Benefits
    /// </summary>
    public interface ISDKSDK
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

        /// <summary>
        /// Retrieve Current Benefits Service Status
        /// 
        /// <remarks>
        /// Fetches the current status indicating whether the benefits service is enabled or disabled.
        /// </remarks>
        /// </summary>
        Task<GetBenefitsServiceResponse> GetBenefitsServiceAsync();

        /// <summary>
        /// Modify Benefits Service Status
        /// 
        /// <remarks>
        /// Allows users to change the enablement status of a specified benefits service.
        /// </remarks>
        /// </summary>
        Task<PatchBenefitsServiceIdResponse> PatchBenefitsServiceIdAsync(string id, ServiceEnablementUpdate? serviceEnablementUpdate = null);
    }
    
    public class SDKConfig
    {
    }

    /// <summary>
    /// Wingspan Benefits API: Benefits
    /// </summary>
    public class SDKSDK: ISDKSDK
    {
        public SDKConfig Config { get; private set; }
        public static List<string> ServerList = new List<string>()
        {
            "https://api.wingspan.app/benefits",
            "https://stagingapi.wingspan.app/benefits",
        };

        private const string _language = "csharp";
        private const string _sdkVersion = "1.0.0";
        private const string _sdkGenVersion = "2.173.0";
        private const string _openapiDocVersion = "1.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 1.0.0 2.173.0 1.0.0 WingspanCMS";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public SDKSDK(string? serverUrl = null, ISpeakeasyHttpClient? client = null)
        {
            _serverUrl = serverUrl ?? SDKSDK.ServerList[0];

            _defaultClient = new SpeakeasyHttpClient(client);
            _securityClient = _defaultClient;
            
            Config = new SDKConfig()
            {
            };

        }

        public async Task<GetBenefitsEnrollmentIdResponse> GetBenefitsEnrollmentIdAsync(string id)
        {
            var request = new GetBenefitsEnrollmentIdRequest()
            {
                Id = id,
            };
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/benefits/enrollment/{id}", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _defaultClient;
            
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
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = baseUrl + "/benefits/plan-enrollment";
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _defaultClient;
            
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
                    response.PlanEnrollments = JsonConvert.DeserializeObject<List<PlanEnrollment>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/benefits/plan-enrollment/{id}", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _defaultClient;
            
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

        public async Task<GetBenefitsServiceResponse> GetBenefitsServiceAsync()
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = baseUrl + "/benefits/service";
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _defaultClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetBenefitsServiceResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ServiceEnablementResponse = JsonConvert.DeserializeObject<ServiceEnablementResponse>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }

        public async Task<PatchBenefitsServiceIdResponse> PatchBenefitsServiceIdAsync(string id, ServiceEnablementUpdate? serviceEnablementUpdate = null)
        {
            var request = new PatchBenefitsServiceIdRequest()
            {
                Id = id,
                ServiceEnablementUpdate = serviceEnablementUpdate,
            };
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/benefits/service/{id}", request);
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Patch, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "ServiceEnablementUpdate", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _defaultClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new PatchBenefitsServiceIdResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ServiceEnablementResponse = JsonConvert.DeserializeObject<ServiceEnablementResponse>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
    }
}