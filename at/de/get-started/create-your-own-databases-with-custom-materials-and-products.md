---
title: Individuelle Datenbank einrichten
description: Eigene Datenbank einrichten, Materialien und Produkte erstellen
ref: create-your-own-databases-with-custom-materials-and-products
type: Erste Schritte
menubar: get-started-nav
---

Eigene Datenbank einrichten, Materialien und Produkte erstellen

## Datenbanken einrichten

Datenbanken können auf <a href="/at/de/knowledge-base/databases#datenbank-erstellen" target="_blank">Account-, Ordner- oder Objekt-Ebene</a> erstellt werden. Zu jedem Account erstellt die Plattform automatisch eine Datenbank auf Accountebene.

1. Gehen Sie auf der gewünschten Ebene in dem Tab **Allgemeines** und klicken Sie auf die Schaltfläche **Neue Datenbank** <iconify-icon inline icon='mdi-database-plus-outline'/>.
2. Geben Sie einen **Namen** für die Datenbank an, fügen Sie optional eine **Beschreibung** hinzu und entscheiden Sie durch Setzen eines Hakens, ob die Datenbank beim Hochladen als **standardmäßig ausgewählte Datenbank** festgelegt werden soll.
3. Klicken Sie auf **Speichern**.
4. Wenn Sie sich in der Datenbank befinden können Informationen durch Klicken auf **Datenbankeigenschaften bearbeiten** <iconify-icon inline icon='mdi-pencil-outline'/> geändert oder durch Klicken auf **Datenbank löschen** <iconify-icon inline icon='mdi-delete-outline'/> gelöscht werden.

## Datenbank bearbeiten

Benutzer können per E-Mail eingeladen und Systeme per API-Token angebundene werden.

### Benutzer hinzufügen

1. Gehen Sie in der Datenbank zum Tab **Benutzer** und klicken Sie auf **Benutzer hinzufügen** <iconify-icon inline icon='mdi-account-plus-outline'/>.
2. Fügen Sie eine **E-Mail-Adresse** hinzu und wählen Sie die entsprechende <a href="/at/de/knowledge-base/users" target="_blank">Berechtigung</a> für den Benutzer.
3. Klicken Sie auf **Speichern**.
4. Benutzer können von einer Datenbank entfernt <iconify-icon inline icon='mdi-delete-outline'/> oder Ihre Berechtigungen angepasst <iconify-icon inline icon='mdi-pencil-outline'/> werden, indem Sie auf die Symbole rechts neben dem entsprechenden Namen klicken.

### API-Token hinzufügen

1. Gehen Sie in der Datenbank zum Tab **Benutzer** und klicken Sie auf **API-Token hinzufügen** <iconify-icon inline icon='mdi-account-plus-outline'/>.
2. Bestimmen Sie <a href="/at/de/api/#autorisierung" target="_blank">den Namen, die Berechtigungsstufe sowie die Ablaufzeit</a> an.
3. Klicken Sie auf **Speichern**.
4. Token können von einer Datenbank entfernt <iconify-icon inline icon='mdi-delete-outline'/> oder Ihre Berechtigungen angepasst <iconify-icon inline icon='mdi-pencil-outline'/> werden, indem Sie auf die Symbole rechts neben dem entsprechenden Namen klicken.

## Datenbanken teilen

Eine Datenbank kann mit mehreren Accounts, Ordnern oder Gebäuden geteilt werden. Dies ermöglicht es beispielsweise einem Unternehmen, eine Datenbank einzurichten und die Produkte den Benutzern eines anderen Accounts/Ordners/Objekts zur Verfügung zu stellen. Änderungen und Ergänzungen in dieser Datenbank sind dann direkt für alle anderen Benutzer mit Freigabe zur Datenbank sichtbar.

Daher ist es beim Teilen einer Datenbank notwendig, die Rechte festzulegen, mit denen die Benutzer des anderen Accounts/Ordners/Objekts, die Produkte verwenden können:
  * **Zuordnen** – Benutzer mit Freigabe können Elemente mit Produkten aus der Datenbank verknüpfen.
  * **Kopieren** – Zusätzlich zum Zuordnen können Benutzer mit Freigabe Produktdatensätze aus dieser in eine andere Datenbank kopieren.
  * **Beitragen** – Zusätzlich zum Zuordnen und Kopieren können Benutzer mit Freigabe neue Materialien und Produkte zur Datenbank hinzufügen.
  * **Verwalten** – Zusätzlich zum Zuordnen, Kopieren und Beitragen können Benutzer mit Freigabe die Rechte für das Account/den Ordner/das Objekt verwalten, mit dem diese Datenbank geteilt wird.

