---
title: Calculations
description: Methodologies used for in-platform calculations
ref: calculations
type: Knowledge Base
menubar: knowledge-base-nav
---

This page documents and explains the in-platform calculations.

## Madaster Circularity Indicator (MCI)

### Introduction 

The Madaster Circularity Indicator (MCI) assigns a circularity score (0-100%) to buildings based on the properties of construction products. The Madaster Circularity Indicator is based on the Material Circularity Indicator developed by the Ellen MacArthur Foundation and was adapted for the functionality of the Madaster Platform.

The MCI assesses a building according to the origin as well as the end of life of its material:
  1. **Construction phase**: what is the percentage of secondary (recycled and reused) material utilized to construct a building.
      > Basic principle: during construction, use as many recycled and reused materials/products as possible.
  2. **End-of-life phase**: what is percentage of material utilized to construct a building that is viable for secondary use (recycling or reusing). 
      >  Basic principle: during end-of-life, capture as many materials/products for recycling and reuse as possible.

Correction factors:

  Based on the 2 values above, a Circularity Indicator (CI) is calculated.
  However, the CI does not account for the amount of missing information in the building or on chosen products. Therefore, two correction factors are applied to the CI, penalizing the percentage of building elements with an unknown mass and penalizing the percentage of known mass with no circularity information and resulting in Madaster Circularity Indicator (MCI).

MCI in practice: 
  * In practice, buildings will have CI scores ranging from 10-100%. A building that is built entirely from virgin/unsustainably produced materials, that ends up primarily as waste, is a ‘linear’ building with a low CI score of 10%.
  * A building that consists entirely of recycled/reused materials, and uses products that can also be recycled/reused in the future is a ‘circular’ building with a maximum CI score of 100%.


### Scope

The MCI score is based on the following components:
#### Construction phase (objective: 100% sustainable materials):
  1. Product mass (kg)
  1. Renewable feedstock Sustainably Produced (% of mass);
  1. Reused materials used to manufacture a product (% of mass);
  1. Recycled materials used to manufacture a product (% of mass);
  1. Efficiency of the recycling process resulting in the recycled materials (%).

#### End-of-life phase (objective: 100% of reusable materials):
  1. Components suitable for reuse (% of mass);
  1. Materials suitable for recycling (% of mass);
  1. Efficiency of end-of-life recycling process (%).


### Measurement Method
  The MCI is based on the ‘Material Circularity Indicator’ of the Ellen MacArthur Foundation (EMF), which is open-source and can be found on the website of the Ellen MacArthur Foundation. This calculation method enables users to compare products and buildings through by comparing the various components and to easily assign circularity ambitions and objectives.

  The ‘Material Circularity Indicator’ uses an extra component based on usage in the Utility factor: 

$$
F(X) = \frac{0.9}{X} \quad \text{where} \quad X = \frac{L}{L_{av}}
$$


  |||
  |-|-|
  | $L$ |Potential functional lifecycle of the product (years)|
  | $L_{av}$	|Industry-average functional lifecycle of the product (years)|

  > No data is available for $L_{av}$ . In previous versions of the MCI, Madaster used the average lifespan of the layer the product instead, but this approach was not giving satisfactory results and has been abandonned. 
  
  > The current version of the MCI only uses $F(X)=0.9$ 


#### Weighting on Mass

The MCI score of a building is made up of the MCI score of the different building layers (Brand, 1994), which are made up of the MCI scores of the products in the respective building layer. The mass of a product, in relation to the mass of the entire building is the factor for the MCI of each product and defines how heavy it influences the entire building MCI.

### Calculating the Madaster Circularity Indicator (MCI)
#### Construction Phase Circularity Indicator
To calculate the Circularity Indicator for the construction phase, the material origin must be known. This information can be input by refering to <a href="../knowledge-base/databases#existing-databases" target="_blank">an existing databases</a> within the Madaster Platform, or by <a href="../knowledge-base/databases#database-at-different-levels-account--folder--building" target="_blank">creating a custom product</a>.
* The formula for the Construction Phase Circularity Indicator is: 

