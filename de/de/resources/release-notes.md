---
title: Release notes
description: Hier finden Sie Informationen zu den Entwicklungen bzw. Versionen der Plattform
ref: release-notes
type: Downloads
menubar: resources-nav
---

## Release notes 2024.4 ##

### Changes to selection in the environmental screen ###

It is now possible to select a preferred scheme, like the MPG or DGNB, directly in the environmental tab. This influences the available KPI's as well, since different schemes have different KPI's. The availability of a scheme is dependent on whether the corresponding feature is available in your account. By default, the standard 15978 is always available and can be based on either A1 or A2 EPD's as described in the 15804. These changes to the selection work on account, folder and building level.

![A building where multiple schemes are available](/assets/images/releasenotes/202404-10108-1.png)

In addition, the phases have become multiselect, wich makes it possible to select and combine exacly the phases that you want to analyze. By default the selection is what the chosen scheme would normally require for reporting.

![The option to choose your phases](/assets/images/releasenotes/202404-10108-2.png)

### Level(s) 2.2 ###

We have added the option to generate the Level(s) 2.2 report. This report is available if the Level(s) feature is activated on your account. It is a report of the construction and demolition waste of a project and similar to other Level(s) reports can be used to align with the EU Taxonomy. For automatic filling of the report the project requires waste information to be available in the project.

![The screen where a Level(2) 2.2 report can be generated](/assets/images/releasenotes/202404-9914.png)

### Changes to generate material passport ###

The 'issue material passport' button has been changed to 'generate report'. This button will now give the option to generate the Madaster material passport as well as scheme specific reports like the Gebäuderessourcenpass from the DGNB, the RICS Carbon Assessment or the MPG report.

![An example of the new generate report options](/assets/images/releasenotes/202404-10111.png)

### Waste codes in excel ###

Last release we introduced the option to add waste information in your digital building files. In this release we've added the lists to the excel export of your building so that they are easier to see and use. This includes the European Waste Codes, the nature of the waste and the end of life scenarios.

![The new sheet in the excel building export](/assets/images/releasenotes/202404-10232.png)

### End of Life scenarios in EPDs ###

Sometimes in EPD databases that we use there are multiple end of life scenarios defined. In order to accomodate for that we've added the different scenarios as separate products in Madaster where we could find them. By default the first scenario will be chosen for the matching.

![An example of multiple end of life scenarios in the Okobaudat database](/assets/images/releasenotes/202404-10048.png)

### Transferring buildings ###

Transferring buildings can now only be done within the same country.

### Country specific release items ###

### United Kingdom ###

* This release we've update our RICS functionality to be compliant with RICS v2. The report is available through the generate report option on a building if the feature is active.
* We have added a field on the building for the UPRN (Unique Property Reference Number).

### Germany ###

* Now the CRREM report in Germany looks specifically for the Gross internal area for its calculations.
* The Gebäuderessourcenpass has been updated so that is filled in more with data available in the platform.

## Release notes 2024.3 ##

### Waste ###

This release the option has been added in the platform to add construction waste as well as being able to categorize both construction and demolition waste according to the European Waste Codes. 

Waste is bound to the phase of the elements:

* For preserved elements it is not possible to add waste information
* New elements can have construction waste, including a wastage and overordering percentage
* Demolished elements can be provided with an European Waste Code
* A new phase has been introduced: "Construction waste". The function of this phase is to add construction waste information separately in case further information on the element is unknown. This creates the possibility to have waste information even though further details of the element, like the full amount, is not available.

An element can have multiple European Waste Codes. When adding an European Waste Code there is the option to add:

* The actual European Waste Code
* The percentage of the element having that European Waste Code
* Whether the waste is hazardous, non-hazardous or inert
* The outcome, or end of life scenario, in case of it being construction waste or when it has been overordered. Note that when waste is hazardous there are different options, reflecting that hazardous waste is for example not reusable.

There are multiple ways of adding waste information.

#### Enrichment ####

It is possible to add waste information when enriching your building file in the platform, for example when editing a new element:

![Waste fields on a new element in enrichment](/assets/images/releasenotes/202403-9915-1.png)

When selecting the option to add an European waste Code the following screen appears:

![Adding an European Waste Code in enrichment](/assets/images/releasenotes/202403-9915-2.png)

