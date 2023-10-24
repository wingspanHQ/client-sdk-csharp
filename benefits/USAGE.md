<!-- Start SDK Example Usage -->


```csharp
using Benefits;
using Benefits.Models.Operations;

var sdk = new BenefitsSDK();

var res = await sdk.Benefits.GetBenefitsEnrollmentIdAsync(new GetBenefitsEnrollmentIdRequest() {
    Id = "<ID>",
});

// handle response
```
<!-- End SDK Example Usage -->