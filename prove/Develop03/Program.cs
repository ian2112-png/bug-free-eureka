using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    
    static void Main(string[] args)
    {
        //creating new objects of reference and scripture
        Reference reference1 = new Reference("John", 3, 16); 
        Reference reference2 = new Reference("Ether", 9, 4, 5);
        Scripture scripture1 = new Scripture(reference1);
        Scripture scripture2 = new Scripture(reference2);

        //calling AddScripture with a new Word class with the actual words
        scripture1.AddScripture(new Word("For God so love the world that he gave His Only Begotten Son, that whosever believeth in Him shall not perish but have everlasting life"));
        scripture2.AddScripture(new Word("And it came to pass that Jared was anointed king over the people, by the hand of wickedness; and he gave unto Akish his daughter to wife."));

        //displaying scripture1
        scripture1.Display();

        Console.WriteLine("Welcome to scripture memorization practice. Press enter to practice or type 'quit' to quit");
        string userAnswer = Console.ReadLine();
        //scripture2.Display();

        //while loop that loops while the user presses enter
        while (userAnswer != "quit")
       {
        //clearing the console at the start of each loop. 
        Console.Clear();
         
        //creating variable that holds value from calling HideWords on scripture1
        string hiddenText = (scripture1.HideWords());
        //printing the scripture with some words hidden
        Console.WriteLine(hiddenText);
        //this is an if statement that uses a lambda value to see if each character is either an underscore or space
        if (hiddenText.All(c=> c == '_' || c == ' ' ))
        {
            //if each is an underscore or space then the loop will exit. 
            break;
        }
        Console.WriteLine("Press enter to practice or type 'quit' to quit"); 
        userAnswer = Console.ReadLine();
        

        
       } 
       //print end of program when done. 
       Console.WriteLine("Program ended.");
    }
}