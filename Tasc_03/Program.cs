// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
using static System.Console;
WriteLine("Введите число от 1 до 7: ");
int day_number = Convert.ToInt32(ReadLine());
if (day_number < 1 ^ day_number > 7)
{
    WriteLine("Недопустимое число");
}
else
{
    if (day_number == 1)
    {
        WriteLine("Понедельник");
    }
    if (day_number == 2)
    {
        WriteLine("Вторник");
    }
    if (day_number == 3)
    {
        WriteLine("Среда");
    }
    if (day_number == 4)
    {
        WriteLine("Четверг");
    }
    if (day_number == 5)
    {
        WriteLine("Пятница");
    }
    if (day_number == 6)
    {
        WriteLine("Суббота");
    }
    if (day_number == 7)
    {
        WriteLine("Воскресенье");
    }
}