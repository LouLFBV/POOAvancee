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

        public override void VerifierCompletion(Personnage personnage)
        {
            int valeur = _rand.Next(0, 101);
            _evenement.ModifierEtat(valeur > 50);
            int voleurDOrChance = _rand.Next(0, 101);
            if (voleurDOrChance <= 50)
            {
                VolDOr(personnage);
            }
        }

        public void VolDOr(Personnage personnage)
        {
            if (personnage.ObtenirOr() < 30)
            {
                personnage.AjouterEnleverOr(-personnage.ObtenirOr());
                return;
            }
            personnage.AjouterEnleverOr(-30);
        }
    }
}
