# Swagger\Client\MaterialApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV11MaterialsByIdFinancialvaluesGet**](MaterialApi.md#apiV11MaterialsByIdFinancialvaluesGet) | **GET** /api/v1.1/materials/{id}/financialvalues | Gets the financial values of a material, for manual import mode.
[**apiV11MaterialsByIdFinancialvaluesPost**](MaterialApi.md#apiV11MaterialsByIdFinancialvaluesPost) | **POST** /api/v1.1/materials/{id}/financialvalues | Adds a financial value for a material, for manual import mode.
[**apiV11MaterialsByIdFinancialvaluesPut**](MaterialApi.md#apiV11MaterialsByIdFinancialvaluesPut) | **PUT** /api/v1.1/materials/{id}/financialvalues | Replaces the financial values for a material, for manual import mode.
[**apiV11MaterialsByIdGet**](MaterialApi.md#apiV11MaterialsByIdGet) | **GET** /api/v1.1/materials/{id} | Gets a material by its identifier.
[**apiV11MaterialsByIdMatchesGet**](MaterialApi.md#apiV11MaterialsByIdMatchesGet) | **GET** /api/v1.1/materials/{id}/matches | Gets the matches of a material.
[**apiV11MaterialsByIdMatchesPost**](MaterialApi.md#apiV11MaterialsByIdMatchesPost) | **POST** /api/v1.1/materials/{id}/matches | Adds a match for a material.
[**apiV11MaterialsByIdMatchesPut**](MaterialApi.md#apiV11MaterialsByIdMatchesPut) | **PUT** /api/v1.1/materials/{id}/matches | Replaces the matches for a material.
[**apiV11MaterialsByIdPut**](MaterialApi.md#apiV11MaterialsByIdPut) | **PUT** /api/v1.1/materials/{id} | Replaces a material.
[**apiV11MaterialsGet**](MaterialApi.md#apiV11MaterialsGet) | **GET** /api/v1.1/materials | Gets all materials.
[**apiV11MaterialsPost**](MaterialApi.md#apiV11MaterialsPost) | **POST** /api/v1.1/materials | Adds a material.


# **apiV11MaterialsByIdFinancialvaluesGet**
> \Swagger\Client\Model\MaterialFinancialValue[] apiV11MaterialsByIdFinancialvaluesGet($id)

Gets the financial values of a material, for manual import mode.

Sample request:  ```  GET api/[version]/materials/[id]/financialvalues  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\MaterialApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the material.

try {
    $result = $apiInstance->apiV11MaterialsByIdFinancialvaluesGet($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling MaterialApi->apiV11MaterialsByIdFinancialvaluesGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the material. |

### Return type

[**\Swagger\Client\Model\MaterialFinancialValue[]**](../Model/MaterialFinancialValue.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11MaterialsByIdFinancialvaluesPost**
> \Swagger\Client\Model\MaterialFinancialValue apiV11MaterialsByIdFinancialvaluesPost($id, $value)

Adds a financial value for a material, for manual import mode.

Sample request:  ```  POST api/[version]/materials/[id]/financialvalues  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\MaterialApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the material.
$value = new \Swagger\Client\Model\MaterialFinancialValue(); // \Swagger\Client\Model\MaterialFinancialValue | The value to add.

try {
    $result = $apiInstance->apiV11MaterialsByIdFinancialvaluesPost($id, $value);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling MaterialApi->apiV11MaterialsByIdFinancialvaluesPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the material. |
 **value** | [**\Swagger\Client\Model\MaterialFinancialValue**](../Model/MaterialFinancialValue.md)| The value to add. | [optional]

### Return type

[**\Swagger\Client\Model\MaterialFinancialValue**](../Model/MaterialFinancialValue.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11MaterialsByIdFinancialvaluesPut**
> \Swagger\Client\Model\MaterialFinancialValue[] apiV11MaterialsByIdFinancialvaluesPut($id, $values)

Replaces the financial values for a material, for manual import mode.

Sample request:  ```  PUT api/[version]/materials/[id]/financialvalues  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\MaterialApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the material.
$values = array(new \Swagger\Client\Model\MaterialFinancialValue()); // \Swagger\Client\Model\MaterialFinancialValue[] | The values to set.

try {
    $result = $apiInstance->apiV11MaterialsByIdFinancialvaluesPut($id, $values);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling MaterialApi->apiV11MaterialsByIdFinancialvaluesPut: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the material. |
 **values** | [**\Swagger\Client\Model\MaterialFinancialValue[]**](../Model/MaterialFinancialValue.md)| The values to set. | [optional]

### Return type

[**\Swagger\Client\Model\MaterialFinancialValue[]**](../Model/MaterialFinancialValue.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11MaterialsByIdGet**
> \Swagger\Client\Model\Material apiV11MaterialsByIdGet($id)

Gets a material by its identifier.

Sample request:  ```  GET api/[version]/materials/[id]  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\MaterialApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the material.

try {
    $result = $apiInstance->apiV11MaterialsByIdGet($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling MaterialApi->apiV11MaterialsByIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the material. |

### Return type

[**\Swagger\Client\Model\Material**](../Model/Material.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11MaterialsByIdMatchesGet**
> \Swagger\Client\Model\MaterialMatch[] apiV11MaterialsByIdMatchesGet($id)

Gets the matches of a material.

Sample request:  ```  GET api/[version]/materials/[id]/matches  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\MaterialApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the material.

try {
    $result = $apiInstance->apiV11MaterialsByIdMatchesGet($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling MaterialApi->apiV11MaterialsByIdMatchesGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the material. |

### Return type

[**\Swagger\Client\Model\MaterialMatch[]**](../Model/MaterialMatch.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11MaterialsByIdMatchesPost**
> \Swagger\Client\Model\MaterialMatch apiV11MaterialsByIdMatchesPost($id, $match)

Adds a match for a material.

Sample request:  ```  POST api/[version]/materials/[id]/matches  ```    For now only Name matches are supported.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\MaterialApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the material.
$match = new \Swagger\Client\Model\MaterialMatch(); // \Swagger\Client\Model\MaterialMatch | The match to add.

try {
    $result = $apiInstance->apiV11MaterialsByIdMatchesPost($id, $match);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling MaterialApi->apiV11MaterialsByIdMatchesPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the material. |
 **match** | [**\Swagger\Client\Model\MaterialMatch**](../Model/MaterialMatch.md)| The match to add. | [optional]

### Return type

[**\Swagger\Client\Model\MaterialMatch**](../Model/MaterialMatch.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11MaterialsByIdMatchesPut**
> \Swagger\Client\Model\MaterialMatch[] apiV11MaterialsByIdMatchesPut($id, $matches)

Replaces the matches for a material.

Sample request:  ```  PUT api/[version]/materials/[id]/matches  ```    For now only Name matches are supported.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\MaterialApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the material.
$matches = array(new \Swagger\Client\Model\MaterialMatch()); // \Swagger\Client\Model\MaterialMatch[] | The matches to set.

try {
    $result = $apiInstance->apiV11MaterialsByIdMatchesPut($id, $matches);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling MaterialApi->apiV11MaterialsByIdMatchesPut: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the material. |
 **matches** | [**\Swagger\Client\Model\MaterialMatch[]**](../Model/MaterialMatch.md)| The matches to set. | [optional]

### Return type

[**\Swagger\Client\Model\MaterialMatch[]**](../Model/MaterialMatch.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11MaterialsByIdPut**
> \Swagger\Client\Model\Material apiV11MaterialsByIdPut($id, $material)

Replaces a material.

Sample request:  ```  PUT api/[version]/materials/[id]  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\MaterialApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier.
$material = new \Swagger\Client\Model\Material(); // \Swagger\Client\Model\Material | The material model.

try {
    $result = $apiInstance->apiV11MaterialsByIdPut($id, $material);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling MaterialApi->apiV11MaterialsByIdPut: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier. |
 **material** | [**\Swagger\Client\Model\Material**](../Model/Material.md)| The material model. | [optional]

### Return type

[**\Swagger\Client\Model\Material**](../Model/Material.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11MaterialsGet**
> \Swagger\Client\Model\Material[] apiV11MaterialsGet()

Gets all materials.

Sample request:  ```  GET api/[version]/materials  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\MaterialApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->apiV11MaterialsGet();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling MaterialApi->apiV11MaterialsGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**\Swagger\Client\Model\Material[]**](../Model/Material.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11MaterialsPost**
> \Swagger\Client\Model\Material apiV11MaterialsPost($material)

Adds a material.

Sample request:   ```  POST api/[version]/materials  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\MaterialApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$material = new \Swagger\Client\Model\Material(); // \Swagger\Client\Model\Material | The material model.

try {
    $result = $apiInstance->apiV11MaterialsPost($material);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling MaterialApi->apiV11MaterialsPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **material** | [**\Swagger\Client\Model\Material**](../Model/Material.md)| The material model. | [optional]

### Return type

[**\Swagger\Client\Model\Material**](../Model/Material.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

