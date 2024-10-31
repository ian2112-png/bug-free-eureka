using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello user. What percentage did you get?");
        string Grade = Console.ReadLine();

        int number = int.Parse(Grade);

        string letter = "";
        int remainder = number % 10;

        if (number >=90)
        {
            letter = "A";

            // Console.WriteLine("You got an A");
            if (remainder >= 3)

            letter = "A";

            else
            {
                letter = "A-";
            }

        }
        else if (number >=80)
        {
            // Console.WriteLine("You got a B.");
            letter = "B";
            if (remainder >= 3)

            letter = "B+";

            else if (remainder == 3)
            {
                letter = "B";
            }

            else
            {
                letter = "B-";
            }

        }
        else if (number >=70)
        {
            // Console.WriteLine("You got a C.");
            letter = "C";
            if (remainder >= 3)

            letter = "C+";

            else if (remainder == 3)
            {
                letter = "C";
            }

            else
            {
                letter = "C-";
            }

        }
        else if (number >=60)
        {
            // Console.WriteLine("You got a D.");
            letter = "D";
            
            if (remainder >= 3)

            letter = "D+";

            else if (remainder == 3)
            {
                letter = "D";
            }

            else 
            {
                letter = "D-";
            }

        }
        else if (number <60)
        {
            // Console.WriteLine("You got an F.");
            letter = "F";

        }
            if (number >=70)
            {
                Console.WriteLine("You passed the class! Congratulations!");
            }
            else
            {
                Console.WriteLine("You did not pass the class. Please see the teacher for a retake.");
            }
            Console.WriteLine($"You got a {letter}");



    
    }
}