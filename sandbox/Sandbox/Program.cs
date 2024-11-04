using System;

class Program //creating a class
{
    static int AddNumbers (int n1, int n2)  //AddNumbers is a method
    {
        int total = (n1 + n2);
        return total;
    }
    static void Main(string[] args) //Main is a method
    {
        int total = AddNumbers(20, 30);
        Console.WriteLine(total);
    
        Console.WriteLine("Hello bob");
        
        for (int i = 0 ; i < 10; i++) // declares i=0 first, then checks if 0<10, then prints line, then increments. loop continues
        {
            Console.WriteLine(i);
        }
        int age = -1;
        while (age < 0 || age > 120) //while loop will continue as long as the expression is true
        {
            Console.Write("Please enter your age: (0-125) ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your age is: {age}");
        }
        List <string> myColors = new List<string>();  //before = says I am creating list of type string. after = creates new list 
        myColors.Add("Red");
        myColors.Add("Green");
        myColors.Add("Blue");

        foreach (string color in myColors)
        {
            Console.WriteLine(color);
        }
    }
}