using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Shape square = new Square("blue",12);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());
    
    Shape circle = new Circle("green",5);
    Console.WriteLine(circle.GetColor());
    Console.WriteLine(circle.GetArea());

    Shape rectangle = new Rectangle("red",5, 4);
    Console.WriteLine(rectangle.GetColor());
    Console.WriteLine(rectangle.GetArea());
    }
        

}