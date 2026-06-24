---
title: Release notes
description: More information about the releases can be found here
ref: release-notes
type: Resources
menubar: resources-nav
---

This page contains the release notes for 2026.

## Release notes 2026.5 ##

* Build number: 39740
* Release date: 8th of June 2026

### Changes ###

* Sankey diagram; it is now possible to see the material flow Sankey on account and folder. This diagram was only available on buildings in renovation. It is available at the dropdown on the circularity tab:

<figure><img src="/assets/images/releasenotes/202605-13383-1.png" alt="The materials flows Sankey diagram on account level."><figcaption>The materials flows Sankey diagram on account level.</figcaption></figure>

* See products when clicking on the graph in env with material/products selected; it is now possible to see the products when you are in the environmental tab on a building and having selected the view for materials/products:

<figure><img src="/assets/images/releasenotes/202605-13386-1.png" alt="Overview of products from the material/product view."><figcaption>Overview of products from the material/product view.</figcaption></figure>

### Adding elements outside of elements in an original source file ###

In the dossier of a building it is now possible to add a virtual file:

<figure><img src="/assets/images/releasenotes/202605-13372-1.png" alt="Adding a virtual file."><figcaption>Adding a virtual file.</figcaption></figure>

For both virtual files and excel source files it is possible to add elements directly:

<figure><img src="/assets/images/releasenotes/202605-13372-2.png" alt="The option to add elements manually."><figcaption>The option to add elements manually.</figcaption></figure>

When adding elements it is possible to filter on products. While selecting products a separate box is shown from which you can see/manage the selection:

<figure><img src="/assets/images/releasenotes/202605-13372-3.png" alt="Selecting products to add as elements to a building."><figcaption>Selecting products to add as elements to a building.</figcaption></figure>

Once products are selected it is possible to adjust the values, such as phase and quantity:

<figure><img src="/assets/images/releasenotes/202605-13372-4.png" alt="Adjusting the values of the selected elements."><figcaption>Adjusting the values of the selected elements.</figcaption></figure>

### Country specific ###

* Onvoorzien hergebruik; for MPG buildings the reuse % on element has been replaced with a 'unforeseen reuse' toggle as used in the MPG calculation rules:

<figure><img src="/assets/images/releasenotes/202605-13352-1.png" alt="The toggle for unforeseen reuse on an element."><figcaption>The toggle for unforeseen reuse on an element.</figcaption></figure>

The calculation was already done according to the rules but now it is more clear in the UI as well.

### API 4.0 ###

The API has been updated substantially. For further information please see our <a href="https://api.madaster.com/" target="_blank">OpenAPI documentation</a> and apply for the <a href="https://docs.madaster.com/gb/en/api/#stay-up-to-date" target="_blank">Newsletter</a>.

## Release notes 2026.4 ##

* Build number: 39222
* Release date: 4th of May 2026

### Changes ###

* Comments searchable in enrichment; if there is a comment on your element you can now search on it in enrichment. The whole comment is searchable:

<figure><img src="/assets/images/releasenotes/202604-13302-1.png" alt="Search results with comments searchable."><figcaption>Search results with comments searchable.</figcaption></figure>

* Sankey in PNG; it is now possible to export the Sankey diagram from the building process table in .png. This is available for both Sankey diagrams.

<figure><img src="/assets/images/releasenotes/202604-13233-1.png" alt="The export button on a Sankey diagram."><figcaption>The export button on a Sankey diagram.</figcaption></figure>

* Copy paste rows or tables on environmental information on a product; if you have the environmental information of a product in a table (from an excel or a webpage like the product information on Okobaudat) you can now copy a whole row or table at once in the platform. It is now also possible when editing the data to hide columns or to empty them. When hiding there is the option to unhide as well. When copy pasting, keep in mind that the number of columns need to match.

<figure><img src="/assets/images/releasenotes/202604-13325-1.png" alt="The new options to hide or unhide columns, as well as emptying a column."><figcaption>The new options to hide or unhide columns, as well as emptying a column.</figcaption></figure>

