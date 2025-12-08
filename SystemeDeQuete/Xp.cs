namespace SystemeDeQuete
{
    public class Xp : Recompense
    {
        public Xp(TypeRecompense nom, int quantite) : base(nom, quantite) { }

        public override int AppliquerRecompense()
        {
            Console.WriteLine($"Le joueur reçoit {_quantite} Xp !");
            return _quantite;
        }
    }
}