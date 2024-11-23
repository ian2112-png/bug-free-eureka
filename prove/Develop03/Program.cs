using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("John", 3, 16); 
        Reference reference2 = new Reference("Ether", 9, 4);
        Scripture scripture1 = new Scripture(reference1);
        Scripture scripture2 = new Scripture(reference2);

        
        scripture1.AddScripture(new Word("For God so love the world that he gave His Only Begotten Son, that whosever believeth in Him shall not perish but have everlasting life"));
        scripture2.AddScripture(new Word("And it came to pass that Jared was anointed king over the people, by the hand of wickedness; and he gave unto Akish his daughter to wife."));

        scripture1.Display();

        Console.WriteLine("Welcome to scripture memorization practice. Press enter to practice or type 'quit' to quit");
        string userAnswer = Console.ReadLine();
        //scripture2.Display();

        while (userAnswer != "quit")
       {
        Console.Clear();
         
       // Console.Clear();
        string hiddenText = (scripture1.HideWords());
        Console.WriteLine(hiddenText);
        if (hiddenText.All(c=> c == '_' || c == ' ' ))
        {
            break;
        }
        Console.WriteLine("Press enter to practice or type 'quit' to quit");
        userAnswer = Console.ReadLine();

        
       } 
       Console.WriteLine("Program ended.");
    }
}