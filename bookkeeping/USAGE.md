<!-- Start SDK Example Usage [usage] -->
```csharp
using WingspanBookkeeping;
using WingspanBookkeeping.Models.Shared;
using WingspanBookkeeping.Models.Operations;

var sdk = new SDK(
    security: new Security() {
        BearerAuth = "",
    });

var res = await sdk.BenefitsEnrollment.GetBenefitsEnrollmentIdAsync(Id: "string");

// handle response
```
<!-- End SDK Example Usage [usage] -->