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
        Console.WriteLine(_welcomeMessage);
        Console.WriteLine(_commonDescription);
        Console.WriteLine("How many seconds would you like to do this activity?");
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
        Console.WriteLine();
    }
    
    public virtual void PerformingActivity()
    {
        Console.WriteLine("Default activity...");
        Thread.Sleep(1000);
    }
    public virtual void DurationTimer()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        
        while (currentTime < futureTime)
        {
            PerformingActivity();
            currentTime = DateTime.Now;
        }
        Thread.Sleep(2000);
        Console.WriteLine(_endMessage);
        Console.WriteLine($"You did the activity for {_duration} seconds");
    }
}