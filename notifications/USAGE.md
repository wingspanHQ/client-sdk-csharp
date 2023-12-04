<!-- Start SDK Example Usage [usage] -->
```csharp
using WingspanNotifications;
using WingspanNotifications.Models.Shared;
using WingspanNotifications.Models.Operations;

var sdk = new SDK(
    security: new Security() {
        BearerAuth = "",
    });

var res = await sdk.BenefitsEnrollment.GetBenefitsEnrollmentIdAsync(Id: "string");

// handle response
```
<!-- End SDK Example Usage [usage] -->