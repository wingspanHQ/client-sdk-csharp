<!-- Start SDK Example Usage -->
```csharp
using WingspanIntegrations;
using WingspanIntegrations.Models.Shared;
using WingspanIntegrations.Models.Operations;

var sdk = new SDK(
    security: new Security() {
        BearerAuth = "",
    }
);

var res = await sdk.BenefitsEnrollment.GetBenefitsEnrollmentIdAsync("string");

// handle response
```
<!-- End SDK Example Usage -->