using System;
using System.Collections.Generic;

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

        public Personnage ObtenirPersonnage()
        {
            return _personnage;
        }
        #region AFFICHAGE

        public static void AfficherMenuDeChoix()
        {
            Console.WriteLine("\n===== MENU PRINCIPAL =====");
            Console.WriteLine("1. Journal de quêtes 📋");
            Console.WriteLine("2. Récompenses 🎁");
            Console.WriteLine("3. Stats (XP / Or) 🧠🪙");
            Console.WriteLine("4. Partir à l'aventure 🚀");
            Console.WriteLine("5. Quitter ❌");
        }

        public void AfficherQuetes()
        {
            Console.WriteLine("\n--- Journal de quêtes ---");
            foreach (var q in _personnage.ObtenirListeDeQuete())
            {
                Console.ForegroundColor = q.ObtenirEvenement().ObtenirEtat() ? ConsoleColor.Green : ConsoleColor.Red;
                Console.WriteLine($"- {q.ObtenirTitre()} ({q.ObtenirImportance()}) → {q.AfficherEtat()}");
                Console.ResetColor();
            }
        }

        public void AfficherStatsDuPersonnage()
        {
            Console.WriteLine($"\nXP : {_personnage.ObtenirXp()} | Or : {_personnage.ObtenirOr()}");
        }

        public void AfficherLesRecompensesDuJoueur()
        {
            Console.WriteLine("\n--- Récompenses ---");
            foreach (var r in _personnage.ObtenirListeDeRecompense())
            {
                Console.WriteLine($"- {r.ObtenirNom()} : {r.ObtenirQuantite()}");
            }
        }

        #endregion

        #region AVENTURE

        private void ProposerTroisQuetes()
        {
            int nombreDeQuetes = Math.Min(3, _quetes.Count - _indexChemin);
            List<Quete> choix = new List<Quete>();

            Console.WriteLine("\n---- Choisissez votre quête ----");

            for (int i = 0; i < nombreDeQuetes; i++)
            {
                var q = _quetes[_indexChemin + i];
                choix.Add(q);
                _personnage.AjouterQuete(q);

                Console.WriteLine($"{i + 1}. {q.ObtenirTitre()} - {q.ObtenirDescription()}");
            }

            bool partieTerminee = GererChoixChemin(choix);

            if (partieTerminee)
                return;   // ✅ sort immédiatement vers le MENU PRINCIPAL

            _indexChemin += nombreDeQuetes;

        }

        private bool GererChoixChemin(List<Quete> choix)
        {
            while (true)
            {
                Console.Write("\nVotre choix : ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int index) &&
                    index >= 1 && index <= choix.Count)
                {
                    Quete q = choix[index - 1];
                    q.VerifierCompletion(_personnage);

                    // ⚔️ BOSS FINAL

                    bool aAssezDXpPourVaincreLeBoss =
                        _personnage.ObtenirXp() >= 200;
                    if (q.ObtenirImportance() == Importance.Principale)
                    {
                        if (aAssezDXpPourVaincreLeBoss)
                            Console.WriteLine("\n🏆 VOUS AVEZ VAINCU LE BOSS !");
                        else
                            Console.WriteLine("\n💀 VOUS ÊTES MORT FACE AU BOSS...");

                        ReinitialiserPartie();   // ✅ RESET COMPLET
                        return true;
                    }

                    if (q.ObtenirEvenement().ObtenirEtat())
                    {
                        Console.WriteLine("\n✅ Quête réussie !");
                        q.ObtenirEvenement().AfficherRecompenses();
                        _personnage.AjouterRecompenses(
                            q.ObtenirEvenement().ObtenirRecompense());
                    }
                    else
                    {
                        Console.WriteLine("\n❌ Échec de la quête !");
                    }
                    return false; // ✅ Fin de tour
                }

                Console.WriteLine("Choix invalide !");
            }
        }

        private void MenuAventure()
        {
            while (_indexChemin < _quetes.Count)
            {
                Console.Clear();
                Console.WriteLine("=== 🗺️ AVENTURE ===");
                Console.WriteLine("1. Choisir une quête");
                Console.WriteLine("2. Voir le journal de quêtes 📋");
                Console.WriteLine("3. Voir XP & Or 🧠🪙");
                Console.WriteLine("4. Voir les récompenses 🎁");
                Console.WriteLine("5. Retour au menu principal ⬅️");

                Console.Write("\nChoix : ");
                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        ProposerTroisQuetes();

                        if (_indexChemin == 0)   // ✅ signifie que FinDePartie a reset
                            return;              // ✅ RETOUR MENU PRINCIPAL
                        break;

                    case "2": AfficherQuetes(); break;
                    case "3": AfficherStatsDuPersonnage(); break;
                    case "4": AfficherLesRecompensesDuJoueur(); break;
                    case "5": return; // ✅ retour au menu principal
                    default: Console.WriteLine("Choix invalide."); break;
                }

                Console.WriteLine("\nEntrée pour continuer...");
                Console.ReadKey();
            }
        }

        #endregion

        #region RESET TOTAL

        public void ReinitialiserPartie()
        {
            _personnage.ReinitialiserPersonnage();
            _indexChemin = 0;

            foreach (var q in _quetes)
                q.ObtenirEvenement().ModifierEtat(false);
        }

        #endregion

        #region MENU

        public void GererChoixMenu()
        {
            while (true)
            {
                Console.Clear();
                AfficherMenuDeChoix();
                Console.Write("\nChoix : ");
                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1": AfficherQuetes(); break;
                    case "2": AfficherLesRecompensesDuJoueur(); break;
                    case "3": AfficherStatsDuPersonnage(); break;
                    case "4": MenuAventure(); break;   // ✅ NOUVEAU
                    case "5": QuitterJeu(); break;
                    default: Console.WriteLine("Choix invalide."); break;
                }

                Console.WriteLine("\nEntrée pour continuer...");
                Console.ReadKey();
            }
        }


        public static void QuitterJeu()
        {
            Console.WriteLine("Merci d'avoir joué !");
            Environment.Exit(0);
        }

        #endregion

        public List<Quete> ObtenirQuetesRestantes()
        {
            List<Quete> restantes = new List<Quete>();
            foreach (var q in _quetes)
            {
                if (!_personnage.ObtenirListeDeQuete().Contains(q) || !q.ObtenirEvenement().ObtenirEtat())
                {
                    restantes.Add(q);
                }
            }
            return restantes;
        }

        public void JouerQuete(Quete q)
        {
            if (!_personnage.ObtenirListeDeQuete().Contains(q))
                _personnage.AjouterQuete(q);

            q.VerifierCompletion(_personnage);
            if (q.ObtenirEvenement().ObtenirEtat())
                _personnage.AjouterRecompenses(q.ObtenirEvenement().ObtenirRecompense());
        }
    }
}
