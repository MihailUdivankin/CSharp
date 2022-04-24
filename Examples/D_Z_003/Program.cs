// 1. Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
string s_a = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string s_b = Console.ReadLine();

int a = int.Parse(s_a);
int b = int.Parse(s_b);

if (a > b)
{
    Console.Write("Число " + a + " больше числа " + b);
}
else
{
    Console.Write("Число " + b + " больше числа " + a);
}