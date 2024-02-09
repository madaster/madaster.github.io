---
title: Release notes
description: More information about the releases can be found here
ref: release-notes
type: Resources
menubar: resources-nav
---

This page contains the release notes.

## Release notes 2024.1 ##

* build number: 25710
* Releasedate: 8th of February 2024

<!--## Internal release notes ##

### Activate on-demand feature as super user ###

As a superuser it is now possible to turn on on-demand features:

![as a super user, on-demand feature can be activated](/assets/images/releasenotes/202401-9691.png)
*screenshot of the feature screen when logged in as a superuser. You can now turn on the features and the red text is not shown to superusers*

### Docs 2.0 ###

This release docs 2.0 will go live. Development will supply the documentation in English.

## Country-specific Release notes ##

* The DGNB label has been added to the building form for Germany and Austria
* The building service phase has been added to the building form for Austria

## External release notes ##-->

### Save viewpoint in 3D-viewer ###

It is now possible to save your viewpoint in the 3D-viewer:

![saving your viewpoint in the 3D viewer](/assets/images/releasenotes/202401-9686.png)

It is possible to undo your viewpoint and choose a new one. The chosen viewpoint will be the default when opening the 3D viewer or the general tab.

### Changes in datasources for financial information ###

For the following datapoints the source has been changed or fixed:

* Inflation for the EuroZone, UK and US
* US Dollar Chinese Yuan exchange rate
* Pricessets for Wool, Rubber and Timber

### Searching for child elements in enrichment ###

It is now possible to search for child elements in enrichment. Note that the result will show the parent in which the child contains the match on the search. It is also possible to search on child ID's.

![Finding results in child elements](/assets/images/releasenotes/202401-8784.png)

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
