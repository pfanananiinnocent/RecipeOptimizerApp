## Recipe Optimizer App (.NET 9)
- This console app determines the optimal combination of recipes that can be made from available ingredients to feed as many people as possible.
## Technologies Used
- .Net 9
- C#
- xUnit for unit testing
- Follows SOLID principles and clean architecture
  
## Folder/Project Structure
RecipeOptimizerApp
  - Models/ # Ingredient
  - Interfaces/ # IRecipeOptimizer
  - Services/ # RecipeOptimizer 
  - Program.cs # Entry point
RecipeOptimizerApp.Tests/ # xUnit tests
  - RecipeOptimizerTests.cs
  - README.md
  - .gitignore

## How to run
### Using Visual studio
- open RecipeOptimizerApp.sln and run the console app
### How to run using bash
- dotnet build
- dotnet run --project RecipeOptimizerApp
- dotnet run
### Running unit test 
- dotnet test
### Sample output
- Make Pizza x2 (Total people to feed: 8)
- Make Pasta x1 (Total people to feed: 2)
- Make Pie x1 (Total people to feed: 1)

