// Демонстрация решения
// Задача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

// void MassEight(int[] len)
// {   
//     for (int i = 0; i < len.Length; i++)
//     {
//         len[i] = new Random().Next(-9,9); 
//     }       
// }
// void PrintMassiv(int[] massiv)
// {
//     for(int j = 0; j < massiv.Length; j++)
//     {
//         Console.Write(massiv[j].ToString() + " ");
//     } 
// }
// void PrintSort(int[] msort)
// {
//     int PositivSum = 0;
//     int NegativSum = 0;
//     for(int k = 0; k < msort.Length; k++)
//     {
//         if(msort[k] > 0)
//         {
//             PositivSum = PositivSum + msort[k];
//         }
//         else if (msort[k] < 0)
//         {
//             NegativSum = NegativSum + msort[k];
//         }        
//     } 
//     Console.WriteLine($"Сумма положительных элементов = {PositivSum}");
//     Console.WriteLine($"Сумма отрицательных элементов = {NegativSum}");
// }
// Console.WriteLine("Введите числовое значение длинны массива");
// string isis=Console.ReadLine();
// int iss = int.Parse(isis);
// int[] arr = new int[iss];
// MassEight(arr);
// PrintMassiv(arr);
// Console.WriteLine();
// PrintSort(arr);
//********************************
// Задача 1: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
// void MassEight(int[] len)
// {   
//     for (int i = 0; i < len.Length; i++)
//     {
//         len[i] = new Random().Next(-9,9); 
//     }       
// }
// void PrintMassiv(int[] massiv)
// {
//     for(int j = 0; j < massiv.Length; j++)
//     {
//         Console.Write(massiv[j].ToString() + " ");
//     } 
// }
// void Invert(int[] massiv)
// {
//     for(int j = 0; j < massiv.Length; j++)
//     {
//         massiv[j] = -1 * massiv[j];//         
//     } 
// }
// Console.WriteLine("Введите числовое значение длинны массива");
// string isis=Console.ReadLine();
// int iss = int.Parse(isis);
// int[] arr = new int[iss];
// MassEight(arr);
// PrintMassiv(arr);
// Console.WriteLine();
// Invert(arr);
// PrintMassiv(arr);

// Задача 2: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
// bool Find(int[] array, int find)
// {
//     bool flag = false;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] == find) 
//         {
//             flag=true;
//         }
//     }

//     if (flag=false) 
//     {
//         Console.WriteLine($"Числа {find} нет в массиве");
//     }
//     else if(flag=true) 
//     {
//         Console.WriteLine($"Число {find} есть в массиве");
//     }
// }
// int[] da1 = new int[5] {6, 7, 19, 345, 3};
// int[] da2 = new int[5] {6, 7, 19, 345, 3};
// int find1 = 8;
// int find2 = 3;
// Find(da1, find1);
// Find(da2, find2);
//********************************************
//********************************************
//********************************************
// void Print(int[] arr)   //от Марии
// {
//     int size = arr.Length;

//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }

// int[] MassNums(int size)
// {   
//     int[] arr = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(-9, 10);        
//     }    
//     return arr;
// }
// void SumMaxMin(int[] arr)
// {
//     int s_min, s_max;
//     s_min = s_max = 0;

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] >= 0)
//         {
//             s_max += arr[i];
//         }
//         else
//         {
//             s_min += arr[i];
//         }
//     }
//     Console.WriteLine($"sum posit {s_max}, sum neg {s_min}");
// }

// int[] arr_1 = MassNums(12);
// Print(arr_1);
// SumMaxMin(arr_1);
// int[] arr_2 = MassNums(12);
// Print(arr_2);
// SumMaxMin(arr_2);
//********************************************
//********************************************
// void Print(int[] arr)   //от Марии
// {
//     int size = arr.Length;

//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }

// int[] MassNums(int size)
// {   
//     int[] arr = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(-9, 10);        
//     }    
//     return arr;
// }


// int[] arr_1 = MassNums(12);
// Print(arr_1);
// SumMaxMin(arr_1);
// int[] arr_2 = MassNums(12);
// Print(arr_2);
// SumMaxMin(arr_2);
//************************
// void Find(int[] array, int find)
// {
//     string flag = "false";
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] == find) 
//         {
//             flag="true";            
//         }
//     }
//     Console.WriteLine(flag);

    
// }
// int[] da1 = new int[5] {6, 7, 19, 345, 3};
// int[] da2 = new int[5] {6, 7, 19, 345, 3};
// int find1 = 8;
// int find2 = 3;
// Console.WriteLine($"{Find(da1, find1)}");
// Console.WriteLine($"{Find(da2, find2)}");
///////*********************

// void CheckArray(int num, int[] arr){
//     string flag = "No";
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(num == arr[i]){
//             flag = "Yes";
//             break;
//         }
//     }
//     Console.WriteLine(flag);
// }

//*******************
// 3. Задайте одномерный массив из 123 случайных чисел.
//    Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// void CheckArray(int num, int[] arr)
// {
//     string flag = "No";
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(num == arr[i]){
//             flag = "Yes";
//             break;
//         }
//     }
//     Console.WriteLine(flag);
// }
//********************
// // 3. Задайте одномерный массив из 123 случайных чисел.
//    Найдите количество элементов массива, значения которых лежат в отрезке [10,99]

// int [] GetArray(int length)
// {
//     int [] result = new int [length];
//     for (int i = 0 ; i< length ; i++)
//     {
//         result[i]= new Random().Next(-120,120);
//     }
//     return result;
// }
// void PrintArray(int[] array)
// {
//     int length = array.Length;
//     for (int i=0; i<length-1; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write(array[length-1]);// пишем последний элемент без запятой на конце.
//     Console.WriteLine();
// }
// //PrintArray(GetArray(123));
// int [] array = GetArray(12);
// PrintArray(array);

// int count = 0;
// for (int i=0; i<12; i++){
//     if (array[i]<100 && array[i]>=10) count ++;
// }
// Console.WriteLine(count);
// //***************************************
//два метода мин и макс, задан массив, методы ищут соответственно мин элемент заданного массива
// и макс элемент заданного массива

int Max (int[] array) 
{  
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i]; 
    } 
    return max;      
} 
 
int Min (int[] array) 
{ 
    int min = array[0]; 
    for (int i=0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];    
    } 
    return min;  
} 
int[] array = new int[5] { 2, 3, 5, 6 , 8};
Console.WriteLine($" min = {Min(array)}");
Console.WriteLine($" max = {Max(array)}");
Console.WriteLine($" max - min = {Max(array)-Min(array)}");
//************************************************************
