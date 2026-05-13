---
title: Databases
description: Database configuration, sourcing and maintenance
ref: databases
type: Knowledge Base
menubar: knowledge-base-nav
---

Database configuration, sourcing and maintenance.

## Available databases

Madaster distinguishes between 3 types of databases, which are listed in the left-hand navigation list <iconify-icon inline icon='mdi-menu'/> under <iconify-icon inline icon='mdi-database-cog-outline'/> **System databases & suppliers**: 

1. **Verified / System databases** <iconify-icon inline icon='mdi-database-check-outline'/> <br>Madaster is connected to various official data sources provided by officials from different countries, e.g. Eco-Platform, EPEA, KBOB, Nationale Millieu Database, Ökobaudat. <br>*Madaster and Madaster C2C where the first databases the platform offered to our founding partners. Since those only contain very limited material information we recommend to switch to other databases (e.g. the ones from EPEA).
2. **Supplier databases** <iconify-icon inline icon='mdi-database'/> <br>Provide product information straigth from the Producers themselves.
3. **Account databases** <br>These individual customer databases are created within the respective accounts for each user's own projects and are not publicly accessible.

## Creating Databases

### Supplier
Manufacturer can add a **New database <iconify-icon inline icon='mdi-plus'/>** directly in the Supplier tab of their account.

### User
Account databases for **normal users** can be added at each level within the own account (account / folder / object) since the account structure in Madaster is flexible and customizable to suit your preferences. The platform allows several folders per account, which may contain subfolders or buildings/infra objects. To support this structure in terms of materials and products, it is possible to create and use one or multiple databases.

1. Database at **account level <iconify-icon inline icon='mdi-briefcase-variant'/>** <br>A database on this level can be used by all underlying folder levels and objects within the account. The database can also be <a href="../get-started/create-your-own-databases-with-custom-materials-and-products#share-databases-with-other-accounts-folders-buildings" target="_blank">shared with other accounts</a>.
2. Database at **folder level <iconify-icon inline icon='mdi-folder-outline'/>** <br>A database on this level can only be used by objects in the selected folder and underlying levels. The database can also be <a href="../get-started/create-your-own-databases-with-custom-materials-and-products#share-databases-with-other-accounts-folders-buildings" target="_blank">shared with other accounts</a>.
3. Database at **object level <iconify-icon inline icon='mdi-office-building'/> <iconify-icon inline icon='mdi-wall'/> <iconify-icon inline icon='mdi-bridge'/> <iconify-icon inline icon='mdi-sprout'/> <iconify-icon inline icon='mdi-road-variant'/> <iconify-icon inline icon='mdi-pipe'/> <iconify-icon inline icon='mdi-train'/>** <br>A database on this level can only be used by the selected object/project. This database CANNOT be shared with other accounts.

Users can add a **New database <iconify-icon inline icon='mdi-database-plus-outline'/>** directly at each level in General tab.

## Database configuration

### User
The configuration options for **account databases** are limited to
* give a name, logo and description
* decide whether it should be set as default selected database on upload
* decide whether inactive products should be shown by default in the database overview
* decide whether to use the product names as search criterion <br>for the automatic mapping on upload
* decide whether it should be restricted to selected input databases for the creation of <a href="../knowledge-base/databases-products.html#difference-between-products-and-components" target="_blank">components</a>.

### Supplier
Manufacturer databases serve a different purpose and therefor differ in the options or properties to configure.

<figure><img src="/assets/images/knowledgebase/database_properties.png" alt="Edit database properties"><figcaption>Edit database properties</figcaption></figure>

* Give a name, logo and description <br>either in a language that is valid globally <iconify-icon inline icon='mdi-earth-off'/> or differ according to the platform's language settings <iconify-icon inline icon='mdi-earth'/>.
* Decide whether inactive products should be shown by default in the database overview. <br>*In active products could be dataset were the EPD is expired or a new productversion is on the market. Those might not be available anymore but still built in in existing buildings/objects.*
* Decide whether to use the product names as search criterion <br>for the automatic mapping on upload.
* Decide whether it should be restricted to selected input databases for the creation of <a href="../knowledge-base/databases-products.html#difference-between-products-and-components" target="_blank">components</a>.

If the feature **Track&Trace** is enable within your account you can decide how you want your product data to be shared. Only if the information is provided will it be possible to track your products in the T&T module.
* **Open** = Madaster users can link product information to the elements in their objects without having to share information about their objects in return.
* **Sharing with optout** =  Madaster users can link product information to the elements in their objects, but have to actively choose if they want to share information about their objects in return.
* **Datasharing** = Madaster users can only link product information to the elements in their objects if they share information about their objects in return (esp. location of the object, amount of the product, date of placement). 
<br>This option allows you to enter a license agreement that explains to users how the object data they share will be used.

Next is a set of checkboxes, all regarding the Product Information of the products in your database. You can set whether or not the users: 
* may see a **Bill of Materials**
* can see the **Circularity tab**
* can see the **Environmental tab**
* can see the **Financial tab**
* can see the **Product files**
* can use the product in their own Bill of Materials <br>*to e.g. create a multi layered product or component in their own database.*
* can copy all product information in their own database <br>*to e.g. create a product similar to yours or to enter some discrepancies.*

Finally, you decide when —or whether— you want to make the database available to all platform users in which countries. (For example, where are your products’ EPD data recognized as valid?)

The database configuration can be adjusted at any time in the Database tab using the button **Edit database properties <iconify-icon inline icon='mdi-pencil-outline'/>**.

## Products

For detailed information about products please see the <a href="../knowledge-base/databases-products.html" target="_blank">Products page</a>.

> Note: Your database should be maintained on a regular base to make sure your products are still up to date. The information coming from your database will help keeping the calculations and information on objects of high quality.

### Adding products
The database and its products can be filled in various ways, e.g. manually, via an API, via an excel, via copying information or soon via AI upload. For detailed information see <a href="../knowledge-base/databases-products#Adding Products to databases" target="_blank">here</a>.

The following product information is valuable in the context of the platform’s analyses:

1. Product information (name, type, service life, density, functional unit, composition)
2. Circularity (material origin, detachability, material recovery)
3. Environment (environmental information according to EPD)
4. Search criteria (for automatic matching with specific material/product descriptions)
5. Financial (rates for transportation and refurbishment costs)

This configuration allows you to create both monolithic products and multilayer products (e.g. Products with a Bill of Materials or Components).

### View, edit, and delete products
For existing products there are various customization options are available via the database overview. 
1. Edit product <iconify-icon inline icon='mdi-pencil-outline'/>
2. Delete product <iconify-icon inline icon='mdi-delete-outline'/>
3. Create a new version of the product <iconify-icon inline icon='mdi-content-duplicate'/>
4. View product <iconify-icon inline icon='mdi-arrow-right-circle-outline'/>
5. Expand condensed product information <iconify-icon inline icon='mdi-chevron-down'/>

## Import/Export Database

Once this feature is enabled, you can import or export products and materials from a database using an Excel template. In the Dossier tab simply click in the toolbar **Import/Export** <iconify-icon inline icon='mdi-swap-vertical'/> and choose before clicking OK.

## User permission

1. **Contributors** can add and modify products in database on the platform.
2. **Administrators** can additionally manage users and share the database with additional accounts.

## Add API Token

For more information on how to add a Token and use the Madaster API, visit our <a href="../api/index.md" target="_blank">API Documentation</a>