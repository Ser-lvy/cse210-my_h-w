public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;

    public ChecklistGoal(string shortName, string description, int points, int targetCount) : base(shortName, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
    }

    public override void RecordEvent()
    {
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            Console.WriteLine($"You have completed the goal: {_shortName}");
        }
    }

    public override bool Iscomplete()
    {
        return _currentCount >= _targetCount;
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName}/{_description}/{_points}/ChecklistGoal/{_targetCount}/{_currentCount}";
    }
    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description}) - Checklist Goal: {_currentCount}/{_targetCount}";
    }
    public int GetTargetCount()
    {
        return _targetCount;
    }
    public int GetCurrentCount()
    {
        return _currentCount;
    }
    public void SetCurrentCount(int currentCount)
    {
        _currentCount = currentCount;
    }
    public void SetTargetCount(int targetCount)
    {
        _targetCount = targetCount;
    }
    public void IncrementCurrentCount()
    {
        _currentCount++;
    }
    public void DecrementCurrentCount()
    {
        if (_currentCount > 0)
        {
            _currentCount--;
        }
    }
    public void ResetCurrentCount()
    {
        _currentCount = 0;
    }
    public void ResetTargetCount()
    {
        _targetCount = 0;
    }
    public void ResetCounts()
    {
        _currentCount = 0;
        _targetCount = 0;
    }
    public void DisplayCurrentCount()
    {
        Console.WriteLine($"Current Count: {_currentCount}");
    }
    public void DisplayTargetCount()
    {
        Console.WriteLine($"Target Count: {_targetCount}");
    }
    public void DisplayCounts()
    {
        Console.WriteLine($"Current Count: {_currentCount}, Target Count: {_targetCount}");
    }
    public override string GetDescription()
    {
        return _description;
    }
    public override void SetDescription(string description)
    {
        _description = description;
    }
    public override void SetShortName(string shortName)
    {
        _shortName = shortName;
    }
    public override void SetPoints(int points)
    {
        _points = points;
    }
    public override string GetShortName()
    {
        return _shortName;
    }
    public override string GetPoints()
    {
        return _points.ToString();
    }
    public override void DisplayGoalInfo()
    {
        Console.WriteLine($"Goal: {_shortName}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Points: {_points}");
        Console.WriteLine($"Target Count: {_targetCount}");
        Console.WriteLine($"Current Count: {_currentCount}");
    }
    public override void DisplayGoalInfoWithDescription()
    {
        Console.WriteLine($"Goal: {_shortName}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Points: {_points}");
        Console.WriteLine($"Target Count: {_targetCount}");
        Console.WriteLine($"Current Count: {_currentCount}");
        
    }
    public override void DisplayGoalInfoWithShortName()
    {
        Console.WriteLine($"Goal: {_shortName}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Points: {_points}");
        Console.WriteLine($"Target Count: {_targetCount}");
        Console.WriteLine($"Current Count: {_currentCount}");
        
    }
    public override void DisplayGoalInfoWithPoints()
    {
        Console.WriteLine($"Goal: {_shortName}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Points: {_points}");
        Console.WriteLine($"Target Count: {_targetCount}");
        Console.WriteLine($"Current Count: {_currentCount}");
        
    }
    public override void DisplayGoalStatus()
    {
        string status = Iscomplete() ? "Complete" : "Incomplete";
        Console.WriteLine($"Goal: {_shortName} - Status: {status}");
    }
    public override void DisplayGoalInfoWithStatus()
    {
        string status = Iscomplete() ? "Complete" : "Incomplete";
        Console.WriteLine($"Goal: {_shortName}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Points: {_points}");
        Console.WriteLine($"Target Count: {_targetCount}");
        Console.WriteLine($"Current Count: {_currentCount}");
        Console.WriteLine($"Status: {status}");
    }
    


    
    
        
    
}