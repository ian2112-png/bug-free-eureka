public class Reference
{
    string _book;
    int _chapter;
    int _verse;
    List<string> _reference; 

public Reference(string book, int chapter, int verse)
{
    _book = book;
    _chapter = chapter;
    _verse = verse;
    _reference = new List<string>();
}
public void Display()
{
 foreach (string reference in _reference)
        {
            Console.WriteLine(reference);
        }
}
}