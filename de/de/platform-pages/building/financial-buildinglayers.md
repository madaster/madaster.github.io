---
title: Finanzen - Gebäudeschichten
description: Finanzen - Gebäudeschichten
ref: building-financial-buildinglayers
type: FAQ
---

## BERECHNUNGSMETHODE
Die verschiedenen Schichten haben einen funktionalen Lebenszyklus, der mit dem Cashflow des Ablaufjahres endet. Dieser Wert ist von Madaster vorgegeben, kann aber in der Registerkarte "Allgemeines" manuell angepasst werden. Auf der Registerkarte "Schichten der Marke" wird der Wert der Materialien basierend auf dem Lebensphaseende-Datum bestimmt. Der Wert eines Materials zu diesem Zeitpunkt wird bis heute mit der Nettowertberechnung unter Verwendung des Diskontierungssatzes zurückgerechnet. Die Summe der Nettowerte stellt den Gebäudewert dar, ausgedrückt als Materialwert.

## TRENDLINIENBESTIMMUNG
Gemäß der Trendlinie des Materialwertes wird der erwartete Wert in verschiedenen Jahren in der Zukunft ermittelt. Der Materialwert wird vorzugsweise aus den gängigen Rohstoffpreisen importiert. Die Preismutation wird zunächst mit der Inflation im Jahr der Mutation korrigiert. Danach werden die Preise entsprechend dem Wechselkurs des jeweiligen Jahres in Euro umgerechnet. Die Punkte in der Trendlinie werden mit Hilfe einer Regressionsanalyse analysiert, nämlich: der Methode der kleinsten Quadrate.

## KORREKTURFAKTOREN
Danach werden die Materialwerte mit Rückbaukosten, Aufbereitungskosten, Transportkosten und einer Korrektur für die Größe der Materialcharge korrigiert. Die Rückbaukosten werden jährlich mit dem BDB-Index korrigiert, der die Inflation der Baukosten darstellt. Der Durchschnitt der Preisentwicklung der letzten 18 Jahre stellt den anpassbaren Standardwert dar. Die Recyclingkosten sind für jedes Material unabhängig und werden auf der Grundlage von Recherchen und Interviews berechnet. Für die Transportkosten wird ein 150 km langer Transport angenommen. Für zwei Materialgruppen liegt ein unterschiedlicher Wert für diese Kosten vor, nämlich Stein (20 km) und Holz (40 km).

## REFERENZEN
- Brand, S. (1994). How Buildings Learn
- LME (London Metal Exchange)
- FRED (Federal Reserve Economic Data)
- The World Bank
- Plasticker
- NASDAQ

## WIE WIRKT SICH DIE INFLATION, DER BDB-INDEX UND DER DISKONTSATZ AUF DIE BERECHNUNG AUS?
Der Einfluss ist in der Sensitivitätsanalyse auf den Detailseiten leicht nachprüfbar. Die Werte können angepasst werden. Als Standardwert wird die durchschnittliche Inflation und der durchschnittliche BDB-Index der letzten 18 Jahre angegeben. Der Diskontsatz setzt sich zu 0,7% aus dem Euribor, zu 2% aus dem Risiko und zu 0,3% aus der Prämie für den Finanzierer zusammen.
