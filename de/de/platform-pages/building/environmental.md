---
title: Umwelt
description: Objekt - Umwelt
ref: building-environmental
type: FAQ
---
## Welche Informationen finde ich hier und welche Anpassungen kann ich tätigen?

Die gesamten Umweltauswirkungen (A1-A3) und die Umweltauswirkungen pro m<sup>2</sup> (A1-A3) werden angezeigt. Wird eine Benchmark ausgewählt und sind entsprechende Informationen verfügbar, wird das Gebäude mit anderen verglichen. 
Über die Schaltfläche oben links können Sie die **Benchmark anpassen** <iconify-icon inline icon='mdi-vector-polyline-edit'/>. Weitere Informationen zum Einrichten von Benchmarks finden Sie <a href="../knowledge-base/stay-organized#verwalten-von-objekten" target="_blank">hier</a>.
Unbekannte Elemente werden angezeigt, damit sie damit sie angepasst und in die Berechnungen einbezogen werden können. Mit Hilfe der Dropdown-Listen können die Umwelt-Indikatoren nach Gesamtmenge, Gebäudeschicht, Klassifizierung und Material/Produkt angezeigt werden. 

### Umweltauswirkungen
Der Indikator für die Umweltauswirkungen wird entlang der Lebensdauer eines Gebäudes angezeigt, welche die unten beschriebenen Phasen umfasst.

Der Lebenszyklus eines Gebäudes wird in die folgenden Phasen unterteilt:

1. **A1-A3 Herstellung bzw. Produktion**: Umfasst die Rohstoffgewinnung, den Transport und die Herstellung von Baumaterialien und -produkten.

1. **A4-A5 Errichtungsphase**: Umfasst den Transport zur Baustelle und die Montage von Materialien und Produkten zu einem Gebäude.

1. **B1-B5 Nutzungsphase**: Umfasst die Nutzung, Wartung, Reparatur, den Austausch und die Aufarbeitung von Materialien und Produkten innerhalb eines Gebäudes.

1. **B4 Ersatz**: Die Ökobilanzierungsmethodik legt fest, wie häufig ein Produkt ersetzt wird. Die während der Herstellung, des Einbaus und des Rückbaus entstehenden Umweltwirkfaktoren werden mit der Anzahl der erforderlichen Ersatzvorgänge multipliziert, wodurch die Umweltauswirkungen der B4-Ersatzphase definiert werden.

1. **B6 Betrieblicher Energieeinsatz**: Emissionen, die während des Gebäudebetriebs verursacht werden.

1. **C1-C4 Entsorgungsphase**: Umfasst den Rückbau eines Gebäudes sowie den Transport, die Abfallverarbeitung und die Entsorgung seiner Materialien und Produkte.

1. **D Vorteile und Belastungen außerhalb der Systemgrenzen**: Umfasst das Wiederverwendungs- und Recyclingpotenzial der Materialien und Produkte eines Gebäudes. Da nicht garantiert werden kann, dass die Wiederverwendung oder das Recycling in der Zukunft stattfinden wird, ist Stufe D eine Annahme, die nicht in den Berechnungen für das gesamte Gebäude berücksichtigt wird.


### 3D-Ansicht
Der Indikator für die Umweltauswirkungen wird nach Material/Produkt über alle Lebenszyklusphasen hinweg angezeigt. In der 3D-Darstellung sind die Materialien/Produkte je nach Höhe ihres Beitrags zum Umwelt-Indikator farblich gekennzeichnet. Materialien mit den größten Umweltauswirkungen werden in rot dargestellt, während Materialien mit 0 oder sogar regenerativem Beitrag in grün angezeigt werden.

> Dieses Feature kann individuell zum Abonnement dazugebucht werden. Weitere Informationen finden Sie in unserer <a href="https://docs.madaster.com/de/de/knowledge-base/features.html" target="_blank">Wissensdatenbank - Features</a>.

### Unbekannt
Unbekannte Elemente sind solche, die bei den Berechnungen nicht berücksichtigt wurden. Dies kann aus drei verschiedenen Gründen resultieren:

1. Unverknüpfte Elemente: Diese Elemente sind nicht mit Produktdatensatz verknüpft wurden und können daher nicht bei Berechnungen berücksichtigt werden.
1. Elemente ohne Klassifikation: Diesen Elementen fehlen Informationen zur Klassifizierung gemäß DIN 276:2018-12, so dass sie keiner Gebäudeschicht zugeordnet werden können. Die Ergebnisse werden zwar berechnet, jedoch werden sie in der Auswertung in der Gebäudekategorie "Unbekannt" angezeigt.
1. Elemente mit unzureichenden geometrischen Angaben: Diesen Elementen fehlen entsprechende geometrische Angaben, so dass keine Berechnungen zustande kommen kann.

## Nicht gefunden, was Sie suchen?
Falls Ihre Frage nicht beantwortet werden konnte, besuchen Sie unsere <a href="https://docs.madaster.com/de/de/" target="_blank">Home-Seite der Madaster Docs</a>. Über die Suchleiste werden Sie zu den Antworten geleitet, die Sie suchen.
