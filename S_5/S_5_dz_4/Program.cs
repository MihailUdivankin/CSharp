// Задача 4: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void PrintMassiv(int[] massiv)
{
    for(int j = 0; j < massiv.Length; j++)
    {
        Console.Write($"{massiv[j]}  ");
    } 
}

void UmnozhAndCreat(int[] arr)
{
    int size = arr.Length;
    int size_new = 0;
    if(size % 2 == 0) 
    {
        Console.WriteLine("четное количество элементов массива");
        size_new = size / 2;
    }
    else 
    {
        Console.WriteLine("НЕ четное количество элементов массива");
        size_new = size / 2 +1;
    }
    int[] arr03 = new int[size_new];
    int temp = 0;
    for(int i = 0; i < size/2; i++)
    {
        temp = arr[i]* arr[(size-1-i)];
        arr03[i] = temp;
        Console.Write($"{arr03[i]} ");            
    }
    if (size_new>size/2)
    {
        temp = arr[size/2];
        arr03[size_new-1] = temp;
        Console.Write($"{arr03[size_new-1]} "); 
    }    
}

int[] arr1 = new int[4] {6, 7, 3, 6};
PrintMassiv(arr1);
Console.WriteLine();
UmnozhAndCreat(arr1);
Console.WriteLine();
Console.WriteLine();

int[] arr2 = new int[6] {1, 2, 3, 4, 5, 6};
PrintMassiv(arr2);
Console.WriteLine();
UmnozhAndCreat(arr2);
Console.WriteLine();
Console.WriteLine();

int[] arr3 = new int[5] {1, 2, 3, 4, 5};
PrintMassiv(arr3);
Console.WriteLine();
UmnozhAndCreat(arr3);
Console.WriteLine();
Console.WriteLine();
