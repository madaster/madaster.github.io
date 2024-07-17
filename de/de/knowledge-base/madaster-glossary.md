---
title: Madaster Glossar
description: Definitionen in der Plattform verwendeter Begriffe
ref: madaster-glossary
type: Wissensdatenbank
menubar: knowledge-base-nav
---

Definitionen in der Plattform verwendeter Begriffe

## Application Programming Interface (API)

Eine (Programmier-)**Schnittstelle** ermöglicht die Interaktion zwischen Softwaresystemen bzw. mit anderen Programmen.

Näheres zu der Madaster-API finden Sie <a href="../api" target="_blank">hier</a>.

## Building Information Modeling (BIM)

### Computer Aided Design (CAD)

**ArchiCAD** ist eine architektonische BIM-CAD-Software, die von der Firma Graphisoft entwickelt wurde. ArchiCAD bietet computergestützte Lösungen für den Umgang mit allen gängigen Aspekten der Ästhetik und Technik während des gesamten Entwurfsprozesses der gebauten Umwelt. Für weitere Informationen besuchen Sie <a href="https://graphisoft.com/solutions/archicad" target="_blank">Graphisoft</a>.

**Autodesk Revit** unterstützt Building Information Modeling (BIM) und bietet Werkzeuge für Architektur, Gebäudetechnik, Hochbau und Konstruktion. Die einzelnen Disziplinen können für eine schnelle und sichere Konstruktion koordiniert werden. Weitere Informationen finden Sie bei <a href="https://www.autodesk.eu/products/revit/overview" target="_blank">Autodesk</a>.

### Industry Foundation Classes (IFC)

IFC ist ein offenes **Standardformat** im Bauwesen zur digitalen Beschreibung von Gebäudemodellen und Infrastrukturprojekten, das offen und herstellerneutral verwendet werden kann. IFC-Dateien enthalten umfassende Informationen wie geometrische Daten, die das Aussehen von Objekten definieren, aber auch wichtige Bauteil-Informationsdaten, wie z.B. Materialinformationen, Klassifizierung, Energiewerte, Brandschutz, Nutzung, Herstellerdaten u.ä. IFC werden von buildingSMART International und die internationale Norm ISO 16739 definiert.

Für weitere Informationen besuchen Sie <a href="https://www.buildingsmart.org/standards/bsi-standards/industry-foundation-classes/" target="_blank">building smart</a> oder schauen Sie in die <a href="https://docs.madaster.com/files/de/IFC-Richtlinien%20f%C3%BCr%20BIM%20Modelle.pdf" target="_blank">Madaster BIM-Richtlinien</a>.

### Level of Detail (LOD)

Das Level of Detail, zu Deutsch **Detaillierungsgrad**, beschreibt die verschiedenen Detailstufen bei der Darstellung von BIM-Modellen. Je nach Betrachtungsabstand und Verwendungszweck wird die Detailgenauigkeit eines Objekts angepasst, um die Rechenleistung und die visuelle Qualität zu optimieren.

LOD-Modelle werden in der Regel in Stufen von 100 bis 500 unterteilt, wobei LOD 100 die geringste Detailstufe und LOD 500 die höchste Detailstufe darstellt.

Für weitere Informationen besuchen Sie <a href="https://www.united-bim.com/practical-approach-to-level-of-detail/" target="_blank">united-bim</a>.

### Property Set (PSet) und Custom Property Set (CPSet)

PSet steht für Property Set (**Eigenschaftensatz**). Es handelt sich dabei um eine Gruppierung von Eigenschaften, die einem IFC-Objekt zugeordnet werden können. Diese Eigenschaften können zusätzliche Informationen über das Objekt liefern, die nicht durch die Standard-IFC-Schemaeigenschaften abgedeckt werden.

PSets dienen dazu, die Flexibilität und Erweiterbarkeit von IFC-Modellen zu erhöhen. Sie ermöglichen es, benutzerdefinierte Informationen an IFC-Objekte anzuhängen, die für bestimmte Anwendungsfälle oder Informationsbedürfnisse relevant sind. Bei der Auswertung eines Bauteils können nur die Eigenschaften, die dem Bauteil zugeordnet sind, erfasst und berechnet werden. 

