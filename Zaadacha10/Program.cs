// Задача 10: Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цыфру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("ВВедите число N = "); 
int N = int.Parse(Console.ReadLine()); 

int a = N/10;
int b = N%10;
int a1 = a%10;

Console.WriteLine("Вторая цифра = " + a1);

