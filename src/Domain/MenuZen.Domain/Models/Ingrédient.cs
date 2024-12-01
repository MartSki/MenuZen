using MartSki.Framework.Domain.ResultPattern.Models;

namespace MenuZen.Domain.Models;

public class Ingrédient
{
    public string Nom { get; init; }
    public string? Icône { get; init; }
    public CatégorieIngrédients CatégorieIngrédients { get; init; }

    private Ingrédient(string nom, string? icône, CatégorieIngrédients catégorieIngrédients)
    {
        Nom = nom;
        Icône = icône;
        CatégorieIngrédients = catégorieIngrédients;
    }

    public static Result<Ingrédient> Create(string nom, string? icône, CatégorieIngrédients catégorieIngrédients)
    {
        return Result<Ingrédient>.Success(new Ingrédient(nom, icône, catégorieIngrédients));
    }
}
