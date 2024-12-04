---
title: Release notes
description: More information about the releases can be found here
ref: release-notes
type: Resources
menubar: resources-nav
---

This page contains the release notes.

## Release notes 2024.8 ##

* Build number: 31592
* Release date: December 2nd 2024

### Calculating impacts of a renovation ###

It is now possible to see the environmental impacts of a renovation according to the 15978 standard. This works as follows:

When your building is in renovation and you have added a **last renovation date**:

<figure><img src="/assets/images/releasenotes/202408-10845-1.png" alt="Building phase in renovation on the building"><figcaption>Building phase in renovation on the building</figcaption></figure>

Madaster will for the impacts take into account the different phases of the elements on the building, where there are three options: new, preserved and demolished. New elements represent the added elements to a building in the renovation, preserved the elements that are kept and demolished the ones that are removed in the renovation project. This can be set in the building file and also in enrichment:

<figure><img src="/assets/images/releasenotes/202408-10845-2.png" alt="Setting the element phase in enrichment"><figcaption>Setting the element phase in enrichment</figcaption></figure>

The impacts of the elements that have these different phases will then show up in the environmental screen on the building and are calculated according to the 15978 LCA rules as defined in the standard. Keep in mind that this will only work when using the 15978 as the LCA analysis method.

<figure><img src="/assets/images/releasenotes/202408-10845-3.png" alt="The impacts of the renovation"><figcaption>The impacts of the renovation</figcaption></figure>

It is possible to filter on the phases by clicking in the graph. That way, it is possible to for example single out only the impacts of the newly added materials in the renovation project:

<figure><img src="/assets/images/releasenotes/202408-10845-4.png" alt="The impacts of the new materials in the renovation project"><figcaption>The impacts of the new materials in the renovation project</figcaption></figure>

### Product passport ###

With this release a new preview feature (which means it can be only be turned on, on request) has been added to generate a product passport for your products. This feature can be found here:

<figure><img src="/assets/images/releasenotes/202408-10793-1.png" alt="The product passport feature"><figcaption>The product passport feature</figcaption></figure>

Having this feature on will change the product overview page:

<figure><img src="/assets/images/releasenotes/202408-10793-2.png" alt="The product overview page when the product passport feature is turned on"><figcaption>The product overview page when the product passport feature is turned on</figcaption></figure>

It will also open up the option to configure your product passport on a product database:

<figure><img src="/assets/images/releasenotes/202408-10793-3.png" alt="Setting up a product passport"><figcaption>Setting up a product passport</figcaption></figure>

There is an option to generate your product passport on the product. When used a pdf file will be created in the dossier of the product:

<figure><img src="/assets/images/releasenotes/202408-10793-4.png" alt="Generating a product passport"><figcaption>Generating a product passport</figcaption></figure>

Location of the passport:

<figure><img src="/assets/images/releasenotes/202408-10793-5.png" alt="The passport in the dossier of the product"><figcaption>The passport in the dossier of the product</figcaption></figure>

Now it is possible to view or download your product passport.

### Support for element combination in IFC ###

When in the IFC export the material families are exported as separate IFC elements it is now possible to set up IFC properties that will be read out in Madaster to recombine those separate IFC elements within a parent-child structure. This is done by using the following properties directly in the Madaster cp_set:

* ElementInstanceCombinationId
* ElementCombinationType

Or defining your own property names in the upload settings in the platform. When this is used Madaster will create a virtual parent element where all elements sharing this ID will be grouped under based on the ElementInstanceCombinationId. The ElementCombinationType will be used for the name and typename of the element.

### Adding material names as search criteria ###

When linking an element to a product in enrichment it was already possible to add the product as a search criterion on the building level. This has now been extended to make it possible to add it as a search criterion on account level as well:

<figure><img src="/assets/images/releasenotes/202408-11039-1.png" alt="Adding search criteria based on the chosen product on account level"><figcaption>Adding search criteria based on the chosen product on account level</figcaption></figure>

### Construction waste in A5 for 15978 and Level(s) ###

The impacts of the construction waste will now be counted in the A5 phase of a building when using the 15978 or Level(s) LCA schemes. The impacts are calculated by summing the impacts from the following phases of the product: A1-A3+A4+C1+C2+C3+C4.

### Other changes ###

