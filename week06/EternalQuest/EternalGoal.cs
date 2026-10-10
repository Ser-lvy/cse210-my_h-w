public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Eternal goals are never completed
    }

    public override bool Iscomplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName}/{_description}/{_points}/EternalGoal";
    }
    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description}) - Eternal Goal";

    }
    public override void DisplayGoalDetails()
    {
        Console.WriteLine(GetDetailsString());
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
    public override string GetPoints()
    {
        return _points.ToString();
    }
    public override string GetDescription()
    {
        return _description;
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
    public override void DisplayGoalShortName()
    {
        Console.WriteLine($"Goal: {_shortName}");
    }
    public override void DisplayGoalPoints()
    {
        Console.WriteLine($"Points: {_points}");
    }
    


    
        
    
    
    
    
    
    

} 