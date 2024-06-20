---
title: Enrich objects with material and product databases
description: Enrich source files with databases, troubleshoot elements not enriched, and refresh source files
ref: enrich-objects-with-material-and-product-databases
type: Get Started
menubar: get-started-nav
---

Enrich source files with databases, troubleshoot elements not enriched, and refresh source files

When a source file is processed, by clicking on the Source file Name under the **Dossier** tab, the Madaster system provides insight into the:
* **Quality of the source file**
  * Percentage of elements that contain a classification method (e.g. SfB, OmniClass table 21, NS 3451, DIN 276...) and are therefore assigned to the correct shearing layer (site, structure, etc.) (**location**).
  * Percentage of elements that contain a **material** description.
  * Percentage of elements that contain geometric information (**base quantities**).
* **Quality of the matching process**
  * Percentage of elements linked to material or product in any of the available databases.
  * Percentage of elements with known mass.

## Check Matching Process

Go to the tab **Enrich** <iconify-icon inline icon='mdi:link-variant-plus'/> (choose Manual) to check for missing material linking, classification codes and geometric information by using the filters on the left. If geometric information is missing you need to go back to the BIM (or Excel)-file and add the missing information and reload the file. The same goes for classification and material names missing in case this information should be included in the original file. Click <a href="../knowledge-base/preparing-bim-ifc-source-files" target="_blank">here</a> for how to prepare your ifc-file for Madaster. When classification and material matching is only necessary for the material passport these can be manually added in the Madaster platform by ticking the checkbox of one or more element.

The following options become available in the bottom of the page:
1. A "Link"-tool to link elements missing material information or not linked with a database. (See: Manual matching process in Madaster).
2. A "writing" tool where you can change/add building numbers, Feedstock input and output, and detachability.
3. An "Unlinking-tool" to unlink elements that wrongfully mapped with a database.
4. An "Include and "Exclude"-tool to exclude elements that shouldn’t be a part of the calculations (eg. Air) or wrongfully Excluded elements can be ‘Included’ again. 

>Tip: When looking for elements with the ‘Search’-tool the use of * to include any letter(s) before and/or after the word is recommended to get better matches, eg. *wool.

## Manual matching process in Madaster

You can manually match elements with products/materials in existing databases.

1. Tick the checkbox of one or more element in the enrichement screen
2. Click on the “Link”-tool. The following options are available:
  * Add a material, add a product or duplicate the element to your own database. Click <a href="../get-started/create-your-own-databases-with-custom-materials-and-products" target="_blank">here</a> for more information on creating custom materials.
  * Linking the element with a product or material from an existing database by using the search-tool, checking the box of the material/product you want to link with, and clicking on "Link"
  * Open up more information on the product by clicking on the arrow next to a product. By then clicking on the arrow, you’ll be able to create search criteria and edit circularity, environmental info etc. for your product or material in this product for future automatic matching with this product. Click <a href="../knowledge-base/databases#search-criteria" target="_blank">here</a>.

>Tip: While you're enriching the file the Madaster-platform is performing a new matching process in the background. This will change the result of the “Quality of the Matching process”. After the enrichment is done you’ll be asked to run a recalculation that you’ll need to confirm.

## Enrich again

With the tab "Enrich again" you can add/delete languages and databases to a new enrichment process. When ticking the box of “Reset all mappings” all elements will be unlinked. This could be usefull when you have matched your file with the wrong database and so avoiding manual relinking.


Looking for information on creating your own materials and products? Click <a href="../get-started/create-your-own-databases-with-custom-materials-and-products" target="_blank">here</a>.

<a class="next-button" href="../get-started/object-insights-and-performance">Next step: Object Insights and Performance</a>
