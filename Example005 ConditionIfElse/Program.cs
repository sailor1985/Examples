Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "мама")

{
    Console.WriteLine("Да здравствует мама-самая гуманная мама в мире");
}
else
{
    Console.WriteLine("Привет,");
    Console.WriteLine(username);
}