// Виды методов:
// Вид 1 и 2 - void методы
// Вид 1: не принимают никаких аргументов, ничего не возвращают. 
// Ключевое слово - void. 
// Использование ( ) обязательно!
// Как вызывать: указать идентификатор этого метода и ()
// // // Вид 1. Описание ++++
void Method1()
{
    Console.WriteLine("Автор....");
}
// Вызов
Method1();
//*************************************************
// Вид 2: методы, которые могут принимать какие-то аргументы, 
// но в то же время ничего не возвращают.
// - Вызов функции - Method2( ). 
// - Ключевое слово void, идентификатор  Method2 и аргумент (string msg).
// - В этой программе можно использовать операторы и аргументы, 
//   которые были приняты.
// // // Вид2. Описание  ++++
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Вызов
Method2(msg: "Текст сообщения");
//************************************
// Описание Вид 2.1  ++++
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i ++;
    }
}
// Вызов
Method21(msg: "Текст", count: 4);
Method21 (count: 4, msg: "новый текст") ;
//****************************************************
// Вид 3: могут что-то возвращать, но не принимают никаких аргументов 
// - Пример – случайная генерация данных. 
// - Если метод что-то возвращает, то надо обязательно указать тип данных, 
//   значение которого мы ожидаем. 
// // // Вид 3. Описание   ++++
int Method3()
{
    return DateTime.Now.Year;
}
// Вызов
int year = Method3();
Console.WriteLine(year);
//********************************
// Вид 4: что-то принимают, что-то возвращают 
// для дальнейшей работы. 
// - Наиболее часто используется
// // // Вид4. Описание
// string Method4(int count, string text)
// {
//     int i = 0;
// 	string result = String.Empty;
// 	while (i < count)
// 	{
//         result = result + text;
//         i++;
// 	}
// 	return	result;
// }
string Method4(int count, string text)  //  ++++
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res) ;
//**********************************
//Цикл в цикле. Таблица умножения   +++++
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}
//******************************************
// Условие задачи: Дан текст. В тексте нужно все 
// пробелы заменить черточками, маленькие буквы 
// “к” заменить большими “К”, а большие “С” 
// заменить маленькими “с”.
string Replace(string text, char oldValue, char newValue) //  ++++
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text [i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
//*****************************************************************************
 
// Задача по упорядочиванию данных внутри массива посредством алгоритма сортировки методом 
// выбора (или методом МиниМакса).
// Допустим имеется какая-то последовательность чисел 6 8 3 2 1 4 5 7. 
// Задача - выбрать самый первый элемент и в оставшихся числах выбрать минимальное. 
// После того, как найден минимальный элемент, нужно поменять его местами с первым 
// элементом. То есть последовательность теперь будет 1 8 3 2 6 4 5 7. 
// Далее выбирается второй рабочий элемент (8) и он меняется местами с минимальным числом 
// из оставшихся, то есть последовательность будет 1 2 3 8 6 4 5 7. и т.д. 
// Таким образом, все числа должны быть в последовательном порядке 1 2 3 4 5 6 7 8.

// Сортировка одномерного массива
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 }; // ++++
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array [ i]} ");
    }
    Console.WriteLine() ;
}
void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1 ; i++)
        {
            int minPosition = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if(array[j] < array[minPosition]) minPosition = j;
            }
            int temporary = array[i];
            array[i] = array[minPosition];
            array[minPosition] = temporary;
        }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
//************************************************************ 
// Сортировка одномерного массива   +++++
// Адаптировать представленный код по сортировке одномерного массива так, чтобы упорядочивание 
// происходило в обратном порядке – от большего к меньшему
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array [ i]} ");
    }
    Console.WriteLine() ;
}
void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1 ; i++)
        {
            int maxPosition = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if(array[j] > array[maxPosition]) maxPosition = j;
            }
            int temporary = array[i];
            array[i] = array[maxPosition];
            array[maxPosition] = temporary;
        }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
//**********************************************