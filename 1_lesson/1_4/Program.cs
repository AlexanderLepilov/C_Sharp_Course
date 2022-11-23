// Напишите программу вычесления модуля числа.

Console.WriteLine("Write a number: ");
var s = Console.ReadLine();
int N = s == null ? 0 : int.Parse(s);
Console.WriteLine($"{Math.Abs(N)}");
