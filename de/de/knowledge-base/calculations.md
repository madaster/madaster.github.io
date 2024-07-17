---
title: Kalkulationen
description: Zugrundeliegende Berechnungsmethoden der Plattform
ref: calculations
type: Wissensdatenbank
menubar: knowledge-base-nav
---

Zugrundeliegende Berechnungsmethoden der Plattform

## Madaster Zirkularitätsindikator (MZI)

### Einführung

Der Madaster Zirkularitätsindikator (MZI) bewertet die Zirkularität (0-100%) von Objekten wie Gebäuden, Brücken oder Bahnhöfen gemäß der Eigenschaften der verbauten Materialien/Produkte. Der Madaster Zirkularitätsindikator basiert auf dem von der Ellen MacArthur Foundation entwickelten Material Circularity Indicator und wurde für die Funktionalität der Madaster Plattform angepasst.

Der MZI bewertet ein Objekt sowohl hinsichtlich der Herkunft als auch des geplanten Lebensendszenarios seines Materials:
  1. **Materialherkunft**: Wie hoch ist der prozentuale Anteil an sekundären (recycelten), wiederverwendeten und weiterverwendeten Materialien/Produkte, die für den Bau eines Objekts genutzt wurden?
      > Grundprinzip: Beim Bau sollten so viele recycelte und wieder- oder weiterverwendete Materialien/Produkte wie möglich verwendet werden.
  2. **Materialverwertung**: Wie hoch ist der Prozentsatz der für den Bau eines Objekts verwendeten Materialien/Produkte, die für eine Sekundärnutzung (Recycling oder Wiederverwendung) in Frage kommen?
      > Grundprinzip: Nach dem geplanten End-of-Life des Objektes sollten so viele Materialien/Produkte wie möglich für das Recycling und die Wiederverwendung verfügbar sein.

**Korrekturfaktoren:**

  Auf der Grundlage der beiden obigen Werte wird der ZI Objekt Score (ZI) berechnet.
  Der ZI berücksichtigt jedoch nicht die Menge der fehlenden Informationen im Objekt. Daher werden zwei Korrekturfaktor auf den ZI angewandt, der eine der den Prozentsatz der Objektelemente mit unbekannter Masse negativ einkalkuliert und der zweite der den Prozentsatz an bekannter Masse mit unbekannter Zirkularität berücksichtigt und zu einem Madaster Zirkularitätsindikator (MZI) führt.

**MZI in der Praxis:**
  * In der Praxis weisen Objekt MZI-Werte zwischen 10 und 100% auf.
  * Ein Objekt, das vollständig aus neuen/nicht nachhaltig produzierten Materialien/Produkte gebaut wird, die hauptsächlich als Abfall enden, ist ein *"lineares"* Objekt mit einem niedrigen MZI-Wert von 10%.
  * Ein Objekt, das vollständig aus recycelten/wiederverwendeten/weiterverwendeten Materialien oder Produkten besteht, die auch in Zukunft recycelt/wiederverwendet werden können, ist ein *"zirkuläres"* Objekt mit einer maximalen MZI-Bewertung von 100%.

### Umfang

Die MZI-Bewertung basiert auf den folgenden Komponenten:
**Materialherkunft (Ziel: 100% nachhaltige Materialien):**
  1. Produktmasse (kg)
  2. Nachhaltig erzeugte erneuerbare Rohstoffe (% der Masse);
  3. Wieder-/weiterverwendete Komponenten, die zur Herstellung eines Produkts verwendet wurden (% der Masse);
  4. Recycelte Materialien, die für die Herstellung eines Produkts verwendet wurden (% der Masse);
  5. Effizienz des Recyclingprozesses, der zu den recycelten Materialien führt (%).

**Materialverwertung (Ziel: 100 % wiederverwendbare Materialien):**
  1. Für die Wiederverwendung geeignete Komponenten (% der Masse);
  2. Für das Recycling (inkl. "Downcycling") geeignete Materialien (% der Masse);
  3. Effizienz des End-of-Life-Recyclingprozesses (%).


