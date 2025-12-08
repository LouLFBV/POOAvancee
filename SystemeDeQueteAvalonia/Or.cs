using System;

namespace SystemeDeQueteAvalonia
{
    public class Or : Recompense
    {
        #region Constructeur
        public Or(TypeRecompense nom, int quantite) : base(nom, quantite) { }
        #endregion

        #region Méthodes Appliquer
        public override int AppliquerRecompense()
        {
            Console.WriteLine($"Le joueur reçoit {_quantite} pièce(s) d'or !");
            return _quantite;
        }
        #endregion
    }
}
    