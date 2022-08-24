/*
// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Input first numbers: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second numbers: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.Write("Первое число " + number1  + " больше чем второе " + number2);
}
else
{
    Console.Write("Второе число " + number2 + " больше чем первое " + number1);
}
*/
/*
// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите числа a, b, c :");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max)
{
    max = b;
}

if (c > max)
{
    max = c;
}

Console.WriteLine("Максимальное число -> " + max);
*/
/*
// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 1)
{
    Console.WriteLine("Число " + number + " является: Нечётным");
}
else
{
    Console.WriteLine("Число " + number + " является: Чётным");
}
*/
/*
// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

for (int current = 1; current <= number; current++)

if (current % 2 == 0)
{
    Console.WriteLine(current);
}
*/

// Задача 1. Напишите программу, которая на вход принимает число и выводит его квадрат.
/*
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

