using MenuZen.Domain.Models;

namespace MenuZen.Domain.Tests.StepDefinitions;

[Binding]
public class CréerCatégorieIngrédientsStepDefinitions
{
    private string _nom = string.Empty;
    private string? _icone;
    private string? _couleur;
    private CategorieIngredient _categorieIngredient;

    [Given("un nom de catégorie d ingrédients {string}")]
    public void GivenUnNomDeCategorieDIngredients(string nom)
    {
        _nom = nom;
    }

    [Given("une icône de catégorie d ingrédients {string}")]
    public void GivenUneIconeDeCategorieDIngredients(string icone)
    {
        _icone = icone;
    }

    [Given("une couleur de catégorie d ingrédients {string}")]
    public void GivenUneCouleurDeCategorieDIngredients(string couleur)
    {
        _couleur = couleur;
    }

    [When("je crée une catégorie d'ingrédients")]
    public void WhenJeCreeUneCategorieDingredients()
    {
        _categorieIngredient = CategorieIngredient.Create(_nom, _icone, _couleur);
    }

    [Then("la catégorie est crée avec succès")]
    public void ThenLaCategorieEstCreeAvecSucces()
    {
        _categorieIngredient.Should().NotBeNull();
    }

    [Then("le nom de la catégorie d ingrédients est {string}")]
    public void ThenLeNomDeLaCategorieDIngredientsEst(string nom)
    {
        _categorieIngredient.Nom.Should().Be(nom);
    }

    [Then("l icône de catégorie d ingrédients est {string}")]
    public void ThenLIconeDeCategorieDIngredientsEst(string icône)
    {
        _categorieIngredient.Icone.Should().Be(icône);
    }

    [Then("la couleur de catégorie d ingrédients est {string}")]
    public void ThenLaCouleurDeCategorieDIngredientsEst(string couleur)
    {
        _categorieIngredient.Couleur.Should().Be(couleur);
    }
}
