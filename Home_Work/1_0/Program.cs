// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Write a number: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Write a number: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("num1 больше", num1);
    Console.WriteLine("num2 меньше", num2);
}
else
{
   Console.WriteLine("num2 больше", num2);
   Console.WriteLine("num1 меньше", num1);
}


