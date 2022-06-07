// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
//
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],3} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] arr, int from, int to)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
}

void SumArray(int[,] matr)
{
    int[] minSumArr = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
            minSumArr[i] = sum;
        }
    }
    int min = 0;
    int minSum = minSumArr[0];
    for (int i = 0; i < minSumArr.Length; i++)
    {
        if (minSum > minSumArr[i]) 
        {
            minSum = minSumArr[i]; 
            min = i;
        }
        Console.Write($"{minSumArr[i]} ");
    }
    Console.WriteLine();
    Console.WriteLine($"Строка с наименьшей суммой элементов ({minSum}) в {min+1} строке");
}

int[,] matrix = new int[5, 7];
FillArray(matrix, 1, 5);
PrintArray(matrix);
Console.WriteLine();
SumArray(matrix);