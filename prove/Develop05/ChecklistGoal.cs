class ChecklistGoal : Goal
{
    private int _checklistCount;
    private int _checklistBonus;
public ChecklistGoal(string name, string description, int points, int checklistCount, int checklistBonus, bool status, string goalType): base(name, description, points, status, goalType)
    {
        _name = name;
        _description = description;
        _points = points;
         _status = status;
         _goalType = goalType;
         _checklistCount = checklistCount;
         _checklistBonus = checklistBonus;
    }
    public override void RecordEvent()
    {
        Console.WriteLine("Recording event");
    }
    public int GetChecklistCount()
    {
        return _checklistCount;
    }
    public void SetChecklistCount (int value)
    {
        _checklistCount = value;
    }
    public int GetChecklistBonus()
    {
        return _checklistBonus;
    }
    public void SetChecklistBonus (int value)
    {
        _checklistBonus = value;
    }
}