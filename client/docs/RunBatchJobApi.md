# Cloudmersive.APIClient.NET.DocumentAI.Api.RunBatchJobApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExtractAllFieldsAndTablesFromDocumentBatchJob**](RunBatchJobApi.md#extractallfieldsandtablesfromdocumentbatchjob) | **POST** /document-ai/document/batch-job/extract/all | Extract All Fields and Tables of Data from a Document using AI as a Batch Job
[**ExtractClassificationFromDocumentBatchJob**](RunBatchJobApi.md#extractclassificationfromdocumentbatchjob) | **POST** /document-ai/document/batch-job/extract/classify | Extract Classification or Category from a Document using AI as a Batch Job
[**ExtractFieldsFromDocumentAdvancedBatchJob**](RunBatchJobApi.md#extractfieldsfromdocumentadvancedbatchjob) | **POST** /document-ai/document/batch-job/extract/fields/advanced | Extract Field Values from a Document using Advanced AI as a Batch Job
[**ExtractTextFromDocumentBatchJob**](RunBatchJobApi.md#extracttextfromdocumentbatchjob) | **POST** /document-ai/document/batch-job/extract/text | Extract Text from a Document using AI as a Batch Job
[**GetAsyncJobStatus**](RunBatchJobApi.md#getasyncjobstatus) | **GET** /document-ai/document/batch-job/batch-job/status | Get the status and result of an Extract Document Batch Job


<a name="extractallfieldsandtablesfromdocumentbatchjob"></a>
# **ExtractAllFieldsAndTablesFromDocumentBatchJob**
> ExtractDocumentBatchJobResult ExtractAllFieldsAndTablesFromDocumentBatchJob (string recognitionMode = null, System.IO.Stream inputFile = null)

Extract All Fields and Tables of Data from a Document using AI as a Batch Job

Creates an async batch job for processing a large document as an AI batch job.  Extract all Fields and Tables, comprised of rows and columns of data, from a document using AI.  Input document formats supported include DOCX, PDF, PNG and JPG.  Requires Managed Instance or Private Cloud deployment.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAI.Api;
using Cloudmersive.APIClient.NET.DocumentAI.Client;
using Cloudmersive.APIClient.NET.DocumentAI.Model;

namespace Example
{
    public class ExtractAllFieldsAndTablesFromDocumentBatchJobExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new RunBatchJobApi();
            var recognitionMode = recognitionMode_example;  // string | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images (optional) 
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input document, or photos of a document, to extract data from (optional) 

            try
            {
                // Extract All Fields and Tables of Data from a Document using AI as a Batch Job
                ExtractDocumentBatchJobResult result = apiInstance.ExtractAllFieldsAndTablesFromDocumentBatchJob(recognitionMode, inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RunBatchJobApi.ExtractAllFieldsAndTablesFromDocumentBatchJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recognitionMode** | **string**| Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images | [optional] 
 **inputFile** | **System.IO.Stream**| Input document, or photos of a document, to extract data from | [optional] 

### Return type

[**ExtractDocumentBatchJobResult**](ExtractDocumentBatchJobResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="extractclassificationfromdocumentbatchjob"></a>
# **ExtractClassificationFromDocumentBatchJob**
> ExtractDocumentBatchJobResult ExtractClassificationFromDocumentBatchJob (string categories = null, string recognitionMode = null, System.IO.Stream inputFile = null)

Extract Classification or Category from a Document using AI as a Batch Job

Creates an async batch job for processing a large document as an AI batch job.  Extract Classification or Category (e.g. Invoice, Receipt, Tax Form, or Form 1040, Form 1040 EZ, etc.) from a document using AI.  Input document formats supported include DOCX, PDF, PNG and JPG.  Requires Managed Instance or Private Cloud deployment.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAI.Api;
using Cloudmersive.APIClient.NET.DocumentAI.Client;
using Cloudmersive.APIClient.NET.DocumentAI.Model;

namespace Example
{
    public class ExtractClassificationFromDocumentBatchJobExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new RunBatchJobApi();
            var categories = categories_example;  // string | Desired classification to extract (optional) 
            var recognitionMode = recognitionMode_example;  // string | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images (optional) 
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input document, or photos of a document, to extract data from (optional) 

            try
            {
                // Extract Classification or Category from a Document using AI as a Batch Job
                ExtractDocumentBatchJobResult result = apiInstance.ExtractClassificationFromDocumentBatchJob(categories, recognitionMode, inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RunBatchJobApi.ExtractClassificationFromDocumentBatchJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categories** | **string**| Desired classification to extract | [optional] 
 **recognitionMode** | **string**| Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images | [optional] 
 **inputFile** | **System.IO.Stream**| Input document, or photos of a document, to extract data from | [optional] 

### Return type

[**ExtractDocumentBatchJobResult**](ExtractDocumentBatchJobResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="extractfieldsfromdocumentadvancedbatchjob"></a>
# **ExtractFieldsFromDocumentAdvancedBatchJob**
> ExtractDocumentBatchJobResult ExtractFieldsFromDocumentAdvancedBatchJob (string recognitionMode = null, AdvancedExtractFieldsRequest body = null)

Extract Field Values from a Document using Advanced AI as a Batch Job

Creates an async batch job for processing a large document as an AI batch job.  Extract Field Values (e.g. Invoice Number, Invoice Date, Business Card Phone Number, etc.) from a document using Advanced AI.  Input document formats supported include DOCX, PDF, PNG and JPG.  Requires Managed Instance or Private Cloud deployment.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAI.Api;
using Cloudmersive.APIClient.NET.DocumentAI.Client;
using Cloudmersive.APIClient.NET.DocumentAI.Model;

namespace Example
{
    public class ExtractFieldsFromDocumentAdvancedBatchJobExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new RunBatchJobApi();
            var recognitionMode = recognitionMode_example;  // string | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images (optional) 
            var body = new AdvancedExtractFieldsRequest(); // AdvancedExtractFieldsRequest |  (optional) 

            try
            {
                // Extract Field Values from a Document using Advanced AI as a Batch Job
                ExtractDocumentBatchJobResult result = apiInstance.ExtractFieldsFromDocumentAdvancedBatchJob(recognitionMode, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RunBatchJobApi.ExtractFieldsFromDocumentAdvancedBatchJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recognitionMode** | **string**| Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images | [optional] 
 **body** | [**AdvancedExtractFieldsRequest**](AdvancedExtractFieldsRequest.md)|  | [optional] 

### Return type

[**ExtractDocumentBatchJobResult**](ExtractDocumentBatchJobResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="extracttextfromdocumentbatchjob"></a>
# **ExtractTextFromDocumentBatchJob**
> ExtractDocumentBatchJobResult ExtractTextFromDocumentBatchJob (string recognitionMode = null, System.IO.Stream inputFile = null)

Extract Text from a Document using AI as a Batch Job

Creates an async batch job for processing a large document as an AI batch job.  Input document formats supported include DOCX, PDF, PNG and JPG.  Supports a wide range of languages.  Requires Managed Instance or Private Cloud deployment.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAI.Api;
using Cloudmersive.APIClient.NET.DocumentAI.Client;
using Cloudmersive.APIClient.NET.DocumentAI.Model;

namespace Example
{
    public class ExtractTextFromDocumentBatchJobExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new RunBatchJobApi();
            var recognitionMode = recognitionMode_example;  // string | Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images (optional) 
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input document, or photos of a document, to extract data from (optional) 

            try
            {
                // Extract Text from a Document using AI as a Batch Job
                ExtractDocumentBatchJobResult result = apiInstance.ExtractTextFromDocumentBatchJob(recognitionMode, inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RunBatchJobApi.ExtractTextFromDocumentBatchJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recognitionMode** | **string**| Optional; Recognition mode - Advanced (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images | [optional] 
 **inputFile** | **System.IO.Stream**| Input document, or photos of a document, to extract data from | [optional] 

### Return type

[**ExtractDocumentBatchJobResult**](ExtractDocumentBatchJobResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getasyncjobstatus"></a>
# **GetAsyncJobStatus**
> ExtractDocumentJobStatusResult GetAsyncJobStatus (string asyncJobID = null)

Get the status and result of an Extract Document Batch Job

Returns the result of the Async Job - possible states can be STARTED or COMPLETED.  This API is only available for Cloudmersive Managed Instance and Private Cloud deployments.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAI.Api;
using Cloudmersive.APIClient.NET.DocumentAI.Client;
using Cloudmersive.APIClient.NET.DocumentAI.Model;

namespace Example
{
    public class GetAsyncJobStatusExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new RunBatchJobApi();
            var asyncJobID = asyncJobID_example;  // string |  (optional) 

            try
            {
                // Get the status and result of an Extract Document Batch Job
                ExtractDocumentJobStatusResult result = apiInstance.GetAsyncJobStatus(asyncJobID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RunBatchJobApi.GetAsyncJobStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asyncJobID** | **string**|  | [optional] 

### Return type

[**ExtractDocumentJobStatusResult**](ExtractDocumentJobStatusResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

