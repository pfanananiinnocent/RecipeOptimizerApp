using RecipeOptimizerApp.Models;
using RecipeOptimizerApp.Interfaces;

namespace RecipeOptimizerApp.Services;

public class RecipeOptimizer : IRecipeOptimizer
{
    public List<(Recipe Recipe, int Times)> Optimize(Dictionary<string, Ingredient> ingredients, List<Recipe> recipes)
    {
        var result = new List<(Recipe, int)>();
        var sortedRecipes = recipes.OrderByDescending(r => r.Servings).ToList();

        foreach (var recipe in sortedRecipes)
        {
            int maxTimes = recipe.MaxTimesCanBeMade(ingredients);
            if (maxTimes == 0) continue;

            result.Add((recipe, maxTimes));

            foreach (var req in recipe.RequiredIngredients)
            {
                ingredients[req.Key].Quantity -= req.Value * maxTimes;
            }
        }

        return result;
    }
}
