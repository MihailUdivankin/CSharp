//  Задача 3: Задайте двумерный массив из целых чисел. 
//  Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
void ArithmeticMeanOfColumn(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double arithmeticMean = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {            
            arithmeticMean = arithmeticMean + arr[i, j];
        } 
        arithmeticMean = arithmeticMean/(arr.GetLength(0));
        Console.WriteLine($"Среднеарифмитическое стобца {j+1} = {Math.Round(arithmeticMean,2)}");       
    }
    Console.WriteLine();
}

Console.Write("Введите число строк m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов n = ");
int n = int.Parse(Console.ReadLine());

int [,] array = FillArray(m, n, 1, 10); // (row, column, min, max)
PrintArray(array);
ArithmeticMeanOfColumn(array);