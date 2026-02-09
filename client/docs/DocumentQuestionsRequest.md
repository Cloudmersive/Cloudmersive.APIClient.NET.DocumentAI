# Cloudmersive.APIClient.NET.DocumentAI.Model.DocumentQuestionsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InputFile** | **byte[]** | Input file as a byte array | [optional] 
**QuestionsYesNo** | [**List&lt;DocumentQuestionBoolean&gt;**](DocumentQuestionBoolean.md) | Optional: Yes or No boolean questions to answer about the document | [optional] 
**QuestionsMultipleChoice** | [**List&lt;DocumentQuestionMultipleChoice&gt;**](DocumentQuestionMultipleChoice.md) | Optional: Multiple choice questions to answer about the document | [optional] 
**QuestionsFreeResponse** | [**List&lt;DocumentQuestionFreeResponse&gt;**](DocumentQuestionFreeResponse.md) | Optional: Free response questions to answer about the document | [optional] 
**RecognitionMode** | **string** | Optional; Recognition mode - Normal (default) provides the highest accuracy but slower speed, while Normal provides faster response but lower accuracy for low quality images | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

