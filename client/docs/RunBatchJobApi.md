# Cloudmersive.APIClient.NET.DocumentAI.Api.RunBatchJobApi

All URIs are relative to *https://api.cloudmersive.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ExtractAllFieldsAndTablesFromDocumentBatchJob**](RunBatchJobApi.md#extractallfieldsandtablesfromdocumentbatchjob) | **POST** /document-ai/document/batch-job/extract/all | Extract All Fields and Tables of Data from a Document using AI as a Batch Job |
| [**ExtractClassificationFromDocumentBatchJob**](RunBatchJobApi.md#extractclassificationfromdocumentbatchjob) | **POST** /document-ai/document/batch-job/extract/classify | Extract Classification or Category from a Document using AI as a Batch Job |
| [**ExtractFieldsFromDocumentAdvancedBatchJob**](RunBatchJobApi.md#extractfieldsfromdocumentadvancedbatchjob) | **POST** /document-ai/document/batch-job/extract/fields/advanced | Extract Field Values from a Document using Advanced AI as a Batch Job |
| [**ExtractTextFromDocumentBatchJob**](RunBatchJobApi.md#extracttextfromdocumentbatchjob) | **POST** /document-ai/document/batch-job/extract/text | Extract Text from a Document using AI as a Batch Job |
| [**GetAsyncJobStatus**](RunBatchJobApi.md#getasyncjobstatus) | **GET** /document-ai/document/batch-job/batch-job/status | Get the status and result of an Extract Document Batch Job |

<a id="extractallfieldsandtablesfromdocumentbatchjob"></a>
# **ExtractAllFieldsAndTablesFromDocumentBatchJob**
> ExtractDocumentBatchJobResult ExtractAllFieldsAndTablesFromDocumentBatchJob (string recognitionMode = null, FileParameter inputFile = null)

Extract All Fields and Tables of Data from a Document using AI as a Batch Job

Creates an async batch job for processing a large document as an AI batch job.  Extract all Fields and Tables, comprised of rows and columns of data, from a document using AI.  Input document formats supported include DOCX, PDF, PNG and JPG.  Requires Managed Instance or Private Cloud deployment.

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
    public class ExtractAllFieldsAndTablesFromDocumentBatchJobExample
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
            var apiInstance = new RunBatchJobApi(httpClient, config, httpClientHandler);
            var recognitionMode = "recognitionMode_example";  // string | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images (optional) 
            var inputFile = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter | Input document, or photos of a document, to extract data from (optional) 

            try
            {
                // Extract All Fields and Tables of Data from a Document using AI as a Batch Job
                ExtractDocumentBatchJobResult result = apiInstance.ExtractAllFieldsAndTablesFromDocumentBatchJob(recognitionMode, inputFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunBatchJobApi.ExtractAllFieldsAndTablesFromDocumentBatchJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExtractAllFieldsAndTablesFromDocumentBatchJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Extract All Fields and Tables of Data from a Document using AI as a Batch Job
    ApiResponse<ExtractDocumentBatchJobResult> response = apiInstance.ExtractAllFieldsAndTablesFromDocumentBatchJobWithHttpInfo(recognitionMode, inputFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunBatchJobApi.ExtractAllFieldsAndTablesFromDocumentBatchJobWithHttpInfo: " + e.Message);
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

[**ExtractDocumentBatchJobResult**](ExtractDocumentBatchJobResult.md)

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

<a id="extractclassificationfromdocumentbatchjob"></a>
# **ExtractClassificationFromDocumentBatchJob**
> ExtractDocumentBatchJobResult ExtractClassificationFromDocumentBatchJob (string categories = null, string recognitionMode = null, FileParameter inputFile = null)

Extract Classification or Category from a Document using AI as a Batch Job

Creates an async batch job for processing a large document as an AI batch job.  Extract Classification or Category (e.g. Invoice, Receipt, Tax Form, or Form 1040, Form 1040 EZ, etc.) from a document using AI.  Input document formats supported include DOCX, PDF, PNG and JPG.  Requires Managed Instance or Private Cloud deployment.

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
    public class ExtractClassificationFromDocumentBatchJobExample
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
            var apiInstance = new RunBatchJobApi(httpClient, config, httpClientHandler);
            var categories = "categories_example";  // string | Desired classification to extract (optional) 
            var recognitionMode = "recognitionMode_example";  // string | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images (optional) 
            var inputFile = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter | Input document, or photos of a document, to extract data from (optional) 

            try
            {
                // Extract Classification or Category from a Document using AI as a Batch Job
                ExtractDocumentBatchJobResult result = apiInstance.ExtractClassificationFromDocumentBatchJob(categories, recognitionMode, inputFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunBatchJobApi.ExtractClassificationFromDocumentBatchJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExtractClassificationFromDocumentBatchJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Extract Classification or Category from a Document using AI as a Batch Job
    ApiResponse<ExtractDocumentBatchJobResult> response = apiInstance.ExtractClassificationFromDocumentBatchJobWithHttpInfo(categories, recognitionMode, inputFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunBatchJobApi.ExtractClassificationFromDocumentBatchJobWithHttpInfo: " + e.Message);
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

[**ExtractDocumentBatchJobResult**](ExtractDocumentBatchJobResult.md)

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

<a id="extractfieldsfromdocumentadvancedbatchjob"></a>
# **ExtractFieldsFromDocumentAdvancedBatchJob**
> ExtractDocumentBatchJobResult ExtractFieldsFromDocumentAdvancedBatchJob (string recognitionMode = null, AdvancedExtractFieldsRequest body = null)

Extract Field Values from a Document using Advanced AI as a Batch Job

Creates an async batch job for processing a large document as an AI batch job.  Extract Field Values (e.g. Invoice Number, Invoice Date, Business Card Phone Number, etc.) from a document using Advanced AI.  Input document formats supported include DOCX, PDF, PNG and JPG.  Requires Managed Instance or Private Cloud deployment.

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
    public class ExtractFieldsFromDocumentAdvancedBatchJobExample
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
            var apiInstance = new RunBatchJobApi(httpClient, config, httpClientHandler);
            var recognitionMode = "recognitionMode_example";  // string | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images (optional) 
            var body = new AdvancedExtractFieldsRequest(); // AdvancedExtractFieldsRequest | Input document and parameters (optional) 

            try
            {
                // Extract Field Values from a Document using Advanced AI as a Batch Job
                ExtractDocumentBatchJobResult result = apiInstance.ExtractFieldsFromDocumentAdvancedBatchJob(recognitionMode, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunBatchJobApi.ExtractFieldsFromDocumentAdvancedBatchJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExtractFieldsFromDocumentAdvancedBatchJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Extract Field Values from a Document using Advanced AI as a Batch Job
    ApiResponse<ExtractDocumentBatchJobResult> response = apiInstance.ExtractFieldsFromDocumentAdvancedBatchJobWithHttpInfo(recognitionMode, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunBatchJobApi.ExtractFieldsFromDocumentAdvancedBatchJobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recognitionMode** | **string** | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images | [optional]  |
| **body** | [**AdvancedExtractFieldsRequest**](AdvancedExtractFieldsRequest.md) | Input document and parameters | [optional]  |

### Return type

[**ExtractDocumentBatchJobResult**](ExtractDocumentBatchJobResult.md)

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

<a id="extracttextfromdocumentbatchjob"></a>
# **ExtractTextFromDocumentBatchJob**
> ExtractDocumentBatchJobResult ExtractTextFromDocumentBatchJob (string recognitionMode = null, FileParameter inputFile = null)

Extract Text from a Document using AI as a Batch Job

Creates an async batch job for processing a large document as an AI batch job.  Input document formats supported include DOCX, PDF, PNG and JPG.  Supports a wide range of languages.  Requires Managed Instance or Private Cloud deployment.

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
    public class ExtractTextFromDocumentBatchJobExample
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
            var apiInstance = new RunBatchJobApi(httpClient, config, httpClientHandler);
            var recognitionMode = "recognitionMode_example";  // string | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images (optional) 
            var inputFile = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter | Input document, or photos of a document, to extract data from (optional) 

            try
            {
                // Extract Text from a Document using AI as a Batch Job
                ExtractDocumentBatchJobResult result = apiInstance.ExtractTextFromDocumentBatchJob(recognitionMode, inputFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunBatchJobApi.ExtractTextFromDocumentBatchJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExtractTextFromDocumentBatchJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Extract Text from a Document using AI as a Batch Job
    ApiResponse<ExtractDocumentBatchJobResult> response = apiInstance.ExtractTextFromDocumentBatchJobWithHttpInfo(recognitionMode, inputFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunBatchJobApi.ExtractTextFromDocumentBatchJobWithHttpInfo: " + e.Message);
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

[**ExtractDocumentBatchJobResult**](ExtractDocumentBatchJobResult.md)

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

<a id="getasyncjobstatus"></a>
# **GetAsyncJobStatus**
> ExtractDocumentJobStatusResult GetAsyncJobStatus (string asyncJobID = null)

Get the status and result of an Extract Document Batch Job

Returns the result of the Async Job - possible states can be STARTED or COMPLETED.  This API is only available for Cloudmersive Managed Instance and Private Cloud deployments.

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
    public class GetAsyncJobStatusExample
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
            var apiInstance = new RunBatchJobApi(httpClient, config, httpClientHandler);
            var asyncJobID = "asyncJobID_example";  // string | Job ID for the batch job to get the status of (optional) 

            try
            {
                // Get the status and result of an Extract Document Batch Job
                ExtractDocumentJobStatusResult result = apiInstance.GetAsyncJobStatus(asyncJobID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RunBatchJobApi.GetAsyncJobStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAsyncJobStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the status and result of an Extract Document Batch Job
    ApiResponse<ExtractDocumentJobStatusResult> response = apiInstance.GetAsyncJobStatusWithHttpInfo(asyncJobID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RunBatchJobApi.GetAsyncJobStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asyncJobID** | **string** | Job ID for the batch job to get the status of | [optional]  |

### Return type

[**ExtractDocumentJobStatusResult**](ExtractDocumentJobStatusResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

