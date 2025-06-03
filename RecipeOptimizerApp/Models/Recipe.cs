namespace RecipeOptimizerApp.Models;

public class Recipe
{
    public required string Name { get; set; }
    public required Dictionary<string, int> RequiredIngredients { get; set; }
    public int Servings { get; set; }

    public int MaxTimesCanBeMade(Dictionary<string, Ingredient> available)
    {
        return RequiredIngredients
            .Select(r => available.ContainsKey(r.Key) ? available[r.Key].Quantity / r.Value : 0)
            .Min();
    }
}
