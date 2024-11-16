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
   //method created to save list to a .txt file
   public void SaveFile(string journalFile)
   {
      //creates a variable to store the journalFile in
      using (StreamWriter outputFile = new StreamWriter(journalFile))
      {
         //for loop that loops through each entry in the list
         foreach (Entry entry in _entries)
         {
            //writes or saves the prompt, response, and date to the .txt file.
            outputFile.WriteLine($"{entry.Prompt}|{entry.Response}|{entry.Date}");
         }
      }
   }
   //method created to load all of the entries
   public void LoadFile(string journalFile)
   {
      //clears the entry list before adding them to avoid a duplicate, since an add method is called in case 1 of the program switch statement
      _entries.Clear();
      
      //reads all lines from the journalFile and stores them in an array called lines
      string [] lines = System.IO.File.ReadAllLines(journalFile);
      
      //loops through each line in the lines array
      foreach(string line in lines)
      {
         //splits each line into a part and stores it in an array. the | is used because it doesn't show up and can be used to separate prompt, response and date
         string[] parts = line.Split("|") ;

         //creates a new instance of the Entry class and names it entry. Calls Entry constructor and passes parts index to it, effectively passing prompt, response, and date
         Entry entry = new Entry(parts[0], parts[1], parts[2]);
         //Adds the entry to the list
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


