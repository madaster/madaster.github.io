---
title: Finanzen - Material
layout: page
show_sidebar: false
menubar: faq-nav
ref: financial-material
permalink: /building-financial-material-de
lang: de
---

## BERECHNUNGSMETHODE
Der Wert der Materialien wird vorzugsweise aus den gängigen Rohstoffpreisen importiert. Die historische Preisentwicklung von Materialien wird zunächst mit der Inflation des Jahres korrigiert, in dem die Preisentwicklung mit der Inflationsrate des Landes der Währung des Rohstoffpreiswertes stattgefunden hat. Außerdem wird in der Vergangenheit auch die Wechselrate pro Jahr berücksichtigt. Die so erzeugten historischen Daten sind Realwertdaten. Mit diesen historischen Echtzeitdaten wird mittels einer Regressionsanalyse nach der Methode der kleinsten Quadrate eine lineare Trendlinie erzeugt.

## KORREKTURFAKTOREN
Danach werden die Materialwerte mit Abbruchkosten, Recyclingkosten, Logistikkosten und einer Korrektur für die Größe der Materialcharge korrigiert. Die Abbruchkosten werden jährlich mit dem BDB-Index korrigiert, der die Inflation der Baukosten darstellt. Der Durchschnitt der Preisentwicklung der letzten 18 Jahre stellt den anpassbaren Standardwert dar. Die Recyclingkosten sind für jedes Material unabhängig und werden auf der Grundlage von Recherchen und Interviews berechnet. Für die Transportkosten wird ein 150 km langer Transport für die Logistikkosten angenommen. Für zwei Materialgruppen liegt ein unterschiedlicher Wert für diese Kosten vor, nämlich Stein (20 km) und Holz (40 km).

## Referenzen
* LME (London Metal Exchange)
* Quandl
* www.vraagenaanbod.nl
* RVO
* BLS Beta Labs

## WIE WIRKT SICH DIE INFLATION, DER BDB-INDEX UND DER DISKONTSATZ AUF DIE BERECHNUNG AUS?
Der Einfluss ist in der Sensitivitätsanalyse auf den Detailseiten leicht nachprüfbar. Die Werte können angepasst werden. Als Standardwert wird die durchschnittliche Inflation und der durchschnittliche BDB-Index der letzten 18 Jahre angegeben. Der Diskontsatz setzt sich zu 0,7% aus dem Euribor, zu 2% aus dem Risiko und zu 0,3% aus der Prämie für den Finanzierer zusammen.