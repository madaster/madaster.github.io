---
title: Upload presets
ref: account-uploadpresets
type: Platform Pages
menubar: platform-pages-nav
redirect_from:
  - platform-pages/folder/uploadpresets
  - platform-pages/building/uploadpresets
---

## What information is shown here?
The list of defined upload presets for IFC files available at this level (account/folder/building) is displayed here.
Also it is possible to add/edit/delete these presets.


At folder or building level, all presets inherit by default the presets defined at a higher level. 

It is possible to break this inheritance by clicking 'break inheritance' in the toolbar. Once the inheritance is broken it is possible to create new presets for this lower and all lower levels.
When inheritance has been broken, there is a possibility to restore the inheritance which will delete all presets defined at this level.

## Presets for source file upload

Madaster offers the ability to create various Presets for source file upload which can be customized from the account-level Settings tab:

1. Click the "Add upload preset" Upload button and configure the following properties and settings:
2. Enter a name for your preset, and define if this preset should be selected per default on all uploads.
2. Choose the Classification method that is used in the source file.
4. You can now enter which PropertySets and Property Names are used in your models for Building number, Phase, Classification codes, GTIN, reuse percentage and Material descriptions.
5. Data sources and priority can be chosen. Click + on available sources to select. Drag and drop to decide the order of which the data sources will be searched for matching.
6. To enrich the search criteria, languages can be selected if relevant for the selected data source. If a language is selected, it will be taken in account while matching the data from the database to the data of the source file.

Click on 'Save' or 'Cancel'.
