using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        while (true)
        {
            Console.WriteLine("Select the type of workout:");
            Console.WriteLine("1. Running");
            Console.WriteLine("2. Cycling");
            Console.WriteLine("3. Swimming");
            Console.WriteLine("4. Exit/view workouts for the day");

            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                continue;
            }

            if (choice == 4)
            {
                // Exit the loop if the user chooses to exit
                break;
            }

            Console.Write("Enter the date (e.g., 2022-11-03): ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime date))
            {
                Console.WriteLine("Invalid date format. Please enter a valid date.");
                continue;
            }

            Console.Write("Enter the duration in minutes: ");
            if (!int.TryParse(Console.ReadLine(), out int minutes) || minutes <= 0)
            {
                Console.WriteLine("Invalid duration. Please enter a positive number of minutes.");
                continue;
            }

            double additionalInfo = 0;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the distance in miles: ");
                    if (!double.TryParse(Console.ReadLine(), out additionalInfo) || additionalInfo <= 0)
                    {
                        Console.WriteLine("Invalid distance. Please enter a positive number of miles.");
                        continue;
                    }
                    activities.Add(new Running(date, minutes, additionalInfo));
                    break;

                case 2:
                    Console.Write("Enter the speed in mph: ");
                    if (!double.TryParse(Console.ReadLine(), out additionalInfo) || additionalInfo <= 0)
                    {
                        Console.WriteLine("Invalid speed. Please enter a positive number in mph.");
                        continue;
                    }
                    activities.Add(new Cycling(date, minutes, additionalInfo));
                    break;

                case 3:
                    Console.Write("Enter the number of laps: ");
                    if (!int.TryParse(Console.ReadLine(), out int laps) || laps <= 0)
                    {
                        Console.WriteLine("Invalid number of laps. Please enter a positive integer.");
                        continue;
                    }
                    activities.Add(new Swimming(date, minutes, laps));
                    break;
            }

            Console.WriteLine("Workout added successfully!");
        }

        // Display summaries for all activities
        Console.WriteLine("\nWorkout Summaries:");
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
