---
title: Verrijken
ref: building-file-enrich
---

## Welke informatie wordt hier getoond?
Het proces van matching, van (IFC) element met een product of een materiaal, wordt door Madaster automatisch uitgevoerd na het importeren en ontleden van het bronbestand. Het kan zijn dat er elementen niet gematched zijn, of dat er een verkeerde matching heeft plaatsgevonden op basis van de zoekcriteria. In het scherm VERRIJKEN kan het matchingsproces gecontroleerd en aangevuld worden, het zogenaamde "verrijken" van het proces.

**NB** : Madaster adviseert sterk om voorafgaand aan het importeren van een bronbestand, er voor te zorgen dat de informatie in het bronbestand goed matcht met de informatie in de geselecteerde databases/bronnen. Dit kan door in de bronbestanden gebruik te maken van de materiaalbenaming in de Madaster database (<a href="/files/be/en/EPEA Generic material list.xlsx" target="_blank">EPEA Generic database material list</a>) of door ervoor te zorgen dat de benaming in de bronbestanden overeenkomt met de (eigen) geselecteerde database/bron.

### Linker kantlijn
Aan de linkerkant is  een zoek en filter functie beschikbaar. De filter "thema's" kunnen uitgeklapt worden om daar een selectie in te maken:
- Status element; filter op gekoppelde / ongekoppelde elementen. Vooral voor het verrijken van ongekoppelde elementen het belangrijkste filter;
- Berekening element; filter op ingesloten / uitgesloten elementen;
- IFC-type; filter op aanwezige IFC types;
- Bouwfase; filter op aanwezige bouwfase (bestaand/sloop/casco/nieuw/definitief;
- Gebouwlagen; filter op aanwezig gebouwschil (layer of Brand);
- Verdiepingen; filter op aanwezige verdieping/bouwlaag;
- Classificatiemethodes; filter op aanwezige classificatie code;
- Eenheid dimensie; filter op dimensie eenheid: volume / oppervlakte / lengte.


### Hoofdscherm
Het hoofdscherm laat de lijst van alle elementen zien die in het brondbestand zitten. De kolommen geven de informatie weer over:
- Element; elementnaam uit het bronbestand;
- Materialen; materiaalnaam uit het bronbestand;
- Product/materiaal; het product/materiaal waarmee het element is gekoppeld;
- Aantal; het aantal elementen van dit type/naam;
- Icoon: koppelen.

Door een of meerdere elementen te selecteren, verschijnt er een dialoogblok, waar mee de elementen gekoppend/ontkoppeld, of ingesloten/uitgesloten kunnen worden.
Het insluiten of uitsluiten van een element leidt er toe dat dit element wel/niet wordt meegenomen in de berekeningen. Dit kan bijvoorbeeld gebruikt worden voor de massa van het omliggende terrein als dat meegenomen is in het bronbestand. Of als er dubbelingen geconstateerd zijn.



## 3D viewer
Bovenaan in het venster, in de blauwe balk, staat een knop om een 3D viewer te activeren. Dit kan alleen als het bronbestand een IFC model is:
- Toon 3D model; de 3D viewer opent en toont het totale model;
- Toon selectie in 3D model; de 3D viewer opent en toont de geselecteerde element(en).

Als er in de 3D view een element wordt geselecteerd, dan verschijnt er een dialoogblok, waar mee de elementen gekoppend/ontkoppeld, of ingesloten/uitgesloten kunnen worden. Op dit moment wordt het betreffende element nog niet in de lijst geselecteerd.

