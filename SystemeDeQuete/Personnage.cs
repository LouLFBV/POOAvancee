using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemeDeQuete
{
    class Personnage
    {
        private int _xpJoueur;
        private int _orJoueur;
        private List<Quete> _listeDeQuete;
        private List<Recompense> _listeDeRecompense;

        public Personnage()
        {
            _xpJoueur = 0;
            _orJoueur = 0;
            _listeDeQuete = new List<Quete>();
            _listeDeRecompense = new List<Recompense>();
        }

        #region Méthodes Afficher

        public void AfficherXp()
        {
            Console.WriteLine($"XP du joueur : {_xpJoueur}");
        }
        public void AfficherOr()
        {
            Console.WriteLine($"Or du joueur : {_orJoueur}");
        }
        public void AfficherListeDeQuete()
        {
            Console.WriteLine("Quêtes du joueur :");
            foreach (var quete in _listeDeQuete)
            {
                Console.WriteLine($"- {quete}");
            }
        }
        public void AfficherListeDeRecompense()
        {
            Console.WriteLine("Récompenses du joueur :");
            foreach (var recompense in _listeDeRecompense)
            {
                Console.WriteLine($"- {recompense}");
            }
        }

        #endregion

        #region Méthodes Ajouter/Enlever

        public void AjouterEnleverXp(int xp)
        {
            _xpJoueur += xp;
        }
        public void AjouterEnleverOr(int or)
        {
            _orJoueur += or;
        }
        public void AjouterQuete(Quete quete)
        {
            _listeDeQuete.Add(quete);
        }

        public void EnleverQuete(Quete quete)
        {
            _listeDeQuete.Remove(quete);
        }
        public void AjouterRecompense(Recompense recompense)
        {
            _listeDeRecompense.Add(recompense);
        }

        public void EnleverRecompense(Recompense recompense)
        {
            _listeDeRecompense.Remove(recompense);
        }


        #endregion

        #region Méthodes Modifier

        public void ModifierXp(int xp)
        {
            _xpJoueur = xp;
        }
        public void ModifierOr(int or)
        {
            _orJoueur = or;
        }
        public void ModifierQuete(List<Quete> quete)
        {
            _listeDeQuete = quete;
        }
        public void ModifierRecompense(List<Recompense> recompense)
        {
            _listeDeRecompense = recompense;
        }

        #endregion


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
