<!-- Start SDK Example Usage -->
```csharp
using WingspanUsers;
using WingspanUsers.Models.Shared;
using WingspanUsers.Models.Operations;

var sdk = new SDK(
    security: new Security() {
        BearerAuth = "",
    }
);

var res = await sdk.BenefitsEnrollment.GetBenefitsEnrollmentIdAsync("string");

// handle response
```
<!-- End SDK Example Usage -->