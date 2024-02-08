---
title: Set up objects
description: Create new objects, prepare and upload source files, and select classification methods
ref: set-up-objects
type: Get Started
menubar: get-started-nav
---

Create new objects, prepare and upload source files, and select classification methods

## Create a new object

1. From the folder-level under the **General** tab, select **New Object**, then select one of the options in the dropdown menu, for example: **Building** or **Urban Mining Screener**.
   > Note: If this button is not visible, a folder of the right type must first be created. The default settings for Region, Municipality, Area, Company, and Subsidiary **Folder Types** prohibit adding buildings directly within them. Review and edit your **Folder types and folder structure** if necessary.
1. After creating a new object, click on **Edit building** and add building information, including **Address**, **Usage**, **Gross surface Area**, **Building Phase**, **Delivery Date**, **Cadaster Information** on the main tab.
1. On the extra tabs in the toolbar, you can insert other useful information about **Labels**, **Energy**, **Building images** and **Lifespan**. 

![Toolbar](/assets/images/gettingstarted/editbuilding.png)

4. Click **Save**. 

## Prepare source files

To generate a Material Passport, a source file must first be uploaded into Madaster. The completeness and accuracy of a Material Passport is determined by the availability and quality of information within a source file. Madaster uses BIM/IFC models or a Madaster Excel template. The elements in these two types of source files should, as far as possible, include: geometric properties, a material description, and a classification coding.

1. Determine the desired <a href="../get-started/object-insights-and-performance" target="_blank">Performance Insights</a> for your portfolio. In general, Madaster provides the following high-level insights:
   * <a href="../get-started/object-insights-and-performance#mass-insights" target="_blank">Mass</a> – of materials/products stored in the object(s).
   * <a href="../get-started/object-insights-and-performance#circularity-insights" target="_blank">Circularity</a> – the degree of secondary materials used during construction, their utility, and their potential for reuse/recycling at end of use.
   * <a href="../get-started/object-insights-and-performance#circularity-insights" target="_blank">Detachability</a> – the degree to which products can be disassembled without damage.
   * <a href="../get-started/object-insights-and-performance#environmental-insights" target="_blank">Environmental</a> – impact during various stages the object’s lifecycle.
   * <a href="../get-started/object-insights-and-performance#financial-insights" target="_blank">Financial (residual) value</a> – the future monetary value of materials at their end of life, accounting for the cost of disassembly, transportation, and processing for resale.
1. Determine the type of source file(s) that will be prepared:
   * For new construction and renovation objects, more and more information is recorded in BIM models. This form of recording offers the most advantages regarding the successful and accurate preparation of a Material Passport in the Madaster Platform. The Madaster Platform primarily uses IFC files (IFC4 or IFC2x3) of the objects to provide insight into the quantities of materials used.
   * For existing objects, drawings and specifications are typically available. These can be translated (by building industry professionals when necessary) into BIM models or, alternatively, processed in the Madaster Excel template to prepare a Material Passport in the Madaster Platform. Please note, when Excel is used as a source file, a 3D representation of the object cannot be generated on the Madaster platform.

1. Prepare the source file(s):
   * Prepare a <a href="../knowledge-base/preparing-bim-ifc-source-files" target="_blank">BIM IFC Source File</a>
   * Or, prepare an <a href="../knowledge-base/preparing-excel-source-files" target="_blank">Excel Source File</a>

## Upload Source Files into Madaster

* From the object-level **General** or **Dossier** tab, select **Upload**.
  1. Select **File Type** and click **Select file(s)**.
  1. Select **Classification method** or select **Upload Preset** (if available).
  1. Select **Languages for enrichment**. 
  1. Select database(s) from the **Available verified databases** or other **Available databases** to mark them as the **Selected sources** for enrichment. Click **Save**.
     > Note: The order of the selected datasources is also the priority used in the matching process.

>  Note: Multiple source files can be uploaded in Madaster per object. For example, architectural, installations/HVAC, construction, and interior models.  
  
## Managing uploaded source files in Madaster
![FileOptions](/assets/images/gettingstarted/fileoptions.png)

1. From the object-level Dossier tab, switch the radio button to make sure that the uploaded source file is Active.
1. When a source file is outdated, a newer source file can be uploaded without losing the linked elements. From the Dossier tab, click the icon <iconify-icon inline icon='mdi-upload-lock'/> on the right side of the Active radio button.


## Manage your objects 

There are many built-in functionalities to create presets for upload, organize and split your objects, archive or transfer them and explore different design alternatives. Click <a href="../knowledge-base/stay-organized" target="_blank">here</a> to read more of how to keep your objects organized.

<a class="next-button" href="../get-started/enrich-objects-with-material-and-product-databases">Next step: Enrich Objects</a>