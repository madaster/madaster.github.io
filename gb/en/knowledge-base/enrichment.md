---
title: Enrichment
description: Tips for the enrichment process
ref: enrichment
type: Knowledge Base
menubar: knowledge-base-nav
---

Tips for the enrichment process.

To ensure a comprehensive assessment of an object on Madaster, each element should have at least a classification and sufficient geometry information, and should be linked to a product dataset. For further information see also <a href="../knowledge-base/quality-check.html#basic-consideration" target="_blank">Quality control</a>.

To check the results of the automatic mapping during the upload of the source file in detail, switch to the **Dossier** tab on object level and click 

1. either on the source file and then the button **Enrich <iconify-icon inline icon='mdi-link-variant-plus'/> (Manual)**

    OR

2. straight on the enrichment icon <iconify-icon inline icon='mdi-link-variant-plus'/> on the right next to the source file.

## Linking elements

Elements can be linked by automatic mapping or by manual mapping.

### 1. Automatic mapping

During the Automatic mapping the platform scans each element for certain information it could link on, which are basically:

1. **Madaster Id** - If there is a property with the Madaster ID of a specific product, the mapping process will prioritize this information.
2. **External Id** - This corresponds to the Madaster ID; however, if both are provided, the Madaster ID takes precedence.
3. **Material/Product name** - The material name is mapped if the product has the exact same name in the database or if similar terms have been entered as <a href="../knowledge-base/databases-products.html#search-criteria-tab" target="_blank">search criteria</a> for a product.

Automatic mapping occurs when uploading a new file <u>OR</u> when it is manually restarted by clicking on the source file and then **Enrich <iconify-icon inline icon='mdi-link-variant-plus'/> (Automatic)**.

### 2. Manual Mapping

Altertanitavely Manual Mapping allows to link each element individually or several elements at once. Check the box next to the element(s) and click  the icon <iconify-icon inline icon='mdi-link-variant'/>. A window will open showing all available databases, including the products. Select the product dataset you wish to link and click **Link**.

Another window will open showing the following options, which you can choose by checking the corresponding box.

1. Simply **link the selected elements**. Regardless of whether they are already linked or not. 

2. Link elements according to your own **Matching Rules** and save these rules for future automatic mapping.
You decide whether to link based on the material name <u>OR</u> the type name <u>OR</u> the IFC type <u>OR EVEN</u> a combination of several criteria.

> Note: Using the drop-down list on the right, you can choose whether to save this rule for future use – either for this specific object or for the entire account. The second option is useful if your projects are frequently modelled in the same way.

> Note: By checking the last box you can also include elements that are already linked.

3. Link all elements **mapped to a specific product**.

> Note: Select this option if, for example, you wish to replace a product with a more environmentally friendly or circular alternative.

<figure><img src="/assets/images/knowledgebase/Search criteria.png" alt="Options in the manual mapping process incl. matching rules."><figcaption>Options in the manual mapping process incl. matching rules.</figcaption></figure>

## Search within Enrichment

If you are looking for specific elements you will find **various filters** in the navigation list on the left as well as a search field.

In the **search field** on the top left you can look for 
* element names,
* typenames,
* element IDs,
* material names or
* content within the comments on the elements.

> Note: If you haven't used a comment in your IFC source file yet you can define any Property as comment via the <a href="../platform-pages/account/uploadpresets.html" target="_blank">Upload Preset</a>. This way you can enable other information to become searchable.

## Save your progress

Especially when working on long-term projects or in a team, it can be helpful to save a separate backup of the current and final version of a project. 

Of course, there is a backup of the entire platform to protect it from complete data loss due to a technical error. Furthermore, accidentally deleted items can be restored by our support team within 30 days before they are permanently deleted. However, <u>if data within a project is overwritten (e.g., by automatic remapping), it is not possible to restore the previous state</u>.

**Recommendations for Data Backup**

1. Use the **archive** feature to save intermediate versions of ongoing projects and/or the final state. Our support team can use an archive to restore at least this version as an active object. <br>
For information on setting up an archive, see <a href="../knowledge-base/stay-organized#manage-objects" target="_blank">Manage objects</a>.

2. Alternatively, you can create a **design** of an intermediate version or to test the impact of mapping other products. <br>
For information on setting up a design, see <a href="../knowledge-base/stay-organized#manage-objects" target="_blank">Manage objects</a>.

3. Another alternative is to upload the source file as a **new version** and keep the "older" version in the dossier’s file tree. The elements of each file could be mapped differently.