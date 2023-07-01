/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
 void Palindrome(int num)
 { 
    int num1, num2, num3,num4;

    num1 = num/10000;
    num2 = num%10;
    num3 = (num/1000)%10;
    num4 = (num/10)%10;
    if (num1 == num2 && num3 == num4)
    {
        Console.WriteLine($"Число {num} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {num} не является палиндромом");
    }
}
Palindrome(num);

/* Второй вариант решения со стрингом для склейки
void Palindrome(int num)
{
    int num1 = num;
    string s = "";
    int count = 1;

    while(count < 5){
        s = s + Convert.ToString(num1 % 10);
        num1 = num1 / 10;
        count++;
    } 
    s = s + Convert.ToString(num1);

    if (num == Convert.ToInt32(s))
    {
        Console.WriteLine($"Число {num} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {num} не является палиндромом");
    }
}

Palindrome(num);*/

/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/*
double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2)+ Math.Pow(y2 - y1, 2)+Math.Pow(z2 - z1, 2)),2); 
} 

Console.WriteLine("Введите координаты x точки А: ");
double  x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты y точки А: ");
double  y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты z точки А: ");
double  z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты x точки B: ");
double  x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты y точки B: ");
double  y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты z точки B: ");
double  z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Расстояние между точками равно: {FindDistance(x1, y1, z1, x2, y2, z2)}");
*/
/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

/*Console.WriteLine("Введите число");
int  num = Convert.ToInt32(Console.ReadLine());

void Cube(int num)
{
    int count = 1;

    while(count <= num){
        System.Console.Write(Math.Pow(count,3) + " ");
        count++;
    }
}
Cube(num);
*/