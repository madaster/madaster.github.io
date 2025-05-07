---
title: Release notes
description: Hier finden Sie Informationen zu den Entwicklungen bzw. Versionen der Plattform
ref: release-notes
type: Downloads
menubar: resources-nav
---

This page contains the release notes for 2025.

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

### Country specific

* The Gebäuderessourcenpass (DGNB) has been updated to version 1.2.1

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

For Germany, the **lifespan of a building** that is taken into account in the environmental calculation can now deviate from the 50 years (specified by the DGNB). 

## Older release notes ##

More information about the releases can be found here:

* <a href="/de/de/resources/release-notes-2024" target="_blank">Release notes 2024</a>
* <a href="/files/en/Madaster Release notes 2023.pdf" target="_blank">Release notes 2023</a>
* <a href="/files/en/Madaster Release notes 2022.pdf" target="_blank">Release notes 2022</a>
* <a href="/files/en/Madaster Release notes 2021.pdf" target="_blank">Release notes 2021</a>