/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());
double Degree(int a, int b)
{  
    double c = a;
    if (b == 0){
        c = 1;
    }
    else if (b < 0)
    {
        b = Math.Abs(b);
        for (int i = 1; i < b; i++)
        {
            c *=a;
        }
        c = 1/c;
    }
    else
    {
        for (int i = 1; i < b; i++)
        {
            c *=a;
        }
    }
    return c;
}
System.Console.WriteLine($"Число {a} в степени {b} равно {Degree(a, b)}");

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int SummNumber(int num)
{
    int num1 = 0;

    while (num != 0)
    {
        num1 = num1 + num%10;
        num = num/10;
    }
    return num1;
}
System.Console.WriteLine($"Сумма числа {num} равна {SummNumber(num)}");


/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] CreateRandomArray(int size,int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(minValue, maxValue+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
        System.Console.Write(array[i]+" ");
    }
    System.Console.WriteLine();
}

Console.WriteLine("Введите размер");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный диапазон");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный диапазон");
int maxValue = Convert.ToInt32(Console.ReadLine());

PrintArray(CreateRandomArray(size,minValue,maxValue));