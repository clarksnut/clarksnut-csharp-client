# IO.Swagger.Api.PartiesApi

All URIs are relative to *https://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetParties**](PartiesApi.md#getparties) | **GET** /api/parties | Get parties


<a name="getparties"></a>
# **GetParties**
> GenericDataRepresentationListPartyData GetParties (string filterText = null, int? offset = null, int? limit = null, List<string> space = null)

Get parties

This will search parties on allowed spaces and current user

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
            var apiInstance = new PartiesApi();
            var filterText = filterText_example;  // string | Filter Text (optional) 
            var offset = 56;  // int? | First result (optional)  (default to 0)
            var limit = 56;  // int? | Max result (optional)  (default to 10)
            var space = new List<string>(); // List<string> | Space Ids (optional) 

            try
            {
                // Get parties
                GenericDataRepresentationListPartyData result = apiInstance.GetParties(filterText, offset, limit, space);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartiesApi.GetParties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

