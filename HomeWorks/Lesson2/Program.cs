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
/*
// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Input size for array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
int count = 0;
FillArrayRandomNumbers(numbers);
WriteArray(numbers);

{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0) count++;
    }
}

Console.WriteLine($"The number of even numbers in the array -> {count} ");

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void WriteArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
*/
/*
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write($"Input the number of array elements: ");
int numberElements = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int numberElements, int min, int max)
{
  int[] randomNumbers = new int[numberElements];
  int sumElements = 0;
  Console.Write("array: ");

    for (int i = 0; i < randomNumbers.Length; i++)
    {
      randomNumbers[i] = new Random().Next(min, max);
      Console.Write(randomNumbers[i] + " ");

      if (i % 2 ! = 1)
      {
        sumElements = sumElements + randomNumbers[i];
      }
    }
  return sumElements;
}

int randomNumbers =  RandomNumbers(numberElements, 1, 10);

Console.WriteLine($"Sum elements: {randomNumbers}");
*/
/*
// Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

int size = 10;
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
WriteArray(numbers);

int max = numbers[0];
int min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    else if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

Console.WriteLine($"Min number: {min}");
Console.WriteLine($"Max number: {max}");
Console.WriteLine($"The difference between the max and min: {max-min}");

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 555);
    }
}


void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
*/
/*
// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Input numbers: ");
int[] numbers = StringToNumber(Console.ReadLine());

int sum = 0;
for (int i = 0; i < numbers.Length; i++)
    {
    if (numbers[i] > 0) sum++;
    }

Console.WriteLine();
Console.WriteLine($"the number of numbers greater 0 = {sum}");

int[] StringToNumber(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',') count++;
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = " ";
        while (input [i] != ',')
        {
        if(i != input.Length - 1)
          {
            temp += input [i].ToString();
            i++;
          }
        else
          {
            temp += input [i].ToString();
          }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}
*/
/*
// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("input meaning b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input meaning k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input meaning b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input meaning k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"coordinates of the intersection point: {x}, {y}");
*/