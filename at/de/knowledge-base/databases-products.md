---
title: Produkte
description: Product upload/set up and maintenance
ref: databases-products
type: Wissensdatenbank
menubar: knowledge-base-nav
---

Product upload/set up and maintenance

## Produktinformation - Allgemein

Hier können produktspezifische Informationen eingegeben werden.
Es gibt 2 Optionen für die Berechnung von Informationen auf der Grundlage der Materialliste. Nur wenn das Kontrollkästchen aktiviert ist, wird das Tab **Materialliste* sichtbar gemacht. Das Kontrollkästchen für die Berechnung von Umweltinformationen wird nur sichtbar, wenn das Kontrollkästchen für die Berechnung der Zirkularität aktiviert ist:
![Berechnen-aus-Stückliste](../../../assets/images/knowledgebase/kalkulationvonMaterialliste.png)

### KEINE Berechnung der Zirkularität auf Grundlage der Materialliste

  * Markieren Sie **nicht** das Kästchen, wenn Madaster **keine** Zirkularitäts- und Dichtewerte aus der Materialliste berechnen soll
  * Area Composition ist sichtbar (Madaster und Madaster V2)
  * Drücken Sie <iconify-icon inline icon='mdi-plus-circle-outline' />, um die Madaster (V2) Materialfamilie hinzuzufügen. Wählen Sie aus der Auswahlliste die gewünschte Familie aus und fügen Sie den Prozentsatz hinzu (wie viel ein Produkt aus dieser Materialfamilie besteht).
  * Geben Sie die Informationen in kg/Maß ein. Das Maß hängt von der Produktart ab, die Sie zuvor ausgewählt haben:
    - Volumen (z.B. Beton = m<sup>3</sup>)
    - Fläche (z.B. Boden = m<sup>2</sup>)
    - Länge (z. B. Rohr = m)
    - Menge (z. B. Hardware = kg)
    - Sonstiges (keine zusätzlichen Angaben erforderlich)
    - Energie (keine weiteren Angaben erforderlich)
  * Das Tab "Zirkularität" muss mit den verfügbaren und benötigten Informationen ausgefüllt werden.

### Berechnen der Zirkularität & Dichte auf Grundlage der Materialliste

  * Wenn Sie möchten, dass Madaster die Zirkularitätswerte aus der <a href="" target="_blank">Materialliste</a> berechnet, dann markieren (klicken) Sie das Kästchen.
  * Auf der Tab "Zirkularität" sind nun einige Eingabefelder für Werte, die berechnet werden, deaktiviert. Die restlichen Felder können ausgefüllt werden, sofern Informationen verfügbar sind.

### Berechnen der Umweltinformationen auf Grundlage der Materialliste

  * Markieren Sie das Kästchen, wenn Sie möchten, dass Madaster die Umweltinformationen aus der <a href="" target="_blank">Materialliste</a> berechnet.
  * Um auf das Tab "Materialliste" zu gelangen, muss ein Name eingegeben und das Produkt gespeichert werden.
  * Wenn die Umweltinformationen aus der Materialliste berechnet werden, muss das Tab "Umwelt" nicht ausgefüllt werden.

### KEINE Berechnung der Umweltinformationen auf Grundlage der Materialliste

  * Markieren Sie **nicht** das Kästchen, wenn Madaster **keine** Umweltwerte aus der Materialliste berechnen soll.
  * Wenn die Umweltinformationen nicht aus der Materialliste berechnet werden, muss das Tab "Umwelt" ausgefüllt werden.

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
