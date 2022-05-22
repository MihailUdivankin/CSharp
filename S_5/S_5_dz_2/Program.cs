//  Задача 2: Задайте одномерный массив, заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 67] -> 0
int [] GetArray(int length,int min, int max)
{
    int [] result = new int [length];
    for (int i = 0 ; i< length ; i++)
    {
        result[i]= new Random().Next(min,max);
    }
    return result;
}
void PrintArray(int[] array)
{
    int length = array.Length;
    for (int i=0; i<length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}
int SummNoCh(int[] array)
{
    int length = array.Length;
    int summ = 0;
    for (int i=0; i<length; i+=2)
    {
        summ = summ + array[i];
    }
    return summ;
}
int [] array = GetArray(16, -5, 10); //(длинна массива, мин значение рандома, макс значение рандома)
PrintArray(array);
Console.WriteLine(SummNoCh(array));

int [] array1 = new int[4] {3, 7, 23, 12};
PrintArray(array1);
Console.WriteLine(SummNoCh(array1));

int [] array2 = new int[4] {-4, -6, 4, 67};
PrintArray(array2);
Console.WriteLine(SummNoCh(array2));