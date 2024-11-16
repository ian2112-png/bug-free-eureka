using System;
using System.Collections.Generic;


//creating a public class called Prompts
public class Prompts
{
    //creating a private string called _Prompt
   private List<string> _prompt; 
    //creating a constructor for Prompts with no parameters
   public Prompts()
    {
        //initializing list of prompts
        _prompt = new List<string>();

        //adding prompts to the list
        _prompt.Add("Who was the most interesting person I interacted with today?");
        _prompt.Add("What was the best part of my day?");
        _prompt.Add("What was the strongest emotion I felt today?");
        _prompt.Add("If I had one thing I could do over today, what would it be?");
        _prompt.Add("How did I see the hand of the Lord in my life today?");
        _prompt.Add("What would my older self most want to remember about today?");
        _prompt.Add("How did I become a better person today than I was yesterday?");
    }  
   
   //creating a method called RandomPrompt to generate a prompt at random from the list
    public string RandomPrompt()
    {
        //setting randomPrompt to a new random
        Random randomPrompt = new Random();
        //setting variable of type int called index to a prompt at random, using the length of the prompts list.
        int index = randomPrompt.Next(_prompt.Count);
        //returning the prompt that lies at the index chosen at random
        return _prompt[index];
        
    }
    //creating a method that displays the random prompt
     public string DisplayPrompt()
    {
        //creating a variable to hold the random prompt
       string prompt = RandomPrompt();
        //displaying the random prompt
       Console.WriteLine(prompt);
        //returns the prompt string
        return prompt;
    }  
}

