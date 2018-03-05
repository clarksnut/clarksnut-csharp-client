# IO.Swagger.Api.RequestAccessApi

All URIs are relative to *https://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RequestAccessToSpace**](RequestAccessApi.md#requestaccesstospace) | **POST** /api/request-access | Request access
[**UpdateAccessSpace**](RequestAccessApi.md#updateaccessspace) | **PUT** /api/request-access/{requestId} | Update request


<a name="requestaccesstospace"></a>
# **RequestAccessToSpace**
> void RequestAccessToSpace (RequestRepresentation body = null)

Request access

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RequestAccessToSpaceExample
    {
        public void main()
        {
            var apiInstance = new RequestAccessApi();
            var body = new RequestRepresentation(); // RequestRepresentation |  (optional) 

            try
            {
                // Request access
                apiInstance.RequestAccessToSpace(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestAccessApi.RequestAccessToSpace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestRepresentation**](RequestRepresentation.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaccessspace"></a>
# **UpdateAccessSpace**
> void UpdateAccessSpace (string requestId, RequestRepresentation body = null)

Update request

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateAccessSpaceExample
    {
        public void main()
        {
            var apiInstance = new RequestAccessApi();
            var requestId = requestId_example;  // string | Request Id
            var body = new RequestRepresentation(); // RequestRepresentation |  (optional) 

            try
            {
                // Update request
                apiInstance.UpdateAccessSpace(requestId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestAccessApi.UpdateAccessSpace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestId** | **string**| Request Id | 
 **body** | [**RequestRepresentation**](RequestRepresentation.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