$$
CI_{Constructie} = F_{R} + F_{RS} + F_{U}
$$

  |||
  |-|-|
  | $F_R$ | Fraction of recycled materials (as a % of the product mass);
  |$F_{RS}$ | Fraction of renewable materials sustainably produced (as a % of the product mass);|
  | $F_U$ | Fraction of reused products and/or components (as a % of the product mass).|
  
$$
F_{R} = M_{R} * E_{F}
$$

  |||
  |-|-|
  |$M_{R}$|  The mass of recycled material input (kg);
  |$E_{F}$| The efficiency of the recycling process preceding the construction phase (%); This applies to the recycling process preceding the production of the product. E.g., it is possible that it takes two discarded floor tiles to manufacture one new floor tile that completely consists of recycled materials (a 50% efficiency).
 
    
#### End-of-Life Phase Circularity Indicator
To calculate the Circularity Indicator for the end-of-life phase, the user must be able to provide insight into what will happen at the end of each products lifespan. This information can be input by refering to <a href="../knowledge-base/databases#existing-databases" target="_blank">an existing databases</a> within the Madaster Platform, or by <a href="https://docs.madaster.com/nl/en/knowledge-base/databases#database-at-different-levels-account--folder--building" target="_blank">creating a custom product</a>. 

The calculation distinguishes recycling, reuse, landfill and incineration. 

The efficiency of the recycling process, i.e., the additional waste generated by this process is also taken into account.
* The formula for the End-of-Life Phase Circularity Indicator is:
  
$$
CI_{End-of-Life} = C_{R} * E_{C} + C_{U}
$$

  |||
  |-|-|
  |$C_{R}$| Fraction of materials that can be potentially recycled at the end of its useful life (as a % of the product mass)|
  |$E_{C}$ | Efficiency of the recycling process in the end-of-life phase (%);|
  |$C_{U}$ | Fraction of components and/or products that can be potentially reused at the end of its useful life (as a % of the product mass)|

  > The fraction of components and/or products to be reused must fulfil several conditions (Design for Disassembly). These conditions must be met, because the reuse of components and/or products is only possible when these can be successfully extracted from a building. The conditions which are to be fulfilled at product level are:
    >1. The connection type is easily detachable.
    >1. The connection is accessible without doing irreparable damage.
    >1. The intersections are not fully integrated by different layers.
    >1. The product is not fully closed off, a complete obstruction of removal.

#### Circularity Indicator (CI)
The Circularity Indicator (CI) is calculated taking into account the material flows and the utility factor. To calculate the CI, the following formula is used:

$$
CI = 1 - LFI * F(X)
$$

|||
|-|-|
| $LFI$ | Linear Flow Index (LFI)

>The Linear Flow Index (LFI) is used to calculate the linear part of the material flow, starting with 100% of unsustainable materials, with 100% ending up in an incinerator or on landfill. The LFI has a range from 0 (completely circular) to 1 (completely linear).|

The formula for the LFI is as follows:
  
$$
LFI = \frac{V + W}{2M + \frac{(WF - WC)}{2}}
$$
    
Where:
    
$$
V = M * (1 - F_{R} - F_{RS} - F_{U})
$$

|||
|-|-|
| $V$ | Mass of unsustainable material used in manufacturing a product (kg)|
| $M$ | Product mass (kg)|
| $F_R$ | Fraction of recycled materials (as a % of the product mass)|
| $F_{RS}$ | Fraction of Renewable materials Sustainably Produced (as a % of the product mass)|
| $F_U$ | Fraction of reused products and/or components (as a % of the product mass)|

$$
W = W_{0} + \frac{(W_{F} + W_{C})}{2}
$$

|||
|-|-|
|$W$ | Mass of waste (kg)|
|$W_0$ | Mass of waste (kg) that ends up on landfill or incinerators after the useful life of a product.|
| $W_F$ | Mass of waste (kg) generated by the recycling process that provides the materials used to manufacture a product.|
| $W_C$ | Mass of waste (kg) generated by the recycling process after the useful life of the product.|

$$
W_{0} = M * (1 - C_{R} - C_{U})
$$