1. Um eine Datenbank zu teilen, müssen Sie sowohl auf die Datenbank als auch das Zielobjekt **aktive Zugriffsrechte** haben.
2. Gehen Sie in der Datenbank auf den Tab **Geteilt mit** und klicken Sie dort auf die Schaltfläche **Freigeben** <iconify-icon inline icon='mdi-plus-circle-outline'/>.
3. Wählen Sie die gewünschten **Rechte** für das Teilen sowie den Account, Ordner oder das Objekt.
4. Klicken Sie auf **Speichern**.

## Produkte erstellen und bearbeiten

Madaster unterscheidet zwischen verschiedenen Produkttypen. Die Wahl des Produkttypen hängt in erster Linie von den verfügbaren geometrischen Daten des betreffenden Objektelements in der Quelldatei ab.

1. Klicken Sie in der Datenbank auf **Produkt hinzufügen** <iconify-icon inline icon='mdi-plus-circle-outline'/>.
2. Fügen Sie einen **Produktnamen** hinzu und wählen Sie den **Typ**.
   * Volumen (z.B. für Beton)
   * Fläche (z.B. für Bodenbeläge)
   * Länge (z.B. für Rohre)
   * Anzahl (z.B. für Waschbecken)
   * Energie (z.B. für Stromnutzung)
   * Gewicht
3. Füllen Sie die mit einem roten Stern **gekennzeichneten Pflichtfelder** im Tab <a href="/at/de/knowledge-base/databases-products#produktinformation---allgemein" target="_blank">Produktinformationen</a> sowie die **Zusammensetzung** aus.
4. Legen Sie außerdem fest, ob die Zirkularitäts- und Umweltinformationen auf Grundlage der Materialliste berechnet werden sollen oder nicht. Dies ist abhängig davon, ob Sie diese Informationen zu dem Produkt vorliegen haben oder einen generischen Produktdatensatz zugrunde legen wollen. Gegebenenfalls geben Sie die Informationen in den Tabs **Zirkularität** und **Umwelt** ein.
5. Geben Sie Suchkriterien für die automatische Zuordnung ein.
   * Klicken Sie auf **Kriterium hinzufügen** <iconify-icon inline icon='mdi-plus-circle-outline'/>.
   * Geben Sie ein **Kriterium** ein (z.B. Materialname oder typeName im BIM-Modell).
   * Legen Sie den **Zuordnungstyp** und die **Sprache** fest sowie die **Gültigkeit** für das ifcmaterial oder den typename.
   * Klicken Sie auf **Speichern**.
6. Gegebenenfalls geben Sie Informationen im Tab **Finanziell** ein.
7. Klicken Sie  auf **Speichern** <iconify-icon inline icon='mdi-content-save-outline'/>.
8. Produkte können in der Datenbank angezeigt, bearbeitet, gelöscht oder kopiert werden.

> Hinweis: Weiterführende Informationen zu den Produktanlagen und -angaben finden Sie <a href="/at/de/knowledge-base/databases#product-information" target="_blank">hier</a>.

## Produkte duplizieren und bearbeiten

1. Wählen Sie ein Produkt in der Datenbank aus, indem Sie die **Checkbox** <iconify-icon inline icon='mdi-checkbox-marked'/> anhaken.
2. Klicken Sie auf **Element duplizieren** <iconify-icon inline icon='mdi-content-copy'/>.
3. Bearbeiten Sie das Produkt wunschgemäß und klicken Sie auf **Speichern** <iconify-icon inline icon='mdi-content-save-outline'/>.

## Datenbank organisieren

Im Tab **Datenbank** können Sie die Tabelle aller Produkte in der Datenbank einsehen. Durch Klicken des Symbols <iconify-icon inline icon='mdi-chevron-down'/> am Ende der Produktzeile, können Sie weitere Produktinformationen einsehen.

Am Ende der Produktzeile befinden sich außerdem Symbole zum **Bearbeiten** <iconify-icon inline icon='mdi-pencil-outline'/>, **Löschen** <iconify-icon inline icon='mdi-delete-outline'/>, Hinzufügen einer neuen **Version** <iconify-icon inline icon='mdi-content-duplicate'/> und **Anzeigen** <iconify-icon inline icon='mdi-arrow-right-circle-outline'/> des Produkts.

## Datenbank löschen

Eine Datenbank kann nur gelöscht werden, wenn keine Produkte mehr darin enthalten sind. Sobald alle Produkte aus einer Datenbank gelöscht sind, können Sie in der oberen Symbolleiste auf **Datenbank löschen** <iconify-icon inline icon='mdi-delete-outline'/> klicken. Wenn Sie sicher sind, klicken Sie im Bestätigungs-Popup auf **Ja** und die Datenbank wird gelöscht.

<a class="next-button" href="/at/de/get-started/object-insights-and-performance">Nächster Schritt: Objekt - Einblicke und Performance</a>