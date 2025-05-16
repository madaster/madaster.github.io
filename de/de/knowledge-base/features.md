---
title: Features
description: Verfügbare Ergänzungen der Partnerschaftslizenzen
ref: features
type: Wissensdatenbank
menubar: knowledge-base-nav
---

Verfügbare Ergänzungen der Partnerschaftslizenzen

## Allgemeines

Auf Accountebene <iconify-icon inline icon='mdi-briefcase-variant'/> hinter dem Symbol <iconify-icon inline icon='mdi-dots-vertical'/> im Tab **Features** finden Sie eine Übersicht der verfügbaren Funktionen sowie der Vorschaufunktionen.

Die **verfügbaren Features** auf der linken Seite können Sie selbst aktivieren <iconify-icon inline icon='mdi-toggle-switch'/> oder - sofern kostenpflichtig - im Tab <a href="../get-started/set-up-your-account#abonnement-verwalten" target="_blank">Abonnement</a> jederzeit selbstständig hinzubuchen. Ergänzungen des laufenden Vertrages werden immer anteilig zur aktuellen Laufzeit berechnet. 

Die **Vorschau-Features** auf der rechten Seite stehen in einer Alpha-Version für die Evaluierung durch unsere Benutzer zur Verfügung. Wenn Sie Interesse haben, uns bei der Entwicklung mittels Anwenderfeedback zu unterstützen, melden Sie sich bitte gern unter über unsere Servicehotline [+49 30 235962051](tel:+4930235962051) oder per Mail an <service@madaster.de> und wir schalten Ihnen den Zugriff frei. Im Folgenden sind diese Features mit einem Stern markiert.

## 3D-Viewer

Nicht zu verwechseln mit dem Tab BIM-Viewer, welcher die im Objekt hochgeladene IFC-Datei visualisiert, ermöglicht die **3D-Ansicht hinsichtlich Umweltauswirkungen und Kreislaufwirtschaft** eine visuelle, farbcodierte Darstellung der Produkte Ihres Objekts mit dem jeweils größten Einfluss. Somit können Sie anhand des Modells sehen, ob Sie Ihre Zielsetzung hinsichtlich einer nachhaltigen Bauweise erreicht haben.

Sobald dieses Feature aktiviert ist:
1. Können Sie in den Tabs **Zirkularität** und **Umwelt** im Dropdown-Menü unter den KPI die Option **Material/Produkt** wählen.
2. Sodann erscheint die Schaltfläche **3D-Viewer**, worüber die interaktive Modellansicht gestartet wird, in der die Elemente mit einer Farbkodierung von dunkelgrün (gut) bis dunkelrot (schlecht) markiert sind, um ihre Auswirkungen gemäß der jeweils gewählte Analyse zu signalisieren.
3. Über die Schaltfläche **Grafik anzeigen** gelangen Sie zurück zum Balkendiagramm. 

Dieses kostenpflichtige Feature kann über den Tab **Abonnement** hinzugebucht werden.

> Hinweis: Eine Sneakpreview können Sie an entsprechender Stelle in Ihren Objekten finden.

## API-Schreibaktionen

Dieses Feature ermöglicht die Interaktion mit der Madaster-Plattform über deren integrierte Schnittstelle mittels Code oder aus anderen Anwendungen unter Verwendung der bereitgestellten <a href="../api/index" target="_blank">API-Endpunkte</a>.

Ein <a href="../api/index#token" target="_blank">API-Token</a> muss generiert werden, damit sich die Anwendung Ihrer Wahl als Benutzer mit bestimmten Rechten und Rollen identifizieren kann. Dann gibt es alle Arten von Aktionen, die über diese API durchgeführt werden können. Folgend ein paar Beispiele.

* **POST** ein neues Objekt im Account
* **POST** eine neue Quelldatei
* **GET** alle Daten eines Objekts innerhalb des Accounts
* **POST** die Terminplanung des Neuberechnungsprozesses für ein Objekt
* **DELETE** ein Objekt *(oder spezifische Teilinformationen)*
* **POST** ein neues Produkt zu einer Datenbank
* **GET** alle verfügbaren Datenbanken
* **POST** einen neuen Ordner im Account

    und viele weitere Optionen...

