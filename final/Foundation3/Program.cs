using System;
using System.Collections.Generic;

class Program
{
    static List<Event> events = new List<Event>();

    static void Main()
    {
        Console.WriteLine("Event Planning Program");

        while (true)
        {
            // Display event type menu
            int eventTypeChoice = DisplayEventTypeMenu();

            // Create instances of the chosen event type using user input
            Event selectedEvent = CreateEvent((EventType)eventTypeChoice);

            // Save the event
            events.Add(selectedEvent);

            Console.WriteLine("\nEvent saved successfully!");

            // Ask the user if they want to input another event
            Console.Write("\nDo you want to input another event? (yes/no): ");
            string input = Console.ReadLine().ToLower();
            if (input != "yes")
            {
                // If the user doesn't want to input another event, break out of the loop
                break;
            }
        }

        // Display past events
        Console.WriteLine("\nPast Events:");
        foreach (var pastEvent in events)
        {
            Console.WriteLine($"\n{pastEvent.GetStandardDetails()}\n");
        }
    }

    static int DisplayEventTypeMenu()
    {
        Console.WriteLine("\nSelect the type of event to plan:");
        Console.WriteLine("1. Generic Event");
        Console.WriteLine("2. Lecture Event");
        Console.WriteLine("3. Reception Event");
        Console.WriteLine("4. Outdoor Gathering Event");

        int choice;
        do
        {
            Console.Write("Enter your choice (1-4): ");
        } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4);

        return choice;
    }

    static Event CreateEvent(EventType eventType)
    {
        Console.WriteLine($"\nEnter details for {eventType}:");

        string title;
        do
        {
            Console.Write("Title: ");
            title = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(title));

        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Date (MM/DD/YYYY): ");
        DateTime date;
        while (!DateTime.TryParse(Console.ReadLine(), out date))
        {
            Console.WriteLine("Invalid date format. Please try again.");
        }

        Console.Write("Time (HH:mm): ");
        TimeSpan time;
        while (!TimeSpan.TryParse(Console.ReadLine(), out time))
        {
            Console.WriteLine("Invalid time format. Please try again.");
        }

        Console.Write("Street: ");
        string street = Console.ReadLine();
        Console.Write("City: ");
        string city = Console.ReadLine();
        Console.Write("State: ");
        string state = Console.ReadLine();
        Console.Write("Zip Code: ");
        string zipCode = Console.ReadLine();

        Address address = new Address(street, city, state, zipCode);

        switch (eventType)
        {
            case EventType.Lecture:
                Console.Write("Speaker: ");
                string speaker = Console.ReadLine();
                Console.Write("Capacity: ");
                int capacity;
                while (!int.TryParse(Console.ReadLine(), out capacity) || capacity <= 0)
                {
                    Console.WriteLine("Invalid capacity. Please enter a positive integer.");
                }
                return new Lecture(title, description, date, time, address, speaker, capacity);

            case EventType.Reception:
                Console.Write("RSVP Email: ");
                string rsvpEmail = Console.ReadLine();
                return new Reception(title, description, date, time, address, rsvpEmail);

            case EventType.OutdoorGathering:
                Console.Write("Weather Statement: ");
                string weatherStatement = Console.ReadLine();
                return new OutdoorGathering(title, description, date, time, address, weatherStatement);

            default:
                return new Event(title, description, date, time, address);
        }
    }

    enum EventType
    {
        GenericEvent = 1,
        Lecture = 2,
        Reception = 3,
        OutdoorGathering = 4
    }
}

