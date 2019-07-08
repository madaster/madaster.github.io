# Swagger\Client\BuildingApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV11BuildingsByIdCircularGet**](BuildingApi.md#apiV11BuildingsByIdCircularGet) | **GET** /api/v1.1/buildings/{id}/circular | Gets the circular information of a buildnig.
[**apiV11BuildingsByIdDelete**](BuildingApi.md#apiV11BuildingsByIdDelete) | **DELETE** /api/v1.1/buildings/{id} | Deletes the building and all related data.
[**apiV11BuildingsByIdExportexcelpassportPost**](BuildingApi.md#apiV11BuildingsByIdExportexcelpassportPost) | **POST** /api/v1.1/buildings/{id}/exportexcelpassport | Schedules the generation of a PDF building passport.
[**apiV11BuildingsByIdExportpassportPost**](BuildingApi.md#apiV11BuildingsByIdExportpassportPost) | **POST** /api/v1.1/buildings/{id}/exportpassport | Schedules the generation of a PDF building passport.
[**apiV11BuildingsByIdFinancialGet**](BuildingApi.md#apiV11BuildingsByIdFinancialGet) | **GET** /api/v1.1/buildings/{id}/financial | Gets the financial information of a buildnig.
[**apiV11BuildingsByIdGet**](BuildingApi.md#apiV11BuildingsByIdGet) | **GET** /api/v1.1/buildings/{id} | Gets a building by its identifier.
[**apiV11BuildingsByIdImagesPost**](BuildingApi.md#apiV11BuildingsByIdImagesPost) | **POST** /api/v1.1/buildings/{id}/images | Adds an image to a building.
[**apiV11BuildingsByIdProcessPost**](BuildingApi.md#apiV11BuildingsByIdProcessPost) | **POST** /api/v1.1/buildings/{id}/process | Schedules the building for proccesing, recalculates all data.
[**apiV11BuildingsByIdPut**](BuildingApi.md#apiV11BuildingsByIdPut) | **PUT** /api/v1.1/buildings/{id} | Replaces a building.
[**apiV11BuildingsByIdUsersGet**](BuildingApi.md#apiV11BuildingsByIdUsersGet) | **GET** /api/v1.1/buildings/{id}/users | Gets all users for a building.
[**apiV11BuildingsByIdUsersPut**](BuildingApi.md#apiV11BuildingsByIdUsersPut) | **PUT** /api/v1.1/buildings/{id}/users | Replaces the security of a users for a building.
[**apiV11BuildingsByIdValidateGet**](BuildingApi.md#apiV11BuildingsByIdValidateGet) | **GET** /api/v1.1/buildings/{id}/validate | Gets building validation parameters.
[**apiV11BuildingsGet**](BuildingApi.md#apiV11BuildingsGet) | **GET** /api/v1.1/buildings | Gets all buildings.
[**apiV11BuildingsPost**](BuildingApi.md#apiV11BuildingsPost) | **POST** /api/v1.1/buildings | Adds a building.


# **apiV11BuildingsByIdCircularGet**
> string apiV11BuildingsByIdCircularGet($id)

Gets the circular information of a buildnig.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the building.

try {
    $result = $apiInstance->apiV11BuildingsByIdCircularGet($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling BuildingApi->apiV11BuildingsByIdCircularGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the building. |

### Return type

**string**

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsByIdDelete**
> apiV11BuildingsByIdDelete($id)

Deletes the building and all related data.

<returns>              The building was successfully deleted.              </returns>              Sample request:              ```              DELETE api/[version]/buildings/[id]/delete              ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the building.

try {
    $apiInstance->apiV11BuildingsByIdDelete($id);
} catch (Exception $e) {
    echo 'Exception when calling BuildingApi->apiV11BuildingsByIdDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the building. |

### Return type

void (empty response body)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsByIdExportexcelpassportPost**
> apiV11BuildingsByIdExportexcelpassportPost($id, $accept_language)

Schedules the generation of a PDF building passport.

Sample request:  ```  POST api/[version]/buildings/[id]/exportexcelpassport  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the building.
$accept_language = "en"; // string | The culture to use for the request

try {
    $apiInstance->apiV11BuildingsByIdExportexcelpassportPost($id, $accept_language);
} catch (Exception $e) {
    echo 'Exception when calling BuildingApi->apiV11BuildingsByIdExportexcelpassportPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the building. |
 **accept_language** | **string**| The culture to use for the request | [optional] [default to en]

### Return type

void (empty response body)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsByIdExportpassportPost**
> apiV11BuildingsByIdExportpassportPost($id, $accept_language)

Schedules the generation of a PDF building passport.

Sample request:  ```  POST api/[version]/buildings/[id]/exportpassport  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the building.
$accept_language = "en"; // string | The culture to use for the request

try {
    $apiInstance->apiV11BuildingsByIdExportpassportPost($id, $accept_language);
} catch (Exception $e) {
    echo 'Exception when calling BuildingApi->apiV11BuildingsByIdExportpassportPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the building. |
 **accept_language** | **string**| The culture to use for the request | [optional] [default to en]

### Return type

void (empty response body)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsByIdFinancialGet**
> string apiV11BuildingsByIdFinancialGet($id)

Gets the financial information of a buildnig.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the building.

try {
    $result = $apiInstance->apiV11BuildingsByIdFinancialGet($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling BuildingApi->apiV11BuildingsByIdFinancialGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the building. |

### Return type

**string**

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsByIdGet**
> \Swagger\Client\Model\BuildingResponse apiV11BuildingsByIdGet($id)

Gets a building by its identifier.

Sample request:  ```  GET api/[version]/buildings/[id]  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the building.

try {
    $result = $apiInstance->apiV11BuildingsByIdGet($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling BuildingApi->apiV11BuildingsByIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the building. |

### Return type

[**\Swagger\Client\Model\BuildingResponse**](../Model/BuildingResponse.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsByIdImagesPost**
> string apiV11BuildingsByIdImagesPost($id, $attachment)

Adds an image to a building.

Sample request:  ```  POST api/[version]/buildings/[id]/images  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the building.
$attachment = "/path/to/file.txt"; // \SplFileObject | The logo file.

try {
    $result = $apiInstance->apiV11BuildingsByIdImagesPost($id, $attachment);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling BuildingApi->apiV11BuildingsByIdImagesPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the building. |
 **attachment** | **\SplFileObject**| The logo file. |

### Return type

**string**

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: multipart/form-data, multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsByIdProcessPost**
> apiV11BuildingsByIdProcessPost($id)

Schedules the building for proccesing, recalculates all data.

Sample request:  ```  POST api/[version]/buildings/[id]/process  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the building.

try {
    $apiInstance->apiV11BuildingsByIdProcessPost($id);
} catch (Exception $e) {
    echo 'Exception when calling BuildingApi->apiV11BuildingsByIdProcessPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the building. |

### Return type

void (empty response body)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsByIdPut**
> \Swagger\Client\Model\BuildingResponse apiV11BuildingsByIdPut($id, $building)

Replaces a building.

Sample request:  ```  PUT api/[version]/buildings/[id]  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the building.
$building = new \Swagger\Client\Model\BuildingRequest(); // \Swagger\Client\Model\BuildingRequest | The building model.

try {
    $result = $apiInstance->apiV11BuildingsByIdPut($id, $building);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling BuildingApi->apiV11BuildingsByIdPut: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the building. |
 **building** | [**\Swagger\Client\Model\BuildingRequest**](../Model/BuildingRequest.md)| The building model. | [optional]

### Return type

[**\Swagger\Client\Model\BuildingResponse**](../Model/BuildingResponse.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsByIdUsersGet**
> \Swagger\Client\Model\V11UserRightResponse[] apiV11BuildingsByIdUsersGet($id)

Gets all users for a building.

Sample request:   ```  GET api/[version]/buildings/[id]/users  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the building.

try {
    $result = $apiInstance->apiV11BuildingsByIdUsersGet($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling BuildingApi->apiV11BuildingsByIdUsersGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the building. |

### Return type

[**\Swagger\Client\Model\V11UserRightResponse[]**](../Model/V11UserRightResponse.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsByIdUsersPut**
> \Swagger\Client\Model\V11UserRightResponse apiV11BuildingsByIdUsersPut($id, $users)

Replaces the security of a users for a building.

Sample request:  ```  PUT api/[version]/portfolios/[id]/users  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the portfolio.
$users = array(new \Swagger\Client\Model\V11UserRightRequest()); // \Swagger\Client\Model\V11UserRightRequest[] | The users to set.

try {
    $result = $apiInstance->apiV11BuildingsByIdUsersPut($id, $users);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling BuildingApi->apiV11BuildingsByIdUsersPut: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the portfolio. |
 **users** | [**\Swagger\Client\Model\V11UserRightRequest[]**](../Model/V11UserRightRequest.md)| The users to set. | [optional]

### Return type

[**\Swagger\Client\Model\V11UserRightResponse**](../Model/V11UserRightResponse.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsByIdValidateGet**
> \Swagger\Client\Model\V11ValidationGraph[] apiV11BuildingsByIdValidateGet($id)

Gets building validation parameters.

Sample request:   ```  GET api/[version]/buildings/[id]/validate  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the building.

try {
    $result = $apiInstance->apiV11BuildingsByIdValidateGet($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling BuildingApi->apiV11BuildingsByIdValidateGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the building. |

### Return type

[**\Swagger\Client\Model\V11ValidationGraph[]**](../Model/V11ValidationGraph.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsGet**
> \Swagger\Client\Model\BuildingResponse[] apiV11BuildingsGet()

Gets all buildings.

Sample request:   ```  GET api/[version]/buildings  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->apiV11BuildingsGet();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling BuildingApi->apiV11BuildingsGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**\Swagger\Client\Model\BuildingResponse[]**](../Model/BuildingResponse.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11BuildingsPost**
> \Swagger\Client\Model\BuildingResponse apiV11BuildingsPost($building)

Adds a building.

Sample request:  ```  POST api/[version]/buildings  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\BuildingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$building = new \Swagger\Client\Model\V11BuildingRequest(); // \Swagger\Client\Model\V11BuildingRequest | The building model.

try {
    $result = $apiInstance->apiV11BuildingsPost($building);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling BuildingApi->apiV11BuildingsPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **building** | [**\Swagger\Client\Model\V11BuildingRequest**](../Model/V11BuildingRequest.md)| The building model. | [optional]

### Return type

[**\Swagger\Client\Model\BuildingResponse**](../Model/BuildingResponse.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

