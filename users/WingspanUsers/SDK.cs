
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
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;
    using WingspanUsers.Models.Shared;
    using WingspanUsers.Utils;



    /// <summary>
    /// Wingspan Benefits API: Benefits
    /// </summary>
    public interface ISDK
    {

        /// <summary>
        /// Operations related to enrollments
        /// </summary>
        public IBenefitsEnrollment BenefitsEnrollment { get; }

        /// <summary>
        /// Operations related to service management
        /// </summary>
        public IBenefitsService BenefitsService { get; }
    }
    
    public class SDKConfig
    {
        public static string[] ServerList = new string[]
        {
            "https://api.wingspan.app/benefits",
            "https://stagingapi.wingspan.app/benefits",
        };
        /// Contains the list of servers available to the SDK
        public string serverUrl = "";
        public int serverIndex = 0;

        public string GetTemplatedServerDetails()
        {
            if (!String.IsNullOrEmpty(this.serverUrl))
            {
                return Utilities.TemplateUrl(Utilities.RemoveSuffix(this.serverUrl, "/"), new Dictionary<string, string>());
            }
            return Utilities.TemplateUrl(SDKConfig.ServerList[this.serverIndex], new Dictionary<string, string>());
        }
    }

    /// <summary>
    /// Wingspan Benefits API: Benefits
    /// </summary>
    public class SDK: ISDK
    {
        public SDKConfig Config { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "2.0.1";
        private const string _sdkGenVersion = "2.194.1";
        private const string _openapiDocVersion = "1.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 2.0.1 2.194.1 1.0.0 WingspanUsers";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IBenefitsEnrollment BenefitsEnrollment { get; private set; }
        public IBenefitsService BenefitsService { get; private set; }

        public SDK(Security? security = null, int? serverIndex = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null)
        {
            if (serverUrl != null) {
                if (urlParams != null) {
                    serverUrl = Utilities.TemplateUrl(serverUrl, urlParams);
                }
                _serverUrl = serverUrl;
            }

            _defaultClient = new SpeakeasyHttpClient(client);
            _securityClient = _defaultClient;
            
            if(security != null)
            {
                _securityClient = SecuritySerializer.Apply(_defaultClient, security);
            }
            
            Config = new SDKConfig()
            {
                serverUrl = _serverUrl
            };

            BenefitsEnrollment = new BenefitsEnrollment(_defaultClient, _securityClient, _serverUrl, Config);
            BenefitsService = new BenefitsService(_defaultClient, _securityClient, _serverUrl, Config);
        }
    }
}