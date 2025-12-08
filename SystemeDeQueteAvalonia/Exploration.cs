namespace SystemeDeQueteAvalonia
{
    class Exploration : Quete, IPerteDOr
    {
        #region Constructeur
        public Exploration(
            string titre,
            string description,
            Importance importance,
            Evenement evenement
        ) : base(titre, description, importance, evenement){}
        #endregion

        #region Méthodes
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
        #endregion
    }
}
