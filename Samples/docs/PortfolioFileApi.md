# IO.Swagger.Api.PortfolioFileApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV11PortfoliosByPortfolioIdFilesByIdDelete**](PortfolioFileApi.md#apiv11portfoliosbyportfolioidfilesbyiddelete) | **DELETE** /api/v1.1/portfolios/{portfolioId}/files/{id} | Deletes a portfolio file.
[**ApiV11PortfoliosByPortfolioIdFilesByIdDownloadGet**](PortfolioFileApi.md#apiv11portfoliosbyportfolioidfilesbyiddownloadget) | **GET** /api/v1.1/portfolios/{portfolioId}/files/{id}/download | Gets a download url for the portfolio file.
[**ApiV11PortfoliosByPortfolioIdFilesByIdGet**](PortfolioFileApi.md#apiv11portfoliosbyportfolioidfilesbyidget) | **GET** /api/v1.1/portfolios/{portfolioId}/files/{id} | Gets a portfolio file by its identifier.
[**ApiV11PortfoliosByPortfolioIdFilesByIdStatusGet**](PortfolioFileApi.md#apiv11portfoliosbyportfolioidfilesbyidstatusget) | **GET** /api/v1.1/portfolios/{portfolioId}/files/{id}/status | Gets a portfolio file status by its identifier.
[**ApiV11PortfoliosByPortfolioIdFilesByIdUploadPost**](PortfolioFileApi.md#apiv11portfoliosbyportfolioidfilesbyiduploadpost) | **POST** /api/v1.1/portfolios/{portfolioId}/files/{id}/upload | Uploads a portfolio file.
[**ApiV11PortfoliosByPortfolioIdFilesGet**](PortfolioFileApi.md#apiv11portfoliosbyportfolioidfilesget) | **GET** /api/v1.1/portfolios/{portfolioId}/files | Gets all portfolio files for a portfolio.
[**ApiV11PortfoliosByPortfolioIdFilesPost**](PortfolioFileApi.md#apiv11portfoliosbyportfolioidfilespost) | **POST** /api/v1.1/portfolios/{portfolioId}/files | Adds a portfolio file.


<a name="apiv11portfoliosbyportfolioidfilesbyiddelete"></a>
# **ApiV11PortfoliosByPortfolioIdFilesByIdDelete**
> void ApiV11PortfoliosByPortfolioIdFilesByIdDelete (Guid? portfolioId, Guid? id)

Deletes a portfolio file.

Sample request:  ```  DELETE api/[version]/portfolios/[portfolioId]/file/[id]  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11PortfoliosByPortfolioIdFilesByIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new PortfolioFileApi();
            var portfolioId = new Guid?(); // Guid? | The portfolio identifier.
            var id = new Guid?(); // Guid? | The identifier of the portfolio.

            try
            {
                // Deletes a portfolio file.
                apiInstance.ApiV11PortfoliosByPortfolioIdFilesByIdDelete(portfolioId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioFileApi.ApiV11PortfoliosByPortfolioIdFilesByIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **portfolioId** | [**Guid?**](Guid?.md)| The portfolio identifier. | 
 **id** | [**Guid?**](Guid?.md)| The identifier of the portfolio. | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11portfoliosbyportfolioidfilesbyiddownloadget"></a>
# **ApiV11PortfoliosByPortfolioIdFilesByIdDownloadGet**
> V11FileDownloadResponse ApiV11PortfoliosByPortfolioIdFilesByIdDownloadGet (Guid? portfolioId, Guid? id)

Gets a download url for the portfolio file.

Sample request:  ```  GET api/[version]/portfolios/[portfolioId]/file/[id]/download  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11PortfoliosByPortfolioIdFilesByIdDownloadGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new PortfolioFileApi();
            var portfolioId = new Guid?(); // Guid? | The identifier of the portfolio.
            var id = new Guid?(); // Guid? | The identifier of the portfolio file.

            try
            {
                // Gets a download url for the portfolio file.
                V11FileDownloadResponse result = apiInstance.ApiV11PortfoliosByPortfolioIdFilesByIdDownloadGet(portfolioId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioFileApi.ApiV11PortfoliosByPortfolioIdFilesByIdDownloadGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **portfolioId** | [**Guid?**](Guid?.md)| The identifier of the portfolio. | 
 **id** | [**Guid?**](Guid?.md)| The identifier of the portfolio file. | 

### Return type

[**V11FileDownloadResponse**](V11FileDownloadResponse.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11portfoliosbyportfolioidfilesbyidget"></a>
# **ApiV11PortfoliosByPortfolioIdFilesByIdGet**
> V11PortfolioFileResponse ApiV11PortfoliosByPortfolioIdFilesByIdGet (Guid? portfolioId, Guid? id)

Gets a portfolio file by its identifier.

Sample request:  ```  GET api/[version]/portfolios/[portfolioId]/file/[id]  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11PortfoliosByPortfolioIdFilesByIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new PortfolioFileApi();
            var portfolioId = new Guid?(); // Guid? | The identifier of the portfolio.
            var id = new Guid?(); // Guid? | The identifier of the portfolio file.

            try
            {
                // Gets a portfolio file by its identifier.
                V11PortfolioFileResponse result = apiInstance.ApiV11PortfoliosByPortfolioIdFilesByIdGet(portfolioId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioFileApi.ApiV11PortfoliosByPortfolioIdFilesByIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **portfolioId** | [**Guid?**](Guid?.md)| The identifier of the portfolio. | 
 **id** | [**Guid?**](Guid?.md)| The identifier of the portfolio file. | 

### Return type

[**V11PortfolioFileResponse**](V11PortfolioFileResponse.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11portfoliosbyportfolioidfilesbyidstatusget"></a>
# **ApiV11PortfoliosByPortfolioIdFilesByIdStatusGet**
> V11PortfolioFileStatusResponse ApiV11PortfoliosByPortfolioIdFilesByIdStatusGet (Guid? portfolioId, Guid? id)

Gets a portfolio file status by its identifier.

Sample request:  ```  GET api/[version]/portfolios/[portfolioId]/file/[id]/status  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11PortfoliosByPortfolioIdFilesByIdStatusGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new PortfolioFileApi();
            var portfolioId = new Guid?(); // Guid? | The identifier of the portfolio.
            var id = new Guid?(); // Guid? | The identifier of the portfolio file.

            try
            {
                // Gets a portfolio file status by its identifier.
                V11PortfolioFileStatusResponse result = apiInstance.ApiV11PortfoliosByPortfolioIdFilesByIdStatusGet(portfolioId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioFileApi.ApiV11PortfoliosByPortfolioIdFilesByIdStatusGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **portfolioId** | [**Guid?**](Guid?.md)| The identifier of the portfolio. | 
 **id** | [**Guid?**](Guid?.md)| The identifier of the portfolio file. | 

### Return type

[**V11PortfolioFileStatusResponse**](V11PortfolioFileStatusResponse.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11portfoliosbyportfolioidfilesbyiduploadpost"></a>
# **ApiV11PortfoliosByPortfolioIdFilesByIdUploadPost**
> void ApiV11PortfoliosByPortfolioIdFilesByIdUploadPost (Guid? portfolioId, Guid? id, System.IO.Stream attachment = null)

Uploads a portfolio file.

Sample request:  ```  POST api/[version]/portfolios/[portfolioId]/file/upload  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11PortfoliosByPortfolioIdFilesByIdUploadPostExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new PortfolioFileApi();
            var portfolioId = new Guid?(); // Guid? | The portfolio identifier.
            var id = new Guid?(); // Guid? | The portfolio file identifier.
            var attachment = new System.IO.Stream(); // System.IO.Stream | The attachment. (optional) 

            try
            {
                // Uploads a portfolio file.
                apiInstance.ApiV11PortfoliosByPortfolioIdFilesByIdUploadPost(portfolioId, id, attachment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioFileApi.ApiV11PortfoliosByPortfolioIdFilesByIdUploadPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **portfolioId** | [**Guid?**](Guid?.md)| The portfolio identifier. | 
 **id** | [**Guid?**](Guid?.md)| The portfolio file identifier. | 
 **attachment** | **System.IO.Stream**| The attachment. | [optional] 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: multipart/form-data, multipart/form-data
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11portfoliosbyportfolioidfilesget"></a>
# **ApiV11PortfoliosByPortfolioIdFilesGet**
> List<V11PortfolioFileResponse> ApiV11PortfoliosByPortfolioIdFilesGet (Guid? portfolioId)

Gets all portfolio files for a portfolio.

Sample request:  ```  GET api/[version]/portfolios/[portfolioId]/file  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11PortfoliosByPortfolioIdFilesGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new PortfolioFileApi();
            var portfolioId = new Guid?(); // Guid? | The identifier of the portfolio.

            try
            {
                // Gets all portfolio files for a portfolio.
                List&lt;V11PortfolioFileResponse&gt; result = apiInstance.ApiV11PortfoliosByPortfolioIdFilesGet(portfolioId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioFileApi.ApiV11PortfoliosByPortfolioIdFilesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **portfolioId** | [**Guid?**](Guid?.md)| The identifier of the portfolio. | 

### Return type

[**List<V11PortfolioFileResponse>**](V11PortfolioFileResponse.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11portfoliosbyportfolioidfilespost"></a>
# **ApiV11PortfoliosByPortfolioIdFilesPost**
> V11PortfolioFileResponse ApiV11PortfoliosByPortfolioIdFilesPost (Guid? portfolioId, V11PortfolioFileRequest portfolioFile = null)

Adds a portfolio file.

Sample request:  ```  POST api/[version]/portfolios/[portfolioId]/file  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11PortfoliosByPortfolioIdFilesPostExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new PortfolioFileApi();
            var portfolioId = new Guid?(); // Guid? | The identifier of the portfolio.
            var portfolioFile = new V11PortfolioFileRequest(); // V11PortfolioFileRequest | The portfolio file model. (optional) 

            try
            {
                // Adds a portfolio file.
                V11PortfolioFileResponse result = apiInstance.ApiV11PortfoliosByPortfolioIdFilesPost(portfolioId, portfolioFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioFileApi.ApiV11PortfoliosByPortfolioIdFilesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **portfolioId** | [**Guid?**](Guid?.md)| The identifier of the portfolio. | 
 **portfolioFile** | [**V11PortfolioFileRequest**](V11PortfolioFileRequest.md)| The portfolio file model. | [optional] 

### Return type

[**V11PortfolioFileResponse**](V11PortfolioFileResponse.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

