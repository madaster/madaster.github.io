---
title: API
ref: api
menubar: none
---

# Madaster API
Endepunktet **Madaster API** kan brukes for å samhandle med Madaster-plattformen og ressursene på den.
Dette API-et dekker ennå ikke all funksjonalitet til plattformen, se [OpenAPI documentation](https://api.madaster.com/).

For å få tilgang til API-ressursene, trenger du et godkjenningstoken.
Hvis du ikke har ett ennå, se kapittelet om godkjenning nedenfor.
Dette tokenet skal sendes som en topptekst med navnet «X-API-Key», som vil autentisere forespørselen med tokenet.

## Godkjenning
For å få tilgang til ressursene i dette API-et, trenger du en API-nøkkel. Denne nøkkelen må knyttes til forespørselen i *X-API-Key*-toppteksten.
For å få tak i en API-nøkkel, må du legge til et token i Madaster-plattformen eller be kontoansvarlige om å gjøre dette for deg.
Dette vil gi deg tilgang til ressursene og deres tilhørende enheter.

### Legge til et token til en konto, mappe, bygning eller database
- Gå til ressurssiden og klikk på fanen *Brukere*

<img src="/assets/images/api/addtoken1.png" class="api-img"/>

- Klikk på knappen *Legg til API-token*

<img src="/assets/images/api/addtoken2.png" class="api-img"/>

- Angi et navn for dette tokenet, kopier den genererte nøkkelen (1), velg et tillatelsesnivå og utløpstid og avslutt ved å klikke på knappen Legg til (2)

<img src="/assets/images/api/addtoken3.png" class="api-img form-img"/>

## Versjoner
API-et forbedres hele tiden, så flere *versjoner* legges til grensesnittet etter som tiden går. Se [OpenAPI documentation](https://api.madaster.com/) for å finne ut hvilke versjoner som støtter hvilke API-kall. Det anbefales alltid å bruke nyeste tilgjengelige versjon for en API-forespørsel, men de gamle versjonene vil fortsatt være tilgjengelig i en viss tid til bruk med eldre utstyr. For å velge en API-versjon legger du til versjonstaggen på API-endepunktet. For versjon 3.0 må du for eksempel bruke https://api.madaster.com/api/v3.0

## Eksempler
I [Github-lageret](https://github.com/Madaster/examples) finner du noen eksempler på hvordan du samhandler med API-et i forskjellige programmeringsspråk.
