using MartSki.Framework.Domain.ResultPattern.Models;

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

    public static Result<CatégorieIngrédients> Create(string nom, string? icône, string? couleur)
    {
        return Result<CatégorieIngrédients>.Success(new CatégorieIngrédients(nom, icône, couleur));
    }
}
