---
title: Features
description: Features can be toggled on and off
ref: features
type: Knowledge Base
menubar: knowledge-base-nav
---

Features can be toggled on and off in the account-level **Features** settings. Features are occasionally accessed by invitation only or as a paid feature, so please contact your local Madaster service if you are interested.

We divide our features between "normal" features and "preview" features. The difference being that preview features are still in development, so might not stays the way you can use them or maybe even cancelled at some point. In the case of these preview features we ask you to give as feedback if anything is not functioning the way you think it should work or if anything is missing or wrong. 

# Features (non-preview)

## 3D Insights (paid feature)
Not to be confused with our **3D** Tab, which visualizes the IFC-File uploaded in the building folder, the **3D Insights** is a paid feature that can be toggled on for every account.
This feature allows a 3D visual analysis of which products in the IFC-file have the largest influence on your building's environmental impact and circularity score. 
Once switched on, a *View in 3D* button will appear in the **Circularity**/ **Environmental** Tab in the dropdown option "Material/Product". This button opens the 3D View of the building, where elements are colour coded dark green (good) to dark red (bad), signalizing what their impact on the respective category is.

## API Write Actions (paid feature)
When enabled, this feature makes it possible to interact with the Madaster platform through code or other applications using the API-endpoints provided. An API-token needs to be generated so your application of choice can identify as a user with specific rights and roles. Then there are all kinds of actions that can be performed via this API. Think of actions like: 
- **POST** a new building to the account 
- **GET** all data of a building within the account 
- **POST** the scheduling of a new recalculation process for a building
- **DELETE** (the image of) a building
- **POST** a new building file
- **GET** a specific building file element by it's Id
- **POST** a new folder in the account
- **GET** all available databases
- **POST** a new commodity to a database
and many more options...

For more information about API for Madaster, check out the specific API help-pages [here](../api/index.md)

## ESG Tab
The **ESG** (Environmental, Social & Governance) tab can be enabled for an account (and its underlying objects). After this feature is enabled the extra tab will be available in the top menu on all levels within the account. On this tab you can run and view reporting. Reports available now, if enabled as features, are: EU Taxonomy, CRREM and Level(s).

## CRREM (paid feature)
The CRREM (Carbon Rist Real Estate Monitor) Tool was developed to calculate the carbon emissions of a building during its operation.
On Madaster it is a paid feature, that can be toggled on for every account.

On building level, in the **ESG** Tab, a method of reporting (in this case: **CRREM**) can be chosen.
In the button **Show settings** the user needs to **Input** the data for the building characteristics, energy procurement, fugitive emissions and renewable energies. 
This data is combined with a global warming goal and respectively a default 
- elictricity emission factor
- district heating emission factor
- district cooling emission factor
- elictricity price
- gas price
- district heating price
- district cooling price
- price of selected "Other source" of energy #1
- price of selected "Other source" of energy #2
- Carbon price
depending on the location of the building. If more detailed information concerning these numbers exist, the user can overwrite them in the other **Settings** tab **User-defined settings**.
Please note that for every building the **General** information "Gross internal area" needs to be filled out, and the delivery date needs to be in the past.

Now that you have input your building operations data, the platform will calculate a yearly CO2 emissions, as well as cost of energy and yearly energy consumption. To reach carbon neutrality until 2050, the CRREM tool calculates a decarbonisation path for a building. Any subsequent emissions above the decarbonisation target (so-called "exceess emissions") represent a carbon ristk. Economic obsolescence is associated with the stranding date; the higher the excess emissions, the greater the probability of economic obsolescence.

## Web-based passports
In addition to the One-pager, Executive Summary and Materials Passport, it's also possible to generate a web-based passport. This web-based passport is similar to the one-pager but available online for you to share with others. Unlike the other passports that are generated in a .pdf to download, the web-based passports are generated and stored online. In the Dossier tab, you can find the link that is created to this web-based passport and that you can share. 

# Preview Features

## Madaster Infra

