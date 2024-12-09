class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool status, string goalType): base(name, description, points, status, goalType)
    {
     
    }
    public override bool IsComplete()
    {
        return true;
    }
    public override void RecordEvent()
    {
        Console.WriteLine("Recording event");
        SetStatus(true);
    }
}