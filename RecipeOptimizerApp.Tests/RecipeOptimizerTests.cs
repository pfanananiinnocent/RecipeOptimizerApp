using RecipeOptimizerApp.Models;
using RecipeOptimizerApp.Services;
using Xunit;

namespace RecipeOptimizerApp.Tests;

public class RecipeOptimizerTests
{
    [Fact]
    public void Optimize_ReturnsCorrectRecipeCombinations()
    {
        var ingredients = new Dictionary<string, Ingredient>
        {
            ["Meat"] = new Ingredient { Name = "Meat", Quantity = 4 },
            ["Cheese"] = new Ingredient { Name = "Cheese", Quantity = 4 },
            ["Tomato"] = new Ingredient { Name = "Tomato", Quantity = 3 },
            ["Dough"] = new Ingredient { Name = "Dough", Quantity = 4 }
        };

        var recipes = new List<Recipe>
        {
            new Recipe
            {
                Name = "Burger",
                Servings = 1,
                RequiredIngredients = new Dictionary<string, int>
                {
                    ["Meat"] = 1,
                    ["Cheese"] = 1,
                    ["Tomato"] = 1,
                    ["Dough"] = 1
                }
            },
            new Recipe
            {
                Name = "Pie",
                Servings = 1,
                RequiredIngredients = new Dictionary<string, int>
                {
                    ["Meat"] = 2,
                    ["Dough"] = 2
                }
            }
        };

        var optimizer = new RecipeOptimizer();
        var result = optimizer.Optimize(ingredients, recipes);

        Assert.True(result.Count > 0);
        Assert.Equal("Burger", result[0].Recipe.Name);
        Assert.Equal(3, result[0].Times); 
    }
}
