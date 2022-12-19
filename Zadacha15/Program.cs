// Задача 15: Напишите рпограмму, которая принимает на вход цыфру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите число: ");
int a = Math.Abs(int.Parse(Console.ReadLine()));
int a1 = a;
int count = 0;

while (a1 > 0)
{
    a1 /= 10;
    count++;
}

if (count - 3 >= 0)
{
    while (count - 3 > 0)
    {
        a = a / 10;
        count--;

    }
    Console.WriteLine($"Третья цифра {a%10}");

}
else
{
    Console.WriteLine("Третьей цифры нет");
}