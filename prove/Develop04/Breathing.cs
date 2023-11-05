public class BreathingActivity : Activity
{
    private int _countdown { get; set; }
    private int _holdCountdown { get; set; }

    public BreathingActivity()

        : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        _countdown = 6;
        _holdCountdown = 3;
    }

    public void SetBreathingActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("");
            BreathIn();
            Console.WriteLine();
            HoldBreath();
            Console.WriteLine("");
            BreathOut();
            Console.WriteLine("");
        }
    }

    public void BreathIn()
    {
        for (int i = _countdown; i > 0; i--)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write($"Breathe in...{i}");
            Thread.Sleep(1000); 
        }
    }

    public void BreathOut()
    {
        for (int i = _countdown; i > 0; i--)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write($"Breathe out...{i}");
            Thread.Sleep(1000); 
        }

    }

    public void HoldBreath()
    {
        for (int i = _holdCountdown; i > 0; i--)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write($"Hold...{i}");
            Thread.Sleep(1000); 
        }
    }
}