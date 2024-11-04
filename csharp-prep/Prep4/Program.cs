using System;
using System.Net;
using System.Collections.Generic;
using System.Globalization;

class Program
{

    static void Main(string[] args)
    {
        int newNumber = -1;
       
        List <int> numberList = new List<int>();
        do
        {
            Console.Write("Please enter a number and type 0 when done: ");
            newNumber = int.Parse(Console.ReadLine());
            if (newNumber != 0)
            {
            numberList.Add(newNumber);
            }
            else
            {
             Console.WriteLine("Your list of numbers will now terminate. ");
            }
        }    while (newNumber != 0);

        Console.WriteLine("Your numbers are: ");
        int total = 0;
        int average = 0;
        double largest = -1E9;
        //int largest = 0;
        foreach (int number in numberList)
        {
            Console.WriteLine(number);
            total += number;
            average = total / numberList.Count;
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The total is {total}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {largest}");
        
    }
}