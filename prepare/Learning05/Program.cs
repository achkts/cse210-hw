using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square square = new Square("blue", 5);
        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("red", 7, 9);
        // Console.WriteLine(rectangle.GetColor());
        // Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("orange", 9.5);
        // Console.WriteLine(circle.GetColor());
        // Console.WriteLine(circle.GetArea()); 


        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        shapes.ForEach(s => {
            Console.WriteLine($"The {s.GetColor()} {s} has an area of {s.GetArea()}.");
        });



    }


}