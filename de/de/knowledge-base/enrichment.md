---
title: Erweitern
description: Tipps für den Erweiterungsprozess
ref: enrichment
type: Knowledge Base
menubar: knowledge-base-nav
---

Tipps für den Erweiterungsprozess.

Um eine umfassende Bewertung eines Objekts auf Madaster zu gewährleisten, sollte jedes Element mindestens über eine Klassifizierung und ausreichende geometrische Informationen verfügen sowie mit einem Produktdatensatz verknüpft sein. Weitere Informationen dazu finden Sie auch unter <a href="../knowledge-base/quality-check.html#grundlegende-betrachtung" target="_blank">Qualitätskontrolle und Qualitätsmanagement</a>.

Um die Ergebnisse der automatischen Zuordnungsprozesses während des Hochladens einer Quelldatei im Detail zu überprüfen, wechseln Sie auf Objektebene zum Tab **Dateien** und klicken Sie

1. entweder auf die Quelldatei und anschließend auf die Schaltfläche  **Erweitern <iconify-icon inline icon='mdi-link-variant-plus'/> (Manuell)**

    ODER

2. direkt auf das Symbol für Erweitern <iconify-icon inline icon='mdi-link-variant-plus'/> rechts neben der Quelldatei.

## Verknüpfen von Elementen

Elemente können durch automatische oder manuelle Zuordnung verknüpft werden.

### 1. Automatische Zuordnung

Bei der automatischen Zuordnung durchsucht die Plattform jedes Element nach bestimmten Informationen, die als Verknüpfungsgrundlage dienen können. Dies sind im Wesentlichen:

1. **Madaster-ID** – Ist für ein Element explizit eine Madaster-ID eines Produkts hinterlegt, wird diese Information beim Zuordnungsprozess bevorzugt berücksichtigt.
2. **Externe Datenbank-ID** – Ist ähnlich einer Madaster-ID eine Externe Datenbank-ID eines Produkts hinterlegt, wird diese verwendet. Sind jedoch beide Angaben vorhanden, hat die Madaster-ID Vorrang.
3. **Material-/Produkt** – Die Bezeichnung des Materials kann zugeordnet werden, wenn das Produkt in der Datenbank entweder exakt denselben Namen trägt oder ähnliche Begriffe als **Suchkriterien** hinterlegt wurden.

Das automatische Verknüpfen erfolgt beim Hochladen einer Quelldatei <u>ODER</u> durch manuellen Anstoß des Prozesses, in dem Sie auf die Quelldatei und anschließend auf **Erweitern <iconify-icon inline icon='mdi-link-variant-plus'/> (Automatisch)** klicken.

### 2. Manuelles Verknüpfen

Alternativ ermöglicht das manuelle Erweitern die Verknüpfung einzelner Elemente oder mehrerer Elemente gleichzeitig. Aktivieren Sie das Kontrollkästchen neben dem bzw. den Elementen und klicken Sie auf das Symbol <iconify-icon inline icon='mdi-link-variant'/>, welches am Ende der Seite erscheint. Es öffnet sich ein Fenster, das alle verfügbaren Datenbanken einschließlich der darin enthaltenen Produkte anzeigt. Wählen Sie den gewünschten Produktdatensatz aus und klicken Sie auf **Verknüpfen <iconify-icon inline icon='mdi-link-variant'/>**.

Daraufhin öffnet sich ein weiteres Fenster mit den folgenden Optionen, die Sie durch Aktivieren des entsprechenden Kontrollkästchens auswählen können.

1. Verknüpfen Sie einfach die **Ausgewählte(n) Elemente** – unabhängig davon, ob sie bereits verknüpft sind oder nicht. 

