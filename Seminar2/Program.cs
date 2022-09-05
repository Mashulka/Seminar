// Задача. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

/*
int FindBiggestDigit(int number)
{
    int ed = number % 10;
    int dec = number / 10;
    int max;

    if (ed > dec)
    max = ed;

    else
    max = dec;
    
    return max;
}

Console.Write("Random two-digit number is ");
int randomNumber = new Random().Next(10,100);

int biggestDigit = FindBiggestDigit(randomNumber);
Console.WriteLine($"Biggest digit of {randomNumber} is {biggestDigit}");
*/
/*
// Задача 2. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

int CutNumber(int number)

{
    int ed = number % 10;
    int sot = number / 100;

    return sot * 10 + ed;
   
}

int randomNumber = new Random().Next(100,1000);

int newNumber = CutNumber(randomNumber);
Console.WriteLine($"New version of {randomNumber} is {newNumber}");
*/
/*
// Задача 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если не кратно, то выводить остаток от деления.

void IsDivisionable(int num1, int num2)
{
    int reminder = num2 % num1;
    
    if(reminder == 0)
        Console.WriteLine($"{num2} is divisionable of {num1}");
    else
        Console.WriteLine($"{num2} is divisionable of {num1}. Reminder is {reminder}");
}       

Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

IsDivisionable(n1, n2);
*/
/*
// Задача 4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

bool IsDivis(int number)
{
    return number % 7 == 0 && number % 23 == 0;    
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

bool isDivison = IsDivis(n);
Console.WriteLine(isDivison);
*/
/*
// Задача 5. Напишите программу, которая принимает на вход координаты точки (x, y величину), причем x, y нулевые и выдает номер четверти в которой находится эта точка.

int FindQuart(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;

    return 0;
}

Console.Write("Input first number: ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
double yA = Convert.ToInt32(Console.ReadLine());

int quartNum = FindQuart(xA, yA);

if(quartNum == 0)
    Console.WriteLine("Point on the axes!");
else
    Console.WriteLine($"Point is located on {quartNum} quart");
*/
/*
// Задача. Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x и y).

using System;

void FindCoordinats (int quart)
{
    if (quart == 1)
    Console.WriteLine("Диапазон (x+, y+)");
    if (quart == 2)
    Console.WriteLine($"Диапазон (x-, y+)");
    if (quart == 3)
    Console.WriteLine($"Диапазон (x-, y-)");
    if (quart == 4)
    Console.WriteLine($"Диапазон (x+, y-)");
}
Console.Write("Input number of quart: ");
int quart = Convert.ToInt32(Console.ReadLine());
FindCoordinats(quart);
*/
/*
// Задача. Напишите программу, которая принимает на вход координаты 2-х точек и находит расстояние между ними в 2D пространстве.

double FindDistanсe(double x1, double y1, double x2, double y2)
{
   return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}
Console.Write("Input x1: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double yb = Convert.ToDouble(Console.ReadLine());
double coordinate = FindDistanсe(xa, xb,ya, yb);
Console.WriteLine($"Distance is {coordinate}");
*/
/*
// Задача. Напишите программу, которая принимает на вход число N и выдает на консоль квадраты чисел от 1 до N.

void ShowSquare(int n)
{
    int current = 1;
    while(current <= n)
    {
        Console.WriteLine($"Квадрат числа {current} = {current * current}");
        current++;
    }
}
Console.Write("Введите любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowSquare(number);
*/

// Задача. Напишите программу, которая принимает на вход некоторое число и возвращает сумму всех чисел от 1 до этого числа.

int FindSum(int number)
{
    int sum = 0;
    for (int current = 1; current <= number; current++) ;
    sum = sum + current;
    return sum;
}
Console.Write("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = FindSum(a);
Console.WriteLine($"Sum of numbers from 1 to {a} is {result}");
