---
title: Mass
ref: building-performance-mass
type: Platform Pages
menubar: platform-pages-nav
redirect_from:
  - platform-pages/building/level-product
  - platform-pages/building/product-circularity
  - platform-pages/building/product-financial
  - platform-pages/building/product-environmental
  - platform-pages/building/product-materials
  - platform-pages/building/product-product
  - platform-pages/building/product-ifc
---

## What Information Is Shown Here?
The total mass and material intensity (mass/m2) are displayed. When a benchmark is selected, and information is available, the object is compared to others. Unknown elements are shown to so they can be modified, and in turn included in calculations. Using the dropdown, the mass is displayed by matrix, shearing layer, and material family. 

### Mass By Matrix
The table is divided horizontally into a material classification (Madaster or Madaster V2). Vertically, a subdivision is made into the different [building layers ("Layers of Brand")](../../knowledge-base/madaster-glossary.md).

#### Building Layers
The first column 'Totals' shows the mass and the number of products (pieces) per material family, as well as the percentage in mass. 

The Layers column shows per [layer](../../knowledge-base/madaster-glossary.md), the percentage and mass of  material has been used in the building layer in question.


#### Material families
Elements from which no material family composition is known are displayed under the material family is 'unknown'.
You can obtain more information about the materials used by clicking on one of the circles. A popup screen will open, showing which materials and products have been used.

**Filter**
In this overview a filter can be used. In the filter materials can be entered, and only these materials are shown in the table. The search results in the filter can be turned off by clicking on cross.

**View** 
By the 'view-switch' the material families are positioned horizontally and the building shells vertically. This gives you the same data in a different overview. The percentages now add up in the material classification column.

**Source files** 
By clicking on 'Source files', a pop-up window appears in which the quality, completeness of information of the active source files is shown.


#### Products
To gain insight into the products present, it is possible to click on a 'building layer', for example 'Construction' or 'Technical installations'. You will then go to a new screen where you will gain insight into the applied products of this specific building layer. On this page you can filter by keyword, Classification method (left column) or level (floor).

If a product is selected, you can view more product information for that specific product on the right side of the tabs 'Material', 'Product' 'Circularity' and 'IFC'. In the 'Product' tab you can then add a document to this product, such as a manual, a certificate, warranty statement or a 'Product Passport'.

### Mass By Shearing Layer
A pie chart displays mass by shearing layer on the left. On the right, a stacked bar chart shows the material family composition of each shearing layer. Users can click on a bar in the stacked bar chart to view which materials and products are comprised within. Users can filter by material, floor, and source file.

Users can also click on a shearing layer in the pie chart. When doing so, all metrics become specific to the selected shearing layer. Additionally, the stacked bar chart on the right updates to show the material sub-families of the shearing layer. Again, users can click on a bar in the stacked bar chart to view which materials are comprised within. 

### Mass By Material Family
A pie chart displays mass by material family on the left. On the right, a stacked bar chart shows the distribution of material families across the shearing layers. Users can click on a bar in the stacked bar chart to view which materials are comprised within. Users can filter by material, floor, and source file.

Users can also click on a material family in the pie chart. When doing so, the total mass metric updates to be specific to the selected material family, and the material intensity and benchmarking metrics are be removed. Additionally, the stacked bar chart on the right updates to show the distribution of material sub-families across the shearing layers. Again, users can click on a bar in the stacked bar chart to view which exact materials are comprised within. 

### Unknown Elements
Unknown elements are those that were not taken into account during calculations. These can occur for 3 different reasons:

__*Elements Unlinked*__ : these elements are not linked to material/product database, and thus cannot be reported on.

__*Elements with Unknown Layer*__: these elements are missing construction classification information, and thus cannot be assigned to a shearing layer.

__*Elements with Insufficient Geometry*__: these elements are lacking sufficient geometry, and thus cannot be used for calculations.
