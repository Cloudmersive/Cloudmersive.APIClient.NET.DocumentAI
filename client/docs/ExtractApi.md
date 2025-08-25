# Cloudmersive.APIClient.NET.DocumentAI.Api.ExtractApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExtractClassification**](ExtractApi.md#extractclassification) | **POST** /document-ai/document/extract/classify | Extract Classification or Category from a Document using AI
[**ExtractFields**](ExtractApi.md#extractfields) | **POST** /document-ai/document/extract/fields | Extract Field Values from a Document using AI
[**ExtractFieldsAdvanced**](ExtractApi.md#extractfieldsadvanced) | **POST** /document-ai/document/extract/fields/advanced | Extract Field Values from a Document using Advanced AI
[**ExtractSummary**](ExtractApi.md#extractsummary) | **POST** /document-ai/document/extract/summary | Extract Summary from a Document using AI
[**ExtractTables**](ExtractApi.md#extracttables) | **POST** /document-ai/document/extract/tables | Extract Tables of Data from a Document using AI


<a name="extractclassification"></a>
# **ExtractClassification**
> DocumentClassificationResult ExtractClassification (string categories = null, System.IO.Stream inputFile = null)

Extract Classification or Category from a Document using AI

Extract Classification or Category (e.g. Invoice, Receipt, Tax Form, or Form 1040, Form 1040 EZ, etc.) from a document using AI.  Input document formats supported include DOCX, PDF, PNG and JPG.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAI.Api;
using Cloudmersive.APIClient.NET.DocumentAI.Client;
using Cloudmersive.APIClient.NET.DocumentAI.Model;

namespace Example
{
    public class ExtractClassificationExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ExtractApi();
            var categories = categories_example;  // string | Desired classification to extract (optional) 
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input document, or photos of a document, to extract data from (optional) 

            try
            {
                // Extract Classification or Category from a Document using AI
                DocumentClassificationResult result = apiInstance.ExtractClassification(categories, inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtractApi.ExtractClassification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categories** | **string**| Desired classification to extract | [optional] 
 **inputFile** | **System.IO.Stream**| Input document, or photos of a document, to extract data from | [optional] 

### Return type

[**DocumentClassificationResult**](DocumentClassificationResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="extractfields"></a>
# **ExtractFields**
> ExtractFieldsResponse ExtractFields (string fieldNames = null, System.IO.Stream inputFile = null)

Extract Field Values from a Document using AI

Extract Field Values (e.g. Invoice Number, Invoice Date, Business Card Phone Number, etc.) from a document using AI.  Input document formats supported include DOCX, PDF, PNG and JPG.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAI.Api;
using Cloudmersive.APIClient.NET.DocumentAI.Client;
using Cloudmersive.APIClient.NET.DocumentAI.Model;

namespace Example
{
    public class ExtractFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ExtractApi();
            var fieldNames = fieldNames_example;  // string | Desired fields to extract (optional) 
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input document, or photos of a document, to extract data from (optional) 

            try
            {
                // Extract Field Values from a Document using AI
                ExtractFieldsResponse result = apiInstance.ExtractFields(fieldNames, inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtractApi.ExtractFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fieldNames** | **string**| Desired fields to extract | [optional] 
 **inputFile** | **System.IO.Stream**| Input document, or photos of a document, to extract data from | [optional] 

### Return type

[**ExtractFieldsResponse**](ExtractFieldsResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="extractfieldsadvanced"></a>
# **ExtractFieldsAdvanced**
> ExtractFieldsResponse ExtractFieldsAdvanced (AdvancedExtractFieldsRequest body = null)

Extract Field Values from a Document using Advanced AI

Extract Field Values (e.g. Invoice Number, Invoice Date, Business Card Phone Number, etc.) from a document using Advanced AI.  Input document formats supported include DOCX, PDF, PNG and JPG.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAI.Api;
using Cloudmersive.APIClient.NET.DocumentAI.Client;
using Cloudmersive.APIClient.NET.DocumentAI.Model;

namespace Example
{
    public class ExtractFieldsAdvancedExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ExtractApi();
            var body = new AdvancedExtractFieldsRequest(); // AdvancedExtractFieldsRequest | Input request, including document file as byte array, and information on which fields to extract (optional) 

            try
            {
                // Extract Field Values from a Document using Advanced AI
                ExtractFieldsResponse result = apiInstance.ExtractFieldsAdvanced(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtractApi.ExtractFieldsAdvanced: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AdvancedExtractFieldsRequest**](AdvancedExtractFieldsRequest.md)| Input request, including document file as byte array, and information on which fields to extract | [optional] 

### Return type

[**ExtractFieldsResponse**](ExtractFieldsResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="extractsummary"></a>
# **ExtractSummary**
> SummarizeDocumentResponse ExtractSummary (System.IO.Stream inputFile = null)

Extract Summary from a Document using AI

Creates a 1 paragraph summary of the input document using Artificial Intelligence.  Input document formats supported include DOCX, PDF, PNG and JPG.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAI.Api;
using Cloudmersive.APIClient.NET.DocumentAI.Client;
using Cloudmersive.APIClient.NET.DocumentAI.Model;

namespace Example
{
    public class ExtractSummaryExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ExtractApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input document, or photos of a document, to extract data from (optional) 

            try
            {
                // Extract Summary from a Document using AI
                SummarizeDocumentResponse result = apiInstance.ExtractSummary(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtractApi.ExtractSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input document, or photos of a document, to extract data from | [optional] 

### Return type

[**SummarizeDocumentResponse**](SummarizeDocumentResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="extracttables"></a>
# **ExtractTables**
> ExtractFieldsResponse ExtractTables (System.IO.Stream inputFile = null)

Extract Tables of Data from a Document using AI

Extract Tables, comprised of rows and columns of data, from a document using AI.  Input document formats supported include DOCX, PDF, PNG and JPG.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAI.Api;
using Cloudmersive.APIClient.NET.DocumentAI.Client;
using Cloudmersive.APIClient.NET.DocumentAI.Model;

namespace Example
{
    public class ExtractTablesExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ExtractApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input document, or photos of a document, to extract data from (optional) 

            try
            {
                // Extract Tables of Data from a Document using AI
                ExtractFieldsResponse result = apiInstance.ExtractTables(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtractApi.ExtractTables: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input document, or photos of a document, to extract data from | [optional] 

### Return type

[**ExtractFieldsResponse**](ExtractFieldsResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

