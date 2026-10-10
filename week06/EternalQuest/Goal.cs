public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    public virtual string GetShortName()
    {
        return _shortName;
    }
    public virtual void SetShortName(string shortName)
    {
        _shortName = shortName;
    }
    public virtual string GetPoints()
    {
        return _points.ToString();
    }
    public virtual void SetPoints(int points)
    {
        _points= points;
    }

    public virtual void RecordEvent()
    {
        Console.WriteLine($"You have earned {_points} points for the goal: {_shortName}");

    }
    public virtual bool Iscomplete()
    {
        return false;
    }
    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }
    public virtual string GetStringRepresentation()
    {
        return $"{_shortName}/{_description}/{_points}";
    }
    public virtual string GetDescription()
    {
        return _description;
    }
    public virtual void SetDescription(string description)
    {
        _description = description;
    }
    public virtual void DisplayGoalDetails()
    {
        Console.WriteLine(GetDetailsString());
    }
    public virtual void DisplayGoalStringRepresentation()
    {
        Console.WriteLine(GetStringRepresentation());
    }
    public virtual void DisplayGoalStatus()
    {
        string status = Iscomplete() ? "Complete" : "Incomplete";
        Console.WriteLine($"{GetDetailsString()} - Status: {status}");
    }
    public virtual void DisplayGoalPoints()
    {
        Console.WriteLine($"{GetDetailsString()} - Points: {GetPoints()}");
    }
    public virtual void DisplayGoalDescription()
    {
        Console.WriteLine($"{GetDetailsString()} - Description: {GetDescription()}");
    }
    public virtual void DisplayGoalShortName()
    {
        Console.WriteLine($"{GetDetailsString()} - Short Name: {GetShortName()}");
    }
    public virtual void DisplayGoalInfo()
    {
        DisplayGoalDetails();
        DisplayGoalStringRepresentation();
        DisplayGoalStatus();
        DisplayGoalPoints();
        DisplayGoalDescription();
        DisplayGoalShortName();
    }
    public virtual void DisplayGoalInfoWithStatus()
    {
        DisplayGoalDetails();
        DisplayGoalStringRepresentation();
        DisplayGoalStatus();
    }
    public virtual void DisplayGoalInfoWithPoints()
    {
        DisplayGoalDetails();
        DisplayGoalStringRepresentation();
        DisplayGoalPoints();
    }
    public virtual void DisplayGoalInfoWithDescription()
    {
        DisplayGoalDetails();
        DisplayGoalStringRepresentation();
        DisplayGoalDescription();
    }
    public virtual void DisplayGoalInfoWithShortName()
    {
        DisplayGoalDetails();
        DisplayGoalStringRepresentation();
        DisplayGoalShortName();
    }

}