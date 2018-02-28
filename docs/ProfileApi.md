# IO.Swagger.Api.ProfileApi

All URIs are relative to *https://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CurrentUser**](ProfileApi.md#currentuser) | **PUT** /api/profile | Update User Profile
[**GetCurrentUser**](ProfileApi.md#getcurrentuser) | **GET** /api/profile | Return User Profile


<a name="currentuser"></a>
# **CurrentUser**
> UserRepresentation CurrentUser (UserRepresentation body = null)

Update User Profile

This will update the profile associated to the current token. [user] role required

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CurrentUserExample
    {
        public void main()
        {
            var apiInstance = new ProfileApi();
            var body = new UserRepresentation(); // UserRepresentation |  (optional) 

            try
            {
                // Update User Profile
                UserRepresentation result = apiInstance.CurrentUser(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfileApi.CurrentUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserRepresentation**](UserRepresentation.md)|  | [optional] 

### Return type

[**UserRepresentation**](UserRepresentation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrentuser"></a>
# **GetCurrentUser**
> UserRepresentation GetCurrentUser ()

Return User Profile

This will return the profile associated to the current token. [user] role required

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCurrentUserExample
    {
        public void main()
        {
            var apiInstance = new ProfileApi();

            try
            {
                // Return User Profile
                UserRepresentation result = apiInstance.GetCurrentUser();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfileApi.GetCurrentUser: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserRepresentation**](UserRepresentation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

