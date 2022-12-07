// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Write a number: ");
void chet(int N)
{
    int i = 0;
    double pere;
    while (i < N)
    {
        i++;
        pere = Math.Pow(i, 3);
        Console.Write($"{pere}, ");
    }
}
int chislo = int.Parse(Console.ReadLine());
chet(chislo);