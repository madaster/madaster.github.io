---
title: Zirkularität
description: Objekt - Zirkularität und Demontierbarkeit
ref: building-circularity
type: FAQ
redirect_from:
  - platform-pages/building/circularity-ci
  - platform-pages/building/circularity-details
  - platform-pages/building/circularity-flows
  - platform-pages/building/detachability-details
  - platform-pages/building/flow-details
---

## Welche Informationen finde ich hier und welche Anpassungen kann ich tätigen?

### Madaster Zirkularitätsindikator (MZI)
Der Madaster Zirkularitätsindikator bewertet den Grad der Kreislauffähigkeit jedes einzelnen Objekts und stuft ihn, basierend auf den von den Madaster-Nutzenden hochgeladenen Informationen, zwischen 10 und 100 % ein. Ein Objekt, dass aus Primärrohstoffen errichtet wurde und am Ende der Objektlebensdauer auf der Deponie endet, ist ein vollständig „lineares“ Objekt mit einem Madaster-ZI von 10 %. Am anderen Ende des Spektrums liegen Objekte, die aus wiederverwerteten und/oder nachwachsenden Materialien errichtet wurden, welche am Ende der Lebensdauer des Objekts problemlos demontiert und wiederverwendet werden können. Dies sind „vollständig kreislauffähige“ Objekte mit einem Score von 100 %, jedoch erreichen die Scores in der Praxis diesen Wert kaum.

Eine detailierte Beschreibung des Madaster Zirkularitätsindikators finden Sie in unserer <a href="/de/de/knowledge-base/calculations#madaster-zirkularit%C3%A4tsindikator-mzi" target="_blank">Wissensdatenbank - Kalkulation</a>.

### Demontierbarkeit
Der Demontierbarkeitsindex auf Objektebene wird nach einer Methodik berechnet, die auf der Website des <a href="https://www.dgbc.nl/publicaties/circular-buildings-een-meetmethodiek-voor-losmaakbaarheid-v11-26">Dutch Green Building Council</a> beschrieben ist.
Die Berechnung erfolgt für alle Elemente, die mit Produkten verbunden sind, für die vollständige Informationen zur Demontierbarkeit vorliegen. Jedes Produkt wird anhand der Verbindungsart, der Zugänglichkeit der Verbindung, der Kreuzungen und der Produktkanten bewertet. Die Masse der betreffenden Elemente wird als Gewichtungsfaktor verwendet.
Der Qualitätsindex gibt die Anzahl der Elemente an, bei denen die Demontierbarkeitsinformation vorliegen im Vergleich zur Gesamtzahl der Elemente des Objekts (in den betreffenden Gebäudeschichten). 

Eine detailierte Beschreibung des Madaster Zirkularitätsindikators finden Sie in unserer <a href="/de/de/knowledge-base/calculations#demontierbarkeit-detachability" target="_blank">Wissensdatenbank - Kalkulation</a>.

### Unbekannt
Unbekannte Elemente sind solche, die bei den Berechnungen nicht berücksichtigt wurden. Dies kann aus drei verschiedenen Gründen resultieren:

1. **Elemente mit fehlender Verknüpfung**: Diese Elemente sind nicht mit Datensätzen einer Material-/Produktdatenbank verknüpft und können daher nicht bei Berechnungen berücksichtigt werden.
1. **Elemente mit unbekannter Gebäudeschicht**: Diesen Elementen fehlen Informationen zur Klassifizierung gemäß DIN 276:2018-12, so dass sie keiner Gebäudeschicht zugeordnet werden können oder die zugewiesenen Klassifizierungen nach DIN276:2018 ist nicht Teil einer Gebäudeschicht nach den Shearing Layers. Eine Zuweisung der Kostengruppen auf die Shearing Layers ist <a href="https://platform.madaster.com/admin/classifications/cd373c62-3c53-4bd0-bedb-0e77bd36d60a" target="">hier</a> einzusehen.
1. **Elemente mit unzureichenden geometrischen Angaben**: Diesen Elementen fehlen geometrische Angaben, die zu dem verknüpften Produkt und dessen Funktionale Einheit passen, so dass keine Berechnung zustande kommen kann.

### Dropdown-Menü
Über das Dropdown-Menü können die Materialströme folgendermaßen angezeigt werden: 
1. Total
1. Gebäudeschichten 
1. Klassifizierungen
1. Material/Produkt 

Die Inputströme werden auf der Grundlage der Definition von Primär- und Sekundärrohstoffen klassifiziert. Neue Rohstoffe werden in nachwachsende und nicht-nachwachsende Materialien unterteilt, wobei nachwachsende Materialien weiter in nachhaltig produzierte und nicht-nachhaltig produzierte Materialien unterteilt werden. Sekundärrohstoffe werden in Material aus Wiederverwendung, Material aus Recycling und Material aus Downcycling unterteilt. Der Output wird in Material zur Wiederverwendung, Material zum Recycling, Material zum Downcycling, Material zur Deponierung und Material zur Verbrennung unterteilt.
Materialien mit dem niedrigsten MZI werden in rot dargestellt, während Materialien mit einem hohen MZI in grün angezeigt werden.

Ist das Feature **Einblicke in den 3D-Viewer** für den Account eingeschaltet, so sieht man unter "Material/Produkt" eine 3D-Ansicht der Materialien/Produkte auf der Grundlage ihres MZI sowie ihrer Input- und Outputströme farblich kodiert.

> Das Feature **Einblicke in den 3D-Viewer** kann individuell zum Abonnement dazugebucht werden. Weitere Informationen finden Sie in unserer <a href="/de/de/knowledge-base/features.html" target="_blank">Wissensdatenbank - Features</a>.

## Nicht gefunden, was Sie suchen?
Falls Ihre Frage nicht beantwortet werden konnte, besuchen Sie unsere <a href="https://docs.madaster.com/de/de/" target="_blank">Home-Seite der Madaster Docs</a>. Über die Suchleiste werden Sie zu den Antworten geleitet, die Sie suchen.