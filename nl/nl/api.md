---
title: API
ref: api
menubar: none
---

# Madaster API
Het **Madaster API** endpoint kan worden gebruikt voor interactie met het Madaster Platform en zijn bronnen.
Deze API dekt nog niet alle functionaliteit van het platform, raadpleeg hiervoor de [OpenAPI documentatie](https://api.madaster.com/).

Om toegang te krijgen tot de API, heeft u een autorisatie token nodig.
Als u deze nog niet heeft, zie dan het hoofdstuk over Autorisatie hieronder.
Het token moet worden verzonden als een header met de naam 'X-API-Key', om toegang te krijgen tot de gewenste bronnen.

## Autorisatie
Om toegang te krijgen tot de bronnen van deze API, heeft u een API token nodig. Dit token moet worden toegevoegd aan het verzoek in de *X-API-Key* header.
Om een API token te verkrijgen, dient u een token toe te voegen in het Madaster Platform, of uw account manager te vragen dit voor u te doen.
Dit geeft u toegang tot de middelen en de daaraan gekoppelde entiteiten.

### Add a token to a account, folder, building or database
- Ga naar de resource pagina en klik op het *Gebruikers* tabblad

<img src="/assets/images/api/addtoken1NL.png" class="api-img"/>

- Klik op de *API Token toevoegen* knop

<img src="/assets/images/api/addtoken2NL.png" class="api-img"/>

- Voer een naam in voor dit token, kopieer de gegenereerde sleutel (1), kies een toestemmingsniveau en een vervaltijd, en sluit af door te klikken op de knop Toevoegen (2)

<img src="/assets/images/api/addtoken3NL.png" class="api-img"/>

## Versions
De API wordt voortdurend verbeterd, dus naarmate de tijd vordert, worden meer *versies* aan de interface toegevoegd. Raadpleeg de [OpenAPI documentatie](https://api.madaster.com/) om te vinden welke versies welke API-aanroepen ondersteunen. Het wordt aangeraden om altijd de laatste beschikbare versie te gebruiken voor een API verzoek; maar de oude versies zullen nog enige tijd beschikbaar blijven voor legacy doeleinden. Om een API versie te selecteren, voeg de versie tag toe aan het API eindpunt. Voor versie 3.0 bijvoorbeeld, gebruik https://api.madaster.com/api/v3.0

## Examples
In de [Github repository](https://github.com/Madaster/examples) kunt u enkele voorbeelden vinden over hoe te communiceren met de API in verschillende programmeertalen.