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


        public override void VerifierCompletion()
        {
            int valeur = _rand.Next(0, 101);
            _evenement.ModifierEtat(valeur > 50);              
        }

        public void VolDOr(int montant)
        {
            Console.WriteLine($"Vous avez perdu {montant} pièces d'or !");
        }
    }
}
