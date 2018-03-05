# IO.Swagger.Api.DocumentsApi

All URIs are relative to *https://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadDocumentPdf**](DocumentsApi.md#downloaddocumentpdf) | **GET** /api/documents/{documentId}/print | Print Document
[**DownloadDocumentXml**](DocumentsApi.md#downloaddocumentxml) | **GET** /api/documents/{documentId}/download | Download Document
[**GetDocument**](DocumentsApi.md#getdocument) | **GET** /api/documents/{documentId} | Return one Document
[**ImportDocument**](DocumentsApi.md#importdocument) | **POST** /api/documents | Import Document


<a name="downloaddocumentpdf"></a>
# **DownloadDocumentPdf**
> void DownloadDocumentPdf (string documentId, string theme = null, string locale = null, string format = null)

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
    public class DownloadDocumentPdfExample
    {
        public void main()
        {
            var apiInstance = new DocumentsApi();
            var documentId = documentId_example;  // string | Document Id
            var theme = theme_example;  // string | Theme (optional) 
            var locale = locale_example;  // string | Locale (optional) 
            var format = format_example;  // string | format (optional)  (default to pdf)

            try
            {
                // Print Document
                apiInstance.DownloadDocumentPdf(documentId, theme, locale, format);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DownloadDocumentPdf: " + e.Message );
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
 **locale** | **string**| Locale | [optional] 
 **format** | **string**| format | [optional] [default to pdf]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloaddocumentxml"></a>
# **DownloadDocumentXml**
> void DownloadDocumentXml (string documentId)

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
    public class DownloadDocumentXmlExample
    {
        public void main()
        {
            var apiInstance = new DocumentsApi();
            var documentId = documentId_example;  // string | Document Id

            try
            {
                // Download Document
                apiInstance.DownloadDocumentXml(documentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DownloadDocumentXml: " + e.Message );
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

<a name="importdocument"></a>
# **ImportDocument**
> void ImportDocument (MultipartFormDataInput body = null)

Import Document

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

