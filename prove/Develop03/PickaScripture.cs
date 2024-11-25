using System; 
using System.Collections.Generic; 
using System.Linq;

class PickaScripture
{
    private Dictionary<Reference, Word> _scriptures = new Dictionary<Reference, Word>();
    private Random _random = new Random();

    public PickaScripture() {}

    public void AddScripture(Reference reference, Word word)
    {
        _scriptures.Add(reference, word);
    }

    public Scripture GetRandom()
    {
        int index = _random.Next(_scriptures.Count);
        var randomPair = _scriptures.ElementAt(index);
        Console.WriteLine(randomPair.Key);
        return new Scripture(randomPair.Key);
    }

    public void Display()
    {
        var randomScripture = GetRandom();
        Console.WriteLine("Random scripture: ");
        randomScripture.Display();
    }
}
