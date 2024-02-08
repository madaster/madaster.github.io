---
title: Databasebrukere
ref: database-users
---

## Hvilken informasjon vises her?
På denne siden finner du muligheten til å legge til eller invitere brukere, eller opprette et API-token for kobling til et annet system.

Listen over brukere som uttrykkelig har minst samarbeidstilgang til denne databasen.
En bruker kan få uttrykkelige rettigheter til å samarbeide på eller administratorrettigheter til en database (trenger ikke rettigheter til noen andre objekter).

En bruker har indirekte rettigheter til en database, basert på hans/hennes rettigheter på et spesifikt objekt (konto/mappe/bygning) og tilgangene til databasen for objektet (kartlegge, kopiere, samarbeide, administrere).

Indirekte rettigheter:

Brukeren har følgende rettigheter for Objekt X       | Database A er delt med Objekt X i rollene (eller)                        | Brukeren har følgende rettigheter til database A
-------------------------------------------------|----------------------------------------------------------|-------------------------------------------------------------------
Leser                                             | Kartlegge, Kopiere, Bidra eller Administrere | Lese
Leder                                          | Kartlegge, Kopiere, Bidra eller Administrere| Over + Kartlegge element i bygninger under Objekt X
Leder og Bidragsyter til database eller Admin       | Kartlegge  | Over + Kartlegge element i bygninger under Objekt X
Leder og Bidragsyter til database eller Admin       | Kopiere  | Over + Kopiere materialer eller produkt fra database A til database B (der man har lov til å bidra)
Leder og Bidragsyter til database eller Admin       | Bidra  | Over + Bidra til database A
Admin                                            | Leder  | Over + Administrere database A-brukere + Rettigheter til å dele database A med andre objekter




### Knapper – mellom de blå linjene ###

**BRUKERE**
- Legg til bruker; legg til en bruker eller inviter en ny bruker.
- Legg til API-token; opprett et API-token for å invitere et system for en bruker.