namespace SystemeDeQuete
{
    public class Pomme : Recompense
    {
        public Pomme(int quantite) : base(quantite) { }

        public override void AppliquerRecompense()
        {
            Console.WriteLine($"Le joueur reçoit {_quantite} pomme(s) !");
        }
    }
}