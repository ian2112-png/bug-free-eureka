class BreathingActivity : Activity
{
    private string _specificDescription;
   public BreathingActivity(string specificDescription, string welcomeMessage = "Welcome to the mindfulness activity.", string commonDescription = "This program will help you relax your mind.", int duration = 30, string endMessage ="Good job. Thank you for participating in the breathing activity.") : base(welcomeMessage, commonDescription, duration, endMessage)  
   {

    _specificDescription = specificDescription;
   }

    public override void DisplayWelcomeMessage()
    {
        //I got help with the virtual/override from copilot AI. 

        base.DisplayWelcomeMessage();
        Console.WriteLine(_specificDescription);
    }
    public override void PerformingActivity()
    {
        Console.WriteLine("Breathe in...");
            Thread.Sleep(4000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(4000);
    }
    public void RunActivity()
    {
        DisplayWelcomeMessage();
        DisplayAnimation();
        DurationTimer();


    }
}