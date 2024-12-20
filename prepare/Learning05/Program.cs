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

    List<Shape> shapes = new List<Shape>();
    shapes.Add(square);
    shapes.Add(circle);
    shapes.Add(rectangle);

    foreach (Shape shape in shapes)
    {
        Console.WriteLine(shape.GetColor());
        Console.WriteLine(shape.GetArea());

    }
    
    }
        

}