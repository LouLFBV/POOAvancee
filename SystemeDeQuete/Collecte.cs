using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemeDeQuete
{
    class Collecte : Quete
    {
        private string _objetsACollecter;

        public Collecte(
            string titre,
            string description,
            Importance importance,
            Evenement evenement,
            string objetsACollecter
        ) : base(titre, description, importance, evenement)
        {
            _objetsACollecter = objetsACollecter;
        }

        public string AfficherObjetsACollecter()
        {
            return _objetsACollecter;
        }

        public void ModifierObjetsACollecter(string nouveauxObjets)
        {
            _objetsACollecter = nouveauxObjets;
        }
    }
}
