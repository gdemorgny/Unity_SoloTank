# Unity_SoloTank

## objectif

améliorer le jeu de tank avec les fonctionnalités suivantes :
- plusieurs scène à dificulté croissante
- persistance des informations du joueur entre les scènes : PV et munitions restantes
- utiliser des events pour mettre à jour la barre de vie et les munitions dans l'UI

en bonus :
- les tourelles pourront faire des dégats différents
- la vitesse du tank baisse en fonction de ses PV.

## base du projet

le projet fournit contient :
- un tank mobile
- des tourelles qui tirent sur le tank
- chaque bullet fait des dégats
- il y a une cadence de tir pour le tank et les tourelles

## Critère d'évaluation

- UI fonctionnelle avec events
- passage de scène fonctionnel, avec conservation des données et difficulté croissante
- utilisation pertinente des ScriptableObjects