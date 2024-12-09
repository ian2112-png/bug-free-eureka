class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points, bool status, string goalType): base(name, description, points, status, goalType)
    {
        
    }
    public override bool IsComplete()
    {
        return false;
    }

    public override void RecordEvent()
    {
        Console.WriteLine("Recording event");
    }
}