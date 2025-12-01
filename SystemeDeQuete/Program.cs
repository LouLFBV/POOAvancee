

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


            Banane banane = new Banane(TypeRecompense.Banane, 5);
            Pomme pomme = new Pomme(TypeRecompense.Pomme, 3);
            Or or = new Or(TypeRecompense.Or, 100);
            Xp xp = new Xp(TypeRecompense.Xp, 50);

            // EVENEMENT 1 
            List<Recompense> recompenses1 = new List<Recompense>();
            recompenses1.Add(banane);
            recompenses1.Add(pomme);
            recompenses1.Add(or);
            recompenses1.Add(xp);
            Evenement evenement1 = new Evenement(recompenses1);

            // EVENEMENT 2
            List<Recompense> recompenses2 = new List<Recompense>();
            recompenses2.Add(banane);
            recompenses2.Add(pomme);
            recompenses2.Add(or);
            recompenses2.Add(xp);
            Evenement evenement2 = new Evenement(recompenses2);

            // EVENEMENT 1 
            List<Recompense> recompenses3 = new List<Recompense>();
            recompenses3.Add(banane);
            recompenses3.Add(pomme);
            recompenses3.Add(or);
            recompenses3.Add(xp);
            Evenement evenement3 = new Evenement(recompenses3);

            List<Quete> quetes = new List<Quete>();
            Collecte quete = new Collecte("Collecte de banane", "Ramasser 10 bananes dans la jungle.", Importance.Secondaire, evenement1, recompenses1);
            Exploration quete1 = new Exploration("Explorer la grotte", "Trouve la pièce secrète !", Importance.Secondaire, evenement2, "pièce secrète");
            Combat quete2 = new Combat("Vaincre le dragon", "Bats-toi contre le dragon pour sauver le village.", Importance.Principale, evenement3, "Dragon Rouge");
            quetes.Add(quete);
            quetes.Add(quete1);
            quetes.Add(quete2);

            ManageurDeJeu manageur = new ManageurDeJeu(quetes);

            Console.WriteLine("## GESTIONNAIRE DE QUETE ##");
            ManageurDeJeu.AfficherMenuDeChoix();
            manageur.GererChoixMenu();
        }
    }

}
