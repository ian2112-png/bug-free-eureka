using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
       DisplayWelcome();
       string name = PromptUserName();
      int number = PromptUserNumber();
      int square = SquareNumber(number);
      DisplayResult(name, square);
    }
    static void DisplayWelcome ()
    {
        Console.WriteLine("This is the display message");
    }
    static string PromptUserName ()
    {
        Console.Write("What is your name, user? ");
        string firstName = Console.ReadLine();
        return firstName;
    }
    static int PromptUserNumber ()
    {
        Console.Write("What is your favorite number, user? ");
        int favorite = int.Parse(Console.ReadLine());
        return favorite;
    } 
    static int SquareNumber (int squaredNumber)
    {
        return squaredNumber*squaredNumber;
    } 
    static void DisplayResult (string name, int square)
    {
        Console.WriteLine($"{name}, your number squared is {square}");
    }
}