Weitere Informationen zur Plattform-API von Madaster finden Sie in der spezifischen <a href="https://api.madaster.com/" target="_blank">OpenAPI_Dokumentation</a>.

Dieses kostenpflichtige Feature kann über den Tab **Abonnement** hinzugebucht werden.

## CRREM (Carbon Risk Real Estate Monitor)

Das CRREM-Tool wurde entwickelt, um die Kohlenstoffemissionen eines Gebäudes während seines Betriebs zu berechnen. Dieses extern entwickelte Tool wurde auf der Madaster-Plattform integriert, um die Betriebsdaten einzelner Gebäude aber auch ganzer Portfolios auswerten zu können.

Auf Objektebene kann im Tab **ESG** im Dropdown diese Berichtsart ausgewählt werden. Über die Schaltfläche **Einstellungen anzeigen** <iconify-icon inline icon='mdi-cog-outline'/> können Sie die Daten zu den Gebäudeeigenschaften, dem Energiebezug, den flüchtigen Emissionen und den erneuerbaren Energien im Tab **Input** eingeben und für die Verarbeitung **Speichern**.

Diese Daten werden mit einem globalen Erwärmungsziel bzw. einem Standardwert kombiniert
* Emissionsfaktor für Elektrizität
* Fernwärme-Emissionsfaktor
* Fernkälte-Emissionsfaktor
* Elektrizitätspreis
* Gaspreis
* Fernwärmepreis
* Fernkältepreis
* Preis der ausgewählten "Anderen Energiequelle" Nr. 1
* Preis der ausgewählten "Andere Energiequelle" Nr. 2
* CO<sub>2</sub> je nach Standort des Gebäudes.

Sollten spezifischere Informationen zu diesen Zahlen vorliegen, können Sie diese im Tab **User-defined settings** ergänzen. Bitte beachten Sie, dass für jedes Gebäude unter Allgemein die **Gross internal area** ausgefüllt sein muss und das **Datum Fertigstellung** in der Vergangenheit liegen muss.

Nachdem Sie nun die Daten Ihres Gebäudebetriebs eingegeben haben, berechnet die Plattform die jährlichen CO<sub>2</sub>-Emissionen sowie die Energiekosten und den jährlichen Energieverbrauch. Um Kohlenstoffneutralität bis 2050 zu erreichen, berechnet das CRREM-Tool einen Dekarbonisierungspfad für ein Gebäude. Alle nachfolgenden Emissionen, die über das Dekarbonisierungsziel hinausgehen (so genannte "Excess-Emissionen"), stellen ein Kohlenstoff-Risiko dar. Die wirtschaftliche Obsoleszenz ist mit dem Stranding-Datum verbunden; je höher die überschüssigen Emissionen sind, desto größer ist die Wahrscheinlichkeit der wirtschaftlichen Obsoleszenz.

Weitere Informationen zum CRREM-Tool finden Sie unter <a href="https://www.crrem.eu/" target="_blank">www.crrem.eu</a> bzw. im <a href="https://www.crrem.eu/wp-content/uploads/2023/09/CRREM-Risk-Assessment-Reference-Guide-V2_11_09_2023-final.pdf" target="_blank">User manual for the CRREM Risk Assessment Tool V2</a>.

Dieses kostenpflichtige Feature kann über den Tab **Abonnement** hinzugebucht werden.

> Hinweis: Bitte achten Sie darauf, dass außerdem der <a href="../knowledge-base/features#esg" target="_blank">ESG-Tab</a> aktiviert ist, um Zugriff auf das dort integrierte CRREM-Tool zu haben.

## Datenbank Import/Export*

Sofern Produktdaten in Datenbanken nicht über eine Schnittstellenanbindung eingespeist werden können, müssen Sie einzelnen per manueller Eingabe erfasst werden. Um hier noch eine Alternative zur Verfügung zu stellen, arbeiten wir an der Möglichkeit, Daten **per Excel** zu erfassen und auch zu exportieren.

