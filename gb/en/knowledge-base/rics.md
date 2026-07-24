---
title: RICS Whole Life Carbon
description: Methodologies used for in-platform calculations following RICS
ref: rics
type: Knowledge Base
menubar: knowledge-base-nav
---

The RICS Whole Life Carbon Assessment (WLCA) for the Built Environment, 2nd Edition, provides a standardised methodology for calculating and reporting carbon emissions across the full life cycle of buildings and infrastructure.

It aligns with:
* EN 15978 and EN 17472
* ICMS 3 (International Cost Management Standards)
* BECD (Built Environment Carbon Database)
* UK Net Zero Carbon Building Standard (NZCBS)

The standard became fully effective from 1 July 2024.

## How can Madaster support RICS V2 reporting?

Madaster can automatically calculate the non-decarbonised scenario for the embodied carbon (A-C, excluding B6-B8) for the building and report this in the buildings template at the technical design stage (Granularity levels 2 and 3). Within the Environmental tab users with access to the RICS WLCA feature are able to choose between the following reporting compliances: EN 15084 (A1), EN 15804 (A2) and RICS (V2).

For RICS WLCA reporting Madaster only uses EPDs that are EN 15804 A2 compliant as EPDs that follow this standard separately report biogenic sequestered carbon. It is important as a result that when connecting EPDs to your asset you select EN 15804 A2 complaint EPDs.

Madaster allows user to generate reports aligned with the RICS standard at granularity levels 2 and 3. This is linked to the RIBA Plan of Work setup within the proeject’s General tab.

Using the generate report button a user can export a RICS WLCA report that reflects the buildings RIBA Plan of Work Stage. The RIBA Plan of Work Stage can be adjusted in the buildings ‘General‘ tab. Plan of Work Stages 4 upward will produce detailed granularity report outputs.

## Setting up a Project for the RICS Feature

First of all make sure that this <a href="../knowledge-base/features.html" target="_blank">feature</a> is enabled <iconify-icon inline icon='mdi-toggle-switch'/> for your account.

In the ‘Get Started’ section, you will then learn how to <a href="../get-started/set-up-objects#create-a-new-object" target="_blank">create an object</a> on the Madaster platform. Provide as much complete and accurate information, as this will directly affect your final results.

While in **Edit <iconify-icon inline icon='mdi-pencil-outline'/>** object mode move to the **Labels tab**.

* This tab sets the compliance scheme to be used on the object/project.
* Ensure that the Compliance Scheme has been set to **RICS WLCA V2**.
* Ensure that the demolition impacts have been accurately or approximately modelled, based on the RICS v2 WLCA Guidance. A **default** value of 35 kgCO2e/m² is considered if this approach is set to *assumed average value* and is reported under A5.1 in the report and dashboard. Similarly, for A5.2 a default value of 40 kgCO2e/m2 will be modelled.
* The GIA value will always be less than or equal to the Gross Floor Area of the project.

<figure><img src="/assets/images/knowledgebase/RICS_selection.png" alt="Ensure the RICS WLCA v2 compliance scheme has been selected and all mandatory fields have been filled"><figcaption>Ensure the RICS WLCA v2 compliance scheme has been selected and all mandatory fields have been filled</figcaption></figure>

## Setting Up a specific product database 

For the purpose of conducting a RICS calculation inclusive of all assumptions and defaults (**or** overriding EPD defaults) as described by RICS, it is recommended that the user sets up a product database to be used across their projects. This ensures that product EPD values can be adjusted as necessary.  

> If this method is followed, please ensure that all assumptions and changes made have been recorded separately for RICS audit purposes.

In the ‘Get Started’ section, you will then learn how to <a href="../get-started/create-your-own-databases-with-custom-materials-and-products.html" target="_blank">create your own database with custom products</a> on the Madaster platform. More detailed information are also available in the <a href="../knowledge-base/databases" target="_blank">'Knowledge Base'</a>.

## A1–A3 Product Stage

**RICS status:** Mandatory

**Relevant RICS clauses:** Sections 5.1.1

This module includes: 
* Raw material extraction
* Manufacturing
* Transport to manufacturer

The RICS WLCA v2 guidance includes UK baseline specifications where project data is unavailable per material type. Refer to Table 16 of the RICS WLCA v2 Guidance document to model assumptions as applicable.

**Madaster implementation:** This module is implemented fully using EPD‑based data where available. This equation followed by this module is as follows: 

$$A1−A3=\sum GWP_{fossil} + GWP_{LULUC}$$

