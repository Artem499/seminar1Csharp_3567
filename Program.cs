Console.WriteLine("input your name, ");
string username = Console.ReadLine();
Console.WriteLine("Hello!");
Console.WriteLine(username);

int numberA = 3;
int numberB = 5;
int result = numberA + numberB;
Console.WriteLine(result);

int numberA = new Random().Next(1, 10); // 1, 2, 3 ... 9
int numberB = new Random().Next(100, 1000); //100, 101 ... 999
int result = numberB / numberA;
Console.WriteLine(result);
