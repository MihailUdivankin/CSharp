// Задача 3: Напишите программу, которая задаёт массив из 8 элементов 
// случайными числами и выводит их на экран. 
// Оформите заполнение массива и вывод в виде функции 
// (пригодится в следующих задачах)

void MassEight(int[] len)
{   
    for (int i = 0; i < len.Length; i++)
    {
        len[i] = new Random().Next(1,100); 
    }       
}
void PrintMassiv(int[] massiv)
{
    for(int j = 0; j < massiv.Length; j++)
    {
        Console.Write(massiv[j].ToString() + " ");
    } 
}
Console.WriteLine("Введите числовое значение длинны массива");
string isis=Console.ReadLine();
int iss = int.Parse(isis);
int[] arr = new int[iss];
MassEight(arr);
PrintMassiv(arr);

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