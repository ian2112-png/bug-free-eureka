public class Scripture  //a scripture HAS a list of words and a reference. 
{
    private Word _scripture;
    private Reference _reference;

   
    public Scripture(Reference reference)
    {
        _reference = reference;
        
    }
    public void AddScripture(Word words)
    {
        _scripture = words;
    }
    //replace words with an underscore

     public string HideWords()
    {
        //creates an array called hidden words that splits the scripture string at the spaces
        string[] hiddenWords = _scripture.GetString().Split(" ");
        //created random variable with random class
        Random random = new Random();
        int index = random.Next(hiddenWords.Length);
        hiddenWords[index] = new string('_', hiddenWords[index].Length);
        _scripture = new Word (string.Join(" ", hiddenWords));
        return _scripture.ToString();
    }
    public void Display()
    {
        _reference.Display();
        
        Console.WriteLine(_scripture.ToString());
        
    }
}
