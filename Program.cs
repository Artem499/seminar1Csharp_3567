Console.WriteLine("input your name, ");
string username = Console.ReadLine();
Console.WriteLine("Hello!");
Console.WriteLine(username);

int numberA = 3;
int numberB = 5;
int result = numberA + numberB;
Console.WriteLine(result);

int numberC = new Random().Next(1, 10); // 1, 2, 3 ... 9
int numberD = new Random().Next(1, 10); //100, 101 ... 999
int result = numberD / numberC;
Console.WriteLine(result);