* When clicking on the more detailed hierarchy of the classification in the mass tab there was an option to go to a non-existent last level. This is now no longer possible.
* Benchmarking has been changed so it is now only possible to select a building that a user is allowed to see (from the same account)
* It is now possible to use 'contains' in the product excel template for search criteria
* When using the 3D viewer in enrichment, the ID column has been replaced with the material name. It is still possible to see the ID's.

### Country specific ###

* For the DGNB it is now possible to aditionally select the following KPI's in the environment screen: POCP, EP and AP. Keep in mind that those KPI's are based on the A1 values.
* The Infrastructure classification LB-VI, Version 7 has been added for Austria 

## Release notes 2024.7 ##

* Build number: 30956
* Release date: 2nd of November 2024

### Additional options when exporting portfolio ###

On folder and account level the export of buildings in an excel has been changed. The button has been moved to the toolbar:

<figure><img src="/assets/images/releasenotes/202407-10734-1.png" alt="Button to generate an excel of the buildings in your account of folder"><figcaption>Button to generate an excel of the buildings in your account of folder</figcaption></figure>

And it will now dynamically be filled with the selected KPI's. KPI's are chosen in the edit-layout setting on your profile:

<figure><img src="/assets/images/releasenotes/202407-10734-2.png" alt="In edit lay-out it is possible to choose KPI's"><figcaption>In edit lay-out it is possible to choose KPI's</figcaption></figure>

### Configure a database to match on name ###

If you want your product database to automatically include the names of the product as search criteria to be matched on when a building file uses the database there is now an option for this. This is both possible on a producer database and on a database in a regular account.

<figure><img src="/assets/images/releasenotes/202407-10848-1.png" alt="Option to use the product names as search criteria for matching"><figcaption>Option to use the product names as search criteria for matching</figcaption></figure>

### Upload preset extended with output flow for reuse ###

It is now possible to set the properties used in an IFC file for reuse on the output flow:

<figure><img src="/assets/images/releasenotes/202407-10857-1.png" alt="Upload setting for using data from an ifc for the output flow for reuse"><figcaption>Upload setting for using data from an ifc for the output flow for reuse</figcaption></figure>

### Sharing databases across countries ###

It is now possible to share a database with accounts in other countries:

<figure><img src="/assets/images/releasenotes/202407-10923-1.png" alt="Option to share a database with accounts in different countries"><figcaption>Option to share a database with accounts in different countries</figcaption></figure>

### Other  changes ###

* When the Name of the ifc element is unknown (when it is not set in the IFC or it contains no data) the typename is no shown as the name. 
* It is now possible in the dossier of a building to switch between the upload and export date of your source files.
* It is now possible to select a delivery date on your building much further in the past.
* The list of system databases and suppliers has been ordered more logically in the navigation and the country filter also filters this list now.


### Bugfixes ###

* Parts of the legend could be missing on the graphs in the environmental screen, which is fixed.
* Product images would not appear when viewing a product from enrichment, now they do.
* For benchmarking the option to select 'none' did not result in clearing the benchmarks. This is fixed.
* Fixed the dropdown for the explorer display mode in the 3D viewer not appearing.
* Fixed a bug where the user settings screen would partially disappear behind other parts of the screen.
* In the material passport databases could be shown as verified when they weren't, which is fixed.
* Material classification could be missing on the product when using the classification from the bill of materials. This is resolved.

### Country specific ###

* The Ökobaudat 2020 version has been made available
* Input values for Austria have been changed to work with a comma for decimal values
* For the paris proof indicator for the Netherlands the 30% penalty for using category 3 products from the NMD is now applied.

## Release notes 2024.6 ##

* Build number: 30680
* Release date: 4th of October 2024

### Source file settings visible on uploaded building file ###

With this release the settings used when uploading a source file are now visible when viewing said file:

<figure><img src="/assets/images/releasenotes/202406-10762-1.png" alt="Information about the settings used when uploading a file as shown in the platform"><figcaption>Information about the settings used when uploading a file as shown in the platform</figcaption></figure>

### Set lifespan on element ###

It is now possible to set a lifespan on element level. This overrules the lifespan as set in either the classification or on the product itself. This will effect certain calculations, such as the impacts in the B4 phase.

<figure><img src="/assets/images/releasenotes/202406-10825-1.png" alt="Setting the lifespan on an element can be done from the enrichment screen"><figcaption>Setting the lifespan on an element can be done from the enrichment screen</figcaption></figure>

This has also been added to the upload presets and to the excel export of a building file.

### Changes to splitting elements ###

