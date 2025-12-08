using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Collections.Generic;

namespace SystemeDeQueteAvalonia
{
    public partial class MainWindow : Window
    {
        #region Champs
        private Personnage _personnage;
        private List<Quete> _quetes;
        private int _indexChemin = 0;
        #endregion

        #region Constructeur
        public MainWindow()
        {
            InitializeComponent();
            InitialiserJeu();

            // Liaisons boutons
            btnAventure.Click += BtnAventure_Click;
            btnQuetes.Click += BtnQuetes_Click;
            btnStats.Click += BtnStats_Click;
            btnRecompenses.Click += BtnRecompenses_Click;
            btnQuitter.Click += (_, __) => Close();
        }
        #endregion

        #region Initialisation du jeu
        private void InitialiserJeu()
        {
            // Création du personnage
            _personnage = new Personnage();

            // Récompenses
            Banane banane = new(TypeRecompense.Banane, 5);
            Pomme pomme = new(TypeRecompense.Pomme, 3);
            Or or = new(TypeRecompense.Or, 100);
            Xp xp = new(TypeRecompense.Xp, 50);

            // Quêtes
            _quetes = new List<Quete>
            {
                new Collecte("Collecte de bananes", "Ramasser 10 bananes.", Importance.Secondaire,
                    new Evenement(new List<Recompense>{banane,xp})),

                new Exploration("Explorer la grotte", "Trouver la pièce secrète.", Importance.Secondaire,
                    new Evenement(new List<Recompense>{pomme,xp})),

                new Collecte("Cueillir des pommes", "Cueillir 5 pommes.", Importance.Secondaire,
                    new Evenement(new List<Recompense>{pomme,or})),

                new Exploration("Chercher des herbes", "Explorer pour trouver des herbes rares.", Importance.Secondaire,
                    new Evenement(new List<Recompense>{xp,or})),

                new Combat("Chasser le loup", "Éliminer le loup de la forêt.", Importance.Secondaire,
                    new Evenement(new List<Recompense>{or,xp})),

                new Collecte("Collecte de pierres", "Ramasser 3 pierres magiques.", Importance.Secondaire,
                    new Evenement(new List<Recompense>{or,xp})),

                new Exploration("Trouver le puits ancien", "Explorer les ruines.", Importance.Secondaire,
                    new Evenement(new List<Recompense>{xp,or})),

                new Combat("Combattre les bandits", "Défendre le village.", Importance.Secondaire,
                    new Evenement(new List<Recompense>{or,xp})),

                new Exploration(
                    "Explorer la forêt mystérieuse",
                    "Partez à la découverte d'une forêt remplie de secrets et d'énigmes.",
                    Importance.Secondaire,
                    new Evenement(new List<Recompense> { banane, pomme, xp })
                ),

                // Boss final
                new Combat("Affronter le Dragon Rouge", "Vaincre le Dragon Rouge.", Importance.Principale,
                    new Evenement(new List<Recompense>{or,xp,banane,pomme}))
            };
        }
        #endregion

        #region BOUTON AVENTURE : afficher 3 quêtes
        private void BtnAventure_Click(object? sender, RoutedEventArgs e)
        {
            logPanel.Children.Clear(); 
            ReinitialiserPartie();
            AppendLog("🌍 L'aventure commence !");
            AfficherTroisQuetes();
        }

        private void AfficherTroisQuetes()
        {
            questsPanel.Children.Clear();

            if (_indexChemin >= _quetes.Count)
            {
                AppendLog("🎉 Toutes les quêtes sont terminées !");
                ReinitialiserPartie();
                AppendLog("🔄 Nouvelle partie commencée !");
                return;
            }

            int nombreDeQuetes = Math.Min(3, _quetes.Count - _indexChemin);
            AppendLog("\n---- Choisissez votre quête ----");

            for (int i = 0; i < nombreDeQuetes; i++)
            {
                var q = _quetes[_indexChemin + i];
                if (!_personnage.ObtenirListeDeQuete().Contains(q) && q.ObtenirImportance() != Importance.Principale)
                    _personnage.AjouterQuete(q);

                var btn = new Button
                {
                    Content = $"{i + 1}. {q.ObtenirTitre()} - {q.ObtenirDescription()}",
                    Tag = q,
                    Margin = new Avalonia.Thickness(0, 6),
                    HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Stretch
                };
                btn.Click += BtnChoisirQuete;
                questsPanel.Children.Add(btn);
            }
        }

