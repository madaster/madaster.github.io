# Madaster.API.Api.BuildingApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV11BuildingsByIdCircularGet**](BuildingApi.md#apiv11buildingsbyidcircularget) | **GET** /api/v1.1/buildings/{id}/circular | Gets the circular information of a building.
[**ApiV11BuildingsByIdDelete**](BuildingApi.md#apiv11buildingsbyiddelete) | **DELETE** /api/v1.1/buildings/{id} | Deletes the building and all related data.
[**ApiV11BuildingsByIdExportexcelpassportPost**](BuildingApi.md#apiv11buildingsbyidexportexcelpassportpost) | **POST** /api/v1.1/buildings/{id}/exportexcelpassport | Schedules the generation of a PDF building passport.
[**ApiV11BuildingsByIdExportpassportPost**](BuildingApi.md#apiv11buildingsbyidexportpassportpost) | **POST** /api/v1.1/buildings/{id}/exportpassport | Schedules the generation of a PDF building passport.
[**ApiV11BuildingsByIdFinancialGet**](BuildingApi.md#apiv11buildingsbyidfinancialget) | **GET** /api/v1.1/buildings/{id}/financial | Gets the financial information of a building.
[**ApiV11BuildingsByIdGet**](BuildingApi.md#apiv11buildingsbyidget) | **GET** /api/v1.1/buildings/{id} | Gets a building by its identifier.
[**ApiV11BuildingsByIdImagesPost**](BuildingApi.md#apiv11buildingsbyidimagespost) | **POST** /api/v1.1/buildings/{id}/images | Adds an image to a building.
[**ApiV11BuildingsByIdProcessPost**](BuildingApi.md#apiv11buildingsbyidprocesspost) | **POST** /api/v1.1/buildings/{id}/process | Schedules the building for proccesing, recalculates all data.
[**ApiV11BuildingsByIdPut**](BuildingApi.md#apiv11buildingsbyidput) | **PUT** /api/v1.1/buildings/{id} | Replaces a building.
[**ApiV11BuildingsByIdUsersGet**](BuildingApi.md#apiv11buildingsbyidusersget) | **GET** /api/v1.1/buildings/{id}/users | Gets all users for a building.
[**ApiV11BuildingsByIdUsersPut**](BuildingApi.md#apiv11buildingsbyidusersput) | **PUT** /api/v1.1/buildings/{id}/users | Replaces the security of a users for a building.
[**ApiV11BuildingsByIdValidateGet**](BuildingApi.md#apiv11buildingsbyidvalidateget) | **GET** /api/v1.1/buildings/{id}/validate | Gets building validation parameters.
[**ApiV11BuildingsGet**](BuildingApi.md#apiv11buildingsget) | **GET** /api/v1.1/buildings | Gets all buildings.
[**ApiV11BuildingsPost**](BuildingApi.md#apiv11buildingspost) | **POST** /api/v1.1/buildings | Adds a building.


<a name="apiv11buildingsbyidcircularget"></a>
# **ApiV11BuildingsByIdCircularGet**
> string ApiV11BuildingsByIdCircularGet (Guid? id)

Gets the circular information of a building.

### Example
```csharp
using System;
using System.Diagnostics;
using Madaster.API.Api;
using Madaster.API.Client;
using Madaster.API.Model;

namespace Example
{
    public class ApiV11BuildingsByIdCircularGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var id = new Guid?(); // Guid? | The identifier of the building.

            try
            {
                // Gets the circular information of a building.
                string result = apiInstance.ApiV11BuildingsByIdCircularGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.ApiV11BuildingsByIdCircularGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the building. | 

### Return type

**string**

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingsbyiddelete"></a>
# **ApiV11BuildingsByIdDelete**
> void ApiV11BuildingsByIdDelete (Guid? id)

Deletes the building and all related data.

<returns>              The building was successfully deleted.              </returns>              Sample request:              ```              DELETE api/[version]/buildings/[id]/delete              ```

### Example
```csharp
using System;
using System.Diagnostics;
using Madaster.API.Api;
using Madaster.API.Client;
using Madaster.API.Model;

namespace Example
{
    public class ApiV11BuildingsByIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var id = new Guid?(); // Guid? | The identifier of the building.

            try
            {
                // Deletes the building and all related data.
                apiInstance.ApiV11BuildingsByIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.ApiV11BuildingsByIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the building. | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingsbyidexportexcelpassportpost"></a>
# **ApiV11BuildingsByIdExportexcelpassportPost**
> void ApiV11BuildingsByIdExportexcelpassportPost (Guid? id, string acceptLanguage = null)

Schedules the generation of a PDF building passport.

Sample request:  ```  POST api/[version]/buildings/[id]/exportexcelpassport  ```

### Example
```csharp
using System;
using System.Diagnostics;
using Madaster.API.Api;
using Madaster.API.Client;
using Madaster.API.Model;

namespace Example
{
    public class ApiV11BuildingsByIdExportexcelpassportPostExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var id = new Guid?(); // Guid? | The identifier of the building.
            var acceptLanguage = acceptLanguage_example;  // string | The culture to use for the request (optional)  (default to en)

            try
            {
                // Schedules the generation of a PDF building passport.
                apiInstance.ApiV11BuildingsByIdExportexcelpassportPost(id, acceptLanguage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.ApiV11BuildingsByIdExportexcelpassportPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the building. | 
 **acceptLanguage** | **string**| The culture to use for the request | [optional] [default to en]

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingsbyidexportpassportpost"></a>
# **ApiV11BuildingsByIdExportpassportPost**
> void ApiV11BuildingsByIdExportpassportPost (Guid? id, string acceptLanguage = null)

Schedules the generation of a PDF building passport.

Sample request:  ```  POST api/[version]/buildings/[id]/exportpassport  ```

### Example
```csharp
using System;
using System.Diagnostics;
using Madaster.API.Api;
using Madaster.API.Client;
using Madaster.API.Model;

namespace Example
{
    public class ApiV11BuildingsByIdExportpassportPostExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var id = new Guid?(); // Guid? | The identifier of the building.
            var acceptLanguage = acceptLanguage_example;  // string | The culture to use for the request (optional)  (default to en)

            try
            {
                // Schedules the generation of a PDF building passport.
                apiInstance.ApiV11BuildingsByIdExportpassportPost(id, acceptLanguage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.ApiV11BuildingsByIdExportpassportPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the building. | 
 **acceptLanguage** | **string**| The culture to use for the request | [optional] [default to en]

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingsbyidfinancialget"></a>
# **ApiV11BuildingsByIdFinancialGet**
> string ApiV11BuildingsByIdFinancialGet (Guid? id, V11BuildingFinancialInformationRequest request = null)

Gets the financial information of a building.

### Example
```csharp
using System;
using System.Diagnostics;
using Madaster.API.Api;
using Madaster.API.Client;
using Madaster.API.Model;

namespace Example
{
    public class ApiV11BuildingsByIdFinancialGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var id = new Guid?(); // Guid? | The identifier of the building.
            var request = new V11BuildingFinancialInformationRequest(); // V11BuildingFinancialInformationRequest | The request model specifying optional calculation variables. (optional) 

            try
            {
                // Gets the financial information of a building.
                string result = apiInstance.ApiV11BuildingsByIdFinancialGet(id, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.ApiV11BuildingsByIdFinancialGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the building. | 
 **request** | [**V11BuildingFinancialInformationRequest**](V11BuildingFinancialInformationRequest.md)| The request model specifying optional calculation variables. | [optional] 

### Return type

**string**

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingsbyidget"></a>
# **ApiV11BuildingsByIdGet**
> BuildingResponse ApiV11BuildingsByIdGet (Guid? id)

Gets a building by its identifier.

Sample request:  ```  GET api/[version]/buildings/[id]  ```

### Example
```csharp
using System;
using System.Diagnostics;
using Madaster.API.Api;
using Madaster.API.Client;
using Madaster.API.Model;

namespace Example
{
    public class ApiV11BuildingsByIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var id = new Guid?(); // Guid? | The identifier of the building.

            try
            {
                // Gets a building by its identifier.
                BuildingResponse result = apiInstance.ApiV11BuildingsByIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.ApiV11BuildingsByIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the building. | 

### Return type

[**BuildingResponse**](BuildingResponse.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingsbyidimagespost"></a>
# **ApiV11BuildingsByIdImagesPost**
> string ApiV11BuildingsByIdImagesPost (Guid? id, System.IO.Stream attachment)

Adds an image to a building.

Sample request:  ```  POST api/[version]/buildings/[id]/images  ```

### Example
```csharp
using System;
using System.Diagnostics;
using Madaster.API.Api;
using Madaster.API.Client;
using Madaster.API.Model;

namespace Example
{
    public class ApiV11BuildingsByIdImagesPostExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var id = new Guid?(); // Guid? | The identifier of the building.
            var attachment = new System.IO.Stream(); // System.IO.Stream | The logo file.

            try
            {
                // Adds an image to a building.
                string result = apiInstance.ApiV11BuildingsByIdImagesPost(id, attachment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.ApiV11BuildingsByIdImagesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the building. | 
 **attachment** | **System.IO.Stream**| The logo file. | 

### Return type

**string**

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: multipart/form-data, multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingsbyidprocesspost"></a>
# **ApiV11BuildingsByIdProcessPost**
> void ApiV11BuildingsByIdProcessPost (Guid? id)

Schedules the building for proccesing, recalculates all data.

Sample request:  ```  POST api/[version]/buildings/[id]/process  ```

### Example
```csharp
using System;
using System.Diagnostics;
using Madaster.API.Api;
using Madaster.API.Client;
using Madaster.API.Model;

namespace Example
{
    public class ApiV11BuildingsByIdProcessPostExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var id = new Guid?(); // Guid? | The identifier of the building.

            try
            {
                // Schedules the building for proccesing, recalculates all data.
                apiInstance.ApiV11BuildingsByIdProcessPost(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.ApiV11BuildingsByIdProcessPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the building. | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingsbyidput"></a>
# **ApiV11BuildingsByIdPut**
> BuildingResponse ApiV11BuildingsByIdPut (Guid? id, BuildingRequest building = null)

Replaces a building.

Sample request:  ```  PUT api/[version]/buildings/[id]  ```

### Example
```csharp
using System;
using System.Diagnostics;
using Madaster.API.Api;
using Madaster.API.Client;
using Madaster.API.Model;

namespace Example
{
    public class ApiV11BuildingsByIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var id = new Guid?(); // Guid? | The identifier of the building.
            var building = new BuildingRequest(); // BuildingRequest | The building model. (optional) 

            try
            {
                // Replaces a building.
                BuildingResponse result = apiInstance.ApiV11BuildingsByIdPut(id, building);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.ApiV11BuildingsByIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the building. | 
 **building** | [**BuildingRequest**](BuildingRequest.md)| The building model. | [optional] 

### Return type

[**BuildingResponse**](BuildingResponse.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingsbyidusersget"></a>
# **ApiV11BuildingsByIdUsersGet**
> List<V11UserRightResponse> ApiV11BuildingsByIdUsersGet (Guid? id)

Gets all users for a building.

Sample request:   ```  GET api/[version]/buildings/[id]/users  ```

### Example
```csharp
using System;
using System.Diagnostics;
using Madaster.API.Api;
using Madaster.API.Client;
using Madaster.API.Model;

namespace Example
{
    public class ApiV11BuildingsByIdUsersGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var id = new Guid?(); // Guid? | The identifier of the building.

            try
            {
                // Gets all users for a building.
                List&lt;V11UserRightResponse&gt; result = apiInstance.ApiV11BuildingsByIdUsersGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.ApiV11BuildingsByIdUsersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the building. | 

### Return type

[**List<V11UserRightResponse>**](V11UserRightResponse.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingsbyidusersput"></a>
# **ApiV11BuildingsByIdUsersPut**
> V11UserRightResponse ApiV11BuildingsByIdUsersPut (Guid? id, List<V11UserRightRequest> users = null)

Replaces the security of a users for a building.

Sample request:  ```  PUT api/[version]/portfolios/[id]/users  ```

### Example
```csharp
using System;
using System.Diagnostics;
using Madaster.API.Api;
using Madaster.API.Client;
using Madaster.API.Model;

namespace Example
{
    public class ApiV11BuildingsByIdUsersPutExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var id = new Guid?(); // Guid? | The identifier of the portfolio.
            var users = new List<V11UserRightRequest>(); // List<V11UserRightRequest> | The users to set. (optional) 

            try
            {
                // Replaces the security of a users for a building.
                V11UserRightResponse result = apiInstance.ApiV11BuildingsByIdUsersPut(id, users);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.ApiV11BuildingsByIdUsersPut: " + e.Message );
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

<a name="apiv11buildingsbyidvalidateget"></a>
# **ApiV11BuildingsByIdValidateGet**
> List<V11ValidationGraph> ApiV11BuildingsByIdValidateGet (Guid? id)

Gets building validation parameters.

Sample request:   ```  GET api/[version]/buildings/[id]/validate  ```

### Example
```csharp
using System;
using System.Diagnostics;
using Madaster.API.Api;
using Madaster.API.Client;
using Madaster.API.Model;

namespace Example
{
    public class ApiV11BuildingsByIdValidateGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var id = new Guid?(); // Guid? | The identifier of the building.

            try
            {
                // Gets building validation parameters.
                List&lt;V11ValidationGraph&gt; result = apiInstance.ApiV11BuildingsByIdValidateGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.ApiV11BuildingsByIdValidateGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The identifier of the building. | 

### Return type

[**List<V11ValidationGraph>**](V11ValidationGraph.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingsget"></a>
# **ApiV11BuildingsGet**
> List<BuildingResponse> ApiV11BuildingsGet ()

Gets all buildings.

Sample request:   ```  GET api/[version]/buildings  ```

### Example
```csharp
using System;
using System.Diagnostics;
using Madaster.API.Api;
using Madaster.API.Client;
using Madaster.API.Model;

namespace Example
{
    public class ApiV11BuildingsGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingApi();

            try
            {
                // Gets all buildings.
                List&lt;BuildingResponse&gt; result = apiInstance.ApiV11BuildingsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.ApiV11BuildingsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<BuildingResponse>**](BuildingResponse.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingspost"></a>
# **ApiV11BuildingsPost**
> BuildingResponse ApiV11BuildingsPost (V11BuildingRequest building = null)

Adds a building.

Sample request:  ```  POST api/[version]/buildings  ```

### Example
```csharp
using System;
using System.Diagnostics;
using Madaster.API.Api;
using Madaster.API.Client;
using Madaster.API.Model;

namespace Example
{
    public class ApiV11BuildingsPostExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingApi();
            var building = new V11BuildingRequest(); // V11BuildingRequest | The building model. (optional) 

            try
            {
                // Adds a building.
                BuildingResponse result = apiInstance.ApiV11BuildingsPost(building);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingApi.ApiV11BuildingsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **building** | [**V11BuildingRequest**](V11BuildingRequest.md)| The building model. | [optional] 

### Return type

[**BuildingResponse**](BuildingResponse.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

