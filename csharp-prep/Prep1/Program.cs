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

        Console.Write ($"Your name is {name2}, {name1} {name2}");
    }
}