Jedem Element können beliebige Eigenschaften (Attribute) zugeordnet werden. Für Madaster wurde ein sogenanntes **Custom Property Set (CPSet_Madaster)** entwickelt. Genauere Informationen dazu finden Sie in unserem **Madaster BIM-Handbuch** unter <a href="../resources/downloads" target="_blank">Downloads bei Handbücher und Vorlagen</a>. Dort finden Sie ebenfalls einen ZIP-Ordner für *Revit*  und einen für *Archicad* mit hilfreichen Dateien für die Implementierung in diesen CAD-Programmen.

## Datenschutz-Grundverordnung (DSGVO)

Die DSGVO oder auch **General Data Protection Regulation (GDPR)** ist ein Gesetz der Europäischen Union zum Datenschutz und zur Datensicherheit. Die Verordnung gilt für alle Organisationen weltweit, sofern ihre Aktivitäten auf Menschen in der EU abzielen oder Daten von ihnen sammeln. Die Verordnung ist am 25. Mai 2018 in Kraft getreten.

Weitere Informationen finden Sie unter <a href="https://gdpr.eu/what-is-gdpr/" target="_blank">gdpr.eu</a> bzw. Madaster betreffend <a href="https://madaster.com/app/uploads/sites/4/2023/01/Madaster-GER_Datenschutzerkla%CC%88rung-Website_Januar-2023.pdf" target="_blank">hier</a>.

## Datenbanken

### EPEA Generic

Diese Datenbank, welche von Expert:innen geprüft und von der EPEA verifiziert wurde, basiert auf einer Kombination aus EPDs sowie wissenschaftlicher und öffentlicher Literatur. Sie enthält **Informationen zu generischen Bauprodukten und -materialien**. Neben den Umweltauswirkungen enthält sie Informationen zur Materialherkunft, Materialverwertung (Kreislauffähigkeit) und potenziellen Schadstoffen sowie Emissionen der Produkte und Materialien.

Sie finden diese Datenbank in der Plattform in der linken Navigationsleiste unter **Systemdatenbanken** <iconify-icon inline icon='mdi-database-cog-outline'/>. Einen Excelexport der **EPEA Material-/Produktliste** finden Sie unter <a href="../resources/downloads" target="_blank">Downloads bei Handbücher und Vorlagen</a>.

### ECO Platform – ECO Portal / Soda4LCA

Die ECO Platform zielt darauf ab, Ökobilanzen für Objekte und Infrastrukturprojekte durch die Bereitstellung zuverlässiger Produktdaten auf effektive Weise zu etablieren.

Weitere Informationen finden Sie bei <a href="https://www.eco-platform.org/home.html" target="_blank">www.eco-platform.org</a>.

### Institut für Bauen und Umwelt e.V. (IBU)

Das Institut für Bauen und Umwelt e.V. ist eine führende Organisation in Deutschland, die sich auf die Nachhaltigkeit im Bauwesen spezialisiert hat. Das Hauptziel des IBU ist, die Umweltauswirkungen von Bauprodukten transparent zu machen und damit die nachhaltige Entwicklung im Bauwesen zu fördern. Zu den Hauptaufgaben zählen die Entwicklung, **Verbreitung von Umweltproduktdeklarationen (EPD**)**, sowie die Bereitstellung einer frei zugänglichen EPD-Datenbank.

Die IBU-Datenbank finden Sie <a href="https://ibu-epd.com/veroeffentlichte-epds/#" target="_blank">hier</a>.

### ÖKOBAUDAT

Mit der Plattform ÖKOBAUDAT stellt das Bundesministerium für Wohnen, Stadtentwicklung und Bau (BMWSB) allen Akteuren eine einheitliche Datenbasis für die Ökobilanzierung von Objekten und Infrastrukturprojekten zur Verfügung. Herzstück der Plattform ist die **Online-Datenbank** mit Ökobilanz-Datensätzen zu Baumaterialien, Bau-, Transport-, Energie- und Entsorgungsprozessen.