### Messmethode
  Der MZI basiert auf dem "Material Circularity Indicator" der Ellen MacArthur Foundation (EMF), der als Open Source auf der Website der Ellen MacArthur Foundation zu finden ist. Diese Berechnungsmethode ermöglicht es Nutzern, Produkte und Objekt durch den Vergleich der verschiedenen Komponenten gegenüberzustellen und auf einfache Weise Ambitionen und Ziele der Kreislaufwirtschaft zuzuordnen.

  Der "Material Zirkularitätsindikator" verwendet eine zusätzliche Komponente, die auf der Nutzung des Faktors "Utility" basiert:

$$
F(X) = \frac{0,9}{X} \quad \text{wobei} \quad X = \frac{L}{L_{av}}
$$


  |||
  |-|-|
  | $L$ |Mögliche funktionelle Lebensdauer eines Produkts (Jahre)|
  | $L_{av}$	|Industriedurchschnittliche funktionelle Lebensdauer eines Produkts (Jahre)|

  > Hinweis: Da keine zufriedenstellenden Daten für $L_{av}$ verfügbar sind, wird in der aktuellen MZI Berechnung $L_{av}=L$ angenommen. Somit fließt die individuelle Lebensdauer nicht in den MZI ein. </br> In vorherigen Versionen des MZI, hat Madaster stattdessen die durchschnittliche Lebensdauer einer Gebäudeschicht genutzt, aber dieser Ansatz wurde wegen mangelhafter Genauigkeit verworfen. Die aktuelle Version des MZI nutzt $F(X)=0,9$ 


**Gewichtung nach Masse**

Der MZI-Wert eines Objekts setzt sich aus den MZI-Werten der verschiedenen Gebäude- bzw. Objektschichten zusammen (Brand, 1994), welche sich wiederum aus den MZI-Werten der Produkte in der jeweiligen Schicht zusammensetzen. Die Masse eines Produkts im Verhältnis zur Masse des gesamten Objekts ist der Faktor für den MZI eines jeden Produkts und bestimmt, wie stark es den MZI des gesamten Objekts beeinflusst.

### Berechnung des Madaster Zirkularitätsindikator (MZI)
**ZI Score für die Materialherkunft**
Um den Zirkularitätsindikator für die Konstruktionsphase zu berechnen, muss die Materialherkunft bekannt sein. Diese Information kann durch Verweis auf ein Produkt einer <a href="../knowledge-base/databases#verfügbare-datenbanken" target="_blank">Systemdatenbank</a> der Madaster Plattform oder durch Erstellung eines Produkts<a href="../knowledge-base/databases#database-at-different-levels-account--folder--building" target="_blank">Erstellung eines benutzerdefinierten Produkts</a> eingegeben werden.
* Die Formel für den Zirkularitätsindikator der Materialherkunft lautet:

$$
ZI_{Konstruktion} = F_{R} + F_{RS} + F_{U}
$$

  |||
  |-|-|
  | $ZI_{Konstruktion}$ | Zirkularitätsindikator der Materialherkunft;
  | $F_R$ | Anteil der rezyklierten Materialien (als % der Produktmasse);
  |$F_{RS}$ | Anteil der erneuerbaren, nachhaltig produzierten Materialien (als % der Produktmasse);
  | $F_U$ | Anteil der wiederverwendeten Produkte und/oder Komponenten (als % der Produktmasse);
  
$$
F_{R} = M_{R} * E_{F} / M_{B}
$$

  |||
  |-|-|
  | $M_R$ |  Masse der rezyklierten Materialien Input (kg);
  |$E_F$| Die Effizienz der rezyklierten Prozesse vor der Konstruktionsphase (%); Dies betrifft die Rezyklierung vor her Herstellung eines Produkts z.B. ist es möglich, dass es zwei verworfene Keramik-Fliesen bedarf, um eine neue, komplett aus rezykliertem Material bestehende Keramik-Fliese herzustellen (also 50% Effizienz).
  | $M_{B}$ | Masse des gesamten Produkts (kg);
    
