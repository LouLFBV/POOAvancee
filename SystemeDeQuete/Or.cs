namespace SystemeDeQuete
{
    public class Or : Recompense
    {
        public Or(TypeRecompense nom, int quantite) : base(nom, quantite) { }

        public override int AppliquerRecompense()
        {
            Console.WriteLine($"Le joueur reçoit {_quantite} pièce(s) d'or !");
            return _quantite;
        }
    }
}
    