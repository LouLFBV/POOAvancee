namespace SystemeDeQueteAvalonia.Recompenses
{
    public abstract class Recompense : ITypeRecompense
    {
        #region Champs
        protected TypeRecompense _nom;
        protected int _quantite;
        #endregion

        #region Constructeur
        public Recompense(TypeRecompense nom, int quantite)
        {
            _nom = nom;
            _quantite = quantite;
        }
        #endregion

        #region Méthodes Obtenir
        public TypeRecompense ObtenirNom()
        {
            return _nom;
        }
        public int ObtenirQuantite()
        {
            return _quantite;
        }
        #endregion

        #region Méthode Modifier
        public void ModifierQuantite(int quantite)
        {
            _quantite = quantite;
        }
        #endregion

        #region Méthode Appliquer Abstraite
        public abstract int AppliquerRecompense();
        #endregion
    }

    public enum TypeRecompense
    {
        Banane,
        Pomme,
        Or,
        Xp
    }
}
