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
            Console.WriteLine("2. Afficher les récompenses du joueur 🎁");
            Console.WriteLine("3. Afficher l'XP et l'or du personnage 🪙🧠");
            Console.WriteLine("4. Quitter ➡️🚪");
        }

        public void AfficherQuetes()
        {
            Console.WriteLine("Liste des quêtes disponibles :");
            foreach (var quete in _personnage.ObtenirListeDeQuete())
            {
                Console.WriteLine($"- titre : {quete.ObtenirTitre()}, description : {quete.ObtenirDescription()}, importance : {quete.ObtenirImportance()}, état : {quete.AfficherEtat()} ");
            }
        }

        public void AfficherStatsDuPersonnage()
        {
            Console.WriteLine($"Xp du joueur : {_personnage.ObtenirXp()}");
            Console.WriteLine($"Or du joueur : {_personnage.ObtenirOr()}");
        }

        public void AfficherLesRecompensesDuJoueur()
        {
            Console.WriteLine("Récompenses du joueur :");
            foreach (var recompense in _personnage.ObtenirListeDeRecompense())
            {
                Console.WriteLine($"- {recompense.ObtenirNom()} : {recompense.ObtenirQuantite()}");
            }
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
                        AfficherLesRecompensesDuJoueur();
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
