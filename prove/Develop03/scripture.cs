public class Scripture
{
    private Reference reference;
    private List<Word> words;
    private Random random = new Random();

    public Scripture(string reference, string text)
    {
        this.reference = new Reference(reference);
        this.words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

      public void HideWords()
    {
        // Randomly select words that are not hidden and hide them with a random percentage <= 20%
        foreach (Word word in words)
        {
            if (!word.IsHidden && random.Next(101) <= 20) // 20% chance or less
            {
                word.Hide();
            }
        }
    }
   public string GetRenderedText()
    {
        // Combine the reference and rendered words
        return $"{reference.Book} {reference.Chapter}:{reference.StartVerse}-{reference.EndVerse} " +
               string.Join(" ", words.Select(word => word.GetRenderedText()));
    }

    public bool IsCompletelyHidden()
    {
        // Check if all words in the scripture are hidden
        return words.All(word => word.IsHidden);
    }
}