using System;
using System.Collections.Generic;

class JournalPrompt
{
    public List<string> promptList = new List<string>
    {
        "What made you happy today?",
        "What could have made your day better?",
        "If you could change one thing about today, what would it be?",
        "What was one thing that made you sad today?",
        "What did you do when you woke up?",
        "What did you eat today?"
    };





    private Random random = new Random();
    public List<string> JournalEntries = new List<string>();





    public void WriteEntry()
    {
        int randomIndex = random.Next(0, promptList.Count);//make prompt random
        string randomPrompt = promptList[randomIndex];
        Console.WriteLine("Prompt: " + randomPrompt);//write random prompt

        Console.Write("Enter your journal entry: ");
        string entryText = Console.ReadLine(); //take the response

        // Get the current date
        string entryDate = DateTime.Now.ToShortDateString();

        // Combine the prompt, date, and entry text
        string journalEntry = $"[{entryDate}] {randomPrompt}: {entryText}";

        JournalEntries.Add(journalEntry);
        Console.WriteLine("Journal entry added successfully.");// add to jounal string
    }





    public void DisplayEntries()
    {
        Console.WriteLine("Latest Entries:");
        foreach (string entry in JournalEntries)
        {
            Console.WriteLine(entry);
        }
    }
}