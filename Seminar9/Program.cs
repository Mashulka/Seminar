/*
// Задача 1. Задать значение n и написать программу, которая выведет все натуральные числа в промежутке от 1 до n.

void ShowNumbers(int n)
{
    if(n > 1) ShowNumbers(n - 1);
    
    Console.Write(n + " "); 
       
           
    // if(n >= 1) 
    // {
    //    Console.Write(n + " ");   метод вывода в обратном порядке
    //    ShowNumbers(n - 1);         
    // }
  
}

ShowNumbers(10);
*/
/*
// Задача 2. Необходимо написать программу, которая будет принимать на вход число и возвращать сумму его цифр.

void ShowNumbers(int n)
{
    if(n > 1) ShowNumbers(n - 1);
    
    Console.Write(n + " ");
}    

int FindSum(int n)
{
    if(n > 0)
        return FindSum(n / 10) + n % 10;
    else
        return n;    
}

ShowNumbers(10);
Console.WriteLine();
Console.WriteLine(FindSum(123));
*/
/*
// Задача 3. Необходимо задать значение m и n, и написать программу которая выведет все натуральные числа в промежутке от m до n.

void ShowNumbers(int n, int m)
{
    if(m != n)
    {
        if(n > m)
        {
            ShowNumbers(n - 1, m);
            Console.Write(n + " ");
        }
        else
        {
            ShowNumbers(m - 1, n);
            Console.Write(m + " ");
        }
    }
    else
        Console.Write(m + " ");
}    

ShowNumbers(5,10);
*/
/*
// Задача 4. Необходимо написать программу, которая число а возводит в целую степень b.

int NumberPower(int a, int b)
{
    if(b != 0)
    {
        return NumberPower(a, b - 1)*a;
    }
    else return 1;
}
Console.WriteLine(NumberPower(2,3));
*/