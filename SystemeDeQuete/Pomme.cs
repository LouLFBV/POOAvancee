public class Pomme : Recompense
{
    public Pomme(int quantite)
    {
        _quantite = quantite;
    }

    public void AppliquerRecompense()
    {
        Console.WriteLine($"Le joueur reçoit {Quantite} pomme(s) !");
    }
}