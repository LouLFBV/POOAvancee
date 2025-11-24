public class Banane : Recompense
{
    public Banane(int quantite)
    {
        _quantite = quantite;
    }

    public void AppliquerRecompense()
    {
        Console.WriteLine($"Le joueur reçoit {Quantite} banane(s) !");
    }
}