|||
|-|-|
| $C_R$ | Fraction of materials with a waste recycling scenario (as a % of the product mass);|
| $C_U$ | Fraction of materials with a waste reuse scenario (as a % of the product mass);|

$$
W_{C} = M * (1 - E_{C}) * C_{R}
$$

|||
|-|-|
| $E_F$ | Efficiency of the recycling process (%) supplying the materials to manufacture a product. The default value of 75% can be changed manually, since the required data is often not available|

$$
W_{C} = M * (1 - E_{C}) * C_{R}
$$

|||
|-|-|
|$E_C$ | Efficiency of the recycling process (%) for a product with a waste recycling scenario. The default value of 75% can be changed manually, since the required data is not available.|


## Detachability

The Detachability Index at the building level is calculated according to a methodology described by the <a href="https://www.dgbc.nl/upload/files/Publicaties/circulariteit/DGBC%20Disassembly%20Potential%20Measurement%20Methodology%20_%202022.pdf" target="_blank">Dutch Green Building Council (DGBC)</a>. Within Madaster, the calculation is made on all elements linked to products. Detachability information can be defined for a product in the database, if its installation is constantly the same, however the detachability information can still be overwritten in the Enrichment Tab for individual elements.


In short, the Detachability Index assesses building components based on the following criteria and scoring:

#### Connection type

||
|-|
|Dry connection|
|Connection with added elements|
|Direct integral connection|
|Soft chemical compound|
|Hard chemical compound|

#### Accessibility of the connection

| |
|-|
| Freely accessible without additional actions |
| Accessible with additional actions that do not cause damage |
| Accessible with additional operations with fully repairable damage |
| Accessible with additional operations with partially repairable damage |
| Not accessible - irreparable damage to the product or surrounding products |

#### Intersections

| |
|-|
| No intersections - modular zoning of products or elements from different layers |
| Occasional intersections of products or elements from different layers |
| Full integration of products or elements from different layers |

#### Product edges inclusion

| |
|-|
| Open, no obstacle to the (intermediate) removal of products or elements |
| Overlap, partial obstruction to (intermediate) removal of products or elements |
| Closed, complete obstruction to (intermediate) removal of products or elements |

## Environmental

The environmental impact of a building is calculated using the Life Cycle Assessment (LCA) methodology EN 15978:2011 (Sustainability of construction works). With the exception of water use, a full LCA can be calculated on Madaster.
The environmental indicators for phases A1-A3 & A4-A4 & B1-B5 & C1-C4 & D are calculated according to the product EPD's of the building elements while the environmental indicators CO2 eqv. emissions and energetic use for phases B6 are calculated based on the amount and EPD of the products entered in the Primary energy Demand fields of the building.

#### A1-A3p and A1-A3s
The A1-A3 phase is sometimes split up into A1-A3p (produced) and A1-A3s (sequestered).

A1-A3p is the usual environmental impact during production, while A1-A3s portays the environmental impact due to removal of carbon dioxide from the atmosphere via photosynthesis during production (e.g. for timber).

#### B4

B4 is the replacement module in the use stage of the LCA. It is calculated slightly different in the Netherlands than it is elsewhere.

* All countries except NL and DE. For each product:

$$
LCA_{iB_4} = (Round(\frac{L_{building}}{L_{product}}) - 1) * (LCA_{i[A]}  LCA_{i[B_1-B_3]} + LCA_{i[C]})
$$

|||
|-|-|
|Round|Round down to the nearest whole value|
|$L_{building}$|Lifespan of the building|
|$L_{product}$|Lifespan of the product|
|$LCA_{i[phase]}$|Value of the environmental indicator i for the phase(s) for the product|

* For the Netherlands:

$$
LCA_{iB_4} = (\frac{L_{building}}{L_{product}} - 1) * (LCA_{i[A-D]}))
$$

|||
|-|-|
|$L_{building}$|Lifespan of the building|
|$L_{product}$|Lifespan of the product|
|$LCA_{i[phase]}$|Value of the environmental indicator for the phase for the product|

* For Germany:

