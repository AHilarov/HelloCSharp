Console.WriteLine("What's your name?");
string UserName = Console.ReadLine();
if (UserName.ToLower == "alex")
{
Console.Write("Приветствую тебя, Alex!");
}
else
{
Console.Write("Hello, ");
Console.Write(UserName);
}