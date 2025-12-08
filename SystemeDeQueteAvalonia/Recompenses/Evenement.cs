using System.Collections.Generic;

namespace SystemeDeQueteAvalonia.Recompenses
{
    public class Evenement
    {
        #region Champs
        private bool _etat;
        private List<Recompense> _recompense;
        #endregion

        #region Constructeur
        public Evenement(List<Recompense> recompense)
        {
            _recompense = recompense;
            _etat = false;
        }
        #endregion

        #region Méthodes Obtenir
        public bool ObtenirEtat()
        {
            return _etat;
        }

        public List<Recompense> ObtenirRecompense()
        {
            return _recompense;
        }
        #endregion

        #region Méthode Modifier
        public void ModifierEtat(bool state)
        {
            _etat = state;
        }
        #endregion
    }
}
