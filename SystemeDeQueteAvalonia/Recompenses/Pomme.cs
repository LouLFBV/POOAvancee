using System;

namespace SystemeDeQueteAvalonia.Recompenses
{
    public class Pomme : Recompense
    {
        #region Constructeur
        public Pomme(TypeRecompense nom, int quantite) : base(nom, quantite) { }
        #endregion

        #region Méthodes Appliquer
        public override int AppliquerRecompense()
        {
            Console.WriteLine($"Le joueur reçoit {_quantite} pomme(s) !");
            return _quantite;
        }
        #endregion
    }
}