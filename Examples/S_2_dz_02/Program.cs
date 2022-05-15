// Задача 2: Напишите программу, которая выводит 
// случайное трёхзначное число и удаляет вторую цифру 
// этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num1 = 0; // программа выводит сразу пять трехзначных чисел для наглядности
int num2 = 0;
void BinarNumber(int num)
{
    num1 = num / 100;
    num2 = num % 10;
    Console.WriteLine($" ==> {num1}{num2}");
}
int index = 0;
while (index < 5)
{
    int number = new Random().Next(100, 1000);
    Console.Write(number);
    BinarNumber(number);
    index++;
}

// //Второй вариант программы
// int number = new Random().Next(100, 1000); //простой вариант решения.
// int num1 = 0;//Выводит одно трехзначное число   
// int num2 = 0;
// void BinarNumber(int num)
// {
//     num1 = num / 100;
//     num2 = num % 10;
//     Console.WriteLine($" ==> {num1}{num2}");
// }
// Console.Write(number);
// BinarNumber(number);
    