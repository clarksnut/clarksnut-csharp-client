# IO.Swagger - the C# library for the Clarksnut

Clarksnut UBL collector

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.2.0-SNAPSHOT
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Swagger.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            var apiInstance = new DocumentsApi();
            var documentId = documentId_example;  // string | Document Id

            try
            {
                // Get Document
                DocumentRepresentation result = apiInstance.GetDocument(documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.GetDocument: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://localhost:8080*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DocumentsApi* | [**GetDocument**](docs/DocumentsApi.md#getdocument) | **GET** /api/documents/{documentId} | Get Document
*DocumentsApi* | [**GetDocuments**](docs/DocumentsApi.md#getdocuments) | **GET** /api/documents | Get Documents
*DocumentsApi* | [**GetXml**](docs/DocumentsApi.md#getxml) | **GET** /api/documents/{documentId}/download | Download Document
*DocumentsApi* | [**ImportDocument**](docs/DocumentsApi.md#importdocument) | **POST** /api/documents | Import Document
*DocumentsApi* | [**PrintDocument**](docs/DocumentsApi.md#printdocument) | **GET** /api/documents/{documentId}/print | Print Document
*DocumentsApi* | [**SearchDocuments**](docs/DocumentsApi.md#searchdocuments) | **POST** /api/documents/search | Search Document
*DocumentsApi* | [**UpdateDocument**](docs/DocumentsApi.md#updatedocument) | **PUT** /api/documents/{documentId} | Update Document
*NamespacesApi* | [**AddSpaceCollaborators**](docs/NamespacesApi.md#addspacecollaborators) | **POST** /api/namespaces/{spaceId}/collaborators | Add Space SpaceCollaborators
*NamespacesApi* | [**DeleteUserSpace**](docs/NamespacesApi.md#deleteuserspace) | **DELETE** /api/namespaces/{spaceId} | Delete space
*NamespacesApi* | [**GetSpaceCollaborators**](docs/NamespacesApi.md#getspacecollaborators) | **GET** /api/namespaces/{spaceId}/collaborators | Get Space SpaceCollaborators
*NamespacesApi* | [**GetUserSpace**](docs/NamespacesApi.md#getuserspace) | **GET** /api/namespaces/{spaceId} | Get Space
*NamespacesApi* | [**GetUserSpaces**](docs/NamespacesApi.md#getuserspaces) | **GET** /api/namespaces | Get Spaces of user
*NamespacesApi* | [**RemoveSpaceCollaborators**](docs/NamespacesApi.md#removespacecollaborators) | **DELETE** /api/namespaces/{spaceId}/collaborators/{userId} | Remove Space SpaceCollaborators
*NamespacesApi* | [**UpdateUserSpace**](docs/NamespacesApi.md#updateuserspace) | **PUT** /api/namespaces/{spaceId} | Update space
*PartiesApi* | [**GetParties**](docs/PartiesApi.md#getparties) | **GET** /api/parties | Get parties
*ProfileApi* | [**CurrentUser**](docs/ProfileApi.md#currentuser) | **PUT** /api/profile | Update User Profile
*ProfileApi* | [**GetCurrentUser**](docs/ProfileApi.md#getcurrentuser) | **GET** /api/profile | Return User Profile
*RequestAccessApi* | [**GetRequestAccess**](docs/RequestAccessApi.md#getrequestaccess) | **GET** /api/request-access | Get Request accesses
*RequestAccessApi* | [**RequestAccessToSpace**](docs/RequestAccessApi.md#requestaccesstospace) | **POST** /api/request-access | Request access
*RequestAccessApi* | [**UpdateAccessSpace**](docs/RequestAccessApi.md#updateaccessspace) | **PUT** /api/request-access/{requestId} | Update request
*SpacesApi* | [**CreateSpace**](docs/SpacesApi.md#createspace) | **POST** /api/spaces | Create Space
*SpacesApi* | [**GetSpace**](docs/SpacesApi.md#getspace) | **GET** /api/spaces/{spaceId} | Get Space
*SpacesApi* | [**GetSpaces**](docs/SpacesApi.md#getspaces) | **GET** /api/spaces | Get Spaces
*UsersApi* | [**GetUser**](docs/UsersApi.md#getuser) | **GET** /api/users/{userId} | Get User
*UsersApi* | [**GetUsers**](docs/UsersApi.md#getusers) | **GET** /api/users | Get Users


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.DocumentAttributes](docs/DocumentAttributes.md)
 - [Model.DocumentData](docs/DocumentData.md)
 - [Model.DocumentLink](docs/DocumentLink.md)
 - [Model.DocumentOwnedBy](docs/DocumentOwnedBy.md)
 - [Model.DocumentQueryAttributes](docs/DocumentQueryAttributes.md)
 - [Model.DocumentQueryData](docs/DocumentQueryData.md)
 - [Model.DocumentQueryRepresentation](docs/DocumentQueryRepresentation.md)
 - [Model.DocumentRelationships](docs/DocumentRelationships.md)
 - [Model.DocumentRepresentation](docs/DocumentRepresentation.md)
 - [Model.GenericDataRepresentation](docs/GenericDataRepresentation.md)
 - [Model.GenericDataRepresentationListDocumentData](docs/GenericDataRepresentationListDocumentData.md)
 - [Model.GenericDataRepresentationListPartyData](docs/GenericDataRepresentationListPartyData.md)
 - [Model.GenericDataRepresentationListRequestData](docs/GenericDataRepresentationListRequestData.md)
 - [Model.GenericDataRepresentationListSpaceData](docs/GenericDataRepresentationListSpaceData.md)
 - [Model.GenericDataRepresentationListUserData](docs/GenericDataRepresentationListUserData.md)
 - [Model.GenericLinksRepresentation](docs/GenericLinksRepresentation.md)
 - [Model.InputPart](docs/InputPart.md)
 - [Model.MediaType](docs/MediaType.md)
 - [Model.MultipartFormDataInput](docs/MultipartFormDataInput.md)
 - [Model.PartyAttributes](docs/PartyAttributes.md)
 - [Model.PartyData](docs/PartyData.md)
 - [Model.RequestAttributes](docs/RequestAttributes.md)
 - [Model.RequestData](docs/RequestData.md)
 - [Model.RequestRepresentation](docs/RequestRepresentation.md)
 - [Model.SpaceAttributes](docs/SpaceAttributes.md)
 - [Model.SpaceCollaborators](docs/SpaceCollaborators.md)
 - [Model.SpaceData](docs/SpaceData.md)
 - [Model.SpaceOwnedBy](docs/SpaceOwnedBy.md)
 - [Model.SpaceRelationships](docs/SpaceRelationships.md)
 - [Model.SpaceRepresentation](docs/SpaceRepresentation.md)
 - [Model.TypedGenericDataRepresentation](docs/TypedGenericDataRepresentation.md)
 - [Model.TypedGenericDataRepresentationListUserData](docs/TypedGenericDataRepresentationListUserData.md)
 - [Model.UserAttributesRepresentation](docs/UserAttributesRepresentation.md)
 - [Model.UserData](docs/UserData.md)
 - [Model.UserRepresentation](docs/UserRepresentation.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
