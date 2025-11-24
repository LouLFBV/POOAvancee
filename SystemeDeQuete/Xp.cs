public class Xp : Recompense
{
    public Xp(int quantite)
    {
        _quantite = quantite;
    }

    public void AppliquerRecompense()
    {
        Console.WriteLine($"Le joueur reçoit {Quantite} Xp !");
    }
}