<!-- Start SDK Example Usage -->
```csharp
using WingspanFiles;
using WingspanFiles.Models.Shared;
using WingspanFiles.Models.Operations;

var sdk = new SDK(
    security: new Security() {
        BearerAuth = "",
    }
);

var res = await sdk.BenefitsEnrollment.GetBenefitsEnrollmentIdAsync("string");

// handle response
```
<!-- End SDK Example Usage -->