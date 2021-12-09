---
title: Database Users
ref: database-users
---

## What information is shown here?
On this page you will find the possibility to add or invite users, or generate an API token for linking to another system.

The list of users which explicitly have at least collaborate access to this database.
A user can be given explicit rights to collaborate or admin rights on a database (no need to have rights on any other object).

A user has implicit rights on a database, based on his/her rights on a specific object (account/folder/building) and the availabilities of the database on the object (map, copy, collaborate, admin).

Implicit rights:

User has the following rights for Object X       | Database A is shared with Object X in the roles (or)                         | User has the following rights to database A
-------------------------------------------------|----------------------------------------------------------|-------------------------------------------------------------------
Read                                             | Map , Copy, Contribute or Manage | Read
Manager                                          | Map , Copy, Contribute or Manage| Above + Map element in buildings under Object X
Manager & Contributer to database or Admin       | Map  | Above + Map element in buildings under Object X
Manager & Contributer to database or Admin       | Copy  | Above + Copying materials or product from database A into database B (Where one is entitled to make contributions)
Manager & Contributer to database or Admin       | Contribute  | Above + Contribute to database A
Admin                                            | Mange  | Above + Manage database A users + Rights to share database A with other objects




### Buttons - between the blue lines ###

**USERS**
- Add user; add a user or invite a new user.
- Add API token; generate an API token to invite a system as a user.
