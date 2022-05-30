//  Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5  7    -2   -0,2
// 1   -3,3   8   -9,9
// 8    7,8  -7,1  9

double [,] GetArray(int row, int column,int min, int max)
{
    double [,] result = new double [row, column];
    for (int i = 0 ; i< row ; i++)
    {
        for (int j = 0 ; j< column ; j++)
        {
            double desdrob = new Random().Next(min,max);
            result[i,j]= desdrob/10; // при 10 - один знак после запятой; при 100 - два знака и т.д.
        }                
    }
    return result;
}

void PrintArray(double[,] array)
{    
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.Write("Введите число строк m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов n = ");
int n = int.Parse(Console.ReadLine());
double [,] array = GetArray(m, n, -100, 100); // при -100 и 100 и коэф. 10 в методе числа будут от -10 до 9,9
PrintArray(array);
Console.WriteLine();
//GetArray(m, n, -100, 100);//(строк, столбцов, мин значение рандома, макс значение рандома)
