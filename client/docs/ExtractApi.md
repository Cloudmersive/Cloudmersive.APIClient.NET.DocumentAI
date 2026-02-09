# Cloudmersive.APIClient.NET.DocumentAI.Api.ExtractApi

All URIs are relative to *https://api.cloudmersive.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ExtractAllFieldsAndTables**](ExtractApi.md#extractallfieldsandtables) | **POST** /document-ai/document/extract/all | Extract All Fields and Tables of Data from a Document using AI |
| [**ExtractBarcodes**](ExtractApi.md#extractbarcodes) | **POST** /document-ai/document/extract/barcodes | Extract Barcodes of from a Document using AI |
| [**ExtractClassification**](ExtractApi.md#extractclassification) | **POST** /document-ai/document/extract/classify | Extract Classification or Category from a Document using AI |
| [**ExtractClassificationAdvanced**](ExtractApi.md#extractclassificationadvanced) | **POST** /document-ai/document/extract/classify/advanced | Extract Classification or Category from a Document using Advanced AI |
| [**ExtractFields**](ExtractApi.md#extractfields) | **POST** /document-ai/document/extract/fields | Extract Field Values from a Document using AI |
| [**ExtractFieldsAdvanced**](ExtractApi.md#extractfieldsadvanced) | **POST** /document-ai/document/extract/fields/advanced | Extract Field Values from a Document using Advanced AI |
| [**ExtractSplit**](ExtractApi.md#extractsplit) | **POST** /document-ai/document/extract/split | Intelligently Split a Combined Document into Sub-Documents using AI |
| [**ExtractSummary**](ExtractApi.md#extractsummary) | **POST** /document-ai/document/extract/summary | Extract Summary from a Document using AI |
| [**ExtractTables**](ExtractApi.md#extracttables) | **POST** /document-ai/document/extract/tables | Extract Tables of Data from a Document using AI |
| [**ExtractText**](ExtractApi.md#extracttext) | **POST** /document-ai/document/extract/text | Extract Text from a Document using AI |

<a id="extractallfieldsandtables"></a>
# **ExtractAllFieldsAndTables**
> ExtractFieldsAndTablesResponse ExtractAllFieldsAndTables (string recognitionMode = null, string preprocessing = null, FileParameter inputFile = null)

Extract All Fields and Tables of Data from a Document using AI

Extract all Fields and Tables, comprised of rows and columns of data, from a document using AI.  Input document formats supported include DOCX, PDF, XLSX, PPTX, EML, MSG, JPG, PNG and WEBP.  Consumes 100 API calls per page.

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
    public class ExtractAllFieldsAndTablesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cloudmersive.com";
            // Configure API key authorization: Apikey
            config.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Apikey", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExtractApi(httpClient, config, httpClientHandler);
            var recognitionMode = "recognitionMode_example";  // string | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images (optional) 
            var preprocessing = "preprocessing_example";  // string | Optional: Set the level of image pre-processing to enhance accuracy.  Possible values are 'Auto' (default), 'Paged', and 'Compatability'.  Use 'Paged' to treat each page as a separate document for extraction (requires Advanced recognitionMode).  Default is Auto. (optional) 
            var inputFile = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter | Input document, or photos of a document, to extract data from (optional) 

            try
            {
                // Extract All Fields and Tables of Data from a Document using AI
                ExtractFieldsAndTablesResponse result = apiInstance.ExtractAllFieldsAndTables(recognitionMode, preprocessing, inputFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExtractApi.ExtractAllFieldsAndTables: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExtractAllFieldsAndTablesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Extract All Fields and Tables of Data from a Document using AI
    ApiResponse<ExtractFieldsAndTablesResponse> response = apiInstance.ExtractAllFieldsAndTablesWithHttpInfo(recognitionMode, preprocessing, inputFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExtractApi.ExtractAllFieldsAndTablesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recognitionMode** | **string** | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images | [optional]  |
| **preprocessing** | **string** | Optional: Set the level of image pre-processing to enhance accuracy.  Possible values are &#39;Auto&#39; (default), &#39;Paged&#39;, and &#39;Compatability&#39;.  Use &#39;Paged&#39; to treat each page as a separate document for extraction (requires Advanced recognitionMode).  Default is Auto. | [optional]  |
| **inputFile** | **FileParameter****FileParameter** | Input document, or photos of a document, to extract data from | [optional]  |

### Return type

[**ExtractFieldsAndTablesResponse**](ExtractFieldsAndTablesResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="extractbarcodes"></a>
# **ExtractBarcodes**
> ExtractBarcodesAiResponse ExtractBarcodes (string recognitionMode = null, FileParameter inputFile = null)

Extract Barcodes of from a Document using AI

Extract all barcodes from a document using AI.  Input document formats supported include DOCX, PDF, XLSX, PPTX, EML, MSG, JPG, PNG, HEIC and WEBP.  Consumes 100 API calls per page.

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
    public class ExtractBarcodesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cloudmersive.com";
            // Configure API key authorization: Apikey
            config.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Apikey", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExtractApi(httpClient, config, httpClientHandler);
            var recognitionMode = "recognitionMode_example";  // string | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images (optional) 
            var inputFile = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter | Input document, or photos of a document, to extract data from (optional) 

            try
            {
                // Extract Barcodes of from a Document using AI
                ExtractBarcodesAiResponse result = apiInstance.ExtractBarcodes(recognitionMode, inputFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExtractApi.ExtractBarcodes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExtractBarcodesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Extract Barcodes of from a Document using AI
    ApiResponse<ExtractBarcodesAiResponse> response = apiInstance.ExtractBarcodesWithHttpInfo(recognitionMode, inputFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExtractApi.ExtractBarcodesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recognitionMode** | **string** | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images | [optional]  |
| **inputFile** | **FileParameter****FileParameter** | Input document, or photos of a document, to extract data from | [optional]  |

### Return type

[**ExtractBarcodesAiResponse**](ExtractBarcodesAiResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="extractclassification"></a>
# **ExtractClassification**
> DocumentClassificationResult ExtractClassification (string categories = null, string recognitionMode = null, FileParameter inputFile = null)

Extract Classification or Category from a Document using AI

Extract Classification or Category (e.g. Invoice, Receipt, Tax Form, or Form 1040, Form 1040 EZ, etc.) from a document using AI.  Input document formats supported include DOCX, PDF, XLSX, PPTX, EML, MSG, JPG, PNG and WEBP.  Consumes 100 API calls per page.

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
    public class ExtractClassificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cloudmersive.com";
            // Configure API key authorization: Apikey
            config.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Apikey", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExtractApi(httpClient, config, httpClientHandler);
            var categories = "categories_example";  // string | Desired classification to extract (optional) 
            var recognitionMode = "recognitionMode_example";  // string | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images (optional) 
            var inputFile = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter | Input document, or photos of a document, to extract data from (optional) 

            try
            {
                // Extract Classification or Category from a Document using AI
                DocumentClassificationResult result = apiInstance.ExtractClassification(categories, recognitionMode, inputFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExtractApi.ExtractClassification: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExtractClassificationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Extract Classification or Category from a Document using AI
    ApiResponse<DocumentClassificationResult> response = apiInstance.ExtractClassificationWithHttpInfo(categories, recognitionMode, inputFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExtractApi.ExtractClassificationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categories** | **string** | Desired classification to extract | [optional]  |
| **recognitionMode** | **string** | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images | [optional]  |
| **inputFile** | **FileParameter****FileParameter** | Input document, or photos of a document, to extract data from | [optional]  |

### Return type

[**DocumentClassificationResult**](DocumentClassificationResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="extractclassificationadvanced"></a>
# **ExtractClassificationAdvanced**
> DocumentAdvancedClassificationResult ExtractClassificationAdvanced (string recognitionMode = null, AdvancedExtractClassificationRequest body = null)

Extract Classification or Category from a Document using Advanced AI

Extract Classification or Category (e.g. Invoice, Receipt, Tax Form, or Form 1040, Form 1040 EZ, etc.) from a document using Advanced AI.  Input document formats supported include DOCX, PDF, XLSX, PPTX, EML, MSG, JPG, PNG and WEBP.  Consumes 100 API calls per page.

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
    public class ExtractClassificationAdvancedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cloudmersive.com";
            // Configure API key authorization: Apikey
            config.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Apikey", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExtractApi(httpClient, config, httpClientHandler);
            var recognitionMode = "recognitionMode_example";  // string | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images (optional) 
            var body = new AdvancedExtractClassificationRequest(); // AdvancedExtractClassificationRequest | Input request to perform the classification on (optional) 

            try
            {
                // Extract Classification or Category from a Document using Advanced AI
                DocumentAdvancedClassificationResult result = apiInstance.ExtractClassificationAdvanced(recognitionMode, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExtractApi.ExtractClassificationAdvanced: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExtractClassificationAdvancedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Extract Classification or Category from a Document using Advanced AI
    ApiResponse<DocumentAdvancedClassificationResult> response = apiInstance.ExtractClassificationAdvancedWithHttpInfo(recognitionMode, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExtractApi.ExtractClassificationAdvancedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recognitionMode** | **string** | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images | [optional]  |
| **body** | [**AdvancedExtractClassificationRequest**](AdvancedExtractClassificationRequest.md) | Input request to perform the classification on | [optional]  |

### Return type

[**DocumentAdvancedClassificationResult**](DocumentAdvancedClassificationResult.md)

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

<a id="extractfields"></a>
# **ExtractFields**
> ExtractFieldsResponse ExtractFields (string fieldNames = null, string recognitionMode = null, FileParameter inputFile = null)

Extract Field Values from a Document using AI

Extract Field Values (e.g. Invoice Number, Invoice Date, Business Card Phone Number, etc.) from a document using AI.  Input document formats supported include DOCX, PDF, XLSX, PPTX, EML, MSG, JPG, PNG and WEBP.  Consumes 100 API calls per page.

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
    public class ExtractFieldsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cloudmersive.com";
            // Configure API key authorization: Apikey
            config.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Apikey", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExtractApi(httpClient, config, httpClientHandler);
            var fieldNames = "fieldNames_example";  // string | Desired fields to extract, comma separated (optional) 
            var recognitionMode = "recognitionMode_example";  // string | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images (optional) 
            var inputFile = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter | Input document, or photos of a document, to extract data from (optional) 

            try
            {
                // Extract Field Values from a Document using AI
                ExtractFieldsResponse result = apiInstance.ExtractFields(fieldNames, recognitionMode, inputFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExtractApi.ExtractFields: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExtractFieldsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Extract Field Values from a Document using AI
    ApiResponse<ExtractFieldsResponse> response = apiInstance.ExtractFieldsWithHttpInfo(fieldNames, recognitionMode, inputFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExtractApi.ExtractFieldsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fieldNames** | **string** | Desired fields to extract, comma separated | [optional]  |
| **recognitionMode** | **string** | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images | [optional]  |
| **inputFile** | **FileParameter****FileParameter** | Input document, or photos of a document, to extract data from | [optional]  |

### Return type

[**ExtractFieldsResponse**](ExtractFieldsResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="extractfieldsadvanced"></a>
# **ExtractFieldsAdvanced**
> ExtractFieldsAdvancedResponse ExtractFieldsAdvanced (string recognitionMode = null, AdvancedExtractFieldsRequest body = null)

Extract Field Values from a Document using Advanced AI

Extract Field Values (e.g. Invoice Number, Invoice Date, Business Card Phone Number, etc.) from a document using Advanced AI.  Input document formats supported include DOCX, PDF, XLSX, PPTX, EML, MSG, JPG, PNG and WEBP.  Consumes 100 API calls per page.

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
    public class ExtractFieldsAdvancedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cloudmersive.com";
            // Configure API key authorization: Apikey
            config.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Apikey", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExtractApi(httpClient, config, httpClientHandler);
            var recognitionMode = "recognitionMode_example";  // string | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images (optional) 
            var body = new AdvancedExtractFieldsRequest(); // AdvancedExtractFieldsRequest | Input request, including document file as byte array, and information on which fields to extract (optional) 

            try
            {
                // Extract Field Values from a Document using Advanced AI
                ExtractFieldsAdvancedResponse result = apiInstance.ExtractFieldsAdvanced(recognitionMode, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExtractApi.ExtractFieldsAdvanced: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExtractFieldsAdvancedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Extract Field Values from a Document using Advanced AI
    ApiResponse<ExtractFieldsAdvancedResponse> response = apiInstance.ExtractFieldsAdvancedWithHttpInfo(recognitionMode, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExtractApi.ExtractFieldsAdvancedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recognitionMode** | **string** | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images | [optional]  |
| **body** | [**AdvancedExtractFieldsRequest**](AdvancedExtractFieldsRequest.md) | Input request, including document file as byte array, and information on which fields to extract | [optional]  |

### Return type

[**ExtractFieldsAdvancedResponse**](ExtractFieldsAdvancedResponse.md)

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

<a id="extractsplit"></a>
# **ExtractSplit**
> SplitDocumentResponse ExtractSplit (string recognitionMode = null, FileParameter inputFile = null)

Intelligently Split a Combined Document into Sub-Documents using AI

Analyzes a document containing multiple sub-documents (such as a scanned batch of ID cards, forms, or mixed documents) and intelligently splits it into separate sub-documents.  Uses AI to detect document boundaries based on visual content, headers, names, and document types.  Returns the page ranges and PDF bytes for each identified sub-document.  Input document formats supported include DOCX, PDF, XLSX, PPTX, EML, MSG, JPG, PNG and WEBP.  Consumes 100 API calls per page.

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
    public class ExtractSplitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cloudmersive.com";
            // Configure API key authorization: Apikey
            config.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Apikey", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExtractApi(httpClient, config, httpClientHandler);
            var recognitionMode = "recognitionMode_example";  // string | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images (optional) 
            var inputFile = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter | Input document containing multiple sub-documents to split (optional) 

            try
            {
                // Intelligently Split a Combined Document into Sub-Documents using AI
                SplitDocumentResponse result = apiInstance.ExtractSplit(recognitionMode, inputFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExtractApi.ExtractSplit: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExtractSplitWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Intelligently Split a Combined Document into Sub-Documents using AI
    ApiResponse<SplitDocumentResponse> response = apiInstance.ExtractSplitWithHttpInfo(recognitionMode, inputFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExtractApi.ExtractSplitWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recognitionMode** | **string** | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images | [optional]  |
| **inputFile** | **FileParameter****FileParameter** | Input document containing multiple sub-documents to split | [optional]  |

### Return type

[**SplitDocumentResponse**](SplitDocumentResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="extractsummary"></a>
# **ExtractSummary**
> SummarizeDocumentResponse ExtractSummary (string recognitionMode = null, string language = null, FileParameter inputFile = null)

Extract Summary from a Document using AI

Creates a 1 paragraph summary of the input document using Artificial Intelligence.  Input document formats supported include DOCX, PDF, XLSX, PPTX, EML, MSG, JPG, PNG and WEBP.  Consumes 100 API calls per page.

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
    public class ExtractSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cloudmersive.com";
            // Configure API key authorization: Apikey
            config.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Apikey", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExtractApi(httpClient, config, httpClientHandler);
            var recognitionMode = "recognitionMode_example";  // string | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images (optional) 
            var language = "language_example";  // string | Optional; Three-letter language code (ISO 639) for the summary.  Default is ENG.  Possible language codes are: AAR,ABK,ACE,ACH,ADA,ADY,AFA,AFH,AFR,AIN,AKA,AKK,ALB,ALE,ALG,ALT,AMH,ANG,ANP,APA,ARA,ARC,ARG,ARM,ARN,ARP,ART,ARW,ASM,AST,ATH,AUS,AVA,AVE,AWA,AYM,AZE,BAD,BAI,BAK,BAL,BAM,BAN,BAQ,BAS,BAT,BEJ,BEL,BEM,BEN,BER,BHO,BIH,BIK,BIN,BIS,BLA,BNT,BOD,BOS,BRA,BRE,BTK,BUA,BUG,BUL,BUR,BYN,CAD,CAI,CAR,CAT,CAU,CEB,CEL,CES,CHA,CHB,CHE,CHG,CHI,CHK,CHM,CHN,CHO,CHP,CHR,CHU,CHV,CHY,CMC,CNR,COP,COR,COS,CPE,CPF,CPP,CRE,CRH,CRP,CSB,CUS,CYM,CZE,DAK,DAN,DAR,DAY,DEL,DEN,DEU,DGR,DIN,DIV,DOI,DRA,DSB,DUA,DUM,DUT,DYU,DZO,EFI,EGY,EKA,ELL,ELX,ENG,ENM,EPO,EST,EUS,EWE,EWO,FAN,FAO,FAS,FAT,FIJ,FIL,FIN,FIU,FON,FRA,FRE,FRM,FRO,FRR,FRS,FRY,FUL,FUR,GAA,GAY,GBA,GEM,GEO,GER,GEZ,GIL,GLA,GLE,GLG,GLV,GMH,GOH,GON,GOR,GOT,GRB,GRC,GRE,GRN,GSW,GUJ,GWI,HAI,HAT,HAU,HAW,HEB,HER,HIL,HIM,HIN,HIT,HMN,HMO,HRV,HSB,HUN,HUP,HYE,IBA,IBO,ICE,IDO,III,IJO,IKU,ILE,ILO,INA,INC,IND,INE,INH,IPK,IRA,IRO,ISL,ITA,JAV,JBO,JPN,JPR,JRB,KAA,KAB,KAC,KAL,KAM,KAN,KAR,KAS,KAT,KAU,KAW,KAZ,KBD,KHA,KHI,KHM,KHO,KIK,KIN,KIR,KMB,KOK,KOM,KON,KOR,KOS,KPE,KRC,KRL,KRO,KRU,KUA,KUM,KUR,KUT,LAD,LAH,LAM,LAO,LAT,LAV,LEZ,LIM,LIN,LIT,LOL,LOZ,LTZ,LUA,LUB,LUG,LUI,LUN,LUO,LUS,MAC,MAD,MAG,MAH,MAI,MAK,MAL,MAN,MAO,MAP,MAR,MAS,MAY,MDF,MDR,MEN,MGA,MIC,MIN,MIS,MKD,MKH,MLG,MLT,MNC,MNI,MNO,MOH,MON,MOS,MRI,MSA,MUL,MUN,MUS,MWL,MWR,MYA,MYN,MYV,NAH,NAI,NAP,NAU,NAV,NBL,NDE,NDO,NDS,NEP,NEW,NIA,NIC,NIU,NLD,NNO,NOB,NOG,NON,NOR,NQO,NSO,NUB,NWC,NYA,NYM,NYN,NYO,NZI,OCI,OJI,ORI,ORM,OSA,OSS,OTA,OTO,PAA,PAG,PAL,PAM,PAN,PAP,PAU,PEO,PER,PHI,PHN,PLI,POL,PON,POR,PRA,PRO,PUS,QUE,RAJ,RAP,RAR,ROA,ROH,ROM,RON,RUM,RUN,RUP,RUS,SAD,SAG,SAH,SAI,SAL,SAM,SAN,SAS,SAT,SCN,SCO,SEL,SEM,SGA,SGN,SHN,SID,SIN,SIO,SIT,SLA,SLK,SLO,SLV,SMA,SME,SMI,SMJ,SMN,SMO,SMS,SNA,SND,SNK,SOG,SOM,SON,SOT,SPA,SQI,SRD,SRN,SRP,SRR,SSA,SSW,SUK,SUN,SUS,SUX,SWA,SWE,SYC,SYR,TAH,TAI,TAM,TAT,TEL,TEM,TER,TET,TGK,TGL,THA,TIB,TIG,TIR,TIV,TKL,TLH,TLI,TMH,TOG,TON,TPI,TSI,TSN,TSO,TUK,TUM,TUP,TUR,TUT,TVL,TWI,TYV,UDM,UGA,UIG,UKR,UMB,UND,URD,UZB,VAI,VEN,VIE,VOL,VOT,WAK,WAL,WAR,WAS,WEL,WEN,WLN,WOL,XAL,XHO,YAO,YAP,YID,YOR,YPK,ZAP,ZBL,ZEN,ZGH,ZHA,ZHO,ZND,ZUL,ZUN,ZXX,ZZA. (optional) 
            var inputFile = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter | Input document, or photos of a document, to extract data from (optional) 

            try
            {
                // Extract Summary from a Document using AI
                SummarizeDocumentResponse result = apiInstance.ExtractSummary(recognitionMode, language, inputFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExtractApi.ExtractSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExtractSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Extract Summary from a Document using AI
    ApiResponse<SummarizeDocumentResponse> response = apiInstance.ExtractSummaryWithHttpInfo(recognitionMode, language, inputFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExtractApi.ExtractSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recognitionMode** | **string** | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images | [optional]  |
| **language** | **string** | Optional; Three-letter language code (ISO 639) for the summary.  Default is ENG.  Possible language codes are: AAR,ABK,ACE,ACH,ADA,ADY,AFA,AFH,AFR,AIN,AKA,AKK,ALB,ALE,ALG,ALT,AMH,ANG,ANP,APA,ARA,ARC,ARG,ARM,ARN,ARP,ART,ARW,ASM,AST,ATH,AUS,AVA,AVE,AWA,AYM,AZE,BAD,BAI,BAK,BAL,BAM,BAN,BAQ,BAS,BAT,BEJ,BEL,BEM,BEN,BER,BHO,BIH,BIK,BIN,BIS,BLA,BNT,BOD,BOS,BRA,BRE,BTK,BUA,BUG,BUL,BUR,BYN,CAD,CAI,CAR,CAT,CAU,CEB,CEL,CES,CHA,CHB,CHE,CHG,CHI,CHK,CHM,CHN,CHO,CHP,CHR,CHU,CHV,CHY,CMC,CNR,COP,COR,COS,CPE,CPF,CPP,CRE,CRH,CRP,CSB,CUS,CYM,CZE,DAK,DAN,DAR,DAY,DEL,DEN,DEU,DGR,DIN,DIV,DOI,DRA,DSB,DUA,DUM,DUT,DYU,DZO,EFI,EGY,EKA,ELL,ELX,ENG,ENM,EPO,EST,EUS,EWE,EWO,FAN,FAO,FAS,FAT,FIJ,FIL,FIN,FIU,FON,FRA,FRE,FRM,FRO,FRR,FRS,FRY,FUL,FUR,GAA,GAY,GBA,GEM,GEO,GER,GEZ,GIL,GLA,GLE,GLG,GLV,GMH,GOH,GON,GOR,GOT,GRB,GRC,GRE,GRN,GSW,GUJ,GWI,HAI,HAT,HAU,HAW,HEB,HER,HIL,HIM,HIN,HIT,HMN,HMO,HRV,HSB,HUN,HUP,HYE,IBA,IBO,ICE,IDO,III,IJO,IKU,ILE,ILO,INA,INC,IND,INE,INH,IPK,IRA,IRO,ISL,ITA,JAV,JBO,JPN,JPR,JRB,KAA,KAB,KAC,KAL,KAM,KAN,KAR,KAS,KAT,KAU,KAW,KAZ,KBD,KHA,KHI,KHM,KHO,KIK,KIN,KIR,KMB,KOK,KOM,KON,KOR,KOS,KPE,KRC,KRL,KRO,KRU,KUA,KUM,KUR,KUT,LAD,LAH,LAM,LAO,LAT,LAV,LEZ,LIM,LIN,LIT,LOL,LOZ,LTZ,LUA,LUB,LUG,LUI,LUN,LUO,LUS,MAC,MAD,MAG,MAH,MAI,MAK,MAL,MAN,MAO,MAP,MAR,MAS,MAY,MDF,MDR,MEN,MGA,MIC,MIN,MIS,MKD,MKH,MLG,MLT,MNC,MNI,MNO,MOH,MON,MOS,MRI,MSA,MUL,MUN,MUS,MWL,MWR,MYA,MYN,MYV,NAH,NAI,NAP,NAU,NAV,NBL,NDE,NDO,NDS,NEP,NEW,NIA,NIC,NIU,NLD,NNO,NOB,NOG,NON,NOR,NQO,NSO,NUB,NWC,NYA,NYM,NYN,NYO,NZI,OCI,OJI,ORI,ORM,OSA,OSS,OTA,OTO,PAA,PAG,PAL,PAM,PAN,PAP,PAU,PEO,PER,PHI,PHN,PLI,POL,PON,POR,PRA,PRO,PUS,QUE,RAJ,RAP,RAR,ROA,ROH,ROM,RON,RUM,RUN,RUP,RUS,SAD,SAG,SAH,SAI,SAL,SAM,SAN,SAS,SAT,SCN,SCO,SEL,SEM,SGA,SGN,SHN,SID,SIN,SIO,SIT,SLA,SLK,SLO,SLV,SMA,SME,SMI,SMJ,SMN,SMO,SMS,SNA,SND,SNK,SOG,SOM,SON,SOT,SPA,SQI,SRD,SRN,SRP,SRR,SSA,SSW,SUK,SUN,SUS,SUX,SWA,SWE,SYC,SYR,TAH,TAI,TAM,TAT,TEL,TEM,TER,TET,TGK,TGL,THA,TIB,TIG,TIR,TIV,TKL,TLH,TLI,TMH,TOG,TON,TPI,TSI,TSN,TSO,TUK,TUM,TUP,TUR,TUT,TVL,TWI,TYV,UDM,UGA,UIG,UKR,UMB,UND,URD,UZB,VAI,VEN,VIE,VOL,VOT,WAK,WAL,WAR,WAS,WEL,WEN,WLN,WOL,XAL,XHO,YAO,YAP,YID,YOR,YPK,ZAP,ZBL,ZEN,ZGH,ZHA,ZHO,ZND,ZUL,ZUN,ZXX,ZZA. | [optional]  |
| **inputFile** | **FileParameter****FileParameter** | Input document, or photos of a document, to extract data from | [optional]  |

### Return type

[**SummarizeDocumentResponse**](SummarizeDocumentResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="extracttables"></a>
# **ExtractTables**
> ExtractTablesResponse ExtractTables (string recognitionMode = null, FileParameter inputFile = null)

Extract Tables of Data from a Document using AI

Extract Tables, comprised of rows and columns of data, from a document using AI.  Input document formats supported include DOCX, PDF, XLSX, PPTX, EML, MSG, JPG, PNG and WEBP.  Consumeds 100 API calls per page.

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
    public class ExtractTablesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cloudmersive.com";
            // Configure API key authorization: Apikey
            config.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Apikey", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExtractApi(httpClient, config, httpClientHandler);
            var recognitionMode = "recognitionMode_example";  // string | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images (optional) 
            var inputFile = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter | Input document, or photos of a document, to extract data from (optional) 

            try
            {
                // Extract Tables of Data from a Document using AI
                ExtractTablesResponse result = apiInstance.ExtractTables(recognitionMode, inputFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExtractApi.ExtractTables: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExtractTablesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Extract Tables of Data from a Document using AI
    ApiResponse<ExtractTablesResponse> response = apiInstance.ExtractTablesWithHttpInfo(recognitionMode, inputFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExtractApi.ExtractTablesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recognitionMode** | **string** | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images | [optional]  |
| **inputFile** | **FileParameter****FileParameter** | Input document, or photos of a document, to extract data from | [optional]  |

### Return type

[**ExtractTablesResponse**](ExtractTablesResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="extracttext"></a>
# **ExtractText**
> ExtractTextResponse ExtractText (string recognitionMode = null, FileParameter inputFile = null)

Extract Text from a Document using AI

Extract raw text from a document using AI.  Input document formats supported include DOCX, PDF, XLSX, PPTX, EML, MSG, JPG, PNG and WEBP.  Supports a wide range of languages.  Consumes 100 API calls per page.

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
    public class ExtractTextExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cloudmersive.com";
            // Configure API key authorization: Apikey
            config.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Apikey", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExtractApi(httpClient, config, httpClientHandler);
            var recognitionMode = "recognitionMode_example";  // string | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images.  Set to Deterministic to directly extract text from digital documents without using AI. (optional) 
            var inputFile = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter | Input document, or photos of a document, to extract data from (optional) 

            try
            {
                // Extract Text from a Document using AI
                ExtractTextResponse result = apiInstance.ExtractText(recognitionMode, inputFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExtractApi.ExtractText: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExtractTextWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Extract Text from a Document using AI
    ApiResponse<ExtractTextResponse> response = apiInstance.ExtractTextWithHttpInfo(recognitionMode, inputFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExtractApi.ExtractTextWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recognitionMode** | **string** | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images.  Set to Deterministic to directly extract text from digital documents without using AI. | [optional]  |
| **inputFile** | **FileParameter****FileParameter** | Input document, or photos of a document, to extract data from | [optional]  |

### Return type

[**ExtractTextResponse**](ExtractTextResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

