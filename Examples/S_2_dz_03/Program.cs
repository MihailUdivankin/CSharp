// Задача 3: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры 
// нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int TakeNum(int num)
{
    int sec = 0;
    sec = num % 10;
    return sec;
}
Console.WriteLine("Введите число");
string isis=Console.ReadLine();
int iss = int.Parse(isis);
if(iss<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(TakeNum(iss));  
}
