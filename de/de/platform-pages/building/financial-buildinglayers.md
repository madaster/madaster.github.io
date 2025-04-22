---
title: Gebäudeschichten
description: Objekt - Finanzen Gebäudeschichten
ref: building-financial-buildinglayers
type: FAQ
---

## Welche Informationen finde ich hier und welche Anpassungen kann ich tätigen?
### Berechnungsmethode Diskontierter Rohstoff-Restwert
Jede Gebäudeschicht hat eine durchschnittliche funktionale Lebensdauer. Nach dieser Zeit wird das Material zurückgebaut und zu diesem Datum wird der Netto-Rohstoffrestwert über den Diskontierungssatz zurückgerechnet und ergibt den diskontierten Rohstoff-Restwert. Die Summe der Nettowerte stellt den Gebäudewert dar, ausgedrückt als Materialwert.

### Bestimmung der Trendlinie, aktueller Rohstoff-Restwert
Gemäß der Trendlinie des Materialwertes wird der erwartete Wert in verschiedenen Jahren in der Zukunft ermittelt. Der Materialwert wird vorzugsweise aus den aktuellen Rohstoffpreisen importiert, dann über die Methode der kleinsten Quadrate eine Trendlinie ermittelt. Die Preismutation wird zunächst mit der Jahres-Inflation korrigiert. Danach werden die Preise entsprechend dem Wechselkurs des jeweiligen Jahres in Euro umgerechnet.

### Korrekturfaktoren
Danach werden die Materialwerte mit Rückbaukosten, Aufbereitungskosten, Transportkosten und einer Korrektur für die Größe der Materialcharge korrigiert. Die Rückbaukosten werden jährlich mit dem BDB-Index korrigiert, der die Inflation der Baukosten darstellt. Der Durchschnitt der Preisentwicklung der letzten 18 Jahre stellt den anpassbaren Standardwert dar. Die Recyclingkosten sind für jedes Material unabhängig und werden auf der Grundlage von Recherchen und Interviews berechnet. Für die Transportkosten wird ein 150 km langer Transport angenommen. Für zwei Materialgruppen liegt ein unterschiedlicher Wert für diese Kosten vor, nämlich Stein (20 km) und Holz (40 km).

### Referenzen
- Brand, S. (1994). How Buildings Learn
- LME (London Metal Exchange)
- FRED (Federal Reserve Economic Data)
- The World Bank
- Plasticker
- NASDAQ

### Inflation, BDB-Index und Diskontierungszinssatz
Der Einfluss ist in der Sensitivitätsanalyse auf den Detailseiten leicht nachprüfbar. Die Werte können angepasst werden. Als Standardwert wird die durchschnittliche Inflation und der durchschnittliche BDB-Index der letzten 18 Jahre angegeben. Der Diskontsatz setzt sich zu 0,7% aus dem Euribor, zu 2% aus dem Risiko und zu 0,3% aus der Prämie für den Finanzierer zusammen.

## Nicht gefunden, was Sie suchen?
Weitere Infos zu der Berechnungsmethode im Finanziellen Tab gibt es <a href ="/de/de/knowledge-base/calculations#finanzielles-tool" target="_blank">hier</a>.
Falls Ihre Frage nicht beantwortet werden konnte, besuchen Sie unsere <a href="/de/de/" target="_blank">Home-Seite der Madaster Docs</a>. Über die Suchleiste werden Sie zu den Antworten geleitet, die Sie suchen.