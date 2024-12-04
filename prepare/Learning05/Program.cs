using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new(5);
        square.SetColor("red");


        Rectangle rectangle = new(5.3,7.2);
        rectangle.SetColor("brown");
        Circle circle = new(4.8);
        circle.SetColor("pink");

        List<Shape> shapes = [square, rectangle, circle];

        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()} {shape.GetArea()}");
        }


    }
}