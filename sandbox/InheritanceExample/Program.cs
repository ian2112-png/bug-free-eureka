class Program 
{
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
        
    } 
}
