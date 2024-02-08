---
title: Create your own databases with custom materials and products
description: Create databases, create products
ref: create-your-own-databases-with-custom-materials-and-products
type: Get Started
menubar: get-started-nav
---

Create databases, create products.

## Create databases

Databases can be added at <a href="../knowledge-base/databases#database-at-different-levels-account--folder--building">account level/folder level/building level</a>.

1. <a href="../knowledge-base/databases#database-at-different-levels-account--folder--building">From Account, Portfolio or Building level</a> go to **General** and click on **New Database**.
2. **Name** the database, add **description**, and decide if you want the created database to be used as the **default selected database on upload**.
3. **Press save**.
4. Information can be changed by pressing **Edit Database Properties** or can be deleted by pressing **Delete Database**.

## Invite users

Users can be invited via email and systems connected via API-Token

### Adding Users

1. In the database, go to tab **Users** and click **Add User**.
2. **Enter E-mail address** and allocate [permissions](../knowledge-base/users.md) to the profile.
3. **Press save**.
Users can be removed from a database (if you have sufficient rights) by pressing the <iconify-icon inline icon='mdi-delete'/> in their table (bottom right).
5. Users can be edited from a database (if you have sufficient rights) by pressing the <iconify-icon inline icon='mdi-pencil-outline'/> in their table (bottom right).

### Adding API Token

1. In the database go to tab **Users** and click **Add API Token**.
2. <a href="../api/api.html" target="_blank">Name Token, set permissions and expiration time (life span)</a>.
3. **Press save**.
4. Tokens can be removed from a database (if you have sufficient rights) by pressing the <iconify-icon inline icon='mdi-delete'/> in their table (bottom right).
5. Tokens can be edited from a database (if you have sufficient rights) by pressing the <iconify-icon inline icon='mdi-pencil-outline'/> in their table (bottom right).

## Share databases with other accounts, folders, buildings

* Share:
  * A database can be shared with multiple accounts, folders or buildings. This makes it possible, for example, for a company to set up a database and make the materials and products available to users from another account. As a shared database, changes and additions made by one user will be visible to all other users of the database.
* Set database rights when sharing:
  * When sharing a database, it is necessary to determine the rights with which the users -of the account/folder/building with which you share it- can use the materials and/or products. A database can be shared with four different types of rights:
    * **Map** – shared users can link elements to materials and products to the database.
    * **Copy** – in addition to mapping, shared users can copy materials and products from the database to another database.
    * **Contribute** – in addition to mapping and copying, shared users can add new materials and products to the database.
    * **Administer** – in addition to mapping, copying, and contributing, shared users can manage the rights on the account/folder/building with which this database is shared.

## Create and edit products

Madaster distinguishes between five different types of products, namely: volume, area, length, quantity and energy products. The choice for one of these types depends primarily on the available geometric data of the relevant building element in the source file.

1. In the database go to register **Database** and click **Add Product**
1. **Enter Product Name** and choose **product type**.
   * Volume (e.g. concrete)
   * Area (e.g. floor)
   * Length (e.g. pipe)
   * Quantity (e.g. door hardware)
   * Energy (e.g. electricity usage)
1. Enter mandatory fields in <a href="../knowledge-base/databases#product-information--general" target="_blank">Product Information Tab</a>. Moreover, define if circularity and environmental values should be calculated from Bill of Materials or not
1. Enter information in <a href="../knowledge-base/databases#product-circularity-tab" target="_blank">Circularity Tab</a>
1. Enter information in the <a href="../knowledge-base/databases" target="_blank">Environment Tab</a>
1. Enter Search Criteria.
   * Press on Add Criterion
   * Enter Search Criterion (e.g. Name, Description used in BIM Model)
   * Press Save
1. Enter <a href="../knowledge-base/databases" target="_blank">Financial Information</a>
1. Press Save
1. Products can be edited, deleted, copied and viewed in the database.

## Duplicate and Edit Products

1. Select a Product in the database
1. Press Duplicate Element
1. Edit Material or Product accordingly

## Organize Databases

From the Database tab in you database, you can see a table of all products and materials in the database. Each product can be expanded by clicking the arrow down icon <iconify-icon inline icon='mdi-chevron-down'/> at the end of the product's row.
In the expansion the specific information for the product is visible. At the end of the product's row, there are icons for editing <iconify-icon inline icon='mdi-pencil-outline'/>, deleting <iconify-icon inline icon='mdi-delete'/>, adding a new version to <iconify-icon inline icon='mdi-content-duplicate'/>, and viewing the product <iconify-icon inline icon='mdi-arrow-right-circle-outline'/>.

## Deleting your database

A database can only be deleted when there are no more products or materials registered to it. Once all the products are deleted from a database, you can click **Delete database** from the upper toolbar. Click **Yes** on the confirmation popup if you are sure and the database will be deleted. 
