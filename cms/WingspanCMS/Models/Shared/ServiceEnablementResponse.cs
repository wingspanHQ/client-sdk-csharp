
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace WingspanCMS.Models.Shared
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class ServiceEnablementResponse
    {

        [JsonProperty("enabled")]
        public bool Enabled { get; set; } = default!;

        [JsonProperty("missingProperties")]
        public List<string>? MissingProperties { get; set; }

        [JsonProperty("serviceState")]
        public ServiceState ServiceState { get; set; } = default!;

        [JsonProperty("test")]
        public string? Test { get; set; }
    }
}