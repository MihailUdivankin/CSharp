//  Задача 4: Напишите программу, которая будет создавать копию заданного двумерного массива 
//  с помощью поэлементного копирования.

void CopyArray (int[,] arr, int [,]arrCopy)
{
    for(int i=0; i<arr.GetLength(0);i++)
    {
        for(int j=0; j<arr.GetLength(1);j++)
        {
            arrCopy[i,j] = arr[i,j];
        }
    }
}

void PrintArray (int[,] arr)
{
    for(int i=0; i<arr.GetLength(0);i++)
    {
        Console.Write("        ");
        for(int j=0; j<arr.GetLength(1);j++)
        {
            Console.Write($" {arr[i,j]} ");
        }
        Console.WriteLine();        
    }    
}

int[,] array1 = new int [2,5] {{3, 7 , 8, 2, 12},{9, 6 , 5, 4, 1}};
int[,] array2 = new int [2,5] {{0, 0 , 0, 0, 0},{0, 0 , 0, 0, 0}};

Console.WriteLine("array1 = ");
PrintArray(array1);

Console.WriteLine("array2 = ");
PrintArray(array2);

CopyArray(array1, array2);
Console.WriteLine("Результат копирования массива array1  в array2");
Console.WriteLine("array1 = ");
PrintArray(array1);

Console.WriteLine("array2 = ");
PrintArray(array2);