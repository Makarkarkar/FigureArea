using FigureArea;
class Program
{
    static void Main(string[] args)//A console application for an explicit demonstration of the work of classes.
    {
        Triangle triangle1 = new Triangle();
        triangle1.A = 3;
        triangle1.B = 4;
        triangle1.C = 5;
        Triangle triangle2 = new Triangle(7,6,3);
        Triangle triangle3 = new Triangle(5,12,13);
        triangle1.GetArea();
        Console.WriteLine($"The area of the triangle 1: {triangle1.GetArea()}");
        Console.WriteLine(triangle1.RightTriangle() ? "The triangle is rectangular.":"The triangle is not rectangular." );
        triangle2.GetArea();
        Console.WriteLine($"The area of the triangle 2: {triangle2.GetArea()}");
        Console.WriteLine(triangle2.RightTriangle() ? "The triangle is rectangular." : "The triangle is not rectangular.");
        triangle3.GetArea();
        Console.WriteLine($"The area of the triangle 3: {triangle3.GetArea()}");
        Console.WriteLine(triangle3.RightTriangle() ? "The triangle is rectangular." : "The triangle is not rectangular.");
        Circle circle1 = new Circle(5);
        circle1.GetArea();
        Console.WriteLine($"The area of the circle 1: {circle1.GetArea()}");
    }
}

