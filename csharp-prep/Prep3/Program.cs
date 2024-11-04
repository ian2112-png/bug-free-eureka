using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,25);
        
        Console.WriteLine("Hello user. Guess the magic number ");
        int userNumber;
        do //do while loop guaranteed to run at least once
        {
            Console.WriteLine("What is your guess?");
            string guess = Console.ReadLine();
            userNumber = int.Parse(guess);
            
            
            if (userNumber == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (userNumber < magicNumber)
            {
                Console.WriteLine("Higher!"); 
            }
            else if (userNumber > magicNumber)
            {
                Console.WriteLine("Lower!");

            }
        }while (userNumber != magicNumber);


    }
}