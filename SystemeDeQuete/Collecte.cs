using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemeDeQuete
{
    class Collecte(
        string titre,
        string description,
        Importance importance,
        Evenement evenement,
        Recompense objetsACollecter
        ) : Quete(titre, description, importance, evenement)
    {
        public Recompense ObtenirObjetsACollecter()
        {
            return objetsACollecter;
        }

        public override void VerifierCompletion()
        {
            int valeur = _rand.Next(0, 101);
            _evenement.ModifierEtat(valeur > 60);
        }
        public void ModifierObjetsACollecter(Recompense nouveauxObjets)
        {
            objetsACollecter = nouveauxObjets;
        }
    }
}
