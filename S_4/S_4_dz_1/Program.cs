//  Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation(int a, int b)  // ++++
{
    int all =a;
    for(int i=1; i<b; i++)
    {
        all *= a;
        //all = all * a;
    }
    return all;
}
Console.WriteLine(Exponentiation(3,5));
Console.WriteLine(Exponentiation(2,4));
Console.WriteLine(Exponentiation(2,5));