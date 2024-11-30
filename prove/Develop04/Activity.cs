using System.Net;
using System.Reflection.PortableExecutable;
using System.Threading;

class Activity
{
    protected int _duration = 30;
    private string _welcomeMessage;
    private string _commonDescription;
    private string _endMessage;

    public Activity()
    {
        
    }
    public Activity(string welcomeMessage, string commonDescription, int duration, string endMessage)
    {
        _welcomeMessage = welcomeMessage;
        _commonDescription = commonDescription;
        _endMessage = endMessage;
        _duration = duration;
    }
    public virtual void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the mindfulness activity. How many seconds would you like to do this activity?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine($"You have opted to do this activity for {_duration} seconds. Prepare to begin. ");
        }
    public void DisplayAnimation()
    {
        //I had an animation without a loop. Copilot suggested I put it in a loop
        char[] animationCharacters = new[] {'-', '/', '\\', '|'};
        for (int i = 0; i < 3; i++)
        {
            foreach(var anim in animationCharacters)
            {
            Console.Write(anim);
            Thread.Sleep(800);
            Console.Write("\b \b");
            }
        }
    }
    public virtual void Countdown()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        
        while (currentTime < futureTime)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(4000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(4000);
            currentTime = DateTime.Now; 
        }
    
    }
}