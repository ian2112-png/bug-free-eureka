public class Scripture
{
    private List<Words> _scripture;
    private Reference _reference;
    public Scripture(Reference r)
    {
        _reference = r;
        _scripture = new List<Words>();
    }
    public void Display()
    {
        _reference.Display();
        foreach (Words scripture in _scripture)
        {
            Console.WriteLine(scripture);
        }
    }
}
