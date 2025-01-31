---
title: Vorbereiten einer Excel-Quelldatei
description: Download und Verwendung des Madaster Excel-Templates
ref: preparing-excel-source-files
type: Wissensdatenbank
menubar: knowledge-base-nav
---

Download und Verwendung des Madaster Excel-Templates

## Madaster Excel-Template herunterladen

Das Excel-Template kann als alternative Quelldatei für Objekte genutzt werden, zu denen kein BIM-Modell bzw. keine IFC-Datei vorliegt. Es kann außerdem genutzt werden, um in IFC-Dateien fehlende Elemente auf Madaster zu ergänzen, bspw. nach Umbau, Renovierung oder Sanierung.

Für jede verfügbare <a href="../knowledge-base/classifications" target="_blank">Klassifizierungsmethode</a> (bspw. DIN 276:2018-12) gibt es eine spezische Excel-Vorlagendatei zum Herunterladen.

1. Klicken Sie auf Objektebene im Tab **Dossier** die Schaltfläche **Hochladen** <iconify-icon inline icon='mdi-upload'/>.
2. Wählen Sie über das Dropdown-Menü die **Klassifizierungsmethode**.
3. Hinter dem Hinweis *"Verwenden Sie Excel? Dann verwenden Sie **diese Vorlage**"* steckt ein Downloadlink der Excel-Vorlage, welche Sie nach Klicken auf diesen in Ihrem lokalen Download-Ordner finden können.

## Madaster Excel-Template ausfüllen

Für ein bestmögliches Auswertungsergebnis, sollte die Vorlage möglichst vollständig mit Informationen befüllt werden. Jedoch gibt es <a href="../knowledge-base/preparing-excel-source-files#erforderliche-mindestangaben" target="_blank">erfoderliche Mindestangaben</a> sowie <a href="../knowledge-base/preparing-excel-source-files#optionale-angaben" target="_blank">optionale Angaben</a>. Welche der Letztgenannten auszufüllen sind, richtet sich nach der Zielsetzung der Darstellung Ihres Projekts auf der Plattform. So sind beispielsweise Materialangaben Pflicht für einen digitalen Materialpass. Angaben zur Demontierbarkeit sind optional. Werden diese nicht erfasst, wird die Demontierbarkeit auch nicht ausgewertet.

In der Excel-Datei finden Sie auf dem ersten Tabellenblatt eine Kurzanleitung, in der erklärt wird, was Sie in welches Blatt und welche Zellen eintragen müssen. Folgend finden Sie ausführlichere Informationen.

### Rückbau / Verbleibend / Bauabfälle / Einbau

In Abhängigkeit des zu realisierenden bzw. realisierten Projekts, wählen Sie hier für die Erfassung der jeweiligen Objektelemente das entsprechende Tabellenblatt. Sie können in mehreren Tabellenblättern gleichzeitig Eintragungen vornehmen, um einen differenzierten Prozess (wie bspw. bei einer Sanierung) darzustellen.

1. Sind für das Objekt Rückbaumaßnahmen geplant, bei denen Materialien oder Produkte aus dem Objekt entfernt werden, wählen Sie für Eintragung dieser Elemente das Tabellenblatt **Rückbau**.

   > Hinweis: Diese Elemente werden (da aus dem Objekt entfernt) nicht im Masse-Tab auftauchen! Sie finden im **Bauprozess**-Tab Berücksichtigung.

2. Sind sich das Objekt (z.B. Bestandserfassung) oder Elemente dessen, keine baulichen Veränderungen geplant sind, wählen Sie das Tabellenblatt **Verbleibend** für Ihre Eintragungen.

3. Möchten Sie **Bauabfälle** erfassen, wählen Sie das entsprechende Tabellenblatt.

4. Möchten Sie einen Neubau erfassen oder sind Umbaumaßnahmen geplant, bei denen zusätzliche Materialien oder Produkte eingebaut werden, wählen Sie das Tabellenblatt **Einbau** für die Eintragung der betreffenden Elemente. 