**ZI Score für die Materialverwertung**
Um den Zirkularitätsindikator für die Materialverwertung dieses Produkts zu berechnen, muss der Benutzer in der Lage sein, einen Einblick in das zu geben, was am Ende der Lebensdauer eines Produkts geschieht. Diese Informationen können durch Verweis auf <a href="../knowledge-base/databases#existing-databases" target="_blank">eine bestehende Datenbank</a> innerhalb der Madaster-Plattform oder durch <a href="https://docs.madaster.com/nl/en/knowledge-base/databases#database-at-different-levels-account--folder--building" target="_blank">Erstellung eines benutzerdefinierten Produkts</a> eingegeben werden.

Bei der Berechnung wird zwischen Recycling, Downcycling, Wiederverwendung, Deponierung und Verbrennung (thermische Verwertung) unterschieden.

Die Effizienz des Recyclingprozesses, d.h. der durch diesen Prozess zusätzlich entstehende Abfall, wird ebenfalls berücksichtigt.
* Die Formel für den End-of-Life Phase Zirkularitätsindikator lautet:
  
$$
ZI_{End-of-Life} = C_{R} * E_{C} + C_{U}
$$

  |||
  |-|-|
  | $ZI_{End-of-Life}$ | Zirkularitätsindikator der Materialverwertung|
  |$C_{R}$| Anteil des Materials, der eventuell am Lebensende rezykliert werden kann (als % der Produktmasse)|
  |$E_{C}$ | Effizienz des Rezyklingprozess' am Lebensende des Produkts (%)|
  |$C_{U}$ | Anteil der Komponenten/ Produkte, die eventuell am Lebensende wiederverwendet werden kann (als % der Produktmasse)|

Der Anteil der wiederzuverwendenden Bauteile und/oder Produkte muss mehrere Rückbaubarkeits-Bedingungen erfüllen (Design for Disassembly). Diese Bedingungen müssen erfüllt sein, denn die Wiederverwendung von Bauteilen und/oder Produkten ist nur möglich, wenn diese erfolgreich aus einem Objekt ausgebaut werden können. Folgende Bedingungen sind auf Produktebene zu erfüllen:

  1. die Art der Verbindun ist leicht lösbar;
  2. die Verbindung ist zugänglich, ohne irreparablen Schaden anzurichten;
  3.  die Schnittpunkte sind nicht vollständig durch verschiedene Schichten integriert;
  4.  das Produkt ist nicht vollständig verschlossen, eine völlige Verhinderung von Ausbau;

**Madaster Zirkularitätsindikator (MZI)**
Der Zirkularitätsindikator (ZI) wird unter Berücksichtigung der Materialströme und des Nutzens berechnet. Zur Berechnung des ZI wird die folgende Formel verwendet:

$$
ZI = 1 - LFI * F(X)
$$

|||
|-|-|
| $ZI$ | Zirkularitätsindikator|
| $LFI$ | Linearer Fluss Index|
| $F(x)$ | Nutzungsfaktor 0,9|

>Der Lineare Fluss Index (LFI) wird verwendet, um den linearen Teil des Materialflusses zu berechnen, ausgehend von 100 % nicht nachhaltiger Materialien, die zu 100 % in einer Verbrennungsanlage oder auf einer Deponie landen. Der LFI hat einen Bereich von 0 (vollständig zirkulär) bis 1 (vollständig linear).

Die Formel für den LFI lautet wie folgt:
  
$$
LFI = \frac{V + W}{2M + \frac{(WF - WC)}{2}}
$$
    
Wobei:
    
$$
V = M * (1 - F_{R} - F_{RS} - F_{U})
$$

