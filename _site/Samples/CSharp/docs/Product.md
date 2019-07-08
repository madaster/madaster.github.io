# Madaster.API.Model.Product
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | [**MultiLingualString2**](MultiLingualString2.md) |  | 
**Type** | **int?** | The type of product | [optional] 
**Description** | [**MultiLingualString1**](MultiLingualString1.md) |  | [optional] 
**Supplier** | **string** | The supplier of the product | 
**ProductCode** | **string** | The product code (EAN) | [optional] 
**Circular** | [**ProductCircularInformation**](ProductCircularInformation.md) | The circular properties of the product | [optional] 
**FixedDimensions** | [**List&lt;ProductDimension&gt;**](ProductDimension.md) | The fixed dimensions of this product | [optional] 
**DefaultDimensions** | [**List&lt;ProductDimension&gt;**](ProductDimension.md) | The default dimensions of this product&#39;s variable size, which will be used as a factor for all child relations | [optional] 
**Id** | **Guid?** | The unique identifier | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

