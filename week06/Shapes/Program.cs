using System;

class Program
{
    static void Main(string[] args)
    {
        Square SquareShape = new Square();
        SquareShape.Color = "Red";
        SquareShape.SideLength = 5.0;
        Console.WriteLine($"Square Area: {SquareShape.GetArea()}");

        Circle circleShape = new Circle();
        circleShape.Color = "Blue";
        circleShape.Radius = 3.0;
        Console.WriteLine($"Circle Area: {circleShape.GetArea()}");

        Rectangle rectangleShape = new Rectangle();
        rectangleShape.Color = "Green";
        rectangleShape.Length = 4.0;
        rectangleShape.Width = 6.0;
        Console.WriteLine($"Rectangle Area: {rectangleShape.GetArea()}");
        
        List<Shape> shapes = new List<Shape>();
        shapes.Add(SquareShape);
        shapes.Add(circleShape);
        shapes.Add(rectangleShape);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
    }

}