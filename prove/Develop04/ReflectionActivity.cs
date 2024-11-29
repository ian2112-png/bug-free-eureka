class ReflectionActivity : Activity
{
   private string _specificDescription;
   public ReflectionActivity(string specificDescription)  
   {
    _specificDescription = specificDescription;
   }
   public override string ToString()
    {
        return _specificDescription;
    }
}
