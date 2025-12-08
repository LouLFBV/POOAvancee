using System.Collections.Generic;
using System.Linq;
using SystemeDeQueteAvalonia.Quetes;
using SystemeDeQueteAvalonia.Recompenses;

namespace SystemeDeQueteAvalonia
{
    public class Personnage
    {
        #region Champs
        private int _xpJoueur;
        private int _orJoueur;
        private List<Quete> _listeDeQuete;
        private List<Recompense> _listeDeRecompense;
        #endregion

        #region Constructeur
        public Personnage()
        {
            _xpJoueur = 0;
            _orJoueur = 0;
            _listeDeQuete = new List<Quete>();
            _listeDeRecompense = new List<Recompense>();
        }
        #endregion

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
                    AjouterEnleverXp(recompense.AppliquerRecompense());
                    continue;
                }

                if (recompense.ObtenirNom() == TypeRecompense.Or)
                {
                    AjouterEnleverOr(recompense.AppliquerRecompense());
                    continue;
                }

                var existante = _listeDeRecompense
                    .FirstOrDefault(r => r.ObtenirNom() == recompense.ObtenirNom());

                if (existante != null)
                {
                    existante.ModifierQuantite(
                        existante.ObtenirQuantite() + recompense.AppliquerRecompense());
                }
                else
                {
                    AjouterRecompense(recompense);
                }
            }
        }

        #endregion

        #region Méthode Réinitialiser
        public void ReinitialiserPersonnage()
        {
            _xpJoueur = 0;
            _orJoueur = 0;
            _listeDeQuete = new List<Quete>();
            _listeDeRecompense = new List<Recompense>(); ;
        }
        #endregion
    }
}
