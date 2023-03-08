Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "кристина")
{
    Console.WriteLine("Ура, это же Кристина!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
