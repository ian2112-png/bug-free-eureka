using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment simpleAssignment = new("Ian", "EE");
        Console.WriteLine(simpleAssignment.GetSummary());

       MathAssignment assignment1 = new MathAssignment("Ian", "EE", "12", "5-7");
       Console.WriteLine($"{assignment1.GetSummary()} Section: {assignment1.GetHomeworkList()}");
       
       WritingAssignment assignment2 = new WritingAssignment("Ian", "EE", "Essay");
       Console.WriteLine($"{assignment2.GetSummary()}, {assignment2.GetWritingInformation()}");

    }

}