In the RICS reporting template – the sum of GWP<sub>fossil</sub> and GWP<sub>LULUC</sub> is provided based on the element classification of the products in the project.

> **<u>What the user must do manually:</u>** *Review assumptions, validate applicability and validity of the product EPD to the project, and disclose any deviations or externally calculated values in the RICS report narrative. Ensure that the EPD compliance is consistent with EN 15804 A2.*

## A1–A3s Product Stage (sequestered) 

**RICS status:** Mandatory 

**Relevant RICS clauses:** Sections 5.1.1

**Madaster implementation:** This module is implemented fully using EPD‑based data where available. This equation followed by this module is as follows: 

$$A1−A3s=\sum GWP_{biogenic}$$

> **<u>What the user must do manually:</u>** *Ensure that the EPDs used in the project are compliant with **EN 15804:A2** standard of reporting. For more information on the EN 15804 please see <a href="../knowledge-base/madaster-glossary.html#environmental" target="_blank">here</a>.*

The reason why Madaster only uses EN 15804:A2 EPDS is because the LCA KPIs (GWP, ADP etc) are broken down further as mandated by this guidance. This allows the platform to clearly differentiate between sequestered GWP (GWPbiogenice) and embodied GWP impacts. Assumptions will have to made for percentage sequestered if A1 EPDs are used. This has to be clearly declared within the assessor’s final RICS report.

## A4 Transport to Site

**RICS status:** Mandatory (Conditional)

**Relevant RICS clauses:** Sections 5.1.3

This module includes: 
* Delivery of materials 
* Transport assumptions 

Where unknown, default transport distances and vehicle types may be used. Refer Table 17, Section 5.1.3 of the RICA WLCA v2 guidance document.

**Madaster implementation:** This module is implemented partially using EPD‑based data where available. If the product EPD has an A4 value within the dataset, then this will be automatically reported against in the WLCA report. 

> **<u>What the user must do manually:</u>** *Ensure, if A4 is within the scope of assessment boundary, that A4 values have been modelled either within the product EPD used in the project **OR** <br>Collate this data and include it within the product EPD used on the project only. For this method, the user will also have to have a project specific database with all the product EPDs used in the project. <br>An A4 template worksheet is available to calculate travel distances for products (based on Table 17, Section 5.1.3, RICS WLCA v2) and can be made available upon request.*

## A5 Construction Stage 

**RICS status:** Mandatory 

**Relevant RICS clauses:** Sections 5.1.4

A5 impacts have been sub-divided into: 
* A5.1: Demolition of existing assets 
* A5.2: Construction activities 
* A5.3: Construction waste 
* A5.4: Worker transport (optional) 

With the current version of the RICS standard, it is understood that the modules A5.1 and A5.4 are optional for reporting purposes.

**Madaster implementation:** Default scenarios for A5.1–A5.3 are implemented. Material wastage rates are mapped to Madaster v2.

Demolition impacts are now reported directly (35% of A1–A3 impact × GIA), reflecting the July 2025 template update. 

> **<u>What the user must do manually:</u>** *If more accurate information is to be modelled for Module A5 at the product level, ensure that the right choice has been made in the labels tab of the project.*

<figure><img src="/assets/images/knowledgebase/RICS_demolition.png" alt="Ensure the right choice has been made on demolition impacts."><figcaption>Ensure the right choice has been made on demolition impacts.</figcaption></figure>

## B1–B4 Use Stage 

**RICS status:** Mandatory 

**Relevant RICS clauses:** Sections

|Module|Description||
|-|-|-|
|B1 |Use |Covers direct in-use emissions not captured elsewhere |
|B2 |Maintenance |Impacts from maintenance processes, including cleaning, as well as any relevant products used and waste produced over the RSP |
|B3 |Repair |Impacts of repairs including production, transportation to and from site, and installation of the repaired items |
|B4 |Replacement |Impacts from production, transportation to site and installation of the replacement items must be included |
|B5 |Refurbishment | |

**Madaster implementation:** This module is implemented fully using EPD based data where available. Default scenarios prescribed within the RICS methodology such as; *‘when data is not available 25% of the A1-A3 impacts of products must be assumed’*; have not been implemented in the feature yet. It is recommended that when required this is modelled into the dataset by the user.

Table 20 on page 21 of the RICS WLCA guide v2 has been implemented at the element level of the feature. This means that if a product EPD does not have lifespans, then the lifespan will be set to the default value prescribed in Table 20 at the based on the element for which the product is used. It is to be noted that the lifespans for only a limited number of elements from the Omniclass classification have been mapped to RICS codes.

