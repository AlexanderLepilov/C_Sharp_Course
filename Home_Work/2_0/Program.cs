// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Write a number: ");
int num = int.Parse(Console.ReadLine());
{
    if ((-1000 < num && num < -100) || (num < 1000 && num > 100))
        Console.Write($"{num} -> {num / 10 % 10}");
    else
        Console.WriteLine($"{num} -> " + "Error");
}
