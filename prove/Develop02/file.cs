using System;
using System.Collections.Generic;
using System.IO;

class JournalFileAppend
{
    private string fileName; // A private field to store the name of the file where entries will be saved
    public void PromptForFileName()
    {
        Console.Write("Enter the file name to save journal entries: ");
        fileName = Console.ReadLine(); // Prompt the user for the file name
    }


    public void SaveEntries(List<string> entries)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(fileName))// Check if fileName is null or empty
            {
                Console.WriteLine("Error: File name not provided. Please use PromptForFileName method.");
                return;
            }

            // Use a StreamWriter to write to the file
            // The "true" argument means that the file will be opened in append mode
            // allowing new entries to be added to the end not replace
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                foreach (string entry in entries)
                {
                    writer.WriteLine(entry);
                }
            }
            
            Console.WriteLine("Journal entries saved to " + fileName);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error saving journal entries: " + e.Message);
        }
    }



        public void LoadEntries()
    {
        try
        {
            // Check if fileName is null or empty 
            if (string.IsNullOrWhiteSpace(fileName))
            {
                Console.WriteLine("Error: File name not provided. ");
                return; // Return early if file name is wrong
            }

            // Read all lines from file
            string[] lines = File.ReadAllLines(fileName);

            // Dislay each line in file
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error loading journal entries: " + e.Message);
        }
    }
}