Sie finden die eingebundenen Datensätze der Datenbank in der Plattform in der linken Navigationsleiste unter **Systemdatenbanken** <iconify-icon inline icon='mdi-database-cog-outline'/>. Die ÖKOBAUDAT selbst finden Sie unter <a href="https://www.oekobaudat.de" target="_blank">www.oekobaudat.de</a>.

## Skalierbarkeit

Für manche Produkte kann eine Skalierungsberechnung entsprechend der verschiedenen Ausführungen (bspw. in Länge oder Gewicht) durchgeführt werden. Das bedeutet, dass mit zunehmender Größe eines Produkts, **basierend auf einer definierten Einheit**, die als funktionale Einheit bezeichnet wird, eine andere Eigenschaft des Produkts proportional mit der Zunahme der funktionalen Einheit zunimmt. Ein Beispiel wäre ein Rohr, bei dem die Länge als funktionale Einheit definiert ist, und mit einer Zunahme der Länge nimmt die Dicke des Rohrs proportional zu.

Ausführliche Informationen finden Sie <a href="../knowlegde-base/databases-products#skalierbarkeit" target="_blank">hier</a>.

## Standards

### Abfallschlüssel

Die Abfallschlüssel gemäß **Abfallverzeichnis-Verordnung (AVV)**, auch bekannt als European Waste Codes (EWC), sind Teil eines europaweiten Systems zur Klassifizierung von Abfällen. Diese Schlüssel werden verwendet, um Abfälle gemäß ihrer Herkunft und Zusammensetzung zu kategorisieren. Das System wurde entwickelt, um die Entsorgung und das Recycling von Abfällen zu erleichtern und sicherzustellen, dass Abfälle korrekt gehandhabt und entsorgt werden.

Die Abfallschlüssel sind auch verschiedene Weise in der Plattform integriert.

### Building Research Establishment Environmental Assessment Method (BREEAM)

BREEAM ist das führende **Validierungs- und Zertifizierungssystem** für ökologische und soziokulturelle Aspekte der Nachhaltigkeit von Gebäuden. Der gesamte Lebenszyklus von Gebäuden wird anhand von 9 Kategorien bewertet und anschließend eine Gesamtnote vergeben.

Für weitere Informationen besuchen Sie bitte die <a href="https://bregroup.com/products/breeam/" target="_blank">BRE Group</a>.

### DGNB

Die **Deutsche Gesellschaft für Nachhaltiges Bauen e.V. (DGNB)** ist eine Organisation, die sich auf die Förderung nachhaltiger Baupraktiken und die Zertifizierung von Gebäuden und Quartieren spezialisiert hat. Sie wurde 2007 gegründet und hat sich zu einem der führenden Akteure im Bereich des nachhaltigen Bauens entwickelt. Die DGNB bietet ein **Zertifizierungssystem** an, welches u.a. die Nachhaltigkeit von Gebäuden oder Quartieren umfassend bewertet. Die DGNB-Zertifizierung kann als Nachweis dafür dienen, dass ein Bauprojekt bestimmte Nachhaltigkeitskriterien erfüllt, die auch in der EU-Taxonomie gefordert werden. Als ein Bestandteil der Zertifizierung kann ein **Gebäuderessourcenpass** gefordert werden.

Für weitere Informationen besuchen Sie bitte die Seite der  <a href="https://www.dgnb.de/de" target="_blank">DGNB</a>. Inwiefern die Vorgaben der DGNB über Madaster ausgewertet werden können, lesen sie bitte <a href="../knowledge-base/features#dgnb" target="_blank">hier weiter</a>.

### DIN 276

Die DIN 276 gilt für die **Kostenplanung im Bauwesen**, insbesondere für die Ermittlung und Klassifizierung von Kosten in den Kostengruppen 100-800. Sie umfasst die Kosten von Gebäuden, Ingenieurbauwerken, Infrastruktureinrichtungen und Freianlagen sowie die damit verbundenen projektbezogenen Kosten.

