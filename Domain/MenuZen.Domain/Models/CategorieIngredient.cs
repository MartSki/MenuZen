namespace MenuZen.Domain.Models;

public class CategorieIngredient
{
    public string Nom { get; init; }
    public string? Icone { get; init; }
    public string? Couleur { get; init; }

    private CategorieIngredient(string nom, string? icone, string? couleur)
    {
        Nom = nom;
        Icone = icone;
        Couleur = couleur;
    }

    public static CategorieIngredient Create(string nom, string? icone, string? couleur)
    {
        return new CategorieIngredient(nom, icone, couleur);
    }
}
