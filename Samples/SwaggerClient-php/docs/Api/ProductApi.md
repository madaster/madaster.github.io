# Swagger\Client\ProductApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV11ProductsByIdChildrenGet**](ProductApi.md#apiV11ProductsByIdChildrenGet) | **GET** /api/v1.1/products/{id}/children | Gets the children of a product.
[**apiV11ProductsByIdChildrenPost**](ProductApi.md#apiV11ProductsByIdChildrenPost) | **POST** /api/v1.1/products/{id}/children | Adds a child for a product.
[**apiV11ProductsByIdChildrenPut**](ProductApi.md#apiV11ProductsByIdChildrenPut) | **PUT** /api/v1.1/products/{id}/children | Replaces the children for a product.
[**apiV11ProductsByIdFinancialvaluesGet**](ProductApi.md#apiV11ProductsByIdFinancialvaluesGet) | **GET** /api/v1.1/products/{id}/financialvalues | Gets the financial values of a product.
[**apiV11ProductsByIdFinancialvaluesPost**](ProductApi.md#apiV11ProductsByIdFinancialvaluesPost) | **POST** /api/v1.1/products/{id}/financialvalues | Adds a financial value for a product.
[**apiV11ProductsByIdFinancialvaluesPut**](ProductApi.md#apiV11ProductsByIdFinancialvaluesPut) | **PUT** /api/v1.1/products/{id}/financialvalues | Replaces the financial values for a product.
[**apiV11ProductsByIdGet**](ProductApi.md#apiV11ProductsByIdGet) | **GET** /api/v1.1/products/{id} | Gets a product by its identifier.
[**apiV11ProductsByIdMatchesGet**](ProductApi.md#apiV11ProductsByIdMatchesGet) | **GET** /api/v1.1/products/{id}/matches | Gets the matches of a product.
[**apiV11ProductsByIdMatchesPost**](ProductApi.md#apiV11ProductsByIdMatchesPost) | **POST** /api/v1.1/products/{id}/matches | Adds a match for a product.
[**apiV11ProductsByIdMatchesPut**](ProductApi.md#apiV11ProductsByIdMatchesPut) | **PUT** /api/v1.1/products/{id}/matches | Replaces the matches for a product.
[**apiV11ProductsByIdPut**](ProductApi.md#apiV11ProductsByIdPut) | **PUT** /api/v1.1/products/{id} | Replaces a product.
[**apiV11ProductsGet**](ProductApi.md#apiV11ProductsGet) | **GET** /api/v1.1/products | Gets all products.
[**apiV11ProductsPost**](ProductApi.md#apiV11ProductsPost) | **POST** /api/v1.1/products | Adds a product.


# **apiV11ProductsByIdChildrenGet**
> \Swagger\Client\Model\ProductChild[] apiV11ProductsByIdChildrenGet($id)

Gets the children of a product.

Sample request:  ```  GET api/[version]/products/[id]/children  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\ProductApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the product.

try {
    $result = $apiInstance->apiV11ProductsByIdChildrenGet($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProductApi->apiV11ProductsByIdChildrenGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the product. |

### Return type

[**\Swagger\Client\Model\ProductChild[]**](../Model/ProductChild.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11ProductsByIdChildrenPost**
> \Swagger\Client\Model\ProductChild apiV11ProductsByIdChildrenPost($id, $child)

Adds a child for a product.

Sample request:  ```  POST api/[version]/products/[id]/children  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\ProductApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the product.
$child = new \Swagger\Client\Model\ProductChild(); // \Swagger\Client\Model\ProductChild | The child to add.

try {
    $result = $apiInstance->apiV11ProductsByIdChildrenPost($id, $child);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProductApi->apiV11ProductsByIdChildrenPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the product. |
 **child** | [**\Swagger\Client\Model\ProductChild**](../Model/ProductChild.md)| The child to add. | [optional]

### Return type

[**\Swagger\Client\Model\ProductChild**](../Model/ProductChild.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11ProductsByIdChildrenPut**
> \Swagger\Client\Model\ProductChild[] apiV11ProductsByIdChildrenPut($id, $children)

Replaces the children for a product.

Sample request:  ```  PUT api/[version]/products/[id]/children   ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\ProductApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the product.
$children = array(new \Swagger\Client\Model\ProductChild()); // \Swagger\Client\Model\ProductChild[] | The matches to set.

try {
    $result = $apiInstance->apiV11ProductsByIdChildrenPut($id, $children);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProductApi->apiV11ProductsByIdChildrenPut: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the product. |
 **children** | [**\Swagger\Client\Model\ProductChild[]**](../Model/ProductChild.md)| The matches to set. | [optional]

### Return type

[**\Swagger\Client\Model\ProductChild[]**](../Model/ProductChild.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11ProductsByIdFinancialvaluesGet**
> \Swagger\Client\Model\ProductFinancialValue[] apiV11ProductsByIdFinancialvaluesGet($id)

Gets the financial values of a product.

Sample request:  ```  GET api/[version]/products/[id]/financialvalues  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\ProductApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the product.

try {
    $result = $apiInstance->apiV11ProductsByIdFinancialvaluesGet($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProductApi->apiV11ProductsByIdFinancialvaluesGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the product. |

### Return type

[**\Swagger\Client\Model\ProductFinancialValue[]**](../Model/ProductFinancialValue.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11ProductsByIdFinancialvaluesPost**
> \Swagger\Client\Model\ProductFinancialValue apiV11ProductsByIdFinancialvaluesPost($id, $value)

Adds a financial value for a product.

Sample request:  ```  POST api/[version]/products/[id]/financialvalues  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\ProductApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the product.
$value = new \Swagger\Client\Model\ProductFinancialValue(); // \Swagger\Client\Model\ProductFinancialValue | The value to add.

try {
    $result = $apiInstance->apiV11ProductsByIdFinancialvaluesPost($id, $value);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProductApi->apiV11ProductsByIdFinancialvaluesPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the product. |
 **value** | [**\Swagger\Client\Model\ProductFinancialValue**](../Model/ProductFinancialValue.md)| The value to add. | [optional]

### Return type

[**\Swagger\Client\Model\ProductFinancialValue**](../Model/ProductFinancialValue.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11ProductsByIdFinancialvaluesPut**
> \Swagger\Client\Model\ProductFinancialValue[] apiV11ProductsByIdFinancialvaluesPut($id, $values)

Replaces the financial values for a product.

Sample request:  ```  PUT api/[version]/products/[id]/financialvalues  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\ProductApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the product.
$values = array(new \Swagger\Client\Model\ProductFinancialValue()); // \Swagger\Client\Model\ProductFinancialValue[] | The values to set.

try {
    $result = $apiInstance->apiV11ProductsByIdFinancialvaluesPut($id, $values);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProductApi->apiV11ProductsByIdFinancialvaluesPut: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the product. |
 **values** | [**\Swagger\Client\Model\ProductFinancialValue[]**](../Model/ProductFinancialValue.md)| The values to set. | [optional]

### Return type

[**\Swagger\Client\Model\ProductFinancialValue[]**](../Model/ProductFinancialValue.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11ProductsByIdGet**
> \Swagger\Client\Model\Product apiV11ProductsByIdGet($id)

Gets a product by its identifier.

Sample request:  ```  GET api/[version]/products/[id]  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\ProductApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the product.

try {
    $result = $apiInstance->apiV11ProductsByIdGet($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProductApi->apiV11ProductsByIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the product. |

### Return type

[**\Swagger\Client\Model\Product**](../Model/Product.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11ProductsByIdMatchesGet**
> \Swagger\Client\Model\ProductMatch[] apiV11ProductsByIdMatchesGet($id)

Gets the matches of a product.

Sample request:  ```  GET api/[version]/products/[id]/matches  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\ProductApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the product.

try {
    $result = $apiInstance->apiV11ProductsByIdMatchesGet($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProductApi->apiV11ProductsByIdMatchesGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the product. |

### Return type

[**\Swagger\Client\Model\ProductMatch[]**](../Model/ProductMatch.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11ProductsByIdMatchesPost**
> \Swagger\Client\Model\ProductMatch apiV11ProductsByIdMatchesPost($id, $match)

Adds a match for a product.

Sample request:  ```  POST api/[version]/products/[id]/matches  ```    For now only Name matches are supported.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\ProductApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the product.
$match = new \Swagger\Client\Model\ProductMatch(); // \Swagger\Client\Model\ProductMatch | The match to add.

try {
    $result = $apiInstance->apiV11ProductsByIdMatchesPost($id, $match);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProductApi->apiV11ProductsByIdMatchesPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the product. |
 **match** | [**\Swagger\Client\Model\ProductMatch**](../Model/ProductMatch.md)| The match to add. | [optional]

### Return type

[**\Swagger\Client\Model\ProductMatch**](../Model/ProductMatch.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11ProductsByIdMatchesPut**
> \Swagger\Client\Model\ProductMatch[] apiV11ProductsByIdMatchesPut($id, $matches)

Replaces the matches for a product.

Sample request:  ```  PUT api/[version]/products/[id]/matches  ```    For now only Name matches are supported.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\ProductApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the product.
$matches = array(new \Swagger\Client\Model\ProductMatch()); // \Swagger\Client\Model\ProductMatch[] | The matches to set.

try {
    $result = $apiInstance->apiV11ProductsByIdMatchesPut($id, $matches);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProductApi->apiV11ProductsByIdMatchesPut: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the product. |
 **matches** | [**\Swagger\Client\Model\ProductMatch[]**](../Model/ProductMatch.md)| The matches to set. | [optional]

### Return type

[**\Swagger\Client\Model\ProductMatch[]**](../Model/ProductMatch.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11ProductsByIdPut**
> \Swagger\Client\Model\Product apiV11ProductsByIdPut($id, $product)

Replaces a product.

Sample request:  ```  PUT api/[version]/products/[id]  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\ProductApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier.
$product = new \Swagger\Client\Model\Product(); // \Swagger\Client\Model\Product | The product model.

try {
    $result = $apiInstance->apiV11ProductsByIdPut($id, $product);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProductApi->apiV11ProductsByIdPut: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier. |
 **product** | [**\Swagger\Client\Model\Product**](../Model/Product.md)| The product model. | [optional]

### Return type

[**\Swagger\Client\Model\Product**](../Model/Product.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11ProductsGet**
> \Swagger\Client\Model\Product[] apiV11ProductsGet()

Gets all products.

Sample request:  ```  GET api/[version]/products  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\ProductApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->apiV11ProductsGet();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProductApi->apiV11ProductsGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**\Swagger\Client\Model\Product[]**](../Model/Product.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11ProductsPost**
> \Swagger\Client\Model\Product apiV11ProductsPost($product)

Adds a product.

Sample request:  ```  POST api/[version]/products  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\ProductApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$product = new \Swagger\Client\Model\Product(); // \Swagger\Client\Model\Product | The product model.

try {
    $result = $apiInstance->apiV11ProductsPost($product);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ProductApi->apiV11ProductsPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **product** | [**\Swagger\Client\Model\Product**](../Model/Product.md)| The product model. | [optional]

### Return type

[**\Swagger\Client\Model\Product**](../Model/Product.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