Weitere Informationen finden Sie u.a. im <a href="https://www.bauindex-online.de/regelwerke/din-276/" target="_blank">BAU-Index</a>.

### Global Trade Item Number (GTIN)

Die Global Trade Item Number kann von einem Unternehmen zur **eindeutigen Identifizierung** aller seiner Handelsartikel verwendet werden. GS1 definiert Handelsartikel als Produkte oder Dienstleistungen, die an einem beliebigen Punkt der Lieferkette bepreist, bestellt oder in Rechnung gestellt werden.

Für weitere Informationen besuchen Sie bitte <a href="https://www.gs1.org/standards/id-keys/gtin" target="_blank">GS1</a>.

### Globally Unique Identifier (GUID)

Weitere Bezeichnungen sind auch UUID oder Universaly Unique Identifier. Technisch gesehen handelt es sich um eindeutige 128-Bit-Referenznummern, die in der Datenverarbeitung verwendet werden und bei deren Generierung eine Wiederholung höchst unwahrscheinlich ist, obwohl es keine zentrale GUID-Behörde gibt, die die Eindeutigkeit gewährleistet.

Für weitere Informationen besuchen Sie bitte <a href="http://guid.one/guid" target="_blank">guid.one</a>.

### Level(s)
Level(s) ist ein **freiwilliges europäisches Rahmenwerk**, das von der Europäischen Kommission entwickelt wurde, um die Nachhaltigkeit von Gebäuden zu bewerten und zu verbessern. Es bietet eine strukturierte Methode zur Messung und Berichterstattung über die Umweltleistung von Gebäuden während ihres gesamten Lebenszyklus. Level(s) zielt darauf ab, ein gemeinsames Verständnis und eine gemeinsame Sprache für Nachhaltigkeit im Bauwesen zu schaffen und so zur Erreichung der EU-Klimaziele beizutragen.

Inwiefern Berichte gemäß der Makroziele und spezifischer Indikatoren über Madaster ausgegeben werden können, lesen sie bitte <a href="../knowledge-base/features#levels" target="_blank">hier weiter</a>.

### NL-SfB

Das **Klassifizierungssystem** der NL-SfB (“Nederlandse basisindeling voor de bouw”, übersetzt: “Niederländische Basisklassifikation für das Bauwesen”) ist ein in der niederländischen Bauindustrie verwendetes System, das baurelevante Informationen organisiert. Dies geschieht in verschiedenen Kategorien, von denen eine die Materialklassifikation ist (Tabelle 3). Die Madaster V2-Klassifikation ist eine Referenz zu dieser Materialklassifikation.

Die vollständige NL-SfB-Klassifikation (V201912) steht als Excel-Datei zum <a href="https://ketenstandaard.nl/app/uploads/2020/03/NL-SfB_Tabel_0-4_Update-V201912.xlsx" target="_blank">Download</a> bereit.

### OmniClass

OmniClass® ist ein umfassendes **Klassifizierungssystem** für die Bauindustrie. OmniClass kann für viele Anwendungen eingesetzt werden, z.B. für die Ablage von physischen Materialien oder die Organisation von Projektinformationen. Seine Hauptanwendung besteht aber darin, eine Klassifizierungsstruktur für elektronische Datenbanken und Software bereitzustellen und so die in diesen Ressourcen verwendeten Informationen zu bereichern. OmniClass integriert andere bestehende Systeme, die derzeit als Grundlage für zwei seiner Tabellen verwendet werden - MasterFormat® für Tabelle 22 - Arbeitsergebnisse und UniFormat® für Tabelle 21 - Elemente. OmniClass bietet eine Methode zur Klassifizierung der gesamten gebauten Umwelt während des gesamten Projektlebenszyklus. Sie ist das nordamerikanische Pendant zu Uniclass.

