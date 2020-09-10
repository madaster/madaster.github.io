# Madaster.API.Api.BuildingFileApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV11BuildingsByBuildingIdFilesByIdActivePost**](BuildingFileApi.md#apiv11buildingsbybuildingidfilesbyidactivepost) | **POST** /api/v1.1/buildings/{buildingId}/files/{id}/active | Activates or deactivates a building file.
[**ApiV11BuildingsByBuildingIdFilesByIdDelete**](BuildingFileApi.md#apiv11buildingsbybuildingidfilesbyiddelete) | **DELETE** /api/v1.1/buildings/{buildingId}/files/{id} | Deletes a building file.
[**ApiV11BuildingsByBuildingIdFilesByIdDownloadGet**](BuildingFileApi.md#apiv11buildingsbybuildingidfilesbyiddownloadget) | **GET** /api/v1.1/buildings/{buildingId}/files/{id}/download | Gets a download url for the building file.
[**ApiV11BuildingsByBuildingIdFilesByIdGet**](BuildingFileApi.md#apiv11buildingsbybuildingidfilesbyidget) | **GET** /api/v1.1/buildings/{buildingId}/files/{id} | Gets a building file by its identifier.
[**ApiV11BuildingsByBuildingIdFilesByIdSetimportingPost**](BuildingFileApi.md#apiv11buildingsbybuildingidfilesbyidsetimportingpost) | **POST** /api/v1.1/buildings/{buildingId}/files/{id}/setimporting | Sets the status of a file to &#39;importing&#39;, so element can be added or updated can be made.
[**ApiV11BuildingsByBuildingIdFilesByIdStartrefinementPost**](BuildingFileApi.md#apiv11buildingsbybuildingidfilesbyidstartrefinementpost) | **POST** /api/v1.1/buildings/{buildingId}/files/{id}/startrefinement | Starts the refinement of a building file.
[**ApiV11BuildingsByBuildingIdFilesByIdStatusGet**](BuildingFileApi.md#apiv11buildingsbybuildingidfilesbyidstatusget) | **GET** /api/v1.1/buildings/{buildingId}/files/{id}/status | Gets a building file status by its identifier.
[**ApiV11BuildingsByBuildingIdFilesByIdUploadPost**](BuildingFileApi.md#apiv11buildingsbybuildingidfilesbyiduploadpost) | **POST** /api/v1.1/buildings/{buildingId}/files/{id}/upload | Uploads a building file.
[**ApiV11BuildingsByBuildingIdFilesGet**](BuildingFileApi.md#apiv11buildingsbybuildingidfilesget) | **GET** /api/v1.1/buildings/{buildingId}/files | Gets all building files.
[**ApiV11BuildingsByBuildingIdFilesPost**](BuildingFileApi.md#apiv11buildingsbybuildingidfilespost) | **POST** /api/v1.1/buildings/{buildingId}/files | Adds a building file.


<a name="apiv11buildingsbybuildingidfilesbyidactivepost"></a>
# **ApiV11BuildingsByBuildingIdFilesByIdActivePost**
> BuildingFileResponse ApiV11BuildingsByBuildingIdFilesByIdActivePost (Guid? buildingId, Guid? id, bool? isActive = null)

Activates or deactivates a building file.

Sample request:  ```  POST api/[version]/buildings/[buildingId]/files/[id]/active  ```

### Example
```csharp
using System;
using System.Diagnostics;
using Madaster.API.Api;
using Madaster.API.Client;
using Madaster.API.Model;

namespace Example
{
    public class ApiV11BuildingsByBuildingIdFilesByIdActivePostExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingFileApi();
            var buildingId = new Guid?(); // Guid? | The identifier of the building.
            var id = new Guid?(); // Guid? | The identifier of the building file.
            var isActive = true;  // bool? | The new active-status. (optional) 

            try
            {
                // Activates or deactivates a building file.
                BuildingFileResponse result = apiInstance.ApiV11BuildingsByBuildingIdFilesByIdActivePost(buildingId, id, isActive);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingFileApi.ApiV11BuildingsByBuildingIdFilesByIdActivePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | [**Guid?**](Guid?.md)| The identifier of the building. | 
 **id** | [**Guid?**](Guid?.md)| The identifier of the building file. | 
 **isActive** | **bool?**| The new active-status. | [optional] 

### Return type

[**BuildingFileResponse**](BuildingFileResponse.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingsbybuildingidfilesbyiddelete"></a>
# **ApiV11BuildingsByBuildingIdFilesByIdDelete**
> void ApiV11BuildingsByBuildingIdFilesByIdDelete (Guid? buildingId, Guid? id)

Deletes a building file.

Sample request:  ```  DELETE api/[version]/buildings/[buildingId]/file/[id]  ```

### Example
```csharp
using System;
using System.Diagnostics;
using Madaster.API.Api;
using Madaster.API.Client;
using Madaster.API.Model;

namespace Example
{
    public class ApiV11BuildingsByBuildingIdFilesByIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingFileApi();
            var buildingId = new Guid?(); // Guid? | The building identifier.
            var id = new Guid?(); // Guid? | The identifier of the building.

            try
            {
                // Deletes a building file.
                apiInstance.ApiV11BuildingsByBuildingIdFilesByIdDelete(buildingId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingFileApi.ApiV11BuildingsByBuildingIdFilesByIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | [**Guid?**](Guid?.md)| The building identifier. | 
 **id** | [**Guid?**](Guid?.md)| The identifier of the building. | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingsbybuildingidfilesbyiddownloadget"></a>
# **ApiV11BuildingsByBuildingIdFilesByIdDownloadGet**
> V11FileDownloadResponse ApiV11BuildingsByBuildingIdFilesByIdDownloadGet (Guid? buildingId, Guid? id)

Gets a download url for the building file.

Sample request:  ```  GET api/[version]/buildings/[buildingId]/file/[id]/download  ```

### Example
```csharp
using System;
using System.Diagnostics;
using Madaster.API.Api;
using Madaster.API.Client;
using Madaster.API.Model;

namespace Example
{
    public class ApiV11BuildingsByBuildingIdFilesByIdDownloadGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingFileApi();
            var buildingId = new Guid?(); // Guid? | The identifier of the building.
            var id = new Guid?(); // Guid? | The identifier of the building file.

            try
            {
                // Gets a download url for the building file.
                V11FileDownloadResponse result = apiInstance.ApiV11BuildingsByBuildingIdFilesByIdDownloadGet(buildingId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingFileApi.ApiV11BuildingsByBuildingIdFilesByIdDownloadGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | [**Guid?**](Guid?.md)| The identifier of the building. | 
 **id** | [**Guid?**](Guid?.md)| The identifier of the building file. | 

### Return type

[**V11FileDownloadResponse**](V11FileDownloadResponse.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingsbybuildingidfilesbyidget"></a>
# **ApiV11BuildingsByBuildingIdFilesByIdGet**
> BuildingFileResponse ApiV11BuildingsByBuildingIdFilesByIdGet (Guid? buildingId, Guid? id)

Gets a building file by its identifier.

Sample request:  ```  GET api/[version]/buildings/[buildingId]/files/[id]  ```

### Example
```csharp
using System;
using System.Diagnostics;
using Madaster.API.Api;
using Madaster.API.Client;
using Madaster.API.Model;

namespace Example
{
    public class ApiV11BuildingsByBuildingIdFilesByIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingFileApi();
            var buildingId = new Guid?(); // Guid? | The identifier of the building.
            var id = new Guid?(); // Guid? | The identifier of the building file.

            try
            {
                // Gets a building file by its identifier.
                BuildingFileResponse result = apiInstance.ApiV11BuildingsByBuildingIdFilesByIdGet(buildingId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingFileApi.ApiV11BuildingsByBuildingIdFilesByIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | [**Guid?**](Guid?.md)| The identifier of the building. | 
 **id** | [**Guid?**](Guid?.md)| The identifier of the building file. | 

### Return type

[**BuildingFileResponse**](BuildingFileResponse.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingsbybuildingidfilesbyidsetimportingpost"></a>
# **ApiV11BuildingsByBuildingIdFilesByIdSetimportingPost**
> void ApiV11BuildingsByBuildingIdFilesByIdSetimportingPost (Guid? buildingId, Guid? id)

Sets the status of a file to 'importing', so element can be added or updated can be made.

Sample request:  ```  POST api/[version]/buildings/[buildingId]/files/[id]/setimporting  ```

### Example
```csharp
using System;
using System.Diagnostics;
using Madaster.API.Api;
using Madaster.API.Client;
using Madaster.API.Model;

namespace Example
{
    public class ApiV11BuildingsByBuildingIdFilesByIdSetimportingPostExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingFileApi();
            var buildingId = new Guid?(); // Guid? | The identifier of the building.
            var id = new Guid?(); // Guid? | The identifier of the building file.

            try
            {
                // Sets the status of a file to 'importing', so element can be added or updated can be made.
                apiInstance.ApiV11BuildingsByBuildingIdFilesByIdSetimportingPost(buildingId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingFileApi.ApiV11BuildingsByBuildingIdFilesByIdSetimportingPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | [**Guid?**](Guid?.md)| The identifier of the building. | 
 **id** | [**Guid?**](Guid?.md)| The identifier of the building file. | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingsbybuildingidfilesbyidstartrefinementpost"></a>
# **ApiV11BuildingsByBuildingIdFilesByIdStartrefinementPost**
> void ApiV11BuildingsByBuildingIdFilesByIdStartrefinementPost (Guid? buildingId, Guid? id)

Starts the refinement of a building file.

Sample request:  ```  POST api/[version]/buildings/[buildingId]/files/[id]/startrefinement  ```

### Example
```csharp
using System;
using System.Diagnostics;
using Madaster.API.Api;
using Madaster.API.Client;
using Madaster.API.Model;

namespace Example
{
    public class ApiV11BuildingsByBuildingIdFilesByIdStartrefinementPostExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingFileApi();
            var buildingId = new Guid?(); // Guid? | The identifier of the building.
            var id = new Guid?(); // Guid? | The identifier of the building file.

            try
            {
                // Starts the refinement of a building file.
                apiInstance.ApiV11BuildingsByBuildingIdFilesByIdStartrefinementPost(buildingId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingFileApi.ApiV11BuildingsByBuildingIdFilesByIdStartrefinementPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | [**Guid?**](Guid?.md)| The identifier of the building. | 
 **id** | [**Guid?**](Guid?.md)| The identifier of the building file. | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingsbybuildingidfilesbyidstatusget"></a>
# **ApiV11BuildingsByBuildingIdFilesByIdStatusGet**
> BuildingFileStatusResponse ApiV11BuildingsByBuildingIdFilesByIdStatusGet (Guid? buildingId, Guid? id)

Gets a building file status by its identifier.

Sample request:  ```  GET api/[version]/buildings/[buildingId]/files/[id]/status  ```

### Example
```csharp
using System;
using System.Diagnostics;
using Madaster.API.Api;
using Madaster.API.Client;
using Madaster.API.Model;

namespace Example
{
    public class ApiV11BuildingsByBuildingIdFilesByIdStatusGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingFileApi();
            var buildingId = new Guid?(); // Guid? | The identifier of the building.
            var id = new Guid?(); // Guid? | The identifier of the building file.

            try
            {
                // Gets a building file status by its identifier.
                BuildingFileStatusResponse result = apiInstance.ApiV11BuildingsByBuildingIdFilesByIdStatusGet(buildingId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingFileApi.ApiV11BuildingsByBuildingIdFilesByIdStatusGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | [**Guid?**](Guid?.md)| The identifier of the building. | 
 **id** | [**Guid?**](Guid?.md)| The identifier of the building file. | 

### Return type

[**BuildingFileStatusResponse**](BuildingFileStatusResponse.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingsbybuildingidfilesbyiduploadpost"></a>
# **ApiV11BuildingsByBuildingIdFilesByIdUploadPost**
> void ApiV11BuildingsByBuildingIdFilesByIdUploadPost (Guid? buildingId, Guid? id, System.IO.Stream attachment = null)

Uploads a building file.

Sample request:  ```  POST api/[version]/buildings/[buildingId]/files/[id]/upload  ```

### Example
```csharp
using System;
using System.Diagnostics;
using Madaster.API.Api;
using Madaster.API.Client;
using Madaster.API.Model;

namespace Example
{
    public class ApiV11BuildingsByBuildingIdFilesByIdUploadPostExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingFileApi();
            var buildingId = new Guid?(); // Guid? | The building identifier.
            var id = new Guid?(); // Guid? | The building file identifier.
            var attachment = new System.IO.Stream(); // System.IO.Stream | The attachment. (optional) 

            try
            {
                // Uploads a building file.
                apiInstance.ApiV11BuildingsByBuildingIdFilesByIdUploadPost(buildingId, id, attachment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingFileApi.ApiV11BuildingsByBuildingIdFilesByIdUploadPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | [**Guid?**](Guid?.md)| The building identifier. | 
 **id** | [**Guid?**](Guid?.md)| The building file identifier. | 
 **attachment** | **System.IO.Stream**| The attachment. | [optional] 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: multipart/form-data, multipart/form-data
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingsbybuildingidfilesget"></a>
# **ApiV11BuildingsByBuildingIdFilesGet**
> List<BuildingFileResponse> ApiV11BuildingsByBuildingIdFilesGet (Guid? buildingId)

Gets all building files.

Sample request:  ```  GET api/[version]/buildings/[buildingId]/files  ```

### Example
```csharp
using System;
using System.Diagnostics;
using Madaster.API.Api;
using Madaster.API.Client;
using Madaster.API.Model;

namespace Example
{
    public class ApiV11BuildingsByBuildingIdFilesGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingFileApi();
            var buildingId = new Guid?(); // Guid? | 

            try
            {
                // Gets all building files.
                List&lt;BuildingFileResponse&gt; result = apiInstance.ApiV11BuildingsByBuildingIdFilesGet(buildingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingFileApi.ApiV11BuildingsByBuildingIdFilesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | [**Guid?**](Guid?.md)|  | 

### Return type

[**List<BuildingFileResponse>**](BuildingFileResponse.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv11buildingsbybuildingidfilespost"></a>
# **ApiV11BuildingsByBuildingIdFilesPost**
> BuildingFileResponse ApiV11BuildingsByBuildingIdFilesPost (Guid? buildingId, V11BuildingFileRequest buildingFile = null)

Adds a building file.

Sample request:   ```  POST api/[version]/buildings/[buildingId]/files  ```

### Example
```csharp
using System;
using System.Diagnostics;
using Madaster.API.Api;
using Madaster.API.Client;
using Madaster.API.Model;

namespace Example
{
    public class ApiV11BuildingsByBuildingIdFilesPostExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Key", "Bearer");

            var apiInstance = new BuildingFileApi();
            var buildingId = new Guid?(); // Guid? | The building identifier.
            var buildingFile = new V11BuildingFileRequest(); // V11BuildingFileRequest | The building file model. (optional) 

            try
            {
                // Adds a building file.
                BuildingFileResponse result = apiInstance.ApiV11BuildingsByBuildingIdFilesPost(buildingId, buildingFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuildingFileApi.ApiV11BuildingsByBuildingIdFilesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buildingId** | [**Guid?**](Guid?.md)| The building identifier. | 
 **buildingFile** | [**V11BuildingFileRequest**](V11BuildingFileRequest.md)| The building file model. | [optional] 

### Return type

[**BuildingFileResponse**](BuildingFileResponse.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

