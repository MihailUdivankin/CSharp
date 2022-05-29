//  Задача 1: Пользователь вводит с клавиатуры M чисел. 
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void HowManyPositive(int num)
{
    int count = 0;
    for(int i=0;i<num;i++)
    {
        Console.Write($"введите {i+1} из {num} чисел  ");
        int x = int.Parse(Console.ReadLine());
        if (x>0) count++;
    }
    Console.WriteLine($"Введено {count} положительных чисел");
}
Console.WriteLine("Сколько чисел будем проверять?");
int num = int.Parse(Console.ReadLine());
HowManyPositive(num);