When splitting an element manually in the platform we will now show how much volume and thickness remains from the main element. If the total of the splitted elements is more or less than the value of the original element a warning is shown. It is also possible to set a specific lifespan on the splitted element.

<figure><img src="/assets/images/releasenotes/202406-10473-1.png" alt="The warning shown when the total amounts do not match"><figcaption>The warning shown when the total amounts do not match</figcaption></figure>

<figure><img src="/assets/images/releasenotes/202406-10473-2.png" alt="Remaing amount shown when splitting an element"><figcaption>Remaing amount shown when splitting an element</figcaption></figure>

### Possible to drill down in classification overview on circularity and environmental tabs ###

It is now possible to click on the classification codes in the circularity and environmental tabs in order to see the deeper levels of the classification.

<figure><img src="/assets/images/releasenotes/202406-10555-1.png" alt="More detailed classification overview for circularity"><figcaption>More detailed classification overview for circularity</figcaption></figure>


### Export and import of an excel building file added ###

If you have used an excel template to create your building you can now use the export and import functionality on the building file.

### Defaults when uploading a new version ###

When uploading a new version of a source file the following options are now checked by default:

<figure><img src="/assets/images/releasenotes/202406-10782-1.png" alt="Defaults when uploading a new version"><figcaption>Defaults when uploading a new version</figcaption></figure>

### Warning added when waste codes do not add up to 100% ###

If the waste codes do not add up to a 100% a warning will be shown. It is still possible to save the waste codes without them being a 100%.

<figure><img src="/assets/images/releasenotes/202406-10472-1.png" alt="The warning that is shown in enrichment when the waste codes do not add up to a 100%"><figcaption>The warning that is shown in enrichment when the waste codes do not add up to a 100%</figcaption></figure>

### Other changes ###

* In the environmental tab it is no shown in the relevant card when the area that is necessary for the calculation is not filled in
* When importing an IFC the material layers are no longer grouped by name but instead separate items are created in Madaster
* Information about whether a product is removed during a renovation has been added to track and trace

### Country specific ###

* For all countries except the Netherlands the layer lifespans have been removed from the material passport
* The Gebäuderessourcenpass has been updated to version 1.2
* A number of older versions of Okobaudat have been made available

## Release notes 2024.5 ##

* Build number: 30163
* Release date: 9th of September 2024

### Changes to benchmarking ###

It is now possible to benchmark your designs and archives from the main building as well as viewing the impacts side by side from the environmental screen.

First you need to set your benchmark:

<figure><img src="/assets/images/releasenotes/202405-10500-1.png" alt="Set your benchmark"><figcaption>Set your benchmark</figcaption></figure>

There you can choose the designs or archives you want to benchmark against. It is possible to select multiple:

<figure><img src="/assets/images/releasenotes/202405-10500-2.png" alt="Choose your buildings for benchmarking"><figcaption>Choose your buildings for benchmarking</figcaption></figure>

Once saved a new card will appear as well as multiple bars in the graph to be able to do a comparison:

<figure><img src="/assets/images/releasenotes/202405-10500-3.png" alt="Results in the screen after selecting the buildings"><figcaption>Results in the screen after selecting the buildings</figcaption></figure>

Note that you select the compliance and phases for different comparisons and that it is also possible to do this comparison from the design or archive. It is also possible to compare per shearing layer or classification:

<figure><img src="/assets/images/releasenotes/202405-10500-4.png" alt="Results when selecting shearing layers"><figcaption>Results when selecting shearing layers</figcaption></figure>

### Additional reporting options ###

#### EU Taxonomy ####

It is now possible to report on the EU Taxonomy for the substantial contribution to the circular economy. This is meant for the economic activity 'new construction'. This is a preview feature that is not enabled by default, but can be requested. If the feature is active the reporting option becomes available at the ESG tab:

<figure><img src="/assets/images/releasenotes/202405-10241-1.png" alt="EU Taxonomy reporting option at ESG tab"><figcaption>EU Taxonomy reporting option at ESG tab</figcaption></figure>

Once selected and the subject and indicator are selected the report will be shown:

<figure><img src="/assets/images/releasenotes/202405-10241-2.png" alt="EU Taxonomy report"><figcaption>EU Taxonomy report</figcaption></figure>

For a full description of the indicators we recommend looking at the EU Taxonomy compass. Note that for a number of indicators it is possible to use the Level(s) reports to show your alignment. The option to generate these reports have been added to the screen.

#### Level(s) ####

This release we've made a number of changes and additions to the Level(s) reports:

