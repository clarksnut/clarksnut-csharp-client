# IO.Swagger.Api.RequestAccessApi

All URIs are relative to *https://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRequestAccess**](RequestAccessApi.md#getrequestaccess) | **GET** /api/request-access | Get Request accesses
[**RequestAccessToSpace**](RequestAccessApi.md#requestaccesstospace) | **POST** /api/request-access | Request access
[**UpdateAccessSpace**](RequestAccessApi.md#updateaccessspace) | **PUT** /api/request-access/{requestId} | Update request


<a name="getrequestaccess"></a>
# **GetRequestAccess**
> GenericDataRepresentationListRequestData GetRequestAccess (List<string> space = null, string status = null)

Get Request accesses

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRequestAccessExample
    {
        public void main()
        {
            var apiInstance = new RequestAccessApi();
            var space = new List<string>(); // List<string> | Space Ids (optional) 
            var status = status_example;  // string | Status (optional)  (default to pending)

            try
            {
                // Get Request accesses
                GenericDataRepresentationListRequestData result = apiInstance.GetRequestAccess(space, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RequestAccessApi.GetRequestAccess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **space** | [**List&lt;string&gt;**](string.md)| Space Ids | [optional] 
 **status** | **string**| Status | [optional] [default to pending]

### Return type

[**GenericDataRepresentationListRequestData**](GenericDataRepresentationListRequestData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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

