// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Write k1: ");
Console.WriteLine("Write b1: ");
Console.WriteLine("Write k2: ");
Console.WriteLine("Write b2: ");

void Intersection(double k1, double b1, double k2, double b2)
{
    double N = k1 - k2;
    if (N != 0)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Intersection point: ({x}; {y})");
    }
    else if (k1 == k2 && b1 == b2)
        Console.WriteLine("There are an infinite number of intersection points.");
    else
        Console.WriteLine("There is no intersection point");
}

Intersection(int.Parse(Console.ReadLine()),
             int.Parse(Console.ReadLine()),
             int.Parse(Console.ReadLine()),
             int.Parse(Console.ReadLine()));