To document infrastructure projects on Madaster, users can switch on the *Madaster Infra* feature.
The Infra feature enables other object types (e.g.: Engineering Structure, Terrain, Transport, or Cable/Pipe) in addition to buildings.
By uploading an Excel or IFC-file containing the build object and linking it to products in a choosen database, an evaluation concerning the **Mass**, **Circularity** and **Environment** can be made.

## EPEA Urban Mining Tool

The EPEA Urban Mining Tool predicts a building's material quantities based on easily accessible data inputs (Building Usage Type, Construction year, Gross Volume in m<sup>3</sup>, and Location (Street Address)). Additionally, the UMT generates estimations regarding the standard environmental impact indicators (e.g. Embodied Carbon). The UMT provides a “shortcut” to material and CO2 reporting for a building, portfolio, or entire municipality. Thus, users without detailed excel files or BIM models are able to estimate mass and environmental impact of their existing builings.

1. From within a folder that allows buildings, click New Object, and then EPEA Urban Mining Tool.
2. Use the interface to provide the required information
3. **Save**

## 2BA Database (Invite only)

* Use this feature to link with products within the 2BA database.
* **Prerequisite**: the account holder must have a separate license with 2BA to access the data.

## Split building

The Split Building feature allows users to create individual building dossiers and passports based on an IFC source file containing several buildings/homes.

1. To use this function, an individual "building number" must be available for each IFC element in the IFC file. The property set and property name for this building number are flexible. This can be specified in the account-level **Settings** tab as a **Preset for Upload**.
2. After an IFC source file containing several buildings/homes is uploaded and enriched, users can use the **Split the Building** button on the building’s **General** tab to automatically create individual building dossiers based on the assigned building numbers.

## Database Import/Export

When this feature is activated, on the **Dossier** tab of your database, there is an extra button **Import/Export** <iconify-icon inline icon='mdi-swap-vertical' /> to Import and Export products from and to your database. If this button is clicked you can choose what to files to generate and in which language. After generation, the files requested will be shown in the dossier overview and can be downloaded from there. 
The option to Import is only available if you have exported an empty Excel template. You will have to download the template and will it with the required information before you can upload it to your database. If all information is correct, your products will be added to the database and visible in the products overview.

## DGBC Detachability Report
DGBC = Dutch Green Building Council

When this feature is enabled on account level **AND** active on the data settings page (if necessary breaking the inheritance for settings), you can get information on the **Detachability** from the **Circularity** Tab of a building. On this tab there is a tile for Detachability and when you click it, you can see the detachability index for the building calculated from the 4 factors of detachability in your elements when specified.
These 4 factors are: 
- Connection type
- Accessibility of the connection
- Intersections
- Product edge inclusion

The quality index indicates the number of elements for which detachability information is included versus the number of elements in the building (in the relevant shearing layers).

## RICS Whole Life Carbon Assessment
When this feature is enabled, users will have the ability to generate a RICS Whole Life Carbon Assessment.

The RICS Whole Life Carbon Assessment is a framework provided by the Royal Institute of Chartered Surveyors for the reporting of Embodied and Operational Carbon. You can find a link to the original framework <a href="https://www.rics.org/profession-standards/rics-standards-and-guidance/sector-standards/construction-standards/whole-life-carbon-assessment" target="_blank">here</a>. 

The RICS Whole Life Carbon Assessment results are viewable through the Environmental tab, and by selecting "RICS Whole Life Carbon Assessment" from the "Compliance" drop down. The RICS Whole Life Carbon Assessment can be generated in the official RICS excel format by accessing the "General" tab on a building, selecting "Generate report", and selecting "RICS Whole Life Carbon Assessment" before selecting "Generate".

For more information about how the assessment is generated, please refer to our <a href="/files/en/RICS Compliancy Guide.pdf">RICS Compliance Guide</a> which will guide users through how RICS is interpreted on the Madaster Platform.

## Levels
Same as with CRREM, if you have the **ESG feature** enabled, you can get Reporting on **Level(s) Classification** on this ESG tab of a building. At this point, only the indicator 1.2 (Life cycle Global Warming Potential (GWP)) is developed and still in development-phase. We will be adding other indicators in the future. 

