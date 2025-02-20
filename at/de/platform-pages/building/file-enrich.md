---
title: Anreichern
description: Objekt - Anreichern
ref: building-file-enrich
type: FAQ
---

## WELCHE INFORMATIONEN WERDEN HIER ANGEZEIGT?
Der Prozess des Abgleichs eines (IFC)-Elements mit einem Produkt oder einem Material wird von Madaster automatisch nach dem Import und dem Auslesen der Quelldatei durchgeführt. Es ist möglich, dass Elemente nicht abgeglichen wurden oder dass auf der Grundlage der Suchkriterien ein falscher Abgleich stattgefunden hat. In der ERWEITERN -Maske kann der Matching-Prozess überprüft und abgeschlossen werden, das sogenannte “Anreichern” des Prozesses.

> **HINWEIS**: Madaster rät dringend, vor dem Import einer Quelldatei sicherzustellen, dass die Informationen in der Quelldatei gut mit den Informationen in den ausgewählten Datenbanken/Quellen übereinstimmen. Dies kann durch die Verwendung des Materialnamens in der EPEA-Datenbank (siehe <a href="../files/at/Epea_Generic.xlsx">EPEA Generic</a>) erfolgen oder indem sichergestellt wird, dass der Name in den Quelldateien mit der (eigenen) ausgewählten Datenbank/Quelle übereinstimmt.

## LINKER SEITENRAND
Auf der linken Seite steht eine Such- und Filterfunktion zur Verfügung. Die Filter können aufgeklappt werden, um eine Auswahl zu treffen:

- **Elementstatus:** Filter für verknüpfte/nicht verknüpfte Elemente. Insbesondere für die Anreicherung ungebundener Elemente der wichtigste Filter.
- **Gebäudeschicht:** Filter für die Gebäudeschicht (nach Stewart Brand).
- **Klassifizierungsmethoden:** Filter auf verfügbaren Klassifizierungscode.
- **Bauphase:** Filter für die vorhandene Bauphase (Rückbau / Verbleibend / Bauabfälle / Einbau).
- **Etagen:** Filter für die vorhandenen Stockwerke/Gebäudeebenen.
- **IFC-Klassen:** Filter für die verfügbaren IFC-Typen.
- **Elementberechnung:** Filter für eingebettete/ausgeschlossene Elemente.
- **Objektnummer:** Filter für Objektnummer (wenn vorhanden).
- **Datenbank:** Filter für die verknüpften Datenbank(en).
- **Mapping-Status:** Filter für gültigen oder ungültigen Mapping-Status.
- **Elemente mit Unterelementen:** Filter für Elemente mit oder ohne Unterelement(en).
- **Produkt:** Filter für verknüpfte Produkte/Materialien.
- **Skalierbar:** Filter für skalierbare Elemente.
- **Maßeinheit:** Filter für Dimensionseinheit: Volumen / Oberfläche / Länge / ... .

> **Hinweis**: Wenn Sie mit Wortfragmenten suchen möchten, verwenden Sie das Symbol *, um anzugeben, ob sich das Fragment am Anfang, am Ende oder in der Mitte des Wortes befindet.
- Beispiele:
    - *Beton: Liefert Treffer, bei denen "Beton" am Ende des Wortes steht.
    - Beton*: Liefert Treffer, bei denen "Beton" am Anfang des Wortes steht.
    - *Beton*: Liefert Treffer, bei denen "Beton" irgendwo im Wort vorkommt.
- Anwendungsfälle:
    - "Stahlbeton C25/30 (2% Bewehrung)" → Suchen mit *Beton.
    - "Betonfertigteil Decke" → Suchen mit Beton*.
- Die Suche umfasst auch die Beschreibungen und Zusammensetzungen der Produkte.
    - Beispiel: Bei einer Suche nach Beton kann auch "Zementbauplatte" als Ergebnis erscheinen, da in der Zusammensetzung Beton enthalten ist.

## HAUPTBILDSCHIRM
Der Hauptbildschirm zeigt die Liste aller in der Quelldatei enthaltenen Elemente. In den Spalten werden folgende Informationen angezeigt:

- **Element:** Elementname aus der Quelldatei.
- **Materialien**: Materialname aus der Quelldatei.
- **Produkt/Material:** das Produkt/Material, mit dem das Element verbunden ist.
- **Volumen/Fläche/Länge**: Dimensionen der Elemente.
- **Menge**: die Anzahl der Elemente dieses Typs/Namens.
- **Symbol:** Zeigt an, ob das Element verlinkt / unverlinkt / ausgeschlossen / ungültig ist. 

Durch Auswahl eines oder mehrerer Elemente erscheint ein Dialogblock, mit dem die Elemente überschrieben/getrennt oder eingebettet/ausgeschlossen werden können. Das Einschließen oder Ausschließen eines Elements führt dazu, dass dieses Element in die Berechnungen einbezogen/nicht einbezogen wird. Dies kann z.B. für die Masse des umgebenden Geländes verwendet werden, wenn es in der Quelldatei enthalten ist. Oder wenn es Überschneidungen gibt.

## 3D-MODELL
Am oberen Rand des Fensters, in der blauen Leiste, befindet sich eine Schaltfläche zum Aktivieren eines 3D-Viewers. Dies ist nur möglich, wenn die Quelldatei ein IFC-Modell ist:

- 3D-Modell anzeigen: Der 3D-Viewer öffnet sich und zeigt das Gesamtmodell.
- Auswahl im 3D-Modell anzeigen: Der 3D-Viewer öffnet sich und zeigt das/die ausgewählte(n) Element(e).

Wenn ein Element in der 3D-Ansicht ausgewählt wird, erscheint ein Dialogblock, mit dem die Elemente überschrieben/getrennt oder eingebettet/ausgeschlossen werden können. Zu diesem Zeitpunkt ist das fragliche Element noch nicht in der Liste ausgewählt.
