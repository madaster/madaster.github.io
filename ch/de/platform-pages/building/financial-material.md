---
title: Material
description: Objekt - Finanzen Material
ref: building-financial-material
type: FAQ
---
## Welche Informationen finde ich hier und welche Anpassungen kann ich tätigen?
### Berechnungsmethode
Der Materialwert wird vorzugsweise aus Warenpreisen gängiger Warenbörsen übernommen. Die historische Preisentwicklung von Materialien wird zunächst mit der Inflationsrate des jeweiligen Jahres und dem entsprechenden Wechselkurs korrigiert, falls der Rohstoff in einer anderen Währung vorliegt. Die Datenpunkte in der Historie der Rohstoffpreise bilden mit dieser Ableitung die Grundlage für eine lineare Trendlinie, die auf Basis einer Regressionsanalyse, nämlich der Methode der kleinsten Quadrate, ermittelt wird. 

### Korrekturfaktoren
Danach werden die Materialwerte mit Rückbaukosten, Aufbereitungskosten, Transportkosten und einer Korrektur für die Größe der Materialcharge korrigiert. Die Abbruchkosten werden jährlich mit dem BDB-Index korrigiert, der die Inflation der Baukosten darstellt. Der Durchschnitt der Preisentwicklung der letzten 18 Jahre stellt den anpassbaren Standardwert dar. Die Aufbereitungskosten sind für jedes Material unabhängig und werden auf der Grundlage von Recherchen und Interviews berechnet. Für die Transportkosten wird ein 150 km langer Transport für die Logistikkosten angenommen. Für zwei Materialgruppen liegt ein unterschiedlicher Wert für diese Kosten vor, nämlich Stein (20 km) und Holz (40 km).

### Referenzen
- LME (London Metal Exchange)
- FRED (Federal Reserve Economic Data)
- The World Bank
- Plasticker
- NASDAQ

### Inflation, BDB-Index und Diskontierungszinssatz
Der Einfluss ist in der Sensitivitätsanalyse auf den Detailseiten leicht nachprüfbar. Die Werte können angepasst werden. Als Standardwert werden die durchschnittliche Inflation und der durchschnittliche BDB-Index der letzten 18 Jahre angegeben. Der Diskontsatz setzt sich zu 0,7% aus dem Euribor, zu 2% aus dem Risiko und zu 0,3% aus der Prämie für den Finanzierer zusammen.

## Nicht gefunden, was Sie suchen?
Falls Ihre Frage nicht beantwortet werden konnte, besuchen Sie unsere <a href="/ch/de/" target="_blank">Home-Seite der Madaster Docs</a>. Über die Suchleiste werden Sie zu den Antworten geleitet, die Sie suchen.
