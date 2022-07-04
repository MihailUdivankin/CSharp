// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectInArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
string[] array1 = new string [4] {"hello", "2", "world", ":-)"}; 
string[] array10 = new string[array1.Length];
string[] array2 = new string [4] {"1234", "1567", "-2", "computer science"}; 
string[] array20 = new string[array2.Length];
string[] array3 = new string [3] {"Russia", "Denmark", "Kazan"}; 
string[] array30 = new string[array3.Length];
SelectInArray(array1,array10);
SelectInArray(array2,array20);
SelectInArray(array3,array30);
PrintArray(array10);
PrintArray(array20);
PrintArray(array30);