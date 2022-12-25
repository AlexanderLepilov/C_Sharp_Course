//Задайте значения M и N.
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

string NaturChisla(int m, int n)
{
    if (m == n)
        return $"{m} ";
    return NaturChisla(m, n - 1) + $"{n} ";
}

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NaturChisla(m, n));
