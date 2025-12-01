using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemeDeQuete
{
    public abstract class Quete
    {
        private string _titre;
        private string _description;
        private Importance _importance;
        private Evenement _evenement;

        protected Quete(string titre, string description, Importance importance, Evenement evenement)
        {
            _titre = titre;
            _description = description;
            _importance = importance;
            _evenement = evenement;
        }

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
        public string AfficherEtat()
        {
            return _evenement.ObtenirEtat() ? "complète" : "incomplète";
        }

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
    }
    public enum Importance
    {
        Principale,
        Secondaire,
        SousQuete
    }
}
