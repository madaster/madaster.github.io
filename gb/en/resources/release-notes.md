---
title: Release notes
description: More information about the releases can be found here
ref: release-notes
type: Resources
menubar: resources-nav
---

This page contains the release notes for 2025.

## Release notes 2025.6 ##

* Build number: 34594
* Release date: 26th of July 2025

### Multiple price sets on a product ###

When a product consists of multiple materials that are each connected to a priceset this was not shown as such when looking at the product level. An overview of the different price trends and price sets for the different materials have been added to the product:

<figure><img src="/assets/images/releasenotes/202506-12126-1.png" alt="The changes in the financial tab on a product."><figcaption>The changes in the financial tab on a product.</figcaption></figure>

Also, the price shown on the product when the digital product passport feature is active reflects the material composition:

<figure><img src="/assets/images/releasenotes/202506-12126-2.png" alt="Nominal value as shown on the product when the digital product passport feature is turned on."><figcaption>Nominal value as shown on the product when the digital product passport feature is turned on.</figcaption></figure>

### Changes to matching and enrichment ###

* Matching elements with weight on products with other functional units, but for which density is known is now possible. So, if you have an element with a weight and you connect it with a volume product that has a known density the volume is now calculated based on the weight so that the platform knowns how much of the product you are using and which impacts it has.

* Only changed for the excel upload: when the area and thickness is known the volume will now be calculated, so matching with a volume product when these characteristics are available (but not the volume) gives results.

* IFC class has been added to the element properties overview:

<figure><img src="/assets/images/releasenotes/202506-12152-1.png" alt="IFC Class as shown in the element property overview from enrichment."><figcaption>IFC Class as shown in the element property overview from enrichment.</figcaption></figure>

* Clicking text will activate or deactivate the filter, instead of only clicking the circle:

<figure><img src="/assets/images/releasenotes/202506-12095-1.png" alt="Text clickable part to turn the filter on or off."><figcaption>Text clickable part to turn the filter on or off.</figcaption></figure>

* If an element in an IFC has only one material and the material contains the detachability information this is now correctly read in in Madaster.

### Need to reindex old source files ###

For performance reasons old source files that:

* Have not been used for more than 18 months
* For archives or deactivated source files this is 3 months 

Will need to be reindexed before being able to manually enrich it again:

<figure><img src="/assets/images/releasenotes/202506-12044-1.png" alt="The notification and reindex option on the source file."><figcaption>The notification and reindex option on the source file.</figcaption></figure>

### Search added for manufacturers in product databases ###

In a product database it is now possible to search for a specific manufacturer:

<figure><img src="/assets/images/releasenotes/202506-12169-1.png" alt="Searching for products from a specific manufacturer in a product database."><figcaption>Searching for products from a specific manufacturer in a product database.</figcaption></figure>

### Use coordinates for adding the location of a building ###

It is now possible to add the location of the building by using the coordinates:

<figure><img src="/assets/images/releasenotes/202506-9728-1.png" alt="Adding the location through coordinates."><figcaption>Adding the location through coordinates.</figcaption></figure>

### Country specific ###

* German translations have been added to the Madaster CP_set
* Usable net heated floor area has been added to DACH buildings. This is also needed for the B6.3 calculations for the QNG Residential scheme, which has been adjusted accordingly.
* The amount of elements shown to have an unknown classification is for Germany and Austria no longer based on the shearing layers but on the actual classification used.
* For Switzerland it is now possible to set up multiple bechmarking values when choosing the Ecobau scheme:

<figure><img src="/assets/images/releasenotes/202506-12239-1.png" alt="Setting up the benchmarking values for Ecobau."><figcaption>Setting up the benchmarking values for Ecobau.</figcaption></figure>

These are shown on the environmental tab as well.

* Museum and Restaurant have been added as building usages to Switzerland
* The KBOB has been update to the latest version

### Bugfixes ###

