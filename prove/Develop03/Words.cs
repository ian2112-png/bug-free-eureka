
public class Word
{
    private string _words;

    public Word(string words)
{
    _words = words;
    
}
    public override string ToString()
    {
        return _words;
    }
    //replace words with an underscore
    public string HideWords()
    {
        string[] hiddenWords = _words.Split(" ");
        Random random = new Random();
        int index = random.Next(hiddenWords.Length);
        hiddenWords[index] = "_";
    }
}
