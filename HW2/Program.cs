/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
 Console.WriteLine("Введите трехзначное число");
 int  num = Convert.ToInt32(Console.ReadLine());

 int SecondNum(int num)
 {
     num = (num/10)%10;
     return num;
 }

// Console.WriteLine(SecondNum(num));
/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
 Console.WriteLine("Введите число");
 int  num = Convert.ToInt32(Console.ReadLine());

 void ThirdNum(int num)
 {  
    if(num < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else{
        while(num > 999)
        {
            num = num/10;
        }
        num = num%10;
        Console.WriteLine(num);
    }
 }

ThirdNum(num);

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите число");
 int  num = Convert.ToInt32(Console.ReadLine());

 void WeekDay(int num)
 {  
    if(num < 1 || num > 7)
    {
        Console.WriteLine("Не день недели");
    } 
    else if(num == 6 || num == 7){
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

WeekDay(num);