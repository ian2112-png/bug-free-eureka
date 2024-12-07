class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points, bool status, string goalType): base(name, description, points, status, goalType)
    {
        _name = name;
        _description = description;
        _points = points;
         _status = status;
         _goalType = goalType;
    }
    public override void RecordEvent()
    {
        Console.WriteLine("Recording event");
    }
}