1. Klicken Sie in der betreffenden Datenbank <iconify-icon inline icon='mdi-database'/> im Tab **Dossier** auf **Import/Export** <iconify-icon inline icon='mdi-swap-vertical'/>.
2. Wählen Sie zunächst **Exportieren** <iconify-icon inline icon='mdi-radiobox-marked'/> und die entsprechende Sprache.

    * Sofern Sie noch keine Produkte erfasst haben, wählen Sie **Leere Vorlage generieren** <iconify-icon inline icon='mdi-checkbox-marked'/>.
    * Sofern Sie bereits Produkte angelegt haben, wählen Sie, welche Produktdaten exportiert bzw. über die Excel bearbeitet werden sollen.

3. Nachdem Sie mit **OK** bestätigt haben, steht Ihnen die entsprechende Excel nach Fertigstellung im Dossier für den **Download** zur Verfügung.
4. Die Option **Importieren** ist erst verfügbar, nachdem überhaupt einmal ein Export generiert wurde. </br> Wählen Sie, welche Produktdaten über die Excel importiert werden sollen sowie die lokal gespeicherte Datei und bestätigen Sie mit **OK**. Wenn alle Informationen korrekt sind, werden Ihre Produkte der Datenbank hinzugefügt und in der Produktübersicht angezeigt.

*Es handelt sich um ein **Vorschau-Feature**. Bei Interesse kontaktieren Sie bitte den Support.

## DGNB*

Der Kriterienkatalog „Gebäude Neubau“ in der Version 2023 umfasst eine Vielzahl von Parametern und Indikatoren, die für eine Zertifizierung erfasst und berichtet werden müssen. Bereits auf Madaster erfasste Daten können aus der Plattform ausgelesen und weitergegeben werden, um in passenden Teilbereichen für die DGNB-Zertifizierung oder im Berichtsprozess genutzt zu werden. 

Die DGNB unterscheidet in ihrem System in folgende Nutzungsprofile:

* Bildungsbauten
* Büro- und Verwaltungsgebäude
* Geschäftshäuser
* Gesundheitsbauten
* Hotels
* Logistikgebäude
* Produktionsstätten
* Shoppingcenter
* Verbrauchermärkte
* Versammlungsstätten
* Wohngebäude 

Derzeit kann Madaster Sie im Zertifizierungsprozess in den folgenden Teilbereichen unterstützen:

### ENV 1.1 – Klimaschutz und Energie

In dieser Kategorie können verschiedene Key Performance Indicators (KPI) wie die Treibhausgasemissionen und Primärenergiebedarfe des baulichen Teils sowie in Betrieb und Nutzung dargestellt und ausgegeben werden (KPI 1-4). Darüber hinaus ist die Bauwerksmasse gemäß LCA auswertbar (KPI 9 auf S. 43 f. des Kriterienkatalogs).
Diese sind auf die Bilanzierungsregeln der DGNB abgestimmt und können somit zu einer Vergleichbarkeit der Lebenszyklus-CO<sub>2</sub>-Bilanz zwischen verschiedenen Projekten und zur Einordnung gemäß vorgegebener Benchmarks genutzt werden (Grenz-, Referenz-, Ziel-, oberer Zielwert).

### TEC 1.6 - Zirkuläres Bauen
Im Kriterium TEC 1.6 des DGNB-Kriterienkatalogs wird zwischen Projekten mit und ohne Rückbau unterschieden. Die Bewertung basiert auf der Integration von Rückbaupotenzialen und zirkulären Konzepten bereits in der Planungsphase. In der Ausführungsphase werden Punkte für den Einsatz zirkulärer Produkte und Bauteile, sowie für die Dokumentation durch Produkt- oder Materialpässe vergeben. Eine umfassende Dokumentation in einem digitalen Gebäuderessourcenpass und hohe „Zirkularitätsquoten“ tragen ebenfalls zur Bewertung bei. Es werden Bonuspunkte für Gebäude vergeben, die überwiegend für die Kreislaufwirtschaft konzipiert.

