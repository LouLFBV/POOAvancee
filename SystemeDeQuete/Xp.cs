namespace SystemeDeQuete
{
    public class Xp : Recompense
    {
        public Xp(TypeRecompense nom, int quantite) : base(nom, quantite) { }

        public override void AppliquerRecompense()
        {
            Console.WriteLine($"Le joueur reçoit {_quantite} Xp !");
        }
    }
}