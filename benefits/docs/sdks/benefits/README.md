# Benefits SDK


## Overview

Wingspan Benefits API: Benefits

### Available Operations

* [GetBenefitsEnrollmentId](#getbenefitsenrollmentid) - Retrieve Enrollment Details for a Specific Member
* [GetBenefitsPlanEnrollment](#getbenefitsplanenrollment) - List all plan enrollments
* [GetBenefitsPlanEnrollmentId](#getbenefitsplanenrollmentid) - Get a particular plan enrollment by ID
* [GetBenefitsService](#getbenefitsservice) - Retrieve Current Benefits Service Status
* [PatchBenefitsServiceId](#patchbenefitsserviceid) - Modify Benefits Service Status

## GetBenefitsEnrollmentId

Fetches the enrollment status and details for a member identified by the provided unique identifier.

### Example Usage

```csharp
using Benefits;
using Benefits.Models.Operations;

var sdk = new BenefitsSDK();

var res = await sdk.Benefits.GetBenefitsEnrollmentIdAsync(new GetBenefitsEnrollmentIdRequest() {
    Id = "<ID>",
});

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [GetBenefitsEnrollmentIdRequest](../../models/operations/GetBenefitsEnrollmentIdRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |


### Response

**[GetBenefitsEnrollmentIdResponse](../../models/operations/GetBenefitsEnrollmentIdResponse.md)**


## GetBenefitsPlanEnrollment

List all plan enrollments

### Example Usage

```csharp
using Benefits;

var sdk = new BenefitsSDK();

var res = await sdk.Benefits.GetBenefitsPlanEnrollmentAsync();

// handle response
```


### Response

**[GetBenefitsPlanEnrollmentResponse](../../models/operations/GetBenefitsPlanEnrollmentResponse.md)**


## GetBenefitsPlanEnrollmentId

Get a particular plan enrollment by ID

### Example Usage

```csharp
using Benefits;
using Benefits.Models.Operations;

var sdk = new BenefitsSDK();

var res = await sdk.Benefits.GetBenefitsPlanEnrollmentIdAsync(new GetBenefitsPlanEnrollmentIdRequest() {
    Id = "<ID>",
});

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [GetBenefitsPlanEnrollmentIdRequest](../../models/operations/GetBenefitsPlanEnrollmentIdRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |


### Response

**[GetBenefitsPlanEnrollmentIdResponse](../../models/operations/GetBenefitsPlanEnrollmentIdResponse.md)**


## GetBenefitsService

Fetches the current status indicating whether the benefits service is enabled or disabled.

### Example Usage

```csharp
using Benefits;

var sdk = new BenefitsSDK();

var res = await sdk.Benefits.GetBenefitsServiceAsync();

// handle response
```


### Response

**[GetBenefitsServiceResponse](../../models/operations/GetBenefitsServiceResponse.md)**


## PatchBenefitsServiceId

Allows users to change the enablement status of a specified benefits service.

### Example Usage

```csharp
using Benefits;
using Benefits.Models.Operations;
using Benefits.Models.Shared;

var sdk = new BenefitsSDK();

var res = await sdk.Benefits.PatchBenefitsServiceIdAsync(new PatchBenefitsServiceIdRequest() {
    ServiceEnablementUpdate = new ServiceEnablementUpdate() {
        Enabled = false,
    },
    Id = "<ID>",
});

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [PatchBenefitsServiceIdRequest](../../models/operations/PatchBenefitsServiceIdRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[PatchBenefitsServiceIdResponse](../../models/operations/PatchBenefitsServiceIdResponse.md)**

