namespace SystemeDeQuete
{
    public class Banane : Recompense
    {
        public Banane(int quantite):base(quantite){}
        public override void AppliquerRecompense()
        {
            Console.WriteLine($"Le joueur reçoit {_quantite} banane(s) !");
        }
    }
}