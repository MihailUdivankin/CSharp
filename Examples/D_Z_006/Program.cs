// 4. Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число больше или равно 2: ");
string s_n = Console.ReadLine();
int n = int.Parse(s_n);
int a = 2;
while (a < n + 1)
{
    Console.Write($"{a} ");
    a = a + 2;
}