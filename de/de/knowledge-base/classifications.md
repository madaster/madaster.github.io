---
title: Klassifikationen
description: Zugrundeliegende Klassifizierungsmethoden der Plattform
ref: classifications
type: Wissensdatenbank
menubar: knowledge-base-nav
---

Zugrundeliegende Klassifizierungsmethoden der Plattform

## Gebäudeschichten (Shearing Layers)

Die Theorie der Shearing Layers (Gebäudeschichten) wurde von dem Architekten Frank Duffy eingeführt und von Steward Brand in seinem Buch "How Buildings Learn: What Happens After They're Built" weiterentwickelt. Der Kern dieser Idee ist, dass ein Gebäude in sechs Schichten unterteilt werden kann:

 1. **Umgebung** (ewig) - Die erste Schicht umfasst das geografische Umfeld, in dem das Gebäude errichtet wurde.
 2. **Baukonstruktion** (30-300 Jahre) - Die zweite Schicht umfasst das Fundament und die tragenden Elemente.
 3. **Gebäudehülle** (±20 Jahre) - Die dritte Schicht umfasst die Fassade, Fenster, Außentüren und das Dach.
 4. **Technische Anlagen** (> 7-15 Jahre) - Die vierte Schicht besteht aus der Haustechnik eines Gebäudes, dem so genannten Innenleben: Kommunikationsleitungen, elektrische Leitungen, Sanitäranlagen, Sprinkleranlagen, Heizungs-, Lüftungs- und Klimaanlagen sowie bewegliche Teile wie Aufzüge und Rolltreppen.
 5. **Innenausbau** (3-30 Jahre) - Die fünfte Schicht umfasst die nichttragenden Wände, Decke und Böden sowie deren Bekleidungen und Türen.
 6. **Mobiliar** - Die sechste Schicht besteht aus den "mobilen" Ausstattungen wie bspw. Stühle, Tische, Kunstgegenstände, aber auch Kücheneinbauten, Lampen etc.
 
Jeder Schicht ist eine bestimmte Lebensdauer zugeordnet. So werden z.B. die Elemente in der Schicht "Gebäudehülle" regelmäßiger ausgetauscht als die in der "Baukonstruktion", jedoch nicht so häufig wie die Elemente des "Mobiliars".

## Klassifizierung der Objektelemente

Klassifizierungen werden verwendet um einzelne Elemente von Objekten und die dafür verbauten Materialien/Produkte entsprechend der diversen Auswertungoptionen auflisten zu können (z.B. gemäß der Gebäudeschichten oder der deutschen Kostengruppen). Auf diese Weise können die Ergebnisse jeder Berechnung sowohl für eine individuelle als auch für eine umfassende, allgemeine Analyse strukturiert werden.

Die meisten Länder haben ihre eigenen Normen für die Klassifizierung der Elemente (siehe <a href="https://docs.madaster.com/nl/en/knowledge-base/madaster-glossary.html" target="_blank">Glossar - Industrienormen</a>). Welche Ihnen neben den nationalen Klassifizierung zur Verfügung stehen, finden Sie außerdem in der linken Navigationsleiste auf der Plattform unter "Informationen/Klassifizierungsmethoden". Nach entsprechender Auswahl liest die Madaster-Plattform diese bei Upload automatisch aus dem BIM-Modell bzw. der Quelldatei aus.

## Materialfamilien

Das Klassifizierungssystem der NL-SfB ("Nederlandse basisindeling voor de bouw", übersetzt: "Niederländische Basisklassifikation für das Bauwesen") ist ein in der niederländischen Bauindustrie verwendetes System, das baurelevante Informationen organisiert. Dies geschieht in verschiedenen Kategorien/Tabellen, von denen eine die Materialklassifikation ist (Tabelle 3). Die Madaster V2-Klassifikation ist eine Referenz zu den von der NL-SfB erstellten Materialklassifikationen.

Die vollständige NL-SfB-Klassifikation (V201912) steht als <a href="https://ketenstandaard.nl/app/uploads/2020/03/NL-SfB_Tabel_0-4_Update-V201912.xlsx" target="_blank">Excel-Datei</a> zum Download bereit.

