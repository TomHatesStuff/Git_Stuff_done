using System;
using System.Collections.Generic;

class Program
{
   static void Main()
   {
     JournalPrompt journalPrompt = new JournalPrompt(); 
     JournalFileAppend journalFileAppend = new JournalFileAppend ();
     //make it loop
     bool continueLoop = true;

     while (continueLoop)
     {

     // Ask user for input
     Console.WriteLine ("Please select one of the following choices: \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit \n Please type in the corresponding digit?");
     
     if (int.TryParse(Console.ReadLine(), out int decision))
     {
        switch (decision)
        {
            // This will have them input a journal entry
            case 1:
                journalPrompt.WriteEntry(); 
                break;
            // This will display journal entry
            case 2:
                journalPrompt.DisplayEntries();
                break;
            // This will load all journal entries
            case 3:
                journalFileAppend.PromptForFileName();
                journalFileAppend.LoadEntries();
                
                break;
            // This will save all journal entries
            case 4:
                journalFileAppend.PromptForFileName(); // Prompt user for file name
                    journalFileAppend.SaveEntries(journalPrompt.JournalEntries);
                break;
            // This will quit the program
            case 5:
                Console.WriteLine("Quitting program...");
                continueLoop = false; //exit loop
                break;
            // If anything is incorrect
            default:
                Console.WriteLine("Invalid entry. Please try again and read instructions.");
                break;
        }
    }
    else
    {
        Console.WriteLine("ERROR: Please retry.");
    }
     }
   }
}
