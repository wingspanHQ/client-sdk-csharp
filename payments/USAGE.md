<!-- Start SDK Example Usage -->
```csharp
using WingspanPayments;
using WingspanPayments.Models.Shared;
using WingspanPayments.Models.Operations;

var sdk = new SDK(
    security: new Security() {
        BearerAuth = "",
    }
);

var res = await sdk.BenefitsEnrollment.GetBenefitsEnrollmentIdAsync("string");

// handle response
```
<!-- End SDK Example Usage -->