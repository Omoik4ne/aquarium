using System;
using System.Collections.Generic;
using System.Text;

namespace Aquarium.Models
{
    class Laquarium
    {
        private List<Habitants> habitants = new List<Habitants>();

        private Random r = new Random();

    
        public void AjouterPoisson(string Nom, Genre Sexe)
        {
            //creer une instance de poisson
           
            Poisson nouveau = new Poisson();
            nouveau.Nom = Nom;
            nouveau.Sexe = Sexe;
            //ajouter l'instance quelque part
            habitants.Add(nouveau);
        }

        public void AjouterAlgue()
        {
            Algue nouveau = new Algue();
            //creer une instance d'algue
            //ajouter l'instance quelque part
            habitants.Add(nouveau);
        }

   
        public void ChaqueJour()
        {
            int alea = r.Next(0, habitants.Count);
           habitants.RemoveAt(alea);

            foreach (Habitants i in habitants)
            {
                if(i is Carnivore)
                {
                        //A completer
            }
         }
}

        public void Afficher()
        {
            int totalAlgues = 0;

            foreach (var i in habitants)
            {

                if (i is Algue)
                {
                    totalAlgues++;
                    Console.WriteLine($"Il y a {totalAlgues} algue(s) dans l'aquarium de Shingshan.");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        
        }
    }
}
