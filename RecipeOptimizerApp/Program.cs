using RecipeOptimizerApp.Models;
using RecipeOptimizerApp.Services;

var ingredients = new Dictionary<string, Ingredient>
{
    ["Cucumber"] = new Ingredient { Name = "Cucumber", Quantity = 2 },
    ["Olives"] = new Ingredient { Name = "Olives", Quantity = 2 },
    ["Lettuce"] = new Ingredient { Name = "Lettuce", Quantity = 3 },
    ["Meat"] = new Ingredient { Name = "Meat", Quantity = 6 },
    ["Tomato"] = new Ingredient { Name = "Tomato", Quantity = 6 },
    ["Cheese"] = new Ingredient { Name = "Cheese", Quantity = 8 },
    ["Dough"] = new Ingredient { Name = "Dough", Quantity = 10 }
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
            ["Lettuce"] = 1,
            ["Tomato"] = 1,
            ["Cheese"] = 1,
            ["Dough"] = 1
        }
    },
    new Recipe
    {
        Name = "Pie",
        Servings = 1,
        RequiredIngredients = new Dictionary<string, int>
        {
            ["Dough"] = 2,
            ["Meat"] = 2
        }
    },
    new Recipe
    {
        Name = "Sandwich",
        Servings = 1,
        RequiredIngredients = new Dictionary<string, int>
        {
            ["Dough"] = 1,
            ["Cucumber"] = 1
        }
    },
    new Recipe
    {
        Name = "Pasta",
        Servings = 2,
        RequiredIngredients = new Dictionary<string, int>
        {
            ["Dough"] = 2,
            ["Tomato"] = 1,
            ["Cheese"] = 2,
            ["Meat"] = 1
        }
    },
    new Recipe
    {
        Name = "Salad",
        Servings = 3,
        RequiredIngredients = new Dictionary<string, int>
        {
            ["Lettuce"] = 2,
            ["Tomato"] = 2,
            ["Cucumber"] = 1,
            ["Cheese"] = 2,
            ["Olives"] = 1
        }
    },
    new Recipe
    {
        Name = "Pizza",
        Servings = 4,
        RequiredIngredients = new Dictionary<string, int>
        {
            ["Dough"] = 3,
            ["Tomato"] = 2,
            ["Cheese"] = 3,
            ["Olives"] = 1
        }
    }
};

var optimizer = new RecipeOptimizer();
var result = optimizer.Optimize(ingredients, recipes);

foreach (var (recipe, times) in result)
{
    Console.WriteLine($"Make {recipe.Name} x{times} (Total people to feed: {recipe.Servings * times})");
}
