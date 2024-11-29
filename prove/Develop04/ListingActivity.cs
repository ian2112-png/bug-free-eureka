class ListingActivity : Activity
{
   private string _specificDescription;
   public ListingActivity(string specificDescription)  
   {
    _specificDescription = specificDescription;
   }
   public override string ToString()
    {
        return _specificDescription;
    }
}
