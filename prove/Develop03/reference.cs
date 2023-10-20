public class Reference
{
    public string Book { get; }
    public int Chapter { get; }
    public int StartVerse { get; }
    public int EndVerse { get; }

    public Reference(string reference)
    {
        // Parse and initialize Book, Chapter, StartVerse, and EndVerse from the input 
        string[] parts = reference.Split(' ');

        Book = parts[0];
        
        string[] verseParts = parts[1].Split(':');
        Chapter = int.Parse(verseParts[0]);

        if (verseParts[1].Contains("-"))
        {
            string[] verseRange = verseParts[1].Split('-');
            StartVerse = int.Parse(verseRange[0]);
            EndVerse = int.Parse(verseRange[1]);
        }
        else
        {
            StartVerse = int.Parse(verseParts[1]);
            EndVerse = StartVerse;
        }
    }
}