* In the Level(s) 2.2 report the construction waste is now also filled
* The Level(s) 2.4 report has been added

### Smaller selection of environmental KPI's for the 15978 LCA analysis ###

Due to performance reasons we have limited the set of KPI's which are shown in the environmental screen when the 15978 LCA methodology is chosen.

### Changes to uploading a new or a new version of a source file ###

#### New source file ####

When uploading a new source file it is now possible to select a preferred compliance for matching. This makes it possible to for example only match on A2 EPD's instead of any EPD:

<figure><img src="/assets/images/releasenotes/202405-9909-1.png" alt="Choosing A1 or A2 for matching"><figcaption>Choosing A1 or A2 for matching</figcaption></figure>

#### New version of a source file ####

When uploading a new version of a source file, for example from the dossier page:

<figure><img src="/assets/images/releasenotes/202405-10506-1.png" alt="Starting adding a new version of a source file"><figcaption>Starting adding a new version of a source file</figcaption></figure>

A number of changes have been made. First, there are more options to make sure information from the earlier version can be integrated with the new version:

<figure><img src="/assets/images/releasenotes/202405-10506-2.png" alt="New options in the screen for uploading a new version of a source file"><figcaption>New options in the screen for uploading a new version of a source file</figcaption></figure>

* Manually entered Phase and classification information will now be copied from the previous version when selecting "copy manually edited properties"
* Manual circularity information can now be copied from the previous version when selecting "copy circularity and detachability"
* It is now possible to copy the building numbers when selecting "Copy building numbers"
* It is now possible to copy the waste codes when selecting "Copy waste codes"
* Elements that have been split manually can also be copied when selecting "Copy split elements", but not in case the original parent element has been removed in the new file.

Secondly, if in the original upload a compliance for matching was selected this will be shown as well. This is only informative, it is not possible to change your matching compliance when uploading a new version.

Also, when uploading a new version it is now possible to use an upload preset.

### Changes to enrichment ###

In the enrichment screen we have changed a number of filters so that it is possible to select multiple values:

<figure><img src="/assets/images/releasenotes/202405-9516-1.png" alt="Multiple values chosen at the filter for product"><figcaption>Multiple values chosen at the filter for product</figcaption></figure>

This makes the filter options more powerful. Most filters have been changed to accomodate for this.

Furthermore; the unit 'weight' was added as a filter option.

When having an element in the phase 'new' or 'demolished' it is possible to add a European Waste code. These have been moved to a separate tab when editing the element:

<figure><img src="/assets/images/releasenotes/202405-10459-1.png" alt="Waste codes in new tab"><figcaption>Waste codes in new tab</figcaption></figure>

We have added the IFC properties when viewing an element in enrichment:

<figure><img src="/assets/images/releasenotes/202405-10483-1.png" alt="The IFC properties as shown on an element in enrichment"><figcaption>The IFC properties as shown on an element in enrichment</figcaption></figure>

### Designs and archive accessible from building overview ###

Archives and designs have been made accessible from the general tab on a building. It was already possible to access these either through the navigation or from the account or folder. It has been added on two places:

* Through the toolbar options where it is also possible to create the design or archive:

<figure><img src="/assets/images/releasenotes/202405-9826-1.png" alt="Option to navigate to the archives from the toolbar"><figcaption>Option to navigate to the archives from the toolbar</figcaption></figure>

<figure><img src="/assets/images/releasenotes/202405-9826-2.png" alt="Option to navigate to the designs from the toolbar"><figcaption>Option to navigate to the designs from the toolbar</figcaption></figure>

Note that since there is a maximum of three designs the options to create one will disappear once there are already three.

* On the bottom of the general tab on the building:

<figure><img src="/assets/images/releasenotes/202405-9826-3.png" alt="Archives and designs on the bottom of the general tab"><figcaption>Archives and designs on the bottom of the general tab</figcaption></figure>

### Changes to the 3D viewer ###

* When showing the properties of an element in the 3D viewer the classification code is now visible:

<figure><img src="/assets/images/releasenotes/202405-10495-1.png" alt="Classification in the 3D viewer"><figcaption>Classification in the 3D viewer</figcaption></figure>

* When using the 3D viewer from the environmental or circularity tabs more interaction options have been added:

<figure><img src="/assets/images/releasenotes/202405-10532-1.png" alt="New options from env or circ in the 3D viewer"><figcaption>New options from env or circ in the 3D viewer</figcaption></figure>

