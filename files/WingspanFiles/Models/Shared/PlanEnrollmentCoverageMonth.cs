
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace WingspanFiles.Models.Shared
{
    using Newtonsoft.Json;
    using WingspanFiles.Models.Shared;
    
    public class PlanEnrollmentCoverageMonth
    {

        [JsonProperty("amountCharged")]
        public double AmountCharged { get; set; } = default!;

        [JsonProperty("fundingStatus")]
        public FundingStatus FundingStatus { get; set; } = default!;

        [JsonProperty("internal")]
        public A71f30be878693b235f8c5f1650be03c9920ca9821526545760476436104c9dc Internal { get; set; } = default!;

        [JsonProperty("month")]
        public string Month { get; set; } = default!;
    }
}