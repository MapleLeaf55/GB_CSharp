/*Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void PrintNum(int n)
{
    if(n >= 1)
    {
        System.Console.Write(n + " ");
        PrintNum(n - 1);
    }
}
Console.WriteLine("Введите значение N");
int n = Convert.ToInt32(Console.ReadLine());

PrintNum(n);

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumNum(int m, int n)
{
    if(m < n)
    {
        return SumNum(m + 1, n) + m;
    }
    else if (m > n)
    {
        return SumNum(m - 1, n) + m;
    } 
    else return m;
}

Console.WriteLine("Введите значение M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(SumNum(m, n));

/*
Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int FuncAccerman(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return FuncAccerman(m - 1, 1);
    }
    else
    {
        return FuncAccerman(m - 1,FuncAccerman(m, n - 1));
    }
} 

Console.WriteLine("Введите значение M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(FuncAccerman(m, n));
