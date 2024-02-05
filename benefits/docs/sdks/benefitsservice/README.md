# BenefitsService
(*BenefitsService*)

## Overview

Operations related to service management

### Available Operations

* [GetBenefitsService](#getbenefitsservice) - Retrieve Current Benefits Service Status
* [PatchBenefitsServiceId](#patchbenefitsserviceid) - Modify Benefits Service Status

## GetBenefitsService

Fetches the current status indicating whether the benefits service is enabled or disabled.

### Example Usage

```csharp
using WingspanBenefits;
using WingspanBenefits.Models.Shared;

var sdk = new SDK(security: new Security() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    });

var res = await sdk.BenefitsService.GetBenefitsServiceAsync();

// handle response
```


### Response

**[GetBenefitsServiceResponse](../../Models/Operations/GetBenefitsServiceResponse.md)**


## PatchBenefitsServiceId

Allows users to change the enablement status of a specified benefits service.

### Example Usage

```csharp
using WingspanBenefits;
using WingspanBenefits.Models.Shared;
using WingspanBenefits.Models.Operations;

var sdk = new SDK(security: new Security() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    });

var res = await sdk.BenefitsService.PatchBenefitsServiceIdAsync(
    id: "string",
    serviceEnablementUpdate: new ServiceEnablementUpdate() {
    Enabled = false,
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `Id`                                                                      | *string*                                                                  | :heavy_check_mark:                                                        | Unique identifier                                                         |
| `ServiceEnablementUpdate`                                                 | [ServiceEnablementUpdate](../../Models/Shared/ServiceEnablementUpdate.md) | :heavy_minus_sign:                                                        | N/A                                                                       |


### Response

**[PatchBenefitsServiceIdResponse](../../Models/Operations/PatchBenefitsServiceIdResponse.md)**

