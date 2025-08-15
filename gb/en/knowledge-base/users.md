---
title: Users
description: Invite users, establish permissions, and use the API
ref: users
type: Knowledge Base
menubar: knowledge-base-nav
---

Depending on the subscription every account has a certain number of active (Administrator, Manage & Contribute to database, Manager) users. To view the number of active users available, go to the **Subscriptions** Tab on account level (only visible for active users).
On the plattform it is possible to add users, with certain permissions at account-, folder- and building-level.
Users can be assigned a "legal role", meaning they have the legal responsibility to accept license terms of restricted producer databases. These are listed under the three dots in the menu, and in the page **Licensed databases**.
For more information on this, see the <a href="databases" target="_blank">Databases on Madaster</a>.

## Add users at account-level

Users invited at account-level will be given access to all existing and future folders, projects and objects within the account. Account-level users can be assigned one of the following permissions:

|Account level|Administrator|Manage & Contribute to database|Manager|Reader|Billing|
|-|-|-|-|-|-|
|Creating and modifying folder types| Yes| No| No| No| No|
|Creating folders| Yes| Yes| Yes| No| No|
|Creating databases| Yes| No| No| No| No|
|Contributions to database created on account or shared with account with at least contribution rights| Yes| Yes| No| No| No|
|Can view the subscription page| Yes| No| No| No| No|
|Can view the user page| Yes| No| No| No| No|


## Add users at folder-level

Users invited at folder-level will be given access to all sub-folders and projects within the selected folder. Folder-level users can be assigned one of the following permissions:

|Folder level |Administrator |Manage & Contribute to database|Manager|Reader|Billing|
|-|-|-|-|-|-|
|View folder and underlying buildings/folders| Yes| Yes| Yes| Yes| Yes|
|Create folders and subfolders| Yes| No| No| No| No|
|Modify folder and underlying buildings/folders| Yes| Yes| Yes| No| No|
|Delete folder and underlying buildings/folders| Yes| No| No| No| No|
|Add building to a folder (if foldertype allows building)| Yes| Yes| Yes| No| No|
|Add and remove users| Yes| No| No| No|   |
|Add database (folder level)| Yes| No| No| No| No|
|Contribute to database (folder level)| Yes| Yes| No| No| No|
|Export Material Passport| Yes| Yes| Yes| No| No|
|Download Material Passport to PDF| Yes| Yes| Yes| No| No|

## Add users at building-level

Users invited at building-level will be given access to only the selected building. Building-level users can be assigned one of the following permissions:

|Building level|Administrator|Manage & Contribute to database|Manager|Reader|Billing|
|-|-|-|-|-|-|
|View building| Yes| Yes| Yes| Yes| No|
|Modify building| Yes| Yes| Yes| No| No|
|Delete building| Yes| No| No| No| No|
|Add and remove users| Yes| No| No| No| No|
|Add database (building level)| Yes| No| No| No| No|
|Contributions to database created on building level or shared with the building with at least contribution rights(folder level)| Yes| Yes| No| No| No|
|Export Material Passport| Yes| Yes| Yes| No| No|
|Download Material Passport to PDF| Yes| Yes| Yes| Yes| Yes|

## Add API token


For more information on using the Madaster API, visit our <a href="../api/" target="_blank">API Documentation</a>.
