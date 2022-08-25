Console.Clear();
Console.Write("Добрый день! Введите своё имя, пожалуйста: ");
string username = Console.ReadLine();

if(username.ToLower() == "наташа")
{
    Console.WriteLine("Ура, это же Моя Любимка!!!");
}
else
{
    Console.WriteLine("Привет, " + username);
}
