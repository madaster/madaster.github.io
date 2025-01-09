---
title: Anreichern
description: Objekt - Anreichern
ref: building-file-enrich
type: FAQ
---

## Welche Informationen finde ich hier und welche Anpassungen kann ich tätigen?
Nach dem Import und dem Auslesen der Quelldatei wird ein automatischer Verknüpfungsprozess eines (IFC)-Elements mit einem Produkt oder einem Material einer Datenbank durchgeführt. Es ist möglich, dass Elemente nicht abgeglichen wurden oder dass auf der Grundlage der Suchkriterien ein falscher Abgleich stattgefunden hat. Es wird daher empfohlen, die automatischen Verknüpfungen auf die Plausibilität zu prüfen.

> Es ist dringend empfohlen, vor dem Import einer Quelldatei sicherzustellen, dass die Informationen (bspw. Materialbezeichnung) in der Quelldatei gut mit den Informationen in den ausgewählten Datenbanken übereinstimmen. Nutzen Sie hierfür bestensfalls genaue Materialbeschreibungen der frei zugänglichen Datenbanken, die Sie für den Abgleich nutzen können.

### Erläuterung des Hauptbildschirms
Der Hauptbildschirm zeigt die Liste aller in der Quelldatei enthaltenen Elemente. In den Spalten werden folgende Informationen angezeigt:

1. Element: Elementname aus der Quelldatei.
1. Materialien: Materialname aus der Quelldatei.
1. Produkt/Material: das Produkt/Material, mit dem das Element mit einem Datensatz einer ausgewählten Datenbank verbunden ist.
1. Volumen/Fläche/Länge: geometrische Informationen des Elements der Quelldatei, die von Madaster ausgelesen wurden.
1. Menge: die Anzahl der Elemente dieses Typs/Namens.
1. Symbol <iconify-icon inline icon='mdi-link-variant'/>: Das Element der Quelldatei ist mit einem Datensatz einer ausgewählten Datenbank verbunden.

Durch Auswahl eines oder mehrerer Elemente erscheint ein Dialogblock, mit dem die Elemente angepasst werden können. Es besteht ebenfalls die Möglichkeit, die ausgewählten Elemente in einem 3D-Viewer <iconify-icon inline icon='mdi-axis-arrow-info'/> darstellen zu lassen, um die Elemente besser zu lokalisieren und eventuelle Anpassungen leichter durchzuführen. Alternativ sind ebenfalls die Element-IDs <iconify-icon inline icon='mdi-identifier'/> anzeigbar, sodass die Anpassungen direkt im BIM-Modell verfolgbar sind.

### Objekt anreichern
Weitere Informationen dazu, wie Sie Ihr Objekt auf der Madaster-Plattform mit Informationen anreichern, finden Sie in unseren <a href="https://docs.madaster.com/de/de/get-started/enrich-objects-with-material-and-product-databases" target="_blank">Ersten Schritten - Objekt anreichern</a>.

### Vorbereiten und Anpassen der Quelldatei
Weitere Informationen dazu, wie Sie Ihre Quelldatei vorbereiten können und welche Anforderungen für die optimierte Nutzung der Madaster-Plattform bestehen, finden Sie in unserer <a href="https://docs.madaster.com/de/de/knowledge-base/preparing-bim-ifc-source-files.html" target="_blank">Wissensdatenbank - Vorbereiten einer Quelldatei</a>.

## Nicht gefunden, was Sie suchen?
Falls Ihre Frage nicht beantwortet werden konnte, besuchen Sie unsere <a href="https://docs.madaster.com/de/de/" target="_blank">Home-Seite der Madaster Docs</a>. Über die Suchleiste werden Sie zu den Antworten geleitet, die Sie suchen.