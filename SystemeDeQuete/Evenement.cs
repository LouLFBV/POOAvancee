using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemeDeQuete
{
    class Evenement
    {
        bool _etat;
        List<Recompense> _recompense;

        public Evenement(bool etat, List<Recompense> recompense)
        {
            _recompense = recompense;
            _etat = etat;
        }

        public bool AfficherEtat()
        {
            return _etat;
        }

        public List<Recompense> AfficherRecompense()
        {
            return _recompense;
        }

        public void ModifierEtat(bool state)
        {
            _etat = state;
        }

        public void ModifierRecompense(List<Recompense> gifted)
        {
            _recompense = gifted;
        }
    }
}
