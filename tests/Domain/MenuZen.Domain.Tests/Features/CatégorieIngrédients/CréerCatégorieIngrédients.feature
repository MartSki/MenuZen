#language: fr
Fonctionnalité: CréerCatégorieIngrédients

Plan du scénario: Créer une catégorie d'ingrédients avec succès
	Etant donné un nom de catégorie d ingrédients '<NomCatégorieIngrédients>'
	Et une icône de catégorie d ingrédients '<IcôneCatégorieIngrédients>'
	Et une couleur de catégorie d ingrédients '<CouleurCatégorieIngrédients>'
	Quand je crée une catégorie d'ingrédients
	Alors la catégorie est crée avec succès
	Et le nom de la catégorie d ingrédients est '<NomCatégorieIngrédients>'
	Et l icône de catégorie d ingrédients est '<IcôneCatégorieIngrédients>'
	Et la couleur de catégorie d ingrédients est '<CouleurCatégorieIngrédients>'

	Exemples: 
	| NomCatégorieIngrédients | IcôneCatégorieIngrédients | CouleurCatégorieIngrédients |
	| Viandes                 | IconeViande               | Rouge                       |

Plan du scénario: Créer une catégorie d'ingrédients sans nom
	Etant donné une icône de catégorie d ingrédients '<IcôneCatégorieIngrédients>'
	Et une couleur de catégorie d ingrédients '<CouleurCatégorieIngrédients>'
	Quand je crée une catégorie d'ingrédients
	Alors la création de la catégorie d ingrédients est en erreur
	Et le code d erreur de la création de la catégorie d ingrédients est '<CodeErreur>'
	Et le message d erreur de la création de la catégorie d ingrédients est '<MessageErreur>'

	Exemples: 
	| CodeErreur               | MessageErreur       |
	| CatégorieIngrédients.Nom | Donnée obligatoire. |