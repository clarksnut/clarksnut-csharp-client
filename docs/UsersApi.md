# IO.Swagger.Api.UsersApi

All URIs are relative to *https://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUser**](UsersApi.md#getuser) | **GET** /api/users/{userId} | Return One User
[**GetUsers**](UsersApi.md#getusers) | **GET** /api/users | Return List of Users


<a name="getuser"></a>
# **GetUser**
> UserRepresentation GetUser (string userId)

Return One User

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User Id

            try
            {
                // Return One User
                UserRepresentation result = apiInstance.GetUser(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User Id | 

### Return type

[**UserRepresentation**](UserRepresentation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusers"></a>
# **GetUsers**
> GenericDataRepresentationListUserData GetUsers (string username = null, string filterText = null, int? offset = null, int? limit = null)

Return List of Users

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUsersExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var username = username_example;  // string | Username (optional) 
            var filterText = filterText_example;  // string | Filter Text (optional) 
            var offset = 56;  // int? | First result (optional)  (default to 0)
            var limit = 56;  // int? | Max results (optional)  (default to 10)

            try
            {
                // Return List of Users
                GenericDataRepresentationListUserData result = apiInstance.GetUsers(username, filterText, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| Username | [optional] 
 **filterText** | **string**| Filter Text | [optional] 
 **offset** | **int?**| First result | [optional] [default to 0]
 **limit** | **int?**| Max results | [optional] [default to 10]

### Return type

[**GenericDataRepresentationListUserData**](GenericDataRepresentationListUserData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