* In **material family** the European Waste Code can be selected
* **Percentage** is the amount of waste attributed to that European waste code for that building element
* In **Nature of waste** it is possible to select whether the waste is hazardous, non-hazardous or inert. Hazardous waste has a limited selection of end of life scenarios to be chosen from the outcome of construction or outcome of overordering waste.
* In **Outcome of construction waste** it is possible to select the end of life scenario for this specific construction waste
* In **Outcome of overordering** it is possible to select the end of life scenario for this specific overordering waste

#### Excel ####

It is possible to add waste information using the excel template. This can be done when using excel as the building file for your building or when exporting an ifc file. The format for utilizing the waste code column in excel is as follows:

* code:percentage:nature:cw-outcome:oo-outcome;code:percentage:nature:cw-outcome:oo-outcome

For which:

* **code** is the European Waste Code
* **percentage** is the percentage of the European Waste Code for the element
* **nature** is the nature of waste
* **cw-outcome** is the outcome of construction waste
* **oo-outcome** is the outcome of overordering waste

Which can be repeated in case of multiple codes. An example:

* 16 02 09*:0.1:Hazardous:70:70;17 01:0.25:Inert:60:60;

#### Including it in your .ifc file ####

If you want to include waste information in your IFC file it is possible to match it by:

* Using the upload settings in your account:

![Mapping waste information in the upload settings](/assets/images/releasenotes/202403-9915-3.png)

* Include it in the CPset

### Level(s) indicator 2.1 ###

It is now possible to generate the Level(s) 2.1 report. This is possible when:

* You are using the DIN-276 classification in your digital building file
* You have the Level(s) feature enabled

![Generating the Level(s) 2.1 report](/assets/images/releasenotes/202403-9904.png)

### DGNB Gebäuderessourcenpass ###

We have updated the DGNB Gebäuderessourcenpass (GRP) so that a lot more information will be exported into the GRP. Provided the information is available of course.

### Release notification removal ###

The release notification will now be permanently removed once it has been dismissed.

## Release notes 2024.2 ##

* build number: 26551
* Release date: 1st of April 2024

## Internal release notes ##

### Track and Trace Premium Tier ###

Additional producer "premium" tier has been added which included Track and Trace by default.  

### Updates to Content Management within Madaster

For employees with access, at the bottom of the left sidebar is the "Content Management" button. Within Content management, Madaster Employees that have been given access will be able to change the names of building usages as well as titles and subtitles in the ESG tabs. Building usages have been grouped to reduce the size of the list.

![The content management button in the sidebar](/assets/images/releasenotes/202402-9816.png)

## External release notes ##

### MPG Calculation for Dutch  Buildings ###

It is now possible to download a complete MPG report for a building. It is found in through the "issue material passport" button.

![The MPG Passport](/assets/images/releasenotes/202402-9287.png)


In order to be able to export a MPG passport, ifc elements on the building need to be connected to the NMD databases. In order to do so, link the ifc elements to the NMD database through the "enrich" screen

Within the enrich screen, it is then possible to compare and sort according to MKI scores of applied products from the NMD database

![The MPG Enrich Screen](/assets/images/releasenotes/202402-9724.png)

### Scaling ###

The database now has support for scalable products, so now mass can be calculated according to the scalable dimensions that are set up.

There are multiple ways a scaling of a product can be defined depdending on the specific needs of a particular product. For instance, it can be a wall whose thickness increases with an increase in area, or a pipe that increases in diameter with an increase in length.

Scalable products can be applied as new products or applied to existing products. Within the database, when "new product" is selected, or "edit" is selected for an existing product, on the right side of the product information form there is now an option to check whether a product is "scalable" or not. 

![The Scaling information form](/assets/images/releasenotes/202402-9876-1.png)

When "scalable" is selected, there will be more fields visible where the scalability parameters of the product can be defined. This can be based on the functional unit, on fixed dimensions, or even a user-defined property. 

![The Scaling formula](/assets/images/releasenotes/202402-9876-2.png)

Once functional unit has been defined, the scaling unit can be defined, with X in the below being the functional unit.

Linear scaling has the formula: (a * X + c) , where a and c need to be defined

Scaling with power formula: (a * X<sup>b</sup> + c) , where a, b, and c need to be defined

