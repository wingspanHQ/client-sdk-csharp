<!-- Start SDK Example Usage [usage] -->
```csharp
using WingspanExperiments;
using WingspanExperiments.Models.Shared;
using WingspanExperiments.Models.Operations;

var sdk = new SDK(
    security: new Security() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    });

var res = await sdk.BenefitsEnrollment.GetBenefitsEnrollmentIdAsync(Id: "string");

// handle response
```
<!-- End SDK Example Usage [usage] -->