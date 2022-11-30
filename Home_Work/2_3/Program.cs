// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Write a number: ");
void Weekend(int num)
{
    string text1 = "no";
    string text2 = "yes";

    if (num == 6 || num == 7)
        Console.WriteLine($"{num} -> {text2}");

    else
        Console.WriteLine($"{num} -> {text1}");

}
Weekend(int.Parse(Console.ReadLine()));