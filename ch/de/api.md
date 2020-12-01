---
title: API
ref: api
menubar: none
---

# Madaster API
The **Madaster API** endpoint can be used to interact with the Madaster Platform and its resources.
This API does not fully cover all functionality of the platform yet, please refer to the [*api-docs*](/api-docs) files or the [Swagger/OpenAPI documentation](https://api.madaster.com/).

To access the API resources, you need an authorization token.
If you do not have one yet, see the chapter about Authorization below.
This token should be sent as a header with the name 'X-API-Key', which will authenticate the request with the token.
To find out which requests are available and which responses they might produce, see the [*api-docs*](/api-docs) files or the [Swagger/OpenAPI documentation](https://api.madaster.com/).

This API can be reached at the endpoint: **[https://api.madaster.com/](https://api.madaster.com/)**<br/>
The interactive Swagger/OpenAPI documentation: **[https://api.madaster.com/](https://api.madaster.com/)**<br/>
If you prefer a static documentation: **[/api-docs](/api-docs)**

## Authorization
To access the resources of this API, you need an API key. This key needs to be attached to the request in the *X-API-Key* header.
To acquire an API key, you need to add a token to either a Portfolio or a Building in the Madaster Platform, or ask your account manager to do this for you.
This will give you access to these resources and their attached entities.

### Add a token to a building
- Go to the building page and click on the *Users* tab

<img src="/assets/images/api/addbuildingtoken1.png" class="api-img"/>

- Click on the *Add API Token* button

<img src="/assets/images/api/addbuildingtoken2.png" class="api-img"/>

- Enter a name for this token, click on the gear icon (1), copy the generated key (2), choose a permission level and expiration time, and finish by clicking on the Add button (3)

<img src="/assets/images/api/addtoken3.png" class="api-img form-img"/>

### Add a token to a portfolio
- Go to the portfolio page and click on the *Users* tab

<img src="/assets/images/api/addportfoliotoken1.png" class="api-img portfolio-img" style="margin-left: -40px;"/>

- Click on the *Add API Token* button

<img src="/assets/images/api/addportfoliotoken2.png" class="api-img portfolio-img"/>

- Enter a name for this token, click on the gear icon (1), copy the generated key (2), choose a permission level and expiration time, and finish by clicking on the Add button (3)

<img src="/assets/images/api/addtoken3.png" class="api-img form-img"/>

## Connection
To connect to the API, multiple tools and languages can be used. Because the Madaster API implements the REST interface, all applications that connect to a REST service can communicate with this API. A few examples can be found below.

### Versions
The API is continually being improved, so as time progresses, more *versions* are added to the interface. Please refer to the [Swagger/OpenAPI documentation](https://api.madaster.com/) to find which versions support which API calls. It is suggested to always use the latest version available for an API request; but the old versions will remain available for legacy purposes. To select an API version, append the version tag to the API endpoint. For version 2.1 for example, use https://api.madaster.com/api/v2.1

### Postman
[Postman](https://www.getpostman.com/) is an easy to use tool that can connect to all sorts of endpoint because it revolves around web requests.

![Postman](/assets/images/api/postman.png)

### C\#
Using any programming language, look for a HTTP client or Web Request client to access the REST resources. The HttpClient in C# for example can be used:

```csharp
HttpClient client = new HttpClient();
client.BaseAddress = new Uri("https://api.madaster.com/");
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
HttpResponseMessage response = await client.GetAsync("api/v2.1/buildings");
if (response.IsSuccessStatusCode)
{
    buildings = await response.Content.ReadAsAsync<IEnumerable<Building>>();
}
```

## Enumerations
The **Madaster API** uses enumerations throughout the entire range of functions. To find out what they mean, check [**enums**](/enums).

## System data
Some calls to the API require data that is not bound to any entity. These calls are made to the **System** level: `https://api.madaster.com/api/v2.1/system`.

## Structure
The **Madaster Platform** uses a hierarchical structure to store enitities and also displays them in this same tree-like way. Simply put, some entities act as containers for other entities, which may seem logical on the website but can be cumbersome to follow through the API. Below you can find this structure and some examples to show you how to navigate through this structure and to upload a single IFC file or create a file manually. For the examples the API version 2.1 is used; if you want to use a different version of the API, replace the `/v2.1/` part with your preferred version number.

### Account
The top level of the structure is an *account*. An account is the level that is attained when subscribing to Madaster and it holds the information about the subscription model. An account can have users attached to it and holds one or more *portfolios*.

#### API calls
Accounts have no representation in the API yet. When accessing the API, the token you use already matches you to the account you belong to.

### Portfolio
A *portfolio* can be seen as a folder of *buildings*, it does not add much data beyond its function as a collection. You can add documentation files to a portfolio and look at combined cumulative data about all the buildings in a portfolio.

#### API calls
When you receive an API token, it is usually scoped to a single portfolio. If you received a token for an entire account, you can use the functions at `https://api.madaster.com/api/v2.1/portfolios`.

### Building
A *buiding* is the main entity of the Madaster platform, it contains all data related to a real-world building and most figures and numbers relate to a building as a whole. A building gets its data from one ore more *building files*.

#### API calls
If your API token is scoped to a single building, the functions for the building entity will only work on that building. You can use the functions at `https://api.madaster.com/api/v2.1/buildings` to manage that building. If you have a token at the portfolio level, you can also add buildings at this level:

**Create a building**<br/>
URL: `POST api/v2.1/buildings`<br/>
Body:
```json
{
  "classificationType": "GUID",
  "portfolioId": "GUID",
  "name": "string",
  "cadastralDesignation": "string",
  "cadastralArea": 0,
  "parcelnumber": "string",
  "publicLawRestriction": "string",
  "completionDate": "2018-08-09T15:01:11.873Z",
  "lastRenovationDate": "2018-08-09T15:01:11.873Z",
  "addressStreet": "string",
  "addressHousenumber": "string",
  "addressHousenumberAddition": "string",
  "addressZipcode": "string",
  "addressCity": "string",
  "addressCountry": "string",
  "buildingUsage": "string",
  "grossSurfaceArea": 0,
  "energyLabel": "string",
  "energyPerformanceCoefficient": 0,
  "energyIndex": 0,
  "expectedLifespan": 0,
  "expectedLifespanStructure": 0,
  "expectedLifespanSkin": 0,
  "expectedLifespanServices": 0,
  "expectedLifespanSpacePlan": 0,
  "expectedLifespanStuff": 0,
  "breeamLabel": 0,
  "gprLabel": 0,
  "mpgLabel": 0,
  "leedLabel": "string"
}
```

This will return a **201 Created** response containing the created building in the body and the *location* response header will contain the URL to the `GET` request for the created building. You can use either value to find the ID of the created building.

To find the right **classification method** for the *classificationType* field, you can use the result from `https://api.madaster.com/api/v2.1/system/classificationmethods` to determine which *id* you need.

### Building file
A building file can be either a source file (IFC/BIM or Excel) or a documentation file. The source files are used to supply the building containing these files with information about the contents of the building. A building file is a collection of *building file elements* and some metadata to inform the user what the file contains.

#### API calls
To upload an IFC file, you first need to create a building file and when the file is created, you can start the upload process and wait for it to finish. If you want to create a building file yourself, you need to take a few more steps instead of uploading to manually start the process.

IFC File: Create a building file > Upload > Activate *(optional)*
Manual File: Create a building file > Start importing > *Create building file elements (see below)* > Start Refining > Activate *(optional)*

**Create a building file**<br/>
URL: `POST api/v2.1/buildings/{buildingId}/files`<br/>
Body:
```json
{
  "name": "string",
  "type": 0,
  "tags": [
    "string"
  ]
}
```

The type property can be either source (0) or information (1), see [BuildingFileType](/enums#buildingfiletype).

**Upload**<br/>
URL: `POST /api/v2.1/buildings/{buildingId}/files/{fileId}/upload`

**Start importing**<br/>
URL: `POST /api/v2.1/buildings/{buildingId}/files/{fileId}/setimporting`

**Start refining**<br/>
URL `POST /api/v2.1/buildings/{buildingId}/files/{fileId}/startrefinement`

**Activate**<br/>
URL: `POST /api/v2.1/buildings/{buildingId}/files/{fileId}/active`

### Building file element
The bottom level of the structure is a *building file element*, which should be relatable to one real world element. It contains quantity information about the element and some metadata that describes its use, location and circularity.

#### API calls
If you create a building file without uploading an actual file to it, you can create building file elements manually. To start this process, you should call the *Start importing* action of the building. When the status is set to 'importing' you can create building file elements. When you are done creating elements, you should call the *Start refining* action of the building.

**Create building file element**<br/>
URL: `POST /api/v2.1/buildings/{buildingId}/files/{fileId}/elements`<br/>
Body:
```json
{
  "id": "GUID",
  "materialName": "string",
  "typeName": "string",
  "elementClass": "string",
  "volume": 0,
  "area": 0,
  "height": 0,
  "width": 0,
  "length": 0,
  "weight": 0,
  "phase": "string",
  "classification": "string",
  "floor": "string"
}
```
