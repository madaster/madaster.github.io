---
title: Masse
ref: building-level
---

## Hvilken informasjon vises her?
Total masse og materialintensitet (masse/m2) vises. Når et benchmark er valgt, og informasjon er tilgjengelig, sammenlignes objektet med andre. Ukjente elementer vises slik at de kan modifiseres, og i sin tur inkluderes i beregninger. Ved å bruke rullegardinmenyen vises massen etter matrise, bygningslag og materialfamilie.

### Masse etter matrise
Tabellen er delt inn horisontalt i en materialklassifisering (Madaster eller Table3-NL_SfB). Vertikalt gjøres en underinndeling i de forskjellige bygningslagene (""Layers of Brand").

### BYGNINGSLAG
Den første kolonnen «Totalt» viser mengdene (massen) og antallet produkter (stykk) per materialtype samt prosentandelen i forhold til de andre materialene som er brukt i denne bygningen. I tillegg til denne prosentandelen er vekten og volumet per materialtype også synlig.

**«Brands lagdeling»** De andre kolonnene viser per «lag» i bygningen, gjennom de såkalte «Brand-lagene», hva slags materiale som er brukt i det aktuelle bygningslaget, og prosentandelen i forhold til de andre materialene i det bygningslaget. I tillegg til denne prosentandelen er vekten og volumet per materialtype også synlig.

### MATERIALER
Hvis du har valgt å vise de sju materialfamiliene, er materialfamilien «ukjent» hvis det ikke er samsvar mellom elementet og databasen med materialer og produkter. Disse elementene vil vises i raden «Ukjent» under de fem bygningslagene. Hvis du har valgt å vise i henhold til en materialklassifisering (f.eks. NL-SfB Table 3) , blir ikke materialene vist hvis det ikke er samsvar mellom elementet og databasen med materialer og produkter.

Du finner mer informasjon om materialene ved å klikke på en av sirklene. Et nytt skjermbilde vil åpne seg og forklare hvilke materialer og produkter som har blitt brukt. Materialtypen «murstein» kan for eksempel spesifiseres som materialene «betong» og «murstein» og som produktene «forsterket søyle» som igjen består av «murstein». Du kan se i hvilket volum hvert materiale forekommer. Hvis du har valgt materialklassifiseringen basert på NL-SfB Table 3, kan du videre åpne de forskjellige materialtypene i kolonnen til venstre ved å klikke på typen materiale. På den måten kan du ytterligere zoome inn på materialklassifiseringen.

**Filter**
I denne oversikten kan du bruke et filter. I filteret kan det legges inn materialer, og bare disse materialene vises i tabellen. Søkeresultatene i filteret kan slås av ved å klikke på krysset.

**Vis** 
Med «visningsskift» blir materialfamiliene plassert horisontalt og bygningslagene vertikalt. Dette gir deg de samme dataene på en annen oversikt. Prosentandelene legges nå sammen i kolonnen for materialklassifisering.

**Kildefiler** 
Ved å klikke på «Kildefiler» vises et sprettoppvindu der kvaliteten og fullstendigheten av informasjonen i de aktive kildefilene vises.


### PRODUKTER
For å få innsikt i de tilstedeværende produktene er det mulig å klikke på et bygningslag, for eksempel «Konstruksjon» eller «Tekniske installasjoner». Du vil da komme til et nytt skjermbilde der du får innsikt i produktene som er brukt i dette spesifikke bygningslaget. På denne siden kan du filtrere på nøkkelord, klassifiseringsmetode (venstre kolonne) eller nivå (etasje).

Hvis et produkt velges, kan du se mer produktinformasjon for det spesifikke produktet på høyre side av fanene «Materiale», «Produkt», «Sirkularitet» og «IFC». I fanen «Produkt» kan du så legge et dokument til dette produktet, slik som en håndbok, et sertifikat, en garantierklæring eller et «Produktpass».

### Masse etter bygningslag
Et sektordiagram viser masse etter bygningslag til venstre. Til høyre viser et stablet søylediagram materialfamiliesammensetningen til hvert bygningslag. Brukere kan klikke på en stolpe i det stablede stolpediagrammet for å se hvilke materialer og produkter som inngår i. Brukere kan filtrere etter materiale, etasje og kildefil.

Brukere kan også klikke på et bygningslag i kakediagrammet. Når du gjør det, blir alle beregninger spesifikke for det valgte bygningslaget. I tillegg oppdateres det stablede søylediagrammet til høyre for å vise materialunderfamiliene til bygningslaget. Igjen kan brukere klikke på en stolpe i det stablede stolpediagrammet for å se hvilke materialer som inngår i.

### Messe Etter materialfamilie
Et sektordiagram viser masse etter materialfamilie til venstre. Til høyre viser et stablet søylediagram fordelingen av materialfamilier over bygningslagene. Brukere kan klikke på en stolpe i det stablede stolpediagrammet for å se hvilke materialer som inngår i. Brukere kan filtrere etter materiale, etasje og kildefil.

Brukere kan også klikke på en materialfamilie i kakediagrammet. Når du gjør det, fjernes den totale masseberegningen for å være spesifikk for den valgte materialfamilien, og materialintensiteten og benchmarking-beregningene. I tillegg oppdateres det stablede søylediagrammet til høyre for å vise fordelingen av materialunderfamilier på tvers av bygningslagene. Igjen kan brukere klikke på en stolpe i det stablede stolpediagrammet for å se hvilke eksakte materialer som inngår i.

### Ukjente elementer
Ukjente elementer er de som ikke ble tatt med i beregningen. Disse kan oppstå av 3 forskjellige årsaker:

_*Elementer uten koblinger*__ : disse elementene er ikke knyttet til material-/produktdatabase, og kan derfor ikke rapporteres på.

__*Elementer med ukjent lag*__: disse elementene mangler konstruksjonsklassifiseringsinformasjon, og kan derfor ikke tilordnes et bygningslag.

__*Elementer med utilstrekkelig geometri*__: disse elementene mangler tilstrekkelig geometri, og kan derfor ikke brukes til beregninger.
