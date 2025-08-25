# Cloudmersive.APIClient.NET.DocumentAI.Api.AnalyzeApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplyRules**](AnalyzeApi.md#applyrules) | **POST** /document-ai/document/analyze/enforce-policy | Enforce Policies to a Document to allow or block it using Advanced AI


<a name="applyrules"></a>
# **ApplyRules**
> DocumentPolicyResult ApplyRules (DocumentPolicyRequest body = null)

Enforce Policies to a Document to allow or block it using Advanced AI

Enforce Policies to a Document to allow or block it using Advanced AI.  Input document formats supported include DOCX, PDF, PNG and JPG.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAI.Api;
using Cloudmersive.APIClient.NET.DocumentAI.Client;
using Cloudmersive.APIClient.NET.DocumentAI.Model;

namespace Example
{
    public class ApplyRulesExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AnalyzeApi();
            var body = new DocumentPolicyRequest(); // DocumentPolicyRequest | Input request, including document and policy rules (optional) 

            try
            {
                // Enforce Policies to a Document to allow or block it using Advanced AI
                DocumentPolicyResult result = apiInstance.ApplyRules(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyzeApi.ApplyRules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocumentPolicyRequest**](DocumentPolicyRequest.md)| Input request, including document and policy rules | [optional] 

### Return type

[**DocumentPolicyResult**](DocumentPolicyResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