*Auf den letzten Tabellenblättern werden die verfügbaren **Klassifizierungen** und **European Waste Codes** (Abfallschlüssel) aufgeführt. Diese dienen der Information und sind partiell mit Zellen der vorangehenden Blätter verknüpft.*

## Erläuterung der Eingabefelder

Der folgende Abschnitt erläutert den Hintergrund und die zu hinterlegenden Informationen in den jeweiligen Spalten. Nicht jedes der Felder muss zwingend ausgefüllt sein. Beachten Sie hierzu den Hinweis zur *Notwendigkeit*. Mit jeder hinterlegten Information steigt auch die Informationstiefe der Auswertung durch die Plattform. 

### Erforderliche Mindestangaben

Die nachfolgende Tabelle und Ausführungen erläutern die mindestens auszufüllenden Spalten, um die Grundfunktionalität der Plattform nutzen zu können. Für detailliertere Auswertungen (bspw. Demontierbarkeit) beachten Sie die nachfolgenden Erläuterungen zu <a href="../knowledge-base/preparing-excel-source-files#optionale-angaben" target="_blank">Optionale Angaben</a>. 

**Ein Beispiel**

Die aufgeführten Beispiele dienen lediglich zur Veranschaulichung und stellen keine verpflichtende Bezeichnung dar.

| Spalte | Bezeichnung| *Beispiel 1* | *Beispiel 2*
|-|-|-|-|
|E| Beschreibung | *Deckenplatte D-01* | *Bodenbelag 1.OG* |
|F| Material/Produkt | *Brettsperrholz* | *Massivholzparkett* |
|G| Klassifizierungscode | *351* | *352* |
|H| Klassifikation | *Deckenkonstruktionen* | *Deckenbeläge* |
|K| Volumen (m<sup>3</sup>) | *2550* | *-* |
|L| Fläche (m<sup>2</sup>)| *-* | *1530* |
|M| Länge (m)| *-* | *-* |

**E) Beschreibung**
* Notwendigkeit der Eingabe: *Erforderlich*
* In diesem Eingabefeld können genauere Beschreibungen zu dem jeweiligen Bauelement hinterlegt werden. Diese Beschreibung dient zur besseren Übersicht und Strukturierung des Excel-Tabellenblatts, weil hier zusätzliche Informationen hinterlegt werden können, die das Element näher beschreiben und somit eine bessere Zuordnung im Objekt ermöglichen. Beispielhaft sind hier Informationen zu Bauteilart, Ausführungsart, Bauteilnummerierungen, Herstellerangaben o.ä. möglich, sodass Sie hiermit Ihre eigene Organisationsstruktur abbilden können. Dieses ist hilfreich, wenn mehrere Bearbeitende an dem Objekt tätig sind oder Zuständigkeiten zwischen Personen innerhalb eines Projekts wechseln. Die Beschreibung des Elements wird darüber hinaus im manuellen Erweiterungstab und bei detaillierteren Bauteilangaben in der Plattform angezeigt.

    > Die Madaster-Plattform liest dieses Feld nicht zwecks automatischen Verknüpfens der Elemente mit den Datenbankprodukten aus. Diese Informationen sind im nachfolgenden Feld „Material/Produkt“ einzugeben. 

**F) Material/Produkt**
* Notwendigkeit der Eingabe: *Erforderlich*
* Dieses Eingabefeld dient zum Verknüpfen des zu erfassenden Elements mit den Datenbanken der Madaster-Plattform. Fehlt diese Information oder ist diese unvollständig, kann die Plattform das Bauelement nicht verknüpfen. Nutzen Sie daher vergleichend die Datenbanken, mit denen Sie die zu erfassenden Materialien und Produkte abgleichen möchten und informieren Sie sich im Vorfeld über die dort verwendeten Bezeichnungen. Wenn diese abweichen, kann es zu einem unvollständigen Verknüpfen des Bauelements mit der ausgewählten Datenbank kommen und eine händische Nachpflege zur Folge haben. Informationen finden Sie in der <a href="https://docs.madaster.com/files/de/Epea_Generic.xlsx" target="_blank">EPEA Material-/Produktliste</a>, der <a href="https://www.oekobaudat.de/no_cache/datenbank/suche.html" target="_blank">ÖKOBAUDAT</a>, der <a href="https://ibu-epd.com/veroeffentlichte-epds/" target="_blank">IBU-Datenbank</a> oder bei den spezifischen Herstellerdatenbanken der Madaster-Plattform. 
        
    > Wurde in den vorangegangenen Spalten eine ID eingetragen, wird diese bevorzugt zum Verknüpfen des Bauelements mit einem Produktdatensatz verwendet. 

