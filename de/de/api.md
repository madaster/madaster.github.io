---
title: API
ref: api
menubar: none
---

# MADASTER API
Die **Madaster API**-Endpunkte können verwendet werden, um mit der Madaster-Plattform und ihren Funktionen zu interagieren.
Diese API deckt noch nicht alle Funktionen der Plattform vollständig ab, bitte beachten Sie die [OpenAPI-Dokumentation](https://api.madaster.com/).

Um auf die API's zuzugreifen, benötigen Sie ein Autorisierungs-Token.
Wenn Sie noch keins haben, lesen Sie das Kapitel über die Autorisierung weiter unten.
Dieser Token sollte als Header mit dem Namen 'X-API-Key' gesendet werden, wodurch die Anfrage mit dem Token authentifiziert wird.

## AUTORISIERUNG
Um auf die Dienste dieser API zugreifen zu können, benötigen Sie einen API-Schlüssel. Dieser Schlüssel muss im *X-API-Key*-Header an die Anfrage angehängt werden.
Um einen API-Schlüssel zu erhalten, müssen Sie ein Token in der Madaster-Plattform hinzufügen oder Ihren Account Manager bitten, dies für Sie zu tun.
Dadurch erhalten Sie Zugriff auf die Ressourcen und die damit verbundenen Entitäten.

### HINZUFÜGEN EINES TOKENS ZU EINEM KONTO, ORDNER, GEBÄUDE ODER EINER DATENBANK
- Klicken Sie auf die Registerkarte *Benutzer*.

<img src="/assets/images/api/addtoken1DE.png" class="api-img"/>

- Klicken Sie auf die Schaltfläche *API-TOKEN HINZUFÜGEN*.

<img src="/assets/images/api/addtoken2DE.png" class="api-img"/>

- Geben Sie einen Namen für den Token ein, kopieren Sie den generierten Schlüssel (1), wählen Sie eine Berechtigungsstufe und eine Ablaufzeit und klicken Sie abschließend auf die Schaltfläche Hinzufügen (2)

<img src="/assets/images/api/addtoken3DE.png" class="api-img"/>

## VERSIONEN
Die API wird ständig verbessert, so dass im Laufe der Zeit weitere *Versionen* der Schnittstelle hinzugefügt werden. Welche Versionen welche API-Aufrufe unterstützen, finden Sie in der [OpenAPI-Dokumentation](https://api.madaster.com/). Es wird empfohlen, immer die neueste verfügbare Version für eine API-Anfrage zu verwenden: Die alten Versionen bleiben jedoch noch eine Zeit lang für Legacy-Zwecke verfügbar. Um eine API-Version auszuwählen, hängen Sie das Versions-Tag an den API-Endpunkt an. Für Version 3.0 verwenden Sie zum Beispiel https://api.madaster.com/api/v3.0

## BEISPIELE
Im [Github-Repository](https://github.com/Madaster/examples) finden Sie einige Beispiele, wie Sie mit der API in verschiedenen Programmiersprachen interagieren können.
