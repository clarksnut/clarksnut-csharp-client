# IO.Swagger.Api.UsersApi

All URIs are relative to *https://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUser**](UsersApi.md#getuser) | **GET** /api/users/{userId} | Get User
[**GetUsers**](UsersApi.md#getusers) | **GET** /api/users | Get Users


<a name="getuser"></a>
# **GetUser**
> UserRepresentation GetUser (string userId)

Get User

This will return the requested user. [view-users] role required

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
                // Get User
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
> GenericDataRepresentationListUserData GetUsers (string username = null)

Get Users

This will search users. [view-users] role required

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

            try
            {
                // Get Users
                GenericDataRepresentationListUserData result = apiInstance.GetUsers(username);
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

### Return type

[**GenericDataRepresentationListUserData**](GenericDataRepresentationListUserData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

