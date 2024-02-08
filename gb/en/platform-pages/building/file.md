---
title: Source file
ref: building-file
type: Platform Pages
menubar: platform-pages-nav
redirect_from:
  - platform-pages/building/file-detail
---

##  Toolbar
From the toolbar you can perform the following actions:
* Back arrow: return to the [Dossier](./files.md) overview.
*  Show 3d-MODEL: if a 3D model is available, you can view it here.Opens the [3D- viewer](./viewer.md) for this file.
*  Enrich: menu to select [manual enrichment](./file-enrich.md) or automatic enrichment against new databases or to reset the whole enrichment.
*  Transsfer file to another building: transfer the file to another building within the same account or to another account (if you have the right to do so).
*  File export: in case of an IFC file, possiblitity to export the file in excel to be able to modify some data in bulk (detachability, percentage reuse, building numbers, base quantities, etc.)
* File import: to reimport the downloaded excel after modification.
* Active Toggle: to activtae or deactivate the file.
* Recalculate: only when the file is active but some information has been changed (either in the file enrichment or because a linked product data has been changed), the file needs to be recalculated to update the data in the building.

## Quality of source file
The accuracy and reliability of data in the Madaster platform starts with the source file. If the quality of the source file is lower and/or data is incomplete, this will cause the Madaster platform to be less accurate and complete. That is why it is important to maximize the quality of the source file, i.e. the completeness of the information, before it is read into the platform.

In the overview shown you can see the quality of the uploaded source file, broken down into the categories on the basis of which the Madaster platform will further process the file.

**Percentage of classification methods**
- Based on number of elements; percentage of the number of elements in the source file containing a classification code (such as NL_SfB-Table1).
- Based on volume; percentage of the volume for which a classification (such as NL_SfB-Table1) assignment is known.

**Percentage of material allocation**
- Based on number of elements; percentage of the number of elements in the source file containing a material allocation.
- Based on volume; percentage of the volume for which a material attribution is known.

**Percentage of gemoteric dimensions**
- Elements with volume information; percentage of the number of elements in the source file containing volume information (for products of type "volume").
- Elements with area information; percentage of the number of elements in the source file containing area information (for products of type 'area').
- Elements with length information; percentage of the number of elements in the source file containing length information (for products of type 'length').
- Elements without geometrical dimensions; percentage of the elements in the source file that do not contain geometrical information. It is important that this percentage is very low. The volume is the primary unit displayed in the "Building" tab.


### Quality of matching process (Manual or Automatic)
The Madaster platform automatically links the elements present in the imported source file as much as possible to the products present in the selected databases/resources. The overview shown shows the result of this based on number of elements. The number of elements of which the mass is known is also indicated.

**Percentage of linked elements**
- Based on number of elements; the percentage of the number of elements in the source file, which are linked to a product or material in the selected databases/resources.

**Percentage of mass**
- Elements whose mass is known; the percentage of the number of elements in the source file associated with a product or material in the selected databases/sources and whose mass is known'.