1. Auf Objektebene kann im Tab **ESG** im Dropdown diese Berichtsart ausgewählt werden.
2. Die vorhandenen Daten können über die Schaltfläche **Gebäuderessourcenpass generieren** <iconify-icon inline icon='mdi-cog-outline'/> exportiert werden. In diesem Anwendungsfall werden die Tabellenfelder, für welche Informationen durch die Nutzung der Madaster-Plattform vorliegen, automatisch befüllt. 
3. Nach Fertigstellung steht Ihnen der befüllte Gebäuderessourcenpass gemäß der Excelvorlage der DGNB im **Dossier** zum Download zur Verfügung.
4. Fehlende Informationen können in der generierten Excel nach dem **Download** außerhalb der Plattform ergänzt werden.

### Welche Informationen füllt Madaster automatisiert im DGNB-Gebäuderessourcenpass aus?
Inhaltlich umfasst der Gebäuderessourcenpass sechs übergeordnete Bereiche mit insgesamt 25 Teilaspekten, die entweder verpflichtend oder optional anzugeben sind. 

> **Hinweis** Es können nur dann Auswertungen berechnet und exportiert werden, wenn die zugehörigen Informationen auf der Plattform eingepflegt sind. Fehlen Verknüpfungen, Material- oder Bauteilklassifikationen, o.ä., kann die Plattform diese nicht in den GRP exportieren.

#### Allgemeines
1. Projektinformationen

#### Bereich: Gebäudeinformationen und Gebäudemasse
1. Standort und Baujahr
1. Art der Bauweise
1. Typ/Anlass: Bestandserhalt oder Neubau
1. Gesamtmasse des Gebäudes
1. Flächengewichtete Gesamtmasse des Gebäudes
1. Umfang dokumentierter Masse
1. Datenbasis, Datenbank

#### Bereich: Materialität, Materialherkunft und Bau- und Abbruchabfälle
1. Materialität des Bauwerks
1. Monetärer Materialwert
1. Materialherkunft – Umgesetzte Kreislaufführung
1. Bau- und Abbruchabfälle der Baumaßnahme

#### Bereich: Umweltwirkungen über den Lebenszyklus
1. Umweltwirkungen über den Lebenszyklus

#### Demontagefähigkeit, Materialverwertungspotenzial und Zirkularitätsbewertung
1. Materialverwertung
1. Monetäre Restwerte

Mit diesen genannten Informationen wird dann automatisch eine Übersicht für den reduzierten und vollständigen Gebäuderessourcenpass in der Excel ausgefüllt.


Weitere Informationen finden Sie unter <a href="https://www.dgnb.de/de" target="_blank">www.dgnb.de</a>.

*Es handelt sich um ein **Vorschau-Feature**. Bei Interesse kontaktieren Sie bitte den Support.

## ESG

Der **ESG-Tab** (Environmental, Social & Governance) kann kostenfrei für einen Account aktiviert werden und steht daraufhin in der Tab-Leiste auf allen Ebenen (auch Ordner und Objekt) zur Verfügung. In diesem Tab sind diverse Reportingtools eingebunden, welche separat aktiviert werden müssen. Danach können Sie hier diverse Berichte erstellen und relevante KPI anzeigen lassen.

Folgende Funktionen sind hier beheimatet und aktuell verfügbar:

* <a href="../knowledge-base/features#crrem-carbon-rist-real-estate-monitor" target="_blank">CRREM</a>
* <a href="../knowledge-base/features#levels" target="_blank">Level(s)</a>
* <a href="../knowledge-base/features#dgnb" target="_blank">DGNB</a>

## Infrastruktur*

Dieses Feature ermöglicht neben Gebäuden auch andere <a href="../knowledge-base/classifications/nutzungsarten" target="_blank">Objekttypen</a> auf der Madaster-Plattform registrieren und dokumentieren zu können. Durch das Hochladen einer Excel- oder IFC-Quelldatei, können **Infrastrukturobjekte** nach Verknüpfung mit passenden Produktdaten regulär bezüglich Masse, Umweltwirkung, Zirkularität und finanziellem Restwert ausgewertet werden.

*Es handelt sich um ein **Vorschau-Feature**. Bei Interesse kontaktieren Sie bitte den Support.

> Hinweis: Aktuell suchen wir **erfahrene Partner**, die uns bei der Entwicklung begleiten und für Interviews zu Themen wie spezifische Dateiformate, Klassifikationen, Nachhaltigkeitsschwerpunkte und Reportings in den diversen <a href="../knowledge-base/classifications/nutzungsarten" target="_blank">Kategorien</a> zur Verfügung stehen.

