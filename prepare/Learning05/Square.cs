public class Square : Shape
{
    // private member variable for side length
    private double _side;

    // constructor (doesn't return types) accepts color & side
    // calls the base constructor with the color
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    // override method or function to return area of square
    public override double GetArea()
    {
        return _side * _side;
    }
}