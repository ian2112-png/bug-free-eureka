class ReflectionActivity : Activity
{
   private string _specificDescription;
   private List<string> _prompts = new List<string>();
   private List<string> _reflectionQuestions = new List<string>();

   public ReflectionActivity(string specificDescription)  
   {
    _specificDescription = specificDescription;
    
    _prompts.Add("Think of a time when you stood up for someone else.");
    _prompts.Add("Think of a time when you did something really difficult.");
    _prompts.Add("Think of a time when you helped someone in need.");
    _prompts.Add("Think of a time when you did something truly selfless.");

    _reflectionQuestions.Add("Why was this experience meaningful to you?");
    _reflectionQuestions.Add("Have you ever done anything like this before?");
    _reflectionQuestions.Add("How did you get started?");
    _reflectionQuestions.Add("How did you feel when it was complete?");
    _reflectionQuestions.Add("What made this time different than other times when you were not as successful?");
    _reflectionQuestions.Add("What is your favorite thing about this experience?");
    _reflectionQuestions.Add("What could you learn from this experience that applies to other situations?");
    _reflectionQuestions.Add("What did you learn about yourself through this experience?");
    _reflectionQuestions.Add("How can you keep this experience in mind in the future?");
    
   }
   public override string ToString()
    {
        return _specificDescription;
    }
    public void AddPrompts(string prompt)
    {
        _prompts.Add(prompt);
    }
    public void AddQuestions(string question)
    {
        _reflectionQuestions.Add(question);
    }
    public string RandomPrompt()
   {
    Random random1 = new Random();
    int index1 = random1.Next(_prompts.Count);
    return _prompts[index1];
   }
   public string RandomQuestion()
   {
    Random random2 = new Random();
    int index2 = random2.Next(_reflectionQuestions.Count);
    return _reflectionQuestions[index2];
   }
}
