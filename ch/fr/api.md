---
title: API
ref: api
menubar: none
---

# Madaster API
The **Madaster API** endpoint can be used to interact with the Madaster Platform and its resources.
This API does not fully cover all functionality of the platform yet, please refer to the [OpenAPI documentation](https://api.madaster.com/).

To access the API resources, you need an authorization token.
If you do not have one yet, see the chapter about Authorization below.
This token should be sent as a header with the name 'X-API-Key', which will authenticate the request with the token.

## Authorization
To access the resources of this API, you need an API key. This key needs to be attached to the request in the *X-API-Key* header.
To acquire an API key, you need to add a token in the Madaster Platform, or ask your account manager to do this for you.
This will give you access to the resources and their attached entities.

### Add a token to a account, folder, building or database
- Go to the resource page and click on the *Users* tab

<img src="/assets/images/api/addtoken1.png" class="api-img"/>

- Click on the *Add API Token* button

<img src="/assets/images/api/addtoken2.png" class="api-img"/>

- Enter a name for this token, copy the generated key (1), choose a permission level and expiration time, and finish by clicking on the Add button (2)

<img src="/assets/images/api/addtoken3.png" class="api-img"/>

## Versions
The API is continually being improved, so as time progresses, more *versions* are added to the interface. Please refer to the [OpenAPI documentation](https://api.madaster.com/) to find which versions support which API calls. It is suggested to always use the latest version available for an API request; but the old versions will remain available for some time for legacy purposes. To select an API version, append the version tag to the API endpoint. For version 3.0 for example, use https://api.madaster.com/api/v3.0

## Examples
In the [Github repository](https://github.com/Madaster/examples) you can find some examples on how to interact with the API in different programming languages.
