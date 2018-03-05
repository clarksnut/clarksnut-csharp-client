# IO.Swagger.Api.NamedSpacesApi

All URIs are relative to *https://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUserSpaces**](NamedSpacesApi.md#getuserspaces) | **GET** /api/namedspaces/{userId} | Return allowed Spaces of User


<a name="getuserspaces"></a>
# **GetUserSpaces**
> GenericDataRepresentationListSpaceData GetUserSpaces (string userId, string role = null, int? offset = null, int? limit = null)

Return allowed Spaces of User

[view-users] role required

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserSpacesExample
    {
        public void main()
        {
            var apiInstance = new NamedSpacesApi();
            var userId = userId_example;  // string | User Id
            var role = role_example;  // string | Role (optional)  (default to owner)
            var offset = 56;  // int? | First result (optional)  (default to 0)
            var limit = 56;  // int? | Max results (optional)  (default to 10)

            try
            {
                // Return allowed Spaces of User
                GenericDataRepresentationListSpaceData result = apiInstance.GetUserSpaces(userId, role, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NamedSpacesApi.GetUserSpaces: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User Id | 
 **role** | **string**| Role | [optional] [default to owner]
 **offset** | **int?**| First result | [optional] [default to 0]
 **limit** | **int?**| Max results | [optional] [default to 10]

### Return type

[**GenericDataRepresentationListSpaceData**](GenericDataRepresentationListSpaceData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

