class Program 
{

    public static void SetPersonFirstName(Person person, string firstName)
   {
    person.SetFirstName(firstName);
   }
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Bob.");
        Person bob = new Person("Bob", "Billy", 37);
        Console.WriteLine(bob.GetPersonInfo());
        
        Doctor doctorJames = new ("James", "Bond", 40, "Stethoscope");
        Console.WriteLine(doctorJames.GetDoctorInformation());
        Console.WriteLine(doctorJames.GetPersonInfo());

        Police policeDoug = new("Doug", "Denver", 40, "Taser");
        Console.WriteLine(policeDoug.GetPoliceInformation());
        Console.WriteLine(policeDoug.GetPersonInfo());

        SetPersonFirstName(policeDoug, "Doug the Second");
        Console.WriteLine(policeDoug.GetPoliceInformation());
        Console.WriteLine(policeDoug.GetPersonInfo());

        SetPersonFirstName(bob, "Bobby");
        Console.WriteLine(bob.GetPersonInfo());
        
        List<Person> people = new List<Person>();
        people.Add(bob);
        people.Add(doctorJames);
        people.Add(policeDoug);

        foreach (Person person in people)
        {
            Console.WriteLine(person.GetPersonInfo());
        }
        
    } 
}
