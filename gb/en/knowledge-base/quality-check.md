---
title: Quality Control and Quality Management
description: Finale check on completed projects
ref: quality-check
type: Knowledge Base
menubar: knowledge-base-nav
---

Recommendations regarding the finale check on completed projects.

## Basic consideration

First, always check the “Unknown” card, which is displayed in all evaluation tabs (Mass, Circularity, Environment, Financial), as it provides information on how many elements
1. are not linked
2. have no classification
3. have insufficient geometric information

The elements affected are displayed after clicking on the respective number. More detailed information on the elements shown can be obtained by clicking on the pieces <iconify-icon inline icon='mdi-eye-outline'/> next to the element.

It is recommended to aim for a zero value in each case. Excluded elements <iconify-icon inline icon='mdi-eye-outline-off'/> are not included in the count.

## Verification of Automated Product Linking <br>(Validation of Results)

How can you verify that elements have been correctly linked to product datasets through the automatic mapping? The following explains what to pay attention to in general and which verification methods are recommended, depending on the desired level of detail.

### Preliminary Considerations

1. **Have all material specifications been read from the source file?**<br>
Click on the relevant source file in the dossier of the object. Under “Quality of the source file”, you will see a percentage under “Material assignment” indicating for how many elements a material specification was found.

    > <u>Note</u>: Materials should be recorded for all elements in the same attribute. According to buildingSMART guidelines, it is recommended to use the “ifcmaterial” attribute. Alternatively, the attribute can be set via the “Presets for upload”. Multiple attributes are not read or combined.

2. **Which elements are missing the material information?**<br>
Go to “Enrich” (Manual) and sort by the “Material / Product” column.

3. **Which elements are not linked to a product dataset?**<br>
Go to “Enrich” (Manual) and use the filter “Element status” (not linked) to see where the “Product / material” column is empty.

    > <u>Note</u>: For details on elements with multiple materials or sub-elements, see <a href="../knowledge-base/work-processes.html#material-compositions-of-elements" target="_blank">Work processes</a> or in the **BIM Manual** in the <a href="../resources/downloads" target="_blank">Download section</a>.

    > <u>Note</u>: If you prefer to work with a **Bill of Quantities** in Excel format, you can generate one by clicking in the dossier on the relevant source file and selecting “File export <iconify-icon inline icon='mdi-file-download-outline'/>”.

### Verification Level 1 – Visual Inspection

**Objective:** The masses must be correctly linked for the most part. <br>
It is not about finding the 1 incorrectly linked element among 40,000.

Does the percentage distribution in the matrix of the mass tab across building layers/classifications and material families seem reasonable and corresponding to the construction method (e.g. timber or solid construction)?

> <u>Note</u>: If elements are not modelled as hollow but are linked to a volume product, this can lead to discrepancies  (e.g. in window frames or elements of the technical installations).

For more details, click on the pie charts in the matrix and then on the displayed pieces <iconify-icon inline icon='mdi-eye-outline'/> of the elements, or use the “Filter <iconify-icon inline icon='mdi-filter-outline'/>” for materials/products or the display options in the dropdown for classifications, building layers or material families.

### Verification Level 2 – Detailed Inspection

**Objective:** Detailed inspection of each linked element. <br>
Absolute certainty requires a detailed manual review of all element links.

Use the filter options mentioned above in the mass tab or in “Enrich” (Manual) to filter by products and check the linked elements individually. Further filters such as ifc classes can be combined in “Enrich” (Manual).

> <u>Note</u>: For models with many sub-elements or if you prefer working with a **Bill of Quantities** in Excel format, you can generate one by clicking on the relevant source file and using “File export <iconify-icon inline icon='mdi-file-download-outline'/>” and then use column sorting or column filters.

## Analysis of Products with the Greatest Negative Impacts

Define negative impacts according to the project’s objectives.

### Environmental Impact Factors (e.g. CO₂ savings)

In the environment tab, you can search for the relevant KPIs using the dropdowns “Compliance (Environmental product declaration)”, then “Select key performance indicator (KPI)”, and finally the selection of lifecycle phases.

In the last dropdown under the KPI cards, select “Material/Product” – the materials/products will be listed according to the magnitude of their impacts.

> <u>Note</u>: With the “3D Insights” feature, you can also track these findings via corresponding colour coding of elements in the 3D model (requires an ifc source file).

> *Internal note: Does not apply to sub-elements due to modelled layers. [Azure Board](https://dev.azure.com/Madaster/Madaster/_boards/board/t/Madaster%20Team/Backlog%20items?text=3d&workitem=12688)*

### Circularity (e.g. recyclability and dismantlability)

In the circularity tab, you can display all linked products under the KPI cards in the “Material/Product” dropdown. The sorting criterion can be set via the second dropdown.

> <u>Note</u>: With the “3D Insights” feature, you can also track these findings via corresponding colour coding of elements in the 3D model (requires an ifc source file).

Further information on circularity calculation can be found by clicking the green arrow next to the KPI. If information on disassembly has been added to the elements, you can also find more details by clicking the arrow next to this KPI.

### Material Masses

In the mass tab, you can see where and due to which products the project is most material-intensive. You can switch between the matrix based on building layers and the matrix based on classification. For more details, click on the pie charts in the matrix and the displayed pieces <iconify-icon inline icon='mdi-eye-outline'/> of the elements. In the button bar, there is also a “Filter <iconify-icon inline icon='mdi-filter-outline'/>” for targeted product searches.

More detailed explanations on sufficiency and durable products will follow.