# IO.Swagger.Api.SpaceRequestAccessApi

All URIs are relative to *https://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRequestAccess**](SpaceRequestAccessApi.md#getrequestaccess) | **GET** /request-access | 
[**RequestAccessToSpace**](SpaceRequestAccessApi.md#requestaccesstospace) | **POST** /request-access | 
[**UpdateAccessSpace**](SpaceRequestAccessApi.md#updateaccessspace) | **PUT** /request-access/{requestId} | 


<a name="getrequestaccess"></a>
# **GetRequestAccess**
> GenericDataRepresentationListRequestData GetRequestAccess ()



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
            var apiInstance = new SpaceRequestAccessApi();

            try
            {
                GenericDataRepresentationListRequestData result = apiInstance.GetRequestAccess();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpaceRequestAccessApi.GetRequestAccess: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

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
            var apiInstance = new SpaceRequestAccessApi();
            var body = new RequestRepresentation(); // RequestRepresentation |  (optional) 

            try
            {
                apiInstance.RequestAccessToSpace(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpaceRequestAccessApi.RequestAccessToSpace: " + e.Message );
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
            var apiInstance = new SpaceRequestAccessApi();
            var requestId = requestId_example;  // string | 
            var body = new RequestRepresentation(); // RequestRepresentation |  (optional) 

            try
            {
                apiInstance.UpdateAccessSpace(requestId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpaceRequestAccessApi.UpdateAccessSpace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestId** | **string**|  | 
 **body** | [**RequestRepresentation**](RequestRepresentation.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

