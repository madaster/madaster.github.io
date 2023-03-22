---
title: Gebäude
ref: building-level
redirect_from:
  - /ch/de/building-level-product
---

## WELCHE INFORMATIONEN WERDEN HIER ANGEZEIGT?
Die Gesamtmasse und die Materialintensität (Masse/m2) werden angezeigt. Wird eine Benchmark ausgewählt und sind entsprechende Informationen verfügbar, wird das Objekt mit ausgewählten verglichen. Unbekannte Elemente werden angezeigt, damit sie angepasst und in die Berechnungen einbezogen werden können. Über die Dropdown-Liste kann die Masse als Matrix, nach Gebäudeschichten oder nach Materialfamilien angezeigt werden.

### MASSE ALS MATRIX
Die Tabelle ist horizontal in die Materialklassifizierung unterteilt (Madaster oder Madaster V2). Vertikal wird die Unterteilung in die verschiedenen Gebäudeschichten ("Layers of Brand") vorgenommen.

#### Gebäudeschichten
Die erste Spalte "Summen" zeigt die Mengen (Masse) und die Anzahl der Produkte (Stücke) je Materialfamilie/-art sowie den Prozentsatz im Verhältnis zu den anderen für dieses Gebäude verwendeten Materialien an. Zusätzlich zu diesem Prozentsatz sind auch das Gewicht und das Volumen pro Materialfamilie/-art sichtbar. 

**Gebäudeschichten (nach Stewart Brand)** 
Die anderen Spalten zeigen pro „Schicht” des Gebäudes anhand der so genannten „Gebäudeschichten” an, welches Material in der betreffenden Gebäudeschicht verwendet wurde und wie hoch der prozentuale Anteil im Verhältnis zu den anderen Materialien in dieser Gebäudeschicht ist. Zusätzlich zu diesem Prozentsatz sind auch das Gewicht und das Volumen pro Materialfamilie/-art sichtbar.

#### Materialien
Wenn Sie sich für die Anzeige der sieben Materialfamilien (Madaster) entschieden haben, ist die Materialfamilie „Unbekannt”, sofern es keine Übereinstimmung zwischen dem Element und der Material- und Produktdatenbank gibt. Diese Elemente werden in der Spalte „Unbekannt” unter den 5 Gebäudeschichte erscheinen. Wenn Sie sich für die Anzeige nach Madaster V2 entschieden haben, werden die Materialien nicht angezeigt, wenn es keine Übereinstimmung zwischen dem Element und der Datenbank der Materialien und Produkte gibt.
Weitere Informationen zu den verwendeten Materialien erhalten Sie, wenn Sie auf einen der Kreise klicken. Es öffnet sich ein Pop-up-Fenster, in welchem die verwendeten  Materialien und Produkte aufgeführt werden. Beispielsweise kann der Materialtyp „Ziegel” den Materialien „Beton” und „Ziegelstein” sowie den Produkten „verstärkte Säule”, die wiederum aus „Ziegelstein” besteht, zugeordnet werden. Sie können sehen, in welchem Volumen jedes Material vorkommt. Wenn Sie sich für die Materialklassifikation Madaster V2 entschieden haben, können Sie die verschiedenen Materialfamilien in der linken Spalte weiter öffnen, indem Sie auf eine Materialfamilie klicken. Auf diese Weise können Sie diese Materialklassifikation weiter vergrössern.

**Filter**
In dieser Übersicht kann ein Filter verwendet werden. Im Filter können Materialien eingegeben werden, und nur diese Materialien werden dann in der Tabelle angezeigt. Die gefilterten Suchergebnisse können durch Anklicken des Kreuzes zurückgesetzt werden.

**Ansehen**
Durch den Klicken auf „Ansehen“ werden die Materialfamilien vertikal und die Gebäudeschichten horizontal positioniert. Dadurch erhalten Sie die gleichen Daten in gedrehter Übersicht. Die Prozentsätze summieren sich nun in der Materialklassifikationsspalte.

