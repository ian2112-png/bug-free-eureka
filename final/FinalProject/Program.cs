using System;

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
        exercise1.DisplayExercises();

        List<Recipes> recipeList = new List<Recipes>();
        Console.WriteLine("Enter recipe name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter cuisine type:");
        string type = Console.ReadLine();

        Console.WriteLine("Enter preparation time in minutes: ");
        int time = int.Parse(Console.ReadLine());
    }
}