* EU Taxonomy reports could not be generated on a design, this has been changed
* Detachability scores for the services layer were not displayed correctly, which has been fixed
* It was not possible to immediately select a certification scheme when creating a building, now it is
* Certification information was not properly displayed in the general tab on the building, this is fixed
* When editing a passport preset cancelling you still save the changes, this is fixed
* When choosing a compliance a incorrect choice could be shown in a number of screens, which has been fixed
* Changing handling cost was not always saved, this is fixed


## Release notes 2025.5 ##

* Build number: 33804
* Release date: 6th of June 2025

### Changes to the Bill of Materials on a product ###

This release a few changes have been made to the interaction with the bill of materials on a product:

* When adding a product to the bill of materials the product overview will now immediately open
* A description field has been added for each added product in the bill of materials:

<figure><img src="/assets/images/releasenotes/202505-BoM-1.png" alt="The new description field on the bill of materials."><figcaption>The new description field on the bill of materials.</figcaption></figure>

* It is now possible to change the sequence of the products in the bill of materials:

<figure><img src="/assets/images/releasenotes/202505-BoM-2.png" alt="Changing the sequence in the bill of materials."><figcaption>Changing the sequence in the bill of materials.</figcaption></figure>

### Selecting a Compliance Scheme

When creating a building, you can now use the drop-down menu on the Labels tab (also accessible via the General tab) to select which compliance scheme you want to follow. 
<figure><img src="/assets/images/releasenotes/202505-Schemes.png" alt="When editing the building a compliance scheme can be choosen."><figcaption>When editing the building a compliance scheme can be choosen.</figcaption></figure>
In the following, values that are mandatory for the calculations are queried according to the respective selection.

### New Benchmark Card

The first change in the benchmarking and comparison functionality has been implemented. With this release, you will find a separate card in the Environmental tab that provides more detailed information about the benchmark you have selected.

* How many buildings in your account/folder/of a certain type are considered for your benchmark and how much is the current building above or below this benchmark?
* Or which individual buildings (including their comparative values) have you selected for your benchmark and how much is the current building above or below this benchmark?

<figure><img src="/assets/images/releasenotes/202505-Benchmarking.png" alt="The new Benchmark card offers further details."><figcaption>The new Benchmark card offers further details.</figcaption></figure>

### Other changes ###

* The Proca feature is now also available on non-producer databases
* In a number of EPD databases the owner of the EPD data has been set as the manufacturer
* A number of material classification mappings have been redone
* For German accounts it is now possible to choose B6.1, B6.2 or B6.3 when applying energy EPDs


## Release notes 2025.4 ##

* Build number: 33498
* Release date: 11th of May 2025

### Matching rules in enrichment ###

This release the options when linking an element to a product from enrichment have been changed: 

<figure><img src="/assets/images/releasenotes/202504-11869-1.png" alt="The new options when linking elements to products."><figcaption>The new options when linking elements to products.</figcaption></figure>

The options are:

* To directly link the current selected element to the chosen product
* To set up more elaborate matching rules based on your selection
* To change all elements current mapped to a certain product to the new selected product

A matching rule will link all elements to the chosen product based on certain properties of the element:

<figure><img src="/assets/images/releasenotes/202504-11869-2.png" alt="The matching rules."><figcaption>The matching rules.</figcaption></figure>

The options are:

* To link all elements with the same material name
* To link all elements with the same type (IfcElementType)
* To link all elements with the same generalized type (like IfcWallType, IfcRoofType)

It is possible to combine these options for a more granular mapping. It is also possible to include this matching rule as a search criteria on either the building or the whole account for future use.

### Redesign upload settings screen ###

The upload settings screen has been given a redesign to be more clear:

<figure><img src="/assets/images/releasenotes/202504-11426-1.png" alt="The matching rules."><figcaption>Part of the redesigned upload settings screen.</figcaption></figure>

### Other changes ###

* The maximum number of elements shown in enrichment has been set to 500.
* The column type name has been added to the excel export of an ifc file.

### Bugfixes ###

* It was possible to delete source files that were being processed when selecting multiple files, this is fixed.
* The checkbox for 'allow elements to match with products of different dimensions or quantities' on the upload settings would be unchecked when reopening the screen or applying it when uploading a file. This has been fixed.
* Uploading a new version of a source file could crash when splitted elements were kept and new elements were added. This has been resolved.
* A rare bug in paging could result in duplicate elements; this is resolved.


