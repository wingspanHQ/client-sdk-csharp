<!-- Start SDK Example Usage -->
```csharp
using WingspanExperiments;
using WingspanExperiments.Models.Shared;
using WingspanExperiments.Models.Operations;

var sdk = new SDK(
    security: new Security() {
        BearerAuth = "",
    }
);

var res = await sdk.BenefitsEnrollment.GetBenefitsEnrollmentIdAsync("string");

// handle response
```
<!-- End SDK Example Usage -->