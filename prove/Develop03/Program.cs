using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<Reference, Word> scriptures = new Dictionary<Reference, Word>();
        Reference reference1 = new Reference("John", 3, 16); 
        Reference reference2 = new Reference("Ether", 9, 4, 5);

        Scripture scripture1 = new Scripture(reference1);
        Scripture scripture2 = new Scripture(reference2);

        PickaScripture picker = new PickaScripture();
        picker.AddScripture(new Reference("John", 2,5), new Word("His mother saith unto the servants, Whatsoever he saith unto you, do it."));
        picker.AddScripture(new Reference("Ether", 13,4), new Word("Behold, Ether saw the days of Christ, and he spake concerning a New Jerusalem upon this land."));
        picker.AddScripture(new Reference("Helaman", 7,3), new Word("And they did reject all his words, insomuch that he could not stay among them, but returned again unto the land of his nativity."));

       // scripture1.AddScripture(new Word("For God so loved the world that he gave His Only Begotten Son, that whosoever believeth in Him shall not perish but have everlasting life."));
       // scripture2.AddScripture(new Word("And it came to pass that Jared was anointed king over the people, by the hand of wickedness; and he gave unto Akish his daughter to wife."));
        
        
       // scripture1.Display();

        Console.WriteLine("Welcome to scripture memorization practice. Press enter to practice or type 'quit' to quit");
        string userAnswer = Console.ReadLine();
        Scripture randomScripture = picker.GetRandom();
    
        while (userAnswer != "quit")
        {
            Console.Clear();
            randomScripture.Display();
            string hiddenText = randomScripture.HideWords();
            

            if (hiddenText.All(c => c == '_' || c == ' '))
            {
                break;
            }
            
            Console.WriteLine("Press enter to practice or type 'quit' to quit"); 
            userAnswer = Console.ReadLine();
        }

        Console.WriteLine("Program ended.");
    }
}
