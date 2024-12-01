using MartSki.Framework.Domain.ResultPattern.Models;

namespace MenuZen.Domain.Models;

public class CatégorieIngrédients
{
    private const int NOM_LONGUEUR_MAX = 50;

    public string Nom { get; init; }
    public string? Icône { get; init; }
    public string? Couleur { get; init; }

    private CatégorieIngrédients(string nom, string? icône, string? couleur)
    {
        Nom = nom;
        Icône = icône;
        Couleur = couleur;
    }

    private static Error[] ContrôlerRèglesMétier(string nom)
    {
        List<Error> errors = new();

        if (String.IsNullOrWhiteSpace(nom))
            errors.Add(new Error($"{nameof(CatégorieIngrédients)}.{nameof(CatégorieIngrédients.Nom)}", "Donnée obligatoire."));

        if (nom.Length > NOM_LONGUEUR_MAX)
            errors.Add(new Error($"{nameof(CatégorieIngrédients)}.{nameof(CatégorieIngrédients.Nom)}", $"La longueur maximale est de {NOM_LONGUEUR_MAX} caractères."));

        return errors.ToArray();
    }

    public static Result<CatégorieIngrédients> Create(string nom, string? icône, string? couleur)
    {
        Error[] errors = ContrôlerRèglesMétier(nom);

        if (errors.Length > 0)
            return Result<CatégorieIngrédients>.Failure(errors);

        return Result<CatégorieIngrédients>.Success(new CatégorieIngrédients(nom, icône, couleur));
    }
}