Which are:
* Toggle axis
* Slice object
* X-ray object

### Other changes ###

* When uploading a picture or logo on a producer database it will now be shown in the overview screen of the database and from the overview screen of all the databases
* The exported graphic when using the button in the mass or environmental tab has been improved

<figure><img src="/assets/images/releasenotes/202405-10531-1.png" alt="Button to export the graph as a picture"><figcaption>Button to export the graph as a picture</figcaption></figure>

### Bugfixes ###

* When using certain zoom levels on the finance tab a graphical glitch resulting in a loop could happen, this has been fixed.
* The unit in the bars in the graph in the environmental tab could be different from the unit shown on the x-axis of the graph. This was fixed.
* Calculating a building with a large amount of unmapped items could break the calculation process, for which we made a fix.

## Release notes 2024.4 ##

### Changes to selection in the environmental screen ###

It is now possible to select a preferred scheme, like the MPG or DGNB (DE), directly in the environmental tab. This influences the available KPI's as well, since different schemes have different KPI's. The availability of a scheme is dependent on whether the corresponding feature is available in your account. By default, the standard 15978 is always available and can be based on either A1 or A2 EPD's as described in the 15804. These changes to the selection work on account, folder and building level.

![A building where multiple schemes are available](/assets/images/releasenotes/202404-10108-1.png)

In addition, the phases have become multiselect, wich makes it possible to select and combine exacly the phases that you want to analyze. By default the selection is what the chosen scheme would normally require for reporting.

![The option to choose your phases](/assets/images/releasenotes/202404-10108-2.png)

### Level(s) 2.2 ###

We have added the option to generate the Level(s) 2.2 report. This report is available if the Level(s) feature is activated on your account. It is a report of the construction and demolition waste of a project and similar to other Level(s) reports can be used to align with the EU Taxonomy. For automatic filling of the report the project requires waste information to be available in the project.

![The screen where a Level(2) 2.2 report can be generated](/assets/images/releasenotes/202404-9914.png)

### Changes to generate material passport ###

The 'issue material passport' button has been changed to 'generate report'. This button will now give the option to generate the Madaster material passport as well as scheme specific reports like the Gebäuderessourcenpass from the DGNB (DE), the RICS Carbon Assessment or the MPG report.

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

Madaster germany platform: We have updated the DGNB Gebäuderessourcenpass (GRP) so that a lot more information will be exported into the GRP. Provided the information is available of course.

### Release notification removal ###

The release notification will now be permanently removed once it has been dismissed.

## Release notes 2024.2 ##

* build number: 26551
* Release date: 1st of April 2024

<!-- ### MPG Calculation for Dutch  Buildings ###

It is now possible to download a complete MPG report for a building. It is found in through the "issue material passport" button.

![The MPG Passport](/assets/images/releasenotes/202402-9287.png)


In order to be able to export a MPG passport, ifc elements on the building need to be connected to the NMD databases. In order to do so, link the ifc elements to the NMD database through the "enrich" screen

Within the enrich screen, it is then possible to compare and sort according to MKI scores of applied products from the NMD database

![The MPG Enrich Screen](/assets/images/releasenotes/202402-9724.png) -->

### Scaling ###

The database now has support for scalable products, so now mass can be calculated according to the scalable dimensions that are set up.

There are multiple way a scaling of a product can be defined depending on the product. For instnace, it can be a wall whose thickness increases with an increase in area, or a pipe that increases in diameter with an increase in length.

Scalable products can be applied as new products or applied to existing products. Within the database, when "new product" is selected, or "edit" is selected for an existing product, on the right side of the product information form there is now an option to check whether a product is "scalable" or not. 

![The Scaling information form](/assets/images/releasenotes/202402-9876-1.png)

When "scalable" is selected, there will be more fields visible where the scalability parameters of the product can be defined. This can be based on the functional unit, on fixed dimensions, or even a user-defined property. 

![The Scaling formula](/assets/images/releasenotes/202402-9876-2.png)

Once functional unit has been defined, the scaling unit can be defined, with X in the below being the scalable dimension.

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

Within the ESG Tab, a DGNB report can be produced on the madaster germany platform. In this release, the reporting for ENV 1.1 Climate Action and Energy is available, which covers ENV 1.1-2.1, ENV 1.1-2.2, and ENV 1.1-2.5 in the DGNB. The compliance can be set either to EN15804:2012-04+A1 2013 or EN15804:2012+A2:2019

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
