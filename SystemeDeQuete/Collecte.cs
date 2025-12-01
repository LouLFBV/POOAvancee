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
        public Recompense AfficherObjetsACollecter()
        {
            return objetsACollecter;
        }

        public void ModifierObjetsACollecter(Recompense nouveauxObjets)
        {
            objetsACollecter = nouveauxObjets;
        }
    }
}
