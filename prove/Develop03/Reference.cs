public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _lastVerse;

    private List<Reference> _randomReference;
    

public Reference(string book)
{
    _randomReference = new List<Reference>();
    _book = book;
}
public Reference(string book, int chapter, int verse)
{
    _book = book;
    _chapter = chapter;
    _verse = verse;
}
public Reference(string book, int chapter, int verse, int lastVerse)
{
    _book = book;
    _chapter = chapter;
    _verse = verse;
    _lastVerse = lastVerse;
}
// public void AddReference(Reference reference)
// {
//     _randomReference.Add(reference);
// }
public void Display()
{
    //if lastVerse has a value, it will be printed. otherwise it will print just the one verse
if (_lastVerse.HasValue)
{
 Console.WriteLine($"{_book} {_chapter}:{_verse}-{_lastVerse}");
}
else
{
 Console.WriteLine($"{_book} {_chapter}:{_verse}");
    
}
 
}
}