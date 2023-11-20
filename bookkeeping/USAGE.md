<!-- Start SDK Example Usage -->
```csharp
using WingspanBookkeeping;
using WingspanBookkeeping.Models.Shared;
using WingspanBookkeeping.Models.Operations;

var sdk = new SDK(
    security: new Security() {
        BearerAuth = "",
    }
);

var res = await sdk.BenefitsEnrollment.GetBenefitsEnrollmentIdAsync("string");

// handle response
```
<!-- End SDK Example Usage -->