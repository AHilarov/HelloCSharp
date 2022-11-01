// это правильный код, из лекции
//Console.WriteLine("What's your name?");
//string UserName = Console.ReadLine();
//if (UserName.ToLower == "alex")
//{
//Console.Write("Приветствую тебя, Alex!");
//}
//else
//{
//Console.Write("Hello, ");
//Console.Write(UserName);
//}


//Это мой апгрейт кода
Console.WriteLine("What's your name?");
string UserName = Console.ReadLine();
bool alex = false;

//Console.WriteLine(alex);
if (UserName == "Alex") alex = true;
if (UserName == "ALEX") alex = true;
if (UserName == "alex") alex = true;
if (UserName == "Aleks") alex = true;
if (UserName == "aleks") alex = true;
if (UserName == "алекс") alex = true;
if (UserName == "Алекс") alex = true;
if (UserName == "АЛЕКС") alex = true;


if (alex == true)
{
Console.Write("Приветствую тебя, Alex!");
}
else
{
Console.Write("Hello, ");
Console.Write(UserName);
}