## Nutzungsarten

Es gibt unterschiedliche Nutzungsarten von Gebäuden und Infrastrukturobjekten mit individuellen Lebensdauern. Dies wirkt sich auch auf die Lebensdauern der jeweiligen Gebäudeschichten aus.
Abhängig von den Nutzungsarten werden die Rückbaukosten als Wert €/m<sup>2</sup> der Bruttofläche geschätzt. Diese Schätzung kann individuell überschrieben werden, wenn detailliertere Informationen verfügbar sind.

Die Nutzungsarten, die Rückbaukosten sowie die Lebensdauer des Objektes sowie die Gebäudeschichten können im Tab "Allgemeines" definiert werden.

### Kategorien von Gebäuden

|Kategorie|Nutzungsart|
|-|-|
|Büro|Büro < 1000 m2|
| |Büro >= 1000 m2|
|Einfamilienhaus|Einfamilienhaus, freistehend|
| |Einfamilienhaus, angrenzend|
|Doppelhaushälfte| |
|Reihenhaus|Reihenhaus, Mittelhaus|
| |Reihenhaus, Endhaus|
|Mehrfamilienhaus|Mehrfamilienhaus, freistehend|
| |Mehrfamilienhaus, angrenzend|
|Wohngebäude| |
|Büro/Verwaltungsgebäude| |
|Bildungsbau| |
|Handelsbau| |
|Industriegebäude| |
|Versammlungsstätte| |
|Beherbungsbau| |		
|Sonstiges| |

### Infrastrukturkategorien

|Objekttyp|Kategorie|Nutzungsart|
|-|-|-|
|Bauwerk|Sonstiges Bauwerk|Becken, Absetzbecken, Transformatorenschutz, Unterstand, Lagertank, Überdachung, Scheune, Windkraftanlage, Sonstige bauliche Anlagen|
| |Begrenzung/Einfriedung|Spundwand, Schallschutzwand, Zaun, Kaimauer, Mauer, Uferschutz|
|Ingenieurbauwerk|Brücke|Brücke|
| |Tunnel|Tunnel|
| |Sonstige Ingenieurbauwerk|Pumpwerk, Wasserversorgungs-/entsorgungsanlagen, Freileitungsmast, Bahnsteig und Zugänge, Schleuse, Schiffsanleger ,Leitdamm, Wehr, Erdbauwerke, Stützbauwerke, Schutzbauten, Sonstige Unterbauanlagen|
|Gelände|Befestigte Flächen|Mischoberfläche, Geschlossener Belag, Verdichtet, Ungepflastert, Gepflastert, Sand|
| |Geländeflächen|Städtische Grünfläche|
|Transport|Streckenabschnitt|Start- und Landebahn für den Flugverkehr, Fahrradweg, Einfahrt, Fahrspur für öffentliche Verkehrsmittel, Kreuzung, Bahnübergang, Parkplatz, Fahrbahn einer Autobahn, Fahrbahn einer Autostraße, Fahrbahn einer Gemeindestraße, Fahrspur einer Landesstraße, Reitweg, Gleis, Bremsschwelle Gemeindestraße, Bremsschwelle Landesstraße, Fußgängerzone, Fußweg, Fußweg mit Treppe, Verkehrsberuhigter Bereich|
| |unterstützender Streckenabschnitt|Wegrand/Wegböschung/Straßenrand, Verkehrsinsel|
| |Gleisanlagen|Light Rail, Nahverkehrsgleis, Fernverkehrsgleis, sonstiger Unterbau (Gleisanlagen)|
|Bahnanlagen|Bahnstrohmanlagen|Fahrleitungsanlagen, Hochspannungskabelanlagen, Kabelschutzanlagen, Schaltposten, Unterwerk, Kraftwerk|
| |Niederspannungs - und Telecomanlagen|Niederspannungsverbraucher|
| |Sicherungsanlagen|Rangiertechnik|
|Leitungen|Kabel und Rohre|Elektrische Leitung, Telekommunikationskabel, Petrochemie-Pipeline, Abwasserleitung, Wasserleitung, Wärmerohrleitung, Sonstige Rohrleitungen|