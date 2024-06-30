using System;

class Program
{
    static void Main(string[] args)
    {
      // create list to hold all the shapes
      List<Shape> shapes = new List<Shape>();
      // now lets add the shapes to the list
      // shapes.Add(new Square("pink", 2));
      // shapes.Add(new Rectangle("yellow", 2, 3));
      // shapes.Add(new Circle("purple", 7));

      // the solution helps ONLY work if i write the lists like this :(
        Square shape1 = new Square("pink", 2);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("yellow", 2, 3);
        shapes.Add(shape2);
  
        Circle shape3 = new Circle("purple", 7);
        shapes.Add(shape3);

      // iterate through the list of the shapes
      foreach (Shape shape in shapes)
      {
        // display the shapes color and area
        // Console.WriteLine("Color: " + shape._color);
        // Console.WriteLine("Area: " + shape.GetArea());

        // i like the solution console better
        //all shapes have a GetColor method or function from base class
        string color = shape.GetColor();
        // all shapes have a GetArea method or function but
        // each shapes uses different math
        double area = shape.GetArea();
        Console.WriteLine($"The {color} shape has an area of {area}.");
      }

      // // create square isntance
      // Square _square = new Square("pink", 2);
      // // call methods or functions and print result
      // Console.WriteLine("Square - Color: " + _square._color);
      // Console.WriteLine("Square - Area: " + _square.GetArea());

      // // create rectangle isntance
      // Rectangle _rectangle = new Rectangle("yellow", 2, 3);
      // // call methods or functions and print result
      // Console.WriteLine("Rectangle - Color: " + _rectangle._color);
      // Console.WriteLine("Rectangle - Area: " + _rectangle.GetArea());

      // // create circle isntance
      // Circle _circle = new Circle("purple", 7);
      // // call methods or functions and print result
      // Console.WriteLine("Circle - Color: " + _circle._color);
      // Console.WriteLine("Circle - Area: " + _circle.GetArea());
    }
}