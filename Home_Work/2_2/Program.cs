// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Write a number: ");
int num = int.Parse(Console.ReadLine());
{
    if (num < 100)
    {
        Console.Write($"{num} -> Error");
        return;
    }

    while (num > 999) num /= 10;
    Console.WriteLine(num % 10);
}

