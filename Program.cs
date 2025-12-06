using System;

class Program
{
    static void Main()
    {
        // Demande à l'utilisateur d'entrer un nombre
        Console.Write("Entrez un nombre : ");

        // Convertit la saisie (texte) en entier
        int n = int.Parse(Console.ReadLine());

        // Boucle de 1 à 10 pour afficher la table
        for (int i = 1; i <= 10; i++)
        {
            // Affiche chaque ligne de la table
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }
}