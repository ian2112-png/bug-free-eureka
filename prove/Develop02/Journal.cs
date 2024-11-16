using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

//creating a public class called journal
public class Journal
{
   //creating a new list of entries of type Entry 
   public List<Entry> _entries;
   //creating a variable of type integer to hold the list


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
   public void DeleteEntry(int index)
   {
      _entries.RemoveAt(index);
   }
   //creating a method to display the entries
    public void DisplayEntries()
   {
      //displaying the entries
    foreach (Entry entry in _entries)
    {
    entry.Display();
    
    }
   }
   public void SaveFile(string journalFile)
   {
      using (StreamWriter outputFile = new StreamWriter(journalFile))
      {
         foreach (Entry entry in _entries)
         {
            outputFile.WriteLine($"{entry.Prompt}|{entry.Response}|{entry.Date}");
         }
      }
   }
   public void LoadFile(string journalFile)
   {
      _entries.Clear();
      string [] lines = System.IO.File.ReadAllLines(journalFile);
      
      foreach(string line in lines)
      {
         string[] parts = line.Split("|") ;
         Entry entry = new Entry(parts[0], parts[1], parts[2]);
         _entries.Add(entry);

      }

   }
   public int WordCount()
   {
         int count = 0;

      foreach (Entry entry in _entries)
      {
         string [] words = entry.Response.Split(" ", StringSplitOptions.RemoveEmptyEntries);
         count += words.Length;
         Console.WriteLine(count);
      }
      return count;
   }
}


