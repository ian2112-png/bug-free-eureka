abstract class Person
{
    private string _firstName;
    private string _lastName;

    private int _age;
    
    public Person(string firstName, string lastName, int age)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
    }

    //This abstract class will force derived classes to override the GetPersonInfo
    public abstract string GetPersonInfo();
    

    public void SetFirstName(string firstName)
    {
        _firstName = firstName;
    }

    public string GetPersonsStats()
    {
        return $"{_firstName} {_lastName}, {_age}";
    }
}