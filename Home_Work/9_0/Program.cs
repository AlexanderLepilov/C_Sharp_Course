// Задайте значение N. Напишите программу, которая выведет все четные натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.

void NaturChisla (int a)
{
    if (a == 0) return;
    NaturChisla (a - 1);
    if (a % 2 == 0)
        Console.Write($"{a} ");
}
NaturChisla (5);