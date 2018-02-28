# IO.Swagger.Api.DocumentsApi

All URIs are relative to *https://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDocument**](DocumentsApi.md#getdocument) | **GET** /api/documents/{documentId} | Get Document
[**GetDocuments**](DocumentsApi.md#getdocuments) | **GET** /api/documents | Get Documents
[**GetXml**](DocumentsApi.md#getxml) | **GET** /api/documents/{documentId}/download | Download Document
[**ImportDocument**](DocumentsApi.md#importdocument) | **POST** /api/documents | Import Document
[**PrintDocument**](DocumentsApi.md#printdocument) | **GET** /api/documents/{documentId}/print | Print Document
[**SearchDocuments**](DocumentsApi.md#searchdocuments) | **POST** /api/documents/search | Search Document
[**UpdateDocument**](DocumentsApi.md#updatedocument) | **PUT** /api/documents/{documentId} | Update Document


<a name="getdocument"></a>
# **GetDocument**
> DocumentRepresentation GetDocument (string documentId)

Get Document

This will return a document

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDocumentExample
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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentId** | **string**| Document Id | 

### Return type

[**DocumentRepresentation**](DocumentRepresentation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocuments"></a>
# **GetDocuments**
> GenericDataRepresentationListDocumentData GetDocuments (string q = null, int? offset = null, int? limit = null, List<string> space = null)

Get Documents

This will search just on Owned and Collaborated Spaces

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDocumentsExample
    {
        public void main()
        {
            var apiInstance = new DocumentsApi();
            var q = q_example;  // string | A text for filter results (optional) 
            var offset = 56;  // int? | The first position of array results (optional)  (default to 0)
            var limit = 56;  // int? | The max number of results (optional)  (default to 10)
            var space = new List<string>(); // List<string> | List of space ids to search in. If null or empty all allowed spaces of user will be used (optional) 

            try
            {
                // Get Documents
                GenericDataRepresentationListDocumentData result = apiInstance.GetDocuments(q, offset, limit, space);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.GetDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| A text for filter results | [optional] 
 **offset** | **int?**| The first position of array results | [optional] [default to 0]
 **limit** | **int?**| The max number of results | [optional] [default to 10]
 **space** | [**List&lt;string&gt;**](string.md)| List of space ids to search in. If null or empty all allowed spaces of user will be used | [optional] 

### Return type

[**GenericDataRepresentationListDocumentData**](GenericDataRepresentationListDocumentData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getxml"></a>
# **GetXml**
> void GetXml (string documentId)

Download Document

This will download the document

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetXmlExample
    {
        public void main()
        {
            var apiInstance = new DocumentsApi();
            var documentId = documentId_example;  // string | Document Id

            try
            {
                // Download Document
                apiInstance.GetXml(documentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.GetXml: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentId** | **string**| Document Id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importdocument"></a>
# **ImportDocument**
> void ImportDocument (MultipartFormDataInput body = null)

Import Document

This will import xml or compressed files

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportDocumentExample
    {
        public void main()
        {
            var apiInstance = new DocumentsApi();
            var body = new MultipartFormDataInput(); // MultipartFormDataInput |  (optional) 

            try
            {
                // Import Document
                apiInstance.ImportDocument(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.ImportDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MultipartFormDataInput**](MultipartFormDataInput.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="printdocument"></a>
# **PrintDocument**
> void PrintDocument (string documentId, string theme = null, string format = null)

Print Document

This will print the document

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrintDocumentExample
    {
        public void main()
        {
            var apiInstance = new DocumentsApi();
            var documentId = documentId_example;  // string | Document Id
            var theme = theme_example;  // string | Theme (optional) 
            var format = format_example;  // string | format (optional)  (default to pdf)

            try
            {
                // Print Document
                apiInstance.PrintDocument(documentId, theme, format);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.PrintDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="searchdocuments"></a>
# **SearchDocuments**
> GenericDataRepresentationListDocumentData SearchDocuments (DocumentQueryRepresentation body = null)

Search Document

This will search document in advanced mode

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchDocumentsExample
    {
        public void main()
        {
            var apiInstance = new DocumentsApi();
            var body = new DocumentQueryRepresentation(); // DocumentQueryRepresentation |  (optional) 

            try
            {
                // Search Document
                GenericDataRepresentationListDocumentData result = apiInstance.SearchDocuments(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.SearchDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentQueryRepresentation**](DocumentQueryRepresentation.md)|  | [optional] 

### Return type

[**GenericDataRepresentationListDocumentData**](GenericDataRepresentationListDocumentData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedocument"></a>
# **UpdateDocument**
> DocumentRepresentation UpdateDocument (string documentId, DocumentRepresentation body = null)

Update Document

This will update the document just for current user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateDocumentExample
    {
        public void main()
        {
            var apiInstance = new DocumentsApi();
            var documentId = documentId_example;  // string | Document Id
            var body = new DocumentRepresentation(); // DocumentRepresentation |  (optional) 

            try
            {
                // Update Document
                DocumentRepresentation result = apiInstance.UpdateDocument(documentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.UpdateDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

