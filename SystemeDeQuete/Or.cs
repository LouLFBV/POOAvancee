namespace SystemeDeQuete
{
    public class Or : Recompense
    {
        public Or(string nom, int quantite) : base(nom, quantite) { }

        public override void AppliquerRecompense()
        {
            Console.WriteLine($"Le joueur reçoit {_quantite} Or !");
        }
    }
}
    