---
title: Preparing BIM IFC source files
description: The universal IFC file format will be used when exporting the source file, which will subsequently be uploaded into the Madaster Platform
ref: preparing-bim-ifc-source-files
type: Knowledge Base
menubar: knowledge-base-nav
---

To ensure a detailed and easy calculation on Madaster, the BIM model needs to be prepared well. The following text will guide you through the key points!

## Madaster general guidelines for all IFC source files

*  When preparing a source file in a BIM application (Revit, ArchiCAD, Etc.), the universal IFC file format should be used when exporting the model, which will subsequently be uploaded into the Madaster Platform.
*  Madaster supports the acceptance and application of the BIM Basis IDS (Information Delivery Specification). For more information, please refer to <a href="https://ucm.buildingsmart.org/use-case-details/2594/en" target="_blank">https://ucm.buildingsmart.org/use-case-details/2594/en</a>.
*  The Madaster guidelines for building information modelling and exporting an IFC file are as follows:
  * All elements within the model must include:
    1. Unique GUIDs.
    2. Geometric properties (so-called 'base quantities').
    3. A Material description.
    4. A classification coding, on the basis of which Madaster can assign the elements to the appropriate <a href="">shearing layer</a>.
       Most countries have their own standards for building element classifications (Please refer to the <a href="https://docs.madaster.com/nl/en/knowledge-base/madaster-glossary.html" target="_blank">Glossary - Industry Standards and your country</a>). The Madaster platform allows you to read your national classification from the BIM files and map it to the layers of the building.
  * Ensure the correct "IFC-Type", to the best ability.
  * Prevent the use of the IFC entity 'Building element proxy' and 'Building element part'.
  * Export the "Renovation status" or "Phasing" in the eponymous Property set; the values allowed are english: Existing / Demolish / New.
  * Preferably use the “IFC 4 Design Transfer View” export setting, however "IFC 2x3" is accepted.
  * Coordinate the local position of (all) the aspect models, close to the point of origin.

## Reading the data fields of an IFC file

If the custom property set with the name: CPset_Madaster is present on an IFC element and within this dataset, the properties below are filled in, then these values ​​of the properties are used within Madaster. Other properties are then ignored.

### Madaster Custom property set (CPset_Madaster)

| PropertyName                      | PropertyType       | Madaster Element                  |
|-----------------------------------|--------------------|-----------------------------------|
| MaterialOrProductId               | IfcText            | MadasterID                        |
| externaldatabaseId                | IfcText            | ExternalDatabaseId                |
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
| OtherUnitUnitName                 | IfcText            | OtherUnitName                     |
| OtherUnitPropertyName             | IfcText            | OtherUnitPropertyName             |
| Reuse                             | IfcReal            | InputPercentageReuse              |
| ElementInstanceCombinationId      | IfcText            |                                   |
| ElementCombinationType            | IfcText            |                                   |
| ElementName                       | IfcText            |                                   |
| ElementTypeName                   | IfcText            |                                   |
| Classification                    | IfcText            | Classification                    |
| Phase                             | IfcText            | Phase                             |
| BuildingNumbers                   | IfcText            | BuildingNumbers                   |
| DetachabilityConnectionType       | IfcText            | DetachabilityConnectionType       |
| DetachabilityConnectionTypeDetail | IfcText            | DetachabilityConnectionTypeDetail |
| DetachabilityAccessibility        | IfcText            | DetachabilityAccessibility        |
| DetachabilityIntersection         | IfcText            | DetachabilityIntersection         |
| DetachabilityProductEdge          | IfcText            | DetachabilityProductEdge          |
| LifeSpan                          | IfcInteger         | LifeSpan                          |
| InstallationDate                  | IfcText            | InstallationDate                  |
| SerialNumber                      | IfcText            | SerialNumber                      |
| TechnicalCondition                | IfcInteger         | TechnicalCondition                |
| AestheticCondition                | IfcInteger         | AestheticCondition                |
| Comment                           | IfcText            | Comment                           |
| AvailableForReuse                 | IfcReal            | InputPercentageAvailableForReuse  |
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

**Detachability**
The acceptable values for the detachability information are as follows.

| DetachabilityConnectionType    | DetachabilityConnectionTypeDetail | Explanation                      |
|--------------------------------|-----------------------------------|----------------------------------|
| DryConnection                  |                                   | Dry connection                   |
|                                | None                              | Loose (no fixing material)       |
|                                | Click                             | Click connection                 |
|                                | Velcro                            | Velcro connection                |
|                                | Magnetic                          | Magnetic connection              |
| AddedConnectionConnection      |                                   | Connection with added elements   |
|                                | BoltAndNut                        | Bolt and nut connection          |
|                                | Spring                            | Spring connection                |
|                                | Corner                            | Corner joints                    |
|                                | Screw                             | Screw joint                      |
| DirectConnection               |                                   | Direct integral connection       |
|                                | Peg                               | Peg connection                   |
|                                | Nail                              | Nailing                          |
| SoftChemicalConnection         |                                   | Soft chemical compound           |
|                                | Sealant                           | Sealant                          |
|                                | Foam                              | Foam joint (PUR)                 |
| HardChemicalConnection         |                                   | Hard chemical compound           |
|                                | Glue                              | Adhesive bonding                 |
|                                | Dump                              | Poured                           |
|                                | Weld                              | Weld joint                       |
|                                | Concrete                          | Cementitious bond                |
|                                | ChemicalAnchor                    | Chemical anchors                 |