Logarithmic scaling: (a * In(b *X) + c) , where a, b, and c need to be defined.

Exponential scaling: (a *exp(X) + c) , where a and c need to be defined

![The Scalable product page](/assets/images/releasenotes/202402-9876-3.png)

When an excel file containing scalable products is uploaded, it will automatically matcho those products and the values for the scalable properties, provided the values are within the margins defined for the product. If the extents of the product are outside the defined margins, the nominal value defined for the product will be assumed. On the enrich screen the values extracted from the excel can be verified.

![Scalability in Enrichment 1](/assets/images/releasenotes/202402-9876-4.png)

![Scalability in Enrichment 2](/assets/images/releasenotes/202402-9876-5.png)

![Scalability in Enrichment 3](/assets/images/releasenotes/202402-9876-6.png)

After activating the file, the mass will be calculated accordin to thespecifications set for scaling:

![Mass Screenshot](/assets/images/releasenotes/202402-9876-6.png)

In the above example, 3 example walls are used, on in the "Skin" layer, one in the "Services" layer, and one in the "Space Plan" layer. 

In the "Services" layer, it is a default wall of 20cm thickness with a grammage of 20kg/m<sup>2</sup> and no scaling, therefore the final wall will be 200kg for 10m<sup>2</sup>

In the "Space plan" layer, the wall is scaled to a thickness of 10cm instead of 20, and with a linear formula that sets its grammage to 0,5(a) * 10(cm) + 10(c) = 15kg/m2, which results in a mass of150kg for the same area of 10m<sup>2</sup>. Without scaling, the mass of this wall would have been assumed as 100kg.

In the "skin" layer, the wall has a thickness of 75cm, and using the same linear scaling formula of 0.5 * 75 + 10 = 47.50kg/m<sup>2</sup> the resulting mass is 475kg for the same area of 10m<sup>2</sup>. Without the scaling formula, the mass of this wall would have been as 750kg.

### DGNB Reporting ###

Within the ESG Tab, a DGNB report can be produced. In this release, the reporting for ENV 1.1 Climate Action and Energy is available, which covers ENV 1.1-2.1, ENV 1.1-2.2, and ENV 1.1-2.5 in the DGNB. The compliance can be set either to EN15804:2012-04+A1 2013 or EN15804:2012+A2:2019

![DGNB Screenshot](/assets/images/releasenotes/202402-9530.png)

### BBSR Material Classification ###

Madaster now supports the DGNB BBSR material classification

### UMS 2.0 for German Customers ###

The UMS for German customers has been updated to reflect the latest methodology stated in (state source). German buildings in the UMS now rely on Gross Floor Area rather than Volume for the calculations.

### RIBA Stages ###

The "Building Phases" in the UK has been updated to reflect the RIBA stages

### Creation of Virtual Sub Elements ###

In the enrich screen, a selected element can have a virtual subelement added to it through the "split element" button

![Virtual Sub Elements](/assets/images/releasenotes/202402-9721-1.png)

![Virtual Sub element button](/assets/images/releasenotes/202402-9721-2.png)

Within the split element form, it is then possible to put the volume, area, length or width for the selected element, and it now acts as a sub element for the selected ifc parent element.

![Created Virtual Sub element](/assets/images/releasenotes/202402-9721-3.png)

The sub element can then have a product associated to it from any of the databases available in madaster, and that split element can then be duplicated across all ifc elements with the same parent name. A use case for this would be inserting a door handle that was not modelled in the ifc across all the similar doors in a project.

### Advanced Mode for Private Home Owners ###

Home owners can activate "advanced mode" in the settings via the 3 dots menu which enables

* Performance tab
* Mass Tab
* Circularity Tab
* Environmental Tab
* Financial Tab
* Presets for upload
* Presets for passports
* Data settings

![Advanced mode for home owners](/assets/images/releasenotes/202402-9858.jpg)

### Excel Template Updates ###

In the Madaster Excel template, there is now support for implementing several buildings into the same excel template. Within the excel template, there is also an additional column for "Number of elements", which now indicates how many times an element is to be duplicated. For example, if there is a project with several windows of the same kind, the window data can be implemented once, and then the number of times it is duplicated across the project can be placed into the "Number of elements" column.

