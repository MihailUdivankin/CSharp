Console.WriteLine("Введите число дня недели: ");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);

if(a == 1)
{
   Console.WriteLine("Понедельник"); 
}
if(a == 2)
{
   Console.WriteLine("Вт"); 
}
if(a == 3)
{
   Console.WriteLine("Ср"); 
}
if(a == 4)
{
   Console.WriteLine("Чт"); 
}
if(a == 5)
{
   Console.WriteLine("Пят"); 
}if(a == 6)
{
   Console.WriteLine("Сб"); 
}
if(a == 7)
{
   Console.WriteLine("Вс"); 
}