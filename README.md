# Checkpoint2-AZ-171120

1) Branche "main" :
Challenge Base de Donneés
Création BDD + Tables + Jeu de test avec 3notes /élève

2) Branche "DAL"
Challenge DataAbstraction Layer
Attention : sur la méthode SelectStudentByLastName, il y a 2 codes
-> 1 qui marche et qui est moche car il store tous les étudiants dans une liste et le tri est fait en C#
-> celui qui fait la requête avec un paramère à la SGBD mais il ne marche pas, le reader est NULL (et fait chi..)

3) Branche "Joins_Aggregates"
Challenge Jointures & Agrégats
La classe Student est modifiée pour intégrer l'attribut Average
La requête a été testée et marche sur SGBD
Attention : la requête n'est pas bien envoyée à la SGBD par la DAL, même bug que challenge précédent (et re-m...)
