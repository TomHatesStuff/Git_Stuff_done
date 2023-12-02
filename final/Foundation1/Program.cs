using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating videos
        Video video1 = new Video("Introduction to C#", "John Doe", 300);
        Video video2 = new Video("Object-Oriented Programming Basics", "Jane Smith", 450);
        Video video3 = new Video("Exception Handling in C#", "Bob Johnson", 400);

        // Adding comments to videos
        video1.AddComment("User1", "Great video!");
        video1.AddComment("User2", "I learned a lot.");

        video2.AddComment("User3", "Nice explanation!");
        video2.AddComment("User4", "Could you cover more examples?");

        video3.AddComment("User5", "Very helpful tutorial!");
        video3.AddComment("User6", "I have a question about the last topic.");

        // Putting videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        string userInput;

        do
        {
            // Display available videos
            Console.WriteLine("Available Videos:");
            foreach (Video video in videos)
            {
                Console.WriteLine($"- {video.Title}");
            }

            // Ask the user for the title of the video
            Console.Write("Enter the title of the video to display information (or 'Quit' to exit): ");
            userInput = Console.ReadLine();

            if (userInput.Equals("Quit", StringComparison.OrdinalIgnoreCase))
            {
                // Exit the loop if the user enters "Quit"
                break;
            }

            // Find the video with the specified title
            Video selectedVideo = videos.Find(v => v.Title.Equals(userInput, StringComparison.OrdinalIgnoreCase));

            // Display information for the selected video
            if (selectedVideo != null)
            {
                Console.WriteLine($"Title: {selectedVideo.Title}");
                Console.WriteLine($"Author: {selectedVideo.Author}");
                Console.WriteLine($"Length: {selectedVideo.LengthInSeconds} seconds");
                Console.WriteLine($"Number of Comments: {selectedVideo.GetNumberOfComments()}");

                Console.WriteLine("Comments:");
                foreach (Comment comment in selectedVideo.GetComments())
                {
                    Console.WriteLine($"  {comment.CommenterName}: {comment.CommentText}");
                }
            }
            else
            {
                Console.WriteLine($"Video with title '{userInput}' not found.");
            }

            Console.WriteLine(); // Add a newline for better readability

        } while (true);
    }
}
