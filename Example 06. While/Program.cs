Console.Clear();

int x1 =50, y1 = 0,
    x2 = 0, y2 = 20,
    x3 = 100, y3 = 20;
Console.SetCursorPosition(x1, y1);
Console.WriteLine("*");
Console.SetCursorPosition(x2, y2);
Console.WriteLine("*");
Console.SetCursorPosition(x3, y3);
Console.WriteLine("*");

int x = x1, y = y1;
int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0, 3);   // [0, 3)  0, 1, 2 
    if(what == 0)
    {
        x = (x + x1) / 2;
        y = (y + y1) / 2;
    }
    
    if(what == 1)
    {
        x = (x + x2) / 2;
        y = (y + y2) / 2;
    }
    
    if(what == 2)
    {
        x = (x + x3) / 2;
        y = (y + y3) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count = count + 1;  //тоже самое, что count +=1 тоже самое, что count = count + 1
    //Console.WriteLine("упражнение окончил");
}