|||
|-|-|
| $V$ | Masse der unnachhaltigen Materialien die bei Herstellung eines Produkts eingesetzt wurden (kg)|
| $M$ | Produktmasse (kg)|
| $F_R$ | Anteil der rezyklierten Materialien (als % der Produktmasse)|
| $F_{RS}$ |Anteil der erneuerbaren, nachhaltig produzierten Materialien (als % der Produktmasse)|
| $F_U$ | Anteil der wiederverwendeten Materialien (als % der Produktmasse)|

$$
W = W_{0} + \frac{(W_{F} + W_{C})}{2}
$$

|||
|-|-|
|$W$ | Masse des Abfalls (kg)|
|$W_0$ | Masse des Abfalls (kg), der nach seiner funktionellen Lebensdauer auf der deponiert oder verbrannt wird.|
| $W_F$ | Masse des Abfalls (kg), der beim Rezyklierprozess während der Herstellung anfällt.|
| $W_C$ | Masee des Abfalls (kg), der beim Rezyklingprozess anfällt, nach der funktionellen Lebensdauer eines Produkts.|

$$
W_{0} = M * (1 - C_{R} - C_{U})
$$

|||
|-|-|
| $M$ | Produktmasse (kg)|
| $C_R$ | Anteil der Materialien, mit einer Materialverwertung als Recycling (als % der Produktmasse);|
| $C_U$ | Anteil der Materialien, mit einer Materialverwertung als Wiederverwertung (als % der Produktmasse);|

$$
W_{F} = \frac{E_{F} * F_{R}}{1-E_{F}}\quad
$$

|||
|-|-|
| $E_F$ | Effizienz des Rezyklingprozess' (%) der Material für die Herstellung von Produkten versorgt. Der Standardwert 75% kann händisch überschrieben werden, da häufig diese Information nicht vorliegt.|

$$
W_{C} = M * (1 - E_{F}) * C_{R}
$$

|||
|-|-|
|$E_C$ | Effizienz des Rezyklingprozess' (%) eines Produkts mit der Materialverwertung als Recycling. Der Standardwert 75% kann händisch überschrieben werden, da häufig diese Information nicht vorliegt.|

## Demontierbarkeit (Detachability)

Der Demontierbarkeits-Index auf Gebäudeebene wird nach der vom <a href="https://www.dgbc.nl/upload/files/Publicaties/circulariteit/DGBC%20Disassembly%20Potential%20Measurement%20Methodology%20_%202022.pdf" target="_blank">Dutch Green Building Council (DGBC)</a> beschriebenene Methode berechnet.

Auf Madaster basiert die Berechnung auf allen verknüpften Elementen, wobei die vier Demontierbarkeits-Eigenschaften für jedes Element in der Quelldatei enthalten sein kann (z.B. mit dem Madaster_CPset und den Detachability-Eigenschaften, dessen Anwendung in der BIM-Handbuch beschrieben ist oder unter <a href="https://docs.madaster.com/de/de/knowledge-base/madaster-property-set.html" target="_blank">Madaster Common Property Set</a>.) und wenn die Information nicht in der Quelldatei gefunden wird, greift Madaster auf die Demontierbarkeit zurück, die im verknüpften Produkt definiert wurde.
Wenn kein Produkt verknüpft ist oder das verknüpfte Produkt keine Angaben zur Demontierbarkeit enthält, werden die Demontierbarkeits-Eigenschaften als "Unbekannt" markiert.

Eine Bearbeitung der Demontierbarkeit ist auf der Plattform möglich, indem im Erweitert-Tab ein Element ausgewählt wird und mit dem Stift-Icon in der Menüleiste bearbeitet wird. Auch die Auswahl und Bearbeitung mehrerer Elemente gleichzeitig ist möglich.

Für die Angabe über IFC-Quelldateien müssen die englischen Begriffe genutzt werden, während die Demontierbarkeit über die Excel-Quelldatei oder über die Plattform (als Produktangabe oder Elementangabe im Erweitert-Tab), mit deutschen Begriffen angegeben wird.

