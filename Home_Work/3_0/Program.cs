// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

Console.WriteLine("Write a number: ");
string number(int n)
{
    int num = 10000;
    if (n > 100000 || n < 10000)
        return "Error";
    else
        while (num > 1)
        {
            if (n / num % 10 != n % 10)
                return "no";
            n /= 10;
            num /= 100;


        }
        return "yes";
}
Console.WriteLine(number(int.Parse(Console.ReadLine())));



