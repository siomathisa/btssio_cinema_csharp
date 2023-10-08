using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------");
            //Création et Affichage objet monFilm
            Film monFilm = Film.getInstance(1982, "Science-Fiction", 1, ": L'action du film se situe à Los Angeles en 2019 et met en scène Rick Deckard (interprété par Harrison Ford), un ancien policier qui reprend du service pour traquer un groupe de réplicants, des androïdes créés à l'image de l'Homme, menés par l'énigmatique Roy Batty (interprété par Rutger Hauer).", "Blade Runner");
            Console.WriteLine(monFilm.ToString());
            Console.WriteLine("--------------------------------------------");
            //Création et Affichage objet monActeur
            Acteur monActeur = Acteur.getInstance(1942, 1, "Ford", "Harisson");
            Console.WriteLine(monActeur.ToString());
            Console.WriteLine("--------------------------------------------");
            //Création objet monCinéma
            Cinema monCinema = Cinema.getInstance();
            //Ajout des acteurs
            monCinema.setActeur(1942, 1, "Ford", "Harisson");
            monCinema.setActeur(1956, 2, "Hanks", "Tom");
            //Ajout des films
            monCinema.setFilm(1982, "Science-Fiction", 1, "L'action du film se situe à Los Angeles en 2019 et met en scène Rick Deckard (interprété par Harrison Ford), un ancien policier qui reprend du service pour traquer un groupe de réplicants, des androïdes créés à l'image de l'Homme, menés par l'énigmatique Roy Batty (interprété par Rutger Hauer).", "Blade Runner");
            monCinema.setFilm(1992, "Animation", 2, "Le film met en scène un groupe de jouets. Woody, une poupée représentant un cow-boy, et Buzz l'Éclair, une figurine d'astronaute, en sont les personnages principaux.", "Toy Story");
            //Affectation des acteurs principaux
            monCinema.getFilm(1).getActeur = monCinema.getActeur(1);
            monCinema.getFilm(2).getActeur = monCinema.getActeur(2);
            //Affichage des caractéristiques des films
            Console.WriteLine("1er Film : ");
            Console.WriteLine(monCinema.getFilm(1).ToString());
            Console.WriteLine("\n");
            Console.WriteLine("2ème Film : ");
            Console.WriteLine(monCinema.getFilm(2).ToString());
            Console.WriteLine("\n");
            //Affichage des acteurs principaux
            Console.WriteLine("Acteur prinipal de Blade Runner : ");
            Console.WriteLine(monCinema.getFilm(1).getActeurPrincipal().ToString());
            Console.WriteLine("\n");
            Console.WriteLine("Acteur prinipal de Toy Story : ");
            Console.WriteLine(monCinema.getFilm(2).getActeurPrincipal().ToString());



            Console.ReadKey();
        }
    }
}
