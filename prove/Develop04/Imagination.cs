class Imagination : Activity
{
    private string _specificDescription;

   public Imagination(string specificDescription, string welcomeMessage = "Welcome to the mindfulness activity.", string commonDescription = "This program will help you relax your mind.", int duration = 30, string endMessage ="Good job. Thank you for participating in the breathing activity.") : base(welcomeMessage, commonDescription, duration, endMessage)  
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
        Console.WriteLine("Imagining yourself in a pleasant environment can help to ease anxiety.");
        Console.WriteLine("Imagine yourself in a beautiful, relaxing, or pleasant environment. This could be the beach, a trickling stream, or a place with family or friends.");
        Console.WriteLine(); 
            Thread.Sleep(500);
            for (int i = 9; i > 0; i--)
        {
            Console.Write("\b \b");
            Console.Write(i);
            Thread.Sleep(1000);

            Thread.Sleep(500);
        }
            Console.WriteLine();
            Console.WriteLine("Imagine the sounds and sights around you. ");

            for (int i = 30; i > 0; i--)

        {
            Console.Write("\b\b \b");
            Console.Write(i);
            Thread.Sleep(1000);


        }
        Console.WriteLine();
        

    }
    
}