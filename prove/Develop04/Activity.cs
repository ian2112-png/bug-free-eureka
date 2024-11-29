class Activity
{
    string _welcomeMessage;
    string _commonDescription;
    string _endMessage;

    public Activity()
    {

    }
    public Activity(string welcomeMessage, string commonDescription, string endMessage)
    {
        _welcomeMessage = welcomeMessage;
        _commonDescription = commonDescription;
        _endMessage = endMessage;
    }
    public void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the mindfulness activity. How many seconds would you like to do this activity?");
        int duration = int.Parse(Console.ReadLine());
        Console.WriteLine($"You have opted to do this activity for {duration} seconds. Prepare to begin. ");
    
    }
    public void DisplayAnimation()
    {
        Thread.Sleep(800);
        Console.Write("-");
        Thread.Sleep(800);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(800);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(800);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(800);
        Console.Write("\b \b");
        Console.Write("-");


        




    }
}