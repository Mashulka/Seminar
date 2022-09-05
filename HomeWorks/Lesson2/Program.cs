/*
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
/*
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
*/
/*
// Задача 19. Напишите программу, которая принимает на  вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("Задача 19");
Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
    if (number [0] == number [4] || number [1] == number [3])
    {
        Console.WriteLine($"Введенное пятизначное число: {number} - да");  
    }
    else Console.WriteLine ($"Введенное пятизначное число {number} - нет");   
}

if (number!.Length == 5)
{
    CheckingNumber(number);
}
else Console.WriteLine($"Введите пятизначное число");
*/
/*
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
     Console.Write($"Введите координату {coorName} точки {pointName}: ");
     return Convert.ToInt32(Console.ReadLine());
}

double Coordinats(double x1, double x2, double y1, double y2, double z1, double z2)
{
     return Math.Sqrt(Math.Pow((x2-x1), 2) +  Math.Pow((y2-y1), 2) +  Math.Pow((z2-z1), 2));
}

double segmentLength = Math.Round (Coordinats(x1, x2, y1, y2, z1, z2), 2 );
Console.WriteLine($"Длина отрезка {segmentLength}");
*/
/*
// Задача 23. Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N

void cube(int n)
{
    int current = 1;
    while(current <= n)
    {
        Console.WriteLine($"Куб числа {current} = {current * current * current}");
        current++;
    }
}
Console.Write("Введите любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
cube(number);
*/
/*
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;

for (int i = 1; i < b; i++)
{
    step = step * a;
}

Console.WriteLine("A в степени B равно: " + step);
*/
/*
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
    int num = i % 10;
    i = i / 10;
    sum = sum + num;
}

Console.WriteLine("Сумма цифр в числе равна: " + sum);
*/
/*
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

    
Console.Write("Введите массив: ");
string? seriesOfNumbers = Console.ReadLine();

int [] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
{
    numbers [i] = new Random().Next(0, 35);
    Console.Write(" " + Method (i) + " ");
}
Console.Write("]");

int Method (int a)
{
    return numbers[a];
}
*/