> **<u>What the user must do manually:</u>** *Ensure that product service life has been adjusted manually according to the project requirements and user specifications. If further information on the impact of predicted use of the product is known, please include it in the appropriate Module B subcategory at the product level. This will impact the B1 - B4 modules.*

## B6–B8 Operational Use

**RICS status:** Mandatory, B8 is optional

**Relevant RICS clauses:** Sections 5.3 – 5.5 

**Madaster implementation:** This module has not been implemented within Madaster for the RICS feature.

*This feature has been planned for implementation in the future.*

## C1–C4 End of Life 

**RICS status:** Mandatory

**Relevant RICS clauses:** Sections 5.6

**Madaster implementation:** Default values for demolishing are included in A5.2 (BAU method). 

Default values as per Tables 22 & 23 are partially implemented; EPD information is modelled if available. 

For user’s own datasets - Use default EoL scenarios to input the EoL scenario per product within Madaster as per Table 22 - 23 if EPD data is missing. This can be done during enrichment on a product level.

Assuming the default values based on the Module A5.2 and Table 24 have not been implemented in Madaster. This is largely a user and client-based decision to determine the scenario based on which these defaults would apply.

> **<u>What the user must do manually:</u>** *Ensure that the EoL scenario of the products has been filled out accurately or in line with the RICS assumptions. Where necessary and if the EPD does not contain data, ensure that Tables 25 – Table 27 have been included to the product data within the project before recalculating and exporting. Please ensure that this is disclosed in a transparent manner within the final RICS report. This will impact the C1-C4 and Module D of the project.*

## Module D 

**RICS status:** Mandatory (must be reported separately within the RICS template)

**Relevant RICS clauses:** Section 5.7

**D1:** Calculations are available if EPD data contains this information; Appendix K logic is partially supported. 

**D2:** Net flows from B6–B8 are not implemented; this will be implemented when the B6-B8 component has been implemented into the feature. 

## Uncertainty and Contingency

**RICS status:** Mandatory

**Relevant RICS clauses:** Section 6.3, Tables 10–14 

**Madaster implementation:** The contingency factors as described in Section 4.10.1, Table 10 has been included in the RICS Madaster Export – a row including the same has been added to the RICS reporting template to ensure transparency communicating the different results.

<u>Future Development:</u> <br>Carbon data uncertainty factor and Quantities Uncertainty factor to be added to RIBA Stages 3-6. 

> **<u>What the user must do manually:</u>** *Ensure that the stage of the project has been set up consistently in the General tab of the project.*

## Decarbonisation

A manual Excel template is available for use if required. The results from this template must be reported separately within the RICS package – i.e. 2 individual reporting template files must be provided with appropriate naming conventions. 

Calculations based on carbon offsets (Section 4.11.6), Sequestration (part of Section 4.11.1), Carbonation (Section 4.11.2) have not been implemented within the RICS feature on Madaster yet. This will need to modeled separately by the RICS assessor and included in the final RICS report. If included, please ensure that this step has been reported separately within the final RICS report for audit. 

## Summary of Key Exceptions 

|Area |Exception |
|-|-|
|A0 |Typically, zero for building projects; reporting for this module is optional. |
|A5.4 |Reporting this module is optional. |
|B8 |Reporting this module is optional. |
|Module D |Module D is reported separately from the WLC total |
|RSP |Alternative study periods can be used but require to be justified to RICS. |
|Data Sources |Project and product specific data overrides default values, where possible |
|International Projects |Local assumptions, if known, will replace UK defaults. |

## Reporting and Audit Readiness 

Madaster reporting outputs align with the official RICS reporting templates. Known historical double counting issues were corrected as of September 2025 in line with RICS Section 6.1.4. The final outputs have now been rounded off to two or three decimal places as per the RICS clause in Section 6.1.4. 

**Relevant RICS clauses:** Sections 6.1.4

> **<u>What the user must do manually:</u>** *Ensure all unsupported modules and assumptions are transparently documented for RICS review. Ensure that the General tab has been filled out consistently and that the products included have the correct classification, scenarios etc. modelled within the project on Madaster.*

## Definitions

|Term |Definitions|
|-|-|
|Upfront Carbon |A0–A5 impacts before practical completion |
|Embodied Carbon |A–C excluding operational energy/water (B6/B7) |
|Operational Carbon |B6 and B7 |
|User Carbon |B8 |
|Whole Life Carbon |Modules A-C (incl. B6, B7) |
|Biogenic Carbon |Carbon stored/released from bio-based materials |