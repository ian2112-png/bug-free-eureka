class Goals
{
    List<string> _goals;

    public Goals()
    {
        _goals = new List<string>();
    }
    public void CreateGoal()
    {
        Console.WriteLine("You will now create a new goal. ");
        Console.WriteLine("Enter the name of the goal you want.");

        string goalName = Console.ReadLine();

        Console.WriteLine("Enter a description for your goal");
        string goalDescription = Console.ReadLine();
        string fullGoal = $"{goalName} : {goalDescription} ";

        _goals.Add(fullGoal);
        Console.WriteLine("Your goal has been added.");
    }

    public void ShowGoals()
    {
        Console.WriteLine("This is your list of goals.");
        foreach(var goal in _goals)
        {
            Console.WriteLine(goal);
        }
    }
}