Die folgenden vier Eigenschaften bestimmen den Demontierbarkeits-Index:

#### Verbindungstypen (Connection type)

||
|-|
|Trockene Verbindung (Dry connection)|
|Verbindung mit Zusatzelementen (Connection with added elements)|
|Direkte integrierte Verbindung (Direct integral connection)|
|Weiche chemische Verbindung (Soft chemical compound)|
|Harte chemische Verbindung (Hard chemical compound)|

#### Zugänglichkeit (Accessibility of the connection)

| |
|-|
| Frei zugänglich ohne zusätzliche Maßnahmen (Accessible) |
| Zugänglich mit zusätzlichen Aktionen, die keinen Schaden verursachen (PartialNoDamage) |
| Zugänglich mit zusätzlichen Maßnahmen und mit vollständig reparierbaren Schäden (PartialWithRepairableDamage) |
| Zugänglich mit zusätzlichen Maßnahmen und mit teilweisereparierbaren Schäden (ParialWithDamage) |
| Nicht zugänglich - irreparable Schäden am Produkt oder den umliegenden Produkten (NotAccessible) |

#### Überschneidungen (Intersections)

| |
|-|
| Keine Überschneidungen – modulare Zonierung von Produkten oder Elementen aus unterschiedlichen Schichten (None) |
| Gelegentliche Überschneidungen von Produkten oder Elementen aus verschiedenen Schichten (Incidental) |
| Vollständige Integration von Produkten oder Elementen aus verschiedenen Schichten (Complete) |

#### Einschluss von Produktkanten (Product edges inclusion)

| |
|-|
| Offen - kein Hindernis für die (Zwischen-)Entfernung von Produkten oder Elementen (Open) |
| Überlappung - teilweise Behinderung der (Zwischen-)Entnahme von Produkten oder Elementen (Overlapping)|
| Geschlossen - vollständige Behinderung der (Zwischen-)Entnahme von Produkten oder Elementen (Closed) |

Für Details bzgl. der Berechnungsmethodik wird auf den oben verlinkten Bericht des Dutch Green Building Councils verwiesen. 

## Umwelt

Die Umweltauswirkungen eines Gebäudes werden mittels einer Lebenszyklusanalyse nach EN 15978:2011 (Nachhaltigkeit von Bauwerken) dargestellt. Abgesehen von dem Wasserverbrauch im Betrieb, kann eine ganze Ökobilanz berechnet werden.
Die Umweltindikatoren für die Phasen A1-A3 & A4-A5 & B1-B5 & C1-C4 & D werden berechnet indem die Umwelt-Daten, die aus EPDs stammen, der verknüpften Produkte mit den Maße der Elemente verknüpft werden während die Umweltauswirkung infolge Gebäudebetrieb (Phase B6) mit energetischen EPDs und Menge an Endenergiebedarf berechnet werden.

#### A1-A3p und A1-A3s
Die A1-A3 phase wird manchmal in A1-A3p (produziert) und A1-A3s (gebunden) geteilt.

A1-A3p sind die üblichen Umweltauswirkungen während der Herstellung, während A1-A3s die Umweltauswirkungen darstellen, die im Material gebunden sind und somit der Atmosphäre während Produktion entzogen werden (z.B. für Holz).

#### B4

B4 stellt den Austausch von Elementen dar, abhängig von der funktionalen Lebensdauer der verknüpften Produkte im Vergleich zu der Lebensdauer des Gebäudes.

* Alle Länder außer NL und DE. Für jedes Produkt:

$$
LCA_{iB_4} = (Runden(\frac{L_{Gebäude}}{L_{Produkt}}) - 1) * (LCA_{i[A]}  LCA_{i[B_1-B_3]} + LCA_{i[C]})
$$

|||
|-|-|
|Runden|Auf die nächste ganze Zahl hochrunden|
|$L_{Gebäude}$|Lebensdauer eines Gebäudes|
|$L_{Produkt}$|Lebensdauer eines Produkts|
|$LCA_{i[Phase]}$|Wert des Umweltindikators i für die Phasen des Produkts|

