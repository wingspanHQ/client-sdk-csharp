<!-- Start SDK Example Usage -->
```csharp
using WingspanNotifications;
using WingspanNotifications.Models.Shared;
using WingspanNotifications.Models.Operations;

var sdk = new SDK(
    security: new Security() {
        BearerAuth = "",
    }
);

var res = await sdk.BenefitsEnrollment.GetBenefitsEnrollmentIdAsync("string");

// handle response
```
<!-- End SDK Example Usage -->