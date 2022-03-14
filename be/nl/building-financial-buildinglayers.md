---
title: Financieel - Gebouwlagen
ref: building-financial-buildinglayers
---

## Berekeningsmethode
De verschillende gebouwlagen hebben een functionele levensduur zoals default opgegeven door Madaster of gebouw-specifiek aangepast in de algemeen-tab. In de gebouwlagen-tab wordt de waarde van materialen bepaald op het einde van hun functionele levensduur. De materialen worden dus gealloceerd op een bepaald jaartal. De waarde in t = einde levensduur wordt netto contant teruggerekend naar t = 0 door middel van de discontovoet. De som van de netto contante waarden (NCW) van de verschillende gebouwlagen is de NCW van het totaal.

## Trendlijnbepaling
Volgens de trendlijn van de materiaalwaarde wordt de verwachte waarde op dat jaartal bepaald. De materiaalwaarde wordt bij voorkeur geïmporteerd uit commodityprijzen van gangbare commodity beurzen. De prijsstijging van materialen is allereerst gecorrigeerd met de inflatie van het betreffende jaar en de bijbehorende wisselkoers in het geval de commodity in een andere valuta staat. De datapunten in de historie van de commodity prijzen met deze aftrek is de basis voor een lineaire trendlijn die is bepaald op basis van een regressieanalyse, namelijk de least-squares methode. 

## Correctiefactoren
Vervolgens zijn de materiaalwaarden gecorrigeerd met sloopkosten, bewerkings- en verwerkingskosten, een correctie voor de grootte van de grondstofstroom en transportkosten per kg. De sloopkosten worden geïndexeerd met de gemiddelde BDB-index van de afgelopen 18 jaar. De verwerkings- en bewerkingskosten zijn materiaalafhankelijk en bepaald op basis van interviews en deskresearch. Voor de transportkosten is een afstand tot de verwerker aangenomen van 150 km per vrachtvervoer voor alle materialen behalve steenachtige materialen (20km) en hout (40km).

## Bronnen
* Brand, S. (1994). How Buildings Learn
* LME (London Metal Exchange)
* Quandl
* www.vraagenaanbod.nl
* RVO
* BLS Beta Labs

## Welke invloed hebben inflatie, BDB-index en de discontovoet op mijn berekening?
De invloed hiervan is goed te testen in de sensitiviteitsanalyse op de detailpagina’s. Hier kunnen de inflatie, BDB-index en de discontovoet aangepast worden. De waarden voor de inflatie en de BDB-index staan standaard op het gemiddelde van de afgelopen 18 jaar. Voor de discontovoet wordt de 10-jaars staatsrente (0,7%) genomen met een aantal risico (2%) en winst (0,3%) opslagen.  