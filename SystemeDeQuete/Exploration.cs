using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemeDeQuete
{
    class Exploration : Quete, IPerteDOr
    {
        private string _lieuATrouver;

        public Exploration(
            string titre,
            string description,
            Importance importance,
            Evenement evenement,
            string lieuATrouver
        ) : base(titre, description, importance, evenement)
        {
            _lieuATrouver = lieuATrouver;
        }

        public string ObtenirLieuATrouver()
        {
            return _lieuATrouver;
        }

        public void ModifierLieuATrouver(string nouveauLieu)
        {
            _lieuATrouver = nouveauLieu;
        }

        public void VolDOr(int montant)
        {
            Console.WriteLine($"Vous avez perdu {montant} pièces d'or !");
        }
    }
}
