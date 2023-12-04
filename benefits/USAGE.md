<!-- Start SDK Example Usage [usage] -->
```csharp
using WingspanBenefits;
using WingspanBenefits.Models.Shared;
using WingspanBenefits.Models.Operations;

var sdk = new SDK(
    security: new Security() {
        BearerAuth = "",
    });

var res = await sdk.BenefitsEnrollment.GetBenefitsEnrollmentIdAsync(Id: "string");

// handle response
```
<!-- End SDK Example Usage [usage] -->