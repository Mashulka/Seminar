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
/*
// Задача 1. Напишите программу, которая принимает на вход некоторое число и возвращает сумму всех чисел от 1 до этого числа.

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
*/
/*
// Задача 2. Напишите программу, клторая на вход принимает число и выдает количество цифр в числе.

int FindDigits(int number)
{
    int current = 0;
    while (number > 0) 
    {
        number = number / 10;
        current++;
    }
    return current;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine ());

Console.WriteLine($"Количество цифр в числе {a} = {FindDigits (a)}");
*/
/*
// Задача 3. Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.

int FindFactorial(int number)
{
    int factorial = 1;
    for(int current = 1; current <= number; current++)
    {
        factorial = current * factorial;
    }
    return factorial;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {a} = {FindFactorial (a)}");
*/
/*
// Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;    
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "");

    Console.WriteLine();        
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value fo element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value fo element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
*/
/*
// Урок 5. 
// Задача 1. Задать массив из 12 элементов и заполнить случайными числами от -9 до 9. Найти сумму положительных и отрицательных элементов.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;    
}

void ShowArray(int[] array)

{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();        
}

void FindMinMaxSum(int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
           sumPositive += array[i];
        else
           sumNegative += array[i];   
    }

    Console.WriteLine("sum of negative elements is " + sumNegative);
    Console.WriteLine("sum of positive elements is " + sumPositive);
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value fo element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value fo element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
FindMinMaxSum(myArray);
*/
/*
// Задача 2. Напишите программу замены элементов массива положительные на отрицательные и наоборот.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;    
}

void ShowArray(int[] array)

{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();        
}

int[] ChangeElement(int[] array)
{

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);  
    }
    return array;
}     

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value fo element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value fo element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
ShowArray(ChangeElement(myArray));
*/
/*
// Задача 3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int[] CreateArray(int size)
{
    int [] newArray = new int[size];
    for (int i = 0; i < size; i++)
        {
        Console.Write($"input [i] element of the array: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
        }
    return newArray;   
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
       Console.Write(array[i] + " ");

    Console.WriteLine();    
}

bool CheckNumber(int[] array, int n)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == n) return true; 
    }
    return false;   
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray (a);
ShowArray(myArray);
bool check = CheckNumber(myArray, number);
if (check == true) Console.WriteLine($"число {a} найдено в массиве");
else Console.WriteLine($"число {number} не найдено в массиве");
*/
/*
// Задача 4. Найдите одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10, 99].

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;    
}

void ShowArray(int[] array)

{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();        
}

int CountElements(int[] array, int min, int max)
{
    int count = 0;
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= min && array[i] <= max) count ++;
    }
    return count;
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int max1 = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
int result = CountElements(myArray, min1, max1);

Console.WriteLine($"Количество элементов массива, находящихся в заданном отрезке равно {result}");
*/