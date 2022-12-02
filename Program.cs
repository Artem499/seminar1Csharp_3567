Console.WriteLine("input your name, ");
string username = Console.ReadLine();
Console.WriteLine("Hello!");
Console.WriteLine(username);

int numberA = 3;
int numberB = 5;
int result = numberA + numberB;
Console.WriteLine(result);

int numberC = new Random().Next(1, 10); // 1, 2, 3 ... 9
int numberD = new Random().Next(1, 10); // 1, 2, 3 ... 9
int result2 = numberD / numberC;
Console.WriteLine(result2);

int numberE = new Random().Next(1, 10);
Console.WriteLine(numberE);
int numberF = new Random().Next(1, 10);
Console.WriteLine(numberF);
int result3 = numberE + numberF;
Console.WriteLine(result3);
