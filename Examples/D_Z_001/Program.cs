//Напишите программу вычисления модуля числа.
//2 -> 2  ; -3 -> 3  ; -7 -> 7
Console.WriteLine("Введите число: ");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);

if(a >= 0)
{
   Console.WriteLine(a);
}
else
{
    Console.WriteLine(a * (-1));
}