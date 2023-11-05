using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

       int choice = 0;

       do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflecting Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");

            string answer = Console.ReadLine();
            choice = int.Parse(answer);


            if (choice == 1)
            {
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.InitiateActivity();
                breathingActivity.SetDuration();
                Console.Clear();
                breathingActivity.GetReady();
                breathingActivity.SetBreathingActivity();
                breathingActivity.EndActivity();
            }

            else if (choice == 2)
            {
                Console.Clear();
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.InitiateActivity();
                reflectingActivity.SetDuration();
                Console.Clear();
                reflectingActivity.GetReady();
                reflectingActivity.SetReflectingActivity();
                reflectingActivity.EndActivity();
            }

            else if (choice == 3)
            {
                Console.Clear();
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.InitiateActivity();
                listingActivity.SetDuration();
                Console.Clear();
                listingActivity.GetReady();
                listingActivity.SetListingActivity();
                listingActivity.EndActivity();
            }

            else if (choice == 4)
            {
                Console.WriteLine("Thank you!");
            }

            else
            {
               Console.WriteLine("Invalid Option");
            }

        }
        while (choice != 4);


    }
}