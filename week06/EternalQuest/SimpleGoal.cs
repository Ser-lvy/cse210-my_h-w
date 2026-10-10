public class SimpleGoal: Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"You have earned {_points} points for the goal: {_shortName}");
    }

    public override bool Iscomplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName}/{_description}/{_points}/SimpleGoal/{_isComplete}";
    }
    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description}) - Simple Goal";
    }
    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
    public bool GetIsComplete()
    {
        return _isComplete;
    }
    public void ResetGoal()
    {
        _isComplete = false;
    }
    public override void DisplayGoalDetails()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_shortName} ({_description}) - Simple Goal");
    }
    public override void DisplayGoalStringRepresentation()
    {
        Console.WriteLine(GetStringRepresentation());
    }
    public override void SetShortName(string shortName)
    {
        _shortName = shortName;
    }
    public override void SetDescription(string description)
    {
        _description = description;
    }
    public override void SetPoints(int points)
    {
        _points = points;
    }
    public override string GetShortName()
    {
        return _shortName;
    }
    public override string GetDescription()
    {
        return _description;
    }
    public override string GetPoints()
    {
        return _points.ToString();
    }
    public override void DisplayGoalInfoWithDescription()
    {
        Console.WriteLine($"Goal: {_shortName}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Points: {_points}");
    }
    public override void DisplayGoalInfoWithPoints()
    {
        Console.WriteLine($"Goal: {_shortName}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Points: {_points}");
    }
    public override void DisplayGoalInfoWithShortName()
    {
        Console.WriteLine($"Goal: {_shortName}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Points: {_points}");
    }
    public override void DisplayGoalInfo()
    {
        Console.WriteLine($"Goal: {_shortName}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Points: {_points}");
    }
    public override void DisplayGoalInfoWithStatus()
    {
        string status = _isComplete ? "Complete" : "Incomplete";
        Console.WriteLine($"Goal: {_shortName}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Points: {_points}");
        Console.WriteLine($"Status: {status}");
    }
    public override void DisplayGoalShortName()
    {
        Console.WriteLine($"Goal: {_shortName}");
    }
    public override void DisplayGoalPoints()
    {
        Console.WriteLine($"Points: {_points}");
    }
    public override void DisplayGoalStatus()
    {
        string status = _isComplete ? "Complete" : "Incomplete";
        Console.WriteLine($"Goal: {_shortName} - Status: {status}");
    }
    public override void DisplayGoalDescription()
    {
        Console.WriteLine($"Description: {_description}");
    }
    
    
      
}
