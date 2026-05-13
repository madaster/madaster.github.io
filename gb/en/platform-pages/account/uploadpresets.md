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

The list of defined presets for upload for IFC files available at this level (account/folder/object) is displayed here. 

It is possible to add/edit/delete these presets. At folder or object level, all presets inherit by default the presets defined on the higher parent level. Unless the button **Break inheritance <iconify-icon inline icon='mdi-cog-transfer-outline'/>** in the toolbar was pressed. Once the inheritance is broken it is possible to create new presets for this lower and all lower levels.

When inheritance has been broken, there is a possibility to **Restore inheritance from parent level. <iconify-icon inline icon='mdi-restore'/>** which will delete all presets defined at this level.

## Presets for source file upload

Madaster offers the ability to create various Presets for IFC source file upload which can be customized from the account-level Settings tab <iconify-icon inline icon='mdi-dots-vertical'/>. Click **Add upload preset <iconify-icon inline icon='mdi-plus-circle-outline'/>** and configure the following properties and settings:

1. Enter a name for your preset, and check the box if this preset should be selected per default on all uploads.
2. Choose the Classification method that is used in the source file.
3. Choose the Default element phase if none is found in the properties.
4. You can now enter which PropertySets and PropertyNames are used in your models for **Product Identification**, **IFC Element Base Properties** or **IFC Element Properties for Reuse** related descriptions.
5. Databases can be selected and prioritised. Click <iconify-icon inline icon='mdi-plus'/> on available sources to select. Drag and drop to decide the order of which the data sources will be searched for matching.
6. To enrich the search criteria, languages can be selected if relevant for the selected data source. If a language is selected, it will be taken into account while matching the data from the database to the data of the source file.

Click **Save** or cancel.