Weitere Informationen finden Sie <a href="https://higherlogicdownload.s3.amazonaws.com/CSIRESOURCES/b00cc178-1ca0-4e36-aeae-82edcd55c99c/UploadedImages/OmniClass_files/OmniClass_Main_Intro_2019-02-22.pdf" target="_blank">hier</a>.

### Product Circularity Data Sheet (PCDS)

Das **Produktzirkularitätsdatenblatt** kann verwendet werden, um festzustellen, wie zirkulär ein Produkt wirklich ist. Es informiert über den Kreislauf, für den es entworfen und hergestellt wurde. Das PCDS bietet ein standardisiertes Format mit vertrauenswürdigen Daten ohne Wertung oder Ranking der verschiedenen Aspekte. Die entsprechende ISO/WD 59040 befindet sich derzeit noch in der Entwicklung.

Für weitere Informationen besuchen Sie bitte <a href="https://pcds.lu/pcds-system/#pcds" target="_blank">pcds.lu</a>.

### QNG

Das **Qualitätssiegel Nachhaltiges Gebäude** ist ein staatliches Gütesiegel des Bundesministerium für Wohnen, Stadtentwicklung und Bauwesen für Gebäude, das durch akkreditierte Zertifizierungsstellen vergeben wird. Das QNG stellt die Erfüllung von Anforderungen an die ökologische, soziokulturelle und ökonomische Qualität von Gebäuden sowie an die Qualität der Planungs- und Bauprozesse sicher.

Das QNG wird in zwei Qualitätsniveaus vergeben, welche die Erfüllung nachhaltigkeitsrelevanter Merkmale und Eigenschaften in überdurchschnittlicher Qualität (QNG-PLUS) und deutlich überdurchschnittlicher Qualität (QNG-PREMIUM) auf einen Blick erkennen lassen.

Für weitere Informationen besuchen Sie bitte <a href="https://www.qng.info/" target="_blank">qng.info</a>.

### Uniformat

Uniformat® ist ein standardisiertes **Klassifizierungssystem**, das zur strukturierten Beschreibung und Analyse der Komponenten und Systeme eines Gebäudes verwendet wird. Es wurde ursprünglich von ASTM International (American Society for Testing and Materials) entwickelt und bietet eine konsistente Methode zur Kategorisierung von Bauwerkskomponenten, die besonders für Kostenplanung, Leistungsbewertung und Lebenszyklusanalyse nützlich ist.

Weitere Informationen finden Sie beim <a href="https://www.csiresources.org/standards/uniformat/about-uniformat" target="_blank">Construction Specifications Institute</a>.

### Unique Identifier (UID)

Ein Unique Identifier ist eine numerische oder alphanumerische Zeichenfolge, die einer einzelnen Einheit innerhalb eines bestimmten Systems zugeordnet ist. UIDs machen es möglich, diese Einheit zu adressieren, so dass auf sie zugegriffen und mit ihr interagiert werden kann. Eindeutige Bezeichner können allen Dingen zugewiesen werden, die von anderen Einheiten unterschieden werden müssen, z.B. einzelnen Benutzern, Unternehmen, Maschinen oder Websites. Diese unverwechselbaren Werte werden in der Regel je nach den Erfordernissen der jeweiligen Anwendung zugewiesen, können aber auch nach dem Zufallsprinzip mit einem Algorithmus automatisch generiert, schrittweise zugewiesen oder vom Benutzer ausgewählt werden.

Für weitere Informationen besuchen Sie bitte <a href="https://www.techtarget.com/iotagenda/definition/unique-identifier-UID" target="_blank">TechTarget</a>.

## Umwelt

### DIN EN 15804

