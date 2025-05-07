---
title: Masse
description: Objekt - Masse
ref: building-performance-mass
type: FAQ
redirect_from:
  - platform-pages/building/level-product
---

## Welche Informationen finde ich hier und welche Anpassungen kann ich tätigen?
Die Gesamtmasse und die Materialintensität werden angezeigt. Wird eine Benchmark ausgewählt, wird das Objekt mit ausgewählten verglichen. 
Über die Schaltfläche oben links können Sie die **Benchmark anpassen** (im Performance-Tab) <iconify-icon inline icon='mdi-vector-polyline-edit'/>. Weitere Informationen zum Einrichten von Benchmarks finden Sie <a href="de/de/knowledge-base/stay-organized#verwalten-von-objekten" target="_blank">hier</a>.

### Dropdown-Möglichkeiten

1. **Matrix - Gebäudeschichten**: Darstellung der Masse aufgeteilt nach Gebäudeschichten. Über das Klicken auf die Kreisdiagramme ist eine Betrachtung in einer tieferen Ebene möglich.
1. **Matrix - Klassifizierung**: Darstellung der Masse aufgeteilt nach Klassifizierung (bspw. nach Kostengruppen nach DIN 276). Über das Klicken auf die Kreisdiagramme ist eine Betrachtung in einer tieferen Ebene möglich.
1. **Gebäudeschichten**: Klicken Sie auf die Diagramme, um detailliertere Informationen einzusehen.
1. **Materialfamilien**: Klicken Sie auf die Diagramme, um detailliertere Informationen einzusehen.

### Filter und Anpassungsmöglichkeiten
1. Im **Filter** <iconify-icon inline icon='mdi-filter-outline'/> können Materialien eingegeben werden, und nur diese Materialien werden dann in der Tabelle angezeigt.
1. Durch Klicken auf **Etagen** <iconify-icon inline icon='mdi-layers-search-outline'/> können Sie die Darstellung nach Etagen filtern, um diese separat zu betrachten.
1. Durch Klicken auf **Quelldateien** <iconify-icon inline icon='mdi-file-check-outline'/> erscheint ein Pop-up-Fenster, in dem die Qualität und Vollständigkeit der Informationen der aktiven Quelldateien angezeigt wird.
1. Durch Klicken auf **Ansehen** <iconify-icon inline icon='mdi-rotate-right-variant'/> werden die Materialfamilien vertikal und die Gebäudeschichten horizontal positioniert. Dadurch erhalten Sie die gleichen Daten in gedrehter Übersicht. Die Prozentsätze summieren sich nun in der Materialklassifikationsspalte.

### Unbekannte Elemente
Unbekannte Elemente sind solche, die bei den Berechnungen nicht berücksichtigt wurden. Dies kann aus drei verschiedenen Gründen resultieren:

1. **Elemente mit fehlender Verknüpfung**: Diese Elemente sind nicht mit Datensätzen einer Material-/Produktdatenbank verknüpft und können daher nicht bei Berechnungen berücksichtigt werden.
1. **Elemente mit unbekannter Gebäudeschicht**: Diesen Elementen fehlen Informationen zur Klassifizierung gemäß DIN 276:2018-12, so dass sie keiner Gebäudeschicht zugeordnet werden können oder die zugewiesenen Klassifizierungen nach DIN276:2018 ist nicht Teil einer Gebäudeschicht nach den Shearing Layers. Eine Zuweisung der Kostengruppen auf die Shearing Layers ist <a href="https://platform.madaster.com/admin/classifications/cd373c62-3c53-4bd0-bedb-0e77bd36d60a" target="">hier</a> einzusehen.
1. **Elemente mit unzureichenden geometrischen Angaben**: Diesen Elementen fehlen geometrische Angaben, die zu dem verknüpften Produkt und dessen Funktionale Einheit passen, so dass keine Berechnung zustande kommen kann.

## Nicht gefunden, was Sie suchen?
Falls Ihre Frage nicht beantwortet werden konnte, besuchen Sie unsere <a href="https://docs.madaster.com/de/de/" target="_blank">Home-Seite der Madaster Docs</a>. Über die Suchleiste werden Sie zu den Antworten geleitet, die Sie suchen.
