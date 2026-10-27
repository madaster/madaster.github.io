---
title: Vorbereiten einer IFC-Quelldatei
description: Modellierungs- und Exporthinweise zu BIM-Modellen
ref: preparing-bim-ifc-source-files
type: Wissensdatenbank
menubar: knowledge-base-nav
---

Modellierungs- und Exporthinweise zu BIM-Modellen

## Allgemeine BIM/IFC-Richtlinien

Grundlage für die Auswertung und Erstellung eines Materialpasses auf der Madaster-Plattform ist eine strukturierte Quelldatei, in der Regel ein BIM-Modell im IFC-Format. Dieses Modell enthält detaillierte Daten des Objektes und bildet die zentrale Datengrundlage für das Madaster-Projekt.

Madaster verwendet den offenen IFC-Standard von buildingSMART, der als einheitliches Austauschformat für digitale Gebäudemodelle dient. Die IFC-Dateien werden während der Entwurfs-, Planungs- oder Renovierungsphase aus den nativen Dateien der BIM-Autorensoftware (Revit, ArchiCAD, Allplan, Vectorworks u. v. m.) erzeugt.

Damit ein BIM-Modell auf der Madaster-Plattform korrekt ausgewertet werden kann, sind bestimmte Modellierungsrichtlinien einzuhalten.

1. **Eindeutige GUIDs**
   - Jede GUID muss eindeutig sein.

2. **Geometrische Eigenschaften**
   - Exportieren Sie stets die Basismengen (geometrische Eigenschaften).

3. **Materialzuweisung**

   Allen Elementen muss ein Material zugewiesen werden. Hierfür stehen folgende Möglichkeiten zur Verfügung:

   - **Über die IfcMaterialSelect-Beziehung** (z. B. `IfcMaterial`).

     Falls vorhanden, werden die Parameter aus den `IfcMaterialProperties` des zugewiesenen Materials automatisch auf das Element übertragen.

   - **Alternativ:** Hinterlegung direkt auf Elementebene im Property Set `CPset_Madaster`.

4. **Klassifizierung**

   Allen Elementen muss eine Klassifizierung zugewiesen werden (z. B. nach DIN 276, eBKP-H oder ÖNORM 1801-1).

   Die Zuordnung erfolgt:
   - Über `IfcClassificationReference` oder `IfcExternalReference`.
   - Falls nicht vorhanden, erfolgt ein Abgleich über den Layer des Elements (`IfcPresentationLayerAssignment`).

5. **IFC-Entitäten**
   - Weisen Sie jedem Bauteil die korrekte IFC-Entität zu.
   - Vermeiden Sie `IfcBuildingElementProxy` und `IfcBuildingElementPart`.

6. **Bauphase**

   Exportieren Sie die Bauphase im Property `Phase` mit folgenden Werten:

   | Deutsch | Englisch |
   |---|---|
   | Rückbau | Demolition |
   | Einbau / Neu | New materials |
   | Verbleibend | Preserved |
   | Bauabfälle | Construction Waste |

7. **IFC-Exportformat**
   - Verwenden Sie vorzugsweise das Exportformat **IFC 4**, alternativ **IFC 2x3**.

8. **Projektnullpunkt**
   - Stellen Sie sicher, dass der Projektnullpunkt mit einer Koordinate verknüpft ist.

> Ausführliche Informationen finden Sie in unserem **Madaster BIM-Handbuch** unter <a href="../resources/downloads" target="_blank">Downloads bei Handbücher und Vorlagen</a>. Dort finden Sie ebenfalls hilfreiche Dateien und Informationen für Allplan, Revit, ArchiCAD und Vectorworks.

## ArchiCAD IFC-Quelldateien vorbereiten

Um sicherzustellen, dass Ihre Datei für den Import geeignet ist, muss sie den BuildSmart-Standards entsprechen. Unter <a href="https://ucm.buildingsmart.org/use-case-details/2594/en" target="_blank">BIM Basic IDS</a> finden Sie eine ausführliche Anleitung. Beachten Sie darüber hinaus das <a href="https://docs.madaster.com/files/de/madaster%20GER_BIM%20Anleitung.pdf" target="_blank">Madaster-BIM-Handbuch</a>.

