/*
// Задача 1. Напишите программу, которая на вход принимает число и выводит его квадрат.

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int quad = num * num;

Console.Write($"The square of {num} is {quad}");
*/
/*
// Задача 2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int quad2 = n2 * n2;

if(n1 == quad2)
    Console.WriteLine($"{n1} is quad of {n2}");
else
    Console.WriteLine($"{n1} is not quad of {n2}");
*/
/* 
// Задача 3. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа от -N до N.

Console.Write("Input integer positive number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = number * (-1);

while(current <= number)
{
    Console.Write(current + " ");
    current++;
}
*/
/*
// Задача 4. Напишите программу, которая на вход принимает трехзначное число и на выходе показывает последнюю цифру.

Console.Write("Input integer tree-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int ed = number % 10;

Console.Write($"Last diget of {number} is {ed}");
*/