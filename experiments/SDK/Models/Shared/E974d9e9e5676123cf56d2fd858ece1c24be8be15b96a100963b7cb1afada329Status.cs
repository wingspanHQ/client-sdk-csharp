
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SDK.Models.Shared
{
    using Newtonsoft.Json;
    using System;
    
    public enum E974d9e9e5676123cf56d2fd858ece1c24be8be15b96a100963b7cb1afada329Status
    {
        [JsonProperty("Active")]
        Active,
        [JsonProperty("Paused")]
        Paused,
        [JsonProperty("Disabled")]
        Disabled,
    }

    public static class E974d9e9e5676123cf56d2fd858ece1c24be8be15b96a100963b7cb1afada329StatusExtension
    {
        public static string Value(this E974d9e9e5676123cf56d2fd858ece1c24be8be15b96a100963b7cb1afada329Status value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static E974d9e9e5676123cf56d2fd858ece1c24be8be15b96a100963b7cb1afada329Status ToEnum(this string value)
        {
            foreach(var field in typeof(E974d9e9e5676123cf56d2fd858ece1c24be8be15b96a100963b7cb1afada329Status).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is E974d9e9e5676123cf56d2fd858ece1c24be8be15b96a100963b7cb1afada329Status)
                    {
                        return (E974d9e9e5676123cf56d2fd858ece1c24be8be15b96a100963b7cb1afada329Status)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum E974d9e9e5676123cf56d2fd858ece1c24be8be15b96a100963b7cb1afada329Status");
        }
    }
}