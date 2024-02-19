<!-- Start SDK Example Usage [usage] -->
```csharp
using WingspanFiles;
using WingspanFiles.Models.Shared;
using WingspanFiles.Models.Operations;

var sdk = new SDK(security: new Security() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    });

var res = await sdk.BenefitsEnrollment.GetBenefitsEnrollmentIdAsync(id: "<value>");

// handle response
```
<!-- End SDK Example Usage [usage] -->