**G) Klassifizierungscode**
* Notwendigkeit der Eingabe: *Erforderlich*
* Für die Madaster-Plattform ist es erforderlich, dass Sie Ihre Elemente klassifizieren, damit eine Kategorisierung der verbauten Produkte erstellt werden kann. In Deutschland ist eine Klassifikation in die jeweiligen Kostengruppen nach der DIN 276 2018-12 üblich.

    > Mit Befüllung der Spalte G wird Spalte H automatisch befüllt.

**K/L/M) Volumen / Fläche / Länge**
* Notwendigkeit der Eingabe: *Erforderlich*
* Mindestens eine dieser Information ist zwingend erforderlich für die Funktionalität der Madaster-Plattform. Welche der Spalten ausgefüllt werden muss, liegt auch in der „Natur des Elements“ bzw. des verbauten Produktes (siehe Beispiel-Einträge). Die Angabe muss jedoch zur deklarierten Einheit der Umweltdeklaration (EPD) des Produktes passen. Eine Flächenangabe bei Verknüpfung mit einem Volumenprodukt ist im Sinne der Plattform ungültig und führt zu einer Nichtberechnung des Elements. Nur wenn die passende Information hinterlegt ist, können die Berechnungen durchgeführt werden.
        
    > Zu beachten ist, welche deklarierte Einheit (m<sup>3</sup>, m<sup>2</sup>, m) die jeweilige Produkt-EPD enthält. Diese Information ist in der <a href="https://www.oekobaudat.de/no_cache/datenbank/suche.html" target="_blank">ÖKOBAUDAT</a>, der <a href="https://ibu-epd.com/veroeffentlichte-epds/" target="_blank">IBU-Datenbank</a> oder bei den spezifischen Hersteller-EPDs zu finden.  

### Optionale Angaben

**A) GTIN**
* Notwendigkeit der Eingabe: *Optional*
* Die GTIN eines Produktes kann ergänzend zur genaueren Beschreibung dessen genutzt werden. Sie stellt eindeutige Kennung (ID) dar, wodurch eine Verwechslung mit anderen Produkten ausgeschlossen ist. IDs werden im automatischen Verknüpfen der Material-/Produktbezeichnung bevorzugt.. Es ist nicht garantiert, dass zu jedem individuellen Produkt Informationen der GTIN in den Datenbanken hinterlegt sind. Es empfiehlt sich deshalb, die jeweiligen Datenbanken und die darin hinterlegten Informationen inhaltlich zu überprüfen. 
 
**B) Artikelnummer**
* Notwendigkeit der Eingabe: *Optional*
* Die Artikelnummer eines Produktes kann ergänzend zur genaueren Beschreibung dessen genutzt werden. Sie stellt eindeutige Kennung (ID) dar, wodurch eine Verwechslung mit anderen Produkten ausgeschlossen ist. IDs werden im automatischen Verknüpfen der Material-/Produktbezeichnung bevorzugt. Es ist nicht garantiert, dass zu jedem Produkt eine Artikelnummer in den Datenbanken hinterlegt ist. Es empfiehlt sich deshalb, die entsprechenden Datenbanken zu prüfen. Alternativ kann auf die Madaster-ID zurückgegriffen werden. 

**C) Madaster-ID**
* Notwendigkeit der Eingabe: *Optional*
* Die Madaster-ID eines Produktes kann ergänzend zur genaueren Beschreibung dessen genutzt werden. Sie stellt eindeutige Kennung (ID) dar, wodurch eine Verwechslung mit anderen Produkten ausgeschlossen ist. IDs werden im automatischen Verknüpfen der Material-/Produktbezeichnung bevorzugt. Die Madaster-ID finden Sie in den jeweiligen „Produktinformationen“ der Datenbanken. Für die EPEA Material-/Produktliste steht Ihnen eine Excelübersicht zum <a href="https://docs.madaster.com/files/de/Epea_Generic.xlsx" target="_blank">Download</a> zur Verfügung. 

