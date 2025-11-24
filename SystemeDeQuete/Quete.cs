using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemeDeQuete
{
    class Quete
    {
<<<<<<< HEAD
        protected string _titre;
        protected string _description;
        protected Importance _importance;
        protected Evenement _evenement;
=======
        private string _titre;
        private string _description;
        private Importance _importance;
        private Evenement _evenement;
>>>>>>> origin/yarkin


        public Quete(string titre, string description, Importance importance, Evenement evenement)
        {
            _titre = titre;
            _description = description;
            _importance = importance;
            _evenement = evenement;
        }
        public void Test()
        {
            Log.Info("Démarrage OK");
            Log.Warn("Attention !");
            Log.Error("Une erreur est survenue");
            Console.WriteLine("Entrer un chiffre !");
            var chiffre = Console.ReadLine();
        }
    }
    public enum Importance
    {
        Principale,
        Secondaire,
        SousQuete
    }
}
