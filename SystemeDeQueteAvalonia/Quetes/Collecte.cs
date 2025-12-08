using SystemeDeQueteAvalonia.Recompenses;

namespace SystemeDeQueteAvalonia.Quetes
{
    class Collecte : Quete
    {
        #region Constructeur
        public Collecte(
            string titre,
            string description,
            Importance importance,
            Evenement evenement
        ) : base(titre, description, importance, evenement){}
        #endregion

        #region Méthodes VerifierCompletion
        public override void VerifierCompletion(Personnage personnage)
        {
            int valeur = _rand.Next(0, 101);
            _evenement.ModifierEtat(valeur > 60);
        }
        #endregion
    }
}
