class ListingActivity : Activity
{
   private string _specificDescription;
   private List<string> _prompts = new List<string>();

      public ListingActivity(string specificDescription, string welcomeMessage = "Welcome to the mindfulness activity.", string commonDescription = "This program will help you relax your mind.", int duration = 30, string endMessage ="Good job. Thank you for participating in the listing activity.") : base(welcomeMessage, commonDescription, duration, endMessage) 

   {
    _specificDescription = specificDescription;
    _prompts.Add("Who are people that you appreciate?");
    _prompts.Add("What are personal strengths of yours?");
    _prompts.Add("Who are people that you have helped this week?");
    _prompts.Add("When have you felt the Holy Ghost this month?");
    _prompts.Add("When have you felt the Holy Ghost this month?");
    _prompts.Add("Who are some of your personal heroes?");


   }
//    public override string ToString()
//     {
//         return _specificDescription;
//     }
    public override void DisplayWelcomeMessage()
    {

        base.DisplayWelcomeMessage();
        Console.WriteLine(_specificDescription);
    }
    public string RandomPrompt()
   {
    Random random3 = new Random();
    int index3 = random3.Next(_prompts.Count);
    return _prompts[index3];
   }
   public override void PerformingActivity()
    {
        //Thread.Sleep(1000);
       
        Console.WriteLine("Enter an answer. ");
        Console.ReadLine();

        


    }
public override void DurationTimer()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        Console.WriteLine("Please reflect on this question and write a list. You can press enter after each submission.");
        DisplayAnimation();
        
        string prompt = RandomPrompt();
        Console.WriteLine(prompt);
        int i = 0;
        while (currentTime < futureTime)
        {
            PerformingActivity();
            currentTime = DateTime.Now;
            i++;
        }
        Thread.Sleep(1000);
        Console.WriteLine(_endMessage);
        Console.WriteLine($"You did the activity for {_duration} seconds");
        Console.WriteLine($"You entered {i} items");
    }

}
