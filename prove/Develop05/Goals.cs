using System.Security.Cryptography.X509Certificates;

class Goals

{
    protected List<Goal> _goals = new List<Goal>();
    private string _fileName = "goals.txt";

    private int _totalPoints;
public void DisplayMenu()
{
    bool running = true; 

    while (running)
    {
    Console.WriteLine("Welcome to the goals activity. Please choose from the following options.");
    Console.WriteLine("Menu options. Please type a number 1-6");
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
            SaveFile(_fileName);
            break;
        case 4:
            LoadFile(_fileName);
            break;
        case 5:
        RecordEvent();
            break;
        case 6:
            Console.WriteLine("Exiting");
            running = false;
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
                bool status = false;
                SimpleGoal goal1 = new SimpleGoal(simpleGoal, simpleDescription, simplePoints, status, "Type: Simple Goal");
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
                ChecklistGoal goal3 = new ChecklistGoal(checkListGoal, checklistDescription, checklistPoints, checklistCount, checklistBonus, complete3, "Type: Checklist Goal");
                _goals.Add(goal3);
            }

            public void ListGoals()
            {
                foreach (var goal in _goals)
                {
                    goal.Display();
                    Console.WriteLine($"Total points: {_totalPoints}");
                }
            }

            public void SaveFile(string goalFile)
            {
                using (StreamWriter outputFile = new StreamWriter(goalFile))
                {
                    foreach(Goal goal in _goals)
                    {
                        if (goal is ChecklistGoal checklistGoal)
                        {
                            outputFile.WriteLine($"{goal.GetType().Name}|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{goal.GetStatus()}|{goal.GetGoalType()}|{checklistGoal.GetChecklistCount()}|{checklistGoal.GetChecklistBonus()}");
                        }
                        else
                        {
                        outputFile.WriteLine($"{goal.GetType().Name}|{goal.GetName()} | {goal.GetDescription()} | {goal.GetPoints()}|{goal.GetStatus()}|{goal.GetGoalType()}");
                        }
                    }
                }

            }
            public void LoadFile(string goalFile)
            {
                _goals.Clear();

                string [] lines = System.IO.File.ReadAllLines(goalFile);
                foreach(string line in lines)
                {
                    string[] parts = line.Split("|");
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool status = bool.Parse(parts[4]);
                    string goalType = parts[5];
                    
                    Goal goal = null;
                    if (type == nameof(SimpleGoal))
                    {
                        goal = new SimpleGoal(name, description, points, status, goalType);

                    }
                    else if (type == nameof(EternalGoal))
                    {
                        goal = new EternalGoal(name, description, points, status, goalType);
                    }
                    else if (type == nameof(ChecklistGoal))
                    {
                        int checklistCount = int.Parse(parts[6]);
                        int checklistBonus = int.Parse(parts[7]);

                        goal = new ChecklistGoal(name, description, points, checklistCount, checklistBonus, status, goalType);
                    }
                    if (goal != null)
                    {
                        _goals.Add(goal);
                    } 
                }
            }
            public void RecordEvent()
            {
                Console.WriteLine("Enter the name of the goal to record.");
                string goalName = Console.ReadLine().Trim();
                Goal goal = _goals.Find(g => g.GetName().Trim() == goalName);
                if (goal != null)
                {
                    goal.RecordEvent();
                    _totalPoints += goal.GetPoints();
                    if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
                    {
                        _totalPoints += checklistGoal.GetChecklistBonus();
                    }
                    
                }
                else
                {
                        Console.WriteLine("No such goal found.");
                }

            }

        }

