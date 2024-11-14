using System;
using System.Collections.Generic;

//creating a public class called journal
public class Journal
{
   //creating a new list of entries of type Entry 
   public List<Entry> _entries;
   //creating a variable of type integer to hold the word count
   private int _wordCount;


   //creating the journal constructor 
    public Journal()
    {
      //initializing the _entries list to a new list
        _entries = new List<Entry>();
    }
    //creating a method to add entries to the entry list
      public void AddEntry(Entry entry)
   {
      //adding entries to the list
      _entries.Add(entry);
   }
   //creating a method to display the entries
    public void DisplayEntries()
   {
      //displaying the entries
    foreach (Entry entry in _entries)
    {
    entry.Display();
    Console.WriteLine(entry);
    }
   }
}


