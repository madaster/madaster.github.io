---
title: Berik
ref: building-file-enrich
---

## Hvilken informasjon vises her?
Prosessen der (IFC) elementer sammenstilles med et produkt eller materiale, utføres automatisk av Madaster etter at kildefilen er importert og analysert. Det er mulig at elementer ikke er blitt sammenstilt med noe, eller at en feilaktig sammenstilling har skjedd på grunnlag av søkekriteriene. I skjermbildet BERIK kan du kontrollere og fullføre sammenstillingsprosessen, den såkalte «berikingen» av prosessen.

**Merk**: Før du importerer en kildefil anbefaler Madaster på det sterkeste å kontrollere at informasjonen i kildefilen har en høy grad av samsvar med informasjonen i de valgte databasene/kildene. Dette kan gjøres ved å bruke materialenavnet i Madaster-databasen (se [kobling til Madaster materialliste]) eller ved å sikre at navnet i kildefilen stemmer overens med din (egen) valgte database/kilde.


### VENSTRE MARG
På venstre siden finner du en søke- og filtreringsfunksjon. Filtrenes «temaer» kan foldes ut for å gjøre et valg:

- Elementstatus; filtrer på koblede / ikke koblede elementer. Spesielt for beriking av elementer uten kobling er dette det viktigste filteret;
- Elementberegning; filtrer på inkluderte/utelatte elementer;
- IFC-type; filtrer på tilgjengelige IFC-typer;
- Byggefase; filtrer på eksisterende byggefase (Gjeldende/Riving/Mellomstatus/Nye materialer/Endelig;
- Bygningslag; filtrer på eksisterende bygningslag (Brands lagdeling);
- Etasje; filtrer på eksisterende etasje/bygningslag;
- Klassifiseringsmetoder; filtrer på tilgjengelig klassifiseringskode;
- Enhetsdimensjon; filtrer på dimensjonsenhet: volum/overflate/lengde.


### HOVEDSKJERM
Hovedskjermen viser listen over alle elementer som finnes i kildefilen. Kolonnene viser informasjonen:
- Element; elementnavnet fra kildefilen.
- Materialer; materialnavnet fra kildefilen.
- Produkt/materiale; produktet/materialet som elementet er koblet til.
- Antall; antallet elementer av denne typen / med dette navnet.
- Ikon; kobling.

Når ett eller flere elementer velges, vises et dialogfelt der elementene kan få overskrift eller bli koblet fra, eller bli inkludert/utelatt. Å inkludere eller utelate et element vil føre til at dette elementet blir inkludert / ikke inkludert i beregningene. Dette kan for eksempel brukes for massen av det omliggende terrenget hvis den er inkludert i kildefilen. Eller hvis det forekommer duplikater.


### 3D-VISNINGSPROGRAM
Øverst i vinduet, i det blå feltet, er det en knapp for å aktivere et 3D-visningsprogram. Dette er bare mulig hvis kildefilen er en IFC-modell:
- Vis 3D-modell; 3D-visningsprogrammet åpnes og viser den totale modellen,
- Vis valg i 3D-modellen; 3D-visningsprogrammet åpnes og viser de valgte elementene.

Hvis et element er valgt i 3D-visningen, vises et dialogfelt der elementene kan få overskrift / bli koblet fra eller bli innebygd/utelukket. I øyeblikket er det aktuelle elementet ennå ikke valgt i listen.
