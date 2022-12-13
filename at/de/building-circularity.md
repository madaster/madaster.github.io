---
title: Zirkularität
ref: building-circularity
---
## WELCHE INFORMATIONEN WERDEN HIER ANGEZEIGT?
Der Madaster Zirkularitätsindikator (MZI) und die Demontierbarkeit des Gebäudes werden angezeigt. Wird eine Benchmark ausgewählt und sind entsprechende Informationen verfügbar, wird das Gebäude mit ausgewählten verglichen. Unterhalb des MZI werden die Materialströme angezeigt. Unbekannte Elemente werden angezeigt, damit sie angepasst und in die Berechnungen einbezogen werden können. Über die Dropdown-Liste können die Materialströme nach Total, Gebäudeschicht oder Material/Produkt angezeigt werden.

### MADASTER ZIRKULARITÄTSINDIKATOR (MZI)
Der Madaster Zirkularitätsindikator bewertet den Grad der Kreislauffähigkeit jedes einzelnen Gebäudes und stuft ihn, basierend auf den von den Nutzern auf Madaster hochgeladenen Informationen, zwischen 0 und 100 % ein. Ein Gebäude, dass aus Primärrohstoffen errichtet wurde und nach einer unterdurchschnittlichen Lebenszeit auf der Deponie endet, ist ein vollständig „lineares“ Gebäude mit einem Madaster-ZI von 0 %. Am anderen Ende des Spektrums liegen Gebäude, die aus wiederverwerteten und/oder schnell nachwachsenden Materialien errichtet werden, welche am Ende der Gebäudelebensdauer problemlos demontiert und wiederverwendet werden können. Dies sind „vollständig kreislauffähige“ Gebäude mit einem Score von 100 %. In der Praxis verzeichnen die meisten Gebäude einen Score zwischen 0 – 100 %.

Der MZI bewertet ein Gebäude auf der Basis von drei Phasen, die innerhalb der Lebensdauer eines Gebäudes stattfinden:

__*Materialherkunft*__ : Wie ist das Verhältnis zwischen „Primärrohstoffen” und „recycelten, wiederverwendeten oder (schnell) erneuerbaren” Rohstoffen?

__*Lebensdauer*__: Wie hoch ist die erwartete Lebensdauer der verwendeten Produkte im Vergleich zur durchschnittlichen Lebensdauer vergleichbarer Produkte?

__*Materialverwertung*__:  Wie ist das Verhältnis von „Abfall” zu “Wiederverwendung oder Recycling” von Materialien und Produkten, die bei der Renovierung oder dem Abriss eines Gebäudes freigesetzt werden?

Der Madaster-ZI setzt zwei verschiedene Bewertungsmethoden ein:

- **Gebäudezirkularitätsindex**: ZI-Score des Gebäudes basierend auf den verfügbaren, von den Nutzern hochgeladenen Informationen.
- **Madaster Zirkularitätsindikator (MZI)**: Korrigierter ZI-Score nach Anpassung entsprechend der fehlenden Informationen.

Die Gebäude-ZI wird um zwei Faktoren korrigiert, die die Vollständigkeit des in Madaster erfassten Datensatzes in die Gesamtpunktzahl einbeziehen. Ein zirkuläres Gebäude und der damit verbundene Materialpass funktioniert nur für Produkte und Materialien, die ordnungsgemäß erfasst wurden. Die Korrektur basiert auf der Vollständigkeit des Modells auf der Grundlage des Prozentsatzes der Masse, von der das Material unbekannt ist, und der Vollständigkeit des Modells auf der Grundlage des Prozentsatzes der Masse, von der die Klassifikation fehlt.

Eine detailierte Beschreibung des Madaster Zirkularitätsindikators finden Sie <a href="/files/de/Madaster - Zirkularitätsindikator.pdf" target="_blank">hier</a>.

### DEMONTIERBARKEIT
Der Demontierbarkeitsindex auf Gebäudeebene wird nach einer Methodik berechnet, die auf der <a href="https://www.dgbc.nl/publicaties/circular-buildings-een-meetmethodiek-voor-losmaakbaarheid-v11-26">Website</a> des Dutch Green Building Council beschrieben ist.
Die Berechnung erfolgt für alle Elemente, die mit Produkten verbunden sind, für die vollständige Informationen zur Demontierbarkeit vorliegen. Jedes Produkt wird anhand der Verbindungsart, der Zugänglichkeit der Verbindung, der Kreuzungen und der Produktkanten bewertet. Die Masse der betreffenden Elemente wird als Gewichtungsfaktor verwendet.
Der Qualitätsindex gibt die Anzahl der Elemente an, bei denen die Demontierbarkeitsinformation vorliegen im Vergleich zur Gesamtzahl der Elemente des Gebäude (in den betreffenden Gebäudeschichten). 

### MATERIALSTRÖME
Über die Dropdown-Liste können die Materialströme nach Total, Gebäudeschicht oder Material/Produkt angezeigt werden. Rohstoffherkunftsströme werden basierend auf der Definition der Platform CB'23 für neue und sekundäre Rohstoffe klassifiziert. Neuwertige Rohstoffe werden in erneuerbare und nicht erneuerbare Materialien unterteilt, wobei erneuerbare Materialien weiter in nachhaltig produzierte und nicht nachhaltig produzierte Materialien unterteilt werden. Sekundärrohstoffe werden in Material aus Wiederverwendung und Material aus Recycling unterteilt. Rohstoffverwertungsströme werden basierend auf der Definition der Plattform CB'23 klassifiziert. Sie werden unterteilt in zur Wiederverwendung verfügbares Material, zum Recycling verfügbares Material, Material zur Deponierung und Material zur Verbrennung. In der 3D-Darstellung sind die Materialien/Produkte auf der Grundlage ihres MZI sowie ihre Eingangsströme und Ausgangsströme farblich gekennzeichnet.

### UNBEKANNTE ELEMENTE
Unbekannte Elemente sind solche, die bei den Berechnungen nicht berücksichtigt wurden. Diese können aus 3 verschiedenen Gründen auftreten:

__*Unverknüpfte Elemente*__ : Diese Elemente sind nicht mit Datensätzen einer Material-/Produktdatenbank verknüpft und können daher nicht für Berechnungen verwendet werden.

__*Elemente ohne Klassifikation*__: Diesen Elementen fehlen Informationen zur Klassifizierung gemäß ÖNORM B 1801-1:2009-06 oder ÖNORM B 1801-1:2022-03, so dass sie keiner Gebäudeschicht zugeordnet werden können.

__*Elemente mit unzureichenden geometrischen Angaben*__: Diesen Elementen fehlt es an vollständigen geometrischen Angaben, so dass sie nicht für Berechnungen verwendet werden können.
