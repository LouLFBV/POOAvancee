namespace SystemeDeQueteAvalonia
{
    class Combat : Quete, IPerteDOr
    {
        #region Constructeur
        public Combat(
            string titre,
            string description,
            Importance importance,
            Evenement evenement
        ) : base(titre, description, importance, evenement) { }
        #endregion

        #region Méthodes
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
        #endregion
    }
}
