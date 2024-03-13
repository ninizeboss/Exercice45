/**
Créer un nouveau projet Exercice45.

Reprendre le programme de l’exercice 10 et intégrer la fonction de l’exercice 44.
Modifier le Main pour utiliser la fonction.
*/

using System;
using System.Net.Http.Headers;

namespace Exercice10
{
    class Program
    {
        static char saisie(string message, char car1, char car2)
        {
            char reponse;
            do
            {
                //Saisir d'un caractère parmi deux choix
                Console.Write("\n" + message + " (" + car1 + "/" + car2 + ") ");
                reponse = Console.ReadKey().KeyChar;
            } while (reponse != car1 && reponse != car2);
            return reponse;
        }
        static void Main(string[] args)
        {
            //sexe reçoit la réponse
            char sexe;
            string message = "Quel est votre sexe ?", monsieur = "Monsieur", madame = "Madame";
            char c1 = 'H', c2 = 'F';
        

            //Saisie de contrôle de réponse
            sexe = saisie(message, c1, c2);
            

            //Affichage du message correspondant
            if (sexe == c1)
            {
                Console.WriteLine("\nBonjour "+monsieur);
            }
            else
            {
                Console.WriteLine("\nBonjour "+madame);
            }
            Console.ReadLine();
        }

    }

}








