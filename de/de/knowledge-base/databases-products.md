---
title: Produkte
description: Produkte anlegen und pflegen
ref: databases-products
type: Wissensdatenbank
menubar: knowledge-base-nav
---

Produkte anlegen und pflegen

## Unterschied Produkte und Bauteile

**Bauteile** referenzieren immer auf andere Bauteile oder Produkte, um Massen sowie zirkuläre, ökologische und finanzielle Kennwerte zu berechnen.  
In der Auswertung wird dabei stets der Name der referenzierten Bauteile bzw. Produkte aufgeführt.

Besteht beispielsweise ein *Bauteil A* aus einem *Produkt 1* und einem *Produkt 2* aus der *Datenbank P* und wird dieses Bauteil mit einem Element verknüpft, so erscheinen in der Auswertung *Produkt 1* und *Produkt 2* sowie die *Datenbank P* in der Materialliste.

**Produkte** können ebenfalls auf andere Produkte oder Bauteile referenzieren. In der Auswertung wird jedoch immer der Name des erstellten Produkts angezeigt – nicht der Name der referenzierten Produkte oder Bauteile.

## Produkte/ Bauteile anlegen

Um ein neues Produkt bzw. Bauteil anzulegen, müssen folgende Pflichtfelder ausgefüllt werden:

- **Produktname**  
  *Wie heißt dieses Produkt?*  
  (z. B. „Stahlbeton-Wand“)

- **Produkttyp**  
  *Mit welcher geometrischen Angabe definiere ich die Menge dieses Produkts?*  
  (z. B. „Ich definiere die Stahlbeton-Wand pro Volumen.“)

- **Funktionelle Einheit**  
  *Bezogen auf welche Menge und Einheit definiere ich dieses Produkt?*  
  (z. B. „Ich definiere die Stahlbeton-Wand pro 1 m³.“)

- **Funktionale Lebensdauer (Jahre)**  
  *Wie lange erfüllt dieses Produkt seinen Nutzen?*  
  (z. B. „Die Stahlbeton-Wand erfüllt 50 Jahre lang ihren Nutzen.“)

Anschließend muss entschieden werden, ob alle Informationen zu diesem Produkt manuell eingetragen werden oder ob diese über eine Referenz zu anderen Produkten mithilfe einer Materialliste abgeleitet werden.

Soll eine Materialliste angelegt werden, stehen zwei Optionen zur Verfügung:

* Berechnung der Zirkularität und Dichte auf Grundlage der Materialliste  
* Berechnung der Umweltinformationen auf Grundlage der Materialliste

![Berechnen-aus-Stückliste](../../../assets/images/knowledgebase/calculatefrombom.png)

### Berechnen der Zirkularität und Dichte auf Grundlage der Materialliste

* Wenn die Zirkularitätswerte aus der Materialliste berechnet werden sollen, muss das Kästchen **„Berechnung der Zirkularität und Dichte auf Grundlage der Materialliste“** aktiviert und die Angaben gespeichert werden.
* Die Registerkarte **„Zirkularität“** wird anschließend mit Daten aus der Materialliste befüllt. Felder zur Wiederverwendung können ergänzend ausgefüllt werden.

### Berechnen der Umweltinformationen auf Grundlage der Materialliste

* Wenn die Umweltinformationen aus der Materialliste berechnet werden sollen, muss das Kästchen **„Berechnung der Umweltinformationen auf Grundlage der Materialliste“** aktiviert und die Angaben gespeichert werden.
* Die Registerkarte **„Umwelt“** wird anschließend mit Daten aus der Materialliste befüllt.

### Befüllen der Materialliste


* In der Registerkarte **„Materialliste“** können nun Schichten oder Bestandteile dieses Produkts bzw. Bauteils definiert werden.
* Über den Button **„Hinzufügen“** lassen sich Produkte aus allen verfügbaren Datenbanken auswählen. Mithilfe des Filters **„Quelle“** kann die Auswahl auf bestimmte Datenbanken eingeschränkt werden. Das gewünschte Produkt kann anschließend ausgewählt und über **„Element hinzufügen“** eingefügt werden.
* Danach wird die Menge dieses Elements pro funktioneller Einheit des gesamten Produkts bzw. Bauteils definiert (siehe *Produktinformation – Allgemein* → **„Funktionelle Einheit“**).
* Über den Toggle **„Gewicht eingeben“** kann ein Element entweder pro Kilogramm oder auf Basis seiner eigenen funktionellen Einheit angegeben werden.

> **Beispiel:**  
> Ich habe ein PVC-Fenster, für das alle mir bekannten Angaben pro 1 m² vorliegen.  
> Ich möchte alle Informationen zu den Bestandteilen des Fensters berechnen lassen.  
> Das Fenster besteht aus 0,74 m² Flachglas und 4 m (bzw. 5 kg) PVC-Profil.  
> Daher definiere ich die funktionelle Einheit als **1 m²** und füge der Materialliste 0,74 m² Flachglas und 5 kg PVC-Profil hinzu.


