---
title: Gebäudeschichten
description: Objekt - Finanzen Gebäudeschichten
ref: building-financial-buildinglayers
type: FAQ
---

## Welche Informationen finde ich hier und welche Anpassungen kann ich tätigen?
### Berechnungsmethode
Die verschiedenen Schichten haben einen funktionalen Lebenszyklus, der mit dem Cashflow des Ablaufjahres endet. Dieser Wert ist von Madaster vorgegeben, kann aber in der Registerkarte "Allgemeines" manuell angepasst werden. Auf der Registerkarte "Schichten der Marke" wird der Wert der Materialien basierend auf dem Lebensphaseende-Datum bestimmt. Der Wert eines Materials zu diesem Zeitpunkt wird bis heute mit der Nettowertberechnung unter Verwendung des Diskontierungssatzes zurückgerechnet. Die Summe der Nettowerte stellt den Gebäudewert dar, ausgedrückt als Materialwert.

### Bestimmung der Trendlinie
Gemäß der Trendlinie des Materialwertes wird der erwartete Wert in verschiedenen Jahren in der Zukunft ermittelt. Der Materialwert wird vorzugsweise aus den gängigen Rohstoffpreisen importiert. Die Preismutation wird zunächst mit der Inflation im Jahr der Mutation korrigiert. Danach werden die Preise entsprechend dem Wechselkurs des jeweiligen Jahres in Euro umgerechnet. Die Punkte in der Trendlinie werden mit Hilfe einer Regressionsanalyse analysiert, nämlich: der Methode der kleinsten Quadrate.

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
Falls Ihre Frage nicht beantwortet werden konnte, besuchen Sie unsere <a href="/ch/de/" target="_blank">Home-Seite der Madaster Docs</a>. Über die Suchleiste werden Sie zu den Antworten geleitet, die Sie suchen.
