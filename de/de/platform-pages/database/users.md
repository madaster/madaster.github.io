---
title: Datenbank Benutzer
ref: database-users
---

## Welche Informationen werden hier angezeigt?
Auf dieser Seite wird die Liste der Benutzer angezeigt, die expliziten "Schreib- oder Admin"-Zugriff auf die Datenbank haben. Außerdem können Sie Benutzern explizit Zugriff auf die Datenbank geben oder ein API-Token für die Verbindung mit einem anderen System generieren.

Einem Benutzer können explizite Rechte für eine Datenbank zum Beitragen oder Verwalten gegeben werden (er muss keine Rechte für ein anderes Objekt haben). Ein Benutzer kann auch Zugriff auf die Datenbank haben, basierend auf seinen Rechten für ein bestimmtes Objekt (Konto/Ordner/Gebäude) und der Verfügbarkeit der Datenbank für das Objekt (verknüpfen, kopieren, beitragen, verwalten).


**Die verschiedenen Rechte beinhalten**:

Benutzer hat die folgenden Rechte für Object X   | Datenbank A ist gemeinsam mit Objekt X in den Rollen (oder)  | User has the following rights to database A
-------------------------------------------------|--------------------------------------------------------------|-------------------------------------------------------------------
Lesen                                            | Zuordnen, Kopieren, Beitragen oder Verwalten                 | Lesen
Manager                                          | Zuordnen, Kopieren, Beitragen oder Verwalten                 | Oben + Kartenelement in Gebäuden unter Objekt X
Manager & Mitwirkender an  Datenbank oder Admin  | Zuordnen                                                     | Oben + Kartenelement in Gebäuden unter Objekt X
Manager & Mitwirkender an Datenbank oder Admin   | Kopieren                                                     | Oben + Kopieren von Materialien oder Produkten aus Datenbank A in 
                                                 |                                                              | Datenbank B (Wo man berechtigt ist, Beiträge zu leisten) 
Manager & Mitwirkender an Datenbank oder Admin   | Mitarbeiten                                                  | Zur Datenbank beitragen A
Administrator                                    | Managen                                                      | Benutzer der Datenbank A verwalten + Rechte zur Freigabe der 
                                                 |                                                              | Datenbank A mit anderen Objekten

### BUTTONS - ZWISCHENBEREICH ###

**Benutzer**
- Benutzer hinzufügen: Einen Benutzer hinzufügen oder einen neuen Benutzer einladen.
- API-Token hinzufügen: Erzeugen Sie ein API Token, um ein System als Benutzer einzuladen.