* Für die Niederlande:

$$
LCA_{iB_4} = (\frac{L_{Gebäude}}{L_{Produkt}} - 1) * (LCA_{i[A-D]}))
$$

|||
|-|-|
|$L_{Gebäude}$|Lebensdauer eines Gebäudes|
|$L_{Produkt}$|Lebensdauer eines Produkts|
|$LCA_{i[Phase]}$|Wert des Umweltindikators i für die Phasen des Produkts|

* Für Deutschland:

$$
LCA_{iB_4} = (Runden(\frac{L_{Gebäudedurchschnitt}}{L_{Produkt}}) - 1) * (LCA_{i[A]} + LCA_{i[B_1-B_3]} + LCA_{i[C]})
$$

|||
|-|-|
|Runden|Auf die nächste ganze Zahl hochrunden|
|$L_{Gebäudedurchschnitt}$|Lebensdauer eines durchschnittlichen Gebäudes = 50a|
|$L_{Produkt}$|Lebensdauer eines Produkts|
|$LCA_{i[Phase]}$|Wert des Umweltindikators i für die Phasen des Produkts|

## Finanzielles Tool

Das Finanzelle Tool berechnet, was das im Gebäude verbaute Material wert ist. Dieser wird entweder ausgedrückt in:

* Aktueller Rohstoff-Restwert; dies ist der heutige Wert des Materials unter Berücksichtigung einer Reihe von Korrekturfaktoren.
* Diskontierter Kapitalwert. Der Kapitalwert ist der heutige Wert, der vom Ende der Lebensdauer der Gebäudeschicht für die Materialien in jeder Schicht zurückgerechnet wird, wobei eine Reihe von Korrekturfaktoren, der Abzinsungssatz und die Materialwertentwicklung berücksichtigt werden.

Der aktuelle Rohstoffrestwert für ein Bauwerk wird durch die Summe der jeweiligen Werte seiner Produkte berechnet. Wenn ein Produkt durch eine Stückliste definiert ist, werden die entsprechenden Produkte in der finanziellen Berechnung aufgeführt.
Aktueller Rohstoff-Restwert eines Produktes:


$$CNV= TV - FC_1 - FC_2 - FC_3$$

| Abkürzung | Beschreibung |
|--------------|-------------|
| $CNV$ | Aktueller Rohstoff-Restwert bzw. Verfügbare Rohstoff-Restwert (Current Value aka. Corrected nominal value) |
| $TV$ | Trendwert (Trend Value) |
| $FC_1$ | Korrekturfactor 1: Rückbaukosten, können im Allgemein Tab des Gebäudes > Objekt bearbeiten, gefunden werden |
| $FC_2$ | Korrekturfactor 2: Transportkosten, können im finanziellen Tab des Produkts gefunden werden |
| $FC_3$ | Correction Factor 3: Aufarbeitungskosten, können im finanziellen Tab des Produkts gefunden werden |

#### Trendwert

Der Trendwert (TV) ist in der Zeitleiste für den aktuellen Monat zu finden.
Es ist eine lineare Grafik, die durch eine Regressionsanalyse (Methode der kleinsten Quadrate) aus der Historischen Preisentwicklung (HPD) berechnet wird.
 **HPD** Die Historische Preisentwicklung (HPD) ist die Entwicklung des Letzten bekannten Wertes (PV)

$$PV=M*LKV$$

| Abkürzung | Beschreibung |
|--------------|-------------|
| $PV$ |  Aktueller Rohstoffwert des Preissatzes (The Priceset Value) [€] |
| $LKV$ | Letzter Bekannter Wert (Last Known Value) [€/kg] |
| $M$ | Masse des Produkts [kg] |

$$LKV=NV*IR*CT$$

