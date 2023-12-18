<!-- Start SDK Example Usage [usage] -->
```csharp
using WingspanBookkeeping;
using WingspanBookkeeping.Models.Shared;
using WingspanBookkeeping.Models.Operations;

var sdk = new SDK(
    security: new Security() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    });

var res = await sdk.BenefitsEnrollment.GetBenefitsEnrollmentIdAsync(Id: "string");

// handle response
```
<!-- End SDK Example Usage [usage] -->