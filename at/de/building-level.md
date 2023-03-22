---
title: Masse
ref: building-level
redirect_from:
  - /at/de/building-level-product
---

## WELCHE INFORMATIONEN WERDEN HIER ANGEZEIGT?
Die Masse des Gebäudes und die Materialintensität (Masse/m2) werden angezeigt. Wird eine Benchmark ausgewählt und sind entsprechende Informationen verfügbar, wird das Gebäude mit ausgewählten verglichen. Unbekannte Elemente werden angezeigt, damit sie angepasst und in die Berechnungen einbezogen werden können. Über die Dropdown-Liste kann die Masse als Matrix, Gebäudeschicht oder nach Materialfamilie angezeigt werden.

### MASSE ALS MATRIX
Die Tabelle ist horizontal in eine Materialklassifikation (Madaster V2) unterteilt. Vertikal wird eine Unterteilung in die verschiedenen Gebäudehüllen ("Layers of Brand") vorgenommen.

#### Gebäudeschichten
Die erste Spalte „Summen” zeigt die Mengen (Masse) und die Anzahl der Produkte (Stücke) pro Materialtyp sowie den Prozentsatz im Verhältnis zu den anderen für dieses Gebäude verwendeten Materialien. Zusätzlich zu diesem Prozentsatz sind auch das Gewicht und das Volumen pro Materialfamilie/-art sichtbar.

**Gebäudeschichten – nach Stewart Brand** 
Die anderen Spalten zeigen pro „Schicht” des Gebäudes anhand der so genannten „Gebäudeschichten” an, welches Material in der betreffenden Gebäudeschicht verwendet wurde und wie hoch der prozentuale Anteil im Verhältnis zu den anderen Materialien in dieser Gebäudehülle ist. Zusätzlich zu diesem Prozentsatz sind auch das Gewicht und das Volumen pro Materialfamilie/-art sichtbar.

#### Materialien
Wenn Sie sich für die Anzeige der sieben Materialfamilien entschieden haben, ist die Materialfamilie „Unbekannt”, wenn es keine Übereinstimmung zwischen dem Element und der Material- und Produktdatenbank gibt. Diese Elemente werden in der Spalte „Unbekannt” unter den 5 Gebäudeschichte erscheinen. Wenn Sie sich für die Anzeige nach NL-SfB Tabelle 3 entschieden haben, werden die Materialien nicht angezeigt, wenn es keine Übereinstimmung zwischen dem Element und der Datenbank der Materialien und Produkte gibt.

Weitere Informationen zu den verwendeten Materialien erhalten Sie, wenn Sie auf einen der Kreise klicken. Ein neuer Bildschirm wird sich öffnen und erklären, welche Materialien und Produkte verwendet wurden. Beispielsweise kann der Materialtyp „Ziegel” den Materialien „Beton” und „Ziegelstein” sowie den Produkten „verstärkte Säule”, die wiederum aus „Ziegelstein” besteht, zugeordnet werden. Sie können sehen, in welchem Volumen jedes Material vorkommt. Wenn Sie sich für die Materialklassifikation Madaster V2 entschieden haben, können Sie die verschiedenen Materialfamilien in der linken Spalte weiter öffnen, indem Sie auf eine Materialfamilie klicken. Auf diese Weise können Sie die Materialklassifikation weiter vergrößern.

**Filter** In dieser Übersicht kann ein Filter verwendet werden. Im Filter können Materialien eingegeben werden, und nur diese Materialien werden in der Tabelle angezeigt. Die Suchergebnisse im Filter können durch Anklicken des Kreuzes abgeschaltet werden.

**Ansehen** 
Durch Klicken auf „Ansehen“ werden die Materialfamilien horizontal und die Gebäudehüllen vertikal positioniert. Dadurch erhalten Sie die gleichen Daten in einer anderen Übersicht. Die Prozentsätze summieren sich nun in der Materialklassifikationsspalte.

