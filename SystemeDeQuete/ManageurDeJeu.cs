using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemeDeQuete
{
    class ManageurDeJeu
    {
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
