// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Write a number");
int N = int.Parse(Console.ReadLine());

int A = 2;

while (A <= N)
{
Console.Write($"{A} ");
A += 2;
}
