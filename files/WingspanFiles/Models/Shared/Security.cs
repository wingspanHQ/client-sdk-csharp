
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
    using WingspanFiles.Utils;
    
    public class Security
    {

        [SpeakeasyMetadata("security:scheme=true,type=http,subType=bearer,name=Authorization")]
        public string BearerAuth { get; set; } = default!;
    }
}