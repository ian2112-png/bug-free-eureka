class BreathingActivity : Activity
{
    private string _specificDescription;
   public BreathingActivity(string specificDescription)  
   {
    _specificDescription = specificDescription;
   }

    public override void DisplayWelcomeMessage()
    {
        //I got help with the virtual/override from copilot AI. 

        Console.WriteLine(_specificDescription);
        base.DisplayWelcomeMessage();
    }
    public override void Countdown()
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
        }
    
    }
    public void RunActivity()
    {
        Console.WriteLine("Breathe in. ");
        Console.WriteLine("Breathe out. ");


    }
}