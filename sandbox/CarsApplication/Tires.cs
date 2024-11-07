class Tire
{
    //creating 3 private variables
    private double width;
    private double radius;

    private double aspectRatio;

//creating a constructor
    public Tire(double width, double aspectRatio, double radius)
    {
        //the width on this parameter is equal to the width that is passed in. 
        //the radius on this parameter is equal to the width that is passed in.
        //the aspect ratio on this parameter is equal to the width thta is passed in.
        this.width = width; // in mm
        this.radius = radius; // in inches
        this.aspectRatio = aspectRatio; //height to width ratio
    }
    public void Display()
    {
        Console.WriteLine($"Tire width: {width}, tire radius: {radius}, \n tire aspect ratio: {aspectRatio}");
    }
}