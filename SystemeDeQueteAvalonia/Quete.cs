using System;

namespace SystemeDeQueteAvalonia
{
    public abstract class Quete
    {
        #region Champs
        protected static readonly Random _rand = new Random();
        private string _titre;
        private string _description;
        private Importance _importance;
        protected Evenement _evenement;
        #endregion

        #region Constructeur
        protected Quete(string titre, string description, Importance importance, Evenement evenement)
        {
            _titre = titre;
            _description = description;
            _importance = importance;
            _evenement = evenement;
        }
        #endregion

        #region Méthodes Afficher
        public string AfficherEtat()
        {
            return _evenement.ObtenirEtat() ? "complète" : "incomplète";
        }
        #endregion

        #region Méthodes Obtenir
        public string ObtenirTitre()
        {
            return _titre;
        }

        public string ObtenirDescription()
        {
            return _description;
        }

        public Importance ObtenirImportance()
        {
            return _importance;
        }

        public Evenement ObtenirEvenement()
        {
            return _evenement;
        }
        #endregion

        #region Méthodes Modifier
        public void ModifierTitre(string title)
        {
            _titre = title;
        }

        public void ModifierDescription(string descrip)
        {
            _description = descrip;
        }

        public void ModifierImportance(Importance important)
        {
            _importance = important;
        }
        #endregion

        #region Méthode Abstraite
        public abstract void VerifierCompletion(Personnage personnage);
        #endregion
    }

    public enum Importance
    {
        Principale,
        Secondaire
    }
}
