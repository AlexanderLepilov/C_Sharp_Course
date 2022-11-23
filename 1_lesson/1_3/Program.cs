// 3. Напишите программу, которая на вход принимает одно число
// (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Write a nuber: ");
string a = Console.ReadLine();
int N = int.Parse(a);
int NegN = -N;

while (NegN <= N)
{
    Console.Write($"{NegN}, ");
    NegN +=1;
}





