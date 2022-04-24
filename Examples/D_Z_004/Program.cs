// 2. Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
string s_a = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string s_b = Console.ReadLine();
Console.WriteLine("Введите третье число: ");
string s_с = Console.ReadLine();

int a = int.Parse(s_a);
int b = int.Parse(s_b);
int c = int.Parse(s_с);

if (b > a)
{
    a = b;
    if (c > a)
    {
        a = c;
    }
}
else
{
    if (c > a)
    {
        a = c;
    }
}
Console.Write("Число " + a + " максимальное");