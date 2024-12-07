using System.Security.Cryptography.X509Certificates;

class Goals

{
    protected List<Goal> _goals = new List<Goal>();
    private string _fileName;

    private int _totalPoints;
public void DisplayMenu()
{
    bool running = true; 

    while (running)
    {
    Console.WriteLine("Welcome to the goals activity. Please choose from the following options.");
    Console.WriteLine("Menu options. Please type a number 1-6}");
    Console.WriteLine("1. Create New Goal");
    Console.WriteLine("2. List Goals");
    Console.WriteLine("3. Save Goals");
    Console.WriteLine("4. Load Goals");
    Console.WriteLine("5. Record Event");
    Console.WriteLine("6. Quit");
    int userInput = int.Parse(Console.ReadLine());

    switch (userInput)
    {
        case 1:
            GoalMenu();
            break;

        case 2:
            ListGoals();
            break;
            
        case 3:
            GoalMenu();
            break;


    }
    }
}
    public void GoalMenu()
    {
        Console.WriteLine("Please choose a number from 1-3");
        Console.WriteLine("1. Create Simple Goal");
        Console.WriteLine("2. Create Eternal Goal");
        Console.WriteLine("3. Create Checklist Goal");
        int goalInput = int.Parse(Console.ReadLine());

        switch (goalInput)
        {
            case 1:
                CreateSimpleGoal();
                break;

                case 2: 
                CreateEternalGoal();
                break;

                case 3:
                CreateChecklistGoal();
                break;

        }
        }
            public void CreateSimpleGoal()
            {
                Console.WriteLine("What is the name of your goal?");
                string simpleGoal = Console.ReadLine();
                Console.WriteLine("What is a short description?");
                string simpleDescription = Console.ReadLine();
                Console.WriteLine("How many points do you want this to be worth?");
                int simplePoints = int.Parse(Console.ReadLine());
                bool complete = false;
                EternalGoal goal1 = new EternalGoal(simpleGoal, simpleDescription, simplePoints, complete, "Type: Eternal Goal");
                _goals.Add(goal1);
            }
            public void CreateEternalGoal()
            {
                Console.WriteLine("What is the name of your goal?");
                string eternalGoal = Console.ReadLine();
                Console.WriteLine("What is a short description?");
                string eternalDescription = Console.ReadLine();
                Console.WriteLine("How many points do you want this to be worth?");
                int eternalPoints = int.Parse(Console.ReadLine());
                bool complete2 = false;
                EternalGoal goal2 = new EternalGoal(eternalGoal, eternalDescription, eternalPoints, complete2, "Type: Eternal Goal");
                _goals.Add(goal2);
            }

            public void CreateChecklistGoal()
            {
                Console.WriteLine("What is the name of your goal?");
                string checkListGoal = Console.ReadLine();
                Console.WriteLine("What is a short description?");
                string checklistDescription = Console.ReadLine();
                Console.WriteLine("How many points do you want this to be worth?");
                int checklistPoints = int.Parse(Console.ReadLine());
                Console.WriteLine("How many times do you need to do this goal?");
                int checklistCount = int.Parse(Console.ReadLine());
                Console.WriteLine("How many bonus points will you receive?");
                int checklistBonus = int.Parse(Console.ReadLine());
                bool complete3 = false;
                EternalGoal goal3 = new EternalGoal(checkListGoal, checklistDescription, checklistPoints, complete3, "Type: Eternal Goal");
                _goals.Add(goal3);
            }

            public void ListGoals()
            {
                foreach (var goal in _goals)
                {
                    Console.WriteLine($"Goal: {goal.GetName()}, Description: {goal.GetDescription()}, Points: {goal.GetPoints()}");
                }
            }


        }

