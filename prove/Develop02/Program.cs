using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal program!");
        Journal journal = new Journal();

         Entry entry1 = new Entry("This is a place holder for the prompt", "This is a placeholder for the response ", "This is a place holder for the date. ");
        journal._entries.Add(entry1);
        journal.DisplayEntries();

        entry1.Display();



    }
    
}
//For split in order to index, put a command to user to put a $ at the end of their journal entry.
//This way I can access it with an index during the split. 
// Journal nouns: 
// -entry
//  -prompts
// -journal
//-menu
//-program 