<figure><img src="/assets/images/releasenotes/202604-13325-2.png" alt="Copying a whole table from a webpage."><figcaption>Copying a whole table from a webpage.</figcaption></figure>

* Default element phase has been added to the upload presets; this was already possible in the regular upload of a building file.

* For IFC v2 exports from Archicad we will now strip the prefix from the material properties in case the prefix is identical to the material name so that if you want to map the property in for example your upload settings you have a singular reference which works.

### Country specific ###

* For the Netherlands a dashboard has been added for Het Nieuwe Normaal:

<figure><img src="/assets/images/releasenotes/202604-13070-1.png" alt="The new dashboard for 'het nieuwe normaal'."><figcaption>The new dashboard for 'het nieuwe normaal'.</figcaption></figure>

* For the UK the infrastructure preview feature has been made available as well as some additional infrastructure objects

<figure><img src="/assets/images/releasenotes/202604-13317-1.png" alt="The infrastructure preview feature."><figcaption>The infrastructure preview feature.</figcaption></figure>

<ul>The additional objects are categorized as "Electricity Infrastructure" with options for "Converter station" and "Switch station":</ul>

<figure><img src="/assets/images/releasenotes/202604-13317-2.png" alt="The new energy infrastructure options."><figcaption>The new energy infrastructure options.</figcaption></figure>

<ul>Additionally, the fields on the "power cable" have been changed.</ul>

* For Germany the default compliance has been changed to 15978 A2 when opening the environmental screen.

### Bugfixes ###

* The number of elements as shown in the mass tab would not always be correct; this has been fixed.
* When inputting environmental data on a product the number would incorrectly be rounded in case of 6 decimals; this has been fixed.


## Release notes 2026.3 ##

* Build number: 38161
* Release date: 28th of March 2026

### Showcases ###

Available for all but especially for Producers and Austrian Circularity Leaders we introduced the possibility to share an object as a showcase with all users of your countries platform. Meaning every user within your country will get reading access to the published object. Our teams use it to share our **Demo models** with you. If you are interested to share insights on your object(s) please contact your local supportteam.

If the feature is enabled go to the 'Users' tab of the object and click on 'Make available to all platform users'.
<figure><img src="/assets/images/releasenotes/202603-13143-1.png" alt="Publish your object as a showcase."><figcaption>Publish your object as a showcase.</figcaption></figure>

The object will appear in the navigationlist on the left of each user and a tag will mark it as 'Showcase'. This tag will also make it easier for you as the owner to recognize that it is shared.
<figure><img src="/assets/images/releasenotes/202603-13143-2.png" alt="Tag to mark the status of an object."><figcaption>Option to revoke the publication of your object as a showcase.</figcaption></figure>

### Update and new filters for system databases ###

The following databases were updated:
* ENVIRONDEC
* IBU DATA
* KIWA
* MRPI
* and ÖKOBAUDAT

And if available information on
* Functional Lifespan
* Publication date
* FreeClass
* and IBUCategories
were copied and can now be filtered for.

### Individual database visible in the general tab ###

Apart from being shown in the navigation list on the right, databases are now also shown in the general tab of the level they were created in, meaning on account or folder level.

<figure><img src="/assets/images/releasenotes/202603-12354.png" alt="Databases in the general tab of an account."><figcaption>Databases in the general tab of an account, folder or object.</figcaption></figure>

### Show quantitysets (IFC) ###

In the 3D tab and in the enrichment the platform shows all propertysets of a selected element. Now we also included the quantitysets 'BaseQuantities' and 'Qto[...]BaseQuantities'. This offers further insight since those set often contain the geometrical information of an element. 

<figure><img src="/assets/images/releasenotes/202603-13184-1.png" alt="Example quantityset in the 3D tab"><figcaption>Example for a quantityset shown in the 3D tab.</figcaption></figure>

<figure><img src="/assets/images/releasenotes/202603-13184-2.png" alt="Example quantityset in the enrichment"><figcaption>Example for a quantityset shown in the enrichment.</figcaption></figure>

