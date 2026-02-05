---
title: Madaster Common Property Set
description: Using the IFC property set CPset_Madaster
ref: madaster-property-set
type: Knowledge Base
menubar: knowledge-base-nav
---

When using BIM, properties need to be in a certain format for Madaster to recognize them. More details on the Madaster relevant properties, see our page on [Preparing BIM IFC source files](./preparing-bim-ifc-source-files.md).

The **Madaster custom property set (CPset)** is an aid for using these properties, instead of declaring them independently. Once the CPset is uploaded into a project, a number of parameters can be filled out. There is no obligation to fill out all but if the custom property set with the name CPset_Madaster is present on an IFC element and within this dataset, the properties below are filled in, then these values ​​of the properties are used within Madaster and other properties are then ignored. 

E.g. if a user entered a value in the Madaster CPset property "Length", while the standard BaseQuantity "Length" has also values, Madaster will prioritise the Madaster CPset.

## CPset_Madaster

| PropertyName                      | PropertyType       | Madaster Element                  |
|-----------------------------------|--------------------|-----------------------------------|
| MaterialOrProductId               | IfcText            | MadasterId                        |
| externaldatabaseId                | IfcText            | externaldatabaseId                |
| GTIN                              | IfcText            | GTIN                              |
| ArticleNumberGLN                  | IfcText            | ArticleNumberGLN                  |
| MaterialOrProductName             | IfcText            | MaterialName                      |
| MaterialOrProductRatio            | IfcText            |                                   |
| Volume                            | IfcVolumeMeasure   | Volume                            |
| Area                              | IfcAreaMeasure     | Area                              |
| Length                            | IfcLengthMeasure   | Length                            |
| Width                             | IfcLengthMeasure   | Width                             |
| Depth                             | IfcLengthMeasure   | Depth                             |
| Height                            | IfcLengthMeasure   | Height                            |
| Weight                            | IfcMassMeasure     | Weight                            |
| Thickness                         | IfcLengthMeasure   | Thickness                         |
| OtherUnit                         | IfcReal            | OtherUnit                         |
| OtherUnitName                     | IfcText            | OtherUnitName                     |
| OtherUnitPropertyName             | IfcText            | OtherUnitPropertyName             |
| Classification                    | IfcText            | Classification                    |
| BuildingNumbers                   | IfcText            | BuildingNumbers                   |
| Phase                             | IfcText            | Phase                             |
| DetachabilityConnectionType       | IfcText            | DetachabilityConnectionType       |
| DetachabilityConnectionTypeDetail | IfcText            | DetachabilityConnectionTypeDetail |
| DetachabilityAccessibility        | IfcText            | DetachabilityAccessibility        |
| DetachabilityIntersection         | IfcText            | DetachabilityIntersection         |
| DetachabilityProductEdge          | IfcText            | DetachabilityProductEdge          |
| Reuse                             | IfcReal            | InputPercentageReuse              |
| InstallationDate                  | IfcText            | InstallationDate                  |
| SerialNumber                      | IfcText            | SerialNumber                      |
| TechnicalCondition                | IfcPositiveInteger | TechnicalCondition                |
| AestheticCondition                | IfcPositiveInteger | AestheticCondition                |
| Comment                           | IfcText            | Comment                           |
| WasteCodes                        | IfcText            | WasteCodes                        |
| AssumedConstructionWaste          | IfcReal            | AssumedConstructionWaste          |
| OverOrdering                      | IfcReal            | OverOrdering                      |

### Additional information

**MaterialOrProductId**\
Identifier of the material or product in a Madaster database.

**externaldatabaseId**\
Identifier of the product or Material in an external database connected to Madaster.

**GTIN**\
Global Trade Item Number of the product.

**ArticleNumberGLN**\
The articleNumber|GLN combination.

**MaterialOrProductName**\
If filled, this material/productname can be used to refer to search criteria.

**MaterialOrProductRatio**\
Split element into children if MaterialOrProductRatio is available

**Classification**\
For example: enter the NL/SfB-Table1 value (2 or 4 digits).

**Phase**\
Value for the building phase.

**Reuse**\
Enter a number in the format 0.01 (1%) and 1.0 (100%). Should be above 0.0 and a maximum of 1.0.

**Waste codes**\
The wastecode format that needs to be used is as followed:
code:percentage:nature:cw-outcome:oo-outcome;code:percentage:nature:cw-outcome:oo-outcome;

This can be for example:
16 02 09*:0.1:Hazardous:70:70;17 01:0.25:Inert:60:60;

Following options are also available:

* code:percentage; In this scenario nature will be default for the belonging code and outcomes will be empty.
* code:percentage:nature; In this scenario the default nature will be overwritten by user input.
* code:percentage:nature:cw-outcome; In this scenario all 4 will be filled, but no overordering outcome.

Following scenario's will result in failure:
* Wrong code
* Double code (in case of multiple waste codes)
* Percentage zero, negative or above 1 (100%)
* Wrong nature
* Wrong outcome
* Outcome for CW that is only valid for OO and vice versa
* Outcome that does not match with selected nature
* Total of all wastecodes above 1 (100%)

**AssumedConstructionWaste**\
Enter a number in the format 0.01 (1%) and 1.0 (100%). Should be above 0.0 and a maximum of 1.0.

**OverOrdering**\
Enter a number in the format 0.01 (1%) and 1.0 (100%). Should be above 0.0 and a maximum of 1.0.

## Madaster Revit property set (CPset_Madaster)

The files ("01_Revit shared parameter file_Madaster" and "02_User Defined PropertySet_Madaster") for user defined property sets can be downloaded in the [Download Section](../resources/downloads.md).
The fist file contains the shared parameters that can be loaded into any Revit project, while the second file needs to be selected when exporting a Revit model to properly export the Madaster Pset.

## Madaster ArchiCAD property set (CPset_Madaster)

The file ("01_Archicad propertyfile_madaster") for user defined property sets can be downloaded in the [Download Section](../resources/downloads.md).
This file contains the shared parameters that can be loaded into any ArchiCAD project.
