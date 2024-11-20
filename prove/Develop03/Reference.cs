public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _lastVerse;
    //List<string> _reference = new List<string>();


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
public void Display()
{
 Console.WriteLine($"{_book} {_chapter}:{_verse}");
 
}
}