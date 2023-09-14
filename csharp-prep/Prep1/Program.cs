using System;

class Program
{
    static void Main(string[] args)
    {
        //this is begining of code to ask for first and last name.
        Console.Write ("What is you first name? ");
        string name1 = Console.ReadLine();

        Console.Write ("What is you last name? ");
        string name2 = Console.ReadLine ();

        Console.Write ("what was your grade percentage for this class? ");
        string number = Console.ReadLine ();
        int percent = int.Parse (number);

        if (percent >= 90)
        {
            Console.WriteLine("Your grade is an A ");
        }
        else if (percent >= 80)
        {
            Console.WriteLine("Your grade is an B ");
        }
        else if (percent >= 70)
        {
            Console.WriteLine("Your grade is an c ");
        }
        else if (percent >= 60)
        {
            Console.WriteLine("Your grade is an d ");
        }
        else if (percent < 60)
        {
            Console.WriteLine("Your grade is an F ");
        }
        if (percent >= 70 )
        {
            Console.WriteLine(" CONGRATS you have passed the class");
        }
        else 
        {
            Console.WriteLine("Saddly you have not passed the test and will have to try again. Good Luck!");
        }


        Console.Write ($"Your name is {name2}, {name1} {name2}");
    }
}