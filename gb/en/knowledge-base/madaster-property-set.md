---
title: Madaster property set
description: Description to be added
ref: madaster-property-set
type: Knowledge Base
menubar: knowledge-base-nav
---

When using BIM, properties need to be in a certain format for Madaster to recognize them. More details on the Madaster relevant properties, see our page on [Preparing BIM IFC source files](./preparing-bim-ifc-source-files.md).
The Madaster property set (Pset) is an aid for using these properties, instead of declaring them independently.
Once the Pset is uploaded into a project, a number of parameters can be filled out. There is no obligation to fill out all, however those that are filled out will always be recognized by Madaster first.
e.g. If a user filles out the Madaster Pset property "Length", while the standard BaseQuantity "Length" is also filled out, Madaster will prioritise the Madaster Pset.

## Madaster Revit property set (CPset_Madaster)

The files ("01_Revit shared parameter file_Madaster" and "02_User Defined PropertySet_Madaster") for user defined property sets can be downloaded in the [Download Section](../resources/downloads.md).
The fist file contains the shared parameters that can be loaded into any Revit project, while the second file needs to be selected when exporting a Revit model to properly export the Madaster Pset.

## Madaster ArchiCAD property set (CPset_Madaster)

The file ("01_Archicad propertyfile_madaster") for user defined property sets can be downloaded in the [Download Section](../resources/downloads.md).
This file contains the shared parameters that can be loaded into any ArchiCAD project.
