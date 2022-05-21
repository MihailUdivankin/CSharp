
// int SumNum(int num) //сумма чисел от 1 до n
// {
//     int all_sum =0;
//     for(int i=1; i<=num; i++)
//     {
//         all_sum += i;
//         //all_sum =all_sum+ i;
//     }
//     return all_sum;
// }
// Console.WriteLine(SumNum(7));
// Console.WriteLine(SumNum(3));
// Console.WriteLine(SumNum(4));
//*****************************************
// void Sum(int num)// Вычисляет количество цифр введенного числа
// {
//     int i = 0;
//     while(num > 0)
//     {
//         num = num / 10;
//         i = i + 1;
//     }
//     Console.WriteLine(i);
// }
// Sum(1235675);
//********************** 
// int NumCount(int num) // Вариант 2. Вычисляет количество цифр введенного числа
// {
//     string result = num.ToString();
//     return result.Length;
// }
// Console.WriteLine(NumCount(456));
// Console.WriteLine(NumCount(78));
// Console.WriteLine(NumCount(89126));
//***********************************
// int PowNum(int num)  //произведение чисел от 1 до n
// {
//     int all_sum =1;
//     for(int i=1; i<=num; i++)
//     {
//         all_sum *= i;
//         //all_sum =all_sum * i;
//     }
//     return all_sum;
// }
// Console.WriteLine(PowNum(7));
// Console.WriteLine(PowNum(2));
// Console.WriteLine(PowNum(3));
//**************************************
// 3. Напишите программу, которая выводит массив из 8 элементов,
//    заполненный нулями и единицами в случайном порядке.
// int [] array= new int[8];
// for (int i = 0; i < 8; i++)
// {
//     array[i] = new Random().Next(2);
//     Console.Write(array[i]);
// }
//*********************************

//дз дз дз дз дз дз дз дз дз дз
//  Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int PowNum(int a, int b)  // ++++
// {
//     int all =a;
//     for(int i=1; i<b; i++)
//     {
//         all *= a;
//         //all_sum =all_sum+ i;
//     }
//     return all;
// }

// Console.WriteLine(PowNum(3,5));
// Console.WriteLine(PowNum(2,4));



//  Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// int Sum(int num)    //Программа принимает ввод числа с консоли, преобразует его в строку,
// {                   //вычисляет длину строки (используется в цикле for())
//     int summ=0;
//     string len = num.ToString(); //***
//                                         // Console.WriteLine($"{len}");
//                                         // Console.WriteLine($"{len[1]}{len[0]}{len[0]}");
//     for(int j=0;j<len.Length;j++)
//     {
//         int num1 = num % 10;
//         num = num / 10;
//         summ= summ +num1;
//         Console.Write($"j= {j}, num1= {num1}, num= {num}, summ= {summ}");
//         Console.WriteLine(" ");
//     }
//     return summ;
// }
// Console.WriteLine(Sum(452));
// Console.WriteLine(Sum(82));
// Console.WriteLine(Sum(9012));
// // Далее ввод с консоли
// Console.WriteLine("Введите число");
// string isis=Console.ReadLine();
// int iss = int.Parse(isis);
// Console.WriteLine(Sum(iss));
//*****************


// Задача 3: Напишите программу, которая задаёт массив из 8 элементов 
// случайными числами и выводит их на экран. 
// Оформите заполнение массива и вывод в виде функции 
// (пригодится в следующих задачах)

// void MassEight(int[] len)
// {   
//     for (int i = 0; i < len.Length; i++)
//     {
//         len[i] = new Random().Next(100); 
//     }       
// }
// void PrintMassiv(int[] massiv)
// {
//     for(int j = 0; j < massiv.Length; j++)
//     {
//         Console.Write(massiv[j].ToString() + " ");
//     } 
// }
// Console.WriteLine("Введите числовое значение длинны массива");
// string isis=Console.ReadLine();
// int iss = int.Parse(isis);
// int[] arr = new int[iss];
// MassEight(arr);
// PrintMassiv(arr);

//**** Задание и печать массива без методов ***
// Console.WriteLine("Введите числовое значение длинны массива");
// string isis=Console.ReadLine();
// int iss = int.Parse(isis);
// int[] arr = new int[iss];
// for (int i = 0; i < iss; i++)
// {
//     arr[i] = new Random().Next(100);        
// } 
// for(int j = 0; j < arr.Length; j++)
// {
//     Console.Write(arr[j].ToString() + " ");
// } 
