
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace WingspanFiles
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;
    using WingspanFiles.Models.Shared;
    using WingspanFiles.Utils;

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
        /// <summary>
        /// List of server URLs available to the SDK.
        /// </summary>
        public static readonly string[] ServerList = {
            "https://api.wingspan.app",
            "https://stagingapi.wingspan.app",
        };

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
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "4.2.1";
        private const string _sdkGenVersion = "2.279.1";
        private const string _openapiDocVersion = "1.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 4.2.1 2.279.1 1.0.0 WingspanFiles";
        private string _serverUrl = "";
        private int _serverIndex = 0;
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;
        public IBenefitsEnrollment BenefitsEnrollment { get; private set; }
        public IBenefitsService BenefitsService { get; private set; }

        public SDK(Security? security = null, Func<Security>? securitySource = null, int? serverIndex = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null)
        {
            if (serverIndex != null)
            {
                if (serverIndex.Value < 0 || serverIndex.Value >= SDKConfig.ServerList.Length)
                {
                    throw new Exception($"Invalid server index {serverIndex.Value}");
                }
                _serverIndex = serverIndex.Value;
            }

            if (serverUrl != null)
            {
                if (urlParams != null)
                {
                    serverUrl = Utilities.TemplateUrl(serverUrl, urlParams);
                }
                _serverUrl = serverUrl;
            }

            _defaultClient = new SpeakeasyHttpClient(client);

            if(securitySource != null)
            {
                _securitySource = securitySource;
            }
            else if(security != null)
            {
                _securitySource = () => security;
            }
            else
            {
                throw new Exception("security and securitySource cannot both be null");
            }

            SDKConfiguration = new SDKConfig()
            {
                serverIndex = _serverIndex,
                serverUrl = _serverUrl
            };

            BenefitsEnrollment = new BenefitsEnrollment(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            BenefitsService = new BenefitsService(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}
