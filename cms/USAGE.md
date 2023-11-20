<!-- Start SDK Example Usage -->
```csharp
using WingspanCMS;
using WingspanCMS.Models.Shared;
using WingspanCMS.Models.Operations;

var sdk = new SDK(
    security: new Security() {
        BearerAuth = "",
    }
);

var res = await sdk.BenefitsEnrollment.GetBenefitsEnrollmentIdAsync("string");

// handle response
```
<!-- End SDK Example Usage -->