public class Scripture  //a scripture HAS a list of words and a reference. 
{
    private List<Word> _scripture;
    private Reference _reference;
    public Scripture(Reference reference)
    {
        _reference = reference;
        _scripture = new List<Word>();
    }
    public void AddScripture(Word words)
    {
        _scripture.Add(words);
    }
    public void Display()
    {
        _reference.Display();
        
        foreach (var word in _scripture)
        {
        Console.WriteLine(word);
        }
    }
}
