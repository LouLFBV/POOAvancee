

namespace SystemeDeQuete
{
    static class Log
    {
        public static void Info(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[INFO] {msg}");
            Console.ResetColor();
        }

        public static void Warn(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[WARN] {msg}");
            Console.ResetColor();
        }

        public static void Error(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[ERROR] {msg}");
            Console.ResetColor();
        }
    }

    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Log.Info("Démarrage OK");
            //Log.Warn("Attention !");
            //Log.Error("Une erreur est survenue");
            //Recompense recompense = new Recompense();
            //recompense.Test();


            Banane banane = new Banane(5);
            Pomme pomme = new Pomme(3);
            Or or = new Or(100);
            Xp xp = new Xp(50);

            List<Recompense> recompenses = new List<Recompense>();
            recompenses.Add(banane);
            recompenses.Add(pomme);
            recompenses.Add(or);
            recompenses.Add(xp);
            Evenement evenement1 = new Evenement(recompenses);

            List<Quete> quetes = new List<Quete>();
            Collecte quete = new Collecte("Collecte de banane", "Ramasser 10 bananes dans la jungle.", Importance.Secondaire, evenement1, new Banane(10));
            Exploration quete1 = new Exploration("Explorer la grotte", "Trouve la pièce secrète !", Importance.Secondaire, evenement1, "pièce secrète");
            Combat quete2 = new Combat("Vaincre le dragon", "Bats-toi contre le dragon pour sauver le village.", Importance.Principale, evenement1, "Dragon Rouge");
            quetes.Add(quete);
            quetes.Add(quete1);
            quetes.Add(quete2);

            ManageurDeJeu manageur = new ManageurDeJeu(quetes);

            Console.WriteLine("## GESTIONNAIRE DE QUETE ##");
            ManageurDeJeu.AfficherMenuDeChoix();
            manageur.GererChoixUtilisateur();
        }
    }

}
