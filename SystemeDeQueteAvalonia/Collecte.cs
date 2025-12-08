using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemeDeQuete
{
    class Collecte : Quete
    {
        private List<Recompense> _objetsACollecter;

        public Collecte(
            string titre,
            string description,
            Importance importance,
            Evenement evenement,
            List<Recompense> objetsACollecter
        ) : base(titre, description, importance, evenement)
        {
            _objetsACollecter = objetsACollecter;
        }
        public List<Recompense> ObtenirObjetsACollecter()
        {
            return _objetsACollecter;
        }

        public override void VerifierCompletion(Personnage personnage)
        {
            int valeur = _rand.Next(0, 101);
            _evenement.ModifierEtat(valeur > 60);
        }
        public void ModifierObjetsACollecter(List<Recompense> nouveauxObjets)
        {
            _objetsACollecter = nouveauxObjets;
        }
    }
}
