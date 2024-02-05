# BenefitsEnrollment
(*BenefitsEnrollment*)

## Overview

Operations related to enrollments

### Available Operations

* [GetBenefitsEnrollmentId](#getbenefitsenrollmentid) - Retrieve Enrollment Details for a Specific Member
* [GetBenefitsPlanEnrollment](#getbenefitsplanenrollment) - List all plan enrollments
* [GetBenefitsPlanEnrollmentId](#getbenefitsplanenrollmentid) - Get a particular plan enrollment by ID

## GetBenefitsEnrollmentId

Fetches the enrollment status and details for a member identified by the provided unique identifier.

### Example Usage

```csharp
using WingspanBenefits;
using WingspanBenefits.Models.Shared;
using WingspanBenefits.Models.Operations;

var sdk = new SDK(security: new Security() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    });

var res = await sdk.BenefitsEnrollment.GetBenefitsEnrollmentIdAsync(id: "string");

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
using WingspanBenefits;
using WingspanBenefits.Models.Shared;

var sdk = new SDK(security: new Security() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    });

var res = await sdk.BenefitsEnrollment.GetBenefitsPlanEnrollmentAsync();

// handle response
```


### Response

**[GetBenefitsPlanEnrollmentResponse](../../Models/Operations/GetBenefitsPlanEnrollmentResponse.md)**


## GetBenefitsPlanEnrollmentId

Get a particular plan enrollment by ID

### Example Usage

```csharp
using WingspanBenefits;
using WingspanBenefits.Models.Shared;
using WingspanBenefits.Models.Operations;

var sdk = new SDK(security: new Security() {
        BearerAuth = "<YOUR_BEARER_TOKEN_HERE>",
    });

var res = await sdk.BenefitsEnrollment.GetBenefitsPlanEnrollmentIdAsync(id: "string");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | Unique identifier  |


### Response

**[GetBenefitsPlanEnrollmentIdResponse](../../Models/Operations/GetBenefitsPlanEnrollmentIdResponse.md)**

