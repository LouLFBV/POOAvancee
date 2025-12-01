namespace SystemeDeQuete
{
    public class Pomme : Recompense
    {
        public Pomme(string nom, int quantite) : base(nom, quantite) { }

        public override void AppliquerRecompense()
        {
            Console.WriteLine($"Le joueur reçoit {_quantite} pomme(s) !");
        }
    }
}