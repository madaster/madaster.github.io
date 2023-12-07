---
title: Zirkularität
ref: building-circularity
redirect_from:
  - /de/de/building-circularity-ci
  - /de/de/building-circularity-details
  - /de/de/building-circularity-flows
  - /de/de/building-detachability-details
---

## WELCHE INFORMATIONEN WERDEN HIER ANGEZEIGT?
Der Madaster Zirkularitätsindikator (MZI) und die Demontierbarkeit des Objekts werden angezeigt. Wird eine Benchmark ausgewählt und sind entsprechende Informationen verfügbar, wird das Objekt mit dieser verglichen. Unterhalb des MZI werden die Materialströme angezeigt. Unbekannte Elemente werden angezeigt, damit sie angepasst und in die Berechnungen einbezogen werden können. Über die Dropdown-Liste können die Materialströme nach Total, nach Gebäudeschichten oder nach Material/Produkt angezeigt werden.

### MADASTER ZIRKULARITÄTSINDIKATOR (MZI)
Der Madaster Zirkularitätsindikator bewertet den Grad der Kreislauffähigkeit jedes einzelnen Objekts und stuft ihn, basierend auf den von den Nutzern auf Madaster hochgeladenen Informationen, zwischen 0 und 100 % ein. Ein Objekt, dass aus Primärrohstoffen errichtet wurde und am Ende der Objektlebensdauer auf der Deponie endet, ist ein vollständig „lineares“ Objekt mit einem Madaster-ZI von 0 %. Am anderen Ende des Spektrums liegen Objekte, die aus wiederverwerteten und/oder nachwachsenden Materialien errichtet wurden, welche am Ende der Lebensdauer des Objekts problemlos demontiert und wiederverwendet werden können. Dies sind „vollständig kreislauffähige“ Objekte mit einem Score von 100 %. In der Praxis verzeichnen die meisten Objekte einen Score zwischen 0 – 100 %.

Der MZI bewertet ein Objekt auf der Basis von zwei Aspekten:

__*Materialherkunft*__ : Wie hoch ist der Anteil von „recycelten, wiederverwendeten oder nachwachsenden Materialien“ im Vergleich zu „Primärrohstoffen“?

__*Materialverwertung*__: Wie hoch ist der Anteil von "Wiederverwendung oder Recycling" im Vergleich zu "Verbrennung und Deponierung" der Materialien und Produkte, die bei der Renovierung oder dem Abriss eines Objekts freigesetzt werden? 

Der Madaster-ZI setzt zwei verschiedene Bewertungsmethoden ein:

- **Objekt ZI Score**: ZI-Score des Objekts basierend auf den verfügbaren, von den Nutzern hochgeladenen Informationen.
- **Madaster Zirkularitätsindikator (MZI)**: Korrigierter ZI-Score nach Anpassung entsprechend der fehlenden Informationen.

Der Objekt ZI Score wird um einen Faktor korrigiert, der die Vollständigkeit des durch den Nutzer hochgeladenen Datensatzes beurteilt. Ein zirkuläres Objekt und sein Materialpass funktionieren nur, wenn alle Materialien und Produkte ordnungsgemäß dokumentiert sind. Die Korrektur basiert auf der Vollständigkeit des Modells, welche wiederum auf dem Prozentsatz der Elemente mit unbekanntem Material sowie dem Prozentsatz der Elemente mit unbekannter Klassifikation gemäß DIN 276:2018-12 basiert.

Eine detailierte Beschreibung des Madaster Zirkularitätsindikators finden Sie <a href="/files/de/Madaster - Zirkularitätsindikator.pdf" target="_blank">hier</a>.

### DEMONTIERBARKEIT
Der Demontierbarkeitsindex auf Objektebene wird nach einer Methodik berechnet, die auf der <a href="https://www.dgbc.nl/publicaties/circular-buildings-een-meetmethodiek-voor-losmaakbaarheid-v11-26">Website</a> des Dutch Green Building Council beschrieben ist.
Die Berechnung erfolgt für alle Elemente, die mit Produkten verbunden sind, für die vollständige Informationen zur Demontierbarkeit vorliegen. Jedes Produkt wird anhand der Verbindungsart, der Zugänglichkeit der Verbindung, der Kreuzungen und der Produktkanten bewertet. Die Masse der betreffenden Elemente wird als Gewichtungsfaktor verwendet.
Der Qualitätsindex gibt die Anzahl der Elemente an, bei denen die Demontierbarkeitsinformation vorliegen im Vergleich zur Gesamtzahl der Elemente des Objekts (in den betreffenden Gebäudeschichten). 

### MATERIALSTRÖME
Über das Dropdown-Menü können die Materialströme nach Total, nach Gebäudeschichten oder nach Material/Produkt angezeigt werden. Die Inputströme werden auf der Grundlage der Definition von Primär- und Sekundärrohstoffen der Plattform CB'23 klassifiziert. Neue Rohstoffe werden in nachwachsende und nicht-nachwachsende Materialien unterteilt, wobei nachwachsende Materialien weiter in nachhaltig produzierte und nicht-nachhaltig produzierte Materialien unterteilt werden. Sekundärrohstoffe werden in Material aus Wiederverwendung und Material aus Recycling unterteilt. Die Outputströme werden ebenfalls auf der Grundlage der Definition der Plattform CB'23 klassifiziert. Der Output wird in Material zur Wiederverwendung, Material zum Recycling, Material zur Deponierung und Material zur Verbrennung unterteilt. In der 3D-Darstellung sind die Materialien/Produkte auf der Grundlage ihres MZI sowie ihrer Input- und Outputströme farblich kodiert.

### UNBEKANNTE ELEMENTE
Unbekannte Elemente sind solche, die bei den Berechnungen nicht berücksichtigt wurden. Dies kann aus 3 verschiedenen Gründen resultieren:

__*Unverknüpfte Elemente*__ : Diese Elemente sind nicht mit Datensätzen einer Material-/Produktdatenbank verknüpft und können daher nicht für Berechnungen verwendet werden.

__*Elemente ohne Klassifikation*__: Diesen Elementen fehlen Informationen zur Klassifizierung gemäß DIN 276:2018-12, so dass sie keiner Objektschicht zugeordnet werden können.

__*Elemente mit unzureichenden geometrischen Angaben*__: Diesen Elementen fehlen entsprechende geometrische Angaben, so dass sie nicht für Berechnungen verwendet werden können.
