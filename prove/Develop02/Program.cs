using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal program!");
        Journal journal = new Journal();
        journal.DisplayEntries();
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