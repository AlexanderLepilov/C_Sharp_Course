// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double[] number)
{
    int length = number.Length;

    for (int index = 0; index < length; index++)
        Console.Write($"{number[index]} ");
}
Console.WriteLine();

double[] MassNums(int size, int from, int to)
{
    double[] number = new double[size];
    Random n_new = new Random();

    for (int index = 0; index < size; index++)
        number[index] = Math.Round(n_new.NextDouble() * (from + to) - from, 2);

    return number;
}

void DiffMaxMin(double[] number)
{
    double n_max = number[0];
    double n_min = number[0];

    for (int i = 1; i < number.Length; i++)
    {
        if (n_max < number[i])
            n_max = number[i];

        else if (n_min > number[i])
            n_min = number[i];
    }

    Console.Write($"Max: {n_max}, min: {n_min}. ");
    Console.WriteLine($"Difference: {n_max} - ({n_min}) = {Math.Round(n_max - n_min, 2)}");
}

double[] number1 = MassNums(int.Parse(Console.ReadLine()),
                          int.Parse(Console.ReadLine()),
                          int.Parse(Console.ReadLine()));
FillArray(number1);
DiffMaxMin(number1);