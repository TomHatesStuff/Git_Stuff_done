using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomMagic = new Random();
        int MagicNumber = randomMagic.Next (1,101);

        int Guess = -1;

        while (MagicNumber != Guess )
        {
        Console.Write("what is you guess? ");
        Guess = int.Parse(Console.ReadLine());

        if (MagicNumber < Guess)
        {
            Console.WriteLine("Lower ");
        }
        else if (MagicNumber > Guess)
        {
            Console.WriteLine ("Higher ");
        }
        else
        {
            Console.WriteLine("Correct! ");
        
        }
        }
    
    }
}