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

        public string AfficherTitre()
        {
            return _titre;
        }

        public string AfficherDescription()
        {
            return _description;
        }

        public Importance AfficherImportance()
        {
            return _importance;
        }

        public Evenement AfficherEvenement()
        {
            return _evenement;
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
