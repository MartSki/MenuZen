using MartSki.Framework.Domain.ResultPattern.Models;

namespace MenuZen.Domain.Models;

public class Ingrédient
{
    private const int NOM_LONGUEUR_MAX = 50;

    public string Nom { get; init; }
    public string? Icône { get; init; }
    public CatégorieIngrédients CatégorieIngrédients { get; init; }

    private Ingrédient(string nom, string? icône, CatégorieIngrédients catégorieIngrédients)
    {
        Nom = nom;
        Icône = icône;
        CatégorieIngrédients = catégorieIngrédients;
    }

    private static Error[] ContrôlerRèglesMétier(string nom)
    {
        List<Error> errors = new();

        if (String.IsNullOrWhiteSpace(nom))
            errors.Add(new Error($"{nameof(Ingrédient)}.{nameof(Ingrédient.Nom)}", "Donnée obligatoire."));

        if (nom is not null && nom.Length > NOM_LONGUEUR_MAX)
            errors.Add(new Error($"{nameof(Ingrédient)}.{nameof(Ingrédient.Nom)}", $"La longueur maximale est de {NOM_LONGUEUR_MAX} caractères."));

        return errors.ToArray();
    }

    public static Result<Ingrédient> Create(string nom, string? icône, CatégorieIngrédients catégorieIngrédients)
    {
        Error[] errors = ContrôlerRèglesMétier(nom);

        if (errors.Length > 0)
            return Result<Ingrédient>.Failure(errors);

        return Result<Ingrédient>.Success(new Ingrédient(nom, icône, catégorieIngrédients));
    }
}