**D) Externe Datenbank-ID**
* Notwendigkeit der Eingabe: *Optional*
* Die Externe Datenbank-ID eines Produktes kann ergänzend zur genaueren Beschreibung dessen genutzt werden. Sie stellt eindeutige Kennung (ID) dar, wodurch eine Verwechslung mit anderen Produkten ausgeschlossen ist. IDs werden im automatischen Verknüpfen der Material-/Produktbezeichnung bevorzugt. Weitere Informationen können bspw. Datenbanken der <a href="https://www.oekobaudat.de/no_cache/datenbank/suche.html" target="_blank">ÖKOBAUDAT</a> oder der <a href="https://ibu-epd.com/veroeffentlichte-epds/" target="_blank">IBU-Datenbank</a> entnommen werden. Es ist nicht garantiert, dass zu jedem Produkt eine Externe Datenbank-ID in den Datenbanken hinterlegt ist. Es empfiehlt sich deshalb, die entsprechenden Datenbanken zu prüfen. Alternativ kann auf die Madaster-ID zurückgegriffen werden. 

**I) Etage**
* Notwendigkeit der Eingabe: *Optional*
* Die Informationsangabe der Etage ordnet dem Produkt eine Lokalisation innerhalb des Objekts zu. Dieses ist hilfreich, wenn mehrere Bearbeitende an dem Objekt tätig sind oder Zuständigkeiten zwischen Personen innerhalb eines Projekts wechseln.  

**J) Anzahl**
* Notwendigkeit der Eingabe: *Optional*
* Wenn Sie in diesem Feld eine Angabe machen, wird die eingegebene Anzahl mit den nachfolgend eingegebenen Angaben des Produktes zu Volumen / Fläche / Länge multipliziert. So können Mehrfachaufzählungen von gleichen Materialien/Produkten vermieden werden.

**N) Gewicht / Dicke / Höhe / Breite / Durchmesser / Eigenschaft / Menge**
* Notwendigkeit der Eingabe: *Optional*
* Möchten Sie die Skalierungsfunktion von Madaster für Ihre Materialien/Produkte verwenden, hinterlegen Sie in diesen Feldern die notwendigen Informationen. Nähere Erläuterungen finden Sie unter <a href="/de/de/knowledge-base/databases.html#produktinformation" target="_blank">Skalierbarkeit</a>.

**O) Objektnummern**
* Notwendigkeit der Eingabe: *Optional*
* Falls Ihr Objekt aus mehreren Unterobjekten besteht, bspw. Mehrfamilienhaus mit mehreren Eigentumswohnungen, können Sie durch die Angabe Ihr Objekt unterteilen und in der Plattform danach filtern. Die Funktionalität ist vergleichbar mit der der *Etage*.

**V/Y/AA/AC) Demontierbarkeit**
* Notwendigkeit der Eingabe: *Empfohlen*
* Die Angaben zur Demontierbarkeit dienen der Informationstiefe zu den Elementen bzw. dem Objekt. Nur wenn hier über die Dropdownauswahl Eingaben getätigt werden, kann die Plattform unter Zirkularität Ergebnisse zur Demontierbarkeitsananlyse der Elemente bzw. des Objektes bereitstellen. 
Aufgrund der Langlebigkeit der Objekte ist es wichtig, gerade dieses Wissen langfristig digital zu sichern und zur Verfügung zu stellen. Gerade bei Renovierungsvorhaben sind diese Informationen essenziell und reduzieren den Planungsaufwand (bspw. die persönliche Ortsbesichtigung). Des Weiteren erleichtern Sie die Planung, welche Produkte unter welchem Aufwand wieder in den Kreislauf zurückgeführt werden können. 
    * **Verbindungstyp:** Wählen Sie hier den Verbindungstyp des Produktes.
    * **Zugänglichkeit der Verbindung:** Wählen Sie hier die Zugänglichkeit der Verbindung des Produktes.
    * **Überschneidungen:** Wählen Sie hier die Produktüberschneidungen.
    * **Produktkanten:** Sie können bewerten, wie Produkte in einer Komposition platziert sind und ob diese offen oder geschlossen ist. Wie der Name schon sagt, hat dies mit den physischen „Kanten" des Produkts zu tun. Liegt ein Produkt so, dass es von umgebenden Produkten „umschlossen“ ist, spricht man von einem Randeinschluss. Dies macht es unmöglich, ein Produkt anders als in umgekehrter Reihenfolge des Aufbaus zu demontieren. Der Randeinschlussfaktor ist in zwei Situationen relevant: 1) für einzelne Produkte, die von der Komposition umschlossen sind oder 2) für Serienprodukte, die sich gegenseitig umschließen.
