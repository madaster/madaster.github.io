# IO.Swagger.Api.MaterialApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV11MaterialsByIdFinancialvaluesGet**](MaterialApi.md#apiv11materialsbyidfinancialvaluesget) | **GET** /api/v1.1/materials/{id}/financialvalues | Gets the financial values of a material, for manual import mode.
[**ApiV11MaterialsByIdFinancialvaluesPost**](MaterialApi.md#apiv11materialsbyidfinancialvaluespost) | **POST** /api/v1.1/materials/{id}/financialvalues | Adds a financial value for a material, for manual import mode.
[**ApiV11MaterialsByIdFinancialvaluesPut**](MaterialApi.md#apiv11materialsbyidfinancialvaluesput) | **PUT** /api/v1.1/materials/{id}/financialvalues | Replaces the financial values for a material, for manual import mode.
[**ApiV11MaterialsByIdGet**](MaterialApi.md#apiv11materialsbyidget) | **GET** /api/v1.1/materials/{id} | Gets a material by its identifier.
[**ApiV11MaterialsByIdMatchesGet**](MaterialApi.md#apiv11materialsbyidmatchesget) | **GET** /api/v1.1/materials/{id}/matches | Gets the matches of a material.
[**ApiV11MaterialsByIdMatchesPost**](MaterialApi.md#apiv11materialsbyidmatchespost) | **POST** /api/v1.1/materials/{id}/matches | Adds a match for a material.
[**ApiV11MaterialsByIdMatchesPut**](MaterialApi.md#apiv11materialsbyidmatchesput) | **PUT** /api/v1.1/materials/{id}/matches | Replaces the matches for a material.
[**ApiV11MaterialsByIdPut**](MaterialApi.md#apiv11materialsbyidput) | **PUT** /api/v1.1/materials/{id} | Replaces a material.
[**ApiV11MaterialsGet**](MaterialApi.md#apiv11materialsget) | **GET** /api/v1.1/materials | Gets all materials.
[**ApiV11MaterialsPost**](MaterialApi.md#apiv11materialspost) | **POST** /api/v1.1/materials | Adds a material.


<a name="apiv11materialsbyidfinancialvaluesget"></a>
# **ApiV11MaterialsByIdFinancialvaluesGet**
> List<MaterialFinancialValue> ApiV11MaterialsByIdFinancialvaluesGet (Guid? id)

Gets the financial values of a material, for manual import mode.

Sample request:  ```  GET api/[version]/materials/[id]/financialvalues  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11MaterialsByIdFinancialvaluesGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new MaterialApi();
            var id = new Guid?(); // Guid? | The identifier of the material.

            try
            {
                // Gets the financial values of a material, for manual import mode.
                List&lt;MaterialFinancialValue&gt; result = apiInstance.ApiV11MaterialsByIdFinancialvaluesGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MaterialApi.ApiV11MaterialsByIdFinancialvaluesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the material. | 

### Return type

[**List<MaterialFinancialValue>**](MaterialFinancialValue.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11materialsbyidfinancialvaluespost"></a>
# **ApiV11MaterialsByIdFinancialvaluesPost**
> MaterialFinancialValue ApiV11MaterialsByIdFinancialvaluesPost (Guid? id, MaterialFinancialValue value = null)

Adds a financial value for a material, for manual import mode.

Sample request:  ```  POST api/[version]/materials/[id]/financialvalues  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11MaterialsByIdFinancialvaluesPostExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new MaterialApi();
            var id = new Guid?(); // Guid? | The identifier of the material.
            var value = new MaterialFinancialValue(); // MaterialFinancialValue | The value to add. (optional) 

            try
            {
                // Adds a financial value for a material, for manual import mode.
                MaterialFinancialValue result = apiInstance.ApiV11MaterialsByIdFinancialvaluesPost(id, value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MaterialApi.ApiV11MaterialsByIdFinancialvaluesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the material. | 
 **value** | [**MaterialFinancialValue**](MaterialFinancialValue.md)| The value to add. | [optional] 

### Return type

[**MaterialFinancialValue**](MaterialFinancialValue.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11materialsbyidfinancialvaluesput"></a>
# **ApiV11MaterialsByIdFinancialvaluesPut**
> List<MaterialFinancialValue> ApiV11MaterialsByIdFinancialvaluesPut (Guid? id, List<MaterialFinancialValue> values = null)

Replaces the financial values for a material, for manual import mode.

Sample request:  ```  PUT api/[version]/materials/[id]/financialvalues  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11MaterialsByIdFinancialvaluesPutExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new MaterialApi();
            var id = new Guid?(); // Guid? | The identifier of the material.
            var values = new List<MaterialFinancialValue>(); // List<MaterialFinancialValue> | The values to set. (optional) 

            try
            {
                // Replaces the financial values for a material, for manual import mode.
                List&lt;MaterialFinancialValue&gt; result = apiInstance.ApiV11MaterialsByIdFinancialvaluesPut(id, values);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MaterialApi.ApiV11MaterialsByIdFinancialvaluesPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the material. | 
 **values** | [**List&lt;MaterialFinancialValue&gt;**](MaterialFinancialValue.md)| The values to set. | [optional] 

### Return type

[**List<MaterialFinancialValue>**](MaterialFinancialValue.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11materialsbyidget"></a>
# **ApiV11MaterialsByIdGet**
> Material ApiV11MaterialsByIdGet (Guid? id)

Gets a material by its identifier.

Sample request:  ```  GET api/[version]/materials/[id]  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11MaterialsByIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new MaterialApi();
            var id = new Guid?(); // Guid? | The identifier of the material.

            try
            {
                // Gets a material by its identifier.
                Material result = apiInstance.ApiV11MaterialsByIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MaterialApi.ApiV11MaterialsByIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the material. | 

### Return type

[**Material**](Material.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11materialsbyidmatchesget"></a>
# **ApiV11MaterialsByIdMatchesGet**
> List<MaterialMatch> ApiV11MaterialsByIdMatchesGet (Guid? id)

Gets the matches of a material.

Sample request:  ```  GET api/[version]/materials/[id]/matches  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11MaterialsByIdMatchesGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new MaterialApi();
            var id = new Guid?(); // Guid? | The identifier of the material.

            try
            {
                // Gets the matches of a material.
                List&lt;MaterialMatch&gt; result = apiInstance.ApiV11MaterialsByIdMatchesGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MaterialApi.ApiV11MaterialsByIdMatchesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the material. | 

### Return type

[**List<MaterialMatch>**](MaterialMatch.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11materialsbyidmatchespost"></a>
# **ApiV11MaterialsByIdMatchesPost**
> MaterialMatch ApiV11MaterialsByIdMatchesPost (Guid? id, MaterialMatch match = null)

Adds a match for a material.

Sample request:  ```  POST api/[version]/materials/[id]/matches  ```    For now only Name matches are supported.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11MaterialsByIdMatchesPostExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new MaterialApi();
            var id = new Guid?(); // Guid? | The identifier of the material.
            var match = new MaterialMatch(); // MaterialMatch | The match to add. (optional) 

            try
            {
                // Adds a match for a material.
                MaterialMatch result = apiInstance.ApiV11MaterialsByIdMatchesPost(id, match);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MaterialApi.ApiV11MaterialsByIdMatchesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the material. | 
 **match** | [**MaterialMatch**](MaterialMatch.md)| The match to add. | [optional] 

### Return type

[**MaterialMatch**](MaterialMatch.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11materialsbyidmatchesput"></a>
# **ApiV11MaterialsByIdMatchesPut**
> List<MaterialMatch> ApiV11MaterialsByIdMatchesPut (Guid? id, List<MaterialMatch> matches = null)

Replaces the matches for a material.

Sample request:  ```  PUT api/[version]/materials/[id]/matches  ```    For now only Name matches are supported.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11MaterialsByIdMatchesPutExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new MaterialApi();
            var id = new Guid?(); // Guid? | The identifier of the material.
            var matches = new List<MaterialMatch>(); // List<MaterialMatch> | The matches to set. (optional) 

            try
            {
                // Replaces the matches for a material.
                List&lt;MaterialMatch&gt; result = apiInstance.ApiV11MaterialsByIdMatchesPut(id, matches);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MaterialApi.ApiV11MaterialsByIdMatchesPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the material. | 
 **matches** | [**List&lt;MaterialMatch&gt;**](MaterialMatch.md)| The matches to set. | [optional] 

### Return type

[**List<MaterialMatch>**](MaterialMatch.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11materialsbyidput"></a>
# **ApiV11MaterialsByIdPut**
> Material ApiV11MaterialsByIdPut (Guid? id, Material material = null)

Replaces a material.

Sample request:  ```  PUT api/[version]/materials/[id]  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11MaterialsByIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new MaterialApi();
            var id = new Guid?(); // Guid? | The identifier.
            var material = new Material(); // Material | The material model. (optional) 

            try
            {
                // Replaces a material.
                Material result = apiInstance.ApiV11MaterialsByIdPut(id, material);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MaterialApi.ApiV11MaterialsByIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier. | 
 **material** | [**Material**](Material.md)| The material model. | [optional] 

### Return type

[**Material**](Material.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11materialsget"></a>
# **ApiV11MaterialsGet**
> List<Material> ApiV11MaterialsGet ()

Gets all materials.

Sample request:  ```  GET api/[version]/materials  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11MaterialsGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new MaterialApi();

            try
            {
                // Gets all materials.
                List&lt;Material&gt; result = apiInstance.ApiV11MaterialsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MaterialApi.ApiV11MaterialsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Material>**](Material.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11materialspost"></a>
# **ApiV11MaterialsPost**
> Material ApiV11MaterialsPost (Material material = null)

Adds a material.

Sample request:   ```  POST api/[version]/materials  ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11MaterialsPostExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new MaterialApi();
            var material = new Material(); // Material | The material model. (optional) 

            try
            {
                // Adds a material.
                Material result = apiInstance.ApiV11MaterialsPost(material);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MaterialApi.ApiV11MaterialsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **material** | [**Material**](Material.md)| The material model. | [optional] 

### Return type

[**Material**](Material.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

