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
            Thread.Sleep(2000);
            for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Console.Write("\b \b");
            Thread.Sleep(1000);

        }
        Console.WriteLine();
        Thread.Sleep(2000);
            Console.WriteLine("Breathe out...");
            for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Console.Write("\b \b");
            Thread.Sleep(1000);

        }
         Console.WriteLine();
        Thread.Sleep(2000);

    }
    public void RunActivity()
    {
        DisplayWelcomeMessage();
        DisplayAnimation();
        DurationTimer();


    }
}