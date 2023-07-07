/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

void OneMass(int[,] array)
{
    int[] array2 = new int[array.GetLength(1)];
    
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        int k = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array2[k] = array[i,j];
            k++;
        }

        for(int n = 0; n < array2.Length; n++){
            for(int j = 0; j < array2.Length; j++){
                if(array2[n] > array2[j])
                {
                    temp = array2[n];
                    array2[n] = array2[j];
                    array2[j] = temp;
                }
            }
        }
        k = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = array2[k];
            k++;
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

int[,] array = CreateRandomArrayInt(rows,columns,minValue,maxValue);
OneMass(array);


/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка
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

int[] SumRows(int[,] array)
{
    int [] sum = new int[array.GetLength(0)];
    int sumRow = 0;
    int pos = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum[j] = array[j,i] + sum[j]; 
        }
    }

    for(int i = 1; i < sum.Length;i++){
       
        sumRow = sum[0];
        if(sumRow > sum[i]){

            sumRow = sum[i];
            pos = i;
        }

    }

    Console.WriteLine($"Минимальная сумма в строке {pos+1}");
    return sum;
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
SumRows(array);

/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int[,] SumRows(int[,] arrayMatrix1, int[,] arrayMatrix2)
{
    int [,] matrixPr = new int[arrayMatrix1.GetLength(0), arrayMatrix2.GetLength(1)];
    for (int i = 0; i < matrixPr.GetLength(0); i++)
    {
        for (int j = 0; j < matrixPr.GetLength(1); j++)
        {
            for (int k = 0; k < arrayMatrix2.GetLength(0); k++){
                matrixPr[i,j] += arrayMatrix1[i,k]*arrayMatrix2[k,j];
            }
            System.Console.Write(matrixPr[i,j]+ " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
    return matrixPr;
}

Console.WriteLine("Введите размер cтроки матрицы 1");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер cтолбца матрицы 1");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный диапазон матрицы 1");
int minValue1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный диапазон матрицы 1");
int maxValue1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размер cтроки матрицы 2");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер cтолбца матрицы 2");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный диапазон матрицы 2");
int minValue2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный диапазон матрицы 2");
int maxValue2 = Convert.ToInt32(Console.ReadLine());

if (columns1 == rows2){
    int[,] arrayMatrix1 = CreateRandomArrayInt(rows1,columns1,minValue1,maxValue1);
    int[,] arrayMatrix2 = CreateRandomArrayInt(rows2,columns2,minValue2,maxValue2);

    SumRows(arrayMatrix1,arrayMatrix2);
}
else{
    Console.WriteLine("Нельзя перемножить матрицы, т.к. число столбцов первой матрицы не совпадает с количеством строк второй матрицы");
}


/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
//максимальный и минимальный диапазон не привязан к двузначным числам

int[,,] CreateRandomArrayInt(int rows, int columns, int height, int minValue, int maxValue)
{
    
    int[] mass = new int[rows*columns*height];
    int  number;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        mass[i] = new Random().Next(minValue,maxValue+1);
        number = mass[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (mass[i] == mass[j])
                {
                    mass[i] = new Random().Next(minValue,maxValue+1);
                    j = 0;
                    number = mass[i];
                }
                number = mass[i];
            }
        }
    }
    
    int c = 0;
    int[,,] array = new int[rows,columns,height];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = mass[c];
                c++;
                System.Console.Write(array[i, j, k]+$"({i},{j},{k}) ");
            }
             System.Console.WriteLine();
        }
       
    }
    System.Console.WriteLine();

    return array;
}

Console.WriteLine("Введите размер cтроки");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер cтолбца");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер высоты");
int height = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный диапазон");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный диапазон");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,,] array = CreateRandomArrayInt(rows,columns,height,minValue,maxValue);

/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
//код адаптирован только для матрицы 4 на 4. для другой размерности работать не будет

int[,] CreateRandomArrayInt(int rows, int columns)
{
    int[,] array = new int[rows,columns];
    int n = rows;
    for(int i = 0; i < rows; i++)
    {
        for(int j=0; j < columns; j++){
            array[i,j] = 0;
            //System.Console.Write(array[i,j]+ " ");
        }
        //System.Console.WriteLine();
    }
    for(int i = 0; i < rows; i++){

        array[0,i] = i+1;
    }
    for(int i = 1; i < rows; i++){

        array[i,rows-1] = n+1;
        n++;
    }
    for(int i = 1; i < rows; i++){

        array[rows-1,rows-i] = n;
        n++;
    }

    for(int i = 1; i < rows; i++){

        array[rows-i,0] = n;
        n++;
    }
    
    for (int i = 1; i < rows-1; i++){

        array[1,i] = n;
        n++;
    }

    for(int i = 1; i < rows-2; i++){

        array[i+1,rows-2] = n;
        n++;
    }

    for(int i = 1; i < rows-2; i++){
        array[rows-2,rows-3] = n;
        n++;
    }

    for(int i = 0; i < rows; i++)
    {
        for(int j=0; j < columns; j++){
            System.Console.Write(array[i,j]+ " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
    
    return array;
}


int rows = 4;
int columns = 4;

CreateRandomArrayInt(rows,columns);
