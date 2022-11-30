// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Write a number: ");
void NumberA(int num)
{
    Console.WriteLine($"{num}");
    if (num < 100)
    {
        Console.WriteLine("num");
        return;
    }

    while (num > 999) num /= 10;
    Console.WriteLine(num % 10);
}
NumberA(int.Parse(Console.ReadLine()));