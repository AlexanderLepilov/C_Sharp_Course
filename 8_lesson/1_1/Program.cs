// 2. Задайте значения M и N. Напишите программу, которая
//    рекурсивно выведет все натуральные числа в промежутке от M до N.

void number(int m, int n)
{
    if (m > n) return;
    Console.Write($"{m} ");
    number (m + 1, n);
}
number(5, 8);

