/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int[] CreateRandomArray(int size,int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(minValue, maxValue+1);
    }
    return array;
}

int[] PrintArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
        System.Console.Write(array[i]+" ");
    }
    System.Console.WriteLine();
    return array;
}

int EvenNumb(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0) count ++;
    }
    return count;
}
Console.WriteLine("Введите размер");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный диапазон");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный диапазон");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array = PrintArray(CreateRandomArray(size,minValue,maxValue));
System.Console.WriteLine($"Количество четных чисел -> {EvenNumb(array)}");

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] CreateRandomArray(int size,int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(minValue, maxValue+1);
    }
    return array;
}

int[] PrintArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
        System.Console.Write(array[i]+" ");
    }
    System.Console.WriteLine();
    return array;
}

int SumNumb(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i%2 != 0) 
        count += array[i];
    }
    return count;
}
Console.WriteLine("Введите размер");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный диапазон");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный диапазон");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array = PrintArray(CreateRandomArray(size,minValue,maxValue));
System.Console.WriteLine($"Сумма элементов, стоящие на нечетных позициях-> {SumNumb(array)}");

/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
int[] CreateRandomArrayInt(int size,int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(minValue, maxValue+1);
    }
    return array;
}

double[] CreateRandomArrayDouble(int size)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++){
        array[i] = Math.Round(new Random().NextDouble(),2);
    }
    return array;
}

double[] SumArray(int[] arrayInt, double[] arrayDouble)
{
    double[] array = new double[arrayDouble.Length];
    for(int i = 0; i < arrayInt.Length; i++){
        array[i] = arrayInt[i] + arrayDouble[i];
    }
    return array;
}

double[] PrintArray(double[] array)
{
    for(int i=0;i<array.Length;i++)
    {
        System.Console.Write(array[i]+" ");
    }
    System.Console.WriteLine();
    return array;
}

double DiffMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        } 
        else if(array[i] > max)
        {
            max = array[i];
        }
    }
    return Math.Round((max - min),2);
}
Console.WriteLine("Введите размер");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный диапазон");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный диапазон");
int maxValue = Convert.ToInt32(Console.ReadLine());


double[] array = PrintArray(SumArray(CreateRandomArrayInt(size,minValue,maxValue),CreateRandomArrayDouble(size)));

System.Console.WriteLine($"Разница между максимальным и минимальным элементами -> {DiffMaxMin(array)}");