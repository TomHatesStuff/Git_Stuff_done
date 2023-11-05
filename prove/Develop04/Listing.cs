public class ListingActivity : Activity
{   
    private int _numResponses { get; set; }
    private int _countdown { get; set; }

    public ListingActivity()

        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _countdown = 5;
    }

    List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    List<string> _reponses = new List<string>();

    public void SetListingActivity()
    {
        Console.WriteLine("");
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine("");
        Console.WriteLine($"--- {DisplayRandomPrompt()} ---");
        Console.WriteLine("");
        Countdown();
        Console.WriteLine();
        GetUserInput();
    }

    public string DisplayRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count);
        string randomPrompt = _prompts[randomIndex];

        return randomPrompt;
    }

    public void GetUserInput()
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"> ");
            string input = Console.ReadLine();
            _reponses.Add(input);
        }

        int _numResponses = _reponses.Count();
        Console.WriteLine($"You listed {_numResponses} items!");
    }

    public void Countdown()
    {
        for (int i = _countdown - 1; i >= 0; i--)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write($"You may begin in: {i} ");
            Thread.Sleep(1000);
        }
    }
}