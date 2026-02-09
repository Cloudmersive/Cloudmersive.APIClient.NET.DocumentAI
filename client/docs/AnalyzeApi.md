# Cloudmersive.APIClient.NET.DocumentAI.Api.AnalyzeApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApplyRules**](AnalyzeApi.md#applyrules) | **POST** /document-ai/document/analyze/enforce-policy | Enforce Policies to a Document to allow or block it using Advanced AI |

<a id="applyrules"></a>
# **ApplyRules**
> DocumentPolicyResult ApplyRules (DocumentPolicyRequest body = null)

Enforce Policies to a Document to allow or block it using Advanced AI

Enforce Policies to a Document to allow or block it using Advanced AI.  Input document formats supported include DOCX, PDF, PNG and JPG.  Consumes 100 API calls per page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Cloudmersive.APIClient.NET.DocumentAI.Api;
using Cloudmersive.APIClient.NET.DocumentAI.Client;
using Cloudmersive.APIClient.NET.DocumentAI.Model;

namespace Example
{
    public class ApplyRulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Apikey
            config.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Apikey", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AnalyzeApi(httpClient, config, httpClientHandler);
            var body = new DocumentPolicyRequest(); // DocumentPolicyRequest | Input request, including document and policy rules (optional) 

            try
            {
                // Enforce Policies to a Document to allow or block it using Advanced AI
                DocumentPolicyResult result = apiInstance.ApplyRules(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnalyzeApi.ApplyRules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApplyRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Enforce Policies to a Document to allow or block it using Advanced AI
    ApiResponse<DocumentPolicyResult> response = apiInstance.ApplyRulesWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AnalyzeApi.ApplyRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**DocumentPolicyRequest**](DocumentPolicyRequest.md) | Input request, including document and policy rules | [optional]  |

### Return type

[**DocumentPolicyResult**](DocumentPolicyResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