| DetachabilityAccessibility     | Explanation                                                                |
|--------------------------------|----------------------------------------------------------------------------|
| Accessible                     | Freely accessible without additional actions                               |
| PartialNoDamage                | Accessible with additional actions that do not cause damage                |
| PartialWithRepairableDamage    | Accessible with additional operations with fully repairable damage         |
| PartialWithDamage              | Accessible with additional operations with partially repairable damage     |
| NotAccessible                  | Not accessible, irreparable damage to the product or surrounding products  |

| DetachabilityIntersection      | Explanation                                                                     |
|--------------------------------|---------------------------------------------------------------------------------|
| None                           | No intersections - modular zoning of products or elements from different layers |
| Incidental                     | Occasional intersections of products or elements from different layers          |
| Complete                       | Full integration of products or elements from different layers                  |

| DetachabilityProductEdge       | Explanation                                                            |
|--------------------------------|------------------------------------------------------------------------|
| Open                           | No obstacle to the (intermediate) removal of products or elements      |
| Overlapping                    | Partial obstruction to (intermediate) removal of products or elements  |
| Closed                         | Complete obstruction to (intermediate) removal of products or elements |

## Prepare Revit IFC source files

To ensure your file is suitable for import, it must comply with buildSmart standards. Please refer to <a href="https://ucm.buildingsmart.org/use-case-details/2594/en" target="_blank">BIM Basic IDS</a> for an extensive manual.

1. **Review Madaster’s <a href="../../../files/en/Madaster BIM - IFC guidelines.pdf">General Guidelines</a> for all IFC source files**
2. **Add building element classification in Revit:**
  * In General, it is possible to have an ifcText or ifcClassification parameter, that contains the classification code (no ifcInteger).
  * To add the classification as an Assembly Code, you must first download the file for the classification of your choice from your preferred source.
  * Go to Manage > Additional Settings > Assembly Code" and navigate to the classification file using browse and confirm with OK to load it into Revit. When you have selected an element go to "Edit Type" and click in the parameter "Assembly Code" and type the correct coding. It is also possible to select the Assembly code from a list, click on the block with "..."   and select the correct code.
3. **Add materials in Revit:**
  * It is possible to assign certain categories or families a specific material. For this go to Manage > Settings > Object Style.
  * To define the material of a type, select an instance of the type and go on "Edit Type" in the Properties Tab.
  * A library of materials is available for picking, as well as the option to add an individual material or download other material libraries.
  * It is important that the materials that are used get a clear name in which the material definition is described (concrete strength xy and z% steel, rock wool etc.).
4. **Add materials according to NLSfB as material library in Revit (NL Specific):**
  * According to the Dutch Revit Standards the NLRS2.5.2 allows you to find a complete material library in the form of a .asd cliff. This is based on NLSfB table 3 which allows you to directly export materials to IFC.
    1. Click Manage tab > settings panel > Materials
    2. Dropdown menu (bottom left) > Open Existing Library.
    3. Select the .adsklib library and open the file.
5. **Export IFC file in Revit:**
  * When exporting a model, be sure to have the right export settings:
  * In the Tab "Property Sets" check the boxes for "Export base quantities" and "Export user defined property sets", if the Madaster cPset was used.
  * In the Tab "General" select "IFC4 Design Transfer View"

## Prepare ArchiCAD IFC source files

To ensure your file is suitable for import, it must comply with IFC protocol. Please refer to <a href="https://ucm.buildingsmart.org/use-case-details/2594/en" target="_blank">BIM Basic ID</a> for an extensive manual.

1. **Review Madaster’s <a href="../../../files/en/Madaster BIM - IFC guidelines.pdf">General Guidelines</a> for all IFC source files**
2. **Add building element classification in ArchiCAD:**
  * Madaster uses a classification code to sort the elements into building layers, the standard classification method varies from country to country.
  * This notation can be added in the Category and Properties in the selection settings of an object. In this window you need to open Manage IFC properties and must activate the Apply predefined rule. In this last window you can activate the Encoding and with the degree of detail (number of digits in the code). The last step is now to indicate which coding the object has.
3. **Add materials in ArchiCAD:**
  * For an exact evaluation, all elements modelled should be equipt with a material, which is defined in ArchiCAD in the Building Materials with the option to add an individual material.
  * It is important that the materials that are used get a clear name in which the material definition is described (concrete strength xy and z% steel, rock wool etc.).
4. **Export IFC file in ArchiCAD:**
  * Under Save As you can choose to save the file as IFC. This is done in the Format: IFC file. In addition, you will need to set the correct translator to export the model in the right way. This can be set in 2 ways: manually or directly downloadable:
    1. Manually set up IFC export: when setting up manually, start creating a new Translator by clicking Create new and settings the following:
    * Under "Settings" > "IFC Scheme" set "IFC4" and "Design Transfer View"
    * The "Geometry conversion" needs to be set to "IFC4 Design Transfer View"
    * The "Data conversion" to "General translator IFC4"
    * It is important that the check mark IFC Base Quantities in the data settings is not forgotten.
    2. Import Madaster Template for IFC Export: From this <a href="../../../files/en/Madaster BIM - Archicad Translator.7z">link</a>, it is possible to a preset IFC translator, which can be imported into ArchiCad via the import button. When exporting your file, make sure the correct translator is selected.

## IFC model check

* Before uploading your IFC model to the Madaster platform, it is recommended to do a completeness check (classification coding, Base Quantities, Material etc.) For this check, use the free BIMcollab ZOOM Public Viewer in combination with the Madaster smart views.
*  BIMcollab ZOOM Public Viewer and the Madaster smart view can be downloaded for free via this <a href="https://helpcenter.bimcollab.com/portal/en/kb/articles/smart-view-sets-downloads">Link</a>. After installing the BIMCollab Zoom, you can load the programmed Madaster smart views into the BIMCollab Zoom via the Import button. This will allow IFC files to be checked for completeness for the Madaster Platform.
