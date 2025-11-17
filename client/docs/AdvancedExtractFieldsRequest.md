# Cloudmersive.APIClient.NET.DocumentAI.Model.AdvancedExtractFieldsRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InputFile** | **byte[]** | Input document file to perform the operation on as a byte array | [optional] 
**FieldsToExtract** | [**List&lt;FieldToExtract&gt;**](FieldToExtract.md) | Fields to extract from the document | [optional] 
**MaximumPagesProcessed** | **int?** | Optional: Limit the number of pages processed | [optional] 
**Preprocessing** | **string** | Optional: Set the level of image pre-processing to enhance accuracy.  Possible values are &#39;Auto&#39; and &#39;None&#39;.  Default is Auto. | [optional] 
**ResultCrossCheck** | **string** | Optional: Set the level of output accuracy cross-checking to perform on the input.  Possible values are &#39;None&#39; and &#39;Advanced&#39;.  Default is None. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

