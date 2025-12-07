using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemeDeQuete
{
    public class Evenement
    {
        private bool _etat;
        private List<Recompense> _recompense;
        public Evenement(List<Recompense> recompense)
        {
            _recompense = recompense;
            _etat = false;
        }

        public void AfficherRecompenses()
        {
            Console.WriteLine("Récompenses obtenues :");
            foreach (var recompense in _recompense)
            {
                recompense.AfficherDetails();
            }
        }
        public bool ObtenirEtat()
        {
            return _etat;
        }

        public List<Recompense> ObtenirRecompense()
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
