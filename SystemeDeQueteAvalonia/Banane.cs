using System;
namespace SystemeDeQuete
{
    public class Banane : Recompense
    {
        public Banane(TypeRecompense nom, int quantite) : base(nom, quantite) {}
        public override void AppliquerRecompense()
        {
            Console.WriteLine($"Le joueur reçoit {_quantite} banane(s) !");
        }
    }
}