**Quelldateien** 
Durch Klicken auf „Quelldateien“ erscheint ein Pop-up-Fenster, in dem die Qualität und Vollständigkeit der Informationen der aktiven Quelldateien angezeigt wird.

#### Produkte
Um einen Einblick in die präsentierten Produkte zu erhalten, ist es möglich, auf eine „Gebäudeschicht“ zu klicken, zum Beispiel „Baukonstruktion“ oder „Technische Anlagen“. Sie gelangen dann auf einen neuen Bildschirm, wo Sie einen Einblick in die angewandten Produkte dieser speziellen Gebäudehülle erhalten. Auf dieser Seite können Sie nach Stichwort, Klassifizierungsmethode oder Etage filtern.

Wenn ein Produkt ausgewählt ist, können Sie auf der rechten Seite der Registerkarten „Material“, „Produkt“, „Zirkularität“ und „IFC“ weitere Produktinformationen zu diesem spezifischen Produkt anzeigen. Auf der Registerkarte „Produkt“ können Sie dann ein Dokument zu diesem Produkt hinzufügen, wie z.B. ein Handbuch, ein Zertifikat, eine Garantieerklärung oder einen „Produktpass“.

### MASSE JE GEBÄUDESCHICHT
Auf der linken Seite zeigt ein Tortendiagramm die Masse nach Gebäudeschichten. Auf der rechten Seite zeigt ein Balkendiagramm die Zusammensetzung der Gebäudeschichten nach Materialfamilien. Benutzer können auf die Balken klicken, um zu sehen, welche Materialien und Produkte darin enthalten sind. Außerdem können Benutzer nach Material, Etage und Quelldatei filtern.

Benutzer können auch auf eine Gebäudeschicht im Tortendiagramm klicken. In diesem Fall werden alle Metriken speziell für die ausgewählte Gebäudeschicht angezeigt und das Balkendiagramm auf der rechten Seite entsprechend der Materialunterfamilien dieser Gebäudeschicht aktualisiert. Auch hier können die Benutzer auf einen Balken klicken, um Details zu den darin enthalten Materialien zu sehen. 

### MASSE JE MATERIALFAMILIE
Auf der linken Seite zeigt ein Tortendiagramm die Masse nach Gebäudeschichten. Auf der rechten Seite zeigt ein Balkendiagramm die Zusammensetzung der Gebäudeschichten nach Materialfamilien. Benutzer können auf die Balken im klicken, um zu sehen, welche Materialien darin enthalten sind. Außerdem können Benutzer nach Material, Etage und Quelldatei filtern.

Benutzer können auch auf eine Materialfamilie im Tortendiagramm klicken. In diesem Fall wird die Metrik für die Gesamtmasse aktualisiert, so dass sie spezifisch für die ausgewählte Materialfamilie ist, und die Metriken für Materialintensität und Benchmarking werden entfernt. Außerdem wird das Balkendiagramm auf der rechten Seite entsprechend der Verteilung der Materialunterfamilien auf die Gebäudeschichten aktualisiert. Auch hier können Benutzer auf einen Balken klicken, um Details zu den darin enthalten Materialien zu sehen.

### UNBEKANNTE ELEMENTE
Unbekannte Elemente sind solche, die bei den Berechnungen nicht berücksichtigt wurden. Diese können aus 3 verschiedenen Gründen auftreten:

__*Unverknüpfte Elemente*__ : Diese Elemente sind nicht mit Datensätzen einer Material-/Produktdatenbank verknüpft und können daher nicht für Berechnungen verwendet werden.

__*Elemente ohne Klassifikation*__: Diesen Elementen fehlen Informationen zur Klassifizierung gemäß ÖNORM B 1801-1:2009-06 oder ÖNORM B 1801-1:2022-03, so dass sie keiner Gebäudeschicht zugeordnet werden können.

__*Elemente mit unzureichenden geometrischen Angaben*__: Diesen Elementen fehlt es an vollständigen geometrischen Angaben, so dass sie nicht für Berechnungen verwendet werden können.