2. Verknüpfen Sie Elemente anhand Ihrer eigenen **Verknüpfungsregeln** und speichern Sie diese für zukünftige automatisierte Zuordnungen.
Sie entscheiden, ob die Verknüpfung auf Basis des Materialnamens <u>ODER<u> des IFC-Typens <u>ODER<u> der IFC-Klasse <u>ODER SOGAR</u> einer Kombination mehrerer Kriterien erfolgen soll. 

    > Hinweis: Über das Dropdown-Menü auf der rechten Seite können Sie festlegen, ob die Regel für die zukünftige Verwendung gespeichert werden soll – entweder nur für das aktuelle Objekt, für einen  bestimmten Ordner oder für das gesamte Konto. Letztere sind sinnvoll, wenn Ihre Projekte häufig auf die gleiche Weise modelliert werden.

    > Hinweis: Durch Aktivieren des letzten Kontrollkästchens können Sie auch Elemente einbeziehen, die bereits verknüpft sind.

3. Verknüpfen Sie alle Elemente, die bereits **einem bestimmten Produkt zugeordnet** sind. 

    > Hinweis: Wählen Sie diese Option, wenn Sie beispielsweise während der Planung ein Produkt durch eine umweltfreundlichere oder kreislauffähige Alternative ersetzen möchten oder wenn ein ursprünglich geplantes Produkt während der Bauphase durch ein anderes ersetzt wird.

<figure><img src="/assets/images_GER/Suchkriterien.png" alt="Optionen im manuellen Zuordnungsprozess inklusive Verknüpfungsregeln."><figcaption>Optionen im manuellen Zuordnungsprozess inklusive Verknüpfungsregeln.</figcaption></figure>

## Suche innerhalb des Erweiterns

Wenn Sie nach bestimmten Elementen suchen, finden Sie in der Navigationsliste auf der linken Seite **verschiedene Filter** sowie ein Suchfeld.

Im **Suchfeld** oben links können Sie suchen nach:
* Elementnamen,
* Typnamen,
* Element-IDs,
* Materialnamen oder
* Inhalten innerhalb der Kommentare zu den Elementen.

> Hinweis: Wenn Sie in Ihrer IFC-Quelldatei noch keinen Kommentar verwendet haben, können Sie über die <a href="../knowledge-base/stay-organized.html#organisieren-der-quelldateien" target="_blank">Voreinstellungen für den (Quelldatei)Upload</a> eine beliebige Eigenschaft der Elemente als Kommentar definieren. Auf diese Weise können Sie weitere Informationen durchsuchbar machen.

## Speichern Sie Ihren Fortschritt

Insbesondere bei der Arbeit an langfristigen Projekten oder im Team kann es sinnvoll sein, eine separate Sicherungskopie der aktuellen und der endgültigen Projektversion zu speichern.

Selbstverständlich existiert ein Backup der gesamten Plattform, um diese vor einem vollständigen Datenverlust durch technische Fehler zu schützen. Zudem können versehentlich gelöschte Inhalte innerhalb von 30 Tagen von unserem Support-Team wiederhergestellt werden, bevor sie endgültig gelöscht werden. <b><i><u>Wenn jedoch Daten innerhalb eines Projekts überschrieben werden (z. B. durch erneute autmatische Verknüpfung), ist eine Wiederherstellung des vorherigen Zustands nicht möglich!</u></i></b>

**Empfehlungen zur Datensicherung**

1. Nutzen Sie die **Archivfunktion**, um Zwischenstände laufender Projekte und/oder den Endzustand zu sichern. Unser Support-Team kann anhand eines Archivs zumindest diese Version als aktives Objekt wiederherstellen. <br>
Informationen zum Erstellen eines Archivs finden Sie unter <a href="../knowledge-base/stay-organized#verwalten-von-objekten" target="_blank">Verwalten von Objekten</a>.

2. Alternativ können Sie eine **Variante** als Zwischenstand anlegen oder um die Auswirkungen der Zuordnung anderer Produkte zu testen. <br>
Informationen zum Erstellen einer Variante finden Sie unter <a href="../knowledge-base/stay-organized#verwalten-von-objekten" target="_blank">Verwalten von Objekten</a>.

3. Eine weitere Möglichkeit besteht darin, die Quelldatei als **neue Version** hochzuladen und die „ältere“ Version im Dateibaum im Tab **Dateien** zu belassen. Die Elemente der jeweiligen Datei können unterschiedlich zugeordnet werden.