using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square s = new Square("blue", 5);
        shapes.Add(s);
        Rectangle r = new Rectangle("red", 2, 5);
        shapes.Add(r);
        Circle c = new Circle("green", 1);
        shapes.Add(c);

        foreach (Shape shape in shapes) {
            Console.WriteLine($"{shape.GetColor()}, {shape.GetArea()}");
        }
    }
}