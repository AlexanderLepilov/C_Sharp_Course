// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray(int[] number)
{
    int length = number.Length;

    for (int index = 0; index < length; index++)
        Console.Write($"{number[index]} ");
}
Console.WriteLine();

int[] MassNums(int size, int from, int to)
{
    int[] number = new int[size];

    for (int index = 0; index < size; index++)
        number[index] = new Random().Next(from, to);

    return number;
}

int Num(int[] number)
{
    int count = 0;

    for (int index = 0; index < number.Length; index++)
    {
        if (number[index] % 2 == 0)
            count++;
    }
    return count;
}

int[] number1 = MassNums(int.Parse(Console.ReadLine()),
                         int.Parse(Console.ReadLine()),
                         int.Parse(Console.ReadLine()));
FillArray(number1);
Console.WriteLine(Num(number1));