### Country specific ###
* NL: For new Dutch buildings there is the option to generate a HNN report in the 'General' tab.
* CH: The new version of the KBOB (2009/1:2022, Version 8.0) is available in Madaster.

### Bugfixes ###
* QNG: C3+C4 included in LCA again


## Release notes 2026.2 ##

* Build number: 37547
* Release date: 21st of February 2026

### Reset filters ###

It is now possible to reset or clear all filters in enrichment or database overviews:

<figure><img src="/assets/images/releasenotes/202602-11479-1.png" alt="The option to reset your filters when viewing a database."><figcaption>The option to reset filters when viewing a database.</figcaption></figure>

<figure><img src="/assets/images/releasenotes/202602-11479-2.png" alt="The option to reset your filters when viewing a database."><figcaption>The option to clear filters in enrichment.</figcaption></figure>

### Show individual search criteria in enrichment ###

If a search criterion was created when linking from enrichment it is now possible to view on the search criterion whether it was applied to the building or account level:

<figure><img src="/assets/images/releasenotes/202602-12743-1.png" alt="Search criterion definition when viewing the linked product in enrichment."><figcaption>Search criterion definition when viewing the linked product in enrichment.</figcaption></figure>

### Changes to deleting an object ###

When deleting an object which has designs and/or archives there is now an option to select which of these to delete as well. By default designs will be deleted and archives will not:

<figure><img src="/assets/images/releasenotes/202602-12996-1.png" alt="The new pop-up screen when deleting an object."><figcaption>The new pop-up screen when deleting an object.</figcaption></figure>

### Unit shown when editing an element in enrichment ###

We have added the unit to the dimensions when editing an element in the enrichment screen:

<figure><img src="/assets/images/releasenotes/202602-13011-1.png" alt="The unit shown when editing an element in enrichment."><figcaption>The unit shown when editing an element in enrichment.</figcaption></figure>

### Country specific ###

* There is now an QNG excel export available:

<figure><img src="/assets/images/releasenotes/202602-12823-1.png" alt="The button to generate the QNG excel report."><figcaption>The button to generate the QNG excel report.</figcaption></figure>

### Bugfixes ###

* Downcycled not being calculated properly when in BoM


## Release notes 2026.1 ##

* Build number: 37037
* Release date: 17th of January 2026

### UI/UX Changes ###

* For infrastructure objects the lifespan table for layers has been removed:

<figure><img src="/assets/images/releasenotes/202601-12887-1.png" alt="This table is no longer availabe for infrastructure objects."><figcaption>This table is no longer availabe for infrastructure objects.</figcaption></figure>

* The area definition used in schemes will be used throughout the building, for example in the financial tab, where possible

### Country Specific ###

* For QNG a help for calculating the impact of PV for energy has been added for residential buildings:

<figure><img src="/assets/images/releasenotes/202601-12859-1.png" alt="The monthly PV calculation help."><figcaption>The monthly PV calculation help.</figcaption></figure>

* For DGNB the PENRT will now be shown in the environmental tab as kWh/m2 NRF a instead of MJ/m2 NRF
* DGNB detachability has been added, including in the GRP
* It is now possible to add the 'sockelbetrag' for DGNB:

<figure><img src="/assets/images/releasenotes/202601-12829-1.png" alt="The monthly PV calculation help."><figcaption>The monthly PV calculation help.</figcaption></figure>


## Older release notes ##

More information about the releases can be found here:

* <a href="./release-notes-2025" target="_blank">Release notes 2025</a>
* <a href="./release-notes-2024" target="_blank">Release notes 2024</a>
* <a href="/files/en/Madaster Release notes 2023.pdf" target="_blank">Release notes 2023</a>
* <a href="/files/en/Madaster Release notes 2022.pdf" target="_blank">Release notes 2022</a>
* <a href="/files/en/Madaster Release notes 2021.pdf" target="_blank">Release notes 2021</a>
