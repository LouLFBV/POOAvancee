using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace SystemeDeQuete
{
    class Combat : Quete, IPerteDOr
    {
        private string _ennemies;

        public Combat(
            string titre,
            string description,
            Importance importance,
            Evenement evenement,
            string ennemies
        ) : base(titre, description, importance, evenement)
        {
            _ennemies = ennemies;
        }

        public string AfficherEnnemies()
        {
            return _ennemies;
        }

        public void ModifierEnnemies(string nouveauxEnnemies)
        {
            _ennemies = nouveauxEnnemies;
        }

        public void VolDOr(int montant)
        {
            Console.WriteLine($"Vous avez perdu {montant} pièces d'or !");
        }
    }
}