**Quelldateien** 
Durch Klicken auf „Quelldateien“ erscheint ein Pop-up-Fenster, in dem die Qualität und Vollständigkeit der Informationen der aktiven Quelldateien angezeigt wird.

#### Produkte
Um einen Einblick in die präsentierten Produkte zu erhalten, ist es möglich, auf eine „Gebäudeschicht“ zu klicken, zum Beispiel „Baukonstruktionen“ oder „Technische Anlagen“. Sie gelangen dann auf eine neue Ansicht, die Ihnen Einblick in die verknüpften Produkte dieser speziellen Gebäudeschicht ermöglicht. Auf dieser Seite können Sie nach Stichwort, Klassifizierung oder Etage filtern.

Wenn ein Produkt ausgewählt ist, können Sie sich in den Registerkarten „Material“, „Produkt“, „Zirkularität“, „Finanziell“ und „IFC“ direkt darüber weitere Produktinformationen zu diesem spezifischen Produkt ansehen. Über die Registerkarte „Produkt“ können Sie diesem ein Dokument hinzufügen, wie z.B. ein Handbuch, ein Zertifikat, eine Garantieerklärung oder einen „Produktpass“.

### MASSE JE GEBÄUDESCHICHT
Auf der linken Seite zeigt ein Tortendiagramm die Masse nach Gebäudeschichten. Auf der rechten Seite zeigt ein Balkendiagramm die Zusammensetzung der Gebäudeschichten nach Materialfamilien. Benutzer können auf die Balken klicken, um zu sehen, welche Materialien und Produkte darin enthalten sind. Ausserdem können Benutzer nach Stichwort oder Etage filtern.

Benutzer können auch auf eine Gebäudeschicht im Tortendiagramm klicken. In diesem Fall werden alle Metriken speziell für die ausgewählte Gebäudeschicht angezeigt und das Balkendiagramm auf der rechten Seite entsprechend der Materialunterfamilien dieser Gebäudeschicht aktualisiert. Auch hier können die Benutzer auf einen Balken klicken, um Details zu den darin enthalten Materialien zu sehen. 

### MASSE JE MATERIALFAMILIE
Auf der linken Seite zeigt ein Tortendiagramm die anteilige Masse der Materialfamilien. Auf der rechten Seite zeigt ein Balkendiagramm die Verteilung der Materialfamilien über die Gebäudeschichten. Benutzer können auf die Balken im klicken, um zu sehen, welche Materialien darin enthalten sind. Ausserdem können Benutzer nach Stichworte oder Etage filtern.

Benutzer können auch auf eine Materialfamilie im Tortendiagramm klicken. In diesem Fall werden alle Metriken speziell für die ausgewählte Materialfamilie angezeigt und die Metriken für Materialintensität und Benchmarking werden entfernt. Ausserdem wird das Balkendiagramm auf der rechten Seite entsprechend der Verteilung der Materialunterfamilien auf die Gebäudeschichten aktualisiert. Auch hier können Benutzer auf einen Balken klicken, um Details zu den darin enthalten Materialien zu sehen.

### UNBEKANNTE ELEMENTE
Unbekannte Elemente sind solche, die bei den Berechnungen nicht berücksichtigt wurden. Dies kann aus 3 verschiedenen Gründen resultieren:

__*Unverknüpfte Elemente*__ : Diese Elemente sind nicht mit Datensätzen einer Material-/Produktdatenbank verknüpft und können daher nicht bei Berechnungen berücksichtigt werden.

__*Elemente mit unbekannter Gebäudeschicht*__: Diesen Elementen fehlen Informationen zur Klassifizierung gemäss eBKP, so dass sie keiner Gebäudeschicht zugeordnet werden können.

__*Elemente mit unzureichenden geometrischen Angaben*__: Diesen Elementen fehlen entsprechende geometrische Angaben, so dass sie nicht für Berechnungen verwendet werden können.
