using System;

namespace SystemeDeQueteAvalonia.Recompenses
{
    public class Xp : Recompense
    {
        #region Constructeur
        public Xp(TypeRecompense nom, int quantite) : base(nom, quantite) { }
        #endregion

        #region Méthodes Appliquer
        public override int AppliquerRecompense()
        {
            Console.WriteLine($"Le joueur reçoit {_quantite} Xp !");
            return _quantite;
        }
        #endregion
    }
}