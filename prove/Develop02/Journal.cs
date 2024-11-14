using System;
using System.Collections.Generic;
public class Journal
{
   public List<Entry> _entries;
   private int _wordCount;


    public Journal()
    {
        _entries = new List<Entry>();
    }
      public void AddEntry(Entry entry)
   {
      _entries.Add(entry);
   }
    public void DisplayEntries()
   {
    Console.WriteLine(_entries);
   }


}

