abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _status;
    protected string _goalType;

    public Goal()
    {

    }
    public Goal(string name, string description, int points, bool status, string goalType)
    {
        _name = name;
        _description = description;
        _points = points;
         _status = status;
         _goalType = goalType;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string value)
    {
        _name = value;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string value)
    {
        _description = value;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int value)
    {
        _points = value;
    }
    public bool GetStatus()
    {
        return _status;
    }
    public void SetStatus(bool value)
    {
        _status = value;
    }
    public string GetGoalType()
    {
        return _goalType;
    }
    public void SetGoalType(string value)
    {
        _goalType = value;
    }
    public abstract void RecordEvent();
}