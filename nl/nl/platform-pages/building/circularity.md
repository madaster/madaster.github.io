---
title: Circulariteit
ref: building-circularity
redirect_from:
  - platform-pages/building/circularity-ci
---

## Welke informatie wordt hier getoond?
De Madaster Circulariteit Indicator (MCI) en de losmaakbaarheid van het gebouw worden weergegeven. Wanneer een benchmark is geselecteerd en er informatie beschikbaar is, wordt het gebouw vergeleken met anderen. Hieronder worden de MCI, materiaalstromen weergegeven. Onbekende elementen worden weergegeven zodat ze kunnen worden aangepast en op hun beurt kunnen worden meegenomen in berekeningen. Met behulp van de vervolgkeuzelijst kunnen materiaalstromen worden weergegeven op totaal, gebouwschil en materiaal/product.

### Madaster Circulariteit Indicator (MCI)
De Madaster Circularity Indicator geeft ieder gebouw een score van 0-100% en wordt bepaald op basis van de gegevens die zijn vastgelegd in Madaster door de gebruiker. Een gebouw dat volledig is opgebouwd uit nieuwe materialen en eindigt op een afvalberg, is een volledig ‘lineair’ gebouw en scoort op de CI: 0%. Anderzijds, een gebouw dat volledig bestaat uit hergebruikte materialen of producten en in de toekomst volledig kan worden hergebruikt, is een volledig ‘circulair’ gebouw en scoort op de CI: 100%. In praktijk, zullen gebouwen een score hebben tussen de 0-100%.

De MCI beoordeelt een gebouw tijdens 3 levensfasen:

__*Constructiefase:*__ wat is de verhouding tussen “nieuwe” en “gerecyclede, hergebruikte of hernieuwbare” grondstoffen?

__*Gebruiksfase:*__ wat is de verwachte levensduur van de producten die worden gebruikt ten opzichte van de gemiddelde levensduur van vergelijkbare producten?

__*Einde-levensduur:*__ wat is de verhouding tussen “afval” en “hergebruik of recycling” van materialen en producten die vrijkomen bij een verbouwing of sloop van een gebouw?

De CI beoordeling kent 2 verschillende bepalingsmethodes:

- **Gebouw Circulariteit Indicator**: CI score van het gebouw op basis van de beschikbare gegevens;
- **Madaster Circulariteit Indicator**: gecorrigeerde Gebouw CI score op basis van correctiefactoren.

De Gebouw CI wordt gecorrigeerd met twee factoren die de compleetheid van de in Madaster vastgelegde dataset meenemen in de totaal score. Een circulair gebouw en daarbij behorend Materialen Paspoort werkt alleen voor producten en materialen die goed zijn vastgelegd. De correctie vindt plaats op basis van de compleetheid van het model op basis van het percentage van de massa waarvan het materiaal onbekend is, en de compleetheid van het model op basis van het percentage van de massa waarvan de NL-SfB codering afwezig is.

Ook is er een <a href="/files/Toelichting_Madaster_Circulariteit_Indicator_v1.0_nl.pdf" target="_blank">uitgebreide toelichting</a> van de Madaster Circulariteit Indicator beschikbaar.

### Losmaakbaarheid
De losmaakbaarheidsindex op gebouwniveau wordt berekend volgens een methodiek beschreven op de site van de Dutch Green Building Council. Binnen Madaster wordt de berekening gemaakt op alle elementen gekoppeld aan producten die zijn voorzien van losmaakbaarheidsinformatie en een Milieukostenindicator bevatten.

### Materiaalstromen
Met behulp van de vervolgkeuzelijst kunnen materiaalstromen worden weergegeven op totaal, gebouwschil en materiaal/product. Inputstromen worden geclassificeerd op basis van de definitie van Platform CB'23 van nieuwe en secundaire grondstoffen. Virgin feedstock wordt onderverdeeld in hernieuwbaar en niet-hernieuwbaar materiaal, waarbij hernieuwbaar materiaal verder wordt onderverdeeld in duurzaam geproduceerd en niet-duurzaam geproduceerd materiaal. Secundaire grondstof wordt onderverdeeld in materiaal uit hergebruik en materiaal uit recycling. Outputstromen worden geclassificeerd op basis van de definitie van Platform CB'23. De output is onderverdeeld in materiaal beschikbaar voor hergebruik, materiaal beschikbaar voor recycling, materiaal voor storten en materiaal voor verbranding. Wanneer deze in 3D worden weergegeven, krijgen de materialen/producten een kleurcode op basis van hun MCI en hun invoer- en uitvoerstromen.

### Onbekende elementen
Onbekende elementen zijn elementen waarmee tijdens de berekeningen geen rekening is gehouden. Deze kunnen om 3 verschillende redenen voorkomen:

__*Elementen ontkoppeld*__: deze elementen zijn niet gekoppeld aan een materiaal-/productdatabase en kunnen dus niet worden gerapporteerd.

__*Elementen met onbekende gebouwschil*__: deze elementen missen een classificatiecode en kunnen dus niet worden toegewezen aan een gebouwschil.

__*Elementen met gebrekkige geometrie*__: deze elementen hebben onvoldoende geometrie en kunnen dus niet worden gebruikt voor berekeningen.