$$
LCA_{iB_4} = (Round(\frac{L_{building-average}}{L_{product}}) - 1) * (LCA_{i[A]} + LCA_{i[B_1-B_3]} + LCA_{i[C]})
$$

|||
|-|-|
|Round|Round down to the nearest whole value|
|$L_{building- average}$|Lifespan of the building-average = 50|
|$L_{product}$|Lifespan of the product|
|$LCA_{i[phase]}$|Value of the environmental indicator i for the phase(s) for the product|

## Financial

The financial module shows what the residual value of a building is expressed in terms of material value. This is expressed in either:

* Current value; this is today’s value taking into account a number of correction factors.
* Net present value (NPV). NPV is today’s value calculated back from the end of life of the layer of Brand for the materials in each layer, taking into account a number of correction factors, discount rate and the material value trend.

The Current value for a project is calculated by the sum of respective current values of its products. If a product is defined through a bill of materials, then the refered products will be listed in the financial calculation.
Current value a product:


$$CNV= TV - FC_1 - FC_2 - FC_3$$

| Abbreviation | Description |
|--------------|-------------|
| $CNV$ | The Current Value aka. Corrected nominal value |
| $TV$ | Trend Value |
| $FC_1$ | Correction Factor 1: Demolition costs |
| $FC_2$ | Correction Factor 2: Transport costs, can be found in the products Financial Tab |
| $FC_3$ | Correction Factor 3: Handling feedstock, can be found in the products Financial Tab |

#### Trend Value

The Trend Value (TV) can be found in the timeline, for the current month.
It is a linear graph, that is calculated through a regression analysis (method of least squares) from the Historic Price Development (HPD).
 **HPD** The Historic Price Development (HPD) is the development of the Priceset Value (PV)

$$PV=M*LKV$$

| Abbreviation | Description |
|--------------|-------------|
| $PV$ | The Priceset Value [€] |
| $LKV$ | Last Known Value [€/kg] |
| $M$ | Mass/Quantity of Product [kg] |

$$LKV=NV*IR*CT$$

| Abbreviation | Description |
|--------------|-------------|
| $LKV$ | Last Known Value (building level) aka. Real Value (product level) [€/kg]. It can only be calculated with the published Inflation Rate, if this is not published for a month then the LKV will be from the previous month. |
| $NV$ | Nominal Value of product [UnitOfCurrency/UnitOfQuantity], it is calculated as noted under "Dataset" in the Financial Tab of each product. There are three methods of calculating the NV: <br> - A base price from a specific date, combined with the price index of the commodity <br> - The daily exchange rate of a commodity <br> - A combination of NV from other products (usually when product is a composite) |
| $IR$ | Inflation Rate [%] |
| $CT$ | Currency Translation [%] |

#### Correction Factor 1: Demolition Costs

$$
FC_{1-p} = DC_{building} * \frac{M_p}{M_{building}}
$$

| Abbreviation | Description |
|--------------|-------------|
| $FC_{1-p}$ | The demolition costs of the product [€] |
| $DC_{building}$ | Demolition cost of the entire building [€] |
| $M_{p}$ | Mass of the product [kg] |
| $M_{building}$ | Mass of building, can be found in the building Mass Tab [kg] |


$$DC_{building}=GSA*DC_{building-usage}$$

| Abbreviation | Description |
|--------------|-------------|
| $DC_{building}$ | Demolition Cost Building [€] |
| $GSA$ | Gross Surface Area, can be found in building General Tab [m<sup>2</sup>] |
| $DC_{building-usage}$ | Demolition Cost of Usage [€/m<sup>2</sup>], can be found in building General Tab > Edit building > Madaster information section |

$$FC1=\sum_{p} FC_{1-p}$$

#### Correction Factor 2: Transport Correction Factor

$$FC_{2-p} = TC*(1+IR)$$

| Abbreviation | Description |
|--------------|-------------|
| $FC_{2-p}$ | Transport cost Product [€/kg] |
| TC | Transport cost per kg, (originally calculated on price sets as a Distance To Processor * average transport cost per kg/km) are defined on the financial tab of products, and defaulted on priceset|
| IR | Inflation rate [%] |

