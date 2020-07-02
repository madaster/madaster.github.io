---
title: Financier - Couche du Bâtiment
layout: page
show_sidebar: false
menubar: faq-nav
ref: building-financial-buildinglayers
permalink: /building-financial-buildinglayers-fr
lang: fr
---

## MÉTHODE DE CALCUL
Les différentes couches du bâtiment ont une durée de vie fonctionnelle telle que définie par Madaster par défaut ou spécifique au bâtiment dans l'onglet « Général » Dans l'onglet « Couches de construction », la valeur des matériaux à la fin de leur vie fonctionnelle est déterminée. Les matériaux sont donc affectés à une année spécifique. La valeur en t = phase de fin de vie est calculée à partir de t = 0 dans la valeur du capital en utilisant le taux d'escompte. La somme des valeurs actuelles nettes (VAN) des différentes couches du bâtiment est la VAN de la somme totale.

## DETERMINATION DES LIGNES DE TENDANCE
La valeur attendue pour cette année est déterminée selon la ligne de tendance de la valeur matérielle. La valeur matérielle est de préférence importée depuis les prix des matières premières des bourses de marchandises communes. L'augmentation des prix des matériaux est d'abord ajustée en fonction de l'inflation de l'année en question et du taux de change correspondant si les marchandises sont dans une autre devise. Les points de données dans l'histoire des prix des matières premières avec cette déduction forment la base d'une ligne de tendance linéaire, qui est déterminée sur la base d'une analyse de régression, c'est-à-dire la méthode des moindres carrés.

## FACTEURS DE CORRECTION
Les valeurs des matériaux ont ensuite été corrigées pour tenir compte des coûts de démolition, des coûts de transformation, d'une correction pour l'importance du flux de matières premières et des coûts de transport par kg. Les coûts de démolition sont indexés sur la moyenne de l'indice BDB des 18 dernières années. Les coûts de traitement et de manutention dépendent du matériau et sont déterminés sur la base d'entretiens et de recherches documentaires. Pour les coûts de transport, une distance de 150 km par transport de marchandises vers le transformateur a été supposée pour tous les matériaux, à l'exception des matériaux pierreux (20 km) et du bois (40 km).

## SOURCE
- Feuer, p. (1994). Comment comprendre les bâtiments
- LME (London Metal Exchange, Marché des métaux de Londres)
- Quandl
- Vraagenaanbod.nl
- RVO
- BLS Beta Labs

## QUEL EST L'IMPACT DE L'INFLATION, DE L'INDICE BDB ET DU TAUX D'ESCOMPTE SUR MES CALCULS ?
Cette influence peut être testée dans l'analyse de sensibilité sur les pages de détail. Vous pouvez ici ajuster l'inflation, l'indice BDB et le taux d'escompte. Les valeurs pour l'inflation et l'indice BDB sont des valeurs standard sur la moyenne des 18 dernières années. Pour le taux d'escompte, on prend le taux d'intérêt public à 10 ans (0,7 %), auquel on ajoute un certain nombre de risques (2 %) et de bénéfices (0,3 %).
