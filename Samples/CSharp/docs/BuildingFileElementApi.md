# IO.Swagger.Api.BuildingFileElementApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV11BuildingsByBuildingIdFilesByFileIdElementsByIdDelete**](BuildingFileElementApi.md#apiv11buildingsbybuildingidfilesbyfileidelementsbyiddelete) | **DELETE** /api/v1.1/buildings/{buildingId}/files/{fileId}/elements/{id} | Deletes an existing building file element.
[**ApiV11BuildingsByBuildingIdFilesByFileIdElementsByIdGet**](BuildingFileElementApi.md#apiv11buildingsbybuildingidfilesbyfileidelementsbyidget) | **GET** /api/v1.1/buildings/{buildingId}/files/{fileId}/elements/{id} | Gets a building file element by its identifier and building file identifier.
[**ApiV11BuildingsByBuildingIdFilesByFileIdElementsByIdPut**](BuildingFileElementApi.md#apiv11buildingsbybuildingidfilesbyfileidelementsbyidput) | **PUT** /api/v1.1/buildings/{buildingId}/files/{fileId}/elements/{id} | Updates an existing building file element.
[**ApiV11BuildingsByBuildingIdFilesByFileIdElementsGet**](BuildingFileElementApi.md#apiv11buildingsbybuildingidfilesbyfileidelementsget) | **GET** /api/v1.1/buildings/{buildingId}/files/{fileId}/elements | Gets a building file elements by its building file identifier.
[**ApiV11BuildingsByBuildingIdFilesByFileIdElementsPost**](BuildingFileElementApi.md#apiv11buildingsbybuildingidfilesbyfileidelementspost) | **POST** /api/v1.1/buildings/{buildingId}/files/{fileId}/elements | Create a new building file element.


<a name="apiv11buildingsbybuildingidfilesbyfileidelementsbyiddelete"></a>
# **ApiV11BuildingsByBuildingIdFilesByFileIdElementsByIdDelete**
> void ApiV11BuildingsByBuildingIdFilesByFileIdElementsByIdDelete (Guid? buildingId, Guid? fileId, string id)

Deletes an existing building file element.

Sample request:        DELETE api/[version]/buildings/[buildingid]/files/[fileid]/elements/[id]

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11BuildingsByBuildingIdFilesByFileIdElementsByIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingFileElementApi();
            var buildingId = new Guid?(); // Guid? | The identifier of the building.
            var fileId = new Guid?(); // Guid? | The identifier of the building file.
            var id = id_example;  // string | The identifier of the element.

            try
            {
                // Deletes an existing building file element.
                apiInstance.ApiV11BuildingsByBuildingIdFilesByFileIdElementsByIdDelete(buildingId, fileId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingFileElementApi.ApiV11BuildingsByBuildingIdFilesByFileIdElementsByIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | [**Guid?**](Guid?.md)| The identifier of the building. | 
 **fileId** | [**Guid?**](Guid?.md)| The identifier of the building file. | 
 **id** | **string**| The identifier of the element. | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingsbybuildingidfilesbyfileidelementsbyidget"></a>
# **ApiV11BuildingsByBuildingIdFilesByFileIdElementsByIdGet**
> BuildingFileElement ApiV11BuildingsByBuildingIdFilesByFileIdElementsByIdGet (Guid? buildingId, Guid? fileId, string id)

Gets a building file element by its identifier and building file identifier.

Sample request:        GET api/[version]/buildings/[buildingid]/files/[fileid]/elements/[id]

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11BuildingsByBuildingIdFilesByFileIdElementsByIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingFileElementApi();
            var buildingId = new Guid?(); // Guid? | The identifier of the building.
            var fileId = new Guid?(); // Guid? | The identifier of the building file.
            var id = id_example;  // string | The identifier of the element.

            try
            {
                // Gets a building file element by its identifier and building file identifier.
                BuildingFileElement result = apiInstance.ApiV11BuildingsByBuildingIdFilesByFileIdElementsByIdGet(buildingId, fileId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingFileElementApi.ApiV11BuildingsByBuildingIdFilesByFileIdElementsByIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | [**Guid?**](Guid?.md)| The identifier of the building. | 
 **fileId** | [**Guid?**](Guid?.md)| The identifier of the building file. | 
 **id** | **string**| The identifier of the element. | 

### Return type

[**BuildingFileElement**](BuildingFileElement.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingsbybuildingidfilesbyfileidelementsbyidput"></a>
# **ApiV11BuildingsByBuildingIdFilesByFileIdElementsByIdPut**
> BuildingFileElement ApiV11BuildingsByBuildingIdFilesByFileIdElementsByIdPut (Guid? buildingId, Guid? fileId, string id, V11CreateBuildingFileElementRequest updateElementRequest = null)

Updates an existing building file element.

Sample request:        PUT api/[version]/buildings/[buildingid]/files/[fileid]/elements/[id]

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11BuildingsByBuildingIdFilesByFileIdElementsByIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingFileElementApi();
            var buildingId = new Guid?(); // Guid? | The identifier of the building.
            var fileId = new Guid?(); // Guid? | The identifier of the building file.
            var id = id_example;  // string | The identifier of the element.
            var updateElementRequest = new V11CreateBuildingFileElementRequest(); // V11CreateBuildingFileElementRequest | The element to create. (optional) 

            try
            {
                // Updates an existing building file element.
                BuildingFileElement result = apiInstance.ApiV11BuildingsByBuildingIdFilesByFileIdElementsByIdPut(buildingId, fileId, id, updateElementRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingFileElementApi.ApiV11BuildingsByBuildingIdFilesByFileIdElementsByIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | [**Guid?**](Guid?.md)| The identifier of the building. | 
 **fileId** | [**Guid?**](Guid?.md)| The identifier of the building file. | 
 **id** | **string**| The identifier of the element. | 
 **updateElementRequest** | [**V11CreateBuildingFileElementRequest**](V11CreateBuildingFileElementRequest.md)| The element to create. | [optional] 

### Return type

[**BuildingFileElement**](BuildingFileElement.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingsbybuildingidfilesbyfileidelementsget"></a>
# **ApiV11BuildingsByBuildingIdFilesByFileIdElementsGet**
> List<BuildingFileElement> ApiV11BuildingsByBuildingIdFilesByFileIdElementsGet (Guid? buildingId, Guid? fileId)

Gets a building file elements by its building file identifier.

Sample request:                    GET api/[version]/buildings/[buildingid]/files/[fileid]/elements                - --    This API is ODATA enabled, the following filters can be used:    * $select  * $filter  * $skip  * $top                [READ MORE](https://developer.microsoft.com/en-us/graph/docs/concepts/query_parameters)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11BuildingsByBuildingIdFilesByFileIdElementsGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingFileElementApi();
            var buildingId = new Guid?(); // Guid? | The identifier of the building.
            var fileId = new Guid?(); // Guid? | The identifier of the building file.

            try
            {
                // Gets a building file elements by its building file identifier.
                List&lt;BuildingFileElement&gt; result = apiInstance.ApiV11BuildingsByBuildingIdFilesByFileIdElementsGet(buildingId, fileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingFileElementApi.ApiV11BuildingsByBuildingIdFilesByFileIdElementsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | [**Guid?**](Guid?.md)| The identifier of the building. | 
 **fileId** | [**Guid?**](Guid?.md)| The identifier of the building file. | 

### Return type

[**List<BuildingFileElement>**](BuildingFileElement.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingsbybuildingidfilesbyfileidelementspost"></a>
# **ApiV11BuildingsByBuildingIdFilesByFileIdElementsPost**
> BuildingFileElement ApiV11BuildingsByBuildingIdFilesByFileIdElementsPost (Guid? buildingId, Guid? fileId, V11CreateBuildingFileElementRequest createElementRequest = null)

Create a new building file element.

Sample request:        POST api/[version]/buildings/[buildingid]/files/[fileid]/elements

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiV11BuildingsByBuildingIdFilesByFileIdElementsPostExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingFileElementApi();
            var buildingId = new Guid?(); // Guid? | The identifier of the building.
            var fileId = new Guid?(); // Guid? | The identifier of the building file.
            var createElementRequest = new V11CreateBuildingFileElementRequest(); // V11CreateBuildingFileElementRequest | The element to create. (optional) 

            try
            {
                // Create a new building file element.
                BuildingFileElement result = apiInstance.ApiV11BuildingsByBuildingIdFilesByFileIdElementsPost(buildingId, fileId, createElementRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingFileElementApi.ApiV11BuildingsByBuildingIdFilesByFileIdElementsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | [**Guid?**](Guid?.md)| The identifier of the building. | 
 **fileId** | [**Guid?**](Guid?.md)| The identifier of the building file. | 
 **createElementRequest** | [**V11CreateBuildingFileElementRequest**](V11CreateBuildingFileElementRequest.md)| The element to create. | [optional] 

### Return type

[**BuildingFileElement**](BuildingFileElement.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

