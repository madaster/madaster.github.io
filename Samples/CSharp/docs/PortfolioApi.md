# IO.Swagger.Api.PortfolioApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV11PortfoliosByIdBuildingsGet**](PortfolioApi.md#apiv11portfoliosbyidbuildingsget) | **GET** /api/v1.1/portfolios/{id}/buildings | Gets all buildings for a portfolio.
[**ApiV11PortfoliosByIdDelete**](PortfolioApi.md#apiv11portfoliosbyiddelete) | **DELETE** /api/v1.1/portfolios/{id} | Deletes a portfolio.
[**ApiV11PortfoliosByIdGet**](PortfolioApi.md#apiv11portfoliosbyidget) | **GET** /api/v1.1/portfolios/{id} | Gets a portfolio by its identifier.
[**ApiV11PortfoliosByIdLogoPost**](PortfolioApi.md#apiv11portfoliosbyidlogopost) | **POST** /api/v1.1/portfolios/{id}/logo | Sets the logo of a portfolio.
[**ApiV11PortfoliosByIdPassportPost**](PortfolioApi.md#apiv11portfoliosbyidpassportpost) | **POST** /api/v1.1/portfolios/{id}/passport | Schedules the generation of a PDF portfolio passport.
[**ApiV11PortfoliosByIdPut**](PortfolioApi.md#apiv11portfoliosbyidput) | **PUT** /api/v1.1/portfolios/{id} | Replaces a portfolio.
[**ApiV11PortfoliosByIdUsersGet**](PortfolioApi.md#apiv11portfoliosbyidusersget) | **GET** /api/v1.1/portfolios/{id}/users | Gets all users for a portfolio.
[**ApiV11PortfoliosByIdUsersPut**](PortfolioApi.md#apiv11portfoliosbyidusersput) | **PUT** /api/v1.1/portfolios/{id}/users | Replaces the security of a users for a portfolio.
[**ApiV11PortfoliosGet**](PortfolioApi.md#apiv11portfoliosget) | **GET** /api/v1.1/portfolios | Gets all portfolios.
[**ApiV11PortfoliosPost**](PortfolioApi.md#apiv11portfoliospost) | **POST** /api/v1.1/portfolios | Adds a portfolio.


<a name="apiv11portfoliosbyidbuildingsget"></a>
# **ApiV11PortfoliosByIdBuildingsGet**
> List<BuildingResponse> ApiV11PortfoliosByIdBuildingsGet (Guid? id)

Gets all buildings for a portfolio.

Sample request:   ```  GET api/[version]/portfolios/[id]/buildings  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11PortfoliosByIdBuildingsGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new PortfolioApi();
            var id = new Guid?(); // Guid? | The identifier of the portfolio.

            try
            {
                // Gets all buildings for a portfolio.
                List&lt;BuildingResponse&gt; result = apiInstance.ApiV11PortfoliosByIdBuildingsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioApi.ApiV11PortfoliosByIdBuildingsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the portfolio. | 

### Return type

[**List<BuildingResponse>**](BuildingResponse.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11portfoliosbyiddelete"></a>
# **ApiV11PortfoliosByIdDelete**
> void ApiV11PortfoliosByIdDelete (Guid? id)

Deletes a portfolio.

Sample request:  ```  DELETE api/[version]/portfolios/[id]  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11PortfoliosByIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new PortfolioApi();
            var id = new Guid?(); // Guid? | The identifier of the portfolio.

            try
            {
                // Deletes a portfolio.
                apiInstance.ApiV11PortfoliosByIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioApi.ApiV11PortfoliosByIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the portfolio. | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11portfoliosbyidget"></a>
# **ApiV11PortfoliosByIdGet**
> PortfolioResponse ApiV11PortfoliosByIdGet (Guid? id)

Gets a portfolio by its identifier.

Sample request:  ```  GET api/[version]/portfolios/[id]  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11PortfoliosByIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new PortfolioApi();
            var id = new Guid?(); // Guid? | The identifier of the portfolio.

            try
            {
                // Gets a portfolio by its identifier.
                PortfolioResponse result = apiInstance.ApiV11PortfoliosByIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioApi.ApiV11PortfoliosByIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the portfolio. | 

### Return type

[**PortfolioResponse**](PortfolioResponse.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11portfoliosbyidlogopost"></a>
# **ApiV11PortfoliosByIdLogoPost**
> string ApiV11PortfoliosByIdLogoPost (Guid? id, System.IO.Stream attachment)

Sets the logo of a portfolio.

Sample request:  ```  POST api/[version]/portfolios/[id]/logo  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11PortfoliosByIdLogoPostExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new PortfolioApi();
            var id = new Guid?(); // Guid? | The identifier of the portfolio.
            var attachment = new System.IO.Stream(); // System.IO.Stream | The logo file.

            try
            {
                // Sets the logo of a portfolio.
                string result = apiInstance.ApiV11PortfoliosByIdLogoPost(id, attachment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioApi.ApiV11PortfoliosByIdLogoPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the portfolio. | 
 **attachment** | **System.IO.Stream**| The logo file. | 

### Return type

**string**

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: multipart/form-data, multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11portfoliosbyidpassportpost"></a>
# **ApiV11PortfoliosByIdPassportPost**
> V11PortfolioFileResponse ApiV11PortfoliosByIdPassportPost (Guid? id, V11CreatePassportRequest createPassportRequest = null, string acceptLanguage = null)

Schedules the generation of a PDF portfolio passport.

Sample request:  ```  POST api/[version]/portfolios/[id]/passport  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11PortfoliosByIdPassportPostExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new PortfolioApi();
            var id = new Guid?(); // Guid? | The identifier of the portfolio.
            var createPassportRequest = new V11CreatePassportRequest(); // V11CreatePassportRequest | The request information to create the passport. (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | The culture to use for the request (optional)  (default to en)

            try
            {
                // Schedules the generation of a PDF portfolio passport.
                V11PortfolioFileResponse result = apiInstance.ApiV11PortfoliosByIdPassportPost(id, createPassportRequest, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioApi.ApiV11PortfoliosByIdPassportPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the portfolio. | 
 **createPassportRequest** | [**V11CreatePassportRequest**](V11CreatePassportRequest.md)| The request information to create the passport. | [optional] 
 **acceptLanguage** | **string**| The culture to use for the request | [optional] [default to en]

### Return type

[**V11PortfolioFileResponse**](V11PortfolioFileResponse.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11portfoliosbyidput"></a>
# **ApiV11PortfoliosByIdPut**
> PortfolioResponse ApiV11PortfoliosByIdPut (Guid? id, PortfolioRequest portfolio = null)

Replaces a portfolio.

Sample request:  ```  PUT api/[version]/portfolios/[id]  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11PortfoliosByIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new PortfolioApi();
            var id = new Guid?(); // Guid? | The identifier of the portfolio.
            var portfolio = new PortfolioRequest(); // PortfolioRequest | The portfolio model. (optional) 

            try
            {
                // Replaces a portfolio.
                PortfolioResponse result = apiInstance.ApiV11PortfoliosByIdPut(id, portfolio);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioApi.ApiV11PortfoliosByIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the portfolio. | 
 **portfolio** | [**PortfolioRequest**](PortfolioRequest.md)| The portfolio model. | [optional] 

### Return type

[**PortfolioResponse**](PortfolioResponse.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11portfoliosbyidusersget"></a>
# **ApiV11PortfoliosByIdUsersGet**
> List<V11UserRightResponse> ApiV11PortfoliosByIdUsersGet (Guid? id)

Gets all users for a portfolio.

Sample request:   ```  GET api/[version]/portfolios/[id]/users  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11PortfoliosByIdUsersGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new PortfolioApi();
            var id = new Guid?(); // Guid? | The identifier of the portfolio.

            try
            {
                // Gets all users for a portfolio.
                List&lt;V11UserRightResponse&gt; result = apiInstance.ApiV11PortfoliosByIdUsersGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioApi.ApiV11PortfoliosByIdUsersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the portfolio. | 

### Return type

[**List<V11UserRightResponse>**](V11UserRightResponse.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11portfoliosbyidusersput"></a>
# **ApiV11PortfoliosByIdUsersPut**
> V11UserRightResponse ApiV11PortfoliosByIdUsersPut (Guid? id, List<V11UserRightRequest> users = null)

Replaces the security of a users for a portfolio.

Sample request:  ```  PUT api/[version]/portfolios/[id]/users  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11PortfoliosByIdUsersPutExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new PortfolioApi();
            var id = new Guid?(); // Guid? | The identifier of the portfolio.
            var users = new List<V11UserRightRequest>(); // List<V11UserRightRequest> | The users to set. (optional) 

            try
            {
                // Replaces the security of a users for a portfolio.
                V11UserRightResponse result = apiInstance.ApiV11PortfoliosByIdUsersPut(id, users);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioApi.ApiV11PortfoliosByIdUsersPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the portfolio. | 
 **users** | [**List&lt;V11UserRightRequest&gt;**](V11UserRightRequest.md)| The users to set. | [optional] 

### Return type

[**V11UserRightResponse**](V11UserRightResponse.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11portfoliosget"></a>
# **ApiV11PortfoliosGet**
> List<PortfolioResponse> ApiV11PortfoliosGet ()

Gets all portfolios.

Sample request:  ```  GET api/[version]/portfolios  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11PortfoliosGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new PortfolioApi();

            try
            {
                // Gets all portfolios.
                List&lt;PortfolioResponse&gt; result = apiInstance.ApiV11PortfoliosGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioApi.ApiV11PortfoliosGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PortfolioResponse>**](PortfolioResponse.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11portfoliospost"></a>
# **ApiV11PortfoliosPost**
> PortfolioResponse ApiV11PortfoliosPost (PortfolioRequest portfolio = null)

Adds a portfolio.

Sample request:  ```  POST api/[version]/portfolios  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11PortfoliosPostExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new PortfolioApi();
            var portfolio = new PortfolioRequest(); // PortfolioRequest | The portfolio model. (optional) 

            try
            {
                // Adds a portfolio.
                PortfolioResponse result = apiInstance.ApiV11PortfoliosPost(portfolio);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioApi.ApiV11PortfoliosPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **portfolio** | [**PortfolioRequest**](PortfolioRequest.md)| The portfolio model. | [optional] 

### Return type

[**PortfolioResponse**](PortfolioResponse.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

