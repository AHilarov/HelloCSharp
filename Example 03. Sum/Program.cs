// суммирование двух чисел
//int Number1 = 100;
//int Number2 = 13;
//int Rusult = Number1 + Number2;
//Console.WriteLine(Rusult);

// суммирование 2 случайных чисел от 0 до 9
Console.WriteLine("Суммирование 2 случайных чисел от 0 до 9");
int NumberA = new Random().Next(1, 10); // 0 1 2 ... 9
//Console.WriteLine(NumberA);
int NumberB = new Random().Next(1, 10); // 0 1 2 ... 9
//Console.WriteLine(NumberB);
int Rusult2 = NumberA + NumberB;
Console.Write(NumberA);
Console.Write(" + ");
Console.Write(NumberB);
Console.Write(" = ");
Console.Write(Rusult2);
