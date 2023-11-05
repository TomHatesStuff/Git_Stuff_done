using System.Net;
using System.Transactions;

public class ReflectingActivity : Activity
{
    private int _countdown { get; set; }

    public ReflectingActivity()

        : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _countdown = 5;
    }
    List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };

    List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public void SetReflectingActivity()
    {
        Console.WriteLine("");
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine("");
        Console.WriteLine($"--- {DisplayRandomPrompt()} ---");
        Console.WriteLine("");
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience. ");
        Countdown();
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"> {DisplayRandomQuestion()} ");
            DisplaySpinner();
            Console.WriteLine();
        }
    }

    public string DisplayRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count);
        string randomPrompt = _prompts[randomIndex];

        return randomPrompt;
    }

    public string DisplayRandomQuestion()
    {

        Random random = new Random();
        int randomIndex = random.Next(0, _questions.Count);
        string randomQuestion = _questions[randomIndex];

        return randomQuestion;
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