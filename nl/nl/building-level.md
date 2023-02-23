---
title: Gebouw
ref: building-level
redirect_from:
  - /nl/nl/building-level-product
---

## Welke informatie wordt hier getoond?
De totale massa en materiaalintensiteit (massa/m2) worden weergegeven. Wanneer een benchmark is geselecteerd en er informatie beschikbaar is, wordt het object vergeleken met anderen. Onbekende elementen worden weergegeven zodat ze kunnen worden aangepast en op hun beurt kunnen worden meegenomen in berekeningen. Met behulp van de vervolgkeuzelijst wordt de massa weergegeven per matrix, gebouwschil en materiaalfamilie.
 
### Massa per matrix
De tabel is horizontaal onderverdeeld in een materiaalclassificatie (Madaster of Tabel3-NL_SfB). Verticaal wordt er een onderverdeling gemaakt in de verschillende gebouwschillen (“Layers of Brand”).

### Gebouwschillen
De eerste kolom ‘Totalen’ geeft de hoeveelheden (massa) en het aantal producten (stuks) per materiaalsoort weer, en het percentage in relatie tot de andere materialen welke voor dit gebouw gebruikt zijn. Naast dit percentage zijn ook het gewicht en het volume per materiaalsoort zichtbaar. 

**Layers of Brand** De overige kolommen geven per 'schil' van het gebouw, middels de zogenaamde "Layers of Brand", weer welk materiaal er gebruikt is in de betreffende gebouwschil, en het percentage in relatie tot de andere materialen in deze gebouwschil. Naast dit percentage zijn ook het gewicht en het volume per materiaalsoort zichtbaar.

### Materialen
Heeft u gekozen voor een weergave van de zeven materiaalfamilies dan is de materiaalfamilie 'onbekend' als er geen match heeft plaatsgevonden tussen het element en de database van materialen en producten. Deze elementen komen in de kolom ‘Onbekend’ onder de 5 bouwfases. Als u heeft gekozen voor de weergave o.b.v. NL-SfB Tabel 3, worden materialen niet weergegeven als er geen match heeft plaatsgevonden tussen het element en de database van materialen en producten.

U kunt meer informatie verkrijgen over de materialen die gebruikt zijn door op één van de cirkels te klikken. Er opent een nieuw scherm, waarin toegelicht wordt welke materialen en producten gebruikt zijn. De materiaalsoort ‘steen’ kan bijvoorbeeld gespecificeerd worden tot de materialen ‘beton’ en ‘baksteen’ en tot de producten ‘gewapende pijler’ wat weer bestaat uit ‘baksteen’. Te zien is in welk volume elk materiaal voorkomt. Als u heeft gekozen voor de materiaalclassificatie o.b.v. NL-SfB Tabel 3, kunt u de verschillende type materialen in de kolom links verder openklappen door op een type materiaal te klikken. Op deze manier kunt u verder in inzoomen op de materiaalclassificatie.

**Filter**  
In dit overzicht kan gebruik worden gemaakt van een filter. In het filter kunnen materialen worden opgevoerd, om vervolgens alleen deze materialen terug te zien in de tabel. De zoekresultaten in het filter kunnen uitgezet worden door op kruisje te klikken. 

**View**
Door de ‘view-switch’ worden de materiaalfamilies horizontaal gepositioneerd en de gebouwschillen verticaal. Hierdoor krijgt u dezelfde gegevens in een ander overzicht te zien. De percentages tellen nu op in de materiaal-classificatie kolom.

**Bronbestanden**
Door op 'Bronbestanden' te klikken, verschijnt een pop-up scherm waarin de kwaliteit, volledigheid van informatie van de _actieve_ bronbestanden wordt getoond.

### Producten
Om inzicht te krijgen in de aanwezige producten, is het mogelijk om op een 'gebouwschil' door te klikken, bijvoorbeeld ‘Constructie’ of 'Technische installaties'. U gaat vervolgens naar een nieuw scherm waar u inzicht krijgt in de toegepaste producten van deze specifieke gebouwschil. U kunt op deze pagina onder andere filteren op trefwoord, Classificatiemethode (linker kolom) of bouwlaag (verdieping).

Als een product is geselecteerd, kunt u voor het desbetreffende product aan de rechterkant op de tabbladen ‘Materiaal’, ‘Product’ 'Circulariteit' en ‘IFC’ nog meer productinformatie bekijken. In de tab 'Product' is er vervolgens de mogelijkheid om een document aan dit product toe te voegen, zoals bijvoorbeeld een handleiding, een certificaat, garantiebepaling of een 'Productpaspoort'.

### Massa per gebouwschil (Shearing Layer)
Aan de linkerkant geeft een cirkeldiagram de massa weer per gebouwschil. Aan de rechterkant toont een gestapeld staafdiagram de samenstelling van de materiaalfamilie van elke gebouwschil. Gebruikers kunnen op een staaf in het gestapelde staafdiagram klikken om te zien welke materialen en producten erin zijn opgenomen. Gebruikers kunnen filteren op materiaal, verdieping en bronbestand.

Gebruikers kunnen ook op een gebouwschil in het cirkeldiagram klikken. Dan worden alle metrieken specifiek voor de geselecteerde gebouwschil. Bovendien wordt het gestapelde staafdiagram aan de rechterkant bijgewerkt om de materiaalsubfamilies van de gebouwschil weer te geven.

### Massa per Materiaalfamilie
Aan de linkerkant geeft een cirkeldiagram de massa weer per materiaalfamilie. Aan de rechterkant toont een gestapeld staafdiagram de verdeling van materiaalfamilies over de gebouwschillen. Gebruikers kunnen op een staaf in het gestapelde staafdiagram klikken om te zien welke materialen erin zijn opgenomen. Gebruikers kunnen filteren op materiaal, verdieping en bronbestand.

Gebruikers kunnen ook op een materiaalfamilie in het cirkeldiagram klikken. Dan worden de totale massa-statistieken bijgewerkt om specifiek te zijn voor de geselecteerde materiaalfamilie en worden de materiaalintensiteit en benchmarking-statistieken verwijderd. Bovendien wordt het gestapelde staafdiagram aan de rechterkant bijgewerkt om de verdeling van materiaalsubfamilies over de gebouwschillen weer te geven.

### Onbekende elementen
Onbekende elementen zijn elementen waarmee tijdens de berekeningen geen rekening is gehouden. Deze kunnen om 3 verschillende redenen voorkomen:

__*Elementen ontkoppeld*__: deze elementen zijn niet gekoppeld aan een materiaal-/productdatabase en kunnen dus niet worden gerapporteerd.

__*Elementen met onbekende gebouwschil*__: deze elementen missen een classificatiecode en kunnen dus niet worden toegewezen aan een gebouwschil.

__*Elementen met gebrekkige geometrie*__: deze elementen hebben onvoldoende geometrie en kunnen dus niet worden gebruikt voor berekeningen.
