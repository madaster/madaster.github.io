---
title: Environmental
ref: building-environmental
type: Platform Pages
menubar: platform-pages-nav
---

## What information is shown here?

The total environmental impact of the selected Environmental KPI in the selected LCA phase and the environmental impact per m2 (or per m2.year) are displayed. 

When a benchmark is selected, and information is available, the building is compared to others. 

Unknown elements are shown to so they can be modified, and in turn included in calculations. Using the dropdowns, environmental impact indicators can be displayed by total, shearing layer, and material/product.

### Environmental Impact Indicator
The environmental Impact Indicator is displayed along a building’s lifespan, which consists of the stages described below. Since A1-A3 data is most commonly accessible, it is used to establish comparisons across shearing layers and different buildings.

The building’s life cycle is divided into the following stages:

__*A1-A3 Manufacturing of Materials and Products*__ : includes the raw material supply, transport, and manufacturing of building materials and products.

__*A4-A5 Construction of the Building*__: includes the transport to the construction site, and the assembly of materials and products into a completed building.

__*B1-B5 Maintenance, Repair and Replacement*__: includes the use, maintenance, repair, replacement, and refurbishment of materials and products within the building.

__*C1-C4 End of Life Processing*__: includes the deconstruction of a building, and the transport, waste processing, and disposal of its materials and products.

__*D Benefits and Loads beyond the System Boundary*__: includes the reuse and recycling potential of the building's materials and products. It is not guaranteed that reuse or recycling will occur in the future, thus stage D is an assumption and not included in full-building calculations.

### Environmental Impact Indicator for renovation

Madaster shows the environmental impacts of a renovation according to the *LCA standard EN 15978*.

To be able to use this functionality

1. The building has to be set as a **renovation** project in the *General* tab.
2. The building has also to be given a **delivery date** and a **last renovation date**.
3. The elements of the building need to be given information about the **phase** they belong to (preserved, demolished or new).

Preserved elements represent the ones which are kept in the building, demolished elements are those which are removed from it, and new elements are those added during the renovation project. The phase can either be set in the source file of the building or in the platform via the enrichment or via the excel file import. *(For further information on the phases please refer to chapter CPset of the BIM manual or the spreadsheet Quickstart of the upload excel template.)*

The results of the calculation of the impact will be shown in the *Environmental* tab in the "**Total**" dashboard, presenting the different proportions in the diagram using different patterns for each phase. It also provides the possibility to toggle the phases via the legend. That way, it is possible, for example, to single out only the impacts of the newly added materials in the renovation project. 

The impacts will be split into:
- **Current**: Impacts of demolished and preserved elements until last renovation date
- **Preserved**: Impacts of preserved elements after renovation date (until the end of the given lifespan of the building)
- **Demolition**: Impacts of demolished elements after renovation date
- **New**: Impact of the new materials brought in during renovation and specified construction waste

### Environmental Impact Indicator By Shearing Layer
The environmental impact indicator is shown by building layer across all life cycle stages.

### Environmental Impact Indicator By Classification
The environmental impact indicator is shown by used top level classificationmethod across all life cycle stages.

### Environmental Impact Indicator By Material/Product
The environmental impact indicator is shown by material/product across all life cycle stages. The chart displayed can sorted in to view materials with the largest contribution to each life cycle stage. When shown in 3D, the materials/products are color-coded based on their contribution to the environmental impact indicator. Materials with the largest environmental impact are shown in red, while materials with 0, or even regenerative, impacts are shown in green.

### Unknown Elements
Unknown elements are those that were not taken into account during calculations. These can occur for 3 different reasons:

__*Elements Unlinked*__ : these elements are not linked to material/product database, and thus cannot be reported on.

__*Elements with Unknown Layer*__: these elements are missing construction classification information, and thus cannot be assigned to a shearing layer.

__*Elements with Insufficient Geometry*__: these elements are lacking sufficient geometry, and thus cannot be used for calculations.