1. Lesen Sie die <a href="https://docs.madaster.com/files/de/BIM%20basis%20ILS_infographicA4_German.pdf" target="_blank">BIM Basic IDS</a> von Madaster für alle IFC-Quelldateien.
2. **Klassifizierung hinzufügen:**
  * Madaster verwendet einen Klassifizierungscode, um die Elemente in Gebäudeschichten zu sortieren, die Standardklassifizierungsmethode variiert von Land zu Land.
  * Diese Notation kann in der Kategorie und den Eigenschaften in den Selektionseinstellungen eines Objekts hinzugefügt werden. In diesem Fenster müssen Sie IFC-Eigenschaften verwalten öffnen und die Option Vordefinierte Regel anwenden aktivieren. In diesem letzten Fenster können Sie die Kodierung und den Detaillierungsgrad (Anzahl der Ziffern des Codes) aktivieren. Der letzte Schritt besteht nun darin, anzugeben, welche Kodierung das Objekt hat.
  * Alternativ dazu können Sie sich das  <a href="/de/de/knowledge-base/madaster-property-set.html#madaster-archicad-eigenschaftssatz-cpset_madaster" target="_blank">Madaster Pset</a> herunterladen und in Archicad importieren.
3. **Materialien hinzufügen**
  * Für eine exakte Auswertung sollten alle modellierten Elemente eine Materialbeschreibung besitzen, die in Archicad in den Baustoffen mit der Option *individuelles Material hinzuzufügen* definiert wird.
  * Wichtig ist, dass die verwendeten Materialien einen eindeutigen Namen erhalten, in dem die Materialdefinition beschrieben ist (Betonfestigkeit X/Y und Z% Stahl, Steinwolle etc.).
4. **IFC-Datei exportieren**
  * Unter *Speichern unter* können Sie die Datei als IFC speichern. Dies geschieht über die Option *Format: IFC-Datei*. Außerdem müssen Sie den richtigen *Übersetzer* für den Modell-Export einstellen. Dieser kann auf 2 Arten eingestellt werden: *manuell* oder *direkt herunterladbar*:
    1. Manuelles Einrichten des IFC-Exports: Wenn Sie den IFC-Export manuell einrichten, erstellen Sie einen neuen Übersetzer, indem Sie auf *Neu erstellen* klicken und folgende Einstellungen vornehmen:
    * Unter *Einstellungen > IFC-Schema* stellen Sie *IFC4* und *Design Transfer View* ein.
    * Die *Geometriekonvertierung* muss auf *IFC4 Design Transfer View* eingestellt werden.
    * Die *Datenkonvertierung* auf *General translator IFC4*.
    * Es ist wichtig, dass der Haken bei *IFC Base Quantities* in den *Dateneinstellungen* nicht vergessen wird.
    2. Über die <a href="/de/de/knowledge-base/madaster-property-set.html#madaster-revit-eigenschaftssatz-cpset_madaster" target="_blank">Madaster-Vorlage</a> können Sie einen voreingestellten IFC-Übersetzer herunterladen, der über den *Import*-Button importiert werden kann.


## Revit IFC-Quelldateien vorbereiten

Um sicherzustellen, dass Ihre Datei für den Import geeignet ist, muss sie den BuildSmart-Standards entsprechen. Unter <a href="https://ucm.buildingsmart.org/use-case-details/2594/en" target="_blank">BIM Basic IDS</a> finden Sie eine ausführliche Anleitung. Beachten Sie darüber hinaus das <a href="https://docs.madaster.com/files/de/madaster%20GER_BIM%20Anleitung.pdf" target="_blank">Madaster-BIM-Handbuch</a>.

1. Lesen Sie die <a href="https://docs.madaster.com/files/de/BIM%20basis%20ILS_infographicA4_German.pdf" target="_blank">BIM Basic IDS</a> von Madaster für alle IFC-Quelldateien
2. **Klassifizierung**  hinzufügen
  * Generell ist es möglich, einen ifcText oder ifcClassification Parameter zu haben, der den Klassifizierungscode enthält (kein ifcInteger!).
  * Um die Klassifizierung als Assembly Code hinzuzufügen, laden Sie <a href="https://docs.madaster.com/files/de/2024-03-28_madaster%20GER_Revit.zip" target="_blank">hier</a> die Datei für die Klassifizierung Ihrer Wahl herunter. 
  * Gehen Sie zu *Verwalten > Zusätzliche Einstellungen > Assembly Code* und navigieren Sie zu der Klassifizierungsdatei mit *Browse* und bestätigen Sie mit *OK*, um sie in Revit zu laden. Wenn Sie ein Element ausgewählt haben, gehen Sie zu *Typ bearbeiten*, klicken Sie auf den Parameter *Baugruppencode* und geben Sie die korrekte Codierung ein. Es ist auch möglich, den Assembly Code aus einer Liste auszuwählen, auf den Block mit *...* zu klicken und den korrekten Code auszuwählen.
