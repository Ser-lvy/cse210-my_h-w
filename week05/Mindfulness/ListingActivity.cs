class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base(
        "Listing",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
    )
    {
    }

    private static List<string> ShuffleList(List<string> input)
    {
        List<string> shuffled = new List<string>(input);
        Random random = new Random();
        int n = shuffled.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            string value = shuffled[k];
            shuffled[k] = shuffled[n];
            shuffled[n] = value;
        }
        return shuffled;
    }

    public override void Run()
    {
        DisplayStartingMessage();

        List<string> shuffledPrompts = ShuffleList(_prompts);
        int promptIndex = 0;

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {shuffledPrompts[promptIndex]} ---");
        promptIndex = (promptIndex + 1) % shuffledPrompts.Count;
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> items = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string ? item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);
            }
        }

        Console.WriteLine($"You listed {items.Count} items!");
        DisplayEndingMessage();
    }
}
