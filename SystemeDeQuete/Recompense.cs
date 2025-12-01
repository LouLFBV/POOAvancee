using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Recompense : ITypeRecompense
{
    protected string _nom;
    protected int _quantite;

    public Recompense(string nom, int quantite)
    {
        _nom = nom;
        _quantite = quantite;
    }

    public void AfficherDetails()
    {
        Console.WriteLine($"- {_nom}, Quantité: {_quantite}");
    }
    public string ObtenirNom()
    {
        return _nom;
    }
    public int ObtenirQuantite()
    {
        return _quantite;
    }

    public void ModifierQuantite(int quantite)
    {
        _quantite = quantite;
    }


    public abstract void AppliquerRecompense();
}