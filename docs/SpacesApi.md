# IO.Swagger.Api.SpacesApi

All URIs are relative to *https://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSpace**](SpacesApi.md#createspace) | **POST** /api/spaces | Create Space
[**GetSpace**](SpacesApi.md#getspace) | **GET** /api/spaces/{spaceId} | Get Space
[**GetSpaces**](SpacesApi.md#getspaces) | **GET** /api/spaces | Get Spaces


<a name="createspace"></a>
# **CreateSpace**
> void CreateSpace (SpaceRepresentation body = null)

Create Space

This will create a space. [user] role required

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
                // Create Space
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

<a name="getspace"></a>
# **GetSpace**
> SpaceRepresentation GetSpace (string spaceId)

Get Space

This will get a space. [view-spaces] role required

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
                // Get Space
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

<a name="getspaces"></a>
# **GetSpaces**
> GenericDataRepresentationListSpaceData GetSpaces (string assignedId = null, string q = null, int? offset = null, int? limit = null)

Get Spaces

This will search spaces. [view-spaces] role required

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
            var q = q_example;  // string | Full text search value (optional)  (default to *)
            var offset = 56;  // int? | First result (optional)  (default to 0)
            var limit = 56;  // int? | Max results (optional)  (default to 10)

            try
            {
                // Get Spaces
                GenericDataRepresentationListSpaceData result = apiInstance.GetSpaces(assignedId, q, offset, limit);
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
 **q** | **string**| Full text search value | [optional] [default to *]
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

