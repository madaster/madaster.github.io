---
title: Datenbanken
description: Datenbankkonfiguration, Anlegen von Produkten und Datenpflege
ref: databases
type: Wissensdatenbank
menubar: knowledge-base-nav
---

Datenbankkonfiguration, Anlegen von Produkten und Datenpflege

## Verfügbare Datenbanken

Madaster unterscheidet zwischen drei Arten von Datenbanken.

* **System- oder geprüfte Datenbanken**: z.B.  <a href= '/files/at/Epea_Generic.xlsx' target='_blank'>EPEA </a>, <a href= 'https://www.oekobaudat.de/' target='_blank'>ÖKOBAUDAT</a> <iconify-icon inline icon='mdi-database-check-outline'/>
* **Produzentendatenbanken** <iconify-icon inline icon='mdi-database' />
  > Diese Datenbanken finden Sie in der linken Navigation <iconify-icon inline icon='mdi-menu' /> unten, hinter dem aufklappbaren Feld <iconify-icon inline icon='mdi-chevron-down' />  **Systemdatenbanken & Produzenten** <iconify-icon inline icon='mdi-database-cog-outline' />.

* **Individuelle Benutzerdatenbanken** <iconify-icon inline icon='mdi-database' />
  > Diese finden Sie in der linken Navigation <iconify-icon inline icon='mdi-menu' /> in ihrem Account.

> **Hinweis: BITTE BEACHTEN SIE, DASS DIE DATENBANKEN *Madaster* UND *Madaster C2C* NICHT ZUR VERWENDUNG EMPFOHLEN SIND.**

## Benutzerberechtigung

Die Berechtigung des Benutzers hängt von zwei Parametern ab:
1. Art des Benutzers
2. Ebene, auf der der Benutzer eingeladen wurde (Account-/Ordner-/Objektebene)
3. Datenbankeigenschaften
* Die eingestellten Datenbankeigenschaften können in der Registerkarte **Datenbank** unter dem Feld **Datenbankeigenschaften bearbeiten** <iconify-icon inline icon='mdi-pencil-outline'/> eingestellt werden.

Nähere Informationen über die Berechtigungen und Hierarchiebenen für Benutzer finden sie
<a href='/at/de/knowledge-base/users.html' target='_blank'>hier</a>.

## Datenbank erstellen

### Account- / Ordner- / Objektebene
Die Account- und Ordnerstruktur in Madaster ist flexibel und kann nach eigenen Präferenzen eingerichtet werden. Die Plattform erlaubt mehrere Ordner pro Account, die Unterordner oder Objekte enthalten können. Um diese Struktur in Bezug auf Materialien und Produkte zu unterstützen, ist es möglich, eine oder mehrere Datenbanken auf unterschiedlichen Ebenen innerhalb des eigenen Accounts zu erstellen und zu verwenden.

1. Datenbank auf **Accountebene** <iconify-icon inline icon='mdi-briefcase-variant'/>
  * Eine Datenbank auf dieser Ebene kann von allen darunter liegenden Ordnerebenen und Objekten innerhalb des Accounts genutzt werden. Die Datenbank kann auch mit anderen Accountsn geteilt werden.
2. Datenbank auf **Ordnerebene** <iconify-icon inline icon='mdi-folder-outline'/>
  * Eine Datenbank auf dieser Ebene kann nur von Objekten in dem ausgewählten Ordner und den darunter liegenden Ebenen verwendet werden. Die Datenbank kann auch mit anderen Accounts geteilt werden.
3. Datenbank auf **Objektebene** <iconify-icon inline icon='mdi-office-building'/> 
  * Eine Datenbank auf dieser Ebene kann nur von dem ausgewählten Objekt verwendet werden. Die Datenbank kann nicht mit anderen Accounts geteilt werden.

### Neue Datenbank erstellen
1. Um eine neue Datenbank zu erstellen, gehen sie auf Account-/Ordner-/Objektebene in der Registerkarte **Allgemeines** in der Symbolleiste auf **Neue Datenbank** <iconify-icon inline icon='mdi-database-plus-outline'/>.
2. Klicken Sie nach der Eingabe der erforderlichen Informationen auf **Speichern**.