$$FC_2=\sum_{p} FC_{2-p}*M_p$$

| Abbreviation | Description |
|--------------|-------------|
| $M_p$ | Mass of product in the building |


$$FC_{3-p}=H_p(1+IR)$$

| Abbreviation | Description |
|--------------|-------------|
| $FC_{3-p}$ | Handling costs [€] for processing and machining a product |
| $H_p$ | Handling costs per kg, are defined on the financial tab of products, and defaulted on priceset |

$$FC_3=\sum_{p} FC_{3-p}*M_p$$

| Abbreviation | Description |
|--------------|-------------|
| $M_p$ | Mass of product in the building |


## Benchmarking

### Object Level:

The building and its shearing layers can be compared to all buildings in the account or folder and filtered by specific building types. The benchmark is against all buildings within the benchmark settings, including buildings for which a user does not have read-rights. The benchmarks are described below: 

#### Material density (Mass/m<sup>2</sup>); 
The building benchmark is established as a weights average of the material density of the buildings in te selection: 

$$B=\frac{\sum_{b}M_b}{\sum_{b}GSA_b}$$

| Abbreviation | Description |
|--------------|-------------|
|$B$|Benchmark Value|
| $M_b$ | Mass of the building |
| $GSA_b$ | Gross Surface Area of building b |
|$\sum_{b}$|SUM for all buildings in selection|

#### Circularity; 
The building benchmark is established by calculating a weighted average of the Circularity Indicators: 

$$B_t=\frac{\sum_{b}M_b*MCI_b}{\sum_{b}M_b}$$

| Abbreviation | Description |
|--------------|-------------|
|$B_t$|Benchmark Value|
|$M_b$| Mass of the building |
|$MCI_b$| Madaster Circularity Indicator of the building |
|$\sum_{b}$|SUM for all buildings in selection|

$$B_l=\frac{\sum_{b}M_{bl}*MCI_{bl}}{\sum_{b}M_{bl}}$$

| Abbreviation | Description |
|--------------|-------------|
|$B_t$|Benchmark Value Per Layer|
| $M_{bl}$ | Mass of the building layer |
|$MCI_b$| Madaster Circularity Indicator of the building layer |
|$\sum_{b}$|SUM for all buildings in selection|

#### Detachability:  
The building benchmark is established by by calculating a weighted average of the Dectachability Index: 

$$B_t=\frac{\sum_{b}M_b*DI_b}{\sum_{b}M_b}$$

| Abbreviation | Description |
|--------------|-------------|
|$B_t$|Benchmark Value|
|$M_b$| Mass of the building |
|$DI_b$| Detachability Index of the building |
|$\sum_{b}$|SUM for all buildings in selection|

$$B_l=\frac{\sum_{b}M_{bl}*DI_{bl}}{\sum_{b}M_{bl}}$$

| Abbreviation | Description |
|--------------|-------------|
|$B_t$|Benchmark Value Per Layer|
| $M_{bl}$ | Mass of the building layer |
|$DI_{bl}$| Detachabilty Index of the building layer |
|$\sum_{b}$|SUM for all buildings in selection|


#### Environmental KPI's:  
The building benchmark is established as a weighted average of the environmental KPI's:

$$B_{ip-t}=\frac{\sum_{b}LCA_{ip-b}}{\sum_{b}GSA_b}$$

| Abbreviation | Description |
|--------------|-------------|
|$B_{ip-t}$|Benchmark for Indicator i in phases p  total|
| $LCA_{ip-b}$ | LCA value for indicator i in phases p of the building|
|$\sum_{b}$|SUM for all buildings in selection|


### Material Value/m<sup>2</sup>; 
The material value benchmark is established as a weighted average of the material values of the buildings in te selection: 

$$B=\frac{\sum_{b}CV_b}{\sum_{b}GSA_b}$$

| Abbreviation | Description |
|--------------|-------------|
|$B$|Benchmark Value|
| $CV_b$ | Current Value of the building |
| $GSA_b$ | Gross Surface Area of building b |
|$\sum_{b}$|SUM for all buildings in selection|