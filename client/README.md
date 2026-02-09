# Cloudmersive.APIClient.NET.DocumentAI - the C# library for the Document AI API

Extract structured data including named fields, tables, barcodes, classifications, and summaries from common document formats, scanned documents, and photos of documents using AI.  Also supports handwriting and low quality photos and scans, as well as digital document input.  Supports a wide range of languages, and is able to analyze and infer semantic structure from the visual layout for documents.

This C# SDK is for the [Cloudmersive Document AI API](https://www.cloudmersive.com/document-ai-api):

- API version: v1
- SDK version: 4.0.0
- Generator version: 7.19.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://www.cloudmersive.com](https://www.cloudmersive.com)

<a id="frameworks-supported"></a>
## Frameworks supported

<a id="dependencies"></a>
## Dependencies

- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```
<a id="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Cloudmersive.APIClient.NET.DocumentAI.Api;
using Cloudmersive.APIClient.NET.DocumentAI.Client;
using Cloudmersive.APIClient.NET.DocumentAI.Model;
```
<a id="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Cloudmersive.APIClient.NET.DocumentAI.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

### Connections
Each ApiClass (properly the ApiClient inside it) will create an instance of HttpClient. It will use that for the entire lifecycle and dispose it when called the Dispose method.

To better manager the connections it's a common practice to reuse the HttpClient and HttpClientHandler (see [here](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net) for details). To use your own HttpClient instance just pass it to the ApiClass constructor.

```csharp
HttpClientHandler yourHandler = new HttpClientHandler();
HttpClient yourHttpClient = new HttpClient(yourHandler);
var api = new YourApiClass(yourHttpClient, yourHandler);
```

If you want to use an HttpClient and don't have access to the handler, for example in a DI context in Asp.net Core when using IHttpClientFactory.

```csharp
HttpClient yourHttpClient = new HttpClient();
var api = new YourApiClass(yourHttpClient);
```
You'll loose some configuration settings, the features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings. You need to either manually handle those in your setup of the HttpClient or they won't be available.

Here an example of DI setup in a sample web project:

```csharp
services.AddHttpClient<YourApiClass>(httpClient =>
   new PetApi(httpClient));
```