## Level(s)*

Level(s) ist ein **europäischer Bewertungs- und Berichtsrahmen**, der eine gemeinsame Sprache für die Nachhaltigkeitsleistung von Gebäuden bietet. Level(s) fördert die Berücksichtigung des Lebenszyklus von Gebäuden und liefert einen robusten Ansatz zum Messen und Unterstützen von Verbesserungen vom Entwurf bis zum Lebensende von Wohngebäuden und Büroräumen.

Level(s) verwendet Basisindikatoren zur Nachhaltigkeit, die im und vom Bausektor getestet werden. Auf der Madaster-Plattform können für Gebäude aktuell folgende Makroziele und Indikatoren gewählt werden:

|Makro-ziel|Thema|Indika-tor|Thema|
|-|-|-|-|
|1.|Treibhausgas- und Luftschadstoffemissionen im Lebenszyklus eines Gebäudes|1.2|Erderwärmungspotenzial (GWP) entlang des Lebenszyklus|
|2.|Ressourceneffiziente Stoffkreisläufe|2.1|Leistungsverzeichnisse, Materialien und Lebensdauern|
|2.|Ressourceneffiziente Stoffkreisläufe|2.2|Bau- und Abbruchabfälle und -materialien|
|2.|Ressourceneffiziente Stoffkreisläufe|2.4|Entwurf für den Rückbau|

1. Auf Objektebene kann im Tab **ESG** im Dropdown diese Berichtsart ausgewählt werden.
2. Die vorhandenen Daten können über die Schaltfläche **Bericht generieren für Indikator *XY*** <iconify-icon inline icon='mdi-cog-outline'/> exportiert werden. In diesem Anwendungsfall werden die Tabellenfelder, für welche Informationen durch die Nutzung der Madaster-Plattform vorliegen, automatisch befüllt. 
3. Nach Fertigstellung steht Ihnen der Bericht im **Dossier** zum Download zur Verfügung.
4. Fehlende Informationen können in der generierten Excel nach dem **Download** außerhalb der Plattform ergänzt werden.

Weitere Informationen zu Level(s) finden Sie bei der <a href="https://environment.ec.europa.eu/topics/circular-economy/levels_en" target="_blank">European Commission</a>.

*Es handelt sich um ein **Vorschau-Feature**. Bei Interesse kontaktieren Sie bitte den Support.

> Hinweis: Bitte achten Sie darauf, dass außerdem der <a href="../knowledge-base/features#esg" target="_blank">ESG-Tab</a> aktiviert ist, um Zugriff auf die dort integrierten Level(s)-Berichte zu haben.

## Objekt teilen

Die Funktion **Split object** kann kostenfrei für einen Account aktiviert werden und ermöglicht es, auf Grundlage einer einzigen IFC-Quelldatei mehrere, individuelle Objektdossiers und Materialpässe, entsprechend der Objekteinheiten zu erstellen. Teilen Sie bspw. eine IFC-Datei eines Quartiers oder eines Mehrfamilienhauses in einzelne Häuser oder Wohnungen.

Um dieses Feature nutzen zu können, muss in der Quelldatei für jedes Element eine entsprechende **Objektnummer** angegeben sein.

1. Nachdem die Quelldatei hochgeladen und angereichert wurde, klicken Sie im Tab **Allgemeines** auf die Schaltfläche **Objekt splitten** <iconify-icon inline icon='mdi-call-split'/>, um automatisch einzelne Objektdossiers auf der Grundlage der zugewiesenen Objektnummern zu erstellen.
2. Es erscheint eine **Benachrichtigung** <iconify-icon inline icon='mdi-bell-outline'/> sobald der Prozess beendet ist.
3. Gehen Sie in der linken Navigationsleiste auf das betreffende Objekt und öffnen Sie die darunter liegenden **Splittobjekte** <iconify-icon inline icon='mdi-chevron-down'/>.

## Track&Trace

Es handelt sich hierbei um ein **herstellerspezifisches Feature**.

