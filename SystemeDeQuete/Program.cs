

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
            ManageurDeJeu manageur = new ManageurDeJeu(new List<Quete>());

            Console.WriteLine("## GESTIONNAIRE DE QUETE ##");
            manageur.AfficherMenuDeChoix();
            manageur.GererChoixUtilisateur();
        }
    }

}
