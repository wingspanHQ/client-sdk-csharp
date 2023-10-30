# SDK


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
using SDK;
using SDK.Models.Operations;

var sdk = new SDKSDK();

var res = await sdk.SDK.GetBenefitsEnrollmentIdAsync("string");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | Unique identifier  |


### Response

**[GetBenefitsEnrollmentIdResponse](../../models/operations/GetBenefitsEnrollmentIdResponse.md)**


## GetBenefitsPlanEnrollment

List all plan enrollments

### Example Usage

```csharp
using SDK;

var sdk = new SDKSDK();

var res = await sdk.SDK.GetBenefitsPlanEnrollmentAsync();

// handle response
```


### Response

**[GetBenefitsPlanEnrollmentResponse](../../models/operations/GetBenefitsPlanEnrollmentResponse.md)**


## GetBenefitsPlanEnrollmentId

Get a particular plan enrollment by ID

### Example Usage

```csharp
using SDK;
using SDK.Models.Operations;

var sdk = new SDKSDK();

var res = await sdk.SDK.GetBenefitsPlanEnrollmentIdAsync("string");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | Unique identifier  |


### Response

**[GetBenefitsPlanEnrollmentIdResponse](../../models/operations/GetBenefitsPlanEnrollmentIdResponse.md)**


## GetBenefitsService

Fetches the current status indicating whether the benefits service is enabled or disabled.

### Example Usage

```csharp
using SDK;

var sdk = new SDKSDK();

var res = await sdk.SDK.GetBenefitsServiceAsync();

// handle response
```


### Response

**[GetBenefitsServiceResponse](../../models/operations/GetBenefitsServiceResponse.md)**


## PatchBenefitsServiceId

Allows users to change the enablement status of a specified benefits service.

### Example Usage

```csharp
using SDK;
using SDK.Models.Operations;
using SDK.Models.Shared;

var sdk = new SDKSDK();

var res = await sdk.SDK.PatchBenefitsServiceIdAsync("string", new ServiceEnablementUpdate() {
    Enabled = false,
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `Id`                                                                      | *string*                                                                  | :heavy_check_mark:                                                        | Unique identifier                                                         |
| `ServiceEnablementUpdate`                                                 | [ServiceEnablementUpdate](../../models/shared/ServiceEnablementUpdate.md) | :heavy_minus_sign:                                                        | N/A                                                                       |


### Response

**[PatchBenefitsServiceIdResponse](../../models/operations/PatchBenefitsServiceIdResponse.md)**