### Additional options when copying an ifc ###

When an ifc is copied, there are now options to duplicate the following items in the ifc:
* The excluded states of any items excluded in the original ifc
* Custom detachability data that was implemented within Madaster
* Custom properties and data that was implemented within Madaster

![Additional options when copying an ifc](/assets/images/releasenotes/202402-9708.jpg)

### Added support for ifcmaterialproperties ###

Madaster now supports ifcmaterialproperties

### Bugfixes ###

* Resolved bug where geometric properties were not appearing in customer PSET
* Resolved incorrect limitations on the CRREM user defined Carbon Pricing
* Resolved bug where CRREM reporting for the year 2023 was not working correctly with the excel functionality
* Resolved bug where elements would be incorrectly duplicated in the excel export
* Resolved bug where products in the financial tab would not show up correctly until tabs were changed
* Resolved bug where superscript was not displaying correctly on product info pages


## Release notes 2024.1 ##

* build number: 25412
* Releasedate: 8th of February 2024

## Internal release notes ##

### Activate on-demand feature as super user ###

As a superuser it is now possible to turn on on-demand features:

![as a super user, on-demand feature can be activated](/assets/images/releasenotes/202401-9691.png)
*screenshot of the feature screen when logged in as a superuser. You can now turn on the features and the red text is not shown to superusers*

### Docs 2.0 ###

This release docs 2.0 will go live. Development will supply the documentation in English.

## Country-specific Release notes ##

* The DGNB label has been added to the building form for Germany and Austria
* The building service phase has been added to the building form for Austria

## External release notes ##

### Save viewpoint in 3D-viewer ###

It is now possible to save your viewpoint in the 3D-viewer:

![saving your viewpoint in the 3D viewer](/assets/images/releasenotes/202401-9686.png)

It is possible to undo your viewpoint and choose a new one. The chosen viewpoint will be the default when opening the 3D viewer or in the general tab.

### Changes in datasources for financial information ###

For the following datapoints the source has been changed or fixed:

* Inflation for the EuroZone, UK and US
* US Dollar Chinese Yuan exchange rate
* Pricessets for Wool, Rubber and Timber

### Searching for sub elements in enrichment ###

It is now possible to search for sub elements in enrichment. Note that the result will show the parent in which the sub contains the match on the search. It is also possible to search on sub ID's.

![Finding results in sub elements](/assets/images/releasenotes/202401-8784.png)

### Reporting on Level(s) indicator 1.2 ###

Level(s) is an European framework for reporting on environmental indicators for buildings. It is now possible to generate results for indicator 1.2 (Global warming potential) on a building in Madaster, including exporting the results in an excel.

![An example of a Level(s) indicator 1.2 report on a building](/assets/images/releasenotes/202401-9481.png)

Level(s) reporting can be activated on request.

### Upload preset screen ###

The upload preset screen has been changed to account for a growing number of databases.

![The changed database selection options in the upload preset screen](/assets/images/releasenotes/202401-9689.png)

### Energy fields and building images added to UMS objects ###

It is now possible to use energy fields and building images on an UMS object

![The added tabs on an UMS object building form](/assets/images/releasenotes/202401-9719.png)

### Changes to the user overview ###

On account level the following options have been added to the user overview:

![The added options on the user overview on account level](/assets/images/releasenotes/202401-9806.png)

* The 'show all rights' toggle changes the overview from showing the users that have access on the whole account or all users that have access on any page within the account.
* The group by icon switches the overview between:
    * Showing the users with their authorizations grouped
    * Showing each combination of a user and an authorization in a list

On folder and building level the group by option is also available, but not the 'show all rights'.

### Bugfixes ###

* Models with elements scattered over a big area would not always show up correctly in the viewer, which is corrected.
* In the file upload screen it could happen that databases would appear multiple times, this has been fixed.
* Very long typenames on the elements in the enrichment screen would cause problems. These are solved.


## Older release notes ##

More information about the releases can be found here:

* <a href="/files/en/Madaster Release notes 2023.pdf" target="_blank">Release notes 2023</a>
* <a href="/files/en/Madaster Release notes 2022.pdf" target="_blank">Release notes 2022</a>
* <a href="/files/en/Madaster Release notes 2021.pdf" target="_blank">Release notes 2021</a>