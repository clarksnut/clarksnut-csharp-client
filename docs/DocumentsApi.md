# IO.Swagger.Api.DocumentsApi

All URIs are relative to *https://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadPdf**](DocumentsApi.md#downloadpdf) | **GET** /api/documents/{documentId}/print | Print Document
[**DownloadXml**](DocumentsApi.md#downloadxml) | **GET** /api/documents/{documentId}/download | Download Document
[**GetDocument**](DocumentsApi.md#getdocument) | **GET** /api/documents/{documentId} | Return one Document
[**GetDocuments**](DocumentsApi.md#getdocuments) | **GET** /api/documents | Return List of Documents
[**ImportDocument**](DocumentsApi.md#importdocument) | **POST** /api/documents | Import Document
[**SearchDocuments**](DocumentsApi.md#searchdocuments) | **POST** /api/documents/search | Search Document
[**UpdateDocument**](DocumentsApi.md#updatedocument) | **PUT** /api/documents/{documentId} | Update a Document


<a name="downloadpdf"></a>
# **DownloadPdf**
> void DownloadPdf (string documentId, string theme = null, string format = null)

Print Document

User need to have access to the Space owner of the document

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
            var apiInstance = new DocumentsApi();
            var documentId = documentId_example;  // string | Document Id
            var theme = theme_example;  // string | Theme (optional) 
            var format = format_example;  // string | format (optional)  (default to pdf)

            try
            {
                // Print Document
                apiInstance.DownloadPdf(documentId, theme, format);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DownloadPdf: " + e.Message );
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

<a name="downloadxml"></a>
# **DownloadXml**
> void DownloadXml (string documentId)

Download Document

User need to have access to the Space owner of the document

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DownloadXmlExample
    {
        public void main()
        {
            var apiInstance = new DocumentsApi();
            var documentId = documentId_example;  // string | Document Id

            try
            {
                // Download Document
                apiInstance.DownloadXml(documentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DownloadXml: " + e.Message );
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

<a name="getdocument"></a>
# **GetDocument**
> DocumentRepresentation GetDocument (string documentId)

Return one Document

User need to have access to the Space owner of the document

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
                // Return one Document
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
> GenericDataRepresentationListDocumentData GetDocuments (string filterText = null, int? offset = null, int? limit = null, List<string> space = null)

Return List of Documents

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
    public class GetDocumentsExample
    {
        public void main()
        {
            var apiInstance = new DocumentsApi();
            var filterText = filterText_example;  // string | Filter text (optional) 
            var offset = 56;  // int? | First result (optional)  (default to 0)
            var limit = 56;  // int? | Maz results (optional)  (default to 10)
            var space = new List<string>(); // List<string> | Space Ids (optional) 

            try
            {
                // Return List of Documents
                GenericDataRepresentationListDocumentData result = apiInstance.GetDocuments(filterText, offset, limit, space);
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

<a name="searchdocuments"></a>
# **SearchDocuments**
> GenericDataRepresentationListDocumentData SearchDocuments (DocumentQueryRepresentation body = null)

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

Update a Document

User need to have access to the Space owner of the document

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
                // Update a Document
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

