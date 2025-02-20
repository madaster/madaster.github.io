---
title: Vorbereiten einer IFC-Quelldatei
description: Modellierungs- und Exporthinweise zu BIM-Modellen
ref: preparing-bim-ifc-source-files
type: Wissensdatenbank
menubar: knowledge-base-nav
---

Modellierungs- und Exporthinweise zu BIM-Modellen

## Allgemeine Richtlinien

Um eine detaillierte und einfache Berechnung auf Madaster zu gewährleisten, muss das BIM-Modell gut vorbereitet sein. Der folgende Text wird Sie durch die wichtigsten Punkte führen.

> Ausführliche Informationen finden Sie in unserem **Madaster BIM-Handbuch** unter <a href="../resources/downloads" target="_blank">Downloads bei Handbücher und Vorlagen</a>. Dort finden Sie ebenfalls hilfreiche Dateien für Revit und ArchiCAD.

1. Wenn eine Quelldatei in einer BIM-Anwendung (Revit, ArchiCAD, etc.) vorbereitet wird, sollte das universelle IFC-Dateiformat beim Export des Modells verwendet werden, das anschließend auf die Madaster-Plattform hochgeladen wird.
2. Madaster unterstützt die Akzeptanz und Anwendung der BIM Basis IDS (Information Delivery Specification). Weitere Informationen finden Sie unter <a href="https://ucm.buildingsmart.org/use-case-details/2594/en" target="_blank">building smart</a>.
3. Die Madaster-Richtlinien für die Modellierung von Gebäudedaten und den Export einer IFC-Datei lauten wie folgt:
* Alle Elemente des Modells müssen enthalten:
* **Eindeutige GUIDs**.
* **Geometrische Eigenschaften** (sogenannte "Basismengen").
* Eine **Materialbeschreibung**.
* Eine **Klassifizierungskodierung**, anhand derer Madaster die Elemente der entsprechenden Gebäudeschicht zuordnen kann. Die meisten Länder haben ihre eigenen Normen für die Klassifizierung von Bauelementen (siehe <a href="../nl/en/knowledge-base/madaster-glossary.html" target="_blank">Madaster Glossar - Standards</a>). Die Madaster-Plattform ermöglicht es Ihnen, Ihre nationale Klassifizierung aus den BIM-Dateien zu lesen und sie den Schichten des Gebäudes zuzuordnen.
* Stellen Sie den korrekten IFC-Typ sicher.
* Verhindern Sie die Verwendung der IFC-Entität "Building element proxy" und "Building element part".
* Exportieren Sie den "Renovierungsstatus" oder die "Phase" im gleichnamigen Property-Set. Wenn Sie selbst erstellt wurden, verwenden Sie die Beriffe:
  EN: Existing / Demolish / New oder DE: Verbleibend / Rückbau / Einbau
* Verwenden Sie vorzugsweise die Export-Einstellung "IFC 4 Design Transfer View", es wird jedoch auch "IFC 2x3" akzeptiert.
* Vergewissern Sie sich, dass der Projektnullpunkt mit einer Koordinate verbunden ist.

## ArchiCAD IFC-Quelldateien vorbereiten

Um sicherzustellen, dass Ihre Datei für den Import geeignet ist, muss sie den BuildSmart-Standards entsprechen. Unter <a href="https://ucm.buildingsmart.org/use-case-details/2594/en" target="_blank">BIM Basic IDS</a> finden Sie eine ausführliche Anleitung. Beachten Sie darüber hinaus das <a href="BIM Handbuch inkludieren" target="_blank">Madaster-BIM-Handbuch</a>.

1. Lesen Sie die <a href="../files/de/BIM%20basis%20ILS_infographicA4_German.pdf" target="_blank">BIM Basic IDS</a> von Madaster für alle IFC-Quelldateien.
2. **Klassifizierung hinzufügen:**
  * Madaster verwendet einen Klassifizierungscode, um die Elemente in Gebäudeschichten zu sortieren, die Standardklassifizierungsmethode variiert von Land zu Land.
  * Diese Notation kann in der Kategorie und den Eigenschaften in den Selektionseinstellungen eines Objekts hinzugefügt werden. In diesem Fenster müssen Sie IFC-Eigenschaften verwalten öffnen und die Option Vordefinierte Regel anwenden aktivieren. In diesem letzten Fenster können Sie die Kodierung und den Detaillierungsgrad (Anzahl der Ziffern des Codes) aktivieren. Der letzte Schritt besteht nun darin, anzugeben, welche Kodierung das Objekt hat.
  * Alternativ dazu können Sie sich das  <a href="/at/de/knowledge-base/madaster-property-set.html#madaster-archicad-eigenschaftssatz-cpset_madaster" target="_blank">Madaster Pset</a> herunterladen und in Archicad importieren.
3. **Materialien hinzufügen:**
  * Für eine exakte Auswertung sollten alle modellierten Elemente eine Materialbeschreibung besitzen, die in Archicad in den Baustoffen mit der Option *individuelles Material hinzuzufügen* definiert wird.
  * Wichtig ist, dass die verwendeten Materialien einen eindeutigen Namen erhalten, in dem die Materialdefinition beschrieben ist (Betonfestigkeit X/Y und Z% Stahl, Steinwolle etc.).
