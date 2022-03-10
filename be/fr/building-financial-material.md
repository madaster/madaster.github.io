---
title: Financier - Matériel
ref: financial-material
---

## MÉTHODE DE CALCUL
La valeur matérielle est de préférence importée depuis les prix des matières premières des bourses de marchandises communes. L'augmentation historique des prix des matériaux est d'abord corrigée avec l'inflation de l'année en question et le taux de change correspondant, si les marchandises sont dans une autre devise. Les points de données dans l'histoire des prix des matières premières avec cette déduction forment la base d'une ligne de tendance linéaire, qui est déterminée sur la base d'une analyse de régression, c'est-à-dire la méthode des moindres carrés.

## FACTEURS DE CORRECTION
Les valeurs des matériaux ont ensuite été corrigées pour tenir compte des coûts de démolition, des coûts de transformation, d'une correction pour l'importance du flux de matières premières et des coûts de transport par kg. Les coûts de démolition sont indexés sur la moyenne de l'indice BDB des 18 dernières années. Les coûts de traitement et de manutention dépendent du matériau et sont déterminés sur la base d'entretiens et de recherches documentaires. Pour les coûts de transport, une distance de 150 km par transport de marchandises vers le transformateur a été supposée pour tous les matériaux, à l'exception des matériaux pierreux (20 km) et du bois (40 km).

## SOURCE
- LME (London Metal Exchange, Marché des métaux de Londres)
- Quandl 
- Vraagenaanbod.nl
- RVO
- BLS Beta Labs

## QUEL EST L'IMPACT DE L'INFLATION, DE L'INDICE BDB (INDICE DES COÛTS DE CONSTRUCTION ET DU TAUX D'ESCOMPTE SUR MES CALCULS ?
Leur influence peut être testée dans l'analyse de sensibilité présentée dans les pages détaillées. Vous pouvez ici ajuster l'inflation, l'indice BDB et le taux d'escompte. Les valeurs pour l'inflation et l'indice BDB sont des valeurs standard sur la moyenne des 18 dernières années. Pour le taux d'escompte, on prend le taux d'intérêt public à 10 ans (0,7 %), auquel on ajoute un certain nombre de risques (2 %) et de bénéfices (0,3 %).
