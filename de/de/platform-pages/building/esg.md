---
title: ESG
ref: building-esg
redirect_from:
  - platform-pages/account/esg
  - platform-pages/folder/esg
---

## WELCHE INFORMATIONEN WERDEN HIER ANGEZEIGT?
In dieser Registerkarte können Sie Informationen zu verschiedenen Features einsehen, die im Bereich ESG, Zertifizierung und Reporting zu verorten sind.

### CRREM - CARBON RISK REAL ESTATE MONITOR
Auf der Plattform wurde das externe entwickelte CRREM-Tool integriert. Dieses Tool wurde entwickelt, um die Kohlenstoffemissionen eines Gebäudes während seines Betriebs zu berechnen.

Auf Objektebene kann im Tab **ESG** im Dropdown diese Berichtsmethode ausgewählt werden. Über die Schaltfläche **Einstellungen anzeigen** muss der Nutzer die Daten für die Objekteigenschaften, den Energiebezug, die flüchtigen Emissionen und die erneuerbaren Energien eingeben. Diese Daten werden mit einem globalen Erwärmungsziel bzw. einem Standard

* Emissionsfaktor für Elektrizität
* Fernwärme-Emissionsfaktor
* Fernkälte-Emissionsfaktor
* Elektrizitätspreis
* Gaspreis
* Fernwärmepreis
* Preis für Fernkälte
* Preis der ausgewählten "anderen Energiequelle" #1
* Preis der ausgewählten "andere Energiequelle" #2
* Kohlenstoffpreis in Abhängigkeit vom Standort des Gebäudes.

Wenn detailliertere Informationen zu diesen Zahlen vorhanden sind, kann der Benutzer diese im Tab **"User-defined settings"** überschreiben. Bitte beachten Sie, dass für jedes Objekt die allgemeine Information **"Gross internal area"** ausgefüllt werden muss, und das **"Datum Fertigstellung"** in der Vergangenheit liegen muss.

Nachdem Sie die Daten Ihres Gebäudebetriebs eingegeben haben, berechnet die Plattform die jährlichen CO2-Emissionen sowie die Energiekosten und den jährlichen Energieverbrauch. Um Kohlenstoffneutralität bis 2050 zu erreichen, berechnet das CRREM-Tool einen Dekarbonisierungspfad für das Objekt. Alle nachfolgenden Emissionen, die über das Dekarbonisierungsziel hinausgehen (so genannte "Excess-Emissionen"), stellen ein Kohlenstoff-Risiko dar. Die wirtschaftliche Obsoleszenz ist mit dem Stranding-Moment verbunden; je höher die überschüssigen Emissionen sind, desto größer ist die Wahrscheinlichkeit der wirtschaftlichen Obsoleszenz.

Weitere Informationen zum CRREM-Tool finden Sie unter <a href="https://www.crrem.eu/" target="_blank">www.crrem.eu</a> bzw. im <a href="https://www.crrem.eu/wp-content/uploads/2023/09/CRREM-Risk-Assessment-Reference-Guide-V2_11_09_2023-final.pdf" target="_blank">User manual for the CRREM Risk Assessment Tool V2</a>.

Dieses Feature ist kostenpflichtig. 

### Level(s)
Level(s) ist ein europäischer Rahmen für die Berichterstattung über Umweltindikatoren für Gebäude. Auf madaster können für Gebäude Ergebnisse zum Makroziel 1 "Treibhausgas- und Luftschadstoffemissionen im Lebenszyklus eines Gebäudes" für den Indikator 1.2 (Treibhauspotenzial) generiert werden, einschließlich des Exports der Ergebnisse in eine Excel-Datei. Weitere Details zur Einbindung folgen.

Informationen zu Level(s) finden Sie bei der <a href="https://environment.ec.europa.eu/topics/circular-economy/levels_en" target="_blank">European Commission</a>.

Die Level(s)-Berichterstattung kann auf Anfrage aktiviert werden.

### DGNB
Der Kriterienkatalog „Gebäude Neubau“ mit der Version 2023 umfasst eine Vielzahl von Parametern und Indikatoren, die für eine Zertifizierung erfasst und berichtet werden müssen. Bereits erfasste Daten mit madaster können ausgelesen und weitergegeben werden und somit in Teilbereichen für die DGNB-Zertifizierung oder im Berichterstattungsprozess genutzt werden. 

Die DGNB unterscheidet in Ihrem System in folgende Nutzungsprofile:
- Bildungsbauten
- Büro- und Verwaltungsgebäude
- Geschäftshäuser
- Gesundheitsbauten
- Hotels
- Logistikgebäude
- Produktionsstätten
- Shoppingcenter
- Verbrauchermärkte
- Versammlungsstätten
- Wohngebäude 

Derzeit kann madaster Sie in dem Zertifizierungsprozess in den folgenden Teilbereichen unterstützen:

#### ENV 1.1 – Klimaschutz und Energie
In dieser Kategorie können verschiedene Key Performance Indicator (KPI) wie die Treibhausgasemissionen und Primärenergiebedarfe des baulichen Teils und im Betrieb und Nutzung dargestellt und ausgegeben werden (KPI 1-4). Darüber hinaus ist die Bauwerksmasse gemäß LCA auswertbar (KPI 9 auf S. 43 f. des Kriterienkatalogs).
Diese sind auf die Bilanzierungsregeln der DGNB abgestimmt und können somit zu einer Vergleichbarkeit der Lebenszyklus-CO2-Bilanz zwischen verschiedenen Projekten und zur Einordnung gemäß vorgegebener Benchmarks genutzt werden (Grenz-, Referenz-, Ziel-, oberer Zielwert).

Die vorhandenen ausgelesenen Daten können dann über den Button „Gebäuderessourcenpass generieren“ exportiert werden. In diesem Anwendungsfall werden die Tabellenfelder, für die Informationen durch die Nutzung von madaster vorliegen, automatisch eingetragen. Fehlen Informationen oder sind diese nicht mit madaster abbildbar, wird keine Eingabe getätigt und die Informationen müssen anderweitig nachgetragen werden.

Weitere Kriteriengruppen des Kriterienkatalogs befinden sich in der Entwicklung (Teilbereiche der Kriteriengruppen ECO 2.7 und TEC 1.6).

Die DGNB-Berichterstattung kann auf Anfrage aktiviert werden.
