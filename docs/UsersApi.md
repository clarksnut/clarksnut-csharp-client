# IO.Swagger.Api.UsersApi

All URIs are relative to *https://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddSpaceCollaborators**](UsersApi.md#addspacecollaborators) | **POST** /api/users/{userId}/spaces/{spaceId}/collaborators | Add new Collaborator
[**DeleteUserSpace**](UsersApi.md#deleteuserspace) | **DELETE** /api/users/{userId}/spaces/{spaceId} | Delete space
[**DownloadPdf**](UsersApi.md#downloadpdf) | **GET** /api/users/{userId}/documents/{documentId}/print | Print Document
[**DownloadUserDocumentXml**](UsersApi.md#downloaduserdocumentxml) | **GET** /api/users/{userId}/documents/{documentId}/download | Download Document
[**GetNotifications**](UsersApi.md#getnotifications) | **GET** /api/users/{userId}/notifications | Get Notifications
[**GetParties**](UsersApi.md#getparties) | **GET** /api/users/{userId}/parties | Get parties
[**GetUser**](UsersApi.md#getuser) | **GET** /api/users/{userId} | Return One User
[**GetUserDocument**](UsersApi.md#getuserdocument) | **GET** /api/users/{userId}/documents/{documentId} | Return one Document
[**GetUserDocuments**](UsersApi.md#getuserdocuments) | **GET** /api/users/{userId}/documents | Return List of Documents
[**GetUserSpace**](UsersApi.md#getuserspace) | **GET** /api/users/{userId}/spaces/{spaceId} | Return one Space
[**GetUserSpaceCollaborators**](UsersApi.md#getuserspacecollaborators) | **GET** /api/users/{userId}/spaces/{spaceId}/collaborators | Return list of Collaborators
[**GetUserSpaceRequestAccess**](UsersApi.md#getuserspacerequestaccess) | **GET** /api/users/{userId}/spaces/{spaceId}/request-access | Get Notifications
[**GetUserSpaces**](UsersApi.md#getuserspaces) | **GET** /api/users/{userId}/spaces | Return allowed Spaces of User
[**GetUsers**](UsersApi.md#getusers) | **GET** /api/users | Return List of Users
[**RemoveSpaceCollaborators**](UsersApi.md#removespacecollaborators) | **DELETE** /api/users/{userId}/spaces/{spaceId}/collaborators/{collaboratorId} | Remove Collaborator
[**SearchUserDocuments**](UsersApi.md#searchuserdocuments) | **POST** /api/users/{userId}/documents/search | Search Document
[**UpdateUser**](UsersApi.md#updateuser) | **PUT** /api/users/{userId} | Update User
[**UpdateUserDocument**](UsersApi.md#updateuserdocument) | **PUT** /api/users/{userId}/documents/{documentId} | Update a Document
[**UpdateUserSpace**](UsersApi.md#updateuserspace) | **PUT** /api/users/{userId}/spaces/{spaceId} | Update space


<a name="addspacecollaborators"></a>
# **AddSpaceCollaborators**
> void AddSpaceCollaborators (string userId, string spaceId, TypedGenericDataRepresentationListUserData body = null)

Add new Collaborator

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
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User Id
            var spaceId = spaceId_example;  // string | Space Id
            var body = new TypedGenericDataRepresentationListUserData(); // TypedGenericDataRepresentationListUserData |  (optional) 

            try
            {
                // Add new Collaborator
                apiInstance.AddSpaceCollaborators(userId, spaceId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.AddSpaceCollaborators: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User Id | 
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
> void DeleteUserSpace (string userId, string spaceId)

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
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User Id
            var spaceId = spaceId_example;  // string | Space Id

            try
            {
                // Delete space
                apiInstance.DeleteUserSpace(userId, spaceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserSpace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User Id | 
 **spaceId** | **string**| Space Id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadpdf"></a>
# **DownloadPdf**
> void DownloadPdf (string userId, string documentId, string theme = null, string format = null)

Print Document

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DownloadPdfExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User Id
            var documentId = documentId_example;  // string | Document Id
            var theme = theme_example;  // string | Theme (optional) 
            var format = format_example;  // string | format (optional)  (default to pdf)

            try
            {
                // Print Document
                apiInstance.DownloadPdf(userId, documentId, theme, format);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DownloadPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User Id | 
 **documentId** | **string**| Document Id | 
 **theme** | **string**| Theme | [optional] 
 **format** | **string**| format | [optional] [default to pdf]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloaduserdocumentxml"></a>
# **DownloadUserDocumentXml**
> void DownloadUserDocumentXml (string userId, string documentId)

Download Document

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DownloadUserDocumentXmlExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User Id
            var documentId = documentId_example;  // string | Document Id

            try
            {
                // Download Document
                apiInstance.DownloadUserDocumentXml(userId, documentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DownloadUserDocumentXml: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User Id | 
 **documentId** | **string**| Document Id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnotifications"></a>
# **GetNotifications**
> NotificationsRepresentation GetNotifications (string userId, List<string> space = null, string status = null)

Get Notifications

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetNotificationsExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User Id
            var space = new List<string>(); // List<string> | Space Ids (optional) 
            var status = status_example;  // string | Status (optional)  (default to pending)

            try
            {
                // Get Notifications
                NotificationsRepresentation result = apiInstance.GetNotifications(userId, space, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetNotifications: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User Id | 
 **space** | [**List&lt;string&gt;**](string.md)| Space Ids | [optional] 
 **status** | **string**| Status | [optional] [default to pending]

### Return type

[**NotificationsRepresentation**](NotificationsRepresentation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparties"></a>
# **GetParties**
> GenericDataRepresentationListPartyData GetParties (string userId, string filterText = null, int? offset = null, int? limit = null, List<string> space = null)

Get parties

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPartiesExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User Id
            var filterText = filterText_example;  // string | Filter Text (optional) 
            var offset = 56;  // int? | First result (optional)  (default to 0)
            var limit = 56;  // int? | Max result (optional)  (default to 10)
            var space = new List<string>(); // List<string> | Space Ids (optional) 

            try
            {
                // Get parties
                GenericDataRepresentationListPartyData result = apiInstance.GetParties(userId, filterText, offset, limit, space);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetParties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User Id | 
 **filterText** | **string**| Filter Text | [optional] 
 **offset** | **int?**| First result | [optional] [default to 0]
 **limit** | **int?**| Max result | [optional] [default to 10]
 **space** | [**List&lt;string&gt;**](string.md)| Space Ids | [optional] 

### Return type

[**GenericDataRepresentationListPartyData**](GenericDataRepresentationListPartyData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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

<a name="getuserdocument"></a>
# **GetUserDocument**
> DocumentRepresentation GetUserDocument (string userId, string documentId)

Return one Document

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserDocumentExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User Id
            var documentId = documentId_example;  // string | Document Id

            try
            {
                // Return one Document
                DocumentRepresentation result = apiInstance.GetUserDocument(userId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User Id | 
 **documentId** | **string**| Document Id | 

### Return type

[**DocumentRepresentation**](DocumentRepresentation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserdocuments"></a>
# **GetUserDocuments**
> GenericDataRepresentationListDocumentData GetUserDocuments (string userId, string filterText = null, int? offset = null, int? limit = null, List<string> space = null)

Return List of Documents

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserDocumentsExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User Id
            var filterText = filterText_example;  // string | Filter text (optional) 
            var offset = 56;  // int? | First result (optional)  (default to 0)
            var limit = 56;  // int? | Maz results (optional)  (default to 10)
            var space = new List<string>(); // List<string> | Space Ids (optional) 

            try
            {
                // Return List of Documents
                GenericDataRepresentationListDocumentData result = apiInstance.GetUserDocuments(userId, filterText, offset, limit, space);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User Id | 
 **filterText** | **string**| Filter text | [optional] 
 **offset** | **int?**| First result | [optional] [default to 0]
 **limit** | **int?**| Maz results | [optional] [default to 10]
 **space** | [**List&lt;string&gt;**](string.md)| Space Ids | [optional] 

### Return type

[**GenericDataRepresentationListDocumentData**](GenericDataRepresentationListDocumentData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserspace"></a>
# **GetUserSpace**
> SpaceRepresentation GetUserSpace (string userId, string spaceId)

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
    public class GetUserSpaceExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User Id
            var spaceId = spaceId_example;  // string | Space Id

            try
            {
                // Return one Space
                SpaceRepresentation result = apiInstance.GetUserSpace(userId, spaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserSpace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User Id | 
 **spaceId** | **string**| Space Id | 

### Return type

[**SpaceRepresentation**](SpaceRepresentation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserspacecollaborators"></a>
# **GetUserSpaceCollaborators**
> GenericDataRepresentationListUserData GetUserSpaceCollaborators (string userId, string spaceId, int? offset = null, int? limit = null)

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
    public class GetUserSpaceCollaboratorsExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User Id
            var spaceId = spaceId_example;  // string | Space Id
            var offset = 56;  // int? | First result (optional)  (default to 0)
            var limit = 56;  // int? | Max results (optional)  (default to 10)

            try
            {
                // Return list of Collaborators
                GenericDataRepresentationListUserData result = apiInstance.GetUserSpaceCollaborators(userId, spaceId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserSpaceCollaborators: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User Id | 
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

<a name="getuserspacerequestaccess"></a>
# **GetUserSpaceRequestAccess**
> GenericDataRepresentationListRequestData GetUserSpaceRequestAccess (string userId, string spaceId, string status = null)

Get Notifications

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserSpaceRequestAccessExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User Id
            var spaceId = spaceId_example;  // string | Space Id
            var status = status_example;  // string | Status (optional)  (default to pending)

            try
            {
                // Get Notifications
                GenericDataRepresentationListRequestData result = apiInstance.GetUserSpaceRequestAccess(userId, spaceId, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserSpaceRequestAccess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User Id | 
 **spaceId** | **string**| Space Id | 
 **status** | **string**| Status | [optional] [default to pending]

### Return type

[**GenericDataRepresentationListRequestData**](GenericDataRepresentationListRequestData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserspaces"></a>
# **GetUserSpaces**
> GenericDataRepresentationListSpaceData GetUserSpaces (string userId, string role = null, int? offset = null, int? limit = null)

Return allowed Spaces of User

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
            var apiInstance = new UsersApi();
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
                Debug.Print("Exception when calling UsersApi.GetUserSpaces: " + e.Message );
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

<a name="removespacecollaborators"></a>
# **RemoveSpaceCollaborators**
> void RemoveSpaceCollaborators (string userId, string spaceId, string collaboratorId)

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
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User Id
            var spaceId = spaceId_example;  // string | Space Id
            var collaboratorId = collaboratorId_example;  // string | User Id

            try
            {
                // Remove Collaborator
                apiInstance.RemoveSpaceCollaborators(userId, spaceId, collaboratorId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.RemoveSpaceCollaborators: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User Id | 
 **spaceId** | **string**| Space Id | 
 **collaboratorId** | **string**| User Id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchuserdocuments"></a>
# **SearchUserDocuments**
> GenericDataRepresentationListDocumentData SearchUserDocuments (string userId, DocumentQueryRepresentation body = null)

Search Document

Search on allowed user (session) spaces

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchUserDocumentsExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User Id
            var body = new DocumentQueryRepresentation(); // DocumentQueryRepresentation |  (optional) 

            try
            {
                // Search Document
                GenericDataRepresentationListDocumentData result = apiInstance.SearchUserDocuments(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.SearchUserDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User Id | 
 **body** | [**DocumentQueryRepresentation**](DocumentQueryRepresentation.md)|  | [optional] 

### Return type

[**GenericDataRepresentationListDocumentData**](GenericDataRepresentationListDocumentData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuser"></a>
# **UpdateUser**
> UserRepresentation UpdateUser (string userId, UserRepresentation body = null)

Update User

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User Id
            var body = new UserRepresentation(); // UserRepresentation |  (optional) 

            try
            {
                // Update User
                UserRepresentation result = apiInstance.UpdateUser(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User Id | 
 **body** | [**UserRepresentation**](UserRepresentation.md)|  | [optional] 

### Return type

[**UserRepresentation**](UserRepresentation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuserdocument"></a>
# **UpdateUserDocument**
> DocumentRepresentation UpdateUserDocument (string userId, string documentId, DocumentRepresentation body = null)

Update a Document

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUserDocumentExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User Id
            var documentId = documentId_example;  // string | Document Id
            var body = new DocumentRepresentation(); // DocumentRepresentation |  (optional) 

            try
            {
                // Update a Document
                DocumentRepresentation result = apiInstance.UpdateUserDocument(userId, documentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUserDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User Id | 
 **documentId** | **string**| Document Id | 
 **body** | [**DocumentRepresentation**](DocumentRepresentation.md)|  | [optional] 

### Return type

[**DocumentRepresentation**](DocumentRepresentation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuserspace"></a>
# **UpdateUserSpace**
> SpaceRepresentation UpdateUserSpace (string userId, string spaceId, SpaceRepresentation body = null)

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
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | User Id
            var spaceId = spaceId_example;  // string | Space Id
            var body = new SpaceRepresentation(); // SpaceRepresentation |  (optional) 

            try
            {
                // Update space
                SpaceRepresentation result = apiInstance.UpdateUserSpace(userId, spaceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUserSpace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User Id | 
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

