// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.

int num = new Random().Next(100, 1000);
{
    if ((-1000 < num && num < -100) || (num < 1000 && num > 100))
        Console.Write($"{num} -> {num / 100 * 10 + num % 10}");
    else
        Console.WriteLine($"{num} -> " + "Error");
}
