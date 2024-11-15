using System;

//creating a public class called Entry
public class Entry
{
    //creating fields of type string 
    public string Prompt;
    public string Response;
    public string Date;

    //creating Entry constructor with parameters prompt, response, and date
    public Entry(string prompt, string response, string date)
    {
        //setting parameters to the field (attributes above)
        Prompt = prompt;
        Response = response;
        Date = date; 
    }
    //creating a method to display the prompt, response, and date
     public void Display()
    {
        //displaying the prompt, response, and date
        Console.WriteLine($"This entry includes Prompt: {Prompt}, Response: {Response}, Date: {Date}");
    }
}