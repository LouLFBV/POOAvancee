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
        private int _indexChemin;
        public ManageurDeJeu(List<Quete> quetes)
        {
            _personnage = new Personnage();
            _quetes = quetes;
            _indexChemin = 0;
        }

        #region Méthodes Afficher
        public static void AfficherMenuDeChoix()
        {
            Console.WriteLine("1. Afficher le journal de quêtes 📋");
            Console.WriteLine("2. Afficher les récompenses du joueur 🎁");
            Console.WriteLine("3. Afficher l'XP et l'or du personnage 🪙🧠");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("4. Patir à l'aventure ! 🚀");

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("5. Quitter ➡️🚪");
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

        public void AfficherLesCheminsProposés()
        {
            Console.WriteLine("Chemins proposés :");
            for (int i = _indexChemin; i <= _indexChemin + 3; i++)
            {
                Log.Info("Démarrage OK");
                Console.WriteLine($"{i + 1}. {_quetes[i].ObtenirTitre()} - {_quetes[i].ObtenirDescription()}");
            }
            GererChoixChemin(_quetes[_indexChemin], _quetes[_indexChemin + 1], _quetes[_indexChemin + 2]);
        }

        #endregion

        public void GererChoixMenu()
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
                        AfficherLesCheminsProposés();
                        break;
                    case "5":
                        QuitterJeu();
                        break;
                    default:
                        Console.WriteLine("Choix invalide, veuillez réessayer.");
                        break;
                }
                AfficherMenuDeChoix();
            }
        }

        public void GererChoixChemin(Quete quete1, Quete quete2, Quete quete3)
        {
            while (true)
            {
                var choix = Console.ReadLine();
                switch (choix)
                {
                    case "1":
                        quete1.VerifierCompletion();
                        if (quete1.ObtenirEvenement().ObtenirEtat())
                        {
                            Console.WriteLine("Quête complétée ! Vous venez d'obtenir :\n");
                            quete1.ObtenirEvenement().AfficherRecompenses();
                        }
                        else
                            Console.WriteLine("Quête imcomplétée !");
                        break;
                    case "2":
                        quete2.VerifierCompletion();
                        if (quete2.ObtenirEvenement().ObtenirEtat())
                        {
                            Console.WriteLine("Quête complétée ! Vous venez d'obtenir :\n");
                            quete2.ObtenirEvenement().AfficherRecompenses();
                        }
                        else
                            Console.WriteLine("Quête imcomplétée !");
                        break;
                    case "3":
                        quete3.VerifierCompletion();
                        if (quete3.ObtenirEvenement().ObtenirEtat())
                        {
                            Console.WriteLine("Quête complétée ! Vous venez d'obtenir :\n");
                            quete3.ObtenirEvenement().AfficherRecompenses();
                        }
                        else
                            Console.WriteLine("Quête imcomplétée !");
                        break;
                    default:
                        Console.WriteLine("Choix invalide, veuillez réessayer.");
                        break;
                }
            }
        }
        public static void QuitterJeu()
        {
            Console.WriteLine("Merci d'avoir joué !");
            Environment.Exit(0);
        }
    }
}
