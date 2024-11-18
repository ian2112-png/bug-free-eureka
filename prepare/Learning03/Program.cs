using System;
//creating program class
class Program
{
    //creating main method
    static void Main(string[] args)
    {
        //creating new Fraction object with no parameters
        Fraction fraction1 = new Fraction();
        //printing fraction string for fraction1
        Console.WriteLine(fraction1.GetFractionString());
       
        //creating new Fraction object with 1 parameter
        Fraction fraction2 = new Fraction(4);
        //printing fraction string for fraction2
        Console.WriteLine(fraction2.GetFractionString());

        //creating new Fraction object with 2 parameters
        Fraction fraction3 = new Fraction(3,4);
        //printing fraction string for fraction3
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        fraction1.SetTop(5);
        fraction1.SetBottom(3);
        Console.WriteLine(fraction1.GetTop());
        Console.WriteLine(fraction1.GetBottom());
        }
}