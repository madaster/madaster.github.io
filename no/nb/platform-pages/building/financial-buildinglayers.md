---
title: Økonomi – bygningslag
ref.: building-financial-buildinglayers
---

## Beregningsmetode
De forskjellige lagene har en funksjonell levetid som avsluttes i avviklingsårets pengestrøm. Denne verdien er som standard gitt av Madaster, men kan justeres manuelt under Generelt-fanen. Under fanen Brands lagdeling blir materialverdiene fastsatt på grunnlag av avviklingsdatoen. Verdien av et materiale på den datoen beregnes tilbake til i dag med beregningen av netto nåverdi (NPV-beregning), som bruker diskonteringsrenten. Summen av NPV-ene representerer bygningsverdien uttrykt som materialverdi. 

## Fastsetting av trendlinje
Den forventede verdien i forskjellige år i fremtiden bestemmes i henhold til trendlinjen for materialverdien. Materialverdien importeres, helst fra vanlige råvarepriser. Prisforandringen korrigeres først for inflasjon i året for skifte av eierskap. Etter det blir priser oppgitt i euro i henhold til valutakursene for det spesifikke året. Punktene i trendlinjen analyseres med en regresjonsanalyse, som følger: minste kvadraters metode. 

## Korreksjonsfaktorer
Etter dette korrigeres materialverdiene med rivingskostnader, resirkuleringskostnader, logistikkostnader og en korreksjon for materialpartiets størrelse. Rivingskostnadene korrigeres hvert år med BDB-indeksen som representerer inflasjonen i bygningskostnader. Gjennomsnittet av prisutviklingen i de siste 18 årene representerer standardverdien som kan tilpasses. Resirkuleringskostnadene er uavhengige for hvert materiale og beregnes basert på skrivebordsanalyser og intervjuer. For transportkostnader antas en transport på 150 km som grunnlag for logistikkostnader. To materialgrupper har en annen sats for disse kostnadene, nemlig stein (20 km) og tre (40 km).

## Referanser
* Brand, S. (1994). How Buildings Learn
* LME (London Metal Exchange, metallbørsen i London)
* Quandl
* www.vraagenaanbod.nl
* RVO
* BLS Beta Labs

## Hvordan påvirker inflasjon, BDB-indeksen og diskonteringsrenten beregningen?
Innflytelsen kan lett kontrolleres i følsomhetsanalysen på detaljsidene. Verdier kan tilpasses. Som en standardverdi brukes gjennomsnittlig inflasjon og gjennomsnittlig BDB-indeks for de siste 18 årene. Diskonteringsrenten er bygd opp bestående av 0,7 % Euribor, 2 % som representerer risikoen og 0,3 % som representerer påslaget for finansieringskilden. 
