// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Write a number: ");
string NumberA(int num)
{
    if ((-1000 < num && num < -100) || (num < 1000 && num > 100))
        return $"{num / 10 % 10}";
    return "Error";
}

Console.Write(NumberA(int.Parse(Console.ReadLine())));