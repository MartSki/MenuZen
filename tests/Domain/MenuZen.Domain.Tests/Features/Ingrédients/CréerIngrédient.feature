#language: fr
Fonctionnalité: CréerIngrédient

Plan du scénario: Créer un ingrédient avec succès
	Etant donné un nom d ingrédient '<NomIngrédient>'
	Et une icône d ingrédient '<IcôneIngrédient>'
	Et une catégorie d ingrédients définie par :
	| NomCatégorieIngrédients | IcôneCatégorieIngrédients | CouleurCatégorieIngrédients |
	| Viandes                 | IconeViande               | Rouge                       |
	Quand je crée l'ingrédient
	Alors l ingrédient est crée avec succès
	Et le nom de l ingrédient est '<NomIngrédient>'
	Et l icône l ingrédient est '<IcôneIngrédient>'
	Et la catégorie d ingrédients est :
	| NomCatégorieIngrédients | IcôneCatégorieIngrédients | CouleurCatégorieIngrédients |
	| Viandes                 | IconeViande               | Rouge                       |

	Exemples: 
	| NomIngrédient | IcôneIngrédient |
	| Steak         | IconeSteak      |