using System;
using System.Collections.Generic; 
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Exercises exercise1 = new();
        exercise1.AddExercise("Bench press");
        exercise1.AddExercise("Squats");
        exercise1.AddExercise("Pec flies");
        exercise1.AddExercise("Stationary bike");
        exercise1.AddExercise("Calf raises");
        exercise1.RandomExercises();

        Console.WriteLine("You will create your own recipes and be prompted to enter information.");
        List<Recipes> recipeList = new List<Recipes>();
        Console.WriteLine("Enter recipe name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter cuisine type:");
        string type = Console.ReadLine();

        Console.WriteLine("Enter preparation time in minutes: ");
        int time = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the ingredients (separated by commas):");
        List<string> ingredients = Console.ReadLine().Split(',').ToList();

        Console.WriteLine("Enter number of calories:");
        int calories = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter breakfast fruit. Press enter if none: ");
        string breakfastFruit = Console.ReadLine();

        Console.WriteLine("Enter dinner vegetable. Press enter if none: ");
        string dinnerVegetable = Console.ReadLine();
    

    if (!string.IsNullOrEmpty(breakfastFruit))
    {
        recipeList.Add(new BreakfastRecipes(breakfastFruit, name, type, time,ingredients, calories));
    }
    else if (!string.IsNullOrEmpty(dinnerVegetable))
    {
        recipeList.Add(new DinnerRecipes(dinnerVegetable, name, type, time, ingredients, calories));
    }
    else
    {
        recipeList.Add(new LunchRecipes(name, type, time, ingredients, calories));
        
    }
    foreach(var recipe in recipeList)
    {
        recipe.Display();
    }
    }
}