### Keine Berechnung von Zirkularität oder Umweltinformationen aus der Materialliste

* Aktivieren Sie das Kästchen **nicht**, wenn Madaster **keine** Zirkularitäts-, Dichte- oder Umweltinformationen aus der Materialliste berechnen soll.
* Die Materialzusammensetzung kann manuell definiert werden (nach NL-SfB, BBSR und European Waste Codes). Über den Button <iconify-icon inline icon='mdi-plus-circle-outline' /> wird eine Materialfamilie hinzugefügt. Wählen Sie die gewünschte Familie aus der Auswahlliste aus und geben Sie den prozentualen Anteil an.
* Geben Sie die Informationen in kg/Maß an. Das Maß hängt von der zuvor ausgewählten Produktart ab:
  * Volumen (z. B. Beton = m³)
  * Fläche (z. B. Boden = m²)
  * Länge (z. B. Rohr = m)
  * Menge (z. B. Tür = Stück)
  * Sonstiges (keine zusätzlichen Angaben erforderlich)
  * Energie (keine zusätzlichen Angaben erforderlich)
* Die Registerkarten **„Zirkularität“** bzw. **„Umwelt“** müssen anschließend mit den verfügbaren und erforderlichen Informationen ausgefüllt werden.

### Anlegen von Bauteilen für Zertifizierungen

Wenn eine Berechnungsmethode die Verwendung von Produkten aus einer bestimmten Datenbank vorschreibt (z. B. ÖKOBAUDAT für DGNB oder die QNG-Rechenwerttabelle für QNG) und ein Bauteil aus Produkten dieser Datenbank zusammengestellt wird, erscheint in der Auswertung die entsprechende Produktdatenbank in der Materialliste. Damit ist die Konformität mit der jeweiligen Methode gegeben.

## Skalierbarkeit

Was bedeutet Produktskalierung?

Alle Bauprodukte werden in verschiedenen Größen (Höhen, Breiten, Dicken etc.) hergestellt. Folglich haben die unterschiedlichen Größen Auswirkungen auf den endgültigen Wert, der die Berechnung des Treibhauspotenzials oder anderen KPIs dient. Um die verschiedenen Größen zu berücksichtigen, beziehen sich die EPDs auf eine *funktionale Einheit*. Das bedeutet, dass bei der Erstellung einer EPD die Daten für eine Einheit der definierten funktionellen Einheit angegeben werden. Zum Beispiel würde sich das angegebene Treibhauspotential einer EPD für Bodenbeläge auf 1m<sup>2</sup> Bodenfläche beziehen.

Die funktionellen Einheiten, die in Madaster definiert sind, sind:

*Volumen*: Eine der gebräuchlichsten funktionalen Einheiten auf der Plattform. Das Volumen unter Berücksichtigung der spezifischen Dichte wird für alles verwendet, was eine große Vielfalt an Formen, Dicken und Breiten aufweisen kann, wie z.B. Beton.

*Fläche*: Eine weitere gängige funktionale Einheit auf Madaster. Die Fläche wird für alle Arten von Anwendungen verwendet, bei denen sowohl die Höhe als auch die Breite variabel sind. Beispiele sind Bodenbeläge, Isolierungen oder Verkleidungen. 

*Länge:* Bei Produkten, die über die Länge definiert werden, handelt es sich z.B. um Aluminiumprofile, die in einer bestimmten Form extrudiert werden. Hierbei bleibt der Querschnitt gleich. Die Variable ist die Länge in der das Profil extrudiert wird.

*Menge*: Diese wird für Gegenstände verwendet, deren Abmessungen nicht variieren und die eine einzigartige Einheit darstellen, wie z.B. Möbel oder Türen.

*Tiefe*: Dies ist keine häufig verwendete funktionale Einheit auf der Plattform. Die Tiefe könnte für Elemente verwendet werden, die ebenfalls einen festen Querschnitt haben. Ein Beispiel wäre eine Pfahlgründung, bei der der Querschnitt gleichbleibt. Allerdings verändert sich die Tiefe, in der der Pfahl im Boden verankert wird. 

*Breite*: Auch dies ist keine übliche funktionale Einheit, die auf der Plattform verwendet wird. Die Breite kann für sehr spezielle Bauanwendungen verwendet werden. Ein Bespiel wären maßgeschneiderte Regale, die ein festes Frontprofil haben, sich aber an die Breite eines Raumes anpassen.

*Höhe*: Ebenfalls keine häufig verwendete funktionale Einheit auf der Plattform. Höhe könnte für Gegenstände wie Stehlampen verwendet werden, bei denen alle Merkmale außer der Höhe gleichbleiben. 

*Durchmesser*: Radius und Durchmesser werden für Gegenstände verwendet, die eine feste Dicke haben, aber im Durchmesser zunehmen können. Beispiele sind Schachtabdeckungen oder Verkehrspoller, die eine einheitliche Höhe haben, deren Querschnitt sich aber ändern kann. 

