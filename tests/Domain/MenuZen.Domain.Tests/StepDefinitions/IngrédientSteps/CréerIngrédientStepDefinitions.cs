using MartSki.Framework.Domain.ResultPattern.Models;
using MenuZen.Domain.Models;

namespace MenuZen.Domain.Tests.StepDefinitions.IngrédientSteps
{
    [Binding]
    public class CréerIngrédientStepDefinitions
    {
        private string _nom;
        private string _icône;
        private CatégorieIngrédients _catégorieIngrédients;
        private Result<Ingrédient> _ingrédient;

        [Given("un nom d ingrédient {string}")]
        public void GivenUnNomDIngredient(string nom)
        {
            _nom = nom;
        }

        [Given("une icône d ingrédient {string}")]
        public void GivenUneIconeDIngredient(string icône)
        {
            _icône = icône;
        }

        [Given("une catégorie d ingrédients définie par :")]
        public void GivenUneCategorieDIngredientsDefiniePar(DataTable catégorieIngrédientsTable)
        {
            DataTableRow categorieIngrédients = catégorieIngrédientsTable.Rows[0];

            _catégorieIngrédients = CatégorieIngrédients.Create(categorieIngrédients["NomCatégorieIngrédients"],
                                                                categorieIngrédients["IcôneCatégorieIngrédients"],
                                                                categorieIngrédients["CouleurCatégorieIngrédients"]).Value;
        }

        [When("je crée l'ingrédient")]
        public void WhenJeCreeLingredient()
        {
            _ingrédient = Ingrédient.Create(_nom, _icône, _catégorieIngrédients);
        }

        [Then("l ingrédient est crée avec succès")]
        public void ThenLIngredientEstCreeAvecSucces()
        {
            _ingrédient.Should().NotBeNull();
            _ingrédient.IsSuccess.Should().BeTrue();
            _ingrédient.IsFailure.Should().BeFalse();
            _ingrédient.Value.Should().NotBeNull();
        }

        [Then("le nom de l ingrédient est {string}")]
        public void ThenLeNomDeLIngredientEst(string nom)
        {
            _ingrédient.Value.Nom.Should().Be(nom);
        }

        [Then("l icône l ingrédient est {string}")]
        public void ThenLIconeLIngredientEst(string icône)
        {
            _ingrédient.Value.Icône.Should().Be(icône);
        }

        [Then("la catégorie d ingrédients est :")]
        public void ThenLaCategorieDIngredientsEst(DataTable catégorieIngrédientsTable)
        {
            DataTableRow categorieIngrédients = catégorieIngrédientsTable.Rows[0];

            _catégorieIngrédients = CatégorieIngrédients.Create(categorieIngrédients["NomCatégorieIngrédients"],
                                                                categorieIngrédients["IcôneCatégorieIngrédients"],
                                                                categorieIngrédients["CouleurCatégorieIngrédients"]).Value;

            _ingrédient.Value.CatégorieIngrédients.Should().BeEquivalentTo(_catégorieIngrédients);
        }
    }
}
