public class Rectangle : Shape
{
    // private member variable for side length
    private double _width;
    private double _height;

    // constructor (doesn't return types) accepts color, width, and height
    // calls the base constructor with the color
    public Rectangle(string color, double width, double height) : base(color)
    {
        _width = width;
        _height = height;
    }
    // override method or function to return area of rectangle
    public override double GetArea()
    {
        return _width * _height;
    }
}