

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

            // Création des récompenses
            Banane banane = new Banane(TypeRecompense.Banane, 5);
            Pomme pomme = new Pomme(TypeRecompense.Pomme, 3);
            Or or = new Or(TypeRecompense.Or, 100);
            Xp xp = new Xp(TypeRecompense.Xp, 50);

            List<Quete> quetes = new List<Quete>
            {
                new Collecte("Collecte de bananes", "Ramasser 10 bananes.", Importance.Secondaire,
                    new Evenement(new List<Recompense>{banane,xp}), new List<Recompense>{banane}),

                new Exploration("Explorer la grotte", "Trouver la pièce secrète.", Importance.Secondaire,
                    new Evenement(new List<Recompense>{pomme,xp}), "Pièce secrète"),

                new Collecte("Cueillir des pommes", "Cueillir 5 pommes.", Importance.Secondaire,
                    new Evenement(new List<Recompense>{pomme,or}), new List<Recompense>{pomme}),

                new Exploration("Chercher des herbes", "Explorer pour trouver des herbes rares.", Importance.Secondaire,
                    new Evenement(new List<Recompense>{xp,or}), "Herbier"),

                new Combat("Chasser le loup", "Éliminer le loup de la forêt.", Importance.Secondaire,
                    new Evenement(new List<Recompense>{or,xp}), "Loup noir"),

                new Collecte("Collecte de pierres", "Ramasser 3 pierres magiques.", Importance.Secondaire,
                    new Evenement(new List<Recompense>{or,xp}), new List<Recompense>{or}),

                new Exploration("Trouver le puits ancien", "Explorer les ruines.", Importance.Secondaire,
                    new Evenement(new List<Recompense>{xp,or}), "Puits ancien"),

                new Combat("Combattre les bandits", "Défendre le village.", Importance.Secondaire,
                    new Evenement(new List<Recompense>{or,xp}), "Chef des bandits"),

                new Exploration(
                    "Explorer la forêt mystérieuse",
                    "Partez à la découverte d'une forêt remplie de secrets et d'énigmes.",
                    Importance.Secondaire,
                    new Evenement(new List<Recompense> { banane, pomme, xp }),
                    "Forêt mystérieuse"
                ),

                // Boss final
                new Combat("Affronter le Dragon Rouge", "Vaincre le Dragon Rouge.", Importance.Principale,
                    new Evenement(new List<Recompense>{or,xp,banane,pomme}), "Dragon Rouge")
            };

            ManageurDeJeu manageur = new ManageurDeJeu(quetes);

            Console.WriteLine("## GESTIONNAIRE DE QUETE ##");
            manageur.GererChoixMenu();
        }
    }

}