Die DIN EN 15804 ist die grundlegende Norm für die Information über die Nachhaltigkeit von Bauprodukten. Diese Norm harmonisiert die Struktur für EPDs im Bausektor und macht die Informationen transparent und vergleichbar. Die erste Fassung wurde 2012 unter dem Namen **EN 15804+A1** *Nachhaltigkeit von Bauwerken - Umweltproduktdeklarationen - Grundregeln für die Produktkategorie Bauprodukte* veröffentlicht. Eine zweite Version der Norm mit der Bezeichnung **EN 15804+A2** wurde 2019 veröffentlicht, mit dem Ziel, die normbasierten EPDs an die Formate des Product Environmental Footprint (PEF) anzugleichen. Einige der Änderungen umfassen mehr Anforderungen an die abgedeckten Lebenszyklusstadien, zusätzliche Indikatoren für die Umweltauswirkungen, neue Inhalte in Bezug auf den biogenen Anteil und eine explizitere Beschreibung der funktionellen Einheit und der deklarierten Einheit.

Die DIN EN 15804 definiert folgende Lebenszyklusphasen eines Gebäudes:
* Herstellungsphase (A1-A3)
* Errichtungsphase (A4-A5)
* Nutzungsphase (B1-B7)
* Entsorgungsphase (C1-C4)
* Vorteile & Belastungen außerhalb der Systemgrenzen (D)

### DIN EN 15978

Diese Norm mit dem Titel *Nachhaltigkeit von Bauwerken - Bewertung der umweltbezogenen Qualität von Gebäuden - Berechnungsmethode* definiert eine Methodik zur **Bewertung der Umweltperformance von Gebäuden** über ihren gesamten Lebenszyklus. Sie gilt für die Bewertung von Neubauten, Bestandsgebäuden und Gebäudesanierungen. Die für die erechnung relevanten Daten stammen aus Umweltproduktdeklarationen gemäß DIN EN 15804 und anderen für die umweltbezogene Qualitätsbewertung relevante Informationen.

### Environmental Product Declaration (EPD)

Eine **Umweltproduktdeklaration** ist ein standardisiertes Dokument, das transparente und verifizierbare Informationen über die Umweltauswirkungen eines Produkts während seines gesamten Lebenszyklus liefert. Sie basiert auf den Prinzipien der Ökobilanz (LCA) und dient dazu, die Umweltperformance eines Produkts verschiedenen Interessengruppen wie Verbrauchern, Unternehmen und politischen Entscheidungsträgern zu kommunizieren. EPDs bilden eine wichtige Grundlage für die Nachhaltigkeitsbewertung von Gebäuden.

### Life cycle assessment (LCA)

Eine **Ökobilanz** ist eine systematische Methode zur Bewertung der Umweltauswirkungen eines Produkts, Systems oder Prozesses über seinen gesamten Lebenszyklus. Sie betrachtet alle Phasen des Lebenszyklus, von der Rohstoffgewinnung bis zur Entsorgung oder Wiederverwertung und quantifiziert die Umweltauswirkungen in verschiedenen Kategorien, wie z.B. Treibhausgaspotenzial (GWP).

Eine detaillierte Erläuterung finden Sie <a href="https://eplca.jrc.ec.europa.eu/lifecycleassessment.html" target="_blank">hier</a>.

## Zirkularität

### Demontierbarkeit

Bei der Bewertung der Demontierbarkeit wird berücksichtigt, wie die Produkte miteinander verbunden sind sowie ob und wie sie aus einer Konstruktion entfernt werden können. Die Angabe der Demontierbarkeit in Madaster basiert auf der überarbeiteten Version der einheitlichen Messmethode für die Demontierbarkeit, wie im Bericht *Circular Buildings - a measurement methodology for disassembly potential 2.0* beschrieben, welcher von einem Konsortium aus u.a. dem Dutch Green Building Council, der Netherlands Enterprise Agency und W/E Adviseurs im Auftrag des niederländischen Innenministeriums und der Transition Agenda Circular Building Economy entwickelt und getestet wurde.

Ausführliche Informationen finden Sie bitte in unserer <a href="../knowledge-base/calculations#demontierbarkeit-detachability" target="_blank">Wissensdatenbank</a>.

### Madaster Zirkularitätsindikator (MZI)

Der Madaster Zirkularitätsindikator wurde entwickelt, um die Kreislauffähigkeit von Objekten zu bewerten (von 0-100%). Für die Berechnung werden die Materialherkunft, Materialverwertung und ein Korrekturfaktor für unbekannte Materialien als Grundlage genommen.

