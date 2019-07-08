# Swagger\Client\PortfolioFileApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiV11PortfoliosByPortfolioIdFilesByIdDelete**](PortfolioFileApi.md#apiV11PortfoliosByPortfolioIdFilesByIdDelete) | **DELETE** /api/v1.1/portfolios/{portfolioId}/files/{id} | Deletes a portfolio file.
[**apiV11PortfoliosByPortfolioIdFilesByIdDownloadGet**](PortfolioFileApi.md#apiV11PortfoliosByPortfolioIdFilesByIdDownloadGet) | **GET** /api/v1.1/portfolios/{portfolioId}/files/{id}/download | Gets a download url for the portfolio file.
[**apiV11PortfoliosByPortfolioIdFilesByIdGet**](PortfolioFileApi.md#apiV11PortfoliosByPortfolioIdFilesByIdGet) | **GET** /api/v1.1/portfolios/{portfolioId}/files/{id} | Gets a portfolio file by its identifier.
[**apiV11PortfoliosByPortfolioIdFilesByIdStatusGet**](PortfolioFileApi.md#apiV11PortfoliosByPortfolioIdFilesByIdStatusGet) | **GET** /api/v1.1/portfolios/{portfolioId}/files/{id}/status | Gets a portfolio file status by its identifier.
[**apiV11PortfoliosByPortfolioIdFilesByIdUploadPost**](PortfolioFileApi.md#apiV11PortfoliosByPortfolioIdFilesByIdUploadPost) | **POST** /api/v1.1/portfolios/{portfolioId}/files/{id}/upload | Uploads a portfolio file.
[**apiV11PortfoliosByPortfolioIdFilesGet**](PortfolioFileApi.md#apiV11PortfoliosByPortfolioIdFilesGet) | **GET** /api/v1.1/portfolios/{portfolioId}/files | Gets all portfolio files for a portfolio.
[**apiV11PortfoliosByPortfolioIdFilesPost**](PortfolioFileApi.md#apiV11PortfoliosByPortfolioIdFilesPost) | **POST** /api/v1.1/portfolios/{portfolioId}/files | Adds a portfolio file.


# **apiV11PortfoliosByPortfolioIdFilesByIdDelete**
> apiV11PortfoliosByPortfolioIdFilesByIdDelete($portfolio_id, $id)

Deletes a portfolio file.

Sample request:  ```  DELETE api/[version]/portfolios/[portfolioId]/file/[id]  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\PortfolioFileApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$portfolio_id = "portfolio_id_example"; // string | The portfolio identifier.
$id = "id_example"; // string | The identifier of the portfolio.

try {
    $apiInstance->apiV11PortfoliosByPortfolioIdFilesByIdDelete($portfolio_id, $id);
} catch (Exception $e) {
    echo 'Exception when calling PortfolioFileApi->apiV11PortfoliosByPortfolioIdFilesByIdDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **portfolio_id** | [**string**](../Model/.md)| The portfolio identifier. |
 **id** | [**string**](../Model/.md)| The identifier of the portfolio. |

### Return type

void (empty response body)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11PortfoliosByPortfolioIdFilesByIdDownloadGet**
> \Swagger\Client\Model\V11FileDownloadResponse apiV11PortfoliosByPortfolioIdFilesByIdDownloadGet($portfolio_id, $id)

Gets a download url for the portfolio file.

Sample request:  ```  GET api/[version]/portfolios/[portfolioId]/file/[id]/download  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\PortfolioFileApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$portfolio_id = "portfolio_id_example"; // string | The identifier of the portfolio.
$id = "id_example"; // string | The identifier of the portfolio file.

try {
    $result = $apiInstance->apiV11PortfoliosByPortfolioIdFilesByIdDownloadGet($portfolio_id, $id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PortfolioFileApi->apiV11PortfoliosByPortfolioIdFilesByIdDownloadGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **portfolio_id** | [**string**](../Model/.md)| The identifier of the portfolio. |
 **id** | [**string**](../Model/.md)| The identifier of the portfolio file. |

### Return type

[**\Swagger\Client\Model\V11FileDownloadResponse**](../Model/V11FileDownloadResponse.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11PortfoliosByPortfolioIdFilesByIdGet**
> \Swagger\Client\Model\V11PortfolioFileResponse apiV11PortfoliosByPortfolioIdFilesByIdGet($portfolio_id, $id)

Gets a portfolio file by its identifier.

Sample request:  ```  GET api/[version]/portfolios/[portfolioId]/file/[id]  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\PortfolioFileApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$portfolio_id = "portfolio_id_example"; // string | The identifier of the portfolio.
$id = "id_example"; // string | The identifier of the portfolio file.

try {
    $result = $apiInstance->apiV11PortfoliosByPortfolioIdFilesByIdGet($portfolio_id, $id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PortfolioFileApi->apiV11PortfoliosByPortfolioIdFilesByIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **portfolio_id** | [**string**](../Model/.md)| The identifier of the portfolio. |
 **id** | [**string**](../Model/.md)| The identifier of the portfolio file. |

### Return type

[**\Swagger\Client\Model\V11PortfolioFileResponse**](../Model/V11PortfolioFileResponse.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11PortfoliosByPortfolioIdFilesByIdStatusGet**
> \Swagger\Client\Model\V11PortfolioFileStatusResponse apiV11PortfoliosByPortfolioIdFilesByIdStatusGet($portfolio_id, $id)

Gets a portfolio file status by its identifier.

Sample request:  ```  GET api/[version]/portfolios/[portfolioId]/file/[id]/status  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\PortfolioFileApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$portfolio_id = "portfolio_id_example"; // string | The identifier of the portfolio.
$id = "id_example"; // string | The identifier of the portfolio file.

try {
    $result = $apiInstance->apiV11PortfoliosByPortfolioIdFilesByIdStatusGet($portfolio_id, $id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PortfolioFileApi->apiV11PortfoliosByPortfolioIdFilesByIdStatusGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **portfolio_id** | [**string**](../Model/.md)| The identifier of the portfolio. |
 **id** | [**string**](../Model/.md)| The identifier of the portfolio file. |

### Return type

[**\Swagger\Client\Model\V11PortfolioFileStatusResponse**](../Model/V11PortfolioFileStatusResponse.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11PortfoliosByPortfolioIdFilesByIdUploadPost**
> apiV11PortfoliosByPortfolioIdFilesByIdUploadPost($portfolio_id, $id, $attachment)

Uploads a portfolio file.

Sample request:  ```  POST api/[version]/portfolios/[portfolioId]/file/upload  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\PortfolioFileApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$portfolio_id = "portfolio_id_example"; // string | The portfolio identifier.
$id = "id_example"; // string | The portfolio file identifier.
$attachment = "/path/to/file.txt"; // \SplFileObject | The attachment.

try {
    $apiInstance->apiV11PortfoliosByPortfolioIdFilesByIdUploadPost($portfolio_id, $id, $attachment);
} catch (Exception $e) {
    echo 'Exception when calling PortfolioFileApi->apiV11PortfoliosByPortfolioIdFilesByIdUploadPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **portfolio_id** | [**string**](../Model/.md)| The portfolio identifier. |
 **id** | [**string**](../Model/.md)| The portfolio file identifier. |
 **attachment** | **\SplFileObject**| The attachment. | [optional]

### Return type

void (empty response body)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: multipart/form-data, multipart/form-data
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11PortfoliosByPortfolioIdFilesGet**
> \Swagger\Client\Model\V11PortfolioFileResponse[] apiV11PortfoliosByPortfolioIdFilesGet($portfolio_id)

Gets all portfolio files for a portfolio.

Sample request:  ```  GET api/[version]/portfolios/[portfolioId]/file  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\PortfolioFileApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$portfolio_id = "portfolio_id_example"; // string | The identifier of the portfolio.

try {
    $result = $apiInstance->apiV11PortfoliosByPortfolioIdFilesGet($portfolio_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PortfolioFileApi->apiV11PortfoliosByPortfolioIdFilesGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **portfolio_id** | [**string**](../Model/.md)| The identifier of the portfolio. |

### Return type

[**\Swagger\Client\Model\V11PortfolioFileResponse[]**](../Model/V11PortfolioFileResponse.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiV11PortfoliosByPortfolioIdFilesPost**
> \Swagger\Client\Model\V11PortfolioFileResponse apiV11PortfoliosByPortfolioIdFilesPost($portfolio_id, $portfolio_file)

Adds a portfolio file.

Sample request:  ```  POST api/[version]/portfolios/[portfolioId]/file  ```

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: Token
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$apiInstance = new Swagger\Client\Api\PortfolioFileApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$portfolio_id = "portfolio_id_example"; // string | The identifier of the portfolio.
$portfolio_file = new \Swagger\Client\Model\V11PortfolioFileRequest(); // \Swagger\Client\Model\V11PortfolioFileRequest | The portfolio file model.

try {
    $result = $apiInstance->apiV11PortfoliosByPortfolioIdFilesPost($portfolio_id, $portfolio_file);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PortfolioFileApi->apiV11PortfoliosByPortfolioIdFilesPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **portfolio_id** | [**string**](../Model/.md)| The identifier of the portfolio. |
 **portfolio_file** | [**\Swagger\Client\Model\V11PortfolioFileRequest**](../Model/V11PortfolioFileRequest.md)| The portfolio file model. | [optional]

### Return type

[**\Swagger\Client\Model\V11PortfolioFileResponse**](../Model/V11PortfolioFileResponse.md)

### Authorization

[Token](../../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

