using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemeDeQuete
{
    class Exploration : Quete, IPerteDOr
    {
        public Exploration(string titre, string description, Importance importance, Evenement evenement) : base(titre, description, importance, evenement)
        {
            _titre = titre;
            _description = description;
            _importance = importance;
            _evenement = evenement;
        }

        public void VolDOr(int montant)
        {
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
}
