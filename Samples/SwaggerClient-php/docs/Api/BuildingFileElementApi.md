# Swagger\Client\BuildingFileElementApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV11BuildingsByBuildingIdFilesByFileIdElementsByIdDelete**](BuildingFileElementApi.md#apiV11BuildingsByBuildingIdFilesByFileIdElementsByIdDelete) | **DELETE** /api/v1.1/buildings/{buildingId}/files/{fileId}/elements/{id} | Deletes an existing building file element.
[**apiV11BuildingsByBuildingIdFilesByFileIdElementsByIdGet**](BuildingFileElementApi.md#apiV11BuildingsByBuildingIdFilesByFileIdElementsByIdGet) | **GET** /api/v1.1/buildings/{buildingId}/files/{fileId}/elements/{id} | Gets a building file element by its identifier and building file identifier.
[**apiV11BuildingsByBuildingIdFilesByFileIdElementsByIdPut**](BuildingFileElementApi.md#apiV11BuildingsByBuildingIdFilesByFileIdElementsByIdPut) | **PUT** /api/v1.1/buildings/{buildingId}/files/{fileId}/elements/{id} | Updates an existing building file element.
[**apiV11BuildingsByBuildingIdFilesByFileIdElementsGet**](BuildingFileElementApi.md#apiV11BuildingsByBuildingIdFilesByFileIdElementsGet) | **GET** /api/v1.1/buildings/{buildingId}/files/{fileId}/elements | Gets a building file elements by its building file identifier.
[**apiV11BuildingsByBuildingIdFilesByFileIdElementsPost**](BuildingFileElementApi.md#apiV11BuildingsByBuildingIdFilesByFileIdElementsPost) | **POST** /api/v1.1/buildings/{buildingId}/files/{fileId}/elements | Create a new building file element.


# **apiV11BuildingsByBuildingIdFilesByFileIdElementsByIdDelete**
> apiV11BuildingsByBuildingIdFilesByFileIdElementsByIdDelete($building_id, $file_id, $id)

Deletes an existing building file element.

Sample request:        DELETE api/[version]/buildings/[buildingid]/files/[fileid]/elements/[id]

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingFileElementApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$building_id = "building_id_example"; // string | The identifier of the building.
$file_id = "file_id_example"; // string | The identifier of the building file.
$id = "id_example"; // string | The identifier of the element.

try {
    $apiInstance->apiV11BuildingsByBuildingIdFilesByFileIdElementsByIdDelete($building_id, $file_id, $id);
} catch (Exception $e) {
    echo 'Exception when calling BuildingFileElementApi->apiV11BuildingsByBuildingIdFilesByFileIdElementsByIdDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **building_id** | [**string**](../Model/.md)| The identifier of the building. |
 **file_id** | [**string**](../Model/.md)| The identifier of the building file. |
 **id** | **string**| The identifier of the element. |

### Return type

void (empty response body)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsByBuildingIdFilesByFileIdElementsByIdGet**
> \Swagger\Client\Model\BuildingFileElement apiV11BuildingsByBuildingIdFilesByFileIdElementsByIdGet($building_id, $file_id, $id)

Gets a building file element by its identifier and building file identifier.

Sample request:        GET api/[version]/buildings/[buildingid]/files/[fileid]/elements/[id]

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingFileElementApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$building_id = "building_id_example"; // string | The identifier of the building.
$file_id = "file_id_example"; // string | The identifier of the building file.
$id = "id_example"; // string | The identifier of the element.

try {
    $result = $apiInstance->apiV11BuildingsByBuildingIdFilesByFileIdElementsByIdGet($building_id, $file_id, $id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling BuildingFileElementApi->apiV11BuildingsByBuildingIdFilesByFileIdElementsByIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **building_id** | [**string**](../Model/.md)| The identifier of the building. |
 **file_id** | [**string**](../Model/.md)| The identifier of the building file. |
 **id** | **string**| The identifier of the element. |

### Return type

[**\Swagger\Client\Model\BuildingFileElement**](../Model/BuildingFileElement.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsByBuildingIdFilesByFileIdElementsByIdPut**
> \Swagger\Client\Model\BuildingFileElement apiV11BuildingsByBuildingIdFilesByFileIdElementsByIdPut($building_id, $file_id, $id, $update_element_request)

Updates an existing building file element.

Sample request:        PUT api/[version]/buildings/[buildingid]/files/[fileid]/elements/[id]

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingFileElementApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$building_id = "building_id_example"; // string | The identifier of the building.
$file_id = "file_id_example"; // string | The identifier of the building file.
$id = "id_example"; // string | The identifier of the element.
$update_element_request = new \Swagger\Client\Model\V11CreateBuildingFileElementRequest(); // \Swagger\Client\Model\V11CreateBuildingFileElementRequest | The element to create.

try {
    $result = $apiInstance->apiV11BuildingsByBuildingIdFilesByFileIdElementsByIdPut($building_id, $file_id, $id, $update_element_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling BuildingFileElementApi->apiV11BuildingsByBuildingIdFilesByFileIdElementsByIdPut: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **building_id** | [**string**](../Model/.md)| The identifier of the building. |
 **file_id** | [**string**](../Model/.md)| The identifier of the building file. |
 **id** | **string**| The identifier of the element. |
 **update_element_request** | [**\Swagger\Client\Model\V11CreateBuildingFileElementRequest**](../Model/V11CreateBuildingFileElementRequest.md)| The element to create. | [optional]

### Return type

[**\Swagger\Client\Model\BuildingFileElement**](../Model/BuildingFileElement.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsByBuildingIdFilesByFileIdElementsGet**
> \Swagger\Client\Model\BuildingFileElement[] apiV11BuildingsByBuildingIdFilesByFileIdElementsGet($building_id, $file_id)

Gets a building file elements by its building file identifier.

Sample request:                    GET api/[version]/buildings/[buildingid]/files/[fileid]/elements                ---    This API is ODATA enabled, the following filters can be used:    * $select  * $filter  * $skip  * $top                [READ MORE](https://developer.microsoft.com/en-us/graph/docs/concepts/query_parameters)

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingFileElementApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$building_id = "building_id_example"; // string | The identifier of the building.
$file_id = "file_id_example"; // string | The identifier of the building file.

try {
    $result = $apiInstance->apiV11BuildingsByBuildingIdFilesByFileIdElementsGet($building_id, $file_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling BuildingFileElementApi->apiV11BuildingsByBuildingIdFilesByFileIdElementsGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **building_id** | [**string**](../Model/.md)| The identifier of the building. |
 **file_id** | [**string**](../Model/.md)| The identifier of the building file. |

### Return type

[**\Swagger\Client\Model\BuildingFileElement[]**](../Model/BuildingFileElement.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsByBuildingIdFilesByFileIdElementsPost**
> \Swagger\Client\Model\BuildingFileElement apiV11BuildingsByBuildingIdFilesByFileIdElementsPost($building_id, $file_id, $create_element_request)

Create a new building file element.

Sample request:        POST api/[version]/buildings/[buildingid]/files/[fileid]/elements

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingFileElementApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$building_id = "building_id_example"; // string | The identifier of the building.
$file_id = "file_id_example"; // string | The identifier of the building file.
$create_element_request = new \Swagger\Client\Model\V11CreateBuildingFileElementRequest(); // \Swagger\Client\Model\V11CreateBuildingFileElementRequest | The element to create.

try {
    $result = $apiInstance->apiV11BuildingsByBuildingIdFilesByFileIdElementsPost($building_id, $file_id, $create_element_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling BuildingFileElementApi->apiV11BuildingsByBuildingIdFilesByFileIdElementsPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **building_id** | [**string**](../Model/.md)| The identifier of the building. |
 **file_id** | [**string**](../Model/.md)| The identifier of the building file. |
 **create_element_request** | [**\Swagger\Client\Model\V11CreateBuildingFileElementRequest**](../Model/V11CreateBuildingFileElementRequest.md)| The element to create. | [optional]

### Return type

[**\Swagger\Client\Model\BuildingFileElement**](../Model/BuildingFileElement.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

