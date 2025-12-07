using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Recompense : ITypeRecompense
{
    protected TypeRecompense _nom;
    protected int _quantite;

    public Recompense(TypeRecompense nom, int quantite)
    {
        _nom = nom;
        _quantite = quantite;
    }

    public void AfficherDetails()
    {
        Console.WriteLine($"- {_nom}, Quantité: {_quantite}");
    }
    public TypeRecompense ObtenirNom()
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

public enum TypeRecompense
{
    Banane,
    Pomme,
    Or,
    Xp
}