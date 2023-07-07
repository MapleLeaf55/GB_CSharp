/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int[,] CreateRandomArrayInt(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows,columns];
    for(int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue+1);
        }
        
    }
    return array;
}

double[,] CreateRandomArrayDouble(int rows, int columns)
{
    double[,] array = new double[rows,columns];

    for(int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = Math.Round(new Random().NextDouble(),2);
        }
    }
    return array;
}

void SumArray(int[,] arrayInt, double[,] arrayDouble)
{
    double[,] array = new double[arrayDouble.GetLength(0), arrayDouble.GetLength(1)];
    for(int i = 0; i < arrayInt.GetLength(0); i++){
        for (int j = 0; j < arrayInt.GetLength(1); j++)
        {
            array[i,j] = Math.Round(arrayInt[i,j] + arrayDouble[i,j],2);
            System.Console.Write(array[i,j]+ " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

Console.WriteLine("Введите размер cтроки");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер cтолбца");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный диапазон");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный диапазон");
int maxValue = Convert.ToInt32(Console.ReadLine());


SumArray(CreateRandomArrayInt(rows,columns,minValue,maxValue),CreateRandomArrayDouble(rows,columns));

/*Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента или же
 указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] CreateRandomArrayInt(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows,columns];
    for(int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue+1);
            System.Console.Write(array[i,j]+ " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
    return array;
}

void FindElement(int[,] array, int rowsPos, int columnsPos)
{
    if (rowsPos >= array.GetLength(0) || columnsPos >= array.GetLength(1)){
        Console.WriteLine("Такой позиции в массиве нет");
    }

    else {
        Console.WriteLine($"Элемент найден -> {array[rowsPos,columnsPos]}");
    }
}

Console.WriteLine("Введите размер cтроки");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер cтолбца");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный диапазон");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный диапазон");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите позицию cтроки");
int rowsPos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию cтолбца");
int columnsPos = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandomArrayInt(rows,columns,minValue,maxValue);
FindElement(array,rowsPos,columnsPos);


/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] CreateRandomArrayInt(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows,columns];
    for(int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue+1);
            System.Console.Write(array[i,j]+ " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
    return array;
}

double[] AvgColumns(int[,] array)
{
    double [] sum = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[j] = array[i,j] + sum[j]; 
        }
    }

    for (int i = 0; i < sum.Length; i++){
        sum[i] = Math.Round(sum[i]/array.GetLength(0),2);
    }
    return sum;
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

Console.WriteLine("Введите размер cтроки");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер cтолбца");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный диапазон");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный диапазон");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandomArrayInt(rows,columns,minValue,maxValue);
PrintArray(AvgColumns(array));
