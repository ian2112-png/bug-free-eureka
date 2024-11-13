using System;
public class Entry
{
    private string Prompt; 
    private string Response;
    private string Date;

    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date; 
    }
     public void Display()
    {
        Console.WriteLine($"This entry includes Prompt: {Prompt}, Response: {Response}, Date: {Date}");
    }
}