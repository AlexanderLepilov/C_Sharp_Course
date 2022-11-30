// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.

Console.WriteLine("Write a number: ");
string NumberA(int num)
{
    if ((-1000 < num && num < -99) || (num < 1000 && num > 99))
        return $"{num / 100 * 10 + num % 10}";
    return "Error";
}
Console.Write(NumberA(int.Parse(Console.ReadLine())));