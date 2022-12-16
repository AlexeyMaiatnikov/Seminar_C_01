// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа.
using static System.Console;
WriteLine("Введите число трехзначное число: ");
int number = Convert.ToInt32(ReadLine());
int remainder = number % 10;
Write($"{remainder}");