3. **Materialien hinzufügen**
  * Es ist möglich, bestimmten Kategorien oder Familien ein bestimmtes Material zuzuordnen. Gehen Sie dazu auf *Verwalten > Einstellungen > Objektstil*.
  * Um das Material eines Typs zu definieren, wählen Sie eine *Instanz* des Typs aus und gehen Sie auf *Typ bearbeiten* in der Registerkarte *Eigenschaften*.
  * Es steht eine Materialbibliothek zur Auswahl, und Sie haben die Möglichkeit, ein individuelles Material *hinzuzufügen* oder andere Materialbibliotheken *herunterzuladen*.
  * Es ist wichtig, dass die verwendeten Materialien einen eindeutigen Namen erhalten, in dem die *Materialdefinition* beschrieben wird (Betonfestigkeit X/Y und Z% Stahl, Steinwolle usw.).

4. **IFC-Datei exportieren**
  * In der Registerkarte *Property Sets* die Kästchen für *Export base quantities* und *Export user defined property sets* auswählen, wenn das *Madaster cPset* verwendet wurde.
  * In der Registerkarte *Allgemein* wählen Sie *IFC4 Design Transfer View*.

## Vectorworks IFC-Quelldateien vorbereiten

Empfohlenes Vorgehen: **Test-IFC exportieren → in Madaster laden → Qualität bewerten → Plug-In-Objekte einstellen → Datenmanager/CPset_Madaster konfigurieren → IFC erneut exportieren und prüfen.**

Ausführliche Informationen finden Sie im <a href="/files/de/madaster DACH_BIM Handbuch.pdf" target="_blank"><strong>Madaster-BIM-Handbuch</strong></a>.
Bei weiterführenden Fragen zum Datenaustausch zwischen Vectorworks und Madaster unterstützt gerne auch das <a href="https://www.vectorworks.de/bim-consulting/anfrage" target="_blank"><strong>BIM-Consulting von Vectorworks</strong></a>.

1. **IFC-Entität zuordnen**
  * Beim Platzieren eines intelligenten Objekts wird die IFC-Entität automatisch gemäß Datenmanager zugewiesen und kann in der **Infopalette → Daten** geprüft werden.
  * Soll die Entität angepasst werden, erfolgt dies zentral über **Datenmanager → Neue kriteriumsbasierte Zuordnung…**. Dort wird über einen Filter, z. B. nach Klasse, die gewünschte IFC-Entität zugewiesen.
  * IFC-Entitäten möglichst nicht manuell über die Infopalette zuweisen, sondern zentral im Datenmanager verwalten.

2. **Material zuweisen**
  * Materialien werden direkt am Objekt bzw. bei mehrschichtigen Bauteilen über deren Schichten definiert. Bei Objekten ohne eindeutige Materialzuordnung oder mit mehreren Materialien (z. B. Türen/Fenster) kann die Zuordnung im **Datenmanager** erfolgen – bei Bedarf auch dynamisch über Formeln.

3. **Klassifikation zuweisen**
  * Die Klassifikation erfolgt über **Datei → Dokument Einstellungen → Klassifikationsstandard-Einstellungen**. Für Deutschland kann beispielsweise **DIN 276 – Regeln für IFC-Daten.xml** verwendet werden. Intelligente Objekte werden damit vielfach automatisch klassifiziert.
  * Falls eine Klassifikation fehlt, sollten die **Einstellungen des intelligenten Objekts** oder die **Regeln des Klassifikationsstandards** überprüft und angepasst werden.
  * Auch hier gilt: **Manuelle Zuweisungen über die Infopalette möglichst vermeiden.**

4. **Mehrschichtige Bauteile korrekt exportieren**
  * Für Wand, Boden/Decke, Dach und Dachfläche ist eine korrekte Hierarchisierung besonders wichtig. Im **Datenmanager** wird dafür unter **ExportOptions → Export by Components = WAHR** gesetzt. Dadurch werden die einzelnen Schichten als **IfcBuildingElementPart** unter dem übergeordneten Bauteil exportiert.
  * **Sonderfall Dach/Dachfläche:** Die ExportOptions müssen sowohl für das Primärelement **IfcRoof** als auch für das sekundäre **IfcSlab** definiert werden.

5. **Mengen exportieren**
  * Bei den meisten Objekten werden Mengen automatisch erzeugt. Beim IFC-Export muss hierfür **„Mengenermittlung – Base Quantities“** aktiviert sein.
  * Bei generischen Objekten können Quantity Sets bei Bedarf im **Datenmanager** ergänzt und über Zuordnungen bzw. Tabellenfunktionen befüllt werden.

6. **CPset_Madaster nutzen**
  * Madaster-spezifische Informationen, z. B. die **Phase eines Bauteils (Rückbau, Neu, Verbleibend)**, können über das **CPset_Madaster** übertragen werden.
  * Dazu wird das Pset zunächst unter **Eigene Eigenschaftssets (Custom Psets) verwalten…** angelegt, anschließend dem Bauteil hinzugefügt und im Datenmanager oder über die Infopalette befüllt.