// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Write a number: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Write a number: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
Console.WriteLine($"max = {num1}");
Console.Write($"min = {num2}");
}
else if (num2 > num1)
{
Console.WriteLine($"max = {num2}");
Console.Write($"min = {num1}");
}
else
{
Console.Write("Числа равны, не возможно определить min и max");
}
