---
title: Work porcesses
description: Possible working methods with elements made of different materials
ref: work-processes
type: Knowledge Base
menubar: knowledge-base-nav
---

Madaster offers a wide range of options for working with the platform, allowing every user to find their optimal workflow.

## Material compositions of elements

Below, we present various options for handling elements made of different materials. This can be taken into account during the creation of the BIM model, or the elements can be divided within the platform. Alternatively, a component or product can be created and used that reflects the ratio of the materials used.

### 1. Displaying Material Compositions in the BIM Model
      
#### 1.1 Use the Material Constituent Set

With a <a href="https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/concepts/Object_Association/Material_Association/Material_Constituent_Set/content.html" target="_blank">Material Constituent Set (IFC 4.3.2 Documentation)</a> you can assign each IfcMaterialConstituent a material and a fraction. This allows Madaster to split the element into “virtual” sub-elements per material.

#### 1.2 Use the Material Layer Set Usage

With a <a href="https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/concepts/Object_Association/Material_Association/Material_Layer_Set_Usage/content.html" target="_blank">Material Layer Set Usage (IFC 4.3.2 Documentation)</a> you can assign each IfcMaterialLayer a material and a layer thickness. This enables Madaster to calculate material ratios and split the element into “virtual” sub-elements per material.

#### 1.3 Use the Material Profile Set Usage 

With a <a href="https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/concepts/Object_Association/Material_Association/Material_Profile_Set_Usage/content.html" target="_blank">Material Profile Set Usage (IFC 4.3.2 Documentation)</a> you can assign each IfcMaterialProfile a material and a profile. This also allows Madaster to calculate material ratios and split the element into “virtual” sub-elements per material.

#### 1.4 Use the CPset_Madaster

You can add the <a href="../knowledge-base/preparing-bim-ifc-source-files.html#reading-the-data-fields-of-an-ifc-file" target="_blank">CPset_Madaster</a> to elements in your project and use the MaterialOrProductName and the MaterialOrProductRatio to enable the platform splitting an element into “virtual” sub-elements.

For more details, please refer to our **BIM Manual** in the <a href="../resources/downloads" target="_blank">Download section</a>.

#### 1.5 Model Each Material Layer Separately

With this approach, each layer receives its own unique ID (UID) and is thus treated as a single, “real” sub-element in the platform.

### 2. Split Elements in the Platform

If you need to divide an element’s materials within the platform, use the **Split** function in the enrichment section.

**How to do it:**

1. Select the checkbox in front of the element you want to split.
2. Click the Split Element button <iconify-icon inline icon='mdi-set-split'/> in the appearing toolbar at the bottom of the screen.
3. A dialog window will open, allowing you to divide the element based on its BaseQuantities.

    > <u>Note</u>: It is only possible to split individual elements, meaning if all elements of one type need to be split via the enrichment, then each element needs to be selected and split seperately.

### 3. Multi-Material Product Datasets

If the required product, which comprises several materials, is not available in the platform's databases and no suitable EPD to support the creation of that product is to be found, it is possible to create individual customized product datasets in your account database(s).

#### 3.1 Set up a Product

The first option is to create a <a href="../knowledge-base/databases-products.html" target="_blank">Product</a> with a <a href="../knowledge-base/databases-products.html#bill-of-materials-tab" target="_blank">Bill of Materials (BoM)</a>. That means circularity and environmental values of this created product will be based on the products in the BoM. 

For example, if the system databases contain the correct materials but not a product with the right combination or ratio, you can create your own.

#### 3.2 Set up a Component

<a href="../resources/release-notes#release-notes-20257" target="_blank">Components</a> works slightly differently from a product with a Bill of Materials. Material classifications, environmental, and financial data are derived solely from the Bill of Materials. When using a product in this way, the platform uses and displays the lowest level of the Bill of Materials for the calculations. 

For example, if an Ökobaudat product is included, this product will appear in the environmental screen for impact calculations.

This approach is useful for certification audits because the account database and the component itself are not displayed.

### Contrary Workflow 

Madaster supports <a href="../resources/release-notes-2024.html#support-for-element-combination-in-if" target="_blank">**element combination in IFC**</a>.

When material families are exported as separate ifc elements, you can define ifc properties that Madaster will read to recombine these elements into a parent-child structure.
Use the properties **ElementInstanceCombinationId** and **ElementCombinationType** in the CPset_Madaster, or define your own property sets and names in the Upload Preset.

When applied, Madaster creates a virtual parent element grouping all elements with the same ID under this parent. The ElementCombinationType defines the name and type of the element.