// Напишите программу, которая на вход принимает значение, 
// а на выходе показывает обратное значение
// 1 -> 1  ; 2 -> 0.5  ; 0.25 -> 4

Console.WriteLine("Введите число: ");
string s_a = Console.ReadLine();
decimal a = int.Parse(s_a);

decimal x = (1 / a);
Console.WriteLine(x);