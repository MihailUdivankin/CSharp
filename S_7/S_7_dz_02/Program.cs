//  Задача 2: Напишите программу, которая на вход принимает позиции элемента 
//  в двумерном массиве, и возвращает значение этого элемента или же указание, 
//  что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]}  ");
        } 
        Console.WriteLine();       
    }
    Console.WriteLine();
}
int[,] FillArray(int row, int column, int min, int max)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {   
        for (int j = 0; j < column; j++)
        {
             arr[i, j] = new Random().Next(min, max);
        }        
    }
    return arr;
}
void  SearchElement (int[,] arr)
{
    Console.Write("введите позицию интересующей вас строки  ");
    int row = int.Parse(Console.ReadLine());

    Console.Write("введите позицию интересующего вас столбца  ");
    int column = int.Parse(Console.ReadLine());

    if(row>arr.GetLength(0)|| row <1 || column <1 || column > arr.GetLength(1))
    {
        Console.WriteLine($"Элемента массива с позицией ({row},{column}) не существует");
    }
    else 
    {
        string text = "Значение элемента массива с позицией ";
        Console.WriteLine($"{text}({row},{column}) = {arr[row-1, column-1]}");
    }
}

Console.Write("Введите число строк m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов n = ");
int n = int.Parse(Console.ReadLine());

int [,] array = FillArray(m, n, 1, 10); // (row, column, min, max)
PrintArray(array);
SearchElement (array);
Console.WriteLine();
SearchElement (array);
Console.WriteLine();
SearchElement (array);