using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int> ();

        int EnterNumber = -1; 

        while (EnterNumber!=0)
        {
            Console.WriteLine ("Enter a number, Type in 0 when done:");

            string response = Console.ReadLine();
            EnterNumber = int.Parse(response);

            if (EnterNumber != 0 )
            {
                numbers.Add (EnterNumber);
            }
        }
        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
            
        float average = ((float)sum) / numbers.Count;

        int max = numbers [0];
            foreach (int number in numbers)
        {
            if (number > max)
                {
                    max = number;
                }
            }
        Console.WriteLine ($"the Sum is: {sum}");
        Console.WriteLine ($"The average is {average}");
        Console.WriteLine ($"The Max is {max}");
    }
}