## Datenbank importieren/exportieren
Es besteht die Möglichkeit, die Produkte und Materialien einer Datenbank über eine Excel-Vorlage zu importieren/exportieren.
1. Klicken Sie in der Datenbank auf die Registerkarte **Dossier** und anschließend in der Symbolleiste auf **Import/Export** <iconify-icon inline icon='mdi-swap-vertical'/>.
1. Um die **Excel-Vorlage** herunterzuladen wählen Sie **Exportieren**, wählen Sie das Kästchen **Leere Vorlage generieren** <iconify-icon inline icon='mdi-checkbox-marked'/> und bestätigen Sie mit **OK**.
1. Für den **Export** einer vorhandenen Datenbank klicken Sie auf **Exportieren** und nach Auswahl der Exportinformationen <iconify-icon inline icon='mdi-checkbox-marked'/> auf **OK**. 
1. Für den **Import** klicken Sie **Importieren** und nach Auswahl der Importinformationen <iconify-icon inline icon='mdi-checkbox-marked'/> auf **OK**.
> **Hinweis:** Wenn Sie zum ersten Mal Informationen über die Datenbank importieren/exportieren, empfiehlt es sich, zumindest ein Probe-Produkt in den Export einzubeziehen. So können Sie prüfen, welche Informationen wo enthalten sind und wie sie strukturiert werden. Beachten Sie, dass die Auswahl **Leere Vorlage generieren** kein Produkt aus der Datenbank enthält.

## Datenbank teilen
 Wenn Sie die notwendige <a href='/at/de/knowledge-base/users.html' target='_blank'>Berechtigung</a> besitzen, können Sie Datenbanken teilen. Gehen Sie dafür auf die jeweilige Datenbank <iconify-icon inline icon='mdi-database' /> und anschließend auf die Registerkarte **Geteilt mit**.
 1. Klicken Sie auf **Freigeben** <iconify-icon inline icon='mdi-plus-circle-outline'/>, um die Datenbank mit einstellbaren Freigaberechten zu teilen.
 1. Klicken Sie auf **Freigabe bearbeiten** <iconify-icon inline icon='mdi-pencil-outline'/>, um die eingestellten Freigaberechte anzupassen. 
 
## Datenbank bearbeiten
In jeder Datenbank können Produkte oder Materialien hinzugefügt werden, die für die auf der Plattform registrierten Objekte verwendet werden können. Auf der Hauptübersichtsseite der Datenbank sehen Sie in der Registerkarte **Datenbank** eine Liste aller Produkte, die in der Datenbank enthalten sind.

### Produkt hinzufügen
In der oberen Symbolleiste können Sie ein neues Produkt zur Datenbank hinzufügen, indem Sie auf die Schaltfläche **Produkt hinzufügen** <iconify-icon inline icon='mdi-plus-circle-outline'/> klicken. Um ein Produkt zu erstellen, sollten folgende Informationen hinterlegt werden:
1. Produktinformationen (Name, Typ, Lebensdauer, Dichte, Funktionelle Einheit, Zusammensetzung)
1. Zirkulariät (Materialherkunft, Demontierbarkeit, Materialverwertung)
1. Umwelt (Umweltinformationen gemäß EPD)
1. Suchkriterium (zum automatischen Abgleich bei spezifischen Material-/Produktbeschreibungen)
1. Finanziell (Preissätze zu Transport- und Aufarbeitungskosten)

Durch diese Konfiguration können Sie sowohl monolithische als auch mehrschichtige Produkte anlegen.

### Produkt einsehen, bearbeiten und löschen
Für vorhandene Produkte sind verschienene Anpassungsmöglichkeiten verfügbar:
1. Produkt bearbeiten <iconify-icon inline icon='mdi-pencil-outline'/>
1. Produkt löschen <iconify-icon inline icon='mdi-delete-outline'/>
1. Neue Version des Produkts erstellen <iconify-icon inline icon='mdi-content-duplicate'/>
1. Produkt ansehen <iconify-icon inline icon='mdi-arrow-right-circle-outline'/>
1. reduzierte Produktinformationen ausklappen <iconify-icon inline icon='mdi-chevron-down'/>

Nähere Informationen zu den Produktinformationen und Einstellungsmöglichkeiten finden Sie im Abschnitt **Produkt hinzufügen**.

## API Token hinzufügen

Nähere Informationen zur Nutzung der Madaster API finden Sie <a href="/at/de/api/" target="_blank">hier</a>.