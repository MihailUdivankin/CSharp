Console.Write("ВВедите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "миша")
{
    Console.WriteLine("Ура! Это же МИША!");
}
else
{
    Console.Write("Здравствуй, ");
    Console.WriteLine(username);
}