| Abkürzung    | Beschreibung |
|--------------|--------------|
| $LKV$ | Letzte bekannte Wert (Gebäude-Ebene) bzw. Aktueller Rohstoffwert (Produkt-Ebene) [€/kg]. Dieser Wert kann nur berechnet werden, sobald die monatliche Inflationsrate veröffentlicht wurde, ansonsten wird auf den Wert des Vormonats zurückgegriffen. |
| $NV$ | Nennwert des Produkts [EinheitWährung/EinheitMenge], stammt aus dem angegebenen Datensatz für jedes Produkt. Es gibt drei Methoden, um den Nennwert zu berechnen: <br> - Ein Basispries an einem bestimmten Datum, kombiniert mit der Preisentwicklung der Ware <br> - Tägliche Werte einer Ware aus einer Rohstoffbörse <br> - Eine Kombination mehrerer Produkt-Nennwerte (meistens wenn es sich um ein Komposit handelt) |
| $IR$ | Inflationsrate [%] |
| $CT$ | Währungsumrechnung [%] |

#### Korrekturfactor 1: Rückbaukosten

$$
FC_{1,p} = DC_{Gebäude} * \frac{M_p}{M_{Gebäude}}
$$

| Abkürzung    | Beschreibung |
|--------------|--------------|
| $FC_{1,p}$ | Die Rückbaukosten eines Produkts [€] |
| $DC_{Gebäude}$ | Die Rückbaukosten eines Gebäudes [€] |
| $M_{p}$ | Masse eines Produkts [kg] |
| $M_{Gebäude}$ | Masse eines Gebäudes, kann im Masse-Tab gesehen werden [kg] |


$$DC_{Gebäude}=GSA*DC_{Gebäudenutzung}$$

| Abkürzung    | Beschreibung |
|--------------|--------------|
| $DC_{Gebäude}$ | Rückbaukosten eines Gebäudes [€] |
| $GSA$ | Bruttogrundfläche, kann im Allgemein-Tab gesehen werden [m<sup>2</sup>] |
| $DC_{Gebäudenutzung}$ | Rückbaukosten je nach Gebäudenutzung [€/m<sup>2</sup>], kann im Allgemein-Tab > Objekt bearbeiten > Madaster Information gefunden werden |

$$FC1=\sum_{p} FC_{1-p}$$

#### Korrekturfactor 2: Transportkosten

$$FC_{2,p} = TC*(1+IR)$$

| Abkürzung    | Beschreibung |
|--------------|--------------|
| $FC_{2,p}$ | Transportkosten des Produktes [€/kg] |
| TC | Transportkosten [€/kg], (ursprünglich berechnet durch Entfernung zur Verarbeitung * Durchschnittliche Kosten [€/km*kg]) können im Finanziellen Tool des Produkts eingesehen werden.|
| IR | Inflationsrate [%] |

$$FC_2=\sum_{p} FC_{2-p}*M_p$$

| Abkürzung    | Beschreibung |
|--------------|--------------|
| $M_p$ | Mass of product in the building |


$$FC_{3,p}=H_p(1+IR)$$

| Abkürzung    | Beschreibung |
|--------------|--------------|
| $FC_{3,p}$ | Handling costs [€] for processing and machining a product |
| $H_p$ | Handling costs per kg, are defined on the financial tab of products, and defaulted on priceset |

$$FC_3=\sum_{p} FC_{3-p}*M_p$$

| Abkürzung    | Beschreibung |
|--------------|--------------|
| $M_p$ | Masse des Produkts im Gebäude |


## Benchmarking

### Objektebene:

Das Objekt und seine Gebäudeschichten können mit allen Objekten im Konto oder Ordner verglichen und nach bestimmten Objekttypen gefiltert werden. Der Benchmark wird mit allen Objekten innerhalb der Benchmark-Einstellungen verglichen, auch mit Objekten, für die ein Benutzer keine Leserechte hat. Die Benchmarks werden im Folgenden beschrieben:

