---
title: Objekt anreichern
description: Quelldateien mit Material- und Produktdaten anreichern, Neuberechnung und Fehlerbehebung
ref: enrich-objects-with-material-and-product-databases
type: Erste Schritte
menubar: get-started-nav
---

Quelldateien mit Material- und Produktdaten anreichern, Neuberechnung und Fehlerbehebung

## Qualität der Quelldatei und des Zuordnungsprozesses

Sobald eine Quelldatei hochgeladen und verarbeitet wurde, können Sie durch Klicken auf den Dateinamen Einblicke in folgende Analysen erhalten.

### Qualität der Quelldatei
  * Prozentsatz der Elemente, die eine <a href="../knowledge-base/classifications#klassifizierung-der-objektelemente" target="_blank">Klassifikation</a> enthalten.
  * Prozentsatz der Elemente, die eine **Materialbeschreibung** enthalten.
  * Prozentsatz der Elemente, die **Geometrische Angaben** (Basismengen) enthalten.

### Qualität des Zuordnungsprozesses
  * Prozentsatz der Elemente, die mit Material- Und Produkt-**Datensätzen verknüpft** sind.
  * Prozentsatz der Elemente mit **bekannter Masse**.

## Zuordnungsprozesses überprüfen

Klicken Sie die Schaltfläche **Erweitern** <iconify-icon inline icon='mdi-link-variant-plus'/> und wählen Sie **Manuell**, um in die Detailansicht zu gelangen. Den **Fortschritt des Erweiterungsprozesses** können Sie mithilfe der Filter auf der linken Seite analysieren. z.B. nach fehlenden Materialverknüpfungen, Klassifizierungen oder geometrischen Informationen zu suchen.

Fehlende geometrische Informationen müssen über die Quelldateien ergänzt und mittels neuer Version hochgeladen werden. <a href="../knowledge-base/preparing-bim-ifc-source-files" target="_blank">Hier</a> erfahren Sie, wie Sie Ihre IFC-Datei für Madaster vorbereiten.

Die folgenden Optionen stehen für manuelle Anpassungen und Zuordnungen zur Verfügung, wenn vor dem Element die zugehörige Checkbox <iconify-icon inline icon='mdi-checkbox-marked'/> ausgewählt wird:

  * **Verknüpfen** <iconify-icon inline icon='mdi-link-variant'/> von Elementen, denen Materialinformationen fehlen oder die nicht automatisch mit einem Produktdatensatz verknüpft wurden (siehe <a href="../get-started/enrich-objects-with-material-and-product-databases#manueller-zuordnungsprozess">Manueller Zuordnungsprozess</a>)
  * **Ergänzen oder Ändern** <iconify-icon inline icon='mdi-pencil-outline'/> von Elementinformationen, wie Objektnummer, Phase, Klassifikation, Materialherkunft/Materialverwertung und Demontierbarkeit
  * **Aufheben von Verknüpfungen** <iconify-icon inline icon='mdi-link-variant-off'/> von Elementen und Produktdatensätzen, die nicht passen oder nicht dem Projekt entsprechen
  * **Teilen mehrschichtiger Elemente** <iconify-icon inline icon='mdi-set-split'/> bzw. von Elementen mit verschiedenen Materialien, um die getrennte Verknüpfung mit Produktdatensätzen zu ermöglichen
  * **Einschließen** und **Ausschließen** von Elementen, die Teil oder kein Teil der Berechnungen sein sollten (z.B. Luftschichten) 

> Hinweis: Bei der **Suche** <iconify-icon inline icon='mdi-magnify'/> nach Elementen wird empfohlen, vor und nach dem Suchbegriff ein * hinzuzufügen, um beliebige Buchstaben vor und/oder nach dem Wort einzuschließen und bessere Treffer zu erhalten.

## Manueller Zuordnungsprozess

Wenn die automatische Zuordnung nicht alle Elemnte verknüpfen konnte, können Sie Elemente manuell mit Material- oder Produktdatensätzen verknüpfen.

1. Aktivieren Sie die **Checkbox** <iconify-icon inline icon='mdi-checkbox-marked'/> eines oder mehrerer Elemente in der Erweitern-Oberfläche.
2. Klicken Sie auf **Verknüpfen** <iconify-icon inline icon='mdi-link-variant'/>. Folgende Optionen stehen zur Verfügung:
   
   **a.** Fügen Sie Ihrer automatisch mit dem Account erstellten Accountdatenbank <iconify-icon inline icon='database'/> ein Produkt hinzu. Informationen dazu finden Sie <a href="../get-started/create-your-own-databases-with-custom-materials-and-products#produkte-erstellen-und-bearbeiten" target="_blank">hier</a>.
   
   **b.** Verknüpfen Sie das Element mit einem Produkt oder Material aus einer vorhandenen Datenbank, indem Sie die Suchfunktion <iconify-icon inline icon='mdi-magnify'/> verwenden, das Kästchen des Materials/Produkts markieren <iconify-icon inline icon='mdi-checkbox-marked'/> und auf das Symbol <iconify-icon inline icon='mdi-link-variant'/> oben rechts klicken. Wählen Sie die passende Option und klicken Sie **OK**

> Hinweis: Während Sie die Datei anreichern, führt die Madaster-Plattform im Hintergrund einen neuen Zuordnungsprozess durch. Dadurch verändert sich das Ergebnis der „Qualität des Zuordnungsprozesses“ sowie der Auswertungen. Um Sie in Ihrem Arbeitsfluss nicht zu unterbrechen, werden Sie nach Abschluss der Anreicherung aufgefordert, eine Neuberechnung durchzuführen. Klicken Sie dazu im Tab Allgemeines oder Dossier die Schaltfläche **Neu berechnen** <iconify-icon inline icon='mdi-calculator-variant-outline'/>.

## Erneutes automatisches Zuordnen

Über die Schaltfläche **Erweitern** <iconify-icon inline icon='mdi-link-variant-plus'/> und die Wahl **Automatisch** können Sie Sprachen und Datenbanken für eine erneute automatische Zuordnung hinzufügen/löschen. Wenn Sie das Kästchen **Zurücksetzen aller Zuordnungen** aktivieren, werden alle bisherigen Verknüpfungen aufgehoben. Dies kann nützlich sein, wenn beispielsweise die Datei beim Hochladen mit der falschen Datenbank abgeglichen wurde und Sie den Aufwand für eine komplette manuelle Verknüpfung vermeiden wollen.

> Hinweis: Suchen Sie Informationen zur Erstellung Ihrer eigenen Materialien und Produkte? Klicken Sie <a href="../get-started/create-your-own-databases-with-custom-materials-and-products" target="_blank">hier</a> für weitere Informationen.

<a class="next-button" href="../get-started/create-your-own-databases-with-custom-materials-and-products">Nächster Schritt: Individuelle Datenbank einrichten</a>