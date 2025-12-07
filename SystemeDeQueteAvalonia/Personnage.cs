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

        #region Méthodes Obtenir

        public int ObtenirXp()
        {
            return _xpJoueur;
        }
        public int ObtenirOr()
        {
            return _orJoueur;
        }
        public List<Quete> ObtenirListeDeQuete()
        {
            return _listeDeQuete;
        }
        public List<Recompense> ObtenirListeDeRecompense()
        {
            return _listeDeRecompense;
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

        public void AjouterRecompenses(List<Recompense> recompenses)
        {
            foreach (var recompense in recompenses)
            {
                if (recompense.ObtenirNom() == TypeRecompense.Xp)
                {
                    AjouterEnleverXp(recompense.ObtenirQuantite());
                    continue;
                }

                if (recompense.ObtenirNom() == TypeRecompense.Or)
                {
                    AjouterEnleverOr(recompense.ObtenirQuantite());
                    continue;
                }

                var existante = _listeDeRecompense
                    .FirstOrDefault(r => r.ObtenirNom() == recompense.ObtenirNom());

                if (existante != null)
                {
                    existante.ModifierQuantite(
                        existante.ObtenirQuantite() + recompense.ObtenirQuantite());
                }
                else
                {
                    AjouterRecompense(recompense);
                }
            }
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

        public void ReinitialiserPersonnage()
        {
            _xpJoueur = 0;
            _orJoueur = 0;
            _listeDeQuete = new List<Quete>();
            _listeDeRecompense = new List<Recompense>(); ;
        }
    }
}
