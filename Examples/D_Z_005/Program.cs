// 3. Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);

if (a % 2 == 0)
{
    Console.WriteLine("Введенное число " + a + " четное");
}
else
{
    Console.WriteLine("Введенное число " + a + " НЕ четное");
}