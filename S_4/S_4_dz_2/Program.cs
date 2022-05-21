//  Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int Sum(int num)    //Программа принимает ввод числа с консоли, преобразует его в строку,
{                   //вычисляет длину строки (используется в цикле for())
    int summ=0;
    string len = num.ToString();
    for(int j=0;j<len.Length;j++)
    {
        int num1 = num % 10;
        num = num / 10;
        summ= summ +num1;
    }
    return summ;
}
Console.WriteLine(Sum(452));
Console.WriteLine(Sum(82));
Console.WriteLine(Sum(9012));
// Далее ввод с консоли
Console.WriteLine("Введите число");
string isis=Console.ReadLine();
int iss = int.Parse(isis);
Console.WriteLine(Sum(iss));

