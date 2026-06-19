---
title: Qualitätskontrolle und Qualitätsmanagement 
description: Empfehlungen zur abschließenden Überprüfung abgeschlossener Projekte.
ref: quality-check
type: Knowledge Base
menubar: knowledge-base-nav
---

Empfehlungen zur abschließenden Überprüfung abgeschlossener Projekte..

## Grundlegende Betrachtung 

Zunächst sollte immer die Karte „Unbekannt“ geprüft werden, welche in allen Auswertungstabs (Masse, Zirkularität, Umwelt, Finanziell) angezeigt wird, da diese Auskunft darüber gibt, wie viele Elemente 
1. Nicht verknüpft sind 
2. Keine Klassifizierung haben 
3. Unzureichende geometrische Angaben haben 

Welche Elemente dies betrifft wird nach klicken auf die jeweilige Zahl angezeigt. Genauere Informationen zu den gezeigten Elementen erhalten Sie nach klicken auf die Stückzahl <iconify-icon inline icon='mdi-eye-outline'/> neben dem Element.

Empfohlen ist hier jeweils einen Nullwert anzustreben. Ausgeschlossene Elemente <iconify-icon inline icon='mdi-eye-outline-off'/> werden bei der Zählung nicht berücksichtigt.

## Prüfung der automatisierten Produktdatensatzverknüpfung <br>(Validierung der Ergebnisse)

Wie kann geprüft werden, ob durch die automatische Zuordnung Elemente korrekt mit Produktdatensätzen verknüpft wurden? Im Folgenden wird erläutert, worauf generell zu achten ist und welche Prüfwege – abhängig von der gewünschten Detailtiefe – empfehlenswert sind.

### Vorbetrachtung 

1. **Wurden alle Materialangaben aus der Quelldatei ausgelesen?**<br>
Klicken Sie im Dossier des Objekts auf die entsprechende Quelldatei. Unter „Qualität der Quelldatei“ sehen sie unter "Materialbeschreibung" eine prozentuale Angabe, für wie viele Elemente eine Materialangabe gefunden wurde.

    > Hinweis: Materialien sollten über alle Elemente in demselben Attribut vermerkt sein. Gemäß den buildingSMART-Richtlinien wird empfohlen, das Attribut „ifcmaterial“ zu nutzen. Alternativ kann das Attribut über die „Voreinstellungen für den Upload“ festgelegt werden. Es werden nicht mehrere Attribute ausgelesen oder kombiniert.

2. **Welche Elemente haben keine Materialinformationen?**<br>
Gehen Sie zu „Erweitern“ (Manuell) und sortieren Sie nach der Spalte „Material / Produkt“.

3. **Welche Elemente sind nicht mit einem Produktdatensatz verknüpft?**<br>
Gehen Sie zu „Erweitern“ (Manuell) und verwenden Sie den Filter „Elementstatus“ (nicht verknüpft), um zu sehen, wo die Spalte „Produkt / Material“ leer ist.

    > Hinweis: Einzelheiten zu Elementen mit mehreren Materialien oder Unterelementen finden Sie unter <a href="../knowledge-base/work-processes.html#materialzusammensetzungen-von-elementen" target="_blank">Arbeitsprozesse</a> oder im **BIM-Handbuch** im <a href="../resources/downloads" target="_blank">Download-Bereich</a>.


    > Hinweis: Wenn Sie es bevorzugen mit einer Bill of Quantities im Excelformat zu arbeiten, können Sie diese nach Klick auf die entsprechende Quelldatei im Dossier über „Datei exportieren <iconify-icon inline icon='mdi-file-download-outline'/>“ generieren.

### Prüfniveau 1 - Sichtprüfung

**Ziel:** Die Massen müssen im Wesentlichen korrekt verknüpft sein. <br>
Es geht nicht darum, das eine falsch verknüpfte Element unter 40.000 zu finden. 

Erscheint die prozentuale Verteilung in der Matrix des Massetabs auf Gebäudeschichten/Klassifikationen und Materialfamilien sinnvoll und entspricht sie der Bauweise (z. B. Holzbau- oder Massivbauweise)? 

