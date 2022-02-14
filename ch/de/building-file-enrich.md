---
title: Bereichern
ref: building-file-enrich
---

## WELCHE INFORMATIONEN WERDEN HIER ANGEZEIGT?
Der Prozess des Abgleichs eines (IFC)-Elements mit einem Produkt oder einem Material wird von Madaster automatisch nach dem Import und dem Auslesen der Quelldatei durchgeführt. Es ist möglich, dass Elemente nicht abgeglichen wurden oder dass auf der Grundlage der Suchkriterien ein falscher Abgleich stattgefunden hat. In der ANREICHERN-Maske kann der Matching-Prozess überprüft und abgeschlossen werden, das sogenannte “Anreichern” des Prozesses.

**HINWEIS**: Madaster rät dringend, vor dem Import einer Quelldatei sicherzustellen, dass die Informationen in der Quelldatei gut mit den Informationen in den ausgewählten Datenbanken/Quellen übereinstimmen. Dies kann durch die Verwendung des Materialnamens in der Madaster-Datenbank (siehe [https://docs.madaster.com/files/ch/de/Madaster%20Materialien.xlsx]) erfolgen oder indem sichergestellt wird, dass der Name in den Quelldateien mit der (eigenen) ausgewählten Datenbank/Quelle übereinstimmt.

## LINKER SEITENRAND
Auf der linken Seite steht eine Such- und Filterfunktion zur Verfügung. Der Filter "Themen" kann aufgeklappt werden, um eine Auswahl zu treffen:

- Statuselement: Filter für verknüpfte/nicht verknüpfte Elemente. Insbesondere für die Anreicherung ungebundener Elemente der wichtigste Filter.
- Berechnungselement: Filter auf eingebettete/ausgeschlossene Elemente.
- IFC-Typ: Filter für die verfügbaren IFC-Typen.
- Bauphase: Filter für die vorhandene Bauphase (vorhanden / Abriss / Rohbau / neu / Final).
- Bauschichten: Filter für die Gebäudeschicht (nach Stewart Brand).
- Stockwerke: Filter für die vorhandenen Stockwerke/Gebäudeebenen.
- Klassifizierungsmethoden: Filter auf verfügbaren Klassifizierungscode.
- Dimension der Einheit: Filter auf Dimensionseinheit: Volumen / Oberfläche / Länge.

## HAUPTBILDSCHIRM
Der Hauptbildschirm zeigt die Liste aller in der Quelldatei enthaltenen Elemente. In den Spalten werden folgende Informationen angezeigt:

- Element: Elementname aus der Quelldatei.
- Materialien: Materialname aus der Quelldatei.
- Produkt/Material: das Produkt/Material, mit dem das Element verbunden ist.
- Anzahl: die Anzahl der Elemente dieses Typs/Namens.
- Symbol: Link.

Durch Auswahl eines oder mehrerer Elemente erscheint ein Dialogblock, mit dem die Elemente überschrieben/getrennt oder eingebettet/ausgeschlossen werden können. Das Einschliessen oder Ausschliessen eines Elements führt dazu, dass dieses Element in die Berechnungen einbezogen/nicht einbezogen wird. Dies kann z.B. für die Masse des umgebenden Geländes verwendet werden, wenn es in der Quelldatei enthalten ist. Oder wenn es Überschneidungen gibt.

## 3D-MODELL
Am oberen Rand des Fensters, in der blauen Leiste, befindet sich eine Schaltfläche zum Aktivieren eines 3D-Viewers. Dies ist nur möglich, wenn die Quelldatei ein IFC-Modell ist:

- 3D-Modell anzeigen: Der 3D-Viewer öffnet sich und zeigt das Gesamtmodell.
- Auswahl im 3D-Modell anzeigen: Der 3D-Viewer öffnet sich und zeigt das/die ausgewählte(n) Element(e).

Wenn ein Element in der 3D-Ansicht ausgewählt wird, erscheint ein Dialogblock, mit dem die Elemente überschrieben/getrennt oder eingebettet/ausgeschlossen werden können. Zu diesem Zeitpunkt ist das fragliche Element noch nicht in der Liste ausgewählt.