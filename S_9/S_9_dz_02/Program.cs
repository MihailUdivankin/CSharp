// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке 
// от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30
int sum = 0;
int ValuesSet(int m, int n)
{
    if (m == n+1) return sum;
    sum += m;
    ValuesSet(m + 1, n); 
    return sum;
}
Console.Write(ValuesSet(1, 15));