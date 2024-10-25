---
title: Objekt einrichten
description: Neue Objekte anlegen, Quelldateien vorbereiten und hochladen
ref: set-up-objects
type: Erste Schritte
menubar: get-started-nav
---

Neue Objekte anlegen, Quelldateien vorbereiten und hochladen

## Objekt erstellen

1. Klicken Sie auf der Ordnerebene im Tab **Allgemeines** auf **Neues Objekt** <iconify-icon inline icon='mdi-plus-circle-outline'/> und wählen Sie eine der Optionen (z.B. Gebäude) im Dropdown-Menü aus.

   > Hinweis: Wenn diese Schaltfläche nicht sichtbar ist, muss zunächst ein Ordner des richtigen Typs erstellt oder die Ordnereinstellungen angepasst werden. Die Standardeinstellungen für einzelne Ordnertypen lassen das direkte Hinzufügen von Objekten nicht zu. Überprüfen und bearbeiten Sie bei Bedarf die <a href="../knowledge-base/folder-types-and-folder-structure" target="_blank">Ordnertypen</a>.

2. Geben Sie in der sich öffnenden Maske mindestens die **erforderlichen Informationen** an, welche unter Allgemeines mit einem roten Stern markiert sind.
3. In den zusätzlichen Tabs können Sie weitere nützliche Informationen wie Labels, Energie, Bilder des Objekts und Lebensdauer ergänzen.
4. Klicken Sie auf **Speichern**.

> Hinweis: Sie können alle Angaben zu Objekten, auch die erforderlichen, jederzeit über die Schaltfläche **Objekt bearbeiten** anpassen.


## Quelldatei vorbereiten

Um ein Objekt auswerten zu können, muss zunächst eine Quelldatei hochgeladen werden. Die Vollständigkeit und Genauigkeit der Auswertung mit Madaster wird durch die Verfügbarkeit und Qualität der Informationen in der Quelldatei bestimmt.

Madaster verarbeitet <a href="../knowledge-base/preparing-bim-ifc-source-files" target="_blank">IFC-Dateien</a> oder das <a href="../knowledge-base/preparing-excel-source-files" target="_blank">Madaster-Excel-Template</a>.

   * Bei Neubau- und Sanierungsobjekten werden immer mehr Informationen in **BIM-Modellen** erfasst. Diese Form der Erfassung bietet die meisten Vorteile hinsichtlich der Auswertung von Materialien und Massen und somit der erfolgreichen und genauen Erstellung eines Materialpasses auf der Madaster-Plattform. Für die Auswertung und Verarbeitung von BIM-Modellen sind IFC-Exporte notwendig.
   * Für bestehende Objekte sind in der Regel Zeichnungen und andere Spezifikationen verfügbar. Diese können (bei Bedarf von Baufachleuten) in BIM-Modelle übersetzt oder alternativ im Madaster-Excel-Template verarbeitet werden.

Für beide Arten von Quelldateien sollten je Element folgende Angaben enthalten sein:
   * eine **Materialbeschreibung**
   * **geometrische Eigenschaften**
   * sowie eine <a href="../knowledge-base/classifications#klassifizierung-der-objektelemente" target="_blank">Klassifizierung</a>

## Quelldatei hochladen

Klicken Sie auf Objektebene im Tab **Dossier** die Schaltfläche **Hochladen** <iconify-icon inline icon='mdi-upload'/>.

  1. Wählen Sie den **Dateityp** Quelldatei (BIM oder Excel) und klicken Sie auf **Datei(en) auswählen**.
  2. Wählen Sie die **Klassifizierungsmethode** oder sofern bereits angelegt die gewünschten <a href="../knowledge-base/stay-organized#organisieren-der-quelldateien" target="_blank">Upload-Voreinstellungen</a>.
  3. "Nur Produkte mit Umweltdaten gemäß ausgewählten Konformitäten abgleichen" ermöglicht Ihnen <u>bei Bedarf</u> den automatischen Zuordnungsprozess von Produktdatensätzen auf eine **Konformität** (EN 15804 oder EN 15804+A2) gezielt zu beschränken.
  4. Wählen Sie die **Sprachen für den Abgleich** aus.
  5. Wählen Sie mittels des <iconify-icon inline icon='mdi-plus-thick'/> **Datenbank(en)** aus oder mittels des <iconify-icon inline icon='mdi-minus-thick'/> ab, um diese unter **Ausgewählte Datenbanken und Priorisierung** für die automatische Zuordnung von Produktdaten hinzuzufügen.

     > Hinweis: Die Reihenfolge der ausgewählten Datenquellen bestimmt die Priorisierung dieser im Zuordnungsprozess. Diese kann per Drag and Drop verändert werden.

  5. Klicken Sie auf **Speichern**.
  
## Quelldateien verwalten

Pro Objekt können auch **mehrere Quelldateien** bei Madaster hochgeladen und gleichzeitig ausgewertet werden. Beispielsweise je eine QUelldatei zum Architektur-, TGA- und Einrichtungmodell oder verschiedene Versionen dieser Modelle. IFC- und Excel-Dateien können dazu auch kombiniert werden.

Schalten Sie auf Objektebene im Tab Dossier die hochgeladene Quelldatei **Aktiv** <iconify-icon inline icon='mdi-toggle-switch'/>. Nur aktivierte Quelldateien werden bei der Auswertung berücksichtigt.

Wurde ein BIM-Modell überarbeitet und ist eine hochgeladene Quelldatei veraltet, kann eine **neue Version** hinzugefügt werden, ohne dass die bisherigen Produktverknüpfungen verloren gehen. Klicken Sie dazu neben der betreffenden Quelldatei auf das Symbol <iconify-icon inline icon='mdi-upload-lock'/> auf der rechten Seite.

## Objekt verwalten

Es gibt viele integrierte Funktionen zum Erstellen von Voreinstellungen für den Upload, Organisieren und Teilen Ihrer Dateien, Archivieren oder Übertragen Ihrer Objekte sowie zum Erstellen von Designvarianten. Klicken Sie <a href="../knowledge-base/stay-organized" target="_blank">hier</a>, um mehr darüber zu erfahren, wie Sie Ihre Objekte organisieren können.

<a class="next-button" href="../get-started/enrich-objects-with-material-and-product-databases">Nächster Schritt: Objekt anreichern</a>