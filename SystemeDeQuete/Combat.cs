using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace SystemeDeQuete
{
    class Combat(
        string titre,
        string description,
        Importance importance,
        Evenement evenement,
        string ennemies
        ) : Quete(titre, description, importance, evenement), IPerteDOr
    {
        public string AfficherEnnemies()
        {
            return ennemies;
        }

        public void ModifierEnnemies(string nouveauxEnnemies)
        {
            ennemies = nouveauxEnnemies;
        }

        public void VolDOr(int montant)
        {
            Console.WriteLine($"Vous avez perdu {montant} pièces d'or !");
        }
    }
}
