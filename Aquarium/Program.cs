using Aquarium.Models;
using Aquarium.Models.Races;
using System.Collections.Generic;
using System;
using System.Threading;

namespace AquariumExo
{
    class Program
    {

        static Laquarium shingshan = new Laquarium();
        //aquarium valable pour tout le program et pas seulement dans methode Main();

        static void Main(string[] args)
        {

            //shingshan.AjouterPoisson("Maurice", Genre.male);
            //shingshan.AjouterPoisson("Nathalie", Genre.female);

            //shingshan.AjouterAlgue();


            while (true) // actions répétitives chaque jour
            {
                Console.Clear();
                shingshan.Afficher();
                Console.WriteLine("\nQue voulez-vous faire?");
                Console.WriteLine("1. Ajouter un poisson");
                Console.WriteLine("2. Ajouter une algue");
                Console.WriteLine("3. Passer au jour suivant");
                Console.WriteLine("4. Sauvegarder");
                Console.WriteLine("5. Quitter");

                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        Choix1();
                        break;
                    case "2":
                        Choix2();

                        break;
                    case "3":
                        Choix3();

                        break;
                    case "4":
                        Choix4();

                        break;
                    case "5":
                        Choix4();

                        break;
                }

            }
        }

        private static void Choix1()
        {
            string nomP= Question("Quel est le nom de votre poisson?");
            Genre genre;
            string sexeP = Question("Quel est le sexe de votre poisson?");
            while (!Enum.TryParse(sexeP, out genre))
            {
                sexeP = Question("Quel est le sexe de votre poisson?");
            }
            shingshan.AjouterPoisson(nomP,genre);
        }

        private static void Choix2()
        {
            shingshan.AjouterAlgue();
            Console.WriteLine("Vous avez ajouté une algue!");
            Thread.Sleep(1500);
        }

        private static void Choix3()
        {
            throw new NotImplementedException();
        }

        private static void Choix4()
        {
            throw new NotImplementedException();
        }
        private static string Question(string v)
        {
            Console.WriteLine(v);
            return Console.ReadLine();
        }
    }

}


