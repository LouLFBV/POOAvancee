namespace SystemeDeQuete
{
    public class Or : Recompense
    {
        public Or(int quantite) : base(quantite) { }

        public override void AppliquerRecompense()
        {
            Console.WriteLine($"Le joueur reçoit {_quantite} Or !");
        }
    }
}
    