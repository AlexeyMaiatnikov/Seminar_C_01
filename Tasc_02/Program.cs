using static System.Console;
WriteLine("Введите число 1: ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите число 2: ");
int b = Convert.ToInt32(ReadLine());
if (a == b * b)
{
    WriteLine("Да");
}
else
{
    WriteLine("Нет");
}
