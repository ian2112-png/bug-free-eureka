using System.ComponentModel.DataAnnotations;

class Car
{

    private Tire tires; //declares a new attribute (variable named tires) (class is tire.). must be defined externally to constructor
    public Car() //this is a constructor
    {
        tires = new Tire(205, 55, 16); //initializes new variable
    }

    public void Display ()
    {
        Console.WriteLine("Cars is a movie. ");
        tires.Display();
    }
}