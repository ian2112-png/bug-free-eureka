using System;
using System.Net;
using System.IO;

//creating a class called program to hold the main function
public class Program
{
    
    //creating the main method
    static void Main(string[] args)
    {
        //creating a Journal object (instance) and initializing it
        Journal journal = new Journal();
        
        //creating a Prompt object (instance) and initializing it

        Prompts prompt = new Prompts();
         
        
        
        //welcoming user to the program
        Console.WriteLine("Welcome to the journal program!");

         bool running = true;
        while (running)
        {
        //showing the menu options
        Console.WriteLine("1. Add Entry" );
        Console.WriteLine("2. Delete Entry");
        Console.WriteLine("3. Display Entry");

        Console.WriteLine("4. Save entry"); 
        Console.WriteLine("5. Load Entry"); 
        Console.WriteLine("6.Quit");
        
        //creating a variable called menuchoice and setting it equal to the integer value inputted by user
        int menuChoice = int.Parse(Console.ReadLine());

        //switch statement to go through options, depending on user choice of 1-5 from menu choices.
        
       
        
        switch(menuChoice)
        {
            //if user puts 1, generate random prompt and display it to user
            case 1:
                string randomPrompt = prompt.DisplayPrompt();
                Console.WriteLine($"Prompt: {randomPrompt}");
                string response = Console.ReadLine();

            //set date and time and display it
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString(); 

        
                Entry entry1 = new Entry(randomPrompt, response, dateText); //new instance of entry created when the user hits option 1
                journal.AddEntry(entry1); //the add entry method is called and adds entry 1. 
                
                break;
            //If user inputs 2, entry can be deleted
            case 2:
                
                Console.WriteLine("Please enter the number of the entry you want to delete. ");
                int deletedEntry = int.Parse(Console.ReadLine())-1;
                journal.DeleteEntry(deletedEntry);
                journal.SaveFile("journalEntries.txt");
                break;



            case 3:
                Console.WriteLine("Displaying entry.");
                journal.DisplayEntries();
                break;

            case 4:
                Console.WriteLine("Saving entry. ");
                journal.SaveFile("journalEntries.txt");

                break;

            case 5:
                Console.WriteLine("Feature not yet working");
                journal.LoadFile("journalEntries.txt");
                break;

            case 6:
                running = false;
                break;
            default:
                Console.WriteLine("Invalid choice. Input a number between 1-5");
                break;
        }
        
        } 
        
    }
    
}