*Radius*: Für den Radius gilt das Gleiche, wie für den Durchmesser.

Sobald eine EPD mit der Fläche als funktioneller Einheit erstellt wird, bedeutet dies, dass die EPD unter der Annahme berechnet wird, dass alle anderen Variablen bei einer Vergrößerung der Fläche konstant bleiben. Dies entspricht jedoch nicht immer der Praxis, wenn die Fläche auf bestimmte Größen angepasst wird. Bei einigen Profilen und Rohren muss z.B. die Dicke zunehmen, um die strukturelle Integrität bei einer Vergrößerung der Länge zu erhalten. In einigen Fällen wirkt sich ein nichtlinearer Anstieg des einen Faktors auf den anderen aus, was sich natürlich auf die endgültigen Auswertungen der KPIs auswirkt. Aus diesem Grund gibt es die Möglichkeiten Produkte auf der Plattform zu skalieren.

Die Skalierung auf Madaster folgt den Skalierungsregeln der **National Mileu Database (NMD)** und wird im folgenden Abschnitt erläutert.

### Wie funktioniert die Skalierung von Produkten auf Madaster?

Wie bereits erwähnt, folgt die Skalierung auf Madaster dem Skalierungsrahmen von der Nationalen Mileu-Datenbank (NMD), welche von der Niederlande bereitgestellt wird. 

Die grundlegende Berechnung der Skalierung ist:

$W_{skaliertes\;Profil,\;x}= f(x) \times W_{Referenz}$ 

Wobei:

$W_{skaliertes\;Profil,\;x}$ = Das Gewicht des skalierten Profils, wie es im Projekt vorhanden ist 

$f(x)$ = die Skalierungsfunktion, die auf die Einheit angewendet wird 
*Im Folgenden werden die verschiedenen Skalierungsfunktionen erläutert.*

$W_{Referenz}$ = Das Gewicht des verwendeten Referenzproduktes 

Die verschiedenen Funktionen, die zur Skalierung eines Produktes angewendet werden können, lauten wie folgt: 

**Linear** : $f(x) = \frac{ax+c}{ax_0 + c}$

**Potenz**: $f(x) = \frac{ax^n+c}{ax_0^n + c}$

**Logarithmisch**: $f(x) = \frac{a \cdot ln(x)+c}{a \cdot ln(x_0) + c}$

**Exponential**: $f(x) = \frac{a \cdot exp(x)+c}{a \cdot exp(x_0) + c}$

### Anwendung einer Produktskalierung auf Madaster

Wenn Sie ein Produkt aus einer Produktdatenbank auswählen, können Sie das Produkt bearbeiten, indem Sie auf das **Stiftsymbol** <iconify-icon inline icon='mdi-pencil-outline'/> klicken. Im Folgenden kann die Materialskalierung auf ein Produkt angewendet werden, indem das Kästchen <iconify-icon inline icon='mdi-checkbox-marked'/> **Skalierbar** markiert wird. 

Skalierbare Produkte können auf neue oder bestehende Produkte angewendet werden. Auf der rechten Seite des Produktinformationsformulars gibt es nun die Möglichkeit, Informationen für die Skalierung einzugeben.

Die Optionen umfassen:

*Skalieren auf feste Dimension*: Das bedeutet, dass $W_{skaliertes\;Profil,\;x}$ auf der Basis einer festen Größe berechnet wird.

*Skalierung nach funktioneller Einheit*: Das bedeutet, dass das endgültige $W_{scaled\;profile,\;x}$ auf der Grundlage der für das Produkt definierten funktionalen Einheit berechnet wird. 

*Skalieren nach einer anderen Eigenschaft*: Das bedeutet, dass $W_{scaled\;profile,\;x}$ auf der Grundlage einer benutzerdefinierten Eigenschaft berechnet wird.

Als Nächstes folgt die Wahl der Skalierungsformel. Hierbei stehen, wie oben beschrieben, die Optionen Linear, Potenz, Exponentiell und logarithmisch zur Auswahl.

Für die lineare Skalierung gilt: $f(x) = \frac{ax+c}{ax_0 + c}$, wobei der Faktor $a$ und die Konstante $c$ definiert werden müssen. 

Für die Potenzskalierung: $f(x) = \frac{ax^n+c}{ax_0^n + c}$, wobei der Faktor $a$, die Konstante $c$ und der Potenzfaktor / Index $n$ definiert werden müssen. 

Für die logarithmische Skalierung: $f(x) = \frac{a \cdot ln(x)+c}{a \cdot ln(x_0) + c}$, wobei der Faktor $a$ und die Konstante $c$ definiert werden müssen. 

Für die Exponentialskalierung: $f(x) = \frac{a \cdot exp(x)+c}{a \cdot exp(x_0) + c}$ Faktor $a$, und Konstante $c$ müssen definiert werden. 

Abschließend können die funktionelle Einheit und die angenommene Größe der funktionellen Einheit definiert werden. 