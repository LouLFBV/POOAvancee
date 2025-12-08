using System;
namespace SystemeDeQueteAvalonia
{
    public class Banane : Recompense
    {
        #region Constructeur
        public Banane(TypeRecompense nom, int quantite) : base(nom, quantite) {}
        #endregion

        #region Méthodes Appliquer
        public override int AppliquerRecompense()
        {
            Console.WriteLine($"Le joueur reçoit {_quantite} banane(s) !");
            return _quantite;
        }
        #endregion
    }
}