> Hinweis: Wenn Elemente nicht hohl modelliert, jedoch mit einem Volumendatensatz verknüpft wurden, kann dies zu einem Missverhältnis führen (z.B. bei Fensterrahmen, Trägerprofilen oder insbesondere bei TGA-Elementen). 

Klicken Sie für mehr Details auf die Kreisdiagramme der Matrix und dann auf die dargestellte Stückzahl <iconify-icon inline icon='mdi-eye-outline'/> (#[Stückzahl]) oder nutzen Sie die „Filter <iconify-icon inline icon='mdi-filter-outline'/>“ nach Material/Produkt und Klassifizierungen bzw. die Darstellungsalternativen im Dropdown nach Gebäudeschichten oder Materialfamilien. 

### Prüfniveau 2 – Detailprüfung

**Ziel:** Detaillierte Prüfung jedes verknüpften Elements. <br>
Eine hundertprozentige Gewissheit erfordert eine detaillierte manuelle Prüfung aller Elementverknüpfungen. 

Nutzen Sie die oben genannten Filtermöglichkeiten im Massetab oder im Bereich „Erweitern“ (manuell), um nach Produkten zu filtern und die verknüpften Elemente einzeln zu prüfen. Weitere Filter wie ifc-Klassen können im „Erweitern“ (manuell) kombiniert werden. 

> Hinweis: Bei Modellen mit vielen Subelementen oder bei Präferenz für die Arbeit mit einer Bill of Quantities im Excelformat können Sie diese nach Klick auf die entsprechende Quelldatei über „Datei exportieren <iconify-icon inline icon='mdi-file-download-outline'/>“ generieren und die Spaltensortierung bzw. Spaltenfilter nutzen. 

## Analyse hinsichtlich Produkte mit den größten negativen Auswirkungen

Definieren Sie negative Auswirkungen entsprechend der Zielsetzung des Projekts.

### Umweltwirkfaktoren (wie CO₂-Einsparungen)

Im Umwelttab können sie die entsprechenden KPIs über die Dropdowns „Konformität (Umweltproduktdeklaration)“, folgend „Leistungsindikator (KPI) auswählen“ und schließlich die Auswahl der Lebenszyklusphasen suchen.

Wählen sie im letzten Dropdown unter den KPI Cards "Material/Produkt“ aus - die Materialien/Produkte werden nach Höhe ihrer Auswirkungen aufgelistet.

> Hinweis: Mit dem Feature „3D Insights“Material Impact Vizualizer können Sie diese Erkenntnisse ebenfalls über entsprechende Einfärbungen der Elemente im 3D-Modell nachverfolgen (Voraussetzung: ifc-Quelldatei).

### Zirkularität (wie Recyclingfähigkeit und Demontierbarkeit)

Im Zirkularitätstab können Sie unter den KPI Cards im Dropdown „Material/Produkt“ alle verlinkten Produkte anzeigen lassen. Das Sortierkriterium bestimmen Sie über den zweiten Dropdown. 

> Hinweis: Mit dem Feature „3D Insights Material Impact Vizualizer “ können Sie diese Erkenntnisse ebenfalls über entsprechende Einfärbungen der Elemente im 3D-Modell nachverfolgen (Voraussetzung: ifc-Quelldatei). 

Weitere Informationen zur Zirkularitätsberechnung erhalten Sie über den grünen Pfeil neben der KPI. Wurden den Elementen Informationen zur Demontierbarkeit hinzugefügt, können Sie auch per Klick auf den Pfeil neben dieser KPI näheres zur Kalkulation erfahren.

### Materialmassen

Im Massetab sehen Sie, wo und aufgrund welcher Produkte das Projekt am materialintensivsten ist. Sie können zwischen der Matrix basierend auf Gebäudeschichten und der Matrix basierend auf Klassifizierung wechseln. Für mehr Details klicken Sie auf die Kreisdiagramme der Matrix sowie ggf. auf die dargestellte Stückzahl <iconify-icon inline icon='mdi-eye-outline'/> (#[Stückzahl]). In der Buttonleiste steht Ihnen außerdem ein „Filter <iconify-icon inline icon='mdi-filter-outline'/>“ zur gezielten Produktsuche zur Verfügung.

Detailliertere Ausführungen zu Suffizienz und langlebigen Produkten folgen.