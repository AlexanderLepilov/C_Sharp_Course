// Напишите программу, которая на вход принимает число и выдаёт,
//  является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Write a number");
int A = int.Parse(Console.ReadLine());

int B = A % 2;

if (B == 0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}

