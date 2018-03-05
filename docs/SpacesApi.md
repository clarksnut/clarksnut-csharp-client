# IO.Swagger.Api.SpacesApi

All URIs are relative to *https://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddSpaceCollaborators**](SpacesApi.md#addspacecollaborators) | **POST** /api/spaces/{spaceId}/collaborators | Add new Collaborator
[**CreateSpace**](SpacesApi.md#createspace) | **POST** /api/spaces | Create new Space
[**DeleteUserSpace**](SpacesApi.md#deleteuserspace) | **DELETE** /api/spaces/{spaceId} | Delete space
[**GetSpace**](SpacesApi.md#getspace) | **GET** /api/spaces/{spaceId} | Return one Space
[**GetSpaceCollaborators**](SpacesApi.md#getspacecollaborators) | **GET** /api/spaces/{spaceId}/collaborators | Return list of Collaborators
[**GetSpaces**](SpacesApi.md#getspaces) | **GET** /api/spaces | Return list of Spaces
[**RemoveSpaceCollaborators**](SpacesApi.md#removespacecollaborators) | **DELETE** /api/spaces/{spaceId}/collaborators/{userId} | Remove Collaborator
[**UpdateUserSpace**](SpacesApi.md#updateuserspace) | **PUT** /api/spaces/{spaceId} | Update space


<a name="addspacecollaborators"></a>
# **AddSpaceCollaborators**
> void AddSpaceCollaborators (string spaceId, TypedGenericDataRepresentationListUserData body = null)

Add new Collaborator

[user] role required

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
            var apiInstance = new SpacesApi();
            var spaceId = spaceId_example;  // string | Space Id
            var body = new TypedGenericDataRepresentationListUserData(); // TypedGenericDataRepresentationListUserData |  (optional) 

            try
            {
                // Add new Collaborator
                apiInstance.AddSpaceCollaborators(spaceId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpacesApi.AddSpaceCollaborators: " + e.Message );
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

<a name="createspace"></a>
# **CreateSpace**
> void CreateSpace (SpaceRepresentation body = null)

Create new Space

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateSpaceExample
    {
        public void main()
        {
            var apiInstance = new SpacesApi();
            var body = new SpaceRepresentation(); // SpaceRepresentation |  (optional) 

            try
            {
                // Create new Space
                apiInstance.CreateSpace(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpacesApi.CreateSpace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SpaceRepresentation**](SpaceRepresentation.md)|  | [optional] 

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
            var apiInstance = new SpacesApi();
            var spaceId = spaceId_example;  // string | Space Id

            try
            {
                // Delete space
                apiInstance.DeleteUserSpace(spaceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpacesApi.DeleteUserSpace: " + e.Message );
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

<a name="getspace"></a>
# **GetSpace**
> SpaceRepresentation GetSpace (string spaceId)

Return one Space

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSpaceExample
    {
        public void main()
        {
            var apiInstance = new SpacesApi();
            var spaceId = spaceId_example;  // string | Space Id

            try
            {
                // Return one Space
                SpaceRepresentation result = apiInstance.GetSpace(spaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpacesApi.GetSpace: " + e.Message );
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

<a name="getspacecollaborators"></a>
# **GetSpaceCollaborators**
> GenericDataRepresentationListUserData GetSpaceCollaborators (string spaceId, int? offset = null, int? limit = null)

Return list of Collaborators

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
            var apiInstance = new SpacesApi();
            var spaceId = spaceId_example;  // string | Space Id
            var offset = 56;  // int? | First result (optional)  (default to 0)
            var limit = 56;  // int? | Max results (optional)  (default to 10)

            try
            {
                // Return list of Collaborators
                GenericDataRepresentationListUserData result = apiInstance.GetSpaceCollaborators(spaceId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpacesApi.GetSpaceCollaborators: " + e.Message );
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

<a name="getspaces"></a>
# **GetSpaces**
> GenericDataRepresentationListSpaceData GetSpaces (string assignedId = null, string filterText = null, int? offset = null, int? limit = null)

Return list of Spaces

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSpacesExample
    {
        public void main()
        {
            var apiInstance = new SpacesApi();
            var assignedId = assignedId_example;  // string | Space Assigned Id (optional) 
            var filterText = filterText_example;  // string | Filter Text (optional) 
            var offset = 56;  // int? | First result (optional)  (default to 0)
            var limit = 56;  // int? | Max results (optional)  (default to 10)

            try
            {
                // Return list of Spaces
                GenericDataRepresentationListSpaceData result = apiInstance.GetSpaces(assignedId, filterText, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpacesApi.GetSpaces: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assignedId** | **string**| Space Assigned Id | [optional] 
 **filterText** | **string**| Filter Text | [optional] 
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

<a name="removespacecollaborators"></a>
# **RemoveSpaceCollaborators**
> void RemoveSpaceCollaborators (string spaceId, string userId)

Remove Collaborator

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
            var apiInstance = new SpacesApi();
            var spaceId = spaceId_example;  // string | Space Id
            var userId = userId_example;  // string | User Id

            try
            {
                // Remove Collaborator
                apiInstance.RemoveSpaceCollaborators(spaceId, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpacesApi.RemoveSpaceCollaborators: " + e.Message );
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
            var apiInstance = new SpacesApi();
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
                Debug.Print("Exception when calling SpacesApi.UpdateUserSpace: " + e.Message );
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

