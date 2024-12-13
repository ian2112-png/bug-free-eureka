class Menu
{
    private Goals goal;
    private Exercises exercise1;
    public Menu()
    {
        goal = new Goals();
        exercise1 = new Exercises();
        exercise1.AddExercise("Bench press");
        exercise1.AddExercise("Squats");
        exercise1.AddExercise("Pec flies");
        exercise1.AddExercise("Stationary bike");
        exercise1.AddExercise("Calf raises");
    }

    public void ShowMenu()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("This is the menu list. Please enter a number between 1-5.");
            Console.WriteLine("1. Generate random exercise. ");
            Console.WriteLine("2. Create recipe. ");
            Console.WriteLine("3. Create goal. ");
            Console.WriteLine("4. List goals. ");
            Console.WriteLine("5. Quit ");

       int userInput = int.Parse(Console.ReadLine());
       switch (userInput)
       {
        case 1:
            exercise1.RandomExercises();
            break;

         case 2: 
            Recipes recipe = new();
            recipe.Create();
            break;
        case 3:
            goal.CreateGoal();
             break;
        
        case 4:
            goal.ShowGoals();
            break;
        
        case 5:
            running = false;
            break;

       }
        
       
    }
}
}