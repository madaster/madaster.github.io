---
title: Building
ref: building-level
---

## WHAT INFORMATION IS SHOWN HERE?
The total mass and material intensity (mass/m2) are displayed. When a benchmark is selected, and information is available, the object is compared to others. Unknown elements are shown to so they can be modified, and in turn included in calculations. Using the dropdown, the mass is displayed by matrix, shearing layer, and material family. 

### Mass By Matrix
The table is divided horizontally into a material classification (Madaster or Table3-NL_SfB). Vertically, a subdivision is made into the different building layers.

#### Building Layers
The first column 'Totals' shows the quantities (mass) and the number of products (pieces) per type of material, and the percentage in relation to the other materials used for this building. In addition to this percentage, the weight and volume per type of material are also visible.

**"Layers of Brand'** The other columns show per 'shell' of the building, by means of the so-called 'Layers of Fire', which material has been used in the building envelope in question, and the percentage in relation to the other materials in this building envelope. In addition to this percentage, the weight and volume per type of material are also visible.

#### Materials
If you have chosen to display the seven material families, the material family is 'unknown' if there is no match between the element and the database of materials and products. These elements will appear in the column 'Unknown' under the 5 construction phases. If you have chosen to display according to Madaster V2, materials will not be displayed if there is no match between the element and the database of materials and products.

You can obtain more information about the materials used by clicking on one of the circles. A new screen will open, explaining which materials and products have been used. For example, the material type 'brick' can be specified to the materials 'concrete' and 'brick' and to the products 'reinforced pillar' which in turn consists of 'brick'. You can see in what volume each material occurs. If you have opted for the material classification based on Madaster V2, you can further open the different types of materials in the column on the left by clicking on a type of material. In this way you can further zoom in on the material classification.

**Filter**
In this overview a filter can be used. In the filter materials can be entered, and only these materials are shown in the table. The search results in the filter can be turned off by clicking on cross.

**View** 
By the 'view-switch' the material families are positioned horizontally and the building shells vertically. This gives you the same data in a different overview. The percentages now add up in the material classification column.

**Source files** 
By clicking on 'Source files', a pop-up window appears in which the quality, completeness of information of the active source files is shown.


#### Products
To gain insight into the products present, it is possible to click on a 'building envelope', for example 'Construction' or 'Technical installations'. You will then go to a new screen where you will gain insight into the applied products of this specific building envelope. On this page you can filter by keyword, Classification method (left column) or level (floor).

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
