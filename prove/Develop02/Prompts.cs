using System;
using System.Collections.Generic;


public class Prompts
{
   private List<string> _Prompt; 
   public Prompts()
    {
        _Prompt = new List<string>();
        _Prompt.Add("Who was the most interesting person I interacted with today?");
        _Prompt.Add("What was the best part of my day?");
        _Prompt.Add("What was the strongest emotion I felt today?");
        _Prompt.Add("If I had one thing I could do over today, what would it be?");
        _Prompt.Add("How did I see the hand of the Lord in my life today?");
        _Prompt.Add("Who was the most interesting person I interacted with today?");
        _Prompt.Add("Who was the most interesting person I interacted with today?");
        
    //Random prompt = new Random();
    }  
    public void DisplayPrompt()
    {
        foreach(string prompt in _Prompt )
        {
        Console.WriteLine(prompt);
        }
    }  
}

