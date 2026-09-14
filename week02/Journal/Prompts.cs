using System.Diagnostics.CodeAnalysis;

public class Prompts
{
    public List<string> _prompts = new List<string>()
    {
        "What was the food I ate for breakfast today?",
        "What was the best part of my day?",
        "Which assignment did I complete today?",
        "Did I pray and thank Heavenly Father today?",
        "If I had to thank someone for helping me out today, who would it be?",
        "Did I take an afternoon nap today?",
        "What I'm I grteful for today?",
        "What was the hardest challenge I faced today"
        
    };
    public Random _random = new Random();
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
        
    }
}
