// Задача 1: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.
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

int[,] SelectionSortMaxToMin(int[,] arr)
{
    for (int k = 0; k < arr.GetLength(0); k++)
    {
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            for (int j = i + 1; j < arr.GetLength(1); j++)
            {
                if (arr[k, j] > arr[k, i])
                {
                    (arr[k, i], arr[k, j]) = (arr[k, j], arr[k, i]);
                }
            }
        }
    }
    return arr;
}

int[,] matrix = new int[4, 15];
FillArray(matrix, -10, 10);
PrintArray(matrix);
Console.WriteLine();

SelectionSortMaxToMin(matrix);
Console.WriteLine();
PrintArray(matrix);