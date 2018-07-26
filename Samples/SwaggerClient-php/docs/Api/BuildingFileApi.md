# Swagger\Client\BuildingFileApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV11BuildingsByBuildingIdFilesByIdActivePost**](BuildingFileApi.md#apiV11BuildingsByBuildingIdFilesByIdActivePost) | **POST** /api/v1.1/buildings/{buildingId}/files/{id}/active | Activates or deactivates a building file.
[**apiV11BuildingsByBuildingIdFilesByIdDelete**](BuildingFileApi.md#apiV11BuildingsByBuildingIdFilesByIdDelete) | **DELETE** /api/v1.1/buildings/{buildingId}/files/{id} | Deletes a building file.
[**apiV11BuildingsByBuildingIdFilesByIdDownloadGet**](BuildingFileApi.md#apiV11BuildingsByBuildingIdFilesByIdDownloadGet) | **GET** /api/v1.1/buildings/{buildingId}/files/{id}/download | Gets a download url for the building file.
[**apiV11BuildingsByBuildingIdFilesByIdGet**](BuildingFileApi.md#apiV11BuildingsByBuildingIdFilesByIdGet) | **GET** /api/v1.1/buildings/{buildingId}/files/{id} | Gets a building file by its identifier.
[**apiV11BuildingsByBuildingIdFilesByIdSetimportingPost**](BuildingFileApi.md#apiV11BuildingsByBuildingIdFilesByIdSetimportingPost) | **POST** /api/v1.1/buildings/{buildingId}/files/{id}/setimporting | Sets the status of a file to &#39;importing&#39;, so element can be added or updated can be made.
[**apiV11BuildingsByBuildingIdFilesByIdStartrefinementPost**](BuildingFileApi.md#apiV11BuildingsByBuildingIdFilesByIdStartrefinementPost) | **POST** /api/v1.1/buildings/{buildingId}/files/{id}/startrefinement | Starts the refinement of a building file.
[**apiV11BuildingsByBuildingIdFilesByIdStatusGet**](BuildingFileApi.md#apiV11BuildingsByBuildingIdFilesByIdStatusGet) | **GET** /api/v1.1/buildings/{buildingId}/files/{id}/status | Gets a building file status by its identifier.
[**apiV11BuildingsByBuildingIdFilesByIdUploadPost**](BuildingFileApi.md#apiV11BuildingsByBuildingIdFilesByIdUploadPost) | **POST** /api/v1.1/buildings/{buildingId}/files/{id}/upload | Uploads a building file.
[**apiV11BuildingsByBuildingIdFilesGet**](BuildingFileApi.md#apiV11BuildingsByBuildingIdFilesGet) | **GET** /api/v1.1/buildings/{buildingId}/files | Gets all building files.
[**apiV11BuildingsByBuildingIdFilesPost**](BuildingFileApi.md#apiV11BuildingsByBuildingIdFilesPost) | **POST** /api/v1.1/buildings/{buildingId}/files | Adds a building file.


# **apiV11BuildingsByBuildingIdFilesByIdActivePost**
> \Swagger\Client\Model\BuildingFileResponse apiV11BuildingsByBuildingIdFilesByIdActivePost($building_id, $id, $is_active)

Activates or deactivates a building file.

Sample request:  ```  POST api/[version]/buildings/[buildingId]/files/[id]/active  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingFileApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$building_id = "building_id_example"; // string | The identifier of the building.
$id = "id_example"; // string | The identifier of the building file.
$is_active = true; // bool | The new active-status.

try {
    $result = $apiInstance->apiV11BuildingsByBuildingIdFilesByIdActivePost($building_id, $id, $is_active);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling BuildingFileApi->apiV11BuildingsByBuildingIdFilesByIdActivePost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **building_id** | [**string**](../Model/.md)| The identifier of the building. |
 **id** | [**string**](../Model/.md)| The identifier of the building file. |
 **is_active** | **bool**| The new active-status. | [optional]

### Return type

[**\Swagger\Client\Model\BuildingFileResponse**](../Model/BuildingFileResponse.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsByBuildingIdFilesByIdDelete**
> apiV11BuildingsByBuildingIdFilesByIdDelete($building_id, $id)

Deletes a building file.

Sample request:  ```  DELETE api/[version]/buildings/[buildingId]/file/[id]  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingFileApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$building_id = "building_id_example"; // string | The building identifier.
$id = "id_example"; // string | The identifier of the building.

try {
    $apiInstance->apiV11BuildingsByBuildingIdFilesByIdDelete($building_id, $id);
} catch (Exception $e) {
    echo 'Exception when calling BuildingFileApi->apiV11BuildingsByBuildingIdFilesByIdDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **building_id** | [**string**](../Model/.md)| The building identifier. |
 **id** | [**string**](../Model/.md)| The identifier of the building. |

### Return type

void (empty response body)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsByBuildingIdFilesByIdDownloadGet**
> \Swagger\Client\Model\V11FileDownloadResponse apiV11BuildingsByBuildingIdFilesByIdDownloadGet($building_id, $id)

Gets a download url for the building file.

Sample request:  ```  GET api/[version]/buildings/[buildingId]/file/[id]/download  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingFileApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$building_id = "building_id_example"; // string | The identifier of the building.
$id = "id_example"; // string | The identifier of the building file.

try {
    $result = $apiInstance->apiV11BuildingsByBuildingIdFilesByIdDownloadGet($building_id, $id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling BuildingFileApi->apiV11BuildingsByBuildingIdFilesByIdDownloadGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **building_id** | [**string**](../Model/.md)| The identifier of the building. |
 **id** | [**string**](../Model/.md)| The identifier of the building file. |

### Return type

[**\Swagger\Client\Model\V11FileDownloadResponse**](../Model/V11FileDownloadResponse.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsByBuildingIdFilesByIdGet**
> \Swagger\Client\Model\BuildingFileResponse apiV11BuildingsByBuildingIdFilesByIdGet($building_id, $id)

Gets a building file by its identifier.

Sample request:  ```  GET api/[version]/buildings/[buildingId]/files/[id]  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingFileApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$building_id = "building_id_example"; // string | The identifier of the building.
$id = "id_example"; // string | The identifier of the building file.

try {
    $result = $apiInstance->apiV11BuildingsByBuildingIdFilesByIdGet($building_id, $id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling BuildingFileApi->apiV11BuildingsByBuildingIdFilesByIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **building_id** | [**string**](../Model/.md)| The identifier of the building. |
 **id** | [**string**](../Model/.md)| The identifier of the building file. |

### Return type

[**\Swagger\Client\Model\BuildingFileResponse**](../Model/BuildingFileResponse.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsByBuildingIdFilesByIdSetimportingPost**
> apiV11BuildingsByBuildingIdFilesByIdSetimportingPost($building_id, $id)

Sets the status of a file to 'importing', so element can be added or updated can be made.

Sample request:  ```  POST api/[version]/buildings/[buildingId]/files/[id]/setimporting  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingFileApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$building_id = "building_id_example"; // string | The identifier of the building.
$id = "id_example"; // string | The identifier of the building file.

try {
    $apiInstance->apiV11BuildingsByBuildingIdFilesByIdSetimportingPost($building_id, $id);
} catch (Exception $e) {
    echo 'Exception when calling BuildingFileApi->apiV11BuildingsByBuildingIdFilesByIdSetimportingPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **building_id** | [**string**](../Model/.md)| The identifier of the building. |
 **id** | [**string**](../Model/.md)| The identifier of the building file. |

### Return type

void (empty response body)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsByBuildingIdFilesByIdStartrefinementPost**
> apiV11BuildingsByBuildingIdFilesByIdStartrefinementPost($building_id, $id)

Starts the refinement of a building file.

Sample request:  ```  POST api/[version]/buildings/[buildingId]/files/[id]/startrefinement  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingFileApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$building_id = "building_id_example"; // string | The identifier of the building.
$id = "id_example"; // string | The identifier of the building file.

try {
    $apiInstance->apiV11BuildingsByBuildingIdFilesByIdStartrefinementPost($building_id, $id);
} catch (Exception $e) {
    echo 'Exception when calling BuildingFileApi->apiV11BuildingsByBuildingIdFilesByIdStartrefinementPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **building_id** | [**string**](../Model/.md)| The identifier of the building. |
 **id** | [**string**](../Model/.md)| The identifier of the building file. |

### Return type

void (empty response body)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsByBuildingIdFilesByIdStatusGet**
> \Swagger\Client\Model\BuildingFileStatusResponse apiV11BuildingsByBuildingIdFilesByIdStatusGet($building_id, $id)

Gets a building file status by its identifier.

Sample request:  ```  GET api/[version]/buildings/[buildingId]/files/[id]/status  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingFileApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$building_id = "building_id_example"; // string | The identifier of the building.
$id = "id_example"; // string | The identifier of the building file.

try {
    $result = $apiInstance->apiV11BuildingsByBuildingIdFilesByIdStatusGet($building_id, $id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling BuildingFileApi->apiV11BuildingsByBuildingIdFilesByIdStatusGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **building_id** | [**string**](../Model/.md)| The identifier of the building. |
 **id** | [**string**](../Model/.md)| The identifier of the building file. |

### Return type

[**\Swagger\Client\Model\BuildingFileStatusResponse**](../Model/BuildingFileStatusResponse.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsByBuildingIdFilesByIdUploadPost**
> apiV11BuildingsByBuildingIdFilesByIdUploadPost($building_id, $id, $attachment)

Uploads a building file.

Sample request:  ```  POST api/[version]/buildings/[buildingId]/files/[id]/upload  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingFileApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$building_id = "building_id_example"; // string | The building identifier.
$id = "id_example"; // string | The building file identifier.
$attachment = "/path/to/file.txt"; // \SplFileObject | The attachment.

try {
    $apiInstance->apiV11BuildingsByBuildingIdFilesByIdUploadPost($building_id, $id, $attachment);
} catch (Exception $e) {
    echo 'Exception when calling BuildingFileApi->apiV11BuildingsByBuildingIdFilesByIdUploadPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **building_id** | [**string**](../Model/.md)| The building identifier. |
 **id** | [**string**](../Model/.md)| The building file identifier. |
 **attachment** | **\SplFileObject**| The attachment. | [optional]

### Return type

void (empty response body)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: multipart/form-data, multipart/form-data
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsByBuildingIdFilesGet**
> \Swagger\Client\Model\BuildingFileResponse[] apiV11BuildingsByBuildingIdFilesGet($building_id)

Gets all building files.

Sample request:  ```  GET api/[version]/buildings/[buildingId]/files  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingFileApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$building_id = "building_id_example"; // string | 

try {
    $result = $apiInstance->apiV11BuildingsByBuildingIdFilesGet($building_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling BuildingFileApi->apiV11BuildingsByBuildingIdFilesGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **building_id** | [**string**](../Model/.md)|  |

### Return type

[**\Swagger\Client\Model\BuildingFileResponse[]**](../Model/BuildingFileResponse.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsByBuildingIdFilesPost**
> \Swagger\Client\Model\BuildingFileResponse apiV11BuildingsByBuildingIdFilesPost($building_id, $building_file)

Adds a building file.

Sample request:   ```  POST api/[version]/buildings/[buildingId]/files  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingFileApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$building_id = "building_id_example"; // string | The building identifier.
$building_file = new \Swagger\Client\Model\V11BuildingFileRequest(); // \Swagger\Client\Model\V11BuildingFileRequest | The building file model.

try {
    $result = $apiInstance->apiV11BuildingsByBuildingIdFilesPost($building_id, $building_file);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling BuildingFileApi->apiV11BuildingsByBuildingIdFilesPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **building_id** | [**string**](../Model/.md)| The building identifier. |
 **building_file** | [**\Swagger\Client\Model\V11BuildingFileRequest**](../Model/V11BuildingFileRequest.md)| The building file model. | [optional]

### Return type

[**\Swagger\Client\Model\BuildingFileResponse**](../Model/BuildingFileResponse.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

