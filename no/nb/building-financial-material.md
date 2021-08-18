---
title: Økonomi – materiale
ref: building-financial-material
---

## Beregningsmetode
Materialverdien importeres helst fra råvareprisene på offentlige råvarebørser. Den historiske prisøkningen på materialene korrigeres først med inflasjonen i det aktuelle året og den tilsvarende valutakursen i tilfelle råvaren selges i en annen valuta. Datapunktene i historikken over råvarepriser med dette fradraget er grunnlaget for en lineær trendlinje som fastsettes på grunnlag av en regresjonsanalyse, dvs. minste kvadraters metode.


### Korreksjonsfaktorer
Deretter blir materialverdiene korrigert for rivekostnader, behandlingskostnader, en korreksjon for størrelsen av råmaterialflyten og transportkostnader per kg. Rivekostnadene er indeksert med den gjennomsnittlige BDB-indeksen for de siste 18 årene. Behandling og behandlingskostnader er materialavhengige og bestemmes på grunnlag av intervjuer og skrivebordsanalyser. For transportkostnader er det antatt en avstand til behandler på 150 km per frakttransport for alle materialer unntatt steinmaterialer (20 km) og tre (40 km).


### Kilder
- LME (London Metal Exchange, metallbørsen i London).
- Quandl.
- www.vraagenaanbod.nl.
- RVO.
- BLS Beta Labs.

### Hvordan påvirker inflasjon, BDB-indeksen (byggekostnadsindeks) og diskonteringsrenten beregningen min?
Innflytelsen av disse kan testes i følsomhetsanalysen på detaljsidene. Her kan du justere inflasjon, BDB-indeksen og diskonteringsrenten. Verdiene for inflasjon og BDB-indeksen er som standard lik gjennomsnittet for de siste 18 årene. Som diskonteringsrente brukes renten for tiårige statsobligasjoner (0,7 %) pluss risiko (2 %) og fortjeneste (0,3 %) lagt til.
