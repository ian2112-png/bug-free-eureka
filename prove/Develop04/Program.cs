using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Activity activity1 = new();
        // activity1.DisplayWelcomeMessage();
        // activity1.DisplayAnimation();

        Console.WriteLine("Here are the options for this activity. Please enter a number from 1-3");
        Console.WriteLine("1. Breathing activity. ");
        Console.WriteLine("2. Reflection activity");
        Console.WriteLine("3. Listing activity");

        int activityChoice = int.Parse(Console.ReadLine());
        
        switch (activityChoice)
        {
            case 1: 
                BreathingActivity breathing = new("You have opted for the breathing activity. ");
                breathing.DisplayWelcomeMessage();
                Console.WriteLine(breathing);
                breathing.DisplayAnimation();
                break;
            case 2:
                ReflectionActivity reflection = new("You have opted for the reflection activity. ");
                reflection.DisplayWelcomeMessage();
                Console.WriteLine(reflection);
                reflection.DisplayAnimation();
                break;
            case 3:

                ListingActivity listing1 = new("You have opted for the listing activity. ");
                listing1.DisplayWelcomeMessage();
                Console.WriteLine(listing1);
                listing1.DisplayAnimation();
                break;

            
            default:
                Console.WriteLine("Incorrect entry. ");
                break;
        }
     }
}