Nachdem Sie dieses Feature aktiviert haben, können Hersteller damit ihre **Produkte verfolgen**, die Sie verkauft oder ggf. über einen „Produkt-als-Dienstleistung“-Vertrag angeboten haben. Sie können dadurch in der Madaster-Plattform einfach sehen, welche Produkte verbaut wurden, wann diese ersetzt werden (müssen) und wo sie sich befinden Track and Trace.

1. Gehen Sie auf die entsprechende Produktdatenbank und in den Tab **Track&Trace**.
2. **Filtern** <iconify-icon inline icon='mdi-filter-outline'/> Sie über die Schaltfläche oben links Produkte nach dem Installationsjahr oder dem geschätzten Austauschjahr und/oder der Nutzungsart.
3. **Zoomen** Sie alternativ in der Karte und/oder zeichnen Sie benutzerdefinierte Grenzen mittels der **Auswahlsymbole** <iconify-icon inline icon='mdi-pentagon'/> <iconify-icon inline icon='mdi-square'/> <iconify-icon inline icon='mdi-circle'/> oben rechts auf der Karte.
4. Zusätzlich können Sie unter Karte durch Anhaken spezifische **Produkte wählen**.
    
Klicken Sie auf die Schaltfläche **Nach Excel exportieren** <iconify-icon inline icon='mdi-file-download-outline'/>, um einen Bericht gemäß Ihrer Auswahl zu generieren und laden Sie den Export aus dem Dossier herunter.

Dieses kostenpflichtige Feature kann über den Tab **Abonnement** hinzugebucht werden.

## Urban Mining Screener

Das **Urban Mining Screener** prognostiziert die Materialmengen eines Objekts auf Grundlage statistischer Daten mittels leicht zugänglicher Dateneingaben zu
* der Objektnutzungsart,
* dem Baujahr,
* der Bruttogrundfläche in m<sup>2</sup> und 
* dem Standort (Adresse). 
Unter Verwendung von Materialdaten aus der **EPEA Generic-Datenbank** generiert der UMS zusätzlich Schätzungen zu den Umweltwirkungen, wie dem Embodied Carbon. 

Der UMS bietet eine vereinfachte Analyse, von Objekten, Portfolios oder ganzer Gemeinden. Auf diese Weise können Benutzer, die keine detaillierten Excel-Dateien oder BIM-Modelle haben, die Massen und Umweltauswirkungen ihrer bestehenden Objekt abschätzen.

1. Klicken Sie auf der Ordnerebene im Tab **Allgemeines** auf **Neues Objekt** <iconify-icon inline icon='mdi-plus-circle-outline'/> und wählen Sie im Dropdown-Menü den **Urban Mining Screener** aus.
2. Geben Sie in der sich öffnenden Maske mindestens die **erforderlichen Informationen** an, welche unter Allgemeines mit einem roten Stern markiert sind.
3. Zusätzlich können Sie in dem Tab **Energie** weitere Daten zum Verbrauch hinterlegen, um die Berechnung der Lenszyklusphase Betrieb (B6) zu ermöglichen.
4. Klicken Sie auf **Speichern**, um die automatische Analyse zu starten.
5. Sobalb diese abgeschlossen ist, finden Sie neben den Auswertungstab im Tab **Dossier**  ein PDF mit den Ergebnissen.

Der Urban Mining Screener ist vor allem als **Flächenerfassungstool** gedacht. Da Abweichungen von der Statistik in einer Mengenanalyse weniger erheblich sind als im Einzelfall. Dennoch können Sie den Urban Mining Screener in der **Version 2.0** nunmehr als Startpunkt für die Erfassung eines Objektes nutzen. Um das gescreente **in ein reguläres Objekt zu konvertieren** klicken Sie unter Allgemeines auf die Schlafläche <iconify-icon inline icon='mdi-home-switch-outline'/>. Nun können Sie die Materialschätzung als Excel exportieren und gemäß vorhandener Daten zu verfeinern.

Sofern Sie an einem automatischen Upload einer Vielzahl von Objekten interessiert sind, kontaktieren Sie bitte den Support.

Dieses kostenpflichtige Feature kann über den Tab **Abonnement** hinzugebucht werden.