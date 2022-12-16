// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
using static System.Console;
WriteLine("Введите число N: ");
int N = Convert.ToInt32(ReadLine());
int b = N * -1;
while (b <= N)
{
    Write($"{b}, ");
    b = b + 1;
}


