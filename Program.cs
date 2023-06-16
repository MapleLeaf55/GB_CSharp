/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

System.Console.WriteLine("Введите первое число");
int  num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    System.Console.WriteLine("Первое число больше -> " + num1);
}
else 
{
    System.Console.WriteLine("Второе число больше -> " + num2);
}


/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

System.Console.WriteLine("Введите первое число");
int  num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2 && num1 > num3)
{
    System.Console.WriteLine("Первое число больше -> " + num1);
}
else if (num2 > num1 && num2 > num3)
{
    System.Console.WriteLine("Второе число больше -> " + num2);
}
else 
{
    System.Console.WriteLine("Третье число больше -> " + num3);
}


/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

System.Console.WriteLine("Введите число");
int  num = Convert.ToInt32(Console.ReadLine());

if (num%2==0)
{
    System.Console.WriteLine("Число четное" );
}
else
{
    System.Console.WriteLine("Число нечетное" );
}

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
System.Console.WriteLine("Введите число");
int  num = Convert.ToInt32(Console.ReadLine());

int current = 2;

if (num == 0 || num == 1)
{
    System.Console.WriteLine("Четных чисел нет");
}
else
{
    while (current <= num)
    {
        if(current%2 == 0) {
            System.Console.Write(current + " ");
        }
        current ++;
    }
}