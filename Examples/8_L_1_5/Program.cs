Console.WriteLine("Введите число: ");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);
int b = 0-a;

//Console.WriteLine(a);
//Console.WriteLine(b);

while (b<(a+1))
{
    //Console.WriteLine(b);
    Console.Write($"{b} ");
    b=b+1;
}