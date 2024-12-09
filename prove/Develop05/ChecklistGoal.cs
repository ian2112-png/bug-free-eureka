class ChecklistGoal : Goal
{
    private int _checklistCount;
    private int _checklistBonus;
    private int _completedCount;
public ChecklistGoal(string name, string description, int points, int checklistCount, int checklistBonus, bool status, string goalType): base(name, description, points, status, goalType)
    {
         _checklistCount = checklistCount;
         _checklistBonus = checklistBonus;
         _completedCount = 0;
    }   
    public override void RecordEvent()
    {
        _completedCount++;
        Console.WriteLine("Recording event");
        if (_completedCount >= _checklistCount)
        {
            SetStatus(true);
            Console.WriteLine("Checklist goal completed!");
        }
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
    public int GetCompletedCount()
    {
        return _completedCount;
    }
    
    public override bool IsComplete()
    {
        return GetStatus();

    }
    public override void Display()
    {
        string checkbox = GetStatus() ? "[X]" : "[]";
        Console.WriteLine($"{checkbox} Goal: {_name} Description: {_description} Points: {_points} Completed: {_completedCount}/{_checklistCount} Bonus points: {_checklistBonus}");
    }
}