// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

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

int OddNumSum(int[] number)
{
    int count = 0;

    for (int index = 0; index < number.Length; index += 2)
        count += number[index];
    return count;
}

int[] number1 = MassNums(int.Parse(Console.ReadLine()),
                          int.Parse(Console.ReadLine()),
                          int.Parse(Console.ReadLine()));
FillArray(number1);
Console.WriteLine(OddNumSum(number1));