        private void BtnChoisirQuete(object? sender, RoutedEventArgs e)
        {
            if (sender is not Button btn || btn.Tag is not Quete q)
                return;

            bool boss = q.ObtenirImportance() == Importance.Principale;
            bool assezXp = _personnage.ObtenirXp() >= 100;


            int orAvant = _personnage.ObtenirOr();
            q.VerifierCompletion(_personnage);
            int orApres = _personnage.ObtenirOr();

            if (boss)
            {
                AppendLog(assezXp
                    ? "\n🏆 VOUS AVEZ VAINCU LE BOSS !"
                    : "\n💀 VOUS ÊTES MORT FACE AU BOSS...");
                _personnage.AjouterQuete(q);
                q.ObtenirEvenement().ModifierEtat(assezXp);
                questsPanel.Children.Clear();
                _indexChemin = 0;
                return;
            }

            if (orApres < orAvant)
            {
                AppendLog($"💸 Un voleur vous a volé {orAvant - orApres} pièces d'or lors de cette quête.", Avalonia.Media.Brushes.Orange);
            }

            if (q.ObtenirEvenement().ObtenirEtat())
            {
                AppendLog($"✅ Quête réussie : {q.ObtenirTitre()}", Avalonia.Media.Brushes.Green);
                var recompenses = q.ObtenirEvenement().ObtenirRecompense();
                foreach (var r in recompenses)
                    AppendLog($"  🎁 {r.ObtenirNom()} x{r.ObtenirQuantite()}");
                _personnage.AjouterRecompenses(recompenses);
            }
            else
            {
                AppendLog($"❌ Échec de la quête : {q.ObtenirTitre()}", Avalonia.Media.Brushes.Red);
            }

            // ✅ On avance l'index de 3 pour passer aux 3 prochaines quêtes
            _indexChemin += 3;

            AfficherTroisQuetes();
        }
        #endregion

        #region AUTRES BOUTONS
        private void BtnQuetes_Click(object? sender, RoutedEventArgs e)
        {

            AppendLog("📋 Journal de quêtes :");

            foreach (var q in _personnage.ObtenirListeDeQuete())
            {
                var couleur = q.ObtenirEvenement().ObtenirEtat()
                    ? Avalonia.Media.Brushes.Green   // Quête réussie
                    : Avalonia.Media.Brushes.Red;    // Quête incomplète

                AppendLog($"- {q.ObtenirTitre()} → {q.AfficherEtat()}, Quête {q.ObtenirImportance()}", couleur);
            }
        }


        private void BtnStats_Click(object? sender, RoutedEventArgs e)
        {
            AppendLog($"🧠 XP: {_personnage.ObtenirXp()} | 🪙 Or: {_personnage.ObtenirOr()}");
        }

        private void BtnRecompenses_Click(object? sender, RoutedEventArgs e)
        {
            AppendLog("🎁 Récompenses :");
            foreach (var r in _personnage.ObtenirListeDeRecompense())
                AppendLog($"- {r.ObtenirNom()} : {r.ObtenirQuantite()}");
        }
        #endregion

        #region LOG
        private void AppendLog(string message, Avalonia.Media.IBrush? couleur = null)
        {
            var texte = new TextBlock
            {
                Text = message,
                Foreground = couleur ?? Avalonia.Media.Brushes.White,
                TextWrapping = Avalonia.Media.TextWrapping.Wrap,
                Margin = new Avalonia.Thickness(0, 2)
            };

            logPanel.Children.Add(texte);

            // Scroll automatique vers le bas
            if (logPanel.Parent is ScrollViewer scroll)
            {
                scroll.Offset = new Avalonia.Vector(0, double.MaxValue);
            }
        }

        #endregion

        #region RESET TOTAL
        private void ReinitialiserPartie()
        {
            _personnage.ReinitialiserPersonnage();
            _indexChemin = 0;
            foreach (var q in _quetes)
                q.ObtenirEvenement().ModifierEtat(false);
        }
    }
    #endregion
}
