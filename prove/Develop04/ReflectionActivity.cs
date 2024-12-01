class ReflectionActivity : Activity
{
   private string _specificDescription;
   private List<string> _prompts = new List<string>();
   private List<string> _reflectionQuestions = new List<string>();

   public ReflectionActivity(string specificDescription)  
   {
    _specificDescription = specificDescription;
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
