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
using WingspanNotifications;
using WingspanNotifications.Models.Operations;

var sdk = new SDK();

var res = await sdk.GetBenefitsEnrollmentIdAsync("string");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | Unique identifier  |


### Response

**[GetBenefitsEnrollmentIdResponse](../../Models/Operations/GetBenefitsEnrollmentIdResponse.md)**


## GetBenefitsPlanEnrollment

List all plan enrollments

### Example Usage

```csharp
using WingspanNotifications;

var sdk = new SDK();

var res = await sdk.GetBenefitsPlanEnrollmentAsync();

// handle response
```


### Response

**[GetBenefitsPlanEnrollmentResponse](../../Models/Operations/GetBenefitsPlanEnrollmentResponse.md)**


## GetBenefitsPlanEnrollmentId

Get a particular plan enrollment by ID

### Example Usage

```csharp
using WingspanNotifications;
using WingspanNotifications.Models.Operations;

var sdk = new SDK();

var res = await sdk.GetBenefitsPlanEnrollmentIdAsync("string");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | Unique identifier  |


### Response

**[GetBenefitsPlanEnrollmentIdResponse](../../Models/Operations/GetBenefitsPlanEnrollmentIdResponse.md)**


## GetBenefitsService

Fetches the current status indicating whether the benefits service is enabled or disabled.

### Example Usage

```csharp
using WingspanNotifications;

var sdk = new SDK();

var res = await sdk.GetBenefitsServiceAsync();

// handle response
```


### Response

**[GetBenefitsServiceResponse](../../Models/Operations/GetBenefitsServiceResponse.md)**


## PatchBenefitsServiceId

Allows users to change the enablement status of a specified benefits service.

### Example Usage

```csharp
using WingspanNotifications;
using WingspanNotifications.Models.Operations;
using WingspanNotifications.Models.Shared;

var sdk = new SDK();

var res = await sdk.PatchBenefitsServiceIdAsync("string", new ServiceEnablementUpdate() {
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