* weitere Informationen zur Berechnung der Demontierbarkeit finden Sie <a href="/de/de/knowledge-base/calculations.html#demontierbarkeit-detachability" target="_blank">hier</a>.

**AE) % Wiederverwendet**
* Notwendigkeit der Eingabe: *Empfohlen*
* Mit der Eingabe dieses Feldes geben Sie an, zu wie viel Prozent das Material/Produkt hinsichtlich der *Materialherkunft* wiederverwendet wurde. Ist diese Information hinterlegt, kann diese für die Berechnung des <a href="/de/de/knowledge-base/calculations.html#madaster-zirkularit%C3%A4tsindikator-mzi" target="_blank">Madaster Zirkularitätsindikators</a> genutzt werden.

**AF) Prozentsatz für die Verfügbarkeit für die Wiederverwendung**
* Notwendigkeit der Eingabe: *Empfohlen*
*  Mit der Eingabe dieses Feldes geben Sie die prozentuale Anzahl an, wie viele Materialien/Produkte im Sanierungs-/Rückbauprozess in der *Materialverwendung* für die Wiederverwendung in Betracht gezogen werden können. Ist diese Information hinterlegt, kann diese für die Berechnung des <a href="/de/de/knowledge-base/calculations.html#madaster-zirkularit%C3%A4tsindikator-mzi" target="_blank">Madaster Zirkularitätsindikators</a> genutzt werden.

**AG) Angenommene Bauabfälle**
* Notwendigkeit der Eingabe: *Optional*
* Mit der Angabe der *Angenommenen Bauabfälle* können Sie Ihre Materialien/Produkte mit weiteren Informationen anreichern, die dann für Berichterstattungen wie bspw. *Level(s)* genutzt und exportiert werden können.

**AH) Abfallschlüssel**
* Notwendigkeit der Eingabe: *Optional*
*  Mit der Angabe der hinterlegten *European Waste Codes* können Sie Ihre Materialien/Produkte mit weiteren Informationen anreichern, die dann für Berichterstattungen wie bspw. *Level(s)* genutzt und exportiert werden können. 
*  Alternativ können Sie die Abfallcodes in folgendem Format eingeben *Code:Prozentsatz:Art:BauabfallErgebnis:ÜberbestellungsErgebnis;(ggf. Wiederholung)*, z.B. *16 02 09*:0.1:Gefährlich:70:70;17 01:0.25:Inert:60:60*.

## Madaster Excel-Template hochladen

1. Klicken Sie wie beim Herunterladen der Vorlage auf Objektebene im Tab **Dossier** die Schaltfläche **Hochladen** <iconify-icon inline icon='mdi-upload'/>.
2. Wählen Sie über das Dropdown-Menü die selbe <a href="../knowledge-base/classifications" target="_blank">Klassifizierungsmethode</a> wie für die Vorlage aus.
3. Über **Datei(en) auswählen** geben Sie die ausgefüllte Excel an.
4. Wählen Sie eine Sprache und eine Datenbank für den automatischen Abgleich aus und klicken Sie **Speichern**.

Ist die Datei hochgeladen und verarbeitet, finden Sie diese im **Dossier**. Zur weiteren Bearbeitung folgen Sie der Anleitung <a href="../get-started/enrich-objects-with-material-and-product-databases">Objekt anreichern</a>.