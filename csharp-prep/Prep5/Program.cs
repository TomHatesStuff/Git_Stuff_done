using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomMessage();
        string UserName = PromptUserName();
        int UserNumber = PromptUserNumber ();
        int UserSquare = SquareNumber (UserNumber);
        DisplayResults (UserName, UserSquare);
    }
    static void DisplayWelcomMessage ()
    {
        Console.WriteLine ("Welcome to the Function Assignment!");
    }
    static string PromptUserName ()
    {
        Console.WriteLine("Please type you username in ");
        string Name = Console.ReadLine ();
        
        return Name;
    }
    static int PromptUserNumber ()
    {
        Console.WriteLine ("What is your favorite number?");
        int Number = int.Parse (Console.ReadLine());

        return Number;
    }
    static int SquareNumber (int Number)
    {
        int Square = Number * Number;
        
        return Square;
    }
    static void DisplayResults(string Name , int Square)
    {
        Console.WriteLine ($"{Name} the Square of your number is {Square} ");
    }

}