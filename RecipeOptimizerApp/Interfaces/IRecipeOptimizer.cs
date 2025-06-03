using RecipeOptimizerApp.Models;

namespace RecipeOptimizerApp.Interfaces;

public interface IRecipeOptimizer
{
    List<(Recipe Recipe, int Times)> Optimize(Dictionary<string, Ingredient> ingredients, List<Recipe> recipes);
}
