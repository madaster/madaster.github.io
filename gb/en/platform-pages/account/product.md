---
title: Product
ref: product
redirect_from:
  - platform-pages/view/product
  - platform-pages/view/product-searchcriteria
  - platform-pages/view/product-files
  - platform-pages/view/product-finance
  - platform-pages/view/product-children
  - platform-pages/view/product-circularity
  - platform-pages/view/product-environment
  - platform-pages/edit/product
  - platform-pages/copy/product
  - platform-pages/edit/product-searchcriteria
  - platform-pages/edit/product-files
  - platform-pages/edit/product-finance
  - platform-pages/new/product
  
---

## HOW TO ADD A NEW PRODUCT?
There are two ways to add a new product:

1. Via the "Materials & Products" tab on the administration page, you will find the "Add Product" button in the bar under the name of the tab.

2. It is also possible to add a new product in the enrichment view. You can access this screen by clicking on the "Show details" button behind a source file. Subsequently, you can go to the second tab "Enrich". Here you will see an overview of all the elements from your source file. If the element is not yet linked, you can click on the "Link" icon. A screen appears with the heading "Create new". Click on the "Product" button below it. If the element is already linked, you can click on the three dots at the end of the line and then on "Link again". The same screen as described above appears.

Both options will take you to the screen to add a new product. Fill in all the information about the product, the fields marked with * are mandatory. It is possible to enter the name and description in six languages. It is only necessary to enter the name in the language selected on the platform. If no name and/or description has been entered in the other languages, the name and/or description will be copied to the other languages. In the "Product type" field, indicate whether the product is a volume product, an area product, a length product or a piece of a product (for example, a volume product can be a steel beam and a piece of a product can be an air conditioner). Please note that the "Product type" field cannot be changed after the product has been saved. After you have entered all the information at the bottom of the page, click on the "Save" button. The product is then created in the database and is now in the material and product overview.
You will be taken to the screen where you can enter further data about the product you have just added. By going through the various tabs you can enter additional data, e.g. in the field "Search criteria", "Product composition" and "Financial information".

### SEARCH CRITERIA ###
The screen appears for you to further specify the data of the product you have just added. By going through the different tabs, you can enter additional data. It is essential that (good) search criteria are entered! These are the search terms on which Madaster bases the automatic matching process after loading a source file. Always enter the full and identical name of the product as search criteria. But preferably for multiple search criteria. A search criterion has a matching type

- Contains
- Is equal to
- Starts with
- Ends with (This also helps when entering incomplete search terms as search criteria).

### PRODUCT SCALING ###

How do you use the scalability option on a product?

Within the database, check the box for "scalable" on the product

There are multiple ways a scaling of a product can be defined depdending on the specific needs of a particular product. For instance, it can be a wall whose thickness increases with an increase in area, or a pipe that increases in diameter with an increase in length.

Scalable products can be applied as new products or applied to existing products. Within the database, when "new product" is selected, or "edit" is selected for an existing product, on the right side of the product information form there is now an option to check whether a product is "scalable" or not. 

![The Scaling information form](/assets/images/releasenotes/202402-9876-1.png)

When "scalable" is selected, there will be more fields visible where the scalability parameters of the product can be defined. This can be based on the functional unit, on fixed dimensions, or even a user-defined property. 

![The Scaling formula](/assets/images/releasenotes/202402-9876-2.png)

Once functional unit has been defined, the scaling unit can be defined, with X in the below being the functional unit.

Linear scaling has the formula: (a * X + c) , where a and c need to be defined

Scaling with power formula: (a * X<sup>b</sup> + c) , where a, b, and c need to be defined

Logarithmic scaling: (a * In(b *X) + c) , where a, b, and c need to be defined.

Exponential scaling: (a *exp(X) + c) , where a and c need to be defined

![The Scalable product page](/assets/images/releasenotes/202402-9876-3.png)

When a file containing scalable products is uploaded, it will automatically match those products and the values for the scalable properties, provided the values are within the margins defined for the product. If the extents of the product are outside the defined margins, the nominal value defined for the product will be assumed. On the enrich screen the values extracted from the excel can be verified.

![Scalability in Enrichment 1](/assets/images/releasenotes/202402-9876-4.png)

![Scalability in Enrichment 2](/assets/images/releasenotes/202402-9876-5.png)

![Scalability in Enrichment 3](/assets/images/releasenotes/202402-9876-6.png)

After activating the file, the mass will be calculated accordin to thespecifications set for scaling:

![Mass Screenshot](/assets/images/releasenotes/202402-9876-6.png)

In the above example, 3 example walls are used, on in the "Skin" layer, one in the "Services" layer, and one in the "Space Plan" layer. 

In the "Services" layer, it is a default wall of 20cm thickness with a grammage of 20kg/m<sup>2</sup> and no scaling, therefore the final wall will be 200kg for 10m<sup>2</sup>

In the "Space plan" layer, the wall is scaled to a thickness of 10cm instead of 20, and with a linear formula that sets its grammage to 0,5(a) * 10(cm) + 10(c) = 15kg/m2, which results in a mass of150kg for the same area of 10m<sup>2</sup>. Without scaling, the mass of this wall would have been assumed as 100kg.

In the "skin" layer, the wall has a thickness of 75cm, and using the same linear scaling formula of 0.5 * 75 + 10 = 47.50kg/m<sup>2</sup> the resulting mass is 475kg for the same area of 10m<sup>2</sup>. Without the scaling formula, the mass of this wall would have been assumed as 750kg.