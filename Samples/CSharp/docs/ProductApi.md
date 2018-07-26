# IO.Swagger.Api.ProductApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV11ProductsByIdChildrenGet**](ProductApi.md#apiv11productsbyidchildrenget) | **GET** /api/v1.1/products/{id}/children | Gets the children of a product.
[**ApiV11ProductsByIdChildrenPost**](ProductApi.md#apiv11productsbyidchildrenpost) | **POST** /api/v1.1/products/{id}/children | Adds a child for a product.
[**ApiV11ProductsByIdChildrenPut**](ProductApi.md#apiv11productsbyidchildrenput) | **PUT** /api/v1.1/products/{id}/children | Replaces the children for a product.
[**ApiV11ProductsByIdFinancialvaluesGet**](ProductApi.md#apiv11productsbyidfinancialvaluesget) | **GET** /api/v1.1/products/{id}/financialvalues | Gets the financial values of a product.
[**ApiV11ProductsByIdFinancialvaluesPost**](ProductApi.md#apiv11productsbyidfinancialvaluespost) | **POST** /api/v1.1/products/{id}/financialvalues | Adds a financial value for a product.
[**ApiV11ProductsByIdFinancialvaluesPut**](ProductApi.md#apiv11productsbyidfinancialvaluesput) | **PUT** /api/v1.1/products/{id}/financialvalues | Replaces the financial values for a product.
[**ApiV11ProductsByIdGet**](ProductApi.md#apiv11productsbyidget) | **GET** /api/v1.1/products/{id} | Gets a product by its identifier.
[**ApiV11ProductsByIdMatchesGet**](ProductApi.md#apiv11productsbyidmatchesget) | **GET** /api/v1.1/products/{id}/matches | Gets the matches of a product.
[**ApiV11ProductsByIdMatchesPost**](ProductApi.md#apiv11productsbyidmatchespost) | **POST** /api/v1.1/products/{id}/matches | Adds a match for a product.
[**ApiV11ProductsByIdMatchesPut**](ProductApi.md#apiv11productsbyidmatchesput) | **PUT** /api/v1.1/products/{id}/matches | Replaces the matches for a product.
[**ApiV11ProductsByIdPut**](ProductApi.md#apiv11productsbyidput) | **PUT** /api/v1.1/products/{id} | Replaces a product.
[**ApiV11ProductsGet**](ProductApi.md#apiv11productsget) | **GET** /api/v1.1/products | Gets all products.
[**ApiV11ProductsPost**](ProductApi.md#apiv11productspost) | **POST** /api/v1.1/products | Adds a product.


<a name="apiv11productsbyidchildrenget"></a>
# **ApiV11ProductsByIdChildrenGet**
> List<ProductChild> ApiV11ProductsByIdChildrenGet (Guid? id)

Gets the children of a product.

Sample request:  ```  GET api/[version]/products/[id]/children  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11ProductsByIdChildrenGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new ProductApi();
            var id = new Guid?(); // Guid? | The identifier of the product.

            try
            {
                // Gets the children of a product.
                List&lt;ProductChild&gt; result = apiInstance.ApiV11ProductsByIdChildrenGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.ApiV11ProductsByIdChildrenGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the product. | 

### Return type

[**List<ProductChild>**](ProductChild.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11productsbyidchildrenpost"></a>
# **ApiV11ProductsByIdChildrenPost**
> ProductChild ApiV11ProductsByIdChildrenPost (Guid? id, ProductChild child = null)

Adds a child for a product.

Sample request:  ```  POST api/[version]/products/[id]/children  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11ProductsByIdChildrenPostExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new ProductApi();
            var id = new Guid?(); // Guid? | The identifier of the product.
            var child = new ProductChild(); // ProductChild | The child to add. (optional) 

            try
            {
                // Adds a child for a product.
                ProductChild result = apiInstance.ApiV11ProductsByIdChildrenPost(id, child);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.ApiV11ProductsByIdChildrenPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the product. | 
 **child** | [**ProductChild**](ProductChild.md)| The child to add. | [optional] 

### Return type

[**ProductChild**](ProductChild.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11productsbyidchildrenput"></a>
# **ApiV11ProductsByIdChildrenPut**
> List<ProductChild> ApiV11ProductsByIdChildrenPut (Guid? id, List<ProductChild> children = null)

Replaces the children for a product.

Sample request:  ```  PUT api/[version]/products/[id]/children   ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11ProductsByIdChildrenPutExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new ProductApi();
            var id = new Guid?(); // Guid? | The identifier of the product.
            var children = new List<ProductChild>(); // List<ProductChild> | The matches to set. (optional) 

            try
            {
                // Replaces the children for a product.
                List&lt;ProductChild&gt; result = apiInstance.ApiV11ProductsByIdChildrenPut(id, children);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.ApiV11ProductsByIdChildrenPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the product. | 
 **children** | [**List&lt;ProductChild&gt;**](ProductChild.md)| The matches to set. | [optional] 

### Return type

[**List<ProductChild>**](ProductChild.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11productsbyidfinancialvaluesget"></a>
# **ApiV11ProductsByIdFinancialvaluesGet**
> List<ProductFinancialValue> ApiV11ProductsByIdFinancialvaluesGet (Guid? id)

Gets the financial values of a product.

Sample request:  ```  GET api/[version]/products/[id]/financialvalues  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11ProductsByIdFinancialvaluesGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new ProductApi();
            var id = new Guid?(); // Guid? | The identifier of the product.

            try
            {
                // Gets the financial values of a product.
                List&lt;ProductFinancialValue&gt; result = apiInstance.ApiV11ProductsByIdFinancialvaluesGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.ApiV11ProductsByIdFinancialvaluesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the product. | 

### Return type

[**List<ProductFinancialValue>**](ProductFinancialValue.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11productsbyidfinancialvaluespost"></a>
# **ApiV11ProductsByIdFinancialvaluesPost**
> ProductFinancialValue ApiV11ProductsByIdFinancialvaluesPost (Guid? id, ProductFinancialValue value = null)

Adds a financial value for a product.

Sample request:  ```  POST api/[version]/products/[id]/financialvalues  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11ProductsByIdFinancialvaluesPostExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new ProductApi();
            var id = new Guid?(); // Guid? | The identifier of the product.
            var value = new ProductFinancialValue(); // ProductFinancialValue | The value to add. (optional) 

            try
            {
                // Adds a financial value for a product.
                ProductFinancialValue result = apiInstance.ApiV11ProductsByIdFinancialvaluesPost(id, value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.ApiV11ProductsByIdFinancialvaluesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the product. | 
 **value** | [**ProductFinancialValue**](ProductFinancialValue.md)| The value to add. | [optional] 

### Return type

[**ProductFinancialValue**](ProductFinancialValue.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11productsbyidfinancialvaluesput"></a>
# **ApiV11ProductsByIdFinancialvaluesPut**
> List<ProductFinancialValue> ApiV11ProductsByIdFinancialvaluesPut (Guid? id, List<ProductFinancialValue> values = null)

Replaces the financial values for a product.

Sample request:  ```  PUT api/[version]/products/[id]/financialvalues  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11ProductsByIdFinancialvaluesPutExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new ProductApi();
            var id = new Guid?(); // Guid? | The identifier of the product.
            var values = new List<ProductFinancialValue>(); // List<ProductFinancialValue> | The values to set. (optional) 

            try
            {
                // Replaces the financial values for a product.
                List&lt;ProductFinancialValue&gt; result = apiInstance.ApiV11ProductsByIdFinancialvaluesPut(id, values);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.ApiV11ProductsByIdFinancialvaluesPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the product. | 
 **values** | [**List&lt;ProductFinancialValue&gt;**](ProductFinancialValue.md)| The values to set. | [optional] 

### Return type

[**List<ProductFinancialValue>**](ProductFinancialValue.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11productsbyidget"></a>
# **ApiV11ProductsByIdGet**
> Product ApiV11ProductsByIdGet (Guid? id)

Gets a product by its identifier.

Sample request:  ```  GET api/[version]/products/[id]  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11ProductsByIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new ProductApi();
            var id = new Guid?(); // Guid? | The identifier of the product.

            try
            {
                // Gets a product by its identifier.
                Product result = apiInstance.ApiV11ProductsByIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.ApiV11ProductsByIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the product. | 

### Return type

[**Product**](Product.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11productsbyidmatchesget"></a>
# **ApiV11ProductsByIdMatchesGet**
> List<ProductMatch> ApiV11ProductsByIdMatchesGet (Guid? id)

Gets the matches of a product.

Sample request:  ```  GET api/[version]/products/[id]/matches  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11ProductsByIdMatchesGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new ProductApi();
            var id = new Guid?(); // Guid? | The identifier of the product.

            try
            {
                // Gets the matches of a product.
                List&lt;ProductMatch&gt; result = apiInstance.ApiV11ProductsByIdMatchesGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.ApiV11ProductsByIdMatchesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the product. | 

### Return type

[**List<ProductMatch>**](ProductMatch.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11productsbyidmatchespost"></a>
# **ApiV11ProductsByIdMatchesPost**
> ProductMatch ApiV11ProductsByIdMatchesPost (Guid? id, ProductMatch match = null)

Adds a match for a product.

Sample request:  ```  POST api/[version]/products/[id]/matches  ```    For now only Name matches are supported.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11ProductsByIdMatchesPostExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new ProductApi();
            var id = new Guid?(); // Guid? | The identifier of the product.
            var match = new ProductMatch(); // ProductMatch | The match to add. (optional) 

            try
            {
                // Adds a match for a product.
                ProductMatch result = apiInstance.ApiV11ProductsByIdMatchesPost(id, match);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.ApiV11ProductsByIdMatchesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the product. | 
 **match** | [**ProductMatch**](ProductMatch.md)| The match to add. | [optional] 

### Return type

[**ProductMatch**](ProductMatch.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11productsbyidmatchesput"></a>
# **ApiV11ProductsByIdMatchesPut**
> List<ProductMatch> ApiV11ProductsByIdMatchesPut (Guid? id, List<ProductMatch> matches = null)

Replaces the matches for a product.

Sample request:  ```  PUT api/[version]/products/[id]/matches  ```    For now only Name matches are supported.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11ProductsByIdMatchesPutExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new ProductApi();
            var id = new Guid?(); // Guid? | The identifier of the product.
            var matches = new List<ProductMatch>(); // List<ProductMatch> | The matches to set. (optional) 

            try
            {
                // Replaces the matches for a product.
                List&lt;ProductMatch&gt; result = apiInstance.ApiV11ProductsByIdMatchesPut(id, matches);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.ApiV11ProductsByIdMatchesPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the product. | 
 **matches** | [**List&lt;ProductMatch&gt;**](ProductMatch.md)| The matches to set. | [optional] 

### Return type

[**List<ProductMatch>**](ProductMatch.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11productsbyidput"></a>
# **ApiV11ProductsByIdPut**
> Product ApiV11ProductsByIdPut (Guid? id, Product product = null)

Replaces a product.

Sample request:  ```  PUT api/[version]/products/[id]  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11ProductsByIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new ProductApi();
            var id = new Guid?(); // Guid? | The identifier.
            var product = new Product(); // Product | The product model. (optional) 

            try
            {
                // Replaces a product.
                Product result = apiInstance.ApiV11ProductsByIdPut(id, product);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.ApiV11ProductsByIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier. | 
 **product** | [**Product**](Product.md)| The product model. | [optional] 

### Return type

[**Product**](Product.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11productsget"></a>
# **ApiV11ProductsGet**
> List<Product> ApiV11ProductsGet ()

Gets all products.

Sample request:  ```  GET api/[version]/products  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11ProductsGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new ProductApi();

            try
            {
                // Gets all products.
                List&lt;Product&gt; result = apiInstance.ApiV11ProductsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.ApiV11ProductsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Product>**](Product.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11productspost"></a>
# **ApiV11ProductsPost**
> Product ApiV11ProductsPost (Product product = null)

Adds a product.

Sample request:  ```  POST api/[version]/products  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11ProductsPostExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new ProductApi();
            var product = new Product(); // Product | The product model. (optional) 

            try
            {
                // Adds a product.
                Product result = apiInstance.ApiV11ProductsPost(product);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductApi.ApiV11ProductsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **product** | [**Product**](Product.md)| The product model. | [optional] 

### Return type

[**Product**](Product.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

