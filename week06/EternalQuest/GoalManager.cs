public class GoalManager
{
    private List<Goal> _goals;

    public GoalManager()
    {
        _goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
        }
    }

    public bool Iscomplete(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            return _goals[goalIndex].Iscomplete();
        }
        return false;
    }
    public List<Goal> GetGoals()
    {
        return _goals;
    }
    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            string status = goal.Iscomplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}. {status} {goal.GetDetailsString()}");
        }
    }
    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());

            }
        }


    }
    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('/');
                    if (parts.Length >= 4)
                    {
                        string shortName = parts[0];
                        string description = parts[1];
                        int points = int.Parse(parts[2]);
                        string goalType = parts[3];

                        Goal goal;
                        switch (goalType)
                        {
                            case "SimpleGoal":
                                bool isComplete = bool.Parse(parts[4]);
                                goal = new SimpleGoal(shortName, description, points);
                                if (isComplete)
                                {
                                    goal.RecordEvent(); // Mark as complete
                                }
                                break;
                            case "EternalGoal":
                                goal = new EternalGoal(shortName, description, points);
                                break;
                            case "ChecklistGoal":
                                int targetCount = int.Parse(parts[4]);
                                int currentCount = int.Parse(parts[5]);
                                goal = new ChecklistGoal(shortName, description, points, targetCount);
                                for (int i = 0; i < currentCount; i++)
                                {
                                    goal.RecordEvent(); // Increment current count
                                }
                                break;
                            default:
                                throw new Exception("Unknown goal type");
                        }

                        _goals.Add(goal);
                    }
                }
            }
        }
    }
    public void DisplayGoalDetails(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void DisplayGoalStringRepresentation(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }
    public void RecordEventForGoal(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
        }
    }
    public void DisplayAllGoals()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void DisplayAllGoalStringRepresentations()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }
    public void DisplayAllGoalStatuses()
    {
        foreach (Goal goal in _goals)
        {
            string status = goal.Iscomplete() ? "Complete" : "Incomplete";
            Console.WriteLine($"{goal.GetDetailsString()} - Status: {status}");
        }
    }
    public void DisplayAllGoalPoints()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goal.GetDetailsString()} - Points: {goal.GetPoints()}");
        }
    }
    public void DisplayAllGoalShortNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goal.GetDetailsString()} - Short Name: {goal.GetShortName()}");
        }
    }
    public void DisplayAllGoalDescriptions()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goal.GetDetailsString()} - Description: {goal.GetDescription()}");
        }
    }
    public void DisplayAllGoalTypes()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goal.GetDetailsString()} - Type: {goal.GetType().Name}");
        }
    }
    public void DisplayAllGoalCurrentCounts()
    {
        foreach (Goal goal in _goals)
        {
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"{goal.GetDetailsString()} - Current Count: {checklistGoal.GetCurrentCount()}");
            }
        }
    }
    public void DisplayAllGoalTargetCounts()
    {
        foreach (Goal goal in _goals)
        {
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"{goal.GetDetailsString()} - Target Count: {checklistGoal.GetTargetCount()}");
            }
        }
    }
    public void createGoal(string goalType, string shortName, string description, int points, int targetCount = 0)
    {
        Goal goal;
        switch (goalType)
        {
            case "SimpleGoal":
                goal = new SimpleGoal(shortName, description, points);
                break;
            case "EternalGoal":
                goal = new EternalGoal(shortName, description, points);
                break;
            case "ChecklistGoal":
                goal = new ChecklistGoal(shortName, description, points, targetCount);
                break;
            default:
                throw new Exception("Unknown goal type");
        }
        _goals.Add(goal);
    }
    public void createFile(string filename)
    {
        if (!File.Exists(filename))
        {
            using (File.Create(filename))
            {
                // File created
            }
        }
        
    }
    
    
    public void CreateNewGoal(string goalType, string shortName, string description, int points, int targetCount = 0)
    {
        Goal goal;
        switch (goalType)
        {
            case "SimpleGoal":
                goal = new SimpleGoal(shortName, description, points);
                break;
            case "EternalGoal":
                goal = new EternalGoal(shortName, description, points);
                break;
            case "ChecklistGoal":
                goal = new ChecklistGoal(shortName, description, points, targetCount);
                break;
            default:
                throw new Exception("Unknown goal type");
        }
        _goals.Add(goal);
    }
    
}