#### Materialdichte (Masse/m<sup>2</sup>);
Der Objektbenchmark wird als gewichteter Durchschnitt der Materialdichte der Objekt in der Auswahl ermittelt:

$$B=\frac{\sum_{b}M_b}{\sum_{b}GSA_b}$$

| Abkürzung    | Beschreibung |
|--------------|--------------|
|$B$|Benchmark Wert|
| $M_b$ | Masse des Gebäudes |
| $GSA_b$ | Bruttogrundfläche des Gebäudes b |
|$\sum_{b}$|Summe für alle Gebäude in Auswahl|

#### Kreislaufwirtschaft;
Der Objekt-Benchmark wird durch Berechnung eines gewichteten Durchschnitts der Zirkularitätsindikatoren ermittelt:

$$B_t=\frac{\sum_{b}M_b*MZI_b}{\sum_{b}M_b}$$

| Abkürzung    | Beschreibung |
|--------------|--------------|
|$B_t$|Benchmark Wert|
| $M_b$ | Masse des Gebäudes |
|$MZI_b$| Madaster Zirkularitätsindikator des Gebäudes |
|$\sum_{b}$|Summe für alle Gebäude in Auswahl|

$$B_l=\frac{\sum_{b}M_{bl}*MZI_{bl}}{\sum_{b}M_{bl}}$$

| Abkürzung    | Beschreibung |
|--------------|--------------|
|$B_t$|Benchmark Wert pro Gebäudeschicht|
| $M_{bl}$ | Masse der Gebäudeschicht |
|$MZI_b$| Madaster Zirkularitätsindikator der Gebäudeschicht |
|$\sum_{b}$|Summe für alle Gebäude in Auswahl|

#### Demontierbakeit:
Der Objekt-Benchmark wird durch die Berechnung eines gewichteten Durchschnitts des Demontierbarkeitsindexes ermittelt:

$$B_t=\frac{\sum_{b}M_b*DI_b}{\sum_{b}M_b}$$

| Abkürzung    | Beschreibung |
|--------------|--------------|
|$B_t$|Benchmark Wert|
|$M_b$| Masse des Gebäudes |
|$DI_b$| Demontierbarkeits-Index des Gebäudes |
|$\sum_{b}$|Summe für alle Gebäude in Auswahl|

$$B_l=\frac{\sum_{b}M_{bl}*DI_{bl}}{\sum_{b}M_{bl}}$$

| Abkürzung    | Beschreibung |
|--------------|--------------|
|$B_t$|Benchmark Value Per Layer|
| $M_{bl}$ | Masse der Gebäudeschicht |
|$DI_{bl}$| Demontierbarkeits-Index der Gebäudeschicht |
|$\sum_{b}$|Summe für alle Gebäude in Auswahl|


#### Umwelt-KPIs:  
Der Objekt-Benchmark wird als gewichteter Durchschnitt der Umwelt-KPIs ermittelt:

$$B_{ip-t}=\frac{\sum_{b}LCA_{ip-b}}{\sum_{b}GSA_b}$$

| Abkürzung    | Beschreibung |
|--------------|--------------|
|$B_{ip-t}$|Benchmark für Indikator i in Phasen p insgesamt|
| $LCA_{ip-b}$ | LCA-Wert für Indikator i in Phasen p des Gebäudes|
|$\sum_{b}$|Summe für alle Gebäude in Auswahl|


### Materialwert/m<sup>2</sup>;
Der Materialwert-Benchmark wird als gewichteter Durchschnitt der Materialwerte der Objekt in der Auswahl ermittelt:

$$B=\frac{\sum_{b}CV_b}{\sum_{b}GSA_b}$$

| Abkürzung    | Beschreibung |
|--------------|--------------|
|$B$|Benchmark Wert|
| $CV_b$ | Aktueller Rohstoff-Restwert des Gebäudes |
| $GSA_b$ | Bruttogrundfläche des Gebäudes b |
|$\sum_{b}$|Summe für alle Gebäude in Auswahl|
