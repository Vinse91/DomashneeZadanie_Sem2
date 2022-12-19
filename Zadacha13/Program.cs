// Задача 13: Напишите программу, которая выводит третью цыфру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 ->6



Console.Write("ВВедите число  = "); 
int a = Math.Abs(int.Parse(Console.ReadLine()!));
int a1 = a;
int count = 0;

while (a1 > 0)
{
    a1 /= 10;
    count++;
}

if (count - 3 >= 0)
{
    while (count -3 >0)
    {
        a = a/10;
        count--;

    }
    Console.WriteLine($"Третья цыфра {a%10}");
}
else
{
    Console.WriteLine("Третьей цифры нет");

}