Ausführliche Informationen dazu finden Sie bitte in unserer <a href="../knowledge-base/calculations#madaster-zirkularitätsindikator-mzi" target="_blank">Wissensdatenbank</a>.

### Materialien

**Primäre (Roh-)Materialien** sind natürliche (aus der Natur gewonnenen) Ressourcen. Unabhängig von ihrer Gewinnung umfasst das unverarbeitete Rohstoffe, wie zum Beispiel frische Holzfasern für die Papierherstellung, die aus gefällten Bäumen gewonnen wurden. 

**Sekundär(roh)stoffe** hingegen werden durch Wiederaufbereitung (Recycling) aus entsorgtem Material gewonnen, z.B. Holzfasern aus Altpapier. Daher weden Sie auch als Rezyklate oder Recycling(roh)stoffe bezeichnet. Es handelt sich also um Stoffe, die im Rahmen der Rohstoffwirtschaft in einer Kaskade ein wiederholtes Mal verwendet werden. Die Verwendung von Sekundärstoffen schont die natürlichen Ressourcen und trägt zu einer nachhaltigen Entwicklung bei. Sekundärstoffe entstehen, wenn Abfälle recycelt werden, aber nicht, wenn sie deponiert, energetisch verwertet oder verbrannt werden.

Gemäß der EU-Taxonomie müssen **nachhaltig produzierte erneuerbare Rohstoffe** eine international anerkannte Zertifizierung aufweisen. Beispiele solcher Zertifizierungen sind:
* ISCC PLUS - Zertifizierung für die Kreislaufwirtschaft und Bioökonomie
* FSC - Rat für Waldbewirtschaftung
* PEFC - System zur Sicherstellung einer nachhaltigen Waldbewirtschaftung
* RSB - Globale Zertifizierung für nachhaltige Kraftstoffe und Materialien aus Biomasse, Abfällen und Reststoffen

### Recycling (Wiederverwertung)

Unter Recycling versteht man das Sammeln und Verarbeiten von gebrauchten Produkten und Materialien, die sonst als Abfall entsorgt werden würden, und deren Umwandlung in neue Produkte. Auf diese Weise wird die Menge der zu deponierenden Abfälle verringert und wertvolle Ressourcen an Primärrohstoffen geschont. Allerdings wird dazu häufig nicht wenig Energie verbraucht und Kohlenstoff freigesetzt.

**Recycling-Effizienz** ist eine Kennzahl zur Charakterisierung der technischen Leistung eines Recyclings. Der allgemeine Ansatz zur Schätzung der Effizienz ist der Input, gemessen als Masse oder Volumen aller Fraktionen oder Materialien, welche dem Recyclingprozess pro Zeitraum (in der Regel pro Jahr) zugeführt werden sowie der Output, gemessen als Masse der nützlichen recycelten Komponenten, mit Ausnahme aller nicht recycelten Materialien, die in den Abfall gelangen. Der Verlust von Bestandteilen an den Abfall kann auf Prozessineffizienzen wie Sortierverluste, Schlackenverluste, Beschädigungen oder Qualitätseinbußen zurückzuführen sein.

### Repurpose (Weiterverwendung)

Unter Weiterverwendung versteht man den Einsatz eines Produkts mit einem bestimmten Nutzungswert in einem neuen Objekt unter einem anderen Nutzungswert.

### Reuse (Wiederverwendung)

Wiederverwendung ist das Prinzip der Einsparung von Aufwand und Material durch die wiederholte Verwendung einer Sache, die an einem Ort nicht mehr benötigt wird, an einem anderen. Im Sinne der **europäischen Abfallrahmenrichtlinie** verstaht man darunter “jedes Verfahren, bei dem Erzeugnisse oder Bestandteile, die keine Abfälle sind, wieder für denselben Zweck verwendet werden, für den sie ursprünglich bestimmt waren."

Mehr Informationen finden Sie <a href="https://www.re-use-hessen.de/was-ist-re-use/" target="_blank">hier</a>.