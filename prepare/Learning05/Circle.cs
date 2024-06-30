public class Circle : Shape
{
    // private member variable for side length
    private double _radius;

    // constructor (doesn't return types) accepts color & radius
    // calls the base constructor with the color
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    // override method or function to return area of circle
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
        // solution shows math this way
        // return _radius * _radius * Math.PI;
    }
}