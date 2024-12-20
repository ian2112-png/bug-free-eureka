using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        bool running = true;
        while (running)
        {
        Console.WriteLine("Here are the options for this activity. Please enter a number from 1-5");
        Console.WriteLine();
        Console.WriteLine("1. Breathing activity. ");
        Console.WriteLine("2. Reflection activity");
        Console.WriteLine("3. Listing activity");
        Console.WriteLine("4. Imagination activity");
        Console.WriteLine("5. Exit");

        int activityChoice = int.Parse(Console.ReadLine());
        
        switch (activityChoice)
        {
            case 1: 
                BreathingActivity breathing = new("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing. The activity will start momentarily. ");
                breathing.RunActivity();
                break;
            case 2:
                ReflectionActivity reflection = new("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflection.RunActivity();
                break;
            case 3:

                ListingActivity listing1 = new("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listing1.RunActivity();
                break;

                case 4:

                Imagination imagination1 = new("This activity will help you relax your body by using your imagination. ");
                imagination1.RunActivity();
                break;
                
                case 5:
                    Console.WriteLine("Program ended");
                    running = false;
                    break;

            
            default:
                Console.WriteLine("Incorrect entry. ");
                break;
        }
     }
    }
}