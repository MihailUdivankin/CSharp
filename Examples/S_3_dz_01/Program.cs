//  Задача 1: Напишите программу, которая принимает на вход пятизначное число 
//  и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
bool IsPalindrome(string s)   // программа проверяет является ли число или текст палиндромом
{
    for (int i = 0; i < s.Length / 2; ++i)
    {
        if (s[i] != s[s.Length - 1 - i]) // !=  это знак неравенства
        return false;
    }
    return true;
}
Console.WriteLine("Введите пятизначное число");
string palin=Console.ReadLine();
string s = palin;

if((IsPalindrome(s) == true))
{
    Console.Write("Введенное число ");
    Console.ForegroundColor = ConsoleColor.DarkGreen; // устанавливаем цвет
    Console.Write(s);
    Console.ResetColor(); // сбрасываем в стандартный
    Console.Write(" является палиндромом");
}
else if((IsPalindrome(s) == false))
{
    Console.Write("Введенное число ");
    Console.ForegroundColor = ConsoleColor.DarkGreen; // устанавливаем цвет
    Console.Write(s);
    Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
    Console.Write(" НЕ является палиндромом");
    Console.ResetColor(); // сбрасываем в стандартный
}
//******
// {
//     Console.WriteLine($"ВВеденное число {s} является палиндромом");
// }
// else if((IsPalindrome(s) == false))
// {
//     Console.WriteLine($"ВВеденное число {s} НЕ является палиндромом");
// }
//*****
//арозаупаланалапуазора     4564567654654