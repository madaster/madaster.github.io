---
title: Arbeitsmethoden
description: Mögliche Arbeitsmethoden mit Elementen aus mehreren Materialien
ref: work-processes
type: Knowledge Base
menubar: knowledge-base-nav
---

Madaster bietet vielfältige Möglichkeiten zur Nutzung der Plattform, sodass jeder Anwender seinen optimalen Workflow finden kann.

## Materialzusammensetzungen von Elementen

Im Folgenden stellen wir verschiedene Optionen für den Umgang mit Elementen aus unterschiedlichen Materialien vor. Dies kann bei der Erstellung des BIM-Modells berücksichtigt oder die Elemente innerhalb der Plattform aufgeteilt werden. Alternativ kann eine Komponente oder ein Produkt erstellt und verwendet werden, das das Verhältnis der verwendeten Materialien widerspiegelt.

### 1. Darstellung von Materialzusammensetzungen im BIM-Modell

#### 1.1 Verwendung des Materialbestandteilsatzes

Mit einem <a href="https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/concepts/Object_Association/Material_Association/Material_Constituent_Set/content.html" target="_blank">Material Constituent Set (IFC 4.3.2 Documentation)</a> können Sie jedem IfcMaterialConstituent ein Material und einen Anteil zuweisen. Dadurch kann Madaster das Element in „virtuelle“ Unterelemente pro Material aufteilen.

#### 1.2 Verwendung der Material-Layer-Sets

Mit der <a href="https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/concepts/Object_Association/Material_Association/Material_Layer_Set_Usage/content.html" target="_blank">Material Layer Set Usage (IFC 4.3.2 Documentation)</a> können Sie jedem IfcMaterialLayer ein Material und eine Schichtdicke zuweisen. Dadurch kann Madaster die Materialverhältnisse berechnen und das Element in „virtuelle“ Unterelemente pro Material aufteilen.


#### 1.3 Verwendung des Materialprofilsatzes

Mit dem <a href="https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/concepts/Object_Association/Material_Association/Material_Profile_Set_Usage/content.html" target="_blank">Material Profile Set Usage (IFC 4.3.2 Documentation)</a> können Sie jedem IfcMaterialProfile ein Material und ein Profil zuweisen. Dadurch kann Madaster auch Materialverhältnisse berechnen und das Element in „virtuelle“ Unterelemente pro Material aufteilen.


#### 1.4 CPset_Madaster verwenden

Sie können das <a href="../knowledge-base/madaster-property-set.html" target="_blank">CPset_Madaster</a> zu Elementen in Ihrem Projekt hinzufügen und mithilfe von MaterialOrProductName und MaterialOrProductRatio die Aufteilung eines Elements in „virtuelle“ Unterelemente aktivieren.

Weitere Informationen finden Sie in unserem **BIM-Handbuch** im <a href="../resources/downloads" target="_blank">Downloadbereich</a>.

#### 1.5 Jede Materialschicht separat modellieren

Bei diesem Ansatz erhält jede Schicht eine eigene eindeutige ID (UID) und wird somit als einzelnes, „echtes“ Unterelement in der Plattform behandelt.

### 2. Elemente in der Plattform aufteilen

Wenn Sie die Materialien eines Elements innerhalb der Plattform aufteilen müssen, verwenden Sie die Funktion **Aufteilen** im Bereich „Anreicherung“.

**So geht's:**

1. Aktivieren Sie das Kontrollkästchen vor dem Element, das Sie aufteilen möchten.

2. Klicken Sie auf die Schaltfläche „Element aufteilen“ <iconify-icon inline icon='mdi-set-split'/> in der Symbolleiste am unteren Bildschirmrand.

3. Ein Dialogfenster öffnet sich, in dem Sie das Element anhand seiner Basismengen aufteilen können.

> <u>Hinweis</u>: Es können nur einzelne Elemente aufgeteilt werden. Wenn also alle Elemente eines Typs über die Anreicherung aufgeteilt werden sollen, muss jedes Element einzeln ausgewählt und aufgeteilt werden.

### 3. Produktdatensätze für mehrere Materialien

Falls das gewünschte Produkt, das aus mehreren Materialien besteht, nicht in den Datenbanken der Plattform verfügbar ist und keine geeignete EPD zur Erstellung dieses Produkts gefunden werden kann, besteht die Möglichkeit, individuelle, benutzerdefinierte Produktdatensätze in Ihren Kontodatenbanken anzulegen.
#### 3.1 Produkt einrichten

Die erste Option ist die Erstellung eines <a href="../knowledge-base/databases-products.html" target="_blank">Produkt</a> mit einer <a href="../knowledge-base/databases-products.html#bill-of-materials-tab" target="_blank">Stückliste (BoM)</a>. Das bedeutet, dass die Kreislauf- und Umweltwerte dieses erstellten Produkts auf den Produkten in der Stückliste basieren.

Wenn die Systemdatenbanken beispielsweise die richtigen Materialien, aber kein Produkt mit der passenden Kombination oder dem richtigen Verhältnis enthalten, können Sie ein eigenes Produkt erstellen.

#### 3.2 Komponente einrichten

<a href="../resources/release-notes#release-notes-20257" target="_blank">Komponenten</a> funktionieren etwas anders als Produkte mit Stückliste. Materialklassifizierungen, Umweltdaten und Finanzdaten werden ausschließlich aus der Stückliste abgeleitet. Bei dieser Verwendung eines Produkts nutzt und zeigt die Plattform für die Berechnungen die niedrigste Ebene der Stückliste an.

Wenn beispielsweise ein Ökobaudat-Produkt eingebunden ist, wird dieses Produkt in der Umweltansicht für die Wirkungsberechnungen angezeigt.

Dieser Ansatz ist für Zertifizierungsaudits nützlich, da die Kontendatenbank und die Komponente selbst nicht angezeigt werden.

### Alternativer Workflow

Madaster unterstützt <a href="../resources/release-notes-2024.html#support-for-element-combination-in-if" target="_blank">**Elementkombinationen in IFC**</a>.

Wenn Materialfamilien als separate IFC-Elemente exportiert werden, können Sie IFC-Eigenschaften definieren, die Madaster ausliest, um diese Elemente in eine Eltern-Kind-Struktur zu rekombinieren.

Verwenden Sie die Eigenschaften **ElementInstanceCombinationId** und **ElementCombinationType** in CPset_Madaster oder definieren Sie eigene Eigenschaftssätze und -namen im Upload-Preset.

Bei Anwendung erstellt Madaster ein virtuelles übergeordnetes Element, das alle Elemente mit derselben ID unter diesem Element gruppiert. Der ElementCombinationType definiert Name und Typ des Elements.
Feedback geben