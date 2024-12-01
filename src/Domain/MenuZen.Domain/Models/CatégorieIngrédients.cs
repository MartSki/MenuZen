namespace MenuZen.Domain.Models;

public class CatégorieIngrédients
{
    public string Nom { get; init; }
    public string? Icône { get; init; }
    public string? Couleur { get; init; }

    private CatégorieIngrédients(string nom, string? icône, string? couleur)
    {
        Nom = nom;
        Icône = icône;
        Couleur = couleur;
    }

    public static CatégorieIngrédients Create(string nom, string? icône, string? couleur)
    {
        return new CatégorieIngrédients(nom, icône, couleur);
    }
}
