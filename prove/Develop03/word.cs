public class Word
{
    public string Text { get; }
    public bool IsHidden { get; set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public string GetRenderedText()
    {
        if (IsHidden)
        {
            // Replace the word with underscores or any other placeholder
            return new string('_', Text.Length);
        }
        return Text;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public void Show()
    {
        IsHidden = false;
    }
}