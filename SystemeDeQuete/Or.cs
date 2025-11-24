public class Or : Recompense
{
    public Or(int quantite)
    {
        _quantite = quantite;
    }

    public void AppliquerRecompense()
    {
        Console.WriteLine($"Le joueur reçoit {Quantite} Or !");
    }
}