// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Write a number1: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Write a number2: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Write a number3: ");
int c = int.Parse(Console.ReadLine());

int max = a;

if (b > max)
{
    Console.WriteLine(max = b);
}
if (c > max)
{
    Console.WriteLine(max = c);
}
Console.Write("max = ");
Console.WriteLine(max);


