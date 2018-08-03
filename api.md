# Madaster Private API
The **Madaster Private API** endpoint can be used to interact with the Madaster Platform and its resources.
This API does not fully cover all functionality of the platform yet, please refer to the [*docs*](https://api.madaster.com/docs) files or the [Swagger/OpenAPI documentation](https://api.madaster.com/swagger).

To access the API resources, you need an authorization token.
If you do not have one yet, see the chapter about Authorization below.
This token should be sent as a header with the name 'X-API-Key', which will authenticate the request with the token.
To find out which requests are available and which responses they might produce, see the [*docs*](https://api.madaster.com/docs) files or the [Swagger/OpenAPI documentation](https://api.madaster.com/swagger).

This API can be reached at the endpoint: **[https://api.madaster.com/](https://api.madaster.com/)**<br/>
The interactive Swagger/OpenAPI documentation can be found at: **[https://api.madaster.com/swagger](https://api.madaster.com/swagger)**<br/>
If you prefer a static documentation: **[https://api.madaster.com/docs](https://api.madaster.com/docs)**

## Authorization
To access the resources of this API, you need an API key. This key needs to be attached to the request in the *X-API-Key* header.
To acquire an API key, you need to add a token to either a Portfolio or a Building in the Madaster Platform, or ask your account manager to do this for you.
This will give you access to these resources and their attached entities.

### Add a token to a building
- Go to the building page and click on the *Users* tab

![Step 1](assets/images/api/addbuildingotoken1.png)

- Click on the *Add API Token* button

![Step 2](assets/images/api/addbuildingtoken2.png)

- Enter a name for this token, click on the gear icon (1), copy the generated key (2), choose a permission level and expiration time, and finish by clicking on the Add button (3)

![Step 3](assets/images/api/addtoken3.png)

### Add a token to a portfolio
- Go to the portfolio page and click on the *Users* tab

![Step 1](assets/images/api/addportfoliotoken1.png)

- Click on the *Add API Token* button

![Step 2](assets/images/api/addportfoliotoken2.png)

- Enter a name for this token, click on the gear icon (1), copy the generated key (2), choose a permission level and expiration time, and finish by clicking on the Add button (3)

![Step 3](assets/images/api/addtoken3.png)

## Connection
To connect to the API, multiple tools and languages can be used. Because the Madaster Private API implements the REST interface, all applications that connect to a REST service can communicate with this API. A few examples can be found below.


### Versions
The API is continually being improved, so as time progresses, more *versions* are added to the interface. Please refer to the [Swagger/OpenAPI documentation](https://api.madaster.com/swagger) to find which versions support which API calls. It is suggested to always use the latest version available for an API request; but the old versions will remain available for legacy purposes. To select an API version, append the version tag to the API endpoint. For version 1.1 for example, use https://api.madaster.com/api/v1.1

### Postman
[Postman](https://www.getpostman.com/) is an easy to use tool that can connect to all sorts of endpoint because it revolves around web requests.

![Postman](assets/images/api/postman.png)

### C#
Using any programming language, look for a HTTP client or Web Request client to access the REST resources. The HttpClient in C# for example can be used:

```csharp
HttpClient client = new HttpClient();
client.BaseAddress = new Uri("https://api.madaster.com/");
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
HttpResponseMessage response = await client.GetAsync("api/v1.1/buildings");
if (response.IsSuccessStatusCode)
{
    buildings = await response.Content.ReadAsAsync<IEnumerable<Building>>();
}
```
