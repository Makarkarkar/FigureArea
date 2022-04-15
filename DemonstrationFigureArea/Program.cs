using FigureArea;
class Program
{
    static void Main(string[] args)//Консольное приложение для явной демонстрации работы классов.
    {
        Triangle triangle1 = new Triangle();
        triangle1.A = 3;
        triangle1.B = 4;
        triangle1.C = 5;
        Triangle triangle2 = new Triangle(7,6,3);
        Triangle triangle3 = new Triangle(5,12,13);
        triangle1.GetArea();
        Console.WriteLine($"Площадь треугольника 1: {triangle1.GetArea()}");
        Console.WriteLine(triangle1.RightTriangle() ? "Треугольник ранободренный":"Треугольник не равнобедренный" );
        triangle2.GetArea();
        Console.WriteLine($"Площадь треугольника 2: {triangle2.GetArea()}");
        Console.WriteLine(triangle2.RightTriangle() ? "Треугольник ранободренный" : "Треугольник не равнобедренный");
        triangle3.GetArea();
        Console.WriteLine($"Площадь треугольника 3: {triangle3.GetArea()}");
        Console.WriteLine(triangle3.RightTriangle() ? "Треугольник ранободренный" : "Треугольник не равнобедренный");
        Circle circle1 = new Circle(5);
        circle1.GetArea();
        Console.WriteLine($"Площадь круга 1: {circle1.GetArea()}");
    }
}

