﻿/*
// Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("вторая цифра этого числа ->" + stringNumber [1]);
*/
/*
// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)
{
    Console.WriteLine("третья цифра - >" + anyNumberText [2]);
}
else
{
    Console.WriteLine("- > третьей цифры нет");
}
*/

// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
void DayWeek(int dayNumber)
{ if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("(день выходной) - > да");
}
else if (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine("не день недели");
}
else Console.WriteLine("(день выходной) - > нет");
}
DayWeek(dayNumber);