<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Cloudmersive.APIClient.NET.DocumentAI.Api;
using Cloudmersive.APIClient.NET.DocumentAI.Client;
using Cloudmersive.APIClient.NET.DocumentAI.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.cloudmersive.com";
            // Configure API key authorization: Apikey
            config.ApiKey.Add("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("Apikey", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AnalyzeApi(httpClient, config, httpClientHandler);
            var body = new DocumentQuestionsRequest(); // DocumentQuestionsRequest | Input request, including document and questions (optional) 

            try
            {
                // Answer Questions about a Document in a structured way using Advanced AI
                DocumentQuestionAnswersResult result = apiInstance.AnswerQuestions(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnalyzeApi.AnswerQuestions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.cloudmersive.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AnalyzeApi* | [**AnswerQuestions**](docs/AnalyzeApi.md#answerquestions) | **POST** /document-ai/document/analyze/answer-questions | Answer Questions about a Document in a structured way using Advanced AI
*AnalyzeApi* | [**ApplyRules**](docs/AnalyzeApi.md#applyrules) | **POST** /document-ai/document/analyze/enforce-policy | Enforce Policies to a Document to allow or block it using Advanced AI
*ExtractApi* | [**ExtractAllFieldsAndTables**](docs/ExtractApi.md#extractallfieldsandtables) | **POST** /document-ai/document/extract/all | Extract All Fields and Tables of Data from a Document using AI
*ExtractApi* | [**ExtractBarcodes**](docs/ExtractApi.md#extractbarcodes) | **POST** /document-ai/document/extract/barcodes | Extract Barcodes of from a Document using AI
*ExtractApi* | [**ExtractClassification**](docs/ExtractApi.md#extractclassification) | **POST** /document-ai/document/extract/classify | Extract Classification or Category from a Document using AI
*ExtractApi* | [**ExtractClassificationAdvanced**](docs/ExtractApi.md#extractclassificationadvanced) | **POST** /document-ai/document/extract/classify/advanced | Extract Classification or Category from a Document using Advanced AI
*ExtractApi* | [**ExtractFields**](docs/ExtractApi.md#extractfields) | **POST** /document-ai/document/extract/fields | Extract Field Values from a Document using AI
*ExtractApi* | [**ExtractFieldsAdvanced**](docs/ExtractApi.md#extractfieldsadvanced) | **POST** /document-ai/document/extract/fields/advanced | Extract Field Values from a Document using Advanced AI
*ExtractApi* | [**ExtractSplit**](docs/ExtractApi.md#extractsplit) | **POST** /document-ai/document/extract/split | Intelligently Split a Combined Document into Sub-Documents using AI
*ExtractApi* | [**ExtractSummary**](docs/ExtractApi.md#extractsummary) | **POST** /document-ai/document/extract/summary | Extract Summary from a Document using AI
*ExtractApi* | [**ExtractTables**](docs/ExtractApi.md#extracttables) | **POST** /document-ai/document/extract/tables | Extract Tables of Data from a Document using AI
*ExtractApi* | [**ExtractText**](docs/ExtractApi.md#extracttext) | **POST** /document-ai/document/extract/text | Extract Text from a Document using AI
*RunBatchJobApi* | [**ExtractAllFieldsAndTablesFromDocumentBatchJob**](docs/RunBatchJobApi.md#extractallfieldsandtablesfromdocumentbatchjob) | **POST** /document-ai/document/batch-job/extract/all | Extract All Fields and Tables of Data from a Document using AI as a Batch Job
*RunBatchJobApi* | [**ExtractClassificationFromDocumentBatchJob**](docs/RunBatchJobApi.md#extractclassificationfromdocumentbatchjob) | **POST** /document-ai/document/batch-job/extract/classify | Extract Classification or Category from a Document using AI as a Batch Job
*RunBatchJobApi* | [**ExtractFieldsFromDocumentAdvancedBatchJob**](docs/RunBatchJobApi.md#extractfieldsfromdocumentadvancedbatchjob) | **POST** /document-ai/document/batch-job/extract/fields/advanced | Extract Field Values from a Document using Advanced AI as a Batch Job
*RunBatchJobApi* | [**ExtractTextFromDocumentBatchJob**](docs/RunBatchJobApi.md#extracttextfromdocumentbatchjob) | **POST** /document-ai/document/batch-job/extract/text | Extract Text from a Document using AI as a Batch Job
*RunBatchJobApi* | [**GetAsyncJobStatus**](docs/RunBatchJobApi.md#getasyncjobstatus) | **GET** /document-ai/document/batch-job/batch-job/status | Get the status and result of an Extract Document Batch Job


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.AdvancedExtractClassificationRequest](docs/AdvancedExtractClassificationRequest.md)
 - [Model.AdvancedExtractFieldsRequest](docs/AdvancedExtractFieldsRequest.md)
 - [Model.DocumentAdvancedClassificationResult](docs/DocumentAdvancedClassificationResult.md)
 - [Model.DocumentCategories](docs/DocumentCategories.md)
 - [Model.DocumentClassificationResult](docs/DocumentClassificationResult.md)
 - [Model.DocumentPolicyRequest](docs/DocumentPolicyRequest.md)
 - [Model.DocumentPolicyResult](docs/DocumentPolicyResult.md)
 - [Model.DocumentQuestionAnswerItem](docs/DocumentQuestionAnswerItem.md)
 - [Model.DocumentQuestionAnswersResult](docs/DocumentQuestionAnswersResult.md)
 - [Model.DocumentQuestionBoolean](docs/DocumentQuestionBoolean.md)
 - [Model.DocumentQuestionChoiceItem](docs/DocumentQuestionChoiceItem.md)
 - [Model.DocumentQuestionFreeResponse](docs/DocumentQuestionFreeResponse.md)
 - [Model.DocumentQuestionMultipleChoice](docs/DocumentQuestionMultipleChoice.md)
 - [Model.DocumentQuestionsRequest](docs/DocumentQuestionsRequest.md)
 - [Model.ExtractBarcodesAiResponse](docs/ExtractBarcodesAiResponse.md)
 - [Model.ExtractDocumentBatchJobResult](docs/ExtractDocumentBatchJobResult.md)
 - [Model.ExtractDocumentJobStatusResult](docs/ExtractDocumentJobStatusResult.md)
 - [Model.ExtractFieldsAdvancedResponse](docs/ExtractFieldsAdvancedResponse.md)
 - [Model.ExtractFieldsAndTablesResponse](docs/ExtractFieldsAndTablesResponse.md)
 - [Model.ExtractFieldsResponse](docs/ExtractFieldsResponse.md)
 - [Model.ExtractTablesResponse](docs/ExtractTablesResponse.md)
 - [Model.ExtractTextResponse](docs/ExtractTextResponse.md)
 - [Model.ExtractedBarcodeItem](docs/ExtractedBarcodeItem.md)
 - [Model.ExtractedTextPage](docs/ExtractedTextPage.md)
 - [Model.FieldAdvancedValue](docs/FieldAdvancedValue.md)
 - [Model.FieldToExtract](docs/FieldToExtract.md)
 - [Model.FieldValue](docs/FieldValue.md)
 - [Model.PolicyRule](docs/PolicyRule.md)
 - [Model.PolicyRuleViolation](docs/PolicyRuleViolation.md)
 - [Model.SplitDocumentResponse](docs/SplitDocumentResponse.md)
 - [Model.SubDocument](docs/SubDocument.md)
 - [Model.SummarizeDocumentResponse](docs/SummarizeDocumentResponse.md)
 - [Model.TableResult](docs/TableResult.md)
 - [Model.TableResultCell](docs/TableResultCell.md)
 - [Model.TableResultRow](docs/TableResultRow.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="Apikey"></a>
### Apikey

- **Type**: API key
- **API key parameter name**: Apikey
- **Location**: HTTP header

