Console.Write("Введите имя пользователя ");
string userName = Console.ReadLine();

if (userName.ToLower() == "lex") {
    Console.Write("Приветствую Вас сударь  " + userName);
}
else {
Console.Write("Привет " + userName);
}