---
title: Database Gebruikers
ref: database-users
---

## Welke informatie wordt hier getoond?
Op deze pagina wordt de lijst van gebruikers die expliciet "schrijf of beheer" toegang hebben tot de database getoond.
Ook vind de mogelijkheid plaats om gebruikers expliciet toegang te geven tot de database, of een API token te genereren ten behoeven van de koppeling me een ander systeem.

Een gebruiker kan expliciete rechten op een database krijgen om te kunnen bijdragen of administreren (geen noodzaak om rechten te hebben op een ander object).
Een gebruiker kunnen ook impliciet toegang hebben op de database, gebaseerd op zijn/haar rechten op een specifiek object (account/map/gebouw) en de beschikbaarheid van de database op het object (koppel, kopieer, bijdragen, beheer).

## Uitleg impliciete rechten op database:

Gebruiker heeft volgende rol op Object X | Database A is gedeeld met Object X in de rollen (of) | Gebruiker heeft volgende rechten op database A
-----------------------------------------|------------------------------------------------------|-------------------------------------------------------------------
Lezer                                      | Koppel , Kopieer, Bijdragen of Beheer | Lees
Manager                                    | Koppel , Kopieer, Bijdragen of Beheer| Bovenliggende + Koppel element in gebouwen onder Object X
Manager & bijdrager aan database of Beheer | Koppel  | Bovenliggende + Koppel element in gebouwen onder Object X
Manager & bijdrager aan database of Beheer | Kopieer  | Bovenliggende + kopieren materialen of product van database A in database B (Waaraan een Bijdrage mag worden geleverd)
Manager & bijdrager aan database of Beheer | Bijdragen  | Bovenliggende + Bijdragen aan database A
Beheer                                     | Beheer  | Bovenliggende + Gebruikers van database A beheren + Rechten om database A te delen met andere objecten

### Knoppenbalk - tussen de blauwe lijnen ###

**GEBRUIKERS**
- Gebruiker toevoegen; voeg een gebruiker toe of nodig een nieuwe gebruiker uit.
- API token toevoegen; genereer een API token om een systeem als gebruiker uit te nodigen.
