using System;

public class Shape
{
    // color member variable
    private string Color;
    // getter & setter of color
    // public string _color
    // {
    //     get { return Color; }
    //     set { Color = value; }
    // }

    // constructure accepting color
    public Shape(string color)
    {
        Color = color;
    }
    public string GetColor()
    {
        return Color;
    }
    public void SetColor(string color)
    {
        Color = color;
    }

    // solution doesn't like what i did here:
    // virtual method or function
    // public virtual double GetArea()
    {
        // this method or function should get overrideen in/why(?) derived classes
       // return 0;
    }
    public abstract double GetArea();
}