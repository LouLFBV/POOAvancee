namespace SystemeDeQuete
{
    public class Pomme : Recompense
    {
        public Pomme(TypeRecompense nom, int quantite) : base(nom, quantite) { }

        public override int AppliquerRecompense()
        {
            Console.WriteLine($"Le joueur reçoit {_quantite} pomme(s) !");
            return _quantite;
        }
    }
}