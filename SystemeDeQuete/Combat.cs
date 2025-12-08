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
        public string ObtenirEnnemies()
        {
            return ennemies;
        }

        public void ModifierEnnemies(string nouveauxEnnemies)
        {
            ennemies = nouveauxEnnemies;
        }
        public override void VerifierCompletion(Personnage personnage)
        {
            int valeur = _rand.Next(0, 101);
            _evenement.ModifierEtat(valeur > 40);

            int voleurDOrChance = _rand.Next(0, 101);
            if (voleurDOrChance < 30)
            {
                VolDOr(personnage);
            }
        }

        public void VolDOr(Personnage personnage)
        {
            if (personnage.ObtenirOr() < 50)
            {
                personnage.AjouterEnleverOr(-personnage.ObtenirOr());
                return;
            }
            personnage.AjouterEnleverOr(-50);
        }
    }
}
