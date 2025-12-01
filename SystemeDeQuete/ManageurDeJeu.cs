using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemeDeQuete
{
    class ManageurDeJeu
    {
        private Personnage _personnage;
        private List<Quete> _quetes;


        public ManageurDeJeu(List<Quete> quetes)
        {
            _personnage = new Personnage();
            _quetes = quetes;
        }

        #region Méthodes Afficher
        public static void AfficherMenuDeChoix()
        {
            Console.WriteLine("1. Afficher les quêtes 📋");
            Console.WriteLine("2. Afficher les récompenses 🎁");
            Console.WriteLine("3. Afficher l'XP et l'or du personnage 🪙🧠");
            Console.WriteLine("4. Quitter ➡️🚪");
        }

        public void AfficherQuetes()
        {
            Console.WriteLine("Liste des quêtes disponibles :");
            foreach (var quete in _quetes)
            {
                Console.WriteLine($"- titre : {quete.AfficherTitre()}, description : {quete.AfficherDescription()}, importance : {quete.AfficherImportance()}, état : {quete.AfficherEvenement().AfficherEtat()} ");
            }
        }

        public void AfficherStatsDuPersonnage()
        {
            _personnage.AfficherXp();
            _personnage.AfficherOr();
        }

        #endregion

        public void GererChoixUtilisateur()
        {
            while (true)
            {
                var choix = Console.ReadLine();
                switch (choix)
                {
                    case "1":
                        AfficherQuetes();
                        break;
                    case "2":
                        _personnage.AfficherListeDeRecompense();
                        break;
                    case "3":
                        AfficherStatsDuPersonnage();
                        break;
                    case "4":
                        QuitterJeu();
                        break;
                    default:
                        Console.WriteLine("Choix invalide, veuillez réessayer.");
                        break;
                }
                AfficherMenuDeChoix();
            }
        }
        public static void QuitterJeu()
        {
            Console.WriteLine("Merci d'avoir joué !");
            Environment.Exit(0);
        }
    }
}
