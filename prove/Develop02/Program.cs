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
        Console.WriteLine("2. Display Entry");
        Console.WriteLine("3. Save entry"); 
        Console.WriteLine("4. Load Entry"); 
        Console.WriteLine("5.Quit");
        
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

                Console.WriteLine($"The date is {dateText}");
        
                Entry entry1 = new Entry(randomPrompt, response, dateText); //new instance of entry created when the user hits option 1
                journal.AddEntry(entry1); //the add entry method is called and adds entry 1. 
                
                break;
            case 2:
                Console.WriteLine("Displaying entry.");
                journal.DisplayEntries();
                break;

            case 3:
                Console.WriteLine("Feature not yet working");
                break;

            case 4:
                Console.WriteLine("Feature not yet working");
                break;

            case 5:
                running = false;
                break;
            default:
                Console.WriteLine("Invalid choice. Input a number between 1-5");
                break;
        }
        
        } 
        
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