## Release notes 2025.3 ##

* Build number: 33047
* Release date: March 31st 2025

### IFC hierarchy now available in enrichment ##

With this release it is now possible to filter on the IFC hierarchy in enrichment:

<figure><img src="/assets/images/releasenotes/202503-11382-1.png" alt="The IFC Hierary in the filters in enrichment"><figcaption>The IFC Hierarchy in the filters in enrichment.</figcaption></figure>

This makes finding the right set of elements quicker based on the IFC structure.

There is also the option to quickly link a product to elements that share the same type and material:

<figure><img src="/assets/images/releasenotes/202503-11382-2.png" alt="Linking a product to all elements that have the same type and material."><figcaption>Linking a product to all elements that have the same type and material.</figcaption></figure>

This means that is should be quicker to assign a product to elements that according to the IFC model would make sense to be connected to the same product.

Existing models are not updated, so this will only show up for new models or reuploaded models.

### View quality of all source files from dossier ##

The option to view the quality of all the source files is now available from the dossier on a building. It used to be an option in the mass tab only.

<figure><img src="/assets/images/releasenotes/202503-11568-1.png" alt="Option to view the quality of all source files."><figcaption>Option to view the quality of all source files.</figcaption></figure>

### Editing multiple documents ##

It is now possible to edit multiple documents by selecting multiple files in for example the dossier of a building:

<figure><img src="/assets/images/releasenotes/202503-11423-1.png" alt="Editing multiple source files."><figcaption>Editing multiple source files.</figcaption></figure>

### Additional properties added to elements ###

New properties have been added that can be filled on the element. These are:

* Serial number; which can be used to specify more specifically the products that are installed
* Installation date; which can be used to specify on which date the product was installed. When this information is available it is used in B4 calculations as well.
* Technical condition: a high-level indicator for in what technical condition the installed product/element is
* Aesthetic condition: a high-level indicator for in what aesthetic condition the installed product/element is
* Comment: a free text field for commenting on the installed product or the element.

These fields can be filled in on the new details tab on an element:

<figure><img src="/assets/images/releasenotes/202503-11430-1.png" alt="The new details tab on an element in enrichment."><figcaption>The new details tab on an element in enrichment.</figcaption></figure>

They are also added to the excel upload templates for buildings, as well as the excel export/import functionality. These fields are now also available in the upload settings.

These new properties are also exported when generating a technical annex.

### Changes to the upload presets ###

The following options have been added to the upload presets:

Above mentioned new properties on the element:
* Serial number
* Comment
* Technical condition
* Aesthetic condition
* Installation date

<figure><img src="/assets/images/releasenotes/202503-11430-2.png" alt="The new element properties in the upload presets screen."><figcaption>The new element properties in the upload presets screen.</figcaption></figure>

Another addition to the upload presets are the basic dimensions:
* Volume
* Area
* Length
* Width

<figure><img src="/assets/images/releasenotes/202503-11678-1.png" alt="The basic dimensions in the upload presets screen."><figcaption>The new basic dimension in the upload presets screen.</figcaption></figure>

### Changes to the upload screen ###

There are two new options added when uploading a source file.

1. When there is no phase information available on the element it is possible to set the default that will be filled in when uploading a file to the platform. There is a prefilled default selected based on the phase of the building. For example, when a building is new, the default phase will be prefilled with 'new' as well. This can still be changed though.

<figure><img src="/assets/images/releasenotes/202503-11461-1.png" alt="The option to set a default element phase in the upload screen."><figcaption>The option to set a default element phase in the upload screen.</figcaption></figure>

2. Another new option is the choice to match products on elements when the dimensions or quantities differ. This is off by default to prevent having to re-link after uploading, but can be turned on:

<figure><img src="/assets/images/releasenotes/202503-11572-1.png" alt="The option to match elements on products with different dimensions or quantities yes or no."><figcaption>The option to match elements on products with different dimensions or quantities yes or no.</figcaption></figure>

