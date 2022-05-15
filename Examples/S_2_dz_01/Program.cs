// Задача 1: Напишите программу, которая принимает на 
// вход трёхзначное число и на выходе показывает вторую 
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int TakeNum(int num)
{
    int sec = 0;
    sec = (num % 100 - num % 10) / 10;
    return sec;
}
Console.WriteLine("Введите трехзначное число");
string isis=Console.ReadLine();
int iss = int.Parse(isis);
Console.WriteLine($"Вторая цифра этого числа {TakeNum(iss)}");

