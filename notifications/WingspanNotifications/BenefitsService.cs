
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace WingspanNotifications
{
    using Newtonsoft.Json;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;
    using WingspanNotifications.Models.Operations;
    using WingspanNotifications.Models.Shared;
    using WingspanNotifications.Utils;

    /// <summary>
    /// Operations related to service management
    /// </summary>
    public interface IBenefitsService
    {

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

    /// <summary>
    /// Operations related to service management
    /// </summary>
    public class BenefitsService: IBenefitsService
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "2.1.0";
        private const string _sdkGenVersion = "2.214.10";
        private const string _openapiDocVersion = "1.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 2.1.0 2.214.10 1.0.0 WingspanNotifications";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public BenefitsService(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<GetBenefitsServiceResponse> GetBenefitsServiceAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = baseUrl + "/benefits/service";
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
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
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/benefits/service/{id}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Patch, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "ServiceEnablementUpdate", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
            var client = _securityClient;
            
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