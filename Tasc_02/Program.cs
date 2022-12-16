// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
using static System.Console;
WriteLine("Введите число 1: ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите число 2: ");
int b = Convert.ToInt32(ReadLine());
if (a == b * b)
{
    WriteLine($"Число {a} является квадратом числа {b}");
}
else
{
    WriteLine($"Число {a} не является квадратом числа {b}");
}
