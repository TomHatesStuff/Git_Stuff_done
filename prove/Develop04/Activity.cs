using Microsoft.Win32.SafeHandles;

public class Activity 
{
    private string _activity { get; set; }
    private string _welcomeMessage { get; set; }
    private int _duration { get; set; }
    public int duration;

    public Activity(string activity, string message)
    {
        _activity = activity;
        _welcomeMessage = message;
    }


    public int SetDuration()
    {
       _duration = _duration; 
       Console.Write("How long, in seconds, would you like for your session? ");
       string answer = Console.ReadLine();
       duration = int.Parse(answer);
       return duration;
    }


    public void DisplaySpinner()
    {
        DateTime endTime = DateTime.Now.AddSeconds(5);

        while (DateTime.Now < endTime)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public void InitiateActivity()
    {
        Console.WriteLine($"Welcome to the {_activity} Activity.");
        Console.WriteLine("");
        Console.WriteLine(_welcomeMessage);
        Console.WriteLine("");
    }

    public void EndActivity()
    {
        Console.WriteLine("");
        Console.WriteLine("Well Done!");
        DisplaySpinner();
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {duration} seconds of the {_activity} Activity.");
        DisplaySpinner();
        Console.WriteLine("");
        Console.Clear();
    }

    public void GetReady()
    {
        Console.WriteLine("Get ready... ");
        DisplaySpinner();
    }


}