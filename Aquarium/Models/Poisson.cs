using System;
using System.Collections.Generic;
using System.Text;

namespace Aquarium.Models
{
    class Poisson : Habitants
    {
    /// <propriétés>
        public string Nom { get; set; }

       public Genre Sexe { get; set; }

        /// </propriétés>

        public virtual void Manger(Algue a, Poisson p)
        {

        }
        public override string ToString()
        {
            
            return $"Type: {GetType().Name} - Nom: {Nom} - Genre: {Sexe}";
        }

    }
}
