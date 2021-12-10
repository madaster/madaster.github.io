---
title: Enrich
ref: building-file-enrich
---

## What information is shown here?
The process of matching, of (IFC) element with a product or a material, is carried out automatically by Madaster after importing and dissecting the source file. It is possible that elements have not been matched, or that a wrong matching has taken place on the basis of the search criteria. In the LITTING screen the matching process can be checked and completed, the so-called "enriching" of the process.

**Take notice** : Madaster strongly advises to make sure, before importing a source file, that the information in the source file matches well with the information in the selected databases/sources. This can be done by using the material name in the Madaster database (see [link to Madaster List of Materials] ) or by ensuring that the name in the source files matches the (own) selected database/source.


### LEFT MARGIN
On the left side is a search and filter function available. The filter categories can be unfolded to make a selection:

- Status element: filter on linked/unlinked elements. Especially for the enrichment of unlinked elements the most important filter;
- Calculation element: filter on included / excluded elements;
- IFC type: filter on available IFC types;
- Construction phase: filter on existing construction phase (existing / demolition / hull / new / final;
- Building layers: filter on existing shearing layer.;
- Floors: filter on existing storey;
- Classification methods: filter on available classification code;
- Unit dimension: filter on dimension unit: volume / surface / length.


### MAIN SCREEN
The main screen shows the list of all elements contained in the source file. The columns display the information:
- Element: element name from the source file;
- Materials: material name(s) from the source file;
- Product/material: the product/material to which the element is linked;
- Number: the number of elements of this type/name;
- Icon: link.

By selecting one or more elements, a dialog block appears, with which the elements can be linked / unlinked, or included / excluded. Including or excluding an element will result in this element being included/not included in the calculations. This can be used, for example, for the mass of the surrounding terrain if it is included in the source file. Or if there are duplications.


### 3D VIEWER
At the top of the window, in the blue bar, there is a button to activate a 3D viewer. This is only possible if the source file is an IFC model:
- Show 3D model: the 3D viewer opens and shows the total model;
- Show selection in 3D model: the 3D viewer opens and shows the selected element(s).

If an element is selected in the 3D view, a dialog block appears, with which the elements can be headed/disconnected, or embedded/excluded. At this time, the element in question is not yet selected in the list.
