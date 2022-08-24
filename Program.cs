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

