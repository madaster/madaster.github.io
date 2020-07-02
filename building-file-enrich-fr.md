---
title: Enrichir
layout: page
show_sidebar: false
menubar: faq-nav
ref: building-file-enrich
permalink: /building-file-enrich-fr
lang: fr
---

## QUELLES SONT LES INFORMATIONS PRÉSENTÉES ICI ?
Le processus de mise en correspondance d'un élément (IFC) avec un produit ou un matériau est automatiquement effectué par Madaster après l'importation et la décomposition du fichier source. Il est possible que des éléments n'aient pas été trouvés ou qu'une mise en correspondance incorrecte ait été effectuée sur la base des critères de recherche. Dans le masque LITTING, le processus de mise en correspondance peut être vérifié et complété, ce que l'on appelle « l'ajout » d'informations au processus.

**NB** : Madaster conseille vivement, avant d'importer un fichier source, de s'assurer que les informations contenues dans le fichier source correspondent bien à celles des bases de données/sources sélectionnées. Cela peut se faire en utilisant le nom du matériau dans la base de données Madaster (voir [Lien vers la liste de matériaux Madaster] ) ou en s'assurant que le nom dans les fichiers source correspond à la base de données/source sélectionnée.

## MARQUE DE GAUCHE
Une fonction de recherche et de filtrage est disponible sur le côté gauche. Le filtre « Sujets » peut être étendu pour effectuer une sélection :

- Élément de statut ; filtre selon les éléments reliés/non reliés. Le filtre le plus important, en particulier, pour l'ajout d'éléments non reliés ;
- Élément de calcul ; filtre selon les éléments incorporés/exclus ;
- Type IFC ; filtre selon les types IFC disponibles ;
- Phase de construction ; filtre selon la phase de construction existante (existante/démolition/coque/nouvelle/finale) ;
- Couches de construction ; filtre selon l'enveloppe du bâtiment existante (Layer of Brand) ;
- Planchers ; filtre selon le niveau du plancher/bâtiment existant ;
- Méthodes de classification ; filtre selon le code de classification disponible ;
- Dimension de l'unité ; filtre selon l'unité dimensionnelle : Volume/superficie/longueur.

## ÉCRAN PRINCIPAL
L'écran principal affiche la liste de tous les éléments contenus dans le fichier source. Les informations sont affichées dans les colonnes :

- Élément ; nom de l'élément dans le fichier source ;
- Matériaux ; nom du matériau dans le fichier source ;
- Produit/matériau ; le produit/matériau auquel l'élément est affecté ;
- Nombre ; le nombre d'éléments de ce type/nom ;
- Symbole : Lien.

En sélectionnant un ou plusieurs éléments, une boîte de dialogue apparaît, avec laquelle les éléments peuvent être écrasés/séparés ou intégrés/exclus. L'inclusion ou l'exclusion d'un élément entraîne l'inclusion/la non-inclusion de cet élément dans les calculs. Cela peut être utilisé pour la masse du terrain environnant, par exemple, si elle est incluse dans le fichier source, ou s'il y a un chevauchement.

## VISIONNEUSE 3D
En haut de la fenêtre, dans la barre bleue, il y a un bouton pour activer une visionneuse 3D. Cela n'est possible que si le fichier source est un modèle IFC :

- Afficher le modèle 3D ; la visionneuse 3D s'ouvre et affiche le modèle entier ;
- Afficher la sélection dans le modèle 3D ; la visionneuse 3D s'ouvre et affiche l'élément/les éléments sélectionné(s).

Lorsqu'un élément est sélectionné dans la vue 3D, un bloc de dialogue apparaît qui permet d'écraser/séparer les éléments ou de les intégrer/exclure. À ce moment-là, l'élément en question n'est pas encore sélectionné dans la liste.
