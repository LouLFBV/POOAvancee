using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Recompense : ITypeRecompense
{
    protected int _quantite;

    public Recompense(int quantite)
    {
        _quantite = quantite;
    }

    public int AfficherQuantite()
    {
        return _quantite;
    }

    public void ModifierQuantite(int quantite)
    {
        _quantite = quantite;
    }


    public abstract void AppliquerRecompense();
}