4. **IFC-Datei exportieren:**
  * Unter *Speichern unter* können Sie die Datei als IFC speichern. Dies geschieht über die Option *Format: IFC-Datei*. Außerdem müssen Sie den richtigen *Übersetzer* für den Modell-Export einstellen. Dieser kann auf 2 Arten eingestellt werden: *manuell* oder *direkt herunterladbar*:
    1. Manuelles Einrichten des IFC-Exports: Wenn Sie den IFC-Export manuell einrichten, erstellen Sie einen neuen Übersetzer, indem Sie auf *Neu erstellen* klicken und folgende Einstellungen vornehmen:
    * Unter *Einstellungen > IFC-Schema* stellen Sie *IFC4* und *Design Transfer View* ein.
    * Die *Geometriekonvertierung* muss auf *IFC4 Design Transfer View* eingestellt werden.
    * Die *Datenkonvertierung* auf *General translator IFC4*.
    * Es ist wichtig, dass der Haken bei *IFC Base Quantities* in den *Dateneinstellungen* nicht vergessen wird.
    * Wenn Sie das "Dach-Trimming-Tool" angewendet haben, stellen Sie sicher, dass Sie dies in den Exporteinstellungen unter „Geometriekonvertierung – Umwandlung von Archicad-Elementen“ berücksichtigen, damit betroffene Elemente korrekt exportiert werden.
    2. Im <a href="/files/at/Madaster - BIM Anleitung_AT.pdf" target="_blank">Madaster-BIM-Handbuch</a> können Sie nachlesen wie ein voreingestellter IFC-Übersetzer über den *Import*-Button importiert werden kann.
      


## Revit IFC-Quelldateien vorbereiten

Um sicherzustellen, dass Ihre Datei für den Import geeignet ist, muss sie den BuildSmart-Standards entsprechen. Unter <a href="https://ucm.buildingsmart.org/use-case-details/2594/en" target="_blank">BIM Basic IDS</a> finden Sie eine ausführliche Anleitung. Beachten Sie darüber hinaus das <a href="/files/at/Madaster - BIM Anleitung_AT.pdf" target="_blank">Madaster-BIM-Handbuch</a>.

1. Lesen Sie die <a href="../files/de/BIM%20basis%20ILS_infographicA4_German.pdf" target="_blank">BIM Basic IDS</a> von Madaster für alle IFC-Quelldateien
2. **Klassifizierung hinzufügen:**  
  * Generell ist es möglich, einen ifcText oder ifcClassification Parameter zu haben, der den Klassifizierungscode enthält (kein ifcInteger!).
  * Um die Klassifizierung als Assembly Code hinzuzufügen, laden Sie <!--<a href="../files/de/2024-03-28_madaster%20GER_Revit.zip" target="_blank">hier</a> --> die Datei für die Klassifizierung Ihrer Wahl online herunter. 
  * Gehen Sie zu *Verwalten > Zusätzliche Einstellungen > Assembly Code* und navigieren Sie zu der Klassifizierungsdatei mit *Browse* und bestätigen Sie mit *OK*, um sie in Revit zu laden. Wenn Sie ein Element ausgewählt haben, gehen Sie zu *Typ bearbeiten*, klicken Sie auf den Parameter *Baugruppencode* und geben Sie die korrekte Codierung ein. Es ist auch möglich, den Assembly Code aus einer Liste auszuwählen, auf den Block mit *...* zu klicken und den korrekten Code auszuwählen.
3. **Materialien hinzufügen:**
  * Es ist möglich, bestimmten Kategorien oder Familien ein bestimmtes Material zuzuordnen. Gehen Sie dazu auf *Verwalten > Einstellungen > Objektstil*.
  * Um das Material eines Typs zu definieren, wählen Sie eine *Instanz* des Typs aus und gehen Sie auf *Typ bearbeiten* in der Registerkarte *Eigenschaften*.
  * Es steht eine Materialbibliothek zur Auswahl, und Sie haben die Möglichkeit, ein individuelles Material *hinzuzufügen* oder andere Materialbibliotheken *herunterzuladen*.
  * Es ist wichtig, dass die verwendeten Materialien einen eindeutigen Namen erhalten, in dem die *Materialdefinition* beschrieben wird (Betonfestigkeit X/Y und Z% Stahl, Steinwolle usw.).

4. **IFC-Datei exportieren:**
  * In der Registerkarte *Property Sets* die Kästchen für *Export base quantities* und *Export user defined property sets* auswählen, wenn das *Madaster cPset* verwendet wurde.
  * In der Registerkarte *Allgemein* wählen Sie *IFC4 Design Transfer View*.


<!-- ## IFC-Modellprüfung

1. Bevor Sie Ihr IFC-Modell auf die Madaster-Plattform hochladen, empfiehlt es sich, eine Vollständigkeitsprüfung durchzuführen (Klassifizierungskodierung, Basismengen, Material usw.). Für diese Prüfung verwenden Sie den kostenlosen BIMcollab ZOOM Public Viewer in Kombination mit den Madaster Smart Views.
2. Der <a href="https://www.bimcollab.com/de/go/free-ifc-viewer/" target="_blank">BIMcollab ZOOM Public Viewer</a> und <a href="https://helpcenter.bimcollab.com/portal/de/kb/articles/smart-view-sets-downloads-de" target="_blank">Madaster Smart Views</a>
können kostenlos heruntergeladen werden. Nach der Installation von BIMCollab Zoom können Sie die programmierten Madaster Smart Views über die Schaltfläche Importieren in das Programm laden. Indem Sie nun Ihr eigenes (IFC) Modell öffnen, kann das Modell, die Smart Views, auf Vollständigkeit geprüft werden. -->
