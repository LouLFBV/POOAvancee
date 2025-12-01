namespace SystemeDeQuete
{
    public class Xp : Recompense
    {
        public Xp(int quantite) : base(quantite) { }

        public override void AppliquerRecompense()
        {
            Console.WriteLine($"Le joueur reçoit {_quantite} Xp !");
        }
    }
}