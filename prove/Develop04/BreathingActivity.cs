class BreathingActivity : Activity
{
    private string _specificDescription;
   public BreathingActivity(string specificDescription)  
   {
    _specificDescription = specificDescription;
   }

    public override string ToString()
    {
        return _specificDescription;
    }
}