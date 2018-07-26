# Swagger\Client\PortfolioApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV11PortfoliosByIdBuildingsGet**](PortfolioApi.md#apiV11PortfoliosByIdBuildingsGet) | **GET** /api/v1.1/portfolios/{id}/buildings | Gets all buildings for a portfolio.
[**apiV11PortfoliosByIdDelete**](PortfolioApi.md#apiV11PortfoliosByIdDelete) | **DELETE** /api/v1.1/portfolios/{id} | Deletes a portfolio.
[**apiV11PortfoliosByIdGet**](PortfolioApi.md#apiV11PortfoliosByIdGet) | **GET** /api/v1.1/portfolios/{id} | Gets a portfolio by its identifier.
[**apiV11PortfoliosByIdLogoPost**](PortfolioApi.md#apiV11PortfoliosByIdLogoPost) | **POST** /api/v1.1/portfolios/{id}/logo | Sets the logo of a portfolio.
[**apiV11PortfoliosByIdPassportPost**](PortfolioApi.md#apiV11PortfoliosByIdPassportPost) | **POST** /api/v1.1/portfolios/{id}/passport | Schedules the generation of a PDF portfolio passport.
[**apiV11PortfoliosByIdPut**](PortfolioApi.md#apiV11PortfoliosByIdPut) | **PUT** /api/v1.1/portfolios/{id} | Replaces a portfolio.
[**apiV11PortfoliosByIdUsersGet**](PortfolioApi.md#apiV11PortfoliosByIdUsersGet) | **GET** /api/v1.1/portfolios/{id}/users | Gets all users for a portfolio.
[**apiV11PortfoliosByIdUsersPut**](PortfolioApi.md#apiV11PortfoliosByIdUsersPut) | **PUT** /api/v1.1/portfolios/{id}/users | Replaces the security of a users for a portfolio.
[**apiV11PortfoliosGet**](PortfolioApi.md#apiV11PortfoliosGet) | **GET** /api/v1.1/portfolios | Gets all portfolios.
[**apiV11PortfoliosPost**](PortfolioApi.md#apiV11PortfoliosPost) | **POST** /api/v1.1/portfolios | Adds a portfolio.


# **apiV11PortfoliosByIdBuildingsGet**
> \Swagger\Client\Model\BuildingResponse[] apiV11PortfoliosByIdBuildingsGet($id)

Gets all buildings for a portfolio.

Sample request:   ```  GET api/[version]/portfolios/[id]/buildings  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\PortfolioApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the portfolio.

try {
    $result = $apiInstance->apiV11PortfoliosByIdBuildingsGet($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PortfolioApi->apiV11PortfoliosByIdBuildingsGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the portfolio. |

### Return type

[**\Swagger\Client\Model\BuildingResponse[]**](../Model/BuildingResponse.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11PortfoliosByIdDelete**
> apiV11PortfoliosByIdDelete($id)

Deletes a portfolio.

Sample request:  ```  DELETE api/[version]/portfolios/[id]  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\PortfolioApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the portfolio.

try {
    $apiInstance->apiV11PortfoliosByIdDelete($id);
} catch (Exception $e) {
    echo 'Exception when calling PortfolioApi->apiV11PortfoliosByIdDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the portfolio. |

### Return type

void (empty response body)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11PortfoliosByIdGet**
> \Swagger\Client\Model\PortfolioResponse apiV11PortfoliosByIdGet($id)

Gets a portfolio by its identifier.

Sample request:  ```  GET api/[version]/portfolios/[id]  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\PortfolioApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the portfolio.

try {
    $result = $apiInstance->apiV11PortfoliosByIdGet($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PortfolioApi->apiV11PortfoliosByIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the portfolio. |

### Return type

[**\Swagger\Client\Model\PortfolioResponse**](../Model/PortfolioResponse.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11PortfoliosByIdLogoPost**
> string apiV11PortfoliosByIdLogoPost($id, $attachment)

Sets the logo of a portfolio.

Sample request:  ```  POST api/[version]/portfolios/[id]/logo  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\PortfolioApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the portfolio.
$attachment = "/path/to/file.txt"; // \SplFileObject | The logo file.

try {
    $result = $apiInstance->apiV11PortfoliosByIdLogoPost($id, $attachment);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PortfolioApi->apiV11PortfoliosByIdLogoPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the portfolio. |
 **attachment** | **\SplFileObject**| The logo file. |

### Return type

**string**

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: multipart/form-data, multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11PortfoliosByIdPassportPost**
> \Swagger\Client\Model\V11PortfolioFileResponse apiV11PortfoliosByIdPassportPost($id, $create_passport_request, $accept_language)

Schedules the generation of a PDF portfolio passport.

Sample request:  ```  POST api/[version]/portfolios/[id]/passport  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\PortfolioApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the portfolio.
$create_passport_request = new \Swagger\Client\Model\V11CreatePassportRequest(); // \Swagger\Client\Model\V11CreatePassportRequest | The request information to create the passport.
$accept_language = "en"; // string | The culture to use for the request

try {
    $result = $apiInstance->apiV11PortfoliosByIdPassportPost($id, $create_passport_request, $accept_language);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PortfolioApi->apiV11PortfoliosByIdPassportPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the portfolio. |
 **create_passport_request** | [**\Swagger\Client\Model\V11CreatePassportRequest**](../Model/V11CreatePassportRequest.md)| The request information to create the passport. | [optional]
 **accept_language** | **string**| The culture to use for the request | [optional] [default to en]

### Return type

[**\Swagger\Client\Model\V11PortfolioFileResponse**](../Model/V11PortfolioFileResponse.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11PortfoliosByIdPut**
> \Swagger\Client\Model\PortfolioResponse apiV11PortfoliosByIdPut($id, $portfolio)

Replaces a portfolio.

Sample request:  ```  PUT api/[version]/portfolios/[id]  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\PortfolioApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the portfolio.
$portfolio = new \Swagger\Client\Model\PortfolioRequest(); // \Swagger\Client\Model\PortfolioRequest | The portfolio model.

try {
    $result = $apiInstance->apiV11PortfoliosByIdPut($id, $portfolio);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PortfolioApi->apiV11PortfoliosByIdPut: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the portfolio. |
 **portfolio** | [**\Swagger\Client\Model\PortfolioRequest**](../Model/PortfolioRequest.md)| The portfolio model. | [optional]

### Return type

[**\Swagger\Client\Model\PortfolioResponse**](../Model/PortfolioResponse.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11PortfoliosByIdUsersGet**
> \Swagger\Client\Model\V11UserRightResponse[] apiV11PortfoliosByIdUsersGet($id)

Gets all users for a portfolio.

Sample request:   ```  GET api/[version]/portfolios/[id]/users  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\PortfolioApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the portfolio.

try {
    $result = $apiInstance->apiV11PortfoliosByIdUsersGet($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PortfolioApi->apiV11PortfoliosByIdUsersGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The identifier of the portfolio. |

### Return type

[**\Swagger\Client\Model\V11UserRightResponse[]**](../Model/V11UserRightResponse.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11PortfoliosByIdUsersPut**
> \Swagger\Client\Model\V11UserRightResponse apiV11PortfoliosByIdUsersPut($id, $users)

Replaces the security of a users for a portfolio.

Sample request:  ```  PUT api/[version]/portfolios/[id]/users  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\PortfolioApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | The identifier of the portfolio.
$users = array(new \Swagger\Client\Model\V11UserRightRequest()); // \Swagger\Client\Model\V11UserRightRequest[] | The users to set.

try {
    $result = $apiInstance->apiV11PortfoliosByIdUsersPut($id, $users);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PortfolioApi->apiV11PortfoliosByIdUsersPut: ', $e->getMessage(), PHP_EOL;
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

# **apiV11PortfoliosGet**
> \Swagger\Client\Model\PortfolioResponse[] apiV11PortfoliosGet()

Gets all portfolios.

Sample request:  ```  GET api/[version]/portfolios  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\PortfolioApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $result = $apiInstance->apiV11PortfoliosGet();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PortfolioApi->apiV11PortfoliosGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**\Swagger\Client\Model\PortfolioResponse[]**](../Model/PortfolioResponse.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11PortfoliosPost**
> \Swagger\Client\Model\PortfolioResponse apiV11PortfoliosPost($portfolio)

Adds a portfolio.

Sample request:  ```  POST api/[version]/portfolios  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\PortfolioApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$portfolio = new \Swagger\Client\Model\PortfolioRequest(); // \Swagger\Client\Model\PortfolioRequest | The portfolio model.

try {
    $result = $apiInstance->apiV11PortfoliosPost($portfolio);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PortfolioApi->apiV11PortfoliosPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **portfolio** | [**\Swagger\Client\Model\PortfolioRequest**](../Model/PortfolioRequest.md)| The portfolio model. | [optional]

### Return type

[**\Swagger\Client\Model\PortfolioResponse**](../Model/PortfolioResponse.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

