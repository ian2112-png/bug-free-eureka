public class Scripture
{
    List<Scripture> _scripture;
    public Scripture()
    {
        _scripture = new List<Scripture>();
    }
    public void Display()
    {
        foreach (Scripture scripture in _scripture)
        {
            Console.WriteLine(scripture);
        }
    }
}