### Other changes ###

* The ICE database has been updated to the latest version.
* The ENVIRONDEC database has been updated.
* It is now possible to select multiple accounts when sharing a database with an account.
* Details on where a search criterion is matched on is now shown in the overview of search criteria on a product in a database.
* On a database it is possible to set whether inactive products should be shown by defaut in the overview.

## Release notes 2025.2 ##

* Build number: 32489
* Release date: February 22nd 2025

### Draft products ###

It is now possible to put a product in a database in draft when you are still working on it:

<figure><img src="/assets/images/releasenotes/202502-11446-1.png" alt="Putting a product in draft"><figcaption>Putting a product in draft.</figcaption></figure>

Draft products are active products and have their own filter (publication status). A tag is shown as well to make it clear the product is in draft:

<figure><img src="/assets/images/releasenotes/202502-11446-2.png" alt="A product in draft in a product overview"><figcaption>A product in draft in a product overview</figcaption></figure>

Draft products cannot be used to link to elements. Once a product has been used in a building it cannot be put in draft again.

### Assumed waste codes ###

If the Madaster platform has assumed waste codes of a product, based on for example the material composition, these will be shown in enrichment:

<figure><img src="/assets/images/releasenotes/202502-11340-1.png" alt="The assumed waste codes"><figcaption>The assumed waste codes as shown in enrichment</figcaption></figure>

If the assumed waste code is correct it is possible to quickly add it to the element so it is actually connected to the element and will appear in reports:

<figure><img src="/assets/images/releasenotes/202502-11340-2.png" alt="Adding the assumed waste code"><figcaption>Adding the assumed waste code</figcaption></figure>

### Other changes ###

* It is now possible to directly generate the technical annex when using the 'generate report' button on a building:

<figure><img src="/assets/images/releasenotes/202502-11394-1.png" alt="Generating the technical annex"><figcaption>Option to generate the technical annex</figcaption></figure>

* The Madaster ID and external ID are no shown on a product in the platform when the product passport feature is active.

* It used to be necessary to have detachability filled in before you could fill in the percentage of 'available for reuse' on the circularity values of a product. This is no longer necessary.

* We have updated the 3D functionality so it can work better with big source files.

* It is now possible to set the following IFC properties in the upload settings:

<figure><img src="/assets/images/releasenotes/202502-11301-1.png" alt="Name and Type Name in upload settings"><figcaption>Name and Type Name in upload settings</figcaption></figure>

## Release notes 2025.1 ##

* Build number: 31984
* Release date: January 10th 2025

### UI updates ###

Numerous updates have been made to the user interface in this version. Main and secondary actions can now be found in the same places. This standardises forms and thus contributes to user friendliness.

<figure><img src="/assets/images/releasenotes/202501-forms-2.png" alt="New interface of forms"><figcaption>Example of the new interface of forms.</figcaption></figure>

### Import progress bar

Users get a better insight into how far the upload of an ifc source file to the platform has progressed.

<figure><img src="/assets/images/releasenotes/202501-progress bar-7.png" alt="New progress bar"><figcaption>New progress bar showing status of ifc import process.</figcaption></figure>

### Technical Annex on elements

In addition to the annex at product level, it is now possible to export a technical annex at element level. This is useful for checking the correct allocation of each element of an ifc file. In addition, you can get more detailed information about what the calculated results are based on.

### Country specific

* For Germany, the lifespan of a building that is taken into account in the environmental calculation can now deviate from the 50 years (specified by the DGNB). 
* Some products in the EPEA database were updated so that they are also available for the United Kingdom, Netherlands, Norway and Switzerland now.

## Older release notes ##

More information about the releases can be found here:

* <a href="/gb/en/resources/release-notes-2024" target="_blank">Release notes 2024</a>
* <a href="/files/en/Madaster Release notes 2023.pdf" target="_blank">Release notes 2023</a>
* <a href="/files/en/Madaster Release notes 2022.pdf" target="_blank">Release notes 2022</a>
* <a href="/files/en/Madaster Release notes 2021.pdf" target="_blank">Release notes 2021</a>