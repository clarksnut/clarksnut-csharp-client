# IO.Swagger.Api.ProfileSpacesApi

All URIs are relative to *https://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddSpaceCollaborators**](ProfileSpacesApi.md#addspacecollaborators) | **POST** /api/profile/spaces/{spaceId}/collaborators | Add Space SpaceCollaborators
[**DeleteUserSpace**](ProfileSpacesApi.md#deleteuserspace) | **DELETE** /api/profile/spaces/{spaceId} | Delete space
[**GetSpaceCollaborators**](ProfileSpacesApi.md#getspacecollaborators) | **GET** /api/profile/spaces/{spaceId}/collaborators | Get Space SpaceCollaborators
[**GetUserSpace**](ProfileSpacesApi.md#getuserspace) | **GET** /api/profile/spaces/{spaceId} | Get Space
[**GetUserSpaces**](ProfileSpacesApi.md#getuserspaces) | **GET** /api/profile/spaces | Get Spaces of user
[**RemoveSpaceCollaborators**](ProfileSpacesApi.md#removespacecollaborators) | **DELETE** /api/profile/spaces/{spaceId}/collaborators/{userId} | Remove Space SpaceCollaborators
[**UpdateUserSpace**](ProfileSpacesApi.md#updateuserspace) | **PUT** /api/profile/spaces/{spaceId} | Update space


<a name="addspacecollaborators"></a>
# **AddSpaceCollaborators**
> void AddSpaceCollaborators (string spaceId, TypedGenericDataRepresentationListUserData body = null)

Add Space SpaceCollaborators

Accessed just by the owner, the owner is identified by current token. [user] role required

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddSpaceCollaboratorsExample
    {
        public void main()
        {
            var apiInstance = new ProfileSpacesApi();
            var spaceId = spaceId_example;  // string | Space Id
            var body = new TypedGenericDataRepresentationListUserData(); // TypedGenericDataRepresentationListUserData |  (optional) 

            try
            {
                // Add Space SpaceCollaborators
                apiInstance.AddSpaceCollaborators(spaceId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfileSpacesApi.AddSpaceCollaborators: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **spaceId** | **string**| Space Id | 
 **body** | [**TypedGenericDataRepresentationListUserData**](TypedGenericDataRepresentationListUserData.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuserspace"></a>
# **DeleteUserSpace**
> void DeleteUserSpace (string spaceId)

Delete space

Accessed just by the owner, the owner is identified by current token. [user] role required

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteUserSpaceExample
    {
        public void main()
        {
            var apiInstance = new ProfileSpacesApi();
            var spaceId = spaceId_example;  // string | Space Id

            try
            {
                // Delete space
                apiInstance.DeleteUserSpace(spaceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfileSpacesApi.DeleteUserSpace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **spaceId** | **string**| Space Id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getspacecollaborators"></a>
# **GetSpaceCollaborators**
> GenericDataRepresentationListUserData GetSpaceCollaborators (string spaceId, int? offset = null, int? limit = null)

Get Space SpaceCollaborators

Accessed just by the owner, the owner is identified by current token. [user] role required

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSpaceCollaboratorsExample
    {
        public void main()
        {
            var apiInstance = new ProfileSpacesApi();
            var spaceId = spaceId_example;  // string | Space Id
            var offset = 56;  // int? | First result (optional)  (default to 0)
            var limit = 56;  // int? | Max results (optional)  (default to 10)

            try
            {
                // Get Space SpaceCollaborators
                GenericDataRepresentationListUserData result = apiInstance.GetSpaceCollaborators(spaceId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfileSpacesApi.GetSpaceCollaborators: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **spaceId** | **string**| Space Id | 
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

<a name="getuserspace"></a>
# **GetUserSpace**
> SpaceRepresentation GetUserSpace (string spaceId)

Get Space

This will get a space, just the owner will be allowed. [user] role required

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserSpaceExample
    {
        public void main()
        {
            var apiInstance = new ProfileSpacesApi();
            var spaceId = spaceId_example;  // string | Space Id

            try
            {
                // Get Space
                SpaceRepresentation result = apiInstance.GetUserSpace(spaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfileSpacesApi.GetUserSpace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **spaceId** | **string**| Space Id | 

### Return type

[**SpaceRepresentation**](SpaceRepresentation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserspaces"></a>
# **GetUserSpaces**
> GenericDataRepresentationListSpaceData GetUserSpaces (string role = null)

Get Spaces of user

This will search owned and collaborated spaces. [user] role required

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
            var apiInstance = new ProfileSpacesApi();
            var role = role_example;  // string | Role (optional)  (default to owner)

            try
            {
                // Get Spaces of user
                GenericDataRepresentationListSpaceData result = apiInstance.GetUserSpaces(role);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfileSpacesApi.GetUserSpaces: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| Role | [optional] [default to owner]

### Return type

[**GenericDataRepresentationListSpaceData**](GenericDataRepresentationListSpaceData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removespacecollaborators"></a>
# **RemoveSpaceCollaborators**
> void RemoveSpaceCollaborators (string spaceId, string userId)

Remove Space SpaceCollaborators

Accessed just by the owner, the owner is identified by current token. [user] role required

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveSpaceCollaboratorsExample
    {
        public void main()
        {
            var apiInstance = new ProfileSpacesApi();
            var spaceId = spaceId_example;  // string | Space Id
            var userId = userId_example;  // string | User Id

            try
            {
                // Remove Space SpaceCollaborators
                apiInstance.RemoveSpaceCollaborators(spaceId, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfileSpacesApi.RemoveSpaceCollaborators: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **spaceId** | **string**| Space Id | 
 **userId** | **string**| User Id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuserspace"></a>
# **UpdateUserSpace**
> SpaceRepresentation UpdateUserSpace (string spaceId, SpaceRepresentation body = null)

Update space

Accessed just by the owner, the owner is identified by current token. [user] role required

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUserSpaceExample
    {
        public void main()
        {
            var apiInstance = new ProfileSpacesApi();
            var spaceId = spaceId_example;  // string | Space Id
            var body = new SpaceRepresentation(); // SpaceRepresentation |  (optional) 

            try
            {
                // Update space
                SpaceRepresentation result = apiInstance.UpdateUserSpace(spaceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfileSpacesApi.UpdateUserSpace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **spaceId** | **string**| Space Id | 
 **body** | [**SpaceRepresentation**](SpaceRepresentation.md)|  | [optional] 

### Return type

[**SpaceRepresentation**](SpaceRepresentation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

