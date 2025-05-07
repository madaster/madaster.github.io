---
title: Benutzer
description: Benutzer einladen und Berechtigungen festlegen sowie Verwendung der API
ref: users
type: Wissensdatenbank
menubar: knowledge-base-nav
---

Benutzer einladen und Berechtigungen festlegen sowie Verwendung der API

Auf der Plattform ist es möglich, Benutzer mit bestimmten Rechten auf Account-, Ordner- und Objektebene hinzuzufügen.
Benutzer können als *Zeichnungsberechtigt* zugewiesen werden, was bedeutet, dass sie die rechtliche Verantwortung haben, die Lizenzbedingungen von eingeschränkten Herstellerdatenbanken zu akzeptieren. Diese sind auf Accountebene hinter dem Symbol <iconify-icon inline icon='mdi-dots-vertical'/> im Menü und auf der Seite **Lizensierte Datenbanken** aufgeführt.
Weitere Informationen hierzu finden Sie auf der Seite <a href="/at/de/knowledge-base/databases" target="_blank">Datenbanken auf Madaster</a>.

**Aktive (gezählte) Nutzer gegenüber Lesern**

Je nach Abonnement verfügt jeder Account über eine bestimmte Anzahl aktiver Benutzer (Administrator, Manager & Mitarbeiter an der Datenbank, Manager). Um die Anzahl der verfügbaren aktiven Benutzer zu sehen, gehen Sie auf Accountebene <iconify-icon inline icon='mdi-briefcase-variant'/> auf den Tab **Abonnement** (nur für aktive Benutzer dieser Ebene sichtbar).

## Benutzer auf Accountebene hinzufügen

Benutzer, die auf **Accountebene** <iconify-icon inline icon='mdi-briefcase-variant'/> eingeladen werden, erhalten Zugang zu allen bestehenden und zukünftigen Ordnern, Projekten und Objekten innerhalb des Accounts. Benutzern auf Accountebene kann eine der folgenden Berechtigungen zugewiesen werden:

|Accountebene|Administrator|Manager & Mitarbeiter an der Datenbank|Manager|Leser|Kontakt Rechnungsstellung|
|-|-|-|-|-|-|
|Erstellen und Bearbeiten von Ordnertypen| Ja| Nein| Nein| Nein| Nein|
|Ordner erstellen| Ja| Nein| Nein| Nein| Nein|
|Datenbank erstellen| Ja| Nein| Nein| Nein| Nein|
|Mitarbeit an einer Account-Datenbank oder geteilten Account-Datenbank mit Beitragsrechten| Ja| Ja| Nein| Nein| Nein|
|Abbonement einsehen| Ja| Nein| Nein| Nein| Nein|
|Benutzer einsehen| Ja| Nein| Nein| Nein| Nein|

## Benutzer auf Ordnerebene hinzufügen

Benutzer, die auf **Ordnerebene** <iconify-icon inline icon='mdi-folder-account'/> eingeladen werden, erhalten Zugriff auf alle Unterordner und Projekte innerhalb des ausgewählten Ordners. Benutzern auf Ordnerebene kann eine der folgenden Berechtigungen zugewiesen werden:

|Ordnerebene|Administrator|Manager & Mitarbeiter an der Datenbank|Manager|Leser|Kontakt Rechnungsstellung|
|-|-|-|-|-|-|
|Ordner und Unterordner erstellen|Ja| Nein| Nein| Nein| Nein|
|Ordner und Unterorder/Objekte einsehen| Ja| Ja| Ja| Ja| Ja|
|Ordner und Unterorder/Objekte bearbeiten| Ja| Ja| Ja| Nein| Nein|
|Ordner und Unterorder/Objekte löschen| Ja| Nein| Nein| Nein| Nein|
|Objekt einem Ordner hinzufügen (solange der Ordnertyp Objekte erlaubt)| Ja| Ja| Ja| Nein| Nein|
|Benutzer hinzufügen/entfernen| Ja| Nein| Nein| Nein| Nein |
|Datenbank hinzufügen| Ja| Nein| Nein| Nein| Nein|
|Mitarbeit an Datenbank| Ja| Ja| Nein| Nein| Nein|
|Materialpass exportieren| Ja| Ja| Ja| Nein| Nein|
|Materialpass herunterladen| Ja| Ja| Ja| Nein| Nein|

## Benutzer auf Objektebene hinzufügen

Benutzer, die auf **Objektebene** <iconify-icon inline icon='mdi-office-building'/> eingeladen werden, erhalten nur Zugriff auf das ausgewählte Objekt. Benutzern auf Objektebene kann eine der folgenden Berechtigungen zugewiesen werden:

|Objektebene|Administrator|Manager & Mitarbeiter an der Datenbank|Manager|Leser|Kontakt Rechnungsstellung|
|-|-|-|-|-|-|
|Objekt einsehen| Ja| Ja| Ja| Ja| Ja|
|Objekt bearbeiten| Ja| Ja| Ja| Nein| Nein|
|Objekt löschen| Ja| Nein| Nein| Nein| Nein|
|Benutzer hinzufügen/entfernen| Ja| Nein| Nein| Nein| Nein|
|Datenbank hinzufügen| Ja| Nein| Nein| Nein| Nein|
|Mitarbeit an einer Objekt-Datenbank oder geteilten Objekt-Datenbank mit Beitragsrechten| Ja| Ja| Nein| Nein| Nein|
|Materialpass exportieren| Ja| Ja| Ja| Nein| Nein|
|Materialpass herunterladen| Ja| Ja| Ja| Ja| Ja|

## API token hinzufügen

Mehr Informationen zur API finden Sie <a